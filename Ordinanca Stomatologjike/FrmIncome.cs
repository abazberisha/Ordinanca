using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ordinanca_Stomatologjike
{
    public partial class FrmIncome : Form
    {
        public FrmIncome()
        {
            InitializeComponent();
        }

        private void btnShpenzimet_Click(object sender, EventArgs e)
        {
        
                 int shuma = 0;

                shuma = (Convert.ToInt32(txtUjiFatura.Text) + Convert.ToInt32(txtRryma.Text) +
                Convert.ToInt32(txtQerajaShpenzim.Text) + Convert.ToInt32(txtTelefoni.Text)+ Convert.ToInt32
               (txtMbeturinat.Text)+Convert.ToInt32(txtShpenzimeZyre.Text));

                 textBox1.Text = shuma.ToString();
        }
    }
}
