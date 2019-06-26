using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
     public class Sigurimi
    {
        private int sigurimiID;
        public int SigurimiID
        {
            get
            {
                return sigurimiID;
            }
            set
            {
                sigurimiID = value;
            }
        }//////////////////////////////////////////////FK///////////////////////////////////////////
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
