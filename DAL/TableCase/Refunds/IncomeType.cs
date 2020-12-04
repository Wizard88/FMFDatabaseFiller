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
                cmd.Parameters.AddWithValue("@Description",);
                cmd.Parameters.AddWithValue("@zOrder",);
                cmd.Parameters.AddWithValue("@CreateDate",);
                cmd.Parameters.AddWithValue("@UserID",);
                cmd.Parameters.AddWithValue("@Active",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
