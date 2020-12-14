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

                cmd.Parameters.AddWithValue("@Title", vrstaPovrata);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@Code", idVrstaPovrata);
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Active", 1);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
