using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class ExecutiveResult : ICommand
    {
        private readonly DataTable _table;

        public ExecutiveResult(DataTable table)
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

                SqlCommand cmd = new SqlCommand("JudgmentAndExecutiveResult.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResultNumber",);
                cmd.Parameters.AddWithValue("@ProtocolNumber",);
                cmd.Parameters.AddWithValue("@TaxPayerID",);
                cmd.Parameters.AddWithValue("@BudgetInstitutionID",);
                cmd.Parameters.AddWithValue("@PaymentMethodID",);
                cmd.Parameters.AddWithValue("@NumberOfInstallment",);
                cmd.Parameters.AddWithValue("@LoanPrincipalOrInstallment",);
                cmd.Parameters.AddWithValue("@LoanPrincipalTotal",);
                cmd.Parameters.AddWithValue("@CourtCostsIzvr",);
                cmd.Parameters.AddWithValue("@CourtCostsPar",);
                cmd.Parameters.AddWithValue("@CourtCostTotal",);
                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResultDate",);
                cmd.Parameters.AddWithValue("@ProtocolDate",);
                cmd.Parameters.AddWithValue("@SubjectTypeID",);
                cmd.Parameters.AddWithValue("@SubjectStatusID",);
                cmd.Parameters.AddWithValue("@ObligationTypeID",);
                cmd.Parameters.AddWithValue("@Interest",);
                cmd.Parameters.AddWithValue("@InterestGlav",);
                cmd.Parameters.AddWithValue("@InterestTp",);
                cmd.Parameters.AddWithValue("@InterestTotal",);
                cmd.Parameters.AddWithValue("@AdditionalAccounting",);
                cmd.Parameters.AddWithValue("@AdditionalAccountingDate",);
                cmd.Parameters.AddWithValue("@AdditionalAccountingLegalCosts",);
                cmd.Parameters.AddWithValue("@AdditionalAccountingPrincipal",);
                cmd.Parameters.AddWithValue("@AdditionalAccountingInterestRate",);
                cmd.Parameters.AddWithValue("@Note",);
                cmd.Parameters.AddWithValue("@CreatedBy",);
                cmd.Parameters.AddWithValue("@BankID",);
                cmd.Parameters.AddWithValue("@ExecutiveResultDate",);
                cmd.Parameters.AddWithValue("@ExecutiveResultNumber",);
                cmd.Parameters.AddWithValue("@ActDate",);
                cmd.Parameters.AddWithValue("@ActNumber",);
                cmd.Parameters.AddWithValue("@JudgementDeliveryID",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
