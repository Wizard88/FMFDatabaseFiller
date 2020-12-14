using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.DecisionsOConstitutionalCourt
{
    internal class ObligationType : ICommand
    {
        private readonly DataTable _table;

        public ObligationType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVrstaObaveze = row["IdVrstaObaveze"];
                object vrstaObaveze = row["VrstaObaveze"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("ObligationTypeInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@ObligationTypeGRID",);
                cmd.Parameters.AddWithValue("@Title", vrstaObaveze);
                cmd.Parameters.AddWithValue("@Description",);
                cmd.Parameters.AddWithValue("@zOrder",);
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Active",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
