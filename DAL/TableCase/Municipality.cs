using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class Municipality : ICommand
    {
        private readonly DataTable _table;

        public Municipality(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object sjediste = row["Sjediste"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
