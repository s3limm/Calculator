using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class OutKeyword : Form
    {
        public OutKeyword()
        {
            InitializeComponent();
        }


        Random random = new Random();

        public string RollingDice(out int number1, out int number2)
        {
            string message;

            number1 = random.Next(0, 7);
            number2 = random.Next(0, 7);

            if (number1 == number2)
            {
                message = "Kazandınız";
            }
            else
            {
                message = "Kaybettiniz";
            }
            return message;
        }

        private void btnDice_Click(object sender, EventArgs e)
        {

            int number1;
            int number2;
            string message = RollingDice(out number1, out number2);
            MessageBox.Show(message);
            lblNumber1.Text = number1.ToString();
            lblNumber2.Text = number2.ToString();

        }

        private void OutKeyword_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz...");
        }
    }
}
