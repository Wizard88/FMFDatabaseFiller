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

                cmd.Parameters.AddWithValue("@Title", banka);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@CreateByUser", 9);
                cmd.Parameters.AddWithValue("@Code", idBanka);
                cmd.Parameters.AddWithValue("@MinistryBank", 1);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
