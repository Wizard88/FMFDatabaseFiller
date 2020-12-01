using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
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
                object sjediste = row["Sjediste"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("MunicipalityInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", );
                cmd.Parameters.AddWithValue("@Code", );
                cmd.Parameters.AddWithValue("@CantonID", );
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
