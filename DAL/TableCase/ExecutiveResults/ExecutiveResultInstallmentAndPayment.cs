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

                SqlCommand cmdInstallment = new SqlCommand("JudgmentAndExecutiveResultInstallment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdInstallment.Parameters.AddWithValue("@JudgmentAndExecutiveResultID", );
                cmdInstallment.Parameters.AddWithValue("@DeliveryDate", );
                cmdInstallment.Parameters.AddWithValue("@BudgetYear", );
                cmdInstallment.Parameters.AddWithValue("@PaymentStatusID", );
                cmdInstallment.Parameters.AddWithValue("@CourtCostIzvr", );
                cmdInstallment.Parameters.AddWithValue("@CourtCostPar", );
                cmdInstallment.Parameters.AddWithValue("@CourtCostTotal", );
                cmdInstallment.Parameters.AddWithValue("@LoanPrincipalOrInstallment", );
                cmdInstallment.Parameters.AddWithValue("@Interest", );
                cmdInstallment.Parameters.AddWithValue("@InterestGlav", );
                cmdInstallment.Parameters.AddWithValue("@InterestTp", );
                cmdInstallment.Parameters.AddWithValue("@InterestTotal", );
                cmdInstallment.Parameters.AddWithValue("@Note", );
                cmdInstallment.Parameters.AddWithValue("@OrdinalNumber", );
                cmdInstallment.Parameters.AddWithValue("@CreatedBy", );

                SqlCommand cmdPayment = new SqlCommand("JudgmentAndExecutiveResultPayment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdPayment.Parameters.AddWithValue("@JudgmentAndExecutiveResultID", );
                cmdPayment.Parameters.AddWithValue("@JudgmentAndExecutiveResultInstallmentID", );
                cmdPayment.Parameters.AddWithValue("@DocumentNumber", );
                cmdPayment.Parameters.AddWithValue("@DocumentDate", );
                cmdPayment.Parameters.AddWithValue("@BudgetYear", );
                cmdPayment.Parameters.AddWithValue("@MinistryBankAccountID", );
                cmdPayment.Parameters.AddWithValue("@StatementNumber", );
                cmdPayment.Parameters.AddWithValue("@RecivedDocumentNumber", );
                cmdPayment.Parameters.AddWithValue("@RecivedDate", );
                cmdPayment.Parameters.AddWithValue("@RecivedBankDate", );
                cmdPayment.Parameters.AddWithValue("@TaxPayerID", );
                cmdPayment.Parameters.AddWithValue("@TaxPayerBankAccountID", );
                cmdPayment.Parameters.AddWithValue("@PayOutDate", );
                cmdPayment.Parameters.AddWithValue("@LoanPrincipalOrInstallment", );
                cmdPayment.Parameters.AddWithValue("@Interest", );
                cmdPayment.Parameters.AddWithValue("@InterestGlav", );
                cmdPayment.Parameters.AddWithValue("@InterestTp", );
                cmdPayment.Parameters.AddWithValue("@InterestTotal", );
                cmdPayment.Parameters.AddWithValue("@CourtCostIzvr", );
                cmdPayment.Parameters.AddWithValue("@CourtCostPar", );
                cmdPayment.Parameters.AddWithValue("@CourtCostTotal", );
                cmdPayment.Parameters.AddWithValue("@WriteOff", );
                cmdPayment.Parameters.AddWithValue("@WriteOffDate", );
                cmdPayment.Parameters.AddWithValue("@ForPayOut", );
                cmdPayment.Parameters.AddWithValue("@Note", );
                cmdPayment.Parameters.AddWithValue("@CreatedBy", );
                cmdPayment.Parameters.AddWithValue("@BankID", );

                cmdInstallment.ExecuteNonQuery();
                cmdPayment.ExecuteNonQuery();
            }
        }
    }
}