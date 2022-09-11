using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class VoceRepository
    {
        public DataTable ucitajVoce()
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Voce", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }

        public List<Voce> GetAllVoce()
        {
            List<Voce> result = new List<Voce>();
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Voce;";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Voce v = new Voce();
                    v.IDVoca = sqlDataReader.GetInt32(0);
                    v.Naziv = sqlDataReader.GetString(1);

                    result.Add(v);
                }
                return result;
            }
        }
       
    }
}
