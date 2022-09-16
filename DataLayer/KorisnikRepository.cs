using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class KorisnikRepository
    {
        public List<Korisnik> GetAllKorisnici()
        {
            List<Korisnik> result = new List<Korisnik>();

            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Korisnici";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Korisnik s = new Korisnik();
                    s.idKorisnika = sqlDataReader.GetInt32(0);
                    s.ime = sqlDataReader.GetString(1);
                    s.prezime = sqlDataReader.GetString(2);
                    s.korisnickoIme = sqlDataReader.GetString(3);
                    s.lozinka = sqlDataReader.GetString(4);


                    result.Add(s);
                }

            }
            return result;
        }

        public int InsertKorisnik(Korisnik k)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Korisnici VALUES('{0}','{1}','{2}','{3}')", k.ime, k.prezime, k.korisnickoIme, k.lozinka);

                return sqlCommand.ExecuteNonQuery();

            }
        }

        public DataTable loginData (string username, string password)
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                string query = "SELECT * FROM Korisnici WHERE KorisnickoIme = '"+username.Trim()+"' AND Lozinka = '"+password.Trim()+"'";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }

        public DataTable ProveraPonavljanjaKorisnickogImena(string username)
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                string query = "SELECT * FROM Korisnici WHERE KorisnickoIme = '" + username.Trim() + "'";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }
    }
}
