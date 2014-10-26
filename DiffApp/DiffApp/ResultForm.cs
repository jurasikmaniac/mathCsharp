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
        private List<ResultRow> result;
        public ResultForm(ref List<ResultRow> result, ref List<ResultRow> result2)
        {
            InitializeComponent();
            this.result = result;
            ShowResult(result, result2);
        }
        public void ShowResult(List<ResultRow> result, List<ResultRow> result2)
        {
            resultDataGridView.Columns.Add("xCoumn", "X");

            for (int i = 0; i < result[0].Y.Length; i++)
            {
                resultDataGridView.Columns.Add("yCoumn" + i, "Y" + i);
            }
            resultDataGridView.Columns.Add("error", "error");

            int ii = 0;
            foreach (var r in result)
            {
                string[] s = r.toStringArray();
                s[s.Length-1] = Convert.ToString(Math.Abs(r.Y[0] - result2[ii].Y[0]) / 15.0);
                resultDataGridView.Rows.Add(s);
                ii++;
            }
        }

        private void ResultForm_SizeChanged(object sender, EventArgs e)
        {
            resultDataGridView.Height = this.Height - 50;
            resultDataGridView.Width = this.Width - 100;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GraphForm(result).ShowDialog();
        }
    }
}
