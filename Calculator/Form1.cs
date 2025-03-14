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
    public partial class main_form: Form
    {
        ICalculator Calculator;
        public main_form()
        {
            InitializeComponent();
        }
        Calculator calcu = new Calculator();
        int result;
        private void main_form_Load(object sender, EventArgs e)
        {
        
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            result = calcu.Plus((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            MessageBox.Show("حاصل جمع: " + result);
            
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            result = calcu.Minus((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            MessageBox.Show("حاصل تفریق: " + result);
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            result = calcu.Multiplication((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            MessageBox.Show("حاصل ضرب: " + result);
        }

        private void btn_devide_Click(object sender, EventArgs e)
        {
            try
            {
                result = calcu.Devide((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                MessageBox.Show("حاصل تقسیم: " + result);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("تعریف نشده!!!!");
            }
        }

        /*bool chek_numbers()
        {
            
        }*/
    }
}
