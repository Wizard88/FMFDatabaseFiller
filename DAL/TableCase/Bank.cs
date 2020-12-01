using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
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
                object banka = row["Banka"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
