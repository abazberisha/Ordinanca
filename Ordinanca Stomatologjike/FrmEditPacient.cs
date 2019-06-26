using EntityLayer;
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
    public partial class FrmEditPacient : Form
    {
        private int pacientiID;

        public FrmEditPacient()
        {
            InitializeComponent();
        }
        //per vendosjen e te dhenave ne textboxa
        public void VendosTeDhenat(Pacienti pacienti)
        {
            txtPacienti.Text = pacienti.PacientiID.ToString();
            txtEName.Text = pacienti.Emri;
            txtESurname.Text = pacienti.Mbiemri;
            txtNrLeternjofitmit.Text = pacienti.NrLeternjoftimit;
            if (pacienti.Gjinia == "Male")
            {
                rbMashkull.Checked = true;
            }
            else
            {
                rbFemer.Checked = true;

            }
            dtpDataOfBirth.Value = pacienti.DataLindjes;
            txtVendiLindjes.Text = pacienti.VendiLindjes;
            txtTel.Text = pacienti.Telefoni;
            txtEmail.Text = pacienti.Email;
            txtAddresa.Text = pacienti.Addresa;


        }

        private void btnEditPacient_Click(object sender, EventArgs e)
        {
            BLPacienti pacienti = new BLPacienti();
            //Objekti i klases pacienti 
            Pacienti pacient = new Pacienti();
            pacient.PacientiID = Int32.Parse(txtPacienti.Text);
            pacient.Emri = txtEName.Text;
            pacient.Mbiemri = txtESurname.Text;
            pacient.NrLeternjoftimit = txtNrLeternjofitmit.Text;
            if (rbMashkull.Checked)
            {
                pacient.Gjinia = "Mashkull";
            }
            else
            {
                pacient.Gjinia = "Femer";
            }

            pacient.DataLindjes = Convert.ToDateTime(dtpDataOfBirth.Text);
            pacient.VendiLindjes = txtVendiLindjes.Text;
            pacient.Telefoni = txtTel.Text;
            pacient.Email = txtEmail.Text;
            pacient.Addresa = txtAddresa.Text;

            if (BLPacienti.UpdatePacient(pacient))
            {
                MessageBox.Show("U editua me sukses");
            }
            else
            {
                MessageBox.Show("Error");
            }

            //Thirret metoda per te edituar 
        }

        private void Anulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditPacient_Load(object sender, EventArgs e)
        {

        }

        private void btnShtoTermin_Click(object sender, EventArgs e)
        {
            FrmAddAppointment frmtermin = new FrmAddAppointment();
            frmtermin.Show();


            BLPacienti pacienti = new BLPacienti();
            //Objekti i klases pacienti 
            //            Pacienti pacient = new Pacienti();
            //            pacient.PacientiID = Int32.Parse(txtPacienti.Text);
            //            pacient.Emri = txtEName.Text;
            //            pacient.Mbiemri = txtESurname.Text;
            //            pacient.NrLeternjoftimit = txtNrLeternjofitmit.Text;
            //            pacient.Telefoni = txtTel.Text;
            //            pacient.Email = txtEmail.Text;




            //            if (BLPacienti.UpdatePacient(pacient))
            //            {
            //                MessageBox.Show("U editua me sukses");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Error");
            //            }

            //Thirret metoda per te edituar 
        }
    }
}
