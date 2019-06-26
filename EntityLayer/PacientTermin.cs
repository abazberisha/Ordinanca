using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class PacientTermin
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
    }
}
