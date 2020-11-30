using System.Data;

namespace DAL.TableCase
{
    internal class PaymentMethod : ICommand
    {
        private readonly DataTable _table;

        public PaymentMethod(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object nacinPlacanja = row["NacinPlacanja"];
                object datumUnosa = row["DatumUnosa"];
            }
        }
    }
}
