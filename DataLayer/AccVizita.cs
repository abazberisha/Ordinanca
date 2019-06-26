using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataLayer
{
    class AccVizita
    {
        public static List<Vizita>ShfaqListenVizitave(string prmKerko)
        {
            List<Vizita> vizita = new List<Vizita>();
            SqlConnection connect = Connection.GetSqlConnection();

            try
            {
                 // emri procedures n SQL
                SqlCommand comand = new SqlCommand("" + connect);

                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@prmKerko",prmKerko);
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Vizita v = new Vizita();
                    v.VizitaID = Int32.Parse(reader["VizitaID"].ToString());
                    v.PacientiID = Int32.Parse(reader["PacientiID"].ToString());
                    v.DoktoriID = Int32.Parse(reader["DoktoriID"].ToString());
                    v.TerminiID = Int32.Parse(reader["TerminiID"].ToString());
                    v.FaturaID = Int32.Parse(reader["FaturaID"].ToString());
                    v.Koha = DateTime.Parse(reader["KohaVizites"].ToString());
                    v.Rekomandimi = reader["Rekomandimi"].ToString();
                    v.Terapia = reader["Terapia"].ToString();
                    v.Diagnoza = reader["Diagnoza"].ToString();
                    vizita.Add(v);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connect.Close();
            }
            return vizita;
        }
        
        
    }
}
