using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.DecisionsOConstitutionalCourt
{
    internal class PersonType : ICommand
    {
        private readonly DataTable _table;

        public PersonType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idTipOsobe = row["IdTipOsobe"];
                object tipOsobe = row["TipOsobe"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("PersonTypeInsert", SQLSingleton.Instance.SqlConnection)
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
