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
        public ResultForm(ref List<ResultRow> result)
        {
            InitializeComponent();
            ShowResult(result);
        }
        public void ShowResult(List<ResultRow> result)
        {
            resultDataGridView.Columns.Add("xCoumn", "X");

            for (int i = 0; i < result[0].Y.Length; i++)
            {
                resultDataGridView.Columns.Add("yCoumn"+i, "Y"+i);
            }

            foreach (var r in result)
            {
                resultDataGridView.Rows.Add(r.toStringArray());
            }
        }

        private void ResultForm_SizeChanged(object sender, EventArgs e)
        {
            resultDataGridView.Height = this.Height - 50;
            resultDataGridView.Width = this.Width - 100;

        }
    }
}
