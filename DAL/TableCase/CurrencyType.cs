using System.Data;

namespace DAL.TableCase
{
    internal class CurrencyType : ICommand
    {
        private readonly DataTable _table;

        public CurrencyType(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaValute = row["VrstaValute"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
