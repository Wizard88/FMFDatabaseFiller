using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class SubjectStatus : ICommand
    {
        private readonly DataTable _table;

        public SubjectStatus(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idTipVezePredmeta = row["IdTipVezePredmeta"];
                object tipVezePredmeta = row["TipVezePredmeta"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("SubjectStatusSave", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", tipVezePredmeta);
                cmd.Parameters.AddWithValue("@Code", idTipVezePredmeta);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@CreatedBy", 9);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
