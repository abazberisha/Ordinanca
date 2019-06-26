using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BussinesLogicLayer;

namespace Ordinanca_Stomatologjike
{
    public partial class FrmAutentifikimi : Form
    {
        public static string Roli = "";
  

        public FrmAutentifikimi()
        {
            InitializeComponent();
        }


        //private bool Autentifikimi()
        //{

        //    return true;
        //    //Nese nuk keni qasje
        //}


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (BLUser.VerifyUser(txtUsername.Text, txtPassword.Text))
            {
                Roli = BLUser.GetRole(txtUsername.Text);
                FrmContent mainFrm = new FrmContent();
                this.Hide();
               mainFrm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Te dhenat per qasje jane Gabim");
            }
            
            
            
            //if (Autentifikimi())
            //{
            //    FrmContent frm = new FrmContent();
            //    frm.Show();

        }
    
    }
}