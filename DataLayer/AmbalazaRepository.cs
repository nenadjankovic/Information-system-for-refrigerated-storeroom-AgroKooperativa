using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AmbalazaRepository
    {
     public List<Ambalaza> GetAllAmbalaza()
        {
            List<Ambalaza> result = new List<Ambalaza>();

            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Ambalaza";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Ambalaza a = new Ambalaza();
                    a.idAmbalaze = sqlDataReader.GetInt32(0);
                    a.izdato = sqlDataReader.GetInt32(1);
                    a.vraceno = sqlDataReader.GetInt32(2);
                    a.idProizvodjaca = sqlDataReader.GetInt32(3);

                    result.Add(a);
                }

            }
            return result;
        }
        
        public int InsertAmbalaza(Ambalaza a)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Ambalaza VALUES({0},{1},{2})", a.izdato, a.vraceno, a.idProizvodjaca);

                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
