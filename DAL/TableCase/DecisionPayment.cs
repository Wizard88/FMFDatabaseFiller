using System.Data;

namespace DAL.TableCase
{
    internal class DecisionPayment : ICommand
    {
        private readonly DataTable _table;

        public DecisionPayment(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object idAPCHOdlukeIsplata = row["IdAPCH_odlukeIsplata"];
                object IdAPCHOdluke = row["IdAPCH_odluke"];
                object brojProtokola = row["BrojProtokola"];
                object DatumProtokola = row["DatumProtokola"];
                object brojRjesenjaIzvrsenja = row["BrojRjesenjaIzvrsenja"];
                object datumRjesenjaIzvrsenja = row["DatumRjesenjaIzvrsenja"];
                object datumPrijema = row["DatumPrijema"];
                object idVrstaObaveze = row["IdVrstaObaveze"];
                object IdStatusPlacanja = row["IdStatusPlacanja"];
                object datumPlacanja = row["DatumPlacanja"];
                object ddBudzetskaGodina = row["IdBudzetskaGodina"];
                object glavnica = row["Glavnica"];
                object sudskiTroskovi = row["SudskiTroskovi"];
                object kamata = row["Kamata"];
                object iznosValuta = row["IznosValuta"];
                object idVrstaValute = row["IdVrstaValute"];
                object idTipOsobe = row["IdTipOsobe"];
                object isplataNaIme = row["IsplataNaIme"];
                object brojDokumentaVeze = row["BrojDokumentaVeze"];
                object datumDokumentaVeze = row["DatumDokumentaVeze"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];


            }
        }
    }
}
