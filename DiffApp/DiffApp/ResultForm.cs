using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffApp
{
    public partial class ResultForm : Form
    {
        public ResultForm(ref double[] result)
        {
            InitializeComponent();
            ShowResult(result);
        }
        public void ShowResult(double[] result)
        {
            resultDataGridView.Columns.Clear();
            resultDataGridView.Rows.Clear();

            resultDataGridView.Columns.Add("x", "x");
            for (int i = 0; i < result.Length; i++)
            {
                resultDataGridView.Columns.Add("y" + i, "y" + i);
            }
        }

        private void ResultForm_SizeChanged(object sender, EventArgs e)
        {
            resultDataGridView.Height = this.Height - 50;
            resultDataGridView.Width = this.Width - 100;

        }
    }
}
