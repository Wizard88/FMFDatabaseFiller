using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class SubjectType : ICommand
    {
        private readonly DataTable _table;

        public SubjectType(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaPredmeta = row["VrstaPredmeta"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
