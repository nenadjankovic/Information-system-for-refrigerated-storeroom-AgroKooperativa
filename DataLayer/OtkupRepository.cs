using DataLayer.Models;
using System;
using System.Collections.Generic;
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
    }
}
