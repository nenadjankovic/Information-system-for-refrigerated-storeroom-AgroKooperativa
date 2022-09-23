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
                sqlCommand.CommandText = string.Format("INSERT INTO Otkup VALUES({0},{1},{2},{3},{4},'{5}',{6},{7})", o.BrutoKolicinaIKlase, o.BrutoKolicinaIIKlase,o.NetoKolicinaIKlase,o.NetoKolicinaIIKlase,o.Tara, o.Datum, o.IDVoca, o.idProizvodjaca);

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
                    p.BrutoKolicinaIKlase = sqlDataReader.GetDecimal(1);
                    p.BrutoKolicinaIIKlase = sqlDataReader.GetDecimal(2);
                    p.NetoKolicinaIKlase = sqlDataReader.GetDecimal(3);
                    p.NetoKolicinaIIKlase = sqlDataReader.GetDecimal(4);
                    p.Tara = sqlDataReader.GetDecimal(5);
                    p.Datum = sqlDataReader.GetDateTime(6);
                    p.IDVoca = sqlDataReader.GetInt32(7);
                    p.idProizvodjaca = sqlDataReader.GetInt32(8);

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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Otkup.idOtkupa, Proizvodjaci.ime, Proizvodjaci.Prezime, Voce.Naziv, Otkup.BrutoKolicinaIKlase, Otkup.BrutoKolicinaIIKlase, Otkup.NetoKolicinaIKlase, Otkup.NetoKolicinaIIKlase, Otkup.Tara, Otkup.Datum FROM Otkup INNER JOIN Proizvodjaci ON Otkup.idProizvodjaca = Proizvodjaci.idProizvodjaca INNER JOIN Voce ON Otkup.IDVoca = Voce.IDVoca", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return dtbl;
            }
        }
        public int DeleteOtkup(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Konstante.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Otkup WHERE Otkup.idOtkupa = '" + id + "' ;");

                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
