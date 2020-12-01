using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class ReturnType : ICommand
    {
        private readonly DataTable _table;

        public ReturnType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaPovrata = row["VrstaPovrata"];
                object datumUnosa = row["DatumUnosa"];

            }
        }
    }
}
