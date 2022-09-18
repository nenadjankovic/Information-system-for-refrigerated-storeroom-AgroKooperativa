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
    public class CenaRepository
    {
        public List<Cena> GetAllCena()
        {
            List<Cena> result = new List<Cena>();

            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM CeneVoca";
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
            sqlCommand.CommandText = string.Format("UPDATE CeneVoca SET  CenaIKlase={0} , CenaIIKlase={1} , Datum='{2}'  WHERE idCeneVoca={3}",
                c.CenaIKlase, c.CenaIIKlase,c.Datum, c.FK_IDVoca);
         
            return sqlCommand.ExecuteNonQuery();
            }
        }

        public int InsertCena(Cena c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO CeneVoca VALUES({0},{1},'{2}',{3})", c.CenaIKlase, c.CenaIIKlase, c.Datum, c.FK_IDVoca);

                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
