using System.Data;

namespace DAL.TableCase
{
    internal class RefundSubjectStatus : ICommand
    {
        private readonly DataTable _table;

        public RefundSubjectStatus(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object statusPredmeta = row["StatusPredmeta"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
