using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class PaymentMethod : ICommand
    {
        private readonly DataTable _table;

        public PaymentMethod(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idNacinPlacanja = row["IdNacinPlacanja"];
                object nacinPlacanja = row["NacinPlacanja"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("PaymentMethodInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", );
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
