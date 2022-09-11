using DataLayer.Models;
using System;
using System.Collections.Generic;
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
    }
}
