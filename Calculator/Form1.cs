using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = Operator.SelectedText;
            string arg1 = Input1.Text;
            string arg2 = Input2.Text;

            Display.Text = $"Result: {Calculate(Convert.ToInt32(arg1), Convert.ToInt32(arg2))}";
        }
    }
}
