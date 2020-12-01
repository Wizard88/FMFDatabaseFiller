using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.TableCase
{
    internal class Decision : ICommand
    {
        private readonly DataTable _tableAPCH;
        private readonly DataTable _tableCH;

        public Decision(DataTable tableAPCH, DataTable tableCH)
        {
            _tableAPCH = tableAPCH;
            _tableCH = tableCH;
        }

        public void Execute()
        {
            foreach (DataRow row in _tableCH.Rows)
            {
                //row from odluke_CH table
                object idAPCH = row["IdAPCH_odluke"];
                object prezime = row["Prezime"];
                object ime = row["Ime"];
                object osnovOdluke = row["Osnov_odluke"];
                object datumOdluke = row["DatumOdluke"];
                object nasBroj = row["Nas_br"];
                object datumProtokola = row["DatumProtokola"];
                object iznosGlavni = row["Iznos"];
                object troskovi = row["Troskovi"];
                object kamata = row["Kamata"];
                object ukupno = row["Ukupno"];
                object datumObrazacBudzet = row["Datum obrac - budzet"];
                object datumPlacanja = row["DatumPlacanja"];
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object idBudzetskaGodina = row["IdBudzetskaGodina"];
                object datumPrijema = row["Datum prijema"];
                object brojResenjaOIzvrsenju = row["Broj rješenja o izvršenju"];
                object datumResenjaIzvrsenja = row["DatumRjesenjaIzvrsenja"];
                object idVrstaObaveze = row["IdVrstaObaveze"];
                object vrsatObaveze = row["VrstaObaveze"];
                object napomena = row["Napomena"];
                object iznosValuta = row["IznosValuta"];
                object idVrstaValute = row["IdVrstaValute"];
                object brojDokumentaObaveze = row["BrojDokumentaVeze"];
                object datumDokumentaVeze = row["DatumDokumentaVeze"];
                object isplataNaIme = row["IsplataNaIme"];

                EnumerableRowCollection<DataRow> results = from myRow in _tableAPCH.AsEnumerable()
                                                           where myRow.Field<int>("IdAPCH_odluke") == (int)idAPCH
                                                           select myRow;

                DataRow relatedRow = results.FirstOrDefault();

                object apchPrezime = relatedRow["Prezime"];
                object apchIme = relatedRow["Ime"];
                object apchBrojOdluke = relatedRow["BrojAPCH_odluke"];
                object apchDatumOdluke = relatedRow["DatumAPCH_odluke"];
                object apchBrojProtokola = relatedRow["BrojProtokola"];
                object apchDatumDokumenta = relatedRow["DatumDokumenta"];
                object apchDatumPrijema = relatedRow["DatumPrijema"];
                object apchBrojResenjaIzvrsenja = relatedRow["BrojRjesenjaIzvrsenja"];
                object apchDatumResenjaIzvrsenja = relatedRow["DatumRjesenjaIzvrsenja"];
                object apchNapomena = relatedRow["Napomena"];
                object apchDatumUnosa = relatedRow["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("DecisionInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@DecisionNumber", apchBrojOdluke);
                cmd.Parameters.AddWithValue("@ProtocolNumber", apchBrojProtokola);
                cmd.Parameters.AddWithValue("@TaxPayerID",);
                cmd.Parameters.AddWithValue("@BudgetInstitutionID",);
                cmd.Parameters.AddWithValue("@PaymentMethodID",);
                cmd.Parameters.AddWithValue("@NumberOfInstallment",);
                cmd.Parameters.AddWithValue("@LoanPrincipal",);
                cmd.Parameters.AddWithValue("@Interest",);
                cmd.Parameters.AddWithValue("@CourtCost",);
                cmd.Parameters.AddWithValue("@Total",);
                cmd.Parameters.AddWithValue("@DecisionDate",);
                cmd.Parameters.AddWithValue("@ProtocolDate",);
                cmd.Parameters.AddWithValue("@InNameOfTaxPayerID",);
                cmd.Parameters.AddWithValue("@SubjectTypeID",);
                cmd.Parameters.AddWithValue("@SubjectStatusID",);
                cmd.Parameters.AddWithValue("@ObligationTypeID",);
                cmd.Parameters.AddWithValue("@Doknjizavanje",);
                cmd.Parameters.AddWithValue("@DatumDoknjizavanja",);
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaSudTros",);
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaGlavnice",);
                cmd.Parameters.AddWithValue("@IznosDoknjizavanjaKamate",);
                cmd.Parameters.AddWithValue("@Note", apchNapomena);
                cmd.Parameters.AddWithValue("@CreatedBy",);

                cmd.ExecuteNonQuery();

            }
        }
    }
}
