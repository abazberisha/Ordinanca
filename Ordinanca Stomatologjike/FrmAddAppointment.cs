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
    public partial class FrmAddAppointment : Form
    {
        public FrmAddAppointment()
        {
            InitializeComponent();
        }

        private void FrmAddAppointment_Load(object sender, EventArgs e)
        {
            MbushCombon();

        }
        public void MbushCombon()
        {
            cmbShfaq.DataSource = BLPacienti.ShfaqListenPacienteve();
            cmbShfaq.DisplayMember = "FullName";
            cmbShfaq.ValueMember = "PacientiID";

        }

        private void cmbShfaq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtArsyejaTerminit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMbyllFormen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShtoTermin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Termini u shtua me sukses");
        }
    }
}
