using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int sum = a + b;

            txtResult.Text = sum.ToString();
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int diff = a - b;

            txtResult.Text = diff.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int mul = a * b;

            txtResult.Text = mul.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int div = a / b;

            txtResult.Text = div.ToString();
        }

        
    }
}
