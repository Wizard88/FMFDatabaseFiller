using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class IncomeType : ICommand
    {
        private readonly DataTable _table;

        public IncomeType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVrstaPrihoda = row["IdVrstaPrihoda"];
                object vrstaPrihoda = row["VrstaPrihoda"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("IncomeTypeInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", vrstaPrihoda);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@Code", idVrstaPrihoda);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
