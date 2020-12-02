using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class JudgmentAndExecutiveResultInstallmentAndPayment : ICommand
    {
        private readonly DataTable _table;

        public JudgmentAndExecutiveResultInstallmentAndPayment(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
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

                SqlCommand cmdResultInstallment = new SqlCommand("JudgmentAndExecutiveResultInstallment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdResultInstallment.Parameters.AddWithValue("@JudgmentAndExecutiveResultID",);
                cmdResultInstallment.Parameters.AddWithValue("@DeliveryDate",);
                cmdResultInstallment.Parameters.AddWithValue("@BudgetYear",);
                cmdResultInstallment.Parameters.AddWithValue("@PaymentStatusID",);
                cmdResultInstallment.Parameters.AddWithValue("@CourtCostIzvr",);
                cmdResultInstallment.Parameters.AddWithValue("@CourtCostPar",);
                cmdResultInstallment.Parameters.AddWithValue("@CourtCostTotal",);
                cmdResultInstallment.Parameters.AddWithValue("@LoanPrincipalOrInstallment",);
                cmdResultInstallment.Parameters.AddWithValue("@Interest",);
                cmdResultInstallment.Parameters.AddWithValue("@InterestGlav",);
                cmdResultInstallment.Parameters.AddWithValue("@InterestTp",);
                cmdResultInstallment.Parameters.AddWithValue("@InterestTotal",);
                cmdResultInstallment.Parameters.AddWithValue("@Note",);
                cmdResultInstallment.Parameters.AddWithValue("@OrdinalNumber",);
                cmdResultInstallment.Parameters.AddWithValue("@CreatedBy",);

                SqlCommand cmdResultPayment = new SqlCommand("JudgmentAndExecutiveResultPayment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdResultPayment.Parameters.AddWithValue("@JudgmentAndExecutiveResultID",);
                cmdResultPayment.Parameters.AddWithValue("@JudgmentAndExecutiveResultInstallmentID",);
                cmdResultPayment.Parameters.AddWithValue("@DocumentNumber",);
                cmdResultPayment.Parameters.AddWithValue("@DocumentDate",);
                cmdResultPayment.Parameters.AddWithValue("@BudgetYear",);
                cmdResultPayment.Parameters.AddWithValue("@MinistryBankAccountID",);
                cmdResultPayment.Parameters.AddWithValue("@StatementNumber",);
                cmdResultPayment.Parameters.AddWithValue("@RecivedDocumentNumber",);
                cmdResultPayment.Parameters.AddWithValue("@RecivedDate",);
                cmdResultPayment.Parameters.AddWithValue("@RecivedBankDate",);
                cmdResultPayment.Parameters.AddWithValue("@TaxPayerID",);
                cmdResultPayment.Parameters.AddWithValue("@TaxPayerBankAccountID",);
                cmdResultPayment.Parameters.AddWithValue("@PayOutDate",);
                cmdResultPayment.Parameters.AddWithValue("@LoanPrincipalOrInstallment",);
                cmdResultPayment.Parameters.AddWithValue("@Interest",);
                cmdResultPayment.Parameters.AddWithValue("@InterestGlav",);
                cmdResultPayment.Parameters.AddWithValue("@InterestTp",);
                cmdResultPayment.Parameters.AddWithValue("@InterestTotal",);
                cmdResultPayment.Parameters.AddWithValue("@CourtCostIzvr",);
                cmdResultPayment.Parameters.AddWithValue("@CourtCostPar",);
                cmdResultPayment.Parameters.AddWithValue("@CourtCostTotal",);
                cmdResultPayment.Parameters.AddWithValue("@WriteOff",);
                cmdResultPayment.Parameters.AddWithValue("@WriteOffDate",);
                cmdResultPayment.Parameters.AddWithValue("@ForPayOut",);
                cmdResultPayment.Parameters.AddWithValue("@Note",);
                cmdResultPayment.Parameters.AddWithValue("@CreatedBy",);
                cmdResultPayment.Parameters.AddWithValue("@BankID",);

                cmdResultInstallment.ExecuteNonQuery();
                cmdResultPayment.ExecuteNonQuery();
            }
        }
    }
}
