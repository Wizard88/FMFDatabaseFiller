using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class ReturnType : ICommand
    {
        private readonly DataTable _table;

        public ReturnType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVrstaPovrata = row["IdVrstaPovrata"];
                object vrstaPovrata = row["VrstaPovrata"];
                object datumUnosa = row["DatumUnosa"];

                //postoje 2 store procedure za ovu tabelu
                SqlCommand cmd = new SqlCommand("ReturnTypeInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", );
                cmd.Parameters.AddWithValue("@Description", );
                cmd.Parameters.AddWithValue("@zOrder", );
                cmd.Parameters.AddWithValue("@CreateDate", );
                cmd.Parameters.AddWithValue("@UserID", );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
