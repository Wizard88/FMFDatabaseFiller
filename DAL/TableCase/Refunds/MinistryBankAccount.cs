using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class MinistryBankAccount : ICommand
    {
        private readonly DataTable _table;

        public MinistryBankAccount(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idRacunPlacanja = row["IdRacunPlacanja"];
                object racunPlacanja = row["RacunPlacanja"];

                SqlCommand cmd = new SqlCommand("MinistryBankAccount.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@BankAccountNumber", );
                cmd.Parameters.AddWithValue("@BankID", );
                cmd.Parameters.AddWithValue("@CreateByUser", );


                cmd.ExecuteNonQuery();
            }
        }
    }
}
