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

                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResultNumber", brojPresudeIR);
                cmd.Parameters.AddWithValue("@ProtocolNumber", brojProtokola);
                cmd.Parameters.AddWithValue("@TaxPayerID",);
                cmd.Parameters.AddWithValue("@BudgetInstitutionID",);
                cmd.Parameters.AddWithValue("@PaymentMethodID",);
                cmd.Parameters.AddWithValue("@NumberOfInstallment",);
                cmd.Parameters.AddWithValue("@LoanPrincipalOrInstallment",);
                cmd.Parameters.AddWithValue("@LoanPrincipalTotal",);
                cmd.Parameters.AddWithValue("@CourtCostsIzvr",);
                cmd.Parameters.AddWithValue("@CourtCostsPar",);
                cmd.Parameters.AddWithValue("@CourtCostTotal",);
                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResultDate", datumPresudeIR);
                cmd.Parameters.AddWithValue("@ProtocolDate", datumProtokola);
                cmd.Parameters.AddWithValue("@SubjectTypeID", idVrstaPredmeta);
                cmd.Parameters.AddWithValue("@SubjectStatusID", idStatusPredmeta);
                cmd.Parameters.AddWithValue("@ObligationTypeID", "Nepoznato");
                cmd.Parameters.AddWithValue("@Interest",);
                cmd.Parameters.AddWithValue("@InterestGlav",);
                cmd.Parameters.AddWithValue("@InterestTp",);
                cmd.Parameters.AddWithValue("@InterestTotal",);
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
