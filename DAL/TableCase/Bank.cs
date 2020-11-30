using System.Data;

namespace DAL.TableCase
{
    internal class Bank : ICommand
    {
        private readonly DataTable _table;

        public Bank(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object banka = row["Banka"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
