using System.Data;

namespace DAL.TableCase
{
    internal class ObligationType : ICommand
    {
        private readonly DataTable _table;

        public ObligationType(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaObaveze = row["VrstaObaveze"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
