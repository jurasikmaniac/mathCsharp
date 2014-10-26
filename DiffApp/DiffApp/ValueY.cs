using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffApp
{
    public partial class ValueY : UserControl
    {
        public ValueY(string txtName)
        {            
            InitializeComponent();
            txtVariable.Text = txtName;
           
        }

        public string Variable 
        { 
            get { return txtVariable.Text; }
            set { txtVariable.Text = value; }
        }

        public string Value 
        { 
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }
    }
    
}
