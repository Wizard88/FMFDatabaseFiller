using System.Data;

namespace DAL.TableCase
{
    internal class IncomeType : ICommand
    {
        private readonly DataTable _table;

        public IncomeType(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaPrihoda = row["VrstaPrihoda"];
                object datumUnosa = row["DatumUnosa"];

            }
        }
    }
}
