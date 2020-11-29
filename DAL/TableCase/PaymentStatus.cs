using System.Data;

namespace DAL.TableCase
{
    internal class PaymentStatus : ICommand
    {
        private readonly DataTable _table;

        public PaymentStatus(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object statusPlacanja = row["StatusPlacanja"];
                object datumUnosa = row["DatumUnosa"];

            }
        }
    }
}
