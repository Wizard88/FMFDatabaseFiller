using System.Data;

namespace DAL.TableCase
{
    internal class PersonType : ICommand
    {
        private readonly DataTable _table;

        public PersonType(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object tipOsobe = row["TipOsobe"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
