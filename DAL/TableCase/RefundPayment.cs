using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class RefundPayment : ICommand
    {
        private readonly DataTable _table;

        public RefundPayment(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idPovrati = row["IdPovrati"];
                object brojRjesenja = row["BrojRjesenja"];
                object datumRjesenja = row["DatumRjesenja"];
                object idRacunPlacanja = row["IdRacunPlacanja"];
                object idBudzetskaGodina = row["IdBudzetskaGodina"];
                object datumPlacanja = row["DatumPlacanja"];
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object idRata = row["IdRata"];
                object glavnicaPlacanja = row["GlavnicaPlacanja"];
                object kamataPlacanja = row["KamataPlacanja"];
                object spremnoZaIsplatu = row["SpremnoZaIsplatu"];
                object kontrola = row["Kontrola"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];

            }
        }
    }
}
