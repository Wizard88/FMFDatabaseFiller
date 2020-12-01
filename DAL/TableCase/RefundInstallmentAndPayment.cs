using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class RefundInstallmentAndPayment : ICommand
    {
        private readonly DataTable _table;

        public RefundInstallmentAndPayment(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idPovrati = row["IdPovrati"];
                object brojRjesenja = row["BrojRjesenja"];
                object datumRjesenja = row["DatumRjesenja"];
                object idRacunPlacanja = row["IdRacunPlacanja"];
                object idBudzetskaGodina = row["IdBudzetskaGodina"];
                object datumPlacanja = row["DatumPlacanja"];
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object idRata = row["IdRata"];
                object glavnicaPlacanja = row["GlavnicaPlacanja"];
                object kamataPlacanja = row["KamataPlacanja"];
                object spremnoZaIsplatu = row["SpremnoZaIsplatu"];
                object kontrola = row["Kontrola"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmdRefundInstallment = new SqlCommand("RefundInstallmentInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdRefundInstallment.Parameters.AddWithValue("@RefundID", );
                cmdRefundInstallment.Parameters.AddWithValue("@DeliveryDate",);
                cmdRefundInstallment.Parameters.AddWithValue("@BudgetYearID",);
                cmdRefundInstallment.Parameters.AddWithValue("@PaymentStatusID",);
                cmdRefundInstallment.Parameters.AddWithValue("@Total", );
                cmdRefundInstallment.Parameters.AddWithValue("@LoanPrincipal",);
                cmdRefundInstallment.Parameters.AddWithValue("@Interest",);
                cmdRefundInstallment.Parameters.AddWithValue("@Note",);
                cmdRefundInstallment.Parameters.AddWithValue("@OrdinalNumber",);
                cmdRefundInstallment.Parameters.AddWithValue("@CreatedBy",);

                SqlCommand cmdRefundPayment = new SqlCommand("RefundPaymentInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdRefundPayment.Parameters.AddWithValue("@RefundID", );
                cmdRefundPayment.Parameters.AddWithValue("@RefundInstallmentID", );
                cmdRefundPayment.Parameters.AddWithValue("@DocumentNumber", );
                cmdRefundPayment.Parameters.AddWithValue("@DocumentDate", );
                cmdRefundPayment.Parameters.AddWithValue("@BudgetYear", );
                cmdRefundPayment.Parameters.AddWithValue("@PersonFirmBankID", );
                cmdRefundPayment.Parameters.AddWithValue("@TaxPayerID", );
                cmdRefundPayment.Parameters.AddWithValue("@TaxPayerBankAccountID", );
                cmdRefundPayment.Parameters.AddWithValue("@PayOutDate", );
                cmdRefundPayment.Parameters.AddWithValue("@Total", );
                cmdRefundPayment.Parameters.AddWithValue("@LoanPrincipal", );
                cmdRefundPayment.Parameters.AddWithValue("@Interest", );
                cmdRefundPayment.Parameters.AddWithValue("@Isknjizavanje", );
                cmdRefundPayment.Parameters.AddWithValue("@DatumIsknjizavanja", );
                cmdRefundPayment.Parameters.AddWithValue("@Note", );
                cmdRefundPayment.Parameters.AddWithValue("@CreatedBy", );
                cmdRefundPayment.Parameters.AddWithValue("@StatementNumber", );
                cmdRefundPayment.Parameters.AddWithValue("@MinistryBankAccountID", );

                cmdRefundInstallment.ExecuteNonQuery();
                cmdRefundPayment.ExecuteNonQuery();
            }
        }
    }
}
