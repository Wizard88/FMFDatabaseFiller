using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class RefundRelation : ICommand
    {
        private readonly DataTable _table;

        public RefundRelation(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVezePredmeta = row["IdVezePredmeta"];
                object idPovrati = row["IdPovrati"];
                object brojVezePredmeta = row["BrojVezePredmeta"];
                object datumVezePredmeta = row["DatumVezePredmeta"];
                object idVrstaVezePredmeta = row["IdVrstaVezePredmeta"];
                object idVezaPredmetaOdKoga = row["IdVezaPredmetaOdKoga"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("RefundRelationSave", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Refund1ID", idPovrati);
                cmd.Parameters.AddWithValue("@Refund2ID", idVezaPredmetaOdKoga);
                cmd.Parameters.AddWithValue("@UserID", 9);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
