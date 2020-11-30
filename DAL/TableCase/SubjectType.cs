using System.Data;

namespace DAL.TableCase
{
    internal class SubjectType : ICommand
    {
        private readonly DataTable _table;

        public SubjectType(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaPredmeta = row["VrstaPredmeta"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
