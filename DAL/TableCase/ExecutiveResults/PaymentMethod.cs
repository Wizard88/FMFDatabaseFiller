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

                cmd.Parameters.AddWithValue("@Title", nacinPlacanja);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Active", null);
                cmd.Parameters.AddWithValue("@Code", idNacinPlacanja);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
