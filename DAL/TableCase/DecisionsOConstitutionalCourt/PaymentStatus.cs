using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.DecisionsOConstitutionalCourt
{
    internal class PaymentStatus : ICommand
    {
        private readonly DataTable _table;

        public PaymentStatus(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object statusPlacanja = row["StatusPlacanja"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("PaymentStatusInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Status", statusPlacanja);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Active", null);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
