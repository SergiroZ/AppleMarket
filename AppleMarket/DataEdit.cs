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
    public partial class DataEdit : Form
    {
        private int indexParentView = 0;

        public DataEdit()
        {
            InitializeComponent();
        }

        #region textBox_Size

        private void textBox_Size_TextChanged(object sender, EventArgs e)
        {
            // при редактировании изменить пустой textbox на 0
            if (textBox_Size.Text == String.Empty)
            {
                int i = 0;
                textBox_Size.Text = i.ToString();
            }
        }

        private void textBox_Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // вводятся только цифры и клавиша BackSpace
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // по клавише TAB или Enter изменить пустой textbox на 0
            if ((keyData == Keys.Tab || keyData == Keys.Enter) && string.IsNullOrEmpty(textBox_Size.Text))
            {
                int i = 0;
                textBox_Size.Text = i.ToString();

                // убрать код выше и будет осуществляться
                // запрет на переход по TAB в другое поле
                //return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox_Sort.Focus();
            }
        }

        #endregion textBox_Size

        private void bott_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void butt_Save_Click(object sender, EventArgs e)
        {
            //*****************
            //SqlConnection con = new SqlConnection(constr);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM tProcedures", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //datagridview1.DataSource = dt;
            //*****************
            //DataRowView drv = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            //DataRow[] rowsToUpdate = new DataRow[] { drv.Row };

            //DataTable changedData = dt.GetChanges();
            //da.update(changedData);
            if (textBox_Size.Text == String.Empty)
            {
                string message = "Требуется ввести значение размера яблока.";
                string caption = "Ошибка ввода.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }
            else
            {
                if (Owner is Form1 main)
                {
                    try
                    {
                        DataGridViewTextBoxCell sizeCell =
                        (DataGridViewTextBoxCell)main.dataGridView1.
                        Rows[indexParentView].Cells["Size"];
                        sizeCell.Value = Convert.ToInt32(textBox_Size.Text);

                        DataGridViewTextBoxCell sortNameCell =
                            (DataGridViewTextBoxCell)main.dataGridView1.
                            Rows[indexParentView].Cells["SortName"];
                        sortNameCell.Value = comboBox_Sort.Text;

                        DataGridViewTextBoxCell tasteCell =
                            (DataGridViewTextBoxCell)main.dataGridView1.
                            Rows[indexParentView].Cells["Taste"];
                        tasteCell.Value = label_Taste.Text;
                    }
                    catch (Exception)
                    {
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void DataEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу
            // "appleOrchardDataSet.AppleSorts".
            // При необходимости она может быть перемещена или удалена.
            this.appleSortsTableAdapter.Fill(this.appleOrchardDataSet.AppleSorts);
            label_Taste.Text = appleOrchardDataSet.AppleSorts.Rows[0]["Taste"].ToString();

            if (Owner is Form1 main)
            {
                try
                {
                    indexParentView = main.dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewTextBoxCell sizeCell =
                    (DataGridViewTextBoxCell)main.dataGridView1.
                    Rows[indexParentView].Cells["Size"];
                    textBox_Size.Text = sizeCell.Value.ToString();

                    DataGridViewTextBoxCell sortNameCell =
                        (DataGridViewTextBoxCell)main.dataGridView1.
                        Rows[indexParentView].Cells["SortName"];
                    comboBox_Sort.Text = sortNameCell.Value.ToString();

                    DataGridViewTextBoxCell tasteCell =
                        (DataGridViewTextBoxCell)main.dataGridView1.
                        Rows[indexParentView].Cells["Taste"];
                    label_Taste.Text = tasteCell.Value.ToString();
                }
                catch (Exception)
                {
                }
            }
        }

        private void comboBox_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label_Taste.Text = appleOrchardDataSet.AppleSorts.
                    Rows[comboBox_Sort.SelectedIndex]["Taste"].ToString();
            }
            catch (Exception)
            {
            }
        }

        private void appleSortsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}