using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using EntityLayer;
using BussinesLogicLayer;

namespace Ordinanca_Stomatologjike
{
    public partial class FrmContent : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

        public FrmContent()
        {
            InitializeComponent();
        }

        private void btnAdd_Patient_Click(object sender, EventArgs e)
        {
            FrmAddPatient frm = new FrmAddPatient();
            frm.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FrmPatientRecord frm = new FrmPatientRecord();
            frm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_Add_Appointment_Click(object sender, EventArgs e)
        {
            FrmAddAppointment takimet = new FrmAddAppointment();
            takimet.Show();
        }

        private void btn_Income_Click(object sender, EventArgs e)
        {
            FrmIncome shpenzimet = new FrmIncome();
            shpenzimet.Show();
        }

        private void FrmContent_Load(object sender, EventArgs e)
        {
            FrmEditPacient editoPacient = new FrmEditPacient();

            Pacienti pacient = new Pacienti();
            pacient.PacientiID = 1;
            //editoPacient.VendosTeDhenat(pacient);

        }
    }
}
