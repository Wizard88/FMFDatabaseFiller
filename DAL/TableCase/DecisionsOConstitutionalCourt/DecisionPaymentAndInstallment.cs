using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.DecisionsOConstitutionalCourt
{
    internal class DecisionPaymentAndInstallment : ICommand
    {
        private readonly DataTable _table;

        public DecisionPaymentAndInstallment(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idAPCHOdlukeIsplata = row["IdAPCH_odlukeIsplata"];
                object idAPCHOdluke = row["IdAPCH_odluke"];
                object brojProtokola = row["BrojProtokola"];
                object datumProtokola = row["DatumProtokola"];
                object brojRjesenjaIzvrsenja = row["BrojRjesenjaIzvrsenja"];
                object datumRjesenjaIzvrsenja = row["DatumRjesenjaIzvrsenja"];
                object datumPrijema = row["DatumPrijema"];
                object idVrstaObaveze = row["IdVrstaObaveze"];
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object datumPlacanja = row["DatumPlacanja"];
                object idBudzetskaGodina = row["IdBudzetskaGodina"];
                object glavnica = row["Glavnica"];
                object sudskiTroskovi = row["SudskiTroskovi"];
                object kamata = row["Kamata"];
                object iznosValuta = row["IznosValuta"];
                object idVrstaValute = row["IdVrstaValute"];
                object idTipOsobe = row["IdTipOsobe"];
                object isplataNaIme = row["IsplataNaIme"];
                object brojDokumentaVeze = row["BrojDokumentaVeze"];
                object datumDokumentaVeze = row["DatumDokumentaVeze"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];

                //checking values
                idStatusPlacanja = (idStatusPlacanja == null) ? "Nepoznato" : idStatusPlacanja;
                double tempSudskiTroskovi = (sudskiTroskovi == null) ? 0 : Convert.ToDouble(sudskiTroskovi);
                double tempGlavnica = (glavnica == null) ? 0 : Convert.ToDouble(glavnica);
                double tempKamata = (kamata == null) ? 0 : Convert.ToDouble(kamata);

                double total = tempSudskiTroskovi + tempGlavnica + tempKamata;

                SqlCommand cmdPayment = new SqlCommand("DecisionPayment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdPayment.Parameters.AddWithValue("@DecisionID", idAPCHOdluke);
                cmdPayment.Parameters.AddWithValue("@DecisionInstallmentID", idAPCHOdlukeIsplata);
                cmdPayment.Parameters.AddWithValue("@DocumentNumber", brojRjesenjaIzvrsenja);
                cmdPayment.Parameters.AddWithValue("@DocumentDate", datumRjesenjaIzvrsenja);
                cmdPayment.Parameters.AddWithValue("@BudgetYear",);
                cmdPayment.Parameters.AddWithValue("@MinistryBankAccountID", null);
                cmdPayment.Parameters.AddWithValue("@StatementNumber", null);
                cmdPayment.Parameters.AddWithValue("@RecivedDocumentNumber", null);
                cmdPayment.Parameters.AddWithValue("@RecivedDate", datumPrijema);
                cmdPayment.Parameters.AddWithValue("@RecivedBankDate",);
                cmdPayment.Parameters.AddWithValue("@TaxPayerID",);
                cmdPayment.Parameters.AddWithValue("@TaxPayerBankAccountID", null);
                cmdPayment.Parameters.AddWithValue("@PayOutDate", datumPlacanja);
                cmdPayment.Parameters.AddWithValue("@Total", total);
                cmdPayment.Parameters.AddWithValue("@CourtCost", sudskiTroskovi);
                cmdPayment.Parameters.AddWithValue("@LoanPrincipal", glavnica);
                cmdPayment.Parameters.AddWithValue("@Interest", kamata);
                cmdPayment.Parameters.AddWithValue("@Isknjizavanje", false);
                cmdPayment.Parameters.AddWithValue("@DatumIsknjizavanja", null);
                cmdPayment.Parameters.AddWithValue("@ForPayOut", false);
                cmdPayment.Parameters.AddWithValue("@Note", napomena);
                cmdPayment.Parameters.AddWithValue("@MinistryBankID", null);

                SqlCommand cmdInstallment = new SqlCommand("DecisionInstallment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmdInstallment.Parameters.AddWithValue("@DecisionID",);
                cmdInstallment.Parameters.AddWithValue("@DeliveryDate", null);
                cmdInstallment.Parameters.AddWithValue("@BudgetYear", );
                cmdInstallment.Parameters.AddWithValue("@PaymentStatusID", idStatusPlacanja);
                cmdInstallment.Parameters.AddWithValue("@Total", total);
                cmdInstallment.Parameters.AddWithValue("@CourtCost", tempSudskiTroskovi);
                cmdInstallment.Parameters.AddWithValue("@LoanPrincipal", tempGlavnica);
                cmdInstallment.Parameters.AddWithValue("@Interest", tempKamata);
                cmdInstallment.Parameters.AddWithValue("@Note", napomena);
                cmdInstallment.Parameters.AddWithValue("@OrdinalNumber", 1);
                cmdInstallment.Parameters.AddWithValue("@CreatedBy", 9);

                cmdPayment.ExecuteNonQuery();
                cmdInstallment.ExecuteNonQuery();
            }
        }
    }
}
