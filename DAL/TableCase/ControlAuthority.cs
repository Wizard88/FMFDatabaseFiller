using System.Data;

namespace DAL.TableCase
{
    internal class ControlAuthority : ICommand
    {
        private readonly DataTable _table;

        public ControlAuthority(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object kontrolniOrgan = row["KontrolniOrgan"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
