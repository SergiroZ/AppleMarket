using System;
using System.Data;
using System.Windows.Forms;

namespace AppleMarket
{
    public partial class Form1 : Form
    {
        private DialogResult dialogResult;
        public int CntrIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.appleSortsRelativeTableAdapter.Fill(appleOrchardDataSet.AppleSortsRelative);
            // *****************************************
            //  dataset - appleOrchardDataSet.Apples
            //  dataadapter - applesTableAdapter
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

            SaveDataToDB(dialogResult);

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

                if (--indexToDell < 0) indexToDell = 0;

                if (dataGridView1.RowCount > 0)
                {
                    dataGridView1.ClearSelection();
                    var id = dataGridView1.Rows[indexToDell].Cells["Id"];
                    id.Selected = true;
                    dataGridView1.CurrentCell = id;

                    applesTableAdapter.Update(appleOrchardDataSet.Apples);
                }
            }
        }

        private void SaveDataToDB(DialogResult dialogResult)
        {
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
            }
        }
    }
}