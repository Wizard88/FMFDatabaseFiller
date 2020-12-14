using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class RefundPaymentAndInstallment : ICommand
    {
        private readonly DataTable _table;

        public RefundPaymentAndInstallment(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idPovratiPlacanje = row["IdPovratiPlacanje"];
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

                //checking values
                idStatusPlacanja = (idStatusPlacanja == null) ? "Nepoznato" : idStatusPlacanja;
                double tempGlavnica = (glavnicaPlacanja == null) ? 0 : Convert.ToDouble(glavnicaPlacanja);
                double tempKamata = (kamataPlacanja == null) ? 0 : Convert.ToDouble(kamataPlacanja);
                double total = tempGlavnica + tempKamata;


                SqlCommand cmdRefundInstallment = new SqlCommand("RefundInstallmentInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdRefundInstallment.Parameters.AddWithValue("@RefundID", idPovrati);
                cmdRefundInstallment.Parameters.AddWithValue("@DeliveryDate", null);
                cmdRefundInstallment.Parameters.AddWithValue("@BudgetYearID", idBudzetskaGodina);
                cmdRefundInstallment.Parameters.AddWithValue("@PaymentStatusID", idStatusPlacanja);
                cmdRefundInstallment.Parameters.AddWithValue("@Total", total);
                cmdRefundInstallment.Parameters.AddWithValue("@LoanPrincipal", tempGlavnica);
                cmdRefundInstallment.Parameters.AddWithValue("@Interest", tempKamata);
                cmdRefundInstallment.Parameters.AddWithValue("@Note", napomena);
                cmdRefundInstallment.Parameters.AddWithValue("@OrdinalNumber", idRata);
                cmdRefundInstallment.Parameters.AddWithValue("@CreatedBy", 9);

                SqlCommand cmdRefundPayment = new SqlCommand("RefundPaymentInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdRefundPayment.Parameters.AddWithValue("@RefundID", idPovrati);
                cmdRefundPayment.Parameters.AddWithValue("@RefundInstallmentID", idPovratiPlacanje);
                cmdRefundPayment.Parameters.AddWithValue("@DocumentNumber", brojRjesenja);
                cmdRefundPayment.Parameters.AddWithValue("@DocumentDate", datumRjesenja);
                cmdRefundPayment.Parameters.AddWithValue("@BudgetYear", idBudzetskaGodina);
                //cmdRefundPayment.Parameters.AddWithValue("@PersonFirmBankID", );
                cmdRefundPayment.Parameters.AddWithValue("@TaxPayerID", );
                cmdRefundPayment.Parameters.AddWithValue("@TaxPayerBankAccountID", );
                cmdRefundPayment.Parameters.AddWithValue("@PayOutDate", datumPlacanja);
                cmdRefundPayment.Parameters.AddWithValue("@Total", total);
                cmdRefundPayment.Parameters.AddWithValue("@LoanPrincipal", tempGlavnica);
                cmdRefundPayment.Parameters.AddWithValue("@Interest", tempKamata);
                cmdRefundPayment.Parameters.AddWithValue("@Isknjizavanje", false);
                cmdRefundPayment.Parameters.AddWithValue("@DatumIsknjizavanja", null);
                cmdRefundPayment.Parameters.AddWithValue("@Note", napomena);
                cmdRefundPayment.Parameters.AddWithValue("@CreatedBy", 9);
                cmdRefundPayment.Parameters.AddWithValue("@StatementNumber", "");
                cmdRefundPayment.Parameters.AddWithValue("@MinistryBankAccountID", idRacunPlacanja);

                cmdRefundInstallment.ExecuteNonQuery();
                cmdRefundPayment.ExecuteNonQuery();
            }
        }
    }
}
