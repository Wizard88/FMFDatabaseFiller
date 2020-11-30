using System.Data;

namespace DAL.TableCase
{
    internal class JudgmentAndExecutiveResultRelation : ICommand
    {
        private readonly DataTable _table;

        public JudgmentAndExecutiveResultRelation(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object predmetVezeOd = row["PredmetVezeOd"];

            }
        }
    }
}
