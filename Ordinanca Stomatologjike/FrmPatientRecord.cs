using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntityLayer;
using BussinesLogicLayer;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Speech;




namespace Ordinanca_Stomatologjike
{
    public partial class FrmPatientRecord : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

        public FrmPatientRecord()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {


            if (txtKerko.Text != "")
            {

                gridPacientet.DataSource = BLPacienti.ShfaqListenPacienteve(txtKerko.Text);

            }
            else
            {

                // gridPacientet.DataSource = BLPacienti.ShfaqListenPacienteve();

                MessageBox.Show("Shkruani numrin e leternjoftimit per ta kerkuar nje pacient", "Gabim gjate kerkimit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_AddPatientBack_Click(object sender, EventArgs e)
        {
            FrmAddPatient shtopacient = new FrmAddPatient();
            shtopacient.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void gridPacientet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Pacienti pacienti = new Pacienti();

                pacienti.PacientiID = Convert.ToInt32(gridPacientet.Rows[e.RowIndex].Cells[0].Value);
                pacienti.Emri = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[2].Value);
                pacienti.Mbiemri = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[3].Value);
                pacienti.NrLeternjoftimit = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[1].Value);
                pacienti.Gjinia = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[4].Value);
                pacienti.DataLindjes = Convert.ToDateTime(gridPacientet.Rows[e.RowIndex].Cells[5].Value);
                pacienti.VendiLindjes = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[6].Value);
                pacienti.Telefoni = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[7].Value);
                pacienti.Email = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[8].Value);
                pacienti.Addresa = Convert.ToString(gridPacientet.Rows[e.RowIndex].Cells[9].Value);


                FrmEditPacient frmedito = new FrmEditPacient();
                frmedito.VendosTeDhenat(pacienti);
                frmedito.ShowDialog();

                btn_SearchPatient_Click(sender, e);

            }

        }

        private void gridPacientet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSpeach_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            for (int i = 0; i < gridPacientet.Rows.Count; i++)
            {
                ss.Speak("Client" + gridPacientet.Rows[i].Cells[1].Value);
            }
        }

        private void FrmPatientRecord_Load(object sender, EventArgs e)
        {
            string[] lista = { "List", "Add", "Clear" };
            Choices opcionet = new Choices(lista);
            GrammarBuilder gb = new GrammarBuilder(opcionet);
            Grammar g = new Grammar(gb);

            recEngine.LoadGrammarAsync(g);
           recEngine.SetInputToDefaultAudioDevice();
          
           
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
           
        }
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            if (e.Result.Text == "List")
            {
                  gridPacientet.DataSource = BLPacienti.ShfaqListenPacienteve();
            }
            else if (e.Result.Text == "Clear")
            {
                gridPacientet.DataSource = "";
            }
            else if (e.Result.Text == "Add")
            {
                FrmAddPatient frmadd = new FrmAddPatient();
                frmadd.ShowDialog();
            }

        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}