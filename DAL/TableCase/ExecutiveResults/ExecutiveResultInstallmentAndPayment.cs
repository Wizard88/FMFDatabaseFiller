using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class ExecutiveResultInstallmentAndPayment : ICommand
    {
        private readonly DataTable _table;

        public ExecutiveResultInstallmentAndPayment(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idPresudeIsplata = row["IdPresudeIsplata"];
                object idPresudeIR = row["IdPresudeIR"];
                object idOsobaFirma = row["IdOsobaFirma"];
                object brojRjesenjaIsplate = row["BrojRjesenjaIsplate"];
                object datumRjesenjaIsplate = row["DatumRjesenjaIsplate"];
                object idStatusOsobaFirma = row["IdStatusOsobaFirma"];
                object datumSpremnostiIsplate = row["DatumSpremnostiIsplate"];
                object idVrstaObaveze = row["IdVrstaObaveze"];
                object idOsnovZaPlacanje = row["IdOsnovZaPlacanje"];
                object idNacinPlacanja = row["IdNacinPlacanja"];
                object brojRata = row["BrojRata"];
                object zaIsplatu = row["ZaIsplatu"];
                object glavnicaRataP = row["GlavnicaRataP"];
                object kamataP = row["KamataP"];
                object kamataGlavP = row["KamataGlavP"];
                object kamataTP = row["KamataTP"];
                object troskoviIzvrsenja = row["TroskoviIzvrsenja"];
                object troskoviParnPostupka = row["TroskoviParnPostupka"];
                object datumPlacanja = row["DatumPlacanja"];
                object brojIzvoda = row["BrojIzvoda"];
                object idGodinaBudzeta = row["IdGodinaBudzeta"];
                object idBudzetskiKorisnik = row["IdBudzetskiKorisnik"];
                object idBanka = row["IdBanka"];
                object brojDokZaprimanja = row["BrojDokZaprimanja"];
                object datumZaprimanja = row["DatumZaprimanja"];
                object datumBankaZaprimanja = row["DatumBankaZaprimanja"];
                object idSjediste = row["IdSjediste"];
                object brojRacuna = row["BrojRacuna"];
                object brojPartije = row["BrojPartije"];
                object glavnicaISP = row["GlavnicaISP"];
                object kamataISP = row["KamataISP"];
                object kamataGlavISP = row["KamataGlavISP"];
                object kamataTPSP = row["KamataTPSP"];
                object sudTroskoviSP = row["SudTroskoviSP"];
                object kontrola2 = row["Kontrola2"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];

                string statusPlacanja = (datumPlacanja == null) ? "Neplaćeno" : "Plaćeno";
                double tempTroskoviIzvrsenja = (troskoviIzvrsenja == null) ? 0 : Convert.ToDouble(troskoviIzvrsenja);
                double tempTroskoviParnPostupka = (troskoviParnPostupka == null) ? 0 : Convert.ToDouble(troskoviParnPostupka);
                double totalSudTroskovi = tempTroskoviIzvrsenja + tempTroskoviParnPostupka;

                double tempKamataISP = (kamataISP == null) ? 0 : Convert.ToDouble(kamataISP);
                double tempKamataGlavISP = (kamataGlavISP == null) ? 0 : Convert.ToDouble(kamataGlavISP);
                double tempKamataTPSP = (kamataTPSP == null) ? 0 : Convert.ToDouble(kamataTPSP);
                double tempTotal = tempKamataISP + tempKamataGlavISP + tempKamataTPSP;

                int tempBudzetskaGodinaID = Convert.ToInt32(idGodinaBudzeta);
                int tempBudzetskaGodina = Utility.GetBudgetYear(tempBudzetskaGodinaID);

                SqlCommand cmdInstallment = new SqlCommand("JudgmentAndExecutiveResultInstallment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdInstallment.Parameters.AddWithValue("@JudgmentAndExecutiveResultID",);
                cmdInstallment.Parameters.AddWithValue("@DeliveryDate", null);
                cmdInstallment.Parameters.AddWithValue("@BudgetYear", tempBudzetskaGodina);
                cmdInstallment.Parameters.AddWithValue("@PaymentStatusID", statusPlacanja);
                cmdInstallment.Parameters.AddWithValue("@CourtCostIzvr", tempTroskoviIzvrsenja);
                cmdInstallment.Parameters.AddWithValue("@CourtCostPar", tempTroskoviParnPostupka);
                cmdInstallment.Parameters.AddWithValue("@CourtCostTotal", totalSudTroskovi);
                cmdInstallment.Parameters.AddWithValue("@LoanPrincipalOrInstallment", glavnicaRataP);
                cmdInstallment.Parameters.AddWithValue("@Interest", tempKamataISP);
                cmdInstallment.Parameters.AddWithValue("@InterestGlav", tempKamataGlavISP);
                cmdInstallment.Parameters.AddWithValue("@InterestTp", tempKamataTPSP);
                cmdInstallment.Parameters.AddWithValue("@InterestTotal", tempTotal);
                cmdInstallment.Parameters.AddWithValue("@Note", napomena);
                cmdInstallment.Parameters.AddWithValue("@OrdinalNumber", );
                cmdInstallment.Parameters.AddWithValue("@CreatedBy", 9);

                SqlCommand cmdPayment = new SqlCommand("JudgmentAndExecutiveResultPayment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdPayment.Parameters.AddWithValue("@JudgmentAndExecutiveResultID", );
                cmdPayment.Parameters.AddWithValue("@JudgmentAndExecutiveResultInstallmentID", );
                cmdPayment.Parameters.AddWithValue("@DocumentNumber", brojRjesenjaIsplate);
                cmdPayment.Parameters.AddWithValue("@DocumentDate", datumRjesenjaIsplate);
                cmdPayment.Parameters.AddWithValue("@BudgetYear", tempBudzetskaGodina);
                cmdPayment.Parameters.AddWithValue("@MinistryBankAccountID", null);
                cmdPayment.Parameters.AddWithValue("@StatementNumber", 1);
                cmdPayment.Parameters.AddWithValue("@RecivedDocumentNumber", brojDokZaprimanja);
                cmdPayment.Parameters.AddWithValue("@RecivedDate", datumZaprimanja);
                cmdPayment.Parameters.AddWithValue("@RecivedBankDate", datumBankaZaprimanja);
                cmdPayment.Parameters.AddWithValue("@TaxPayerID", idOsobaFirma);
                cmdPayment.Parameters.AddWithValue("@TaxPayerBankAccountID", null);
                cmdPayment.Parameters.AddWithValue("@PayOutDate", datumPlacanja);
                cmdPayment.Parameters.AddWithValue("@LoanPrincipalOrInstallment", glavnicaRataP);
                cmdPayment.Parameters.AddWithValue("@Interest", tempKamataISP);
                cmdPayment.Parameters.AddWithValue("@InterestGlav", tempKamataGlavISP);
                cmdPayment.Parameters.AddWithValue("@InterestTp", tempKamataTPSP);
                cmdPayment.Parameters.AddWithValue("@InterestTotal", tempTotal);
                cmdPayment.Parameters.AddWithValue("@CourtCostIzvr", tempTroskoviIzvrsenja);
                cmdPayment.Parameters.AddWithValue("@CourtCostPar", tempTroskoviParnPostupka);
                cmdPayment.Parameters.AddWithValue("@CourtCostTotal", totalSudTroskovi);
                cmdPayment.Parameters.AddWithValue("@WriteOff", false);
                cmdPayment.Parameters.AddWithValue("@WriteOffDate", null);
                cmdPayment.Parameters.AddWithValue("@ForPayOut", false);
                cmdPayment.Parameters.AddWithValue("@Note", napomena);
                cmdPayment.Parameters.AddWithValue("@CreatedBy", 9);
                cmdPayment.Parameters.AddWithValue("@BankID", idBanka);

                cmdInstallment.ExecuteNonQuery();
                cmdPayment.ExecuteNonQuery();
            }
        }
    }
}