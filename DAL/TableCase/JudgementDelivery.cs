using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class JudgementDelivery : ICommand
    {
        private readonly DataTable _table;

        public JudgementDelivery(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object dostavljenoOd = row["DostavljenoOd"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
