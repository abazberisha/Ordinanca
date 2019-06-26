using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    //Klasa doktori e cila trashegon klasen pacienti 
    public class Doktori:Pacienti
    {
        //vetit e klases Doktori 
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
        private int usuerID;
        public int UserID
        {
            get
            {
                return usuerID;
            }
            set
            {
                usuerID = value;
            }
        }

        
        
    }
}
