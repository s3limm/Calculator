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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string op;
        int number1;
        int number2;
        int result;


        #region MauseHover

        private void btn0_MouseHover(object sender, EventArgs e)
        {
            btn0.BackColor = Color.LightGray;
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            btn1.BackColor = Color.LightGray;
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            btn2.BackColor = Color.LightGray;
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            btn3.BackColor = Color.LightGray;
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            btn4.BackColor = Color.LightGray;
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            btn5.BackColor = Color.LightGray;
        }

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            btn6.BackColor = Color.LightGray;
        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            btn7.BackColor = Color.LightGray;
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            btn8.BackColor = Color.LightGray;
        }

        private void btn9_MouseHover(object sender, EventArgs e)
        {
            btn9.BackColor = Color.LightGray;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.DarkGray;
        }

        private void btnMod_MouseHover(object sender, EventArgs e)
        {
            btnMod.BackColor = Color.DarkGray;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {

        }
        private void btnCarpma_MouseHover(object sender, EventArgs e)
        {
            btnCarp.BackColor = Color.DarkGray;
        }
        private void btnBölme_MouseHover(object sender, EventArgs e)
        {
            btnBöl.BackColor = Color.DarkGray;
        }

        private void btnToplama_MouseHover(object sender, EventArgs e)
        {
            btnTopla.BackColor = Color.DarkGray;
        }
        private void btnCıkarma_MouseHover(object sender, EventArgs e)
        {
            btnCıkar.BackColor = Color.DarkGray;
        }

        #endregion

        #region MauseLeave

        private void btn0_MouseLeave(object sender, EventArgs e)
        {
            btn0.BackColor = Color.WhiteSmoke;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.WhiteSmoke;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = Color.WhiteSmoke;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackColor = Color.WhiteSmoke;
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackColor = Color.WhiteSmoke;
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btn5.BackColor = Color.WhiteSmoke;
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            btn6.BackColor = Color.WhiteSmoke;
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            btn7.BackColor = Color.WhiteSmoke;
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            btn8.BackColor = Color.WhiteSmoke;
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            btn9.BackColor = Color.WhiteSmoke;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.LightGray;
        }

        private void btnMod_MouseLeave(object sender, EventArgs e)
        {
            btnMod.BackColor = Color.LightGray;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {

        }
        private void btnCarpma_MouseLeave(object sender, EventArgs e)
        {
            btnCarp.BackColor = Color.LightGray;
        }
        private void btnBölme_MouseLeave(object sender, EventArgs e)
        {
            btnBöl.BackColor = Color.LightGray;
        }

        private void btnToplama_MouseLeave(object sender, EventArgs e)
        {
            btnTopla.BackColor = Color.LightGray;
        }
        private void btnCıkarma_MouseLeave(object sender, EventArgs e)
        {
            btnCıkar.BackColor = Color.LightGray;
        }



        #endregion

        #region Keyboard

        private void btnTopla_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Oemplus)
            {
                op = "+";

                if (string.IsNullOrEmpty(txtResult.Text))
                {
                    MessageBox.Show("Lütfen bir değer giriniz.");
                    txtResult.Focus();
                }
                else
                {
                    number1 = Convert.ToInt32(txtResult.Text);
                    txtResult.Clear();
                }
            }
        }

        private void btnCıkar_KeyUp(object sender, KeyEventArgs e)
        {
            op = "-";

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
                txtResult.Focus();
            }
            else
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Clear();
            }
        }

        private void btnBöl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Text = "";
            }
        }

        private void btnCarp_KeyUp(object sender, KeyEventArgs e)
        {
            op = "*";

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
                txtResult.Focus();
            }
            else
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Clear();
            }
        }

        private void btnMod_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void btnClear_KeyUp(object sender, KeyEventArgs e)
        {

        }

        #endregion

        #region Operators

        private void btnTopla_Click(object sender, EventArgs e)
        {
            op = "+";

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
                txtResult.Focus();
            }
            else
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Clear();
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            op = "-";

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
                txtResult.Focus();
            }
            else
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Clear();
            }

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            op = "/";

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
                txtResult.Focus();
            }
            else
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Clear();
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            op = "*";

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
                txtResult.Focus();
            }
            else
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Clear();
            }
        }


        private void btnMod_Click(object sender, EventArgs e)
        {
            op = "%";

            if (string.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
                txtResult.Focus();
            }
            
            else
            {
                number1 = Convert.ToInt32(txtResult.Text);
                txtResult.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            number1 = (0);
            number2 = (0);
            txtResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            txtResult.Focus();
            number2 = Convert.ToInt32(txtResult.Text);

            if (op == "+")
            {
                result = number1 + number2;
            }


            if (op == "-")
            {
                result = number1 - number2;
            }


            if (op == "/")
            {
                result = number1 / number2;
            }

            if (op == "*")
            {
                result = number1 * number2;
            }


            if (op == "%")
            {
                result = number1 % number2;
            }


            txtResult.Text = result + "";
        }
        #endregion 

        #region Numbers

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        #endregion


        private void Form1_Enter(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(txtResult.Text);

            if (op == "+")
            {
                result = number1 + number2;
            }


            if (op == "-")
            {
                result = number1 - number2;
            }


            if (op == "/")
            {
                result = number1 / number2;
            }

            if (op == "*")
            {
                result = number1 * number2;
            }


            if (op == "%")
            {
                result = number1 % number2;
            }


            txtResult.Text = result + "";
        }

      
    }
}

