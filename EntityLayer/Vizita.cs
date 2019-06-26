using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Vizita
    {
        private int vizitaID;
        public int VizitaID
        {
            get
            {
                return vizitaID;

            }
            set
            {
                vizitaID = value;
            }
        }
        private DateTime koha;///////////////////////////////////////////
        public DateTime Koha
        {
            get
            {
                return koha;
            }
            set
            {
                koha = value;
            }
        }
        private string rekomandimi;
        public string Rekomandimi
        {
            get
            {
                return rekomandimi;
            }
            set
            {
                rekomandimi = value;
            }
        }
        private string  alergjia;

        public string  Alergjia
        {
            get { return alergjia; }
            set { alergjia = value; }
        }
        
        private string diagnoza;
        public string Diagnoza
        {
            get
            {
                return diagnoza;
            }
            set
            {
                diagnoza = value;
            }
        }
        private string terapia;
        public  string Terapia
        {
            get
            {
                return terapia;
            }
            set
            {
                terapia = value;
            }
        }                           ///////////////////////////////FK////////////////////////////
        private int pacientiID;
        public int PacientiID
        {
            get
            {
                return pacientiID;
            }
            set
            {
                pacientiID = value;
            }
        }
        private int doktoriID;
        public int DoktoriID
        {
            get
            {
                return doktoriID;
            }
            set
            {
                doktoriID = value;
            }
        }
        private int terminiID;
        public int TerminiID
        {
            get
            {
                return terminiID;
            }
            set
            {
                terminiID = value;
            }
        }
        private int faturaID;
        public int FaturaID
        {
            get
            {
                return faturaID;
            }
            set
            {
                faturaID = value;
            }
        }

    }
}

