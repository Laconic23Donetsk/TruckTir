﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PartsApp.Models;

namespace PartsApp
{
    /*Задания*/
    //Нумерация строк.
    //Вывод общего кол-ва строк в таблице.
    public partial class ContragentOperationsInfoForm : Form
    {
        /// <summary>
        /// Тип контрагента
        /// </summary>
        Type _contragType;
        /// <summary>
        /// Ключ - Id контрагента. Значение - список операций данного контрагента.
        /// </summary>
        Dictionary<int, List<IOperation>> _contragentsOperations;


        public ContragentOperationsInfoForm(Type contragType)
        {
            InitializeComponent();

            _contragType = contragType;
            _contragentsOperations = new Dictionary<int, List<IOperation>>();
        }//


        private void ContragentOperationsInfoForm_Load(object sender, EventArgs e)
        {            
            //Стартовая инициализация формы.
            FormInitialize();
        }//ContragentOperationsInfoForm_Load

        /// <summary>
        /// Метод стартовой инициализации формы.
        /// </summary>
        private void FormInitialize()
        {            
            //Заполняем таблицы инф-цией в зависимости от типа операции.
            List<IContragent> contragList = null;
            if (_contragType == typeof(Supplier))
            {
                contragList = PartsDAL.FindSuppliers().OrderBy(s => s.ContragentName).ToList();
                ContragentsGroupBox.Text = "Поставщики";
                OperationsGroupBox.Text = "Поставки";
                OperationDetailsGroupBox.Text = "Доп. инф-ция по поставкам.";
            }//if
            else
            {
                contragList = PartsDAL.FindCustomers().OrderBy(s => s.ContragentName).ToList();
                ContragentsGroupBox.Text = "Покупатели";
                OperationsGroupBox.Text = "Покупки";
                OperationDetailsGroupBox.Text = "Доп. инф-ция по покупкам.";
            }//else            

            //Заполняем лист контрагентами.
            foreach (IContragent contrag in contragList)
            {
                ListViewItem item = new ListViewItem(contrag.ContragentName );
                item.SubItems.Add(contrag.Balance == null ? null : ((double)contrag.Balance).ToString("0.00"));
                item.Tag = contrag;
                ContragentsListView.Items.Add(item);                
            }//foreach
            
        }//FormInitialize

