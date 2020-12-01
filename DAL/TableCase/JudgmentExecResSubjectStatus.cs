using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class JudgmentExecResSubjectStatus : ICommand
    {
        private readonly DataTable _table;

        public JudgmentExecResSubjectStatus(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object statusPredmeta = row["StatusPredmeta"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
