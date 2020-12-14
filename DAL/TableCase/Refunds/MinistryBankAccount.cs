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

                int tempBankID = GetBankID(racunPlacanja.ToString());

                SqlCommand cmd = new SqlCommand("MinistryBankAccount.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@BankAccountNumber", racunPlacanja);
                cmd.Parameters.AddWithValue("@BankID", tempBankID);
                cmd.Parameters.AddWithValue("@CreateByUser", 9);


                cmd.ExecuteNonQuery();
            }
        }

        private int GetBankID(string racunPlacanja)
        {
            if (racunPlacanja.StartsWith("338"))
                return 1;
            else if (racunPlacanja.StartsWith("154"))
                return 35;
            else if (racunPlacanja.StartsWith("102"))
                return 181;
            else
                return 184;
        }
    }
}
