using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class CourtCosts : ICommand
    {
        private readonly DataTable _table;

        public CourtCosts(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVrstaSudTroskova = row["IdVrstaSudTroskova"];
                object vrstaSudTroskova = row["VrstaSudTroskova"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmdIzvr = new SqlCommand("", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdIzvr.Parameters.AddWithValue("",);

                SqlCommand cmdPar = new SqlCommand("", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdPar.Parameters.AddWithValue("@", );

                SqlCommand cmdTotal = new SqlCommand("", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdTotal.Parameters.AddWithValue("@", budzetskaGodina);


                cmdIzvr.ExecuteNonQuery();
                cmdPar.ExecuteNonQuery();
                cmdTotal.ExecuteNonQuery();
            }
        }
    }
}
