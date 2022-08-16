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
    public partial class PhoneFormatExample2 : Form
    {
        public PhoneFormatExample2()
        {
            InitializeComponent();
        }

        private void PhoneFormatExample2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz lütfen mesaj göndermek istediğiniz telefon numarasını giriniz");
        }

        private void btnPhoneCheck_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumberİnput.Text;
           string issue =  PhoneNumber(phoneNumber);

            if(issue.Contains("Hata"))
            {
                MessageBox.Show(issue);
            }
            else
            {
                MessageBox.Show($"{issue} telefon numarasına mesajınız iletildi");
            }
        }

        private void Clear()
        {
            txtPhoneNumberİnput.Text = "";
        }

        public string PhoneNumber(string number)
        {
            try
            {
                if (number == "")
                {
                    return "Hata : Lütfen bir numara giriniz.";
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
                    return number;
                }
                else
                {
                    Clear();
                    return "Hata : 11 haneli numara giriniz.";
                }
            }
            catch (FormatException)
            {
                Clear();
                return "Hata : Lütfen doğru karakterler kullanıp tekrar deneyiniz.";
            }

            catch(Exception ) 
            {
                Clear();
                return "Hata : Bilinmeyen bir durum oluştu. Lütfen tekrar deneyiniz.";
            }  
        }
    }
}
