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
    public class CenaVocaRepository
    {
        public List<Cena> GetAllCenaVoca()
        {
            List<Cena> result = new List<Cena>();

            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM CenaVoca";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Cena s = new Cena();
                    s.idCeneVoca = sqlDataReader.GetInt32(0);
                    s.CenaIKlase = sqlDataReader.GetDecimal(1);
                    s.CenaIIKlase = sqlDataReader.GetDecimal(2);
                    s.Datum = sqlDataReader.GetDateTime(3);
                    s.FK_IDVoca = sqlDataReader.GetInt32(4);


                    result.Add(s);
                }

            }
            return result;
        }
        public DataTable ucitajCeneVoca()
        {
            using (SqlConnection sqlCon = new SqlConnection(Konstante.connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Voce.Naziv, CeneVoca.CenaIKlase, CeneVoca.CenaIIKlase, CeneVoca.Datum FROM Voce INNER JOIN CeneVoca ON Voce.IDVoca = CeneVoca.FK_IDVoca", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }

        public int UpdateCenuVoca(Cena c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = string.Format("UPDATE CeneVoca SET  CenaIKlase=@p1 , CenaIIKlase=@p2 , Datum=@p3  WHERE idCeneVoca=@p4");
            sqlCommand.Parameters.Add("p1", c.CenaIKlase);
            sqlCommand.Parameters.Add("p2", c.CenaIIKlase);
            sqlCommand.Parameters.Add("p3", c.Datum);
            sqlCommand.Parameters.Add("p4", c.FK_IDVoca);
            


            return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
