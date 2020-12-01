using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class IncomeType : ICommand
    {
        private readonly DataTable _table;

        public IncomeType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaPrihoda = row["VrstaPrihoda"];
                object datumUnosa = row["DatumUnosa"];

            }
        }
    }
}
