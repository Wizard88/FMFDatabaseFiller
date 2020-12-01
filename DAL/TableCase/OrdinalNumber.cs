using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
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
                object rata = row["Rata"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
