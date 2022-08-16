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
    public partial class refKeyword : Form
    {
        public refKeyword()
        {
            InitializeComponent();
        }

        int number = 20;

        public void CopyNumber(int copyNumber)
        {
            copyNumber = 50;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyNumber(number);
            MessageBox.Show(number.ToString());
        }


        public void Referance(ref int refCopy)
        {
            refCopy = 50;
        }


        private void btnRef_Click(object sender, EventArgs e)
        {
            Referance(ref number);
            MessageBox.Show(number.ToString());
        }
    }
}
