using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class CourtCosts : ICommand
    {
        private readonly DataTable _table;

        public CourtCosts(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaSudTroskova = row["VrstaSudTroskova"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
