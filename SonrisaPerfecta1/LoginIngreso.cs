using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonrisaPerfecta1
{
    public partial class LoginIngreso : Form
    {
        public LoginIngreso()
        {
            InitializeComponent();
        }

        private void txtINGRESOUSUARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtINGRESOCONTRASEÑA.PasswordChar == (Char)0)
            txtINGRESOCONTRASEÑA.PasswordChar = '*';
            else 
                txtINGRESOCONTRASEÑA.PasswordChar = (Char)0;

        }

        private void txtINGRESOCONTRASEÑA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
