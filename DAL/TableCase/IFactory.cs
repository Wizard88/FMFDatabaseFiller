using System.Data;

namespace DAL.TableCase
{
    public interface IFactory
    {
        ICommand GetDecisionFiller(DataTable tableAPCH, DataTable tableCH);
        ICommand GetDecisionPaymentAndInstallmentFiller(DataTable table);
        ICommand GetPaymentStatusFiller(DataTable table);
        ICommand GetBudgetYearFiller(DataTable table);
        ICommand GetCurrencyTypeFiller(DataTable table);
        ICommand GetObligationTypeFiller(DataTable table);
        ICommand GetPersonTypeFiller(DataTable table);
        ICommand GetBudgetInstitutionFiller(DataTable table);
        ICommand GetIncomeTypeFiller(DataTable table);
        ICommand GetMunicipalityFiller(DataTable table);
        ICommand GetOrdinalNumberFiller(DataTable table);
        ICommand GetBankFiller(DataTable table);
        ICommand GetJudgmentAndExecutiveResultTaxPayerFiller(DataTable tableNamePersonFirm, DataTable tablePersonFirm);
        ICommand GetExecutiveResultBudgetInstitutionFiller(DataTable table);
        ICommand GetJudgementDelivery(DataTable table);
        ICommand GetRefundFiller(DataTable table);
        ICommand GetExecutiveResultBudgetYearFiller(DataTable table);
        ICommand GetJudgmentAndExecutiveResultRelationFiller(DataTable table);
        ICommand GetPaymentMethod(DataTable table);
        ICommand GetRefundPaymentAndInstallmentFiller(DataTable table);
        ICommand GetRefundRelationFiller(DataTable table);
        ICommand GetRefundPaymentStatusFiller(DataTable table);
        ICommand GetRefundSubjectStatusFiller(DataTable table);
        ICommand GetReturnTypeFiller(DataTable table);
        ICommand GetTaxPayerFiller(DataTable tableApplicant, DataTable tableNameOfApplicant);
        ICommand GetMinistryBankAccountFiller(DataTable table);
        ICommand GetRefundSideTaxPayerFiller(DataTable table);
        ICommand GetNameOfWhomTaxPayerFiller(DataTable table);
    }
}
