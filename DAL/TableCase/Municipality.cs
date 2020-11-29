using System.Data;

namespace DAL.TableCase
{
    internal class Municipality : ICommand
    {
        private readonly DataTable _table;

        public Municipality(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object sjediste = row["Sjediste"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
