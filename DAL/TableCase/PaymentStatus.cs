using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class PaymentStatus : ICommand
    {
        private readonly DataTable _table;

        public PaymentStatus(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object statusPlacanja = row["StatusPlacanja"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("PaymentStatusInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Status", );
                cmd.Parameters.AddWithValue("@Description", );
                cmd.Parameters.AddWithValue("@zOrder", );
                cmd.Parameters.AddWithValue("@CreateDate", );
                cmd.Parameters.AddWithValue("@UserID", );
                cmd.Parameters.AddWithValue("@Active", );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
