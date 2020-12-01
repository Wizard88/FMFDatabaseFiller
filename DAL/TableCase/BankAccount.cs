using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class BankAccount : ICommand
    {
        private readonly DataTable _table;

        public BankAccount(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object racunPlacanja = row["RacunPlacanja"];
            }
        }
    }
}
