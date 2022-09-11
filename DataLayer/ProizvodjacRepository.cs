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
    public class ProizvodjacRepository
    {
        public List<Proizvodjac> GetAllProizvodjaci()
        {
            List<Proizvodjac> result = new List<Proizvodjac>();

            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Proizvodjaci";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Proizvodjac p = new Proizvodjac();
                    p.idProizvodjaca = sqlDataReader.GetInt32(0);
                    p.ime = sqlDataReader.GetString(1);
                    p.prezime = sqlDataReader.GetString(2);
                    p.mesto = sqlDataReader.GetString(3);
                    p.telefon = sqlDataReader.GetString(4);
                    p.BPG = sqlDataReader.GetInt64(5);

                    result.Add(p);
                }

            }
            return result;
        }

        public int InsertProizvodjac(Proizvodjac p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Proizvodjaci VALUES('{0}','{1}','{2}','{3}',{4})", p.ime, p.prezime, p.mesto, p.telefon, p.BPG);

                return sqlCommand.ExecuteNonQuery();

            }
        }

        //funkc za brisanje proizvodjaca

        public int DeleteProizvodjac(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Proizvodjaci WHERE Proizvodjaci.idProizvodjaca = '" + id + "' ;");

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public DataTable ucitajProizvodjace()
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Proizvodjaci", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }
            
     }
}
