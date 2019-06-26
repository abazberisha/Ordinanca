using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    //Klasa AccPacienti
    public class AccPacienti
    {

        //Metoda void per te insertuar pacient
        public static void Insert(Pacienti pacient)
        {
           
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("usp_Pacient_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                
                cmd.Parameters.AddWithValue("@prmEmri", pacient.Emri);
                cmd.Parameters.AddWithValue("@prmMbiemri",pacient.Mbiemri);
                cmd.Parameters.AddWithValue("@prmNrLeternjoftimit", pacient.NrLeternjoftimit);
                cmd.Parameters.AddWithValue("@prmGjinia", pacient.Gjinia);
                cmd.Parameters.AddWithValue("@prmDataLindjes", pacient.DataLindjes);
                cmd.Parameters.AddWithValue("@prmVendiLindjes", pacient.VendiLindjes);
                cmd.Parameters.AddWithValue("@prmTelefoni", pacient.Telefoni);
                cmd.Parameters.AddWithValue("@prmEmailAddresa", pacient.Email);
                cmd.Parameters.AddWithValue("@prmAddresa", pacient.Addresa);

            
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("AccPacienti.Insert() :" + ex.Message);
            }
            finally
            {
                //perderisa qikjo nuk e ka gjendjen e mbyllur ti mbylle dhe liroi resurset 
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
        /// <summary>
        /// //////////////////////Shfaq Listen e pacientave ///////////////////////////////
        /// </summary>
        /// <returns></returns>
        public static List<Pacienti> ShfaqListenPacienteve()
        {
            List<Pacienti> listPacient = new List<Pacienti>();
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand("usp_SelectAll_Pacienti",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pacienti p = new Pacienti();
                        p.Emri = Convert.ToString(reader["Emri"]);
                        p.Mbiemri = Convert.ToString(reader["Mbiemri"]);
                        p.NrLeternjoftimit = Convert.ToString(reader["NrLeternjofitmit"]);
                        p.Gjinia = Convert.ToString(reader["Gjinia"]);
                        p.DataLindjes = Convert.ToDateTime(reader["DataLindjes"]);
                        p.VendiLindjes = Convert.ToString(reader["VendiLindjes"]);
                        p.Telefoni = Convert.ToString(reader["Telefoni"]);
                        p.Email = Convert.ToString(reader["EmailAddresa"]);
                        p.Addresa = Convert.ToString(reader["Addresa"]);

                        listPacient.Add(p);
                    }
                }
               
            }
            catch (Exception ex)
            {

                throw new Exception("AccPacienti.ShfaqListenPacienteve() :" + ex.Message);
            }
            finally
            {//perderisa nuk eshte e mbyllur ti mbylle dhe alokoi resurset nga memorja
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return listPacient;
        }
        //Kerko pacient Shfaq listen e pacienteve //////////////////////////////////////////////////
        public static List<Pacienti> ShfaqListenPacienteve(string prmKerko)
        {
            List<Pacienti> pacient = new List<Pacienti>();
            SqlConnection connect = Connection.GetSqlConnection();

            try
            {  // emri procedures n SQL
                SqlCommand comand = new SqlCommand("usp_Kerko_Pacient", connect);

                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@prmKerko",prmKerko);
                SqlDataReader reader = comand.ExecuteReader();
                    
                while(reader.Read())
                {
                    Pacienti p = new Pacienti();
                    p.PacientiID = Int32.Parse (reader["PacientiID"].ToString());
                    p.NrLeternjoftimit = reader["NrLeternjofitmit"].ToString();
                    p.Emri = reader["Emri"].ToString();
                    p.Mbiemri = reader["Mbiemri"].ToString();
                    p.Gjinia = reader["Gjinia"].ToString();
                    p.DataLindjes = DateTime.Parse(reader["DataLindjes"].ToString());
                    p.VendiLindjes = reader["VendiLindjes"].ToString();
                    p.Telefoni = reader["Telefoni"].ToString();
                    p.Addresa = reader["Addresa"].ToString();
                    p.Email = reader["EmailAddresa"].ToString();

                    pacient.Add(p);
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
            return pacient;
        }
        public static  bool UpdatePacient(Pacienti pacienti)
        {
            bool uEditua = false;
            SqlConnection conn = Connection.GetSqlConnection();
            try
            {

                SqlCommand cmd = new SqlCommand("ups_Pacient_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PacientiID", pacienti.PacientiID);
                cmd.Parameters.AddWithValue("@Emri", pacienti.Emri);
                cmd.Parameters.AddWithValue("@Mbiemri", pacienti.Mbiemri);
                cmd.Parameters.AddWithValue("@NrLeternjoftimit", pacienti.NrLeternjoftimit);
                cmd.Parameters.AddWithValue("@Gjinia", pacienti.Gjinia);
                cmd.Parameters.AddWithValue("@DataLindjes", pacienti.DataLindjes);
                cmd.Parameters.AddWithValue("@VendiLindjes", pacienti.VendiLindjes);
                cmd.Parameters.AddWithValue("@Telefoni", pacienti.Telefoni);
                cmd.Parameters.AddWithValue("@EmailAddresa", pacienti.Email);
                cmd.Parameters.AddWithValue("@Addresa", pacienti.Addresa);
                cmd.ExecuteNonQuery();
                uEditua = true;

            }
            catch (SqlException ex)
            {
                
                throw;
            }
            finally
            {
                conn.Close();
            }
            return uEditua;
        }
    }
}
