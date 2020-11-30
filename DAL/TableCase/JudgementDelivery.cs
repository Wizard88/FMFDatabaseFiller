using System.Data;

namespace DAL.TableCase
{
    internal class JudgementDelivery : ICommand
    {
        private readonly DataTable _table;

        public JudgementDelivery(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object dostavljenoOd = row["DostavljenoOd"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
