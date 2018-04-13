using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace AppleMarket
{
    public partial class Form1 : Form
    {
        private DialogResult dialogResult;
        public int CntrIndex = 1;

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Excel files(*.xlsx)|*.xlsx|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            this.appleSortsRelativeTableAdapter.Fill(appleOrchardDataSet.AppleSortsRelative);
            // *****************************************
            //  DataSet - appleOrchardDataSet.Apples
            //          - appleOrchardDataSet.AppleSort
            //  DataAdapter - applesTableAdapter
            // *****************************************
            this.applesTableAdapter.Fill(appleOrchardDataSet.Apples);
        }

        private void appleOrchardDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void applesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                DataEdit dataEdit = new DataEdit
                {
                    Owner = this
                };
                dataEdit.ShowDialog();
                dataGridView1.Show();

                int keyToEdit = (int)dataGridView1.SelectedCells[0].Value;
                int sizeToEdit = (int)dataGridView1.SelectedCells[1].Value;

                appleOrchardDataSet.Apples.Rows.Find(keyToEdit).SetField("Size", sizeToEdit);
                appleOrchardDataSet.Apples.Rows.Find(keyToEdit).SetField("SortId", CntrIndex);
                applesTableAdapter.Update(appleOrchardDataSet.Apples);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // добавляем новую строку в Apples и
            // AppleSortsRelative из appleOrchardDataSet
            DataRow row = appleOrchardDataSet.Apples.NewRow(),
                rowrel = appleOrchardDataSet.AppleSortsRelative.NewRow();
            if (dataGridView1.Rows.Count != 0)
            {
                rowrel["SortName"] = dataGridView1.Rows[
                    dataGridView1.Rows.Count - 1].Cells["SortName"].Value;
                rowrel["Taste"] = dataGridView1.Rows[
                    dataGridView1.Rows.Count - 1].Cells["Taste"].Value;
            }

            appleOrchardDataSet.AppleSortsRelative.Rows.Add(rowrel);

            DataEdit dataEdit = new DataEdit
            {
                Owner = this
            };

            if (dataGridView1.Rows.Count == 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            else
                dataGridView1.CurrentCell = dataGridView1.Rows[
                    dataGridView1.Rows.Count - 1].Cells[0];

            dialogResult = dataEdit.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }

            if (dialogResult == DialogResult.OK)
            {
                DataRowView drv = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                var myNewRow = appleOrchardDataSet.Apples.NewRow();
                myNewRow["Size"] = drv["Size"];
                myNewRow["SortID"] = CntrIndex;
                appleOrchardDataSet.Apples.Rows.Add(myNewRow);
                applesTableAdapter.Update(appleOrchardDataSet.Apples);
                this.appleSortsRelativeTableAdapter.Fill(appleOrchardDataSet.AppleSortsRelative);
            }

            if (dataGridView1.RowCount > 0)
            {
                int ind = dataGridView1.RowCount - 1;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[ind].Cells[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[ind].Cells[0];
            }
        }

        private void buttonDell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int indexToDell = dataGridView1.SelectedCells[0].RowIndex;
                int keyToDell = (int)dataGridView1.SelectedCells[0].Value;
                appleOrchardDataSet.Apples.Rows.Find(keyToDell).Delete();

                dataGridView1.Rows.RemoveAt(indexToDell);
                applesTableAdapter.Update(appleOrchardDataSet.Apples);

                if (--indexToDell < 0) indexToDell = 0;

                if (dataGridView1.RowCount > 0)
                {
                    dataGridView1.ClearSelection();
                    var id = dataGridView1.Rows[indexToDell].Cells["Id"];
                    id.Selected = true;
                    dataGridView1.CurrentCell = id;
                }
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;

            // сохраняем данные в .exl файл

            #region Export to Excel with format

            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Value = 20;

            Excel.Application exApp = new Excel.Application();
            progressBar1.Value = 50;
            ExportToExcel(exApp, dataGridView1, "Отчет").SaveAs(filename);
            progressBar1.Value = 100;
            MessageBox.Show("\tВыгрузка завершена.\t");
            progressBar1.Visible = false;
            exApp.Quit();

            #endregion Export to Excel with format
        }

        public Worksheet ExportToExcel(_Application app, DataGridView gridview, string SheetName)
        {
            // see the excel sheet behind the program
            //app.Visible = true;
            app.Workbooks.Add();
            Worksheet worksheet = (Worksheet)app.ActiveSheet; ;

            // changing the name of active sheet worksheet.
            Name = SheetName;
            // storing header part in Excel
            for (int i = 1; i < gridview.Columns.Count + 1; i++)
            {
                var clmn = gridview.Columns[i - 1];
                worksheet.Cells[1, i] = clmn.HeaderText;
                worksheet.Cells[1, i].ColumnWidth = clmn.Width / 6.5;
                //жирность
                (worksheet.Cells[1, i] as Range).Font.Bold = true;
                //размер шрифта
                (worksheet.Cells[1, i] as Range).Font.Size = 11;
                //название шрифта
                (worksheet.Cells[1, i] as Range).Font.Name = "Times New Roman";
                //стиль границы
                (worksheet.Cells[1, i] as Range).Borders[(XlBordersIndex)Constants.xlTop].LineStyle = XlLineStyle.xlContinuous;
                (worksheet.Cells[1, i] as Range).Borders[(XlBordersIndex)Constants.xlBottom].LineStyle = XlLineStyle.xlDouble;
                (worksheet.Cells[1, i] as Range).Borders[(XlBordersIndex)Constants.xlLeft].LineStyle = XlLineStyle.xlContinuous;
                (worksheet.Cells[1, i] as Range).Borders[(XlBordersIndex)Constants.xlRight].LineStyle = XlLineStyle.xlContinuous;
                //толщина границы
                (worksheet.Cells[1, i] as Range).Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
                //выравнивание по горизонтали
                (worksheet.Cells[1, i] as Range).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                //выравнивание по вертикали
                (worksheet.Cells[1, i] as Range).VerticalAlignment = XlVAlign.xlVAlignCenter;
                //заливка ячеек
                (worksheet.Cells[1, i] as Range).Interior.Color = System.Drawing.Color.LightGray;
            }

            // storing Each row and column value to excel sheet
            for (int i = 0; i < gridview.Rows.Count - 1; i++)
            {
                for (int j = 0; j < gridview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gridview.Rows[i].Cells[j].Value;
                }
            }
            return worksheet;
        }
    }
}