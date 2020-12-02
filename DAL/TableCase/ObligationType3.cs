using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class ObligationType3 : ICommand
    {
        private readonly DataTable _table;

        public ObligationType3(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVrstaObaveze = row["IdVrstaObaveze"];
                object idVrstaObavezeGR = row["IdVrstaObavezeGR"];
                object vrstaObaveze = row["VrstaObaveze"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("ObligationTypeInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@ObligationTypeGRID",);
                cmd.Parameters.AddWithValue("@Title",);
                cmd.Parameters.AddWithValue("@Description",);
                cmd.Parameters.AddWithValue("@zOrder",);
                cmd.Parameters.AddWithValue("@CreateDate",);
                cmd.Parameters.AddWithValue("@UserID",);
                cmd.Parameters.AddWithValue("@Active",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
