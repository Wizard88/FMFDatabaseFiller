using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class Municipality : ICommand
    {
        private readonly DataTable _table;

        public Municipality(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idSjediste = row["IdSjediste"];
                object sjediste = row["Sjediste"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("MunicipalityInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", sjediste);
                cmd.Parameters.AddWithValue("@Code", );
                cmd.Parameters.AddWithValue("@CantonID", );
                cmd.Parameters.AddWithValue("@Description", );
                cmd.Parameters.AddWithValue("@zOrder", );
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Active", );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
