using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class ObligationTypeGR : ICommand
    {
        private readonly DataTable _table;

        public ObligationTypeGR(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaObavezeGR = row["VrstaObavezeGR"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
