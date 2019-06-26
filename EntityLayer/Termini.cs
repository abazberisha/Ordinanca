using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Termini
    {
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
        private DateTime koha;
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
        private string arsyejaTerminit;
        public string ArsyejaTerminit
        {
            get
            {
                return arsyejaTerminit;
            }
            set
            {
                arsyejaTerminit = value;
            }
        }
        private string alergjia;
        public string Alergjia
        {
            get
            {
                return alergjia;
            }
            set
            {
                alergjia = value;
            }
        }

    }
}
