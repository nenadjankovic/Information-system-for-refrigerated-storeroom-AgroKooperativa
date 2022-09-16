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
    public class OtkupRepository
    {
        public int InsertOtkup(Otkup o)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Otkup VALUES({0},{1},'{2}',{3},{4})", o.KolicinaIKlase, o.KolicinaIIKlase, o.Datum, o.IDVoca, o.idProizvodjaca);

                return sqlCommand.ExecuteNonQuery();

            }
        }

        public List<Otkup> GetAllOtkup()
        {
            List<Otkup> result = new List<Otkup>();
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Otkup";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Otkup p = new Otkup();
                    p.idOtkupa = sqlDataReader.GetInt32(0);
                    p.KolicinaIKlase = sqlDataReader.GetDecimal(1);
                    p.KolicinaIIKlase = sqlDataReader.GetDecimal(2);
                    p.Datum = sqlDataReader.GetDateTime(3);
                    p.IDVoca = sqlDataReader.GetInt32(4);
                    p.idProizvodjaca = sqlDataReader.GetInt32(5);

                    result.Add(p);
                }
                return result;
            }
        }

        public DataTable ucitajOtkup()
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Proizvodjaci.ime, Proizvodjaci.Prezime, , Avansi.Datum, Avansi.Suma FROM Avansi INNER JOIN Proizvodjaci ON Avansi.idProizvodjaca = Proizvodjaci.idProizvodjaca", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }
    }
}
