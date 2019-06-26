using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntityLayer;
using BussinesLogicLayer;

namespace Ordinanca_Stomatologjike
{
    public partial class FrmAddPatient : Form
    {
        public FrmAddPatient()
        {
            InitializeComponent();
        }
        //eventi i butonit Shto pacient 
        private void btnShtoPacient_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="") 
            {
                MessageBox.Show("Ju lutem shkruani emrin e pacientit");
            }
            else if (txtSurname.Text=="")
            {
                 MessageBox.Show("Ju lutem shkruani mbiemrin e pacientit");
            }
            else if (txtNrLeternjofitmit.Text=="")
            {
                MessageBox.Show("Ju lutem shkruani numrin e leternjoftimit e pacientit");
            }
            else if (dtpDataOfBirth.Text=="")
            {
                MessageBox.Show("Ju lutem shkruani datëlindjen e pacientit");
            }
            else if (txtVendiLindjes.Text=="")
            {
                MessageBox.Show("Ju lutem shkruani vendin e lindjes e pacientit");
            }
            else if (txtAddresa.Text=="")
            {
                MessageBox.Show("Ju lutem shkruani addresen e pacientit");
            }
            else if (txtTel.Text=="")
            {
                MessageBox.Show("Ju lutem shkruani numrin e telefonit e pacientit");
            }


            try
            {
                //Objekti i klases pacienti 
                Pacienti pacient = new Pacienti();
                pacient.Emri = txtName.Text;
                pacient.Mbiemri = txtSurname.Text;
                pacient.NrLeternjoftimit = txtNrLeternjofitmit.Text;
                pacient.Gjinia = cmbSex.Text;
                pacient.DataLindjes = Convert.ToDateTime(dtpDataOfBirth.Text);
                pacient.VendiLindjes = txtVendiLindjes.Text;
                pacient.Telefoni = txtTel.Text;
                pacient.Email = txtEmail.Text;
                pacient.Addresa = txtAddresa.Text;

                BLPacienti.Insert(pacient);

                MessageBox.Show("Pacienti u shtua me sukses ");
            }
            catch (FormatException ex)
            {
                throw new FormatException("Error" +ex.Message); 
            }
           

            //if (AccPacienti.Insert(pacient.ToString()))
            //{
            //    MessageBox.Show("Pacienti u regjistrua me sukses");
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}

            //FrmContent frmcountent = new FrmContent();
            //frmcountent.Show();
            
        }

        private void txtNrLeternjofitmit_TextChanged(object sender, EventArgs e)
        {

        }

        //eventi i butonit Anulo 
        private void Anulo_Click(object sender, EventArgs e)
        {
            //te pastrohen te gjitha fushat 
            txtName.Text = "";
            txtSurname.Text = "";
            txtNrLeternjofitmit.Text = "";
            cmbSex.Text = "";
            dtpDataOfBirth.Text = "";
            txtVendiLindjes.Text = "";
            txtTel.Text = "";
            txtAddresa.Text = "";
            txtEmail.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
