using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Fatura
    {
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
        }
        private decimal qmimi;
        public decimal Cmimi
        {
            get
            {
                return qmimi;
            }
            set
            {
                qmimi = value;
            }
        }
        private DateTime dataFatures;
        public DateTime DataFatures
        {
            get
            {
                return dataFatures;
            }
            set
            {
                dataFatures = value;
            }
        }

    }
}
