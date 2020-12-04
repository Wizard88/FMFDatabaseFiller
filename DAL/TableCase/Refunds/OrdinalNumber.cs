using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class OrdinalNumber : ICommand
    {
        private readonly DataTable _table;

        public OrdinalNumber(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idRata = row["IdRata"];
                object rata = row["Rata"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
