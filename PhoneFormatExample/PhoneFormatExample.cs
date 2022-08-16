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
    public partial class PhoneFormatExample : Form
    {
        public PhoneFormatExample()
        {
            InitializeComponent();
        }

        private void PhoneFormatExample_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz lütfen bir teefon numarası giriniz.");
        }

        private void btnPhoneCheck_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtInputPhone.Text;

            CheckPhone(phoneNumber);

            string Lastİssue = CheckPhone(phoneNumber);


            if(Lastİssue.Contains("Hata"))
            {
                MessageBox.Show(Lastİssue);
            }
            else
            {
                MessageBox.Show($"{Lastİssue} telefon numarasına gönderildi.");
            }
        }

        private void Clear()
        {
            txtInputPhone.Clear();
        }

        public string CheckPhone(string phone)
        {
            try
            {

                if (phone == "")
                {
                    return "Hata mesajı => Lütfen bir telefon numarası giriniz.";
                }

                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");
                string firstChracter = phone.Substring(0, 1);

                if (firstChracter == "9")
                {
                    phone = phone.Substring(1, phone.Length - 1);
                }

                else if (firstChracter != "0")
                {
                    phone = "0" + phone;
                }


                if (phone.Length == 11)
                {
                    Convert.ToDouble(phone);
                    return phone;
                }

                else
                {
                    Clear();
                    return "Hata mesajı => Lütfen girdiğiniz telefon formatını kontrol edip tekrar deneyiniz.[11 haneli sayı girmelisiniz.]";
                    
                }

            }

            catch (FormatException)
            {
                Clear();
                return "Hata mesajı => Lütfen düzgün formatta bir değer giriniz.";  
            }

            catch (Exception)
            {
                Clear();
                return "Hata mesajı => Bilinmeyen bir hata oluştu lütfen uygulamayı tekrar başlatın.";
            }
        }

    }
}
