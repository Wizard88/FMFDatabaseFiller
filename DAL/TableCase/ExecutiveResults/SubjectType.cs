using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class SubjectType : ICommand
    {
        private readonly DataTable _table;

        public SubjectType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVrstaPredmeta = row["IdVrstaPredmeta"];
                object vrstaPredmeta = row["VrstaPredmeta"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("SubjectTypeInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", vrstaPredmeta);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Active", 1);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
