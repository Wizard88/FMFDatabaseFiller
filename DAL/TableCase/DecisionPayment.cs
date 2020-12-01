using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class DecisionPayment : ICommand
    {
        private readonly DataTable _table;

        public DecisionPayment(DataTable table)
        {
            _table = table;
        }

        public void Execute()
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
                object IdStatusPlacanja = row["IdStatusPlacanja"];
                object datumPlacanja = row["DatumPlacanja"];
                object ddBudzetskaGodina = row["IdBudzetskaGodina"];
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

                SqlCommand cmdPayment = new SqlCommand("DecisionPayment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmdPayment.Parameters.AddWithValue("@DecisionID",);
                cmdPayment.Parameters.AddWithValue("@DecisionInstallmentID",);
                cmdPayment.Parameters.AddWithValue("@DocumentNumber",);
                cmdPayment.Parameters.AddWithValue("@DocumentDate",);
                cmdPayment.Parameters.AddWithValue("@BudgetYear",);
                cmdPayment.Parameters.AddWithValue("@MinistryBankAccountID",);
                cmdPayment.Parameters.AddWithValue("@StatementNumber",);
                cmdPayment.Parameters.AddWithValue("@RecivedDocumentNumber",);
                cmdPayment.Parameters.AddWithValue("@RecivedDate",);
                cmdPayment.Parameters.AddWithValue("@RecivedBankDate",);
                cmdPayment.Parameters.AddWithValue("@TaxPayerID",);
                cmdPayment.Parameters.AddWithValue("@TaxPayerBankAccountID",);
                cmdPayment.Parameters.AddWithValue("@PayOutDate",);
                cmdPayment.Parameters.AddWithValue("@Total",);
                cmdPayment.Parameters.AddWithValue("@CourtCost",);
                cmdPayment.Parameters.AddWithValue("@LoanPrincipal",);
                cmdPayment.Parameters.AddWithValue("@Interest",);
                cmdPayment.Parameters.AddWithValue("@Isknjizavanje",);
                cmdPayment.Parameters.AddWithValue("@DatumIsknjizavanja",);
                cmdPayment.Parameters.AddWithValue("@ForPayOut",);
                cmdPayment.Parameters.AddWithValue("@Note",);
                cmdPayment.Parameters.AddWithValue("@MinistryBankID",);

                cmdPayment.ExecuteNonQuery();

                SqlCommand cmdInstallment = new SqlCommand("DecisionInstallment.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmdInstallment.Parameters.AddWithValue("@DecisionID",);
                cmdInstallment.Parameters.AddWithValue("@DeliveryDate",);
                cmdInstallment.Parameters.AddWithValue("@BudgetYear",);
                cmdInstallment.Parameters.AddWithValue("@PaymentStatusID",);
                cmdInstallment.Parameters.AddWithValue("@Total",);
                cmdInstallment.Parameters.AddWithValue("@CourtCost",);
                cmdInstallment.Parameters.AddWithValue("@LoanPrincipal",);
                cmdInstallment.Parameters.AddWithValue("@Interest",);
                cmdInstallment.Parameters.AddWithValue("@Note",);
                cmdInstallment.Parameters.AddWithValue("@OrdinalNumber",);
                cmdInstallment.Parameters.AddWithValue("@CreatedBy",);

                cmdInstallment.ExecuteNonQuery();
            }
        }
    }
}
