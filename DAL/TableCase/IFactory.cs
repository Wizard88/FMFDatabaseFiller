using System.Data;

namespace DAL.TableCase
{
    public interface IFactory
    {
        ICommand GetDecisionFiller(DataTable tableAPCH, DataTable tableCH);
        ICommand GetDecisionPaymentFiller(DataTable table);
        ICommand GetPaymentStatusFiller(DataTable table);
        ICommand GetBudgetYearFiller(DataTable table);
        ICommand GetCurrencyTypeFiller(DataTable table);
        ICommand GetObligationTypeFiller(DataTable table);
        ICommand GetPersonTypeFiller(DataTable table);

        ICommand GetControlAuthorityFiller(DataTable table);
        ICommand GetIncomeTypeFiller(DataTable table);
        ICommand GetMunicipalityFiller(DataTable table);
        ICommand GetOrdinalNumberFiller(DataTable table);
        ICommand GetRefundFiller(DataTable table);
        ICommand GetRefundPaymentFiller(DataTable table);
        ICommand GetRefundRelationFiller(DataTable table);
        ICommand GetRefundSubjectStatusFiller(DataTable table);
        ICommand GetReturnTypeFiller(DataTable table);
        ICommand GetTaxPayerFiller(DataTable tableApplicant, DataTable tableNameOfApplicant);
        ICommand GetBankAccountFiller(DataTable table);
    }
}
