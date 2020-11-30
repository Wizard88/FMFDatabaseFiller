using System.Data;

namespace DAL.TableCase
{
    internal class BudgetInstitution : ICommand
    {
        private readonly DataTable _table;

        public BudgetInstitution(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object budzetskiKorisnik = row["BudzetskiKorisnik"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
