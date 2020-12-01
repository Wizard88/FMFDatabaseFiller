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

                SqlCommand cmd = new SqlCommand("RefundInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@SubjectNumber", );
                cmd.Parameters.AddWithValue("@ReceivingInWorkDate", );
                cmd.Parameters.AddWithValue("@RequestSubmitterID", );
                cmd.Parameters.AddWithValue("@OnBehalfOfWhomID", );
                cmd.Parameters.AddWithValue("@ControlAuthorityActDate", );
                cmd.Parameters.AddWithValue("@ClaimAgreementNumber", );
                cmd.Parameters.AddWithValue("@ClaimAgreementDate", );
                cmd.Parameters.AddWithValue("@ReturnTypeID", );
                cmd.Parameters.AddWithValue("@SubjectDate", );
                cmd.Parameters.AddWithValue("@RequestDate", );
                cmd.Parameters.AddWithValue("@RequestNumber", );
                cmd.Parameters.AddWithValue("@ControlAuthorityID", );
                cmd.Parameters.AddWithValue("@ControlAuthorityActNumber", );
                cmd.Parameters.AddWithValue("@SubjectStatusID", );
                cmd.Parameters.AddWithValue("@NumberOfInstallment", );
                cmd.Parameters.AddWithValue("@TotalClaim", );
                cmd.Parameters.AddWithValue("@PaymentPrincipal", );
                cmd.Parameters.AddWithValue("@PaymentInterest", );
                cmd.Parameters.AddWithValue("@Doknjizavanje", );
                cmd.Parameters.AddWithValue("@DatumDoknjizavanja", );
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaSudTros", );
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaGlavnice", );
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaKamate", );
                cmd.Parameters.AddWithValue("@Note", );
                cmd.Parameters.AddWithValue("@CreatedBy", );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
