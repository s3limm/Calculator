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
    public partial class PhoneFormat : Form
    {
        public PhoneFormat()
        {
            InitializeComponent();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string phoneLast = CheckPhone(phoneNumber);

            if (phoneLast.Contains("Hata"))
            {
                MessageBox.Show(phoneLast);
            }
            else
            {
                MessageBox.Show($"{phoneLast} sms ile telefonunuza gönderlimiştir.");
            }
        }

        public string CheckPhone(string number)
        {

            try
            {

                if (number == "")
                {
                    return "Hata mesajı => Lütfen telefon alanını doldurunuz. ";
                }

                number = number.Replace(" ", "");
                number = number.Replace("+", "");
                string firstChracter = number.Substring(0, 1);

                if (firstChracter == "9")
                {
                    number = number.Substring(1, number.Length - 1);
                }

                else if (firstChracter != "0")
                {
                    number = "0" + number;
                }


                if (number.Length == 11)

                {
                    Convert.ToDouble(number);
                    return number;
                }

                return "Hata mesajı.Lütfen girdiğiniz telefon formatını kontrol ediniz.";


            }
            catch (FormatException)
            {

                return "Hata mesajı.Lütfen uygun formatta bir değer giriniz.";
            }

            catch (Exception)
            {

                return "Hata mesajı.Bilinmeyen bir hata lütfen telefon numaranızı tekrardan giriniz.";

            }

        }

        private void PhoneFormat_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhabalar hoşgeldiniz istediğiniz formatta telefon numarası giriniz.");
        }
    }
}
