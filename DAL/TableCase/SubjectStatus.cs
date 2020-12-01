using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class SubjectStatus : ICommand
    {
        private readonly DataTable _table;

        public SubjectStatus(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object tipVezePredmeta = row["TipVezePredmeta"];
                object datumUnosa = row["DatumUnosa"];

            }
        }
    }
}
