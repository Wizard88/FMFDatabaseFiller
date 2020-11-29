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

        ICommand GetControlAuthority(DataTable table);
        ICommand GetIncomeType(DataTable table);
        ICommand GetMunicipality(DataTable table);
        ICommand GetOrdinalNumber(DataTable table);
        ICommand GetRefund(DataTable table);
        ICommand GetRefundPayment(DataTable table);
        ICommand GetRefundRelation(DataTable table);
        ICommand GetRefundSubjectStatus(DataTable table);
        ICommand GetReturnType(DataTable table);
        ICommand GetTaxPayer(DataTable tableApplicant, DataTable tableNameOfApplicant);
        ICommand GetBankAccount(DataTable table);
    }
}
