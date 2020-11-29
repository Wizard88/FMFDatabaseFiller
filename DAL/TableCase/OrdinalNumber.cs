using System.Data;

namespace DAL.TableCase
{
    internal class OrdinalNumber : ICommand
    {
        private readonly DataTable _table;

        public OrdinalNumber(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object rata = row["Rata"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
