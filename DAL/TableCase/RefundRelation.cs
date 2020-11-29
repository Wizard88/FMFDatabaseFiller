using System.Data;

namespace DAL.TableCase
{
    internal class RefundRelation : ICommand
    {
        private readonly DataTable _table;

        public RefundRelation(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object idPovrati = row["IdPovrati"];
                object brojVezePredmeta = row["BrojVezePredmeta"];
                object datumVezePredmeta = row["DatumVezePredmeta"];
                object idVrstaVezePredmeta = row["IdVrstaVezePredmeta"];
                object idVezaPredmetaOdKoga = row["IdVezaPredmetaOdKoga"];
                object datumUnosa = row["DatumUnosa"];


            }
        }
    }
}
