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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appleOrchardDataSet.Apples". При необходимости она может быть перемещена или удалена.
            this.applesTableAdapter.Fill(this.appleOrchardDataSet.Apples);
        }

        private void appleOrchardDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void applesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}