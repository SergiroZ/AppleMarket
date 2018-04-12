using System;
using System.Data;
using System.Windows.Forms;

namespace AppleMarket
{
    public partial class NewSort : Form
    {
        private DataRow myNewRow;

        public NewSort()
        {
            InitializeComponent();
        }

        private void tbSortName_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbTaste_TextChanged(object sender, EventArgs e)
        {
        }

        private void CancelSort_Click(object sender, EventArgs e)
        {
        }

        private void SaveSort_Click(object sender, EventArgs e)
        {
            if (Owner is DataEdit main)
            {
                main.appleOrchardDataSet.AppleSorts.Rows.Find(0).Delete();
                myNewRow = main.appleOrchardDataSet.AppleSorts.NewRow();
                myNewRow["SortName"] = tbSortName.Text;
                myNewRow["Taste"] = tbTaste.Text;
                main.appleOrchardDataSet.AppleSorts.Rows.Add(myNewRow);
                main.appleSortsTableAdapter.Update(main.appleOrchardDataSet.AppleSorts);
                main.dialogResultNewSort = DialogResult.OK;
            }
        }
    }
}