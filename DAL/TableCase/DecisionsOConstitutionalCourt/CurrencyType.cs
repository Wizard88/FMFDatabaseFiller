using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.DecisionsOConstitutionalCourt
{
    internal class CurrencyType : ICommand
    {
        private readonly DataTable _table;

        public CurrencyType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVrstaValute = row["IdVrstaValute"];
                object vrstaValute = row["VrstaValute"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("CurrencyTypeInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title",);
                cmd.Parameters.AddWithValue("@Description", );
                cmd.Parameters.AddWithValue("@zOrder", );
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", );
                cmd.Parameters.AddWithValue("@Active", );
                cmd.Parameters.AddWithValue("@Code", );
                cmd.Parameters.AddWithValue("@LocalCurrency", );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