        private void ContragentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContragentsListView.SelectedItems.Count != 0)
            {
                //int contragId = (int)ContragentsListBox.SelectedValue;
                int contragId = (ContragentsListView.SelectedItems[0].Tag as IContragent).ContragentId;

                //Если инф-ции об операциях данного контрагента ещё нет в коллекции, находим её в базе и добавляем в коллекцию.
                List<IOperation> operList;
                if (_contragentsOperations.TryGetValue(contragId, out operList) == false)
                {
                    operList = (_contragType == typeof(Supplier)) ? PartsDAL.FindPurchases(contragId, null) : PartsDAL.FindSales(contragId, null);
                    _contragentsOperations.Add(contragId, operList);//добавляем в коллекцию.                
                }//if

                FillTheOperationsInfoDGV(operList); //Заполняем таблицу Операций.
            }//if
        }//ContragentsListBox_SelectedIndexChanged

        private void ContragentsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Если ПКМ по выделенному объекту, выводим контекстное меню.
            if (e.Button == MouseButtons.Right)
            {
                Rectangle rect = ContragentsListView.GetItemRect(ContragentsListView.SelectedIndices[0]);
                rect.Y += ContragentsGroupBox.Location.Y;

                if (e.Y >= rect.Top && e.Y <= rect.Bottom)
                    editContragentContextMenuStrip.Show(ContragentsListView, e.Location, ToolStripDropDownDirection.BelowRight);
            }//if
        }//ContragentsListBox_MouseDown

        private void EditContragentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IContragent contragent = ContragentsListView.SelectedItems[0] as IContragent;
            contragent = (contragent is Supplier) ? PartsDAL.FindSuppliers(contragent.ContragentId) : PartsDAL.FindCustomers(contragent.ContragentId);
            //Передаём в форму 'свежую'инф-цию из базы, на случай если она обновилась.
            new AddContragentForm(contragent).Show();
        }//EditContragentToolStripMenuItem_Click


        private void OperationsInfoDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Если ПКМ по ячейке столбца 'Комментарий', выводи контекстное меню.
            if (e.Button == MouseButtons.Right && e.ColumnIndex == DescriptionCol.Index)
            {
                Rectangle rect = OperationsInfoDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point loc = new Point(rect.Left + e.X, rect.Top + e.Y);
                editOperDescriptContextMenuStrip.Show(OperationsInfoDGV, loc, ToolStripDropDownDirection.BelowRight);
                OperationsInfoDGV.Rows[e.RowIndex].Cells[DescriptionCol.Index].Selected = true;
            }//if
        }//OperationsInfoDGV_CellMouseClick

        private void editOperDescriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Открываем ячейку для редактирования. (Вся строка становится не readonly)
            DataGridViewCell cell = OperationsInfoDGV.SelectedRows[0].Cells[DescriptionCol.Index];
            cell.ReadOnly = false;
            OperationsInfoDGV.BeginEdit(false);  //Активируем для редактирования
        }//editOperDescriptToolStripMenuItem_Click

        private void OperationsInfoDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Делаем недоступными для редактирования все ячейки столбца 'Комментарий'.
            OperationsInfoDGV.Columns[DescriptionCol.Index].ReadOnly = true;

            //Обновляем запись в базе.
            DataGridViewCell cell = OperationsInfoDGV[e.ColumnIndex, e.RowIndex];
            int operId = (int)OperationsInfoDGV[OperationIdCol.Index, e.RowIndex].Value;
            string descr = (cell.Value == null || String.IsNullOrWhiteSpace(cell.Value.ToString())) ? null : cell.Value.ToString().Trim();
            try
            {
                Cursor = Cursors.WaitCursor;
                if (_contragType == typeof(Supplier))
                    PartsDAL.UpdatePurchase(operId, descr);
                else
                    PartsDAL.UpdateSale(operId, descr);

                (cell.OwningRow.Tag as IOperation).Description = descr;
                Cursor = Cursors.Default;
            }//try
            catch
            {
                MessageBox.Show("Не удалось редактировать запись. Попробуйте ещё раз.");
                cell.Value = (cell.OwningRow.Tag as IOperation).Description;
            }//catch
        }//OperationsInfoDGV_CellEndEdit


        /// <summary>
        /// Заполняет таблицу Операций данными из переданного списка.
        /// </summary>
        /// <param name="operationsList">Список операций для заполнения.</param>
        private void FillTheOperationsInfoDGV(List<IOperation> operationsList)
        {
            OperationsInfoDGV.Rows.Clear(); //Очищаем таблицу операций от старых данных.

            foreach (IOperation oper in operationsList)
            {
                OperationsInfoDGV.SelectionChanged -= OperationsInfoDGV_SelectionChanged; //Отключаем вызов события, т.к. оно инициируется сразу при добавлении строки в таблицу, что вызывает ошибку выполнения.
                int rowIndx = OperationsInfoDGV.Rows.Add();                
                DataGridViewRow row = OperationsInfoDGV.Rows[rowIndx];

                row.Tag = oper;
                row.Cells[OperationIdCol.Index].Value = oper.OperationId;
                row.Cells[DateCol.Index].Value        = oper.OperationDate;
                row.Cells[EmployeeCol.Index].Value    = (oper.Employee != null) ? oper.Employee.GetShortFullName() : null;
                row.Cells[ContragentEmployeeCol.Index].Value = oper.ContragentEmployee;
                row.Cells[DescriptionCol.Index].Value = oper.Description;
                row.Cells[TotalSumCol.Index].Value    = oper.OperationDetailsList.Sum(od => od.Sum);

                OperationsInfoDGV.ClearSelection();
                OperationsInfoDGV.SelectionChanged += OperationsInfoDGV_SelectionChanged;
            }//foreach
            
        }//FillTheOperationsInfoDGV

        /// <summary>
        /// Выводим доп. инф-цию по выбранной операции.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationsInfoDGV_SelectionChanged(object sender, EventArgs e)
        {
            OperationDetailsDGV.Rows.Clear(); //Очищаем таблицу доп. инф-ции от старых данных.
            //Если есть выбранная строка.
            if (OperationsInfoDGV.SelectedRows.Count != 0)
            {
                int operId    = (int)OperationsInfoDGV.SelectedRows[0].Cells[OperationIdCol.Index].Value; //Находим Id выбранной операции.                
                int contragId = (ContragentsListView.SelectedItems[0].Tag as IContragent).ContragentId;
                IOperation oper = _contragentsOperations[contragId].First(op => op.OperationId == operId); //Находим нужную операцию
                
                //Выводим инф-цию в таблицу доп. инф-ции по данной операции.
                FillTheOperationDetailsDGV(oper.OperationDetailsList);
            }//if
        }//OperationsInfoDGV_SelectionChanged

        /// <summary>
        /// Заполняет таблицу доп. инф-ции по Операции данными из переданного списка.
        /// </summary>
        /// <param name="operDetList">Список операций для заполнения.</param>
        private void FillTheOperationDetailsDGV(IList<OperationDetails> operDetList)
        {            
            foreach (OperationDetails operDet in operDetList)
            {
                int rowIndx = OperationDetailsDGV.Rows.Add();
                DataGridViewRow row = OperationDetailsDGV.Rows[rowIndx];

                row.Cells[ManufacturerCol.Index].Value  = operDet.SparePart.Manufacturer;
                row.Cells[ArticulCol.Index].Value       = operDet.SparePart.Articul;
                row.Cells[TitleCol.Index].Value         = operDet.SparePart.Title;
                row.Cells[MeasureUnitCol.Index].Value   = operDet.SparePart.MeasureUnit;
                row.Cells[CountCol.Index].Value         = operDet.Count;
                row.Cells[PriceCol.Index].Value         = operDet.Price;
                row.Cells[SumCol.Index].Value           = operDet.Count * operDet.Price;
            }//foreach                          

        }//FillTheOperationDetailsDGV

        

        

        

       

        

        



    }//ContragentOperationsInfoForm

}//namespace

/*Будущие задачи*/
//Сделать выбор периода за кот. ищется инф-ция.