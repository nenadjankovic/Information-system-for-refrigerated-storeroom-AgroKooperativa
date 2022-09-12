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
    public class AvansRepository
    {
        public List<Avansi> GetAllAvans()
        {
            List<Avansi> result = new List<Avansi>();
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Avans";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Avansi a = new Avansi();
                    a.idAvans = sqlDataReader.GetInt32(0);
                    a.Datum = sqlDataReader.GetDateTime(1);
                    a.Suma = sqlDataReader.GetDecimal(2);
                    a.idProizvodjaca = sqlDataReader.GetInt32(3);

                    result.Add(a);
                }
                return result;
            }
        }

        public int InsertAvans(Avansi a)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Avansi VALUES('{0}',{1},{2})", a.Datum, a.Suma, a.idProizvodjaca);

                return sqlCommand.ExecuteNonQuery();

            }
        }

        public DataTable ucitajAvans()
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Avansi.idAvans, Proizvodjaci.Ime, Proizvodjaci.Prezime, Avansi.Datum, Avansi.Suma FROM Avansi INNER JOIN Proizvodjaci ON Avansi.idProizvodjaca = Proizvodjaci.idProizvodjaca", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }

        public int UpdateAvans(Avansi a)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Avansi SET  Datum='{0}' , Suma={1} , idProizvodjaca={2}  WHERE idAvans={3}",
                    a.Datum, a.Suma, a.idProizvodjaca, a.idAvans);

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
