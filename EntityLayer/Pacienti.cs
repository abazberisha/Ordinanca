using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Pacienti
    {
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
        private string nrLeternjoftimit;
        public string  NrLeternjoftimit ////////////////////////////////////////////////////
        {
            get
            {
                return nrLeternjoftimit;
            }
            set
            {
                nrLeternjoftimit = value;
            }
        }
        private string emri;
        public string Emri
        {
            get
            {
                return emri;
            }
            set
            {
                emri = value;
            }
        }
        private string mbiemri;
        public string Mbiemri
        {
            get
            {
                return mbiemri;
            }
            set
            {
                mbiemri = value;
            }
        }

        private string gjinia;///////varchar bit joo po duhet mos gabo me lon bit////////////////////////////////////////////////
        public string  Gjinia
        {
            get
            {
                return gjinia;
            }
            set
            {
                gjinia = value;
            }
        }
        private DateTime dataLindjes;
        public DateTime DataLindjes////////////////////////////////////////////////////
        {
            get
            {
                return dataLindjes;
            }
            set
            {
                dataLindjes = value;
            }
        }
        private string vendiLindjes;
        public string  VendiLindjes 
        {
            get
            {
                return vendiLindjes;
            }
            set
            {
                vendiLindjes = value;
            }
        }
        private string telefoni;//////////////////////////////////////////////
        public string Telefoni
        {
            get
            {
                return telefoni;
            }
            set
            {
                telefoni = value;
            }
        }
        private string email;//////////////////////////////////////////////
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        private string addresa;//////////////////////////////////////////////
        public string Addresa
        {
            get
            {
                return addresa;

            }
            set
            {
                addresa = value;
            }
        }

        public string FullName
        {
            get
            {
                return NrLeternjoftimit + " | " + Emri + " " + Mbiemri;
            }
        }
    }
}
