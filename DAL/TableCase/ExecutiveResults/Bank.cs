using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class Bank : ICommand
    {
        private readonly DataTable _table;

        public Bank(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idBanka = row["IdBanka"];
                object banka = row["Banka"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("Bank.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title",);
                cmd.Parameters.AddWithValue("@Description",);
                cmd.Parameters.AddWithValue("@zOrder",);
                cmd.Parameters.AddWithValue("@CreateByUser",);
                cmd.Parameters.AddWithValue("@Code",);
                cmd.Parameters.AddWithValue("@MinistryBank",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
