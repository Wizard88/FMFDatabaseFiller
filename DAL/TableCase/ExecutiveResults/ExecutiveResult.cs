using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.TableCase.ExecutiveResults
{
    internal class ExecutiveResult : ICommand
    {
        private readonly DataTable _tableJudgmentIR;
        private readonly DataTable _tableJudgmentPayment;

        public ExecutiveResult(DataTable tableJudgmentIR, DataTable tableJudgmentPayment)
        {
            _tableJudgmentIR = tableJudgmentIR;
            _tableJudgmentPayment = tableJudgmentPayment;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _tableJudgmentIR.Rows)
            {
                object idPresudeIR = row["IdPresudeIR"];
                object brojPresudeIR = row["BrojPresudeIR"];
                object datumPresudeIR = row["DatumPresudeIR"];
                object brojProtokola = row["BrojProtokola"];
                object datumProtokola = row["DatumProtokola"];
                object datumPrijemaURad = row["DatumPrijemaURad"];
                object idStatusPredmeta = row["IdStatusPredmeta"];
                object idVrstaPredmeta = row["IdVrstaPredmeta"];
                object nazivPredmeta = row["NazivPredmeta"];
                object idDostavljenoOd = row["IdDostavljenoOd"];
                object brojDostavljenoOd = row["BrojDostavljenoOd"];
                object datumDostavljenoOd = row["DatumDostavljenoOd"];
                object brojPresudeOdIR = row["BrojPresudeOdIR"];
                object datumPresudeOdIR = row["DatumPresudeOdIR"];
                object idBanka = row["IdBanka"];
                object brojDokFMFPravob = row["BrojDokFMFPravob"];
                object datumFMFPravobran = row["DatumFMFPravobran"];
                object brojPravobran = row["BrojPravobran"];
                object datumPravobran = row["DatumPravobran"];
                object idTipRjesenjaPravobran = row["IdTipRjesenjaPravobran"];
                object rješenjePravobran = row["RješenjePravobran"];
                object idPresigniranoKome = row["IdPresigniranoKome"];
                object presigniranoKada = row["PresigniranoKada"];
                object presigniranoRazlog = row["PresigniranoRazlog"];
                object idRazlogPresigniranja = row["IdRazlogPresigniranja"];
                object kontrola1 = row["Kontrola1"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];

                EnumerableRowCollection<DataRow> results = from myRow in _tableJudgmentPayment.AsEnumerable()
                                                           where myRow.Field<int>("IdPresudeIR") == (int)idPresudeIR
                                                           select myRow;

                DataRow relatedRow = results.FirstOrDefault();

                object idPresudeIsplata = relatedRow["IdPresudeIsplata"];
                object idOsobaFirma = relatedRow["IdOsobaFirma"];
                object brojRjesenjaIsplate = relatedRow["BrojRjesenjaIsplate"];
                object datumRjesenjaIsplate = relatedRow["DatumRjesenjaIsplate"];
                object idStatusOsobaFirma = relatedRow["IdStatusOsobaFirma"];
                object datumSpremnostiIsplate = relatedRow["DatumSpremnostiIsplate"];
                object idVrstaObaveze = relatedRow["IdVrstaObaveze"];
                object idOsnovZaPlacanje = relatedRow["IdOsnovZaPlacanje"];
                object idNacinPlacanja = relatedRow["IdNacinPlacanja"];
                object brojRata = relatedRow["BrojRata"];
                object zaIsplatu = relatedRow["ZaIsplatu"];
                object glavnicaRataP = relatedRow["GlavnicaRataP"];
                object kamataP = relatedRow["KamataP"];
                object kamataGlavP = relatedRow["KamataGlavP"];
                object kamataTP = relatedRow["KamataTP"];
                object troskoviIzvrsenja = relatedRow["TroskoviIzvrsenja"];
                object troskoviParnPostupka = relatedRow["TroskoviParnPostupka"];
                object datumPlacanja = relatedRow["DatumPlacanja"];
                object brojIzvoda = relatedRow["BrojIzvoda"];
                object idGodinaBudzeta = relatedRow["IdGodinaBudzeta"];
                object idBudzetskiKorisnik = relatedRow["IdBudzetskiKorisnik"];
                object idBankaRelated = relatedRow["IdBanka"];
                object brojDokZaprimanja = relatedRow["BrojDokZaprimanja"];
                object datumZaprimanja = relatedRow["DatumZaprimanja"];
                object datumBankaZaprimanja = relatedRow["DatumBankaZaprimanja"];
                object idSjediste = relatedRow["IdSjediste"];
                object brojRacuna = relatedRow["BrojRacuna"];
                object brojPartije = relatedRow["BrojPartije"];
                object glavnicaISP = relatedRow["GlavnicaISP"];
                object kamataISP = relatedRow["KamataISP"];
                object kamataGlavISP = relatedRow["KamataGlavISP"];
                object kamataTPSP = relatedRow["KamataTPSP"];
                object sudTroskoviSP = relatedRow["SudTroskoviSP"];
                object kontrola2 = relatedRow["Kontrola2"];
                object napomenaRelated = relatedRow["Napomena"];
                object datumUnosaRelated = relatedRow["DatumUnosa"];

                string statusPlacanja = (datumPlacanja == null) ? "Neplaćeno" : "Plaćeno";
                double tempTroskoviIzvrsenja = (troskoviIzvrsenja == null) ? 0 : Convert.ToDouble(troskoviIzvrsenja);
                double tempTroskoviParnPostupka = (troskoviParnPostupka == null) ? 0 : Convert.ToDouble(troskoviParnPostupka);
                double totalSudTroskovi = tempTroskoviIzvrsenja + tempTroskoviParnPostupka;

                double tempKamataISP = (kamataISP == null) ? 0 : Convert.ToDouble(kamataISP);
                double tempKamataGlavISP = (kamataGlavISP == null) ? 0 : Convert.ToDouble(kamataGlavISP);
                double tempKamataTPSP = (kamataTPSP == null) ? 0 : Convert.ToDouble(kamataTPSP);
                double tempTotal = tempKamataISP + tempKamataGlavISP + tempKamataTPSP;


                SqlCommand cmd = new SqlCommand("JudgmentAndExecutiveResult.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResultNumber", brojPresudeIR);
                cmd.Parameters.AddWithValue("@ProtocolNumber", brojProtokola);
                cmd.Parameters.AddWithValue("@TaxPayerID",);
                cmd.Parameters.AddWithValue("@BudgetInstitutionID", idBudzetskiKorisnik);
                cmd.Parameters.AddWithValue("@PaymentMethodID", idNacinPlacanja);
                cmd.Parameters.AddWithValue("@NumberOfInstallment", 1);
                cmd.Parameters.AddWithValue("@LoanPrincipalOrInstallment", glavnicaRataP);
                cmd.Parameters.AddWithValue("@LoanPrincipalTotal", glavnicaRataP);
                cmd.Parameters.AddWithValue("@CourtCostsIzvr", tempTroskoviIzvrsenja);
                cmd.Parameters.AddWithValue("@CourtCostsPar", tempTroskoviParnPostupka);
                cmd.Parameters.AddWithValue("@CourtCostTotal", totalSudTroskovi);
                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResultDate", datumPresudeIR);
                cmd.Parameters.AddWithValue("@ProtocolDate", datumProtokola);
                cmd.Parameters.AddWithValue("@SubjectTypeID", idVrstaPredmeta);
                cmd.Parameters.AddWithValue("@SubjectStatusID", idStatusPredmeta);
                cmd.Parameters.AddWithValue("@ObligationTypeID", "Nepoznato");
                cmd.Parameters.AddWithValue("@Interest", tempKamataISP);
                cmd.Parameters.AddWithValue("@InterestGlav", tempKamataGlavISP);
                cmd.Parameters.AddWithValue("@InterestTp", tempKamataTPSP);
                cmd.Parameters.AddWithValue("@InterestTotal", tempTotal);
                cmd.Parameters.AddWithValue("@AdditionalAccounting", null);
                cmd.Parameters.AddWithValue("@AdditionalAccountingDate", null);
                cmd.Parameters.AddWithValue("@AdditionalAccountingLegalCosts", null);
                cmd.Parameters.AddWithValue("@AdditionalAccountingPrincipal", null);
                cmd.Parameters.AddWithValue("@AdditionalAccountingInterestRate", null);
                cmd.Parameters.AddWithValue("@Note", napomena);
                cmd.Parameters.AddWithValue("@CreatedBy", 9);
                cmd.Parameters.AddWithValue("@BankID", idBanka);
                cmd.Parameters.AddWithValue("@ExecutiveResultDate", datumPresudeOdIR);
                cmd.Parameters.AddWithValue("@ExecutiveResultNumber", brojPresudeOdIR);
                cmd.Parameters.AddWithValue("@ActDate", null);
                cmd.Parameters.AddWithValue("@ActNumber", null);
                cmd.Parameters.AddWithValue("@JudgementDeliveryID", idDostavljenoOd);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
