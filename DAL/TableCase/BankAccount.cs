using System.Data;

namespace DAL.TableCase
{
    internal class BankAccount : ICommand
    {
        private readonly DataTable _table;

        public BankAccount(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object racunPlacanja = row["RacunPlacanja"];
            }
        }
    }
}
