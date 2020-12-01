using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class JudgmentAndExecutiveResultRelation : ICommand
    {
        private readonly DataTable _table;

        public JudgmentAndExecutiveResultRelation(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object predmetVezeOd = row["PredmetVezeOd"];

            }
        }
    }
}
