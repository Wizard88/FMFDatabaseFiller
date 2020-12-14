using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
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
                object idPovrati = row["IdPovrati"];
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

                SqlCommand cmd = new SqlCommand("RefundInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@SubjectNumber", brojPredmeta);
                cmd.Parameters.AddWithValue("@ReceivingInWorkDate", datumPrijemaURad);
                cmd.Parameters.AddWithValue("@RequestSubmitterID", idPodnosilacZahtjeva);
                cmd.Parameters.AddWithValue("@OnBehalfOfWhomID", idUImeKoga);
                cmd.Parameters.AddWithValue("@ControlAuthorityActDate", datumKaKontrolnomOrganu);
                cmd.Parameters.AddWithValue("@ClaimAgreementNumber", brojSporazuma);
                cmd.Parameters.AddWithValue("@ClaimAgreementDate", datumSporazuma);
                cmd.Parameters.AddWithValue("@ReturnTypeID", );
                cmd.Parameters.AddWithValue("@SubjectDate", datumPredmeta);
                cmd.Parameters.AddWithValue("@RequestDate", datumZahtjeva);
                cmd.Parameters.AddWithValue("@RequestNumber", brojZahtjeva);
                cmd.Parameters.AddWithValue("@ControlAuthorityID", idKontrolniOrgan);
                cmd.Parameters.AddWithValue("@ControlAuthorityActNumber", brojKontrolnogOrgana);
                cmd.Parameters.AddWithValue("@SubjectStatusID", idStatusPlacanja);
                cmd.Parameters.AddWithValue("@NumberOfInstallment", brojRata);
                cmd.Parameters.AddWithValue("@TotalClaim", ukupnoPotrazivanje);
                cmd.Parameters.AddWithValue("@PaymentPrincipal", glavnica);
                cmd.Parameters.AddWithValue("@PaymentInterest", kamata);
                cmd.Parameters.AddWithValue("@Doknjizavanje", false);
                cmd.Parameters.AddWithValue("@DatumDoknjizavanja", null);
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaSudTros", null);
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaGlavnice", null);
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaKamate", null);
                cmd.Parameters.AddWithValue("@Note", napomena);
                cmd.Parameters.AddWithValue("@CreatedBy", 9);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
