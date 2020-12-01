using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class Refund : ICommand
    {
        private readonly DataTable _table;

        public Refund(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idPodnosilacZahtjeva = row["IdPodnosilacZahtjeva"];
                object idStranaZaPovrat = row["IdStranaZaPovrat"];
                object idUImeKoga = row["IdUImeKoga"];
                object brojPredmeta = row["BrojPredmeta"];
                object datumPredmeta = row["DatumPredmeta"];
                object datumPrijemaURad = row["DatumPrijemaURad"];
                object zavrsenPredmet = row["ZavrsenPredmet"];
                object idStatusPredmeta = row["IdStatusPredmeta"];
                object brojZahtjeva = row["BrojZahtjeva"];
                object datumZahtjeva = row["DatumZahtjeva"];
                object idKontrolniOrgan = row["IdKontrolniOrgan"];
                object datumKaKontrolnomOrganu = row["DatumKaKontrolnomOrganu"];
                object brojKontrolnogOrgana = row["BrojKontrolnogOrgana"];
                object datumKontrolnogOrgana = row["DatumKontrolnogOrgana"];
                object brojSporazuma = row["BrojSporazuma"];
                object datumSporazuma = row["DatumSporazuma"];
                object idVrstaPovrata = row["IdVrstaPovrata"];
                object idRacunPlacanja = row["IdRacunPlacanja"];
                object ukupnoPotrazivanje = row["UkupnoPotrazivanje"];
                object glavnica = row["Glavnica"];
                object kamata = row["Kamata"];
                object brojRata = row["BrojRata"];
                object idVrstaPrihoda = row["IdVrstaPrihoda"];
                object datumPlacanja = row["DatumPlacanja"];
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object idBudzetskaGodina = row["IdBudzetskaGodina"];
                object spremnoZaIsplatu = row["SpremnoZaIsplatu"];
                object idVezePredmeta = row["IdVezePredmeta"];
                object kontrola = row["Kontrola"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];


            }
        }
    }
}
