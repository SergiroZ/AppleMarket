using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // *****************************************
            //  dataset - appleOrchardDataSet.Apples
            //  dataadapter - applesTableAdapter
            this.applesTableAdapter.Fill(this.appleOrchardDataSet.Apples);
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
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // добавляем новую строку в Apples из appleOrchardDataSet
            DataRow row = appleOrchardDataSet.Apples.NewRow();
            appleOrchardDataSet.Apples.Rows.Add(row);
            DataEdit dataEdit = new DataEdit
            {
                Owner = this
            };

            //dataGridView1.Rows[ind].Cells[0].Selected = true;
            //dataGridView1.CurrentCell = dataGridView1.Rows[ind].Cells[0];
            dataEdit.ShowDialog();
        }

        private void buttonDell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);

                if (--ind < 0) ind = 0;

                if (dataGridView1.RowCount > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[ind].Cells[0].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[ind].Cells[0];
                }
            }
        }
    }
}