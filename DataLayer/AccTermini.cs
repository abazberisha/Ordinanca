using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataLayer
{
    class AccTermini
    {
        public static List<Termini>ShfaqListenTermineve(string prmKerko)
        {
            List<Termini> termini = new List<Termini>();
            SqlConnection connect = Connection.GetSqlConnection();

            try
            {//emri procedures  ne SQL
                SqlCommand comand = new SqlCommand("" + connect);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@prmKerko", prmKerko);
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {

                    Termini t = new Termini();
                    t.TerminiID = Int32.Parse(reader["TerminiID"].ToString());
                    t.PacientiID = Int32.Parse(reader["PacientiID"].ToString());
                    t.Koha = DateTime.Parse(reader["Koha"].ToString());
                    t.ArsyejaTerminit = reader["ArsyejaTerminit"].ToString();
                    termini.Add(t);
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
            return termini;
        }
    }
}
