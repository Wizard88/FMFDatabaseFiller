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
        ICommand GetTaxPayerFirmFiller(DataTable tableNamePersonFirm, DataTable tablePersonFirm);
        ICommand GetBudgetInstitutionUserFiller(DataTable table);
        ICommand GetJudgementDelivery(DataTable table);
        ICommand GetRefundFiller(DataTable table);
        ICommand GetExecutiveResultBudgetYearFiller(DataTable table);
        ICommand GetResultRelationSublectLinkFromFiller(DataTable table);
        ICommand GetPaymentMethod(DataTable table);
        ICommand GetRefundPaymentAndInstallmentFiller(DataTable table);
        ICommand GetRefundRelationFiller(DataTable table);
        ICommand GetRefundPaymentStatusFiller(DataTable table);
        ICommand GetRefundSubjectStatusFiller(DataTable table);
        ICommand GetReturnTypeFiller(DataTable table);
        ICommand GetTaxPayerFiller(DataTable tableApplicant, DataTable tableNameOfApplicant);
        ICommand GetJudgmentAndExecutiveResultFiller(DataTable table);
        ICommand GetExecutiveResultInstallmentAndPaymentFiller(DataTable table);
        ICommand GetMinistryBankAccountFiller(DataTable table);
        ICommand GetRefundSideTaxPayerFiller(DataTable table);
        ICommand GetNameOfWhomTaxPayerFiller(DataTable table);
        ICommand GetExecResSubjectStatusSubjectFiller(DataTable table);
        ICommand GetSubjectStatus(DataTable table);
        ICommand GetExecResSubjectStatusPaymentFiller(DataTable table);
        ICommand GetBudgetInstitutionRespodentFiller(DataTable table);
        ICommand GetTaxPayerRespondentFiller(DataTable table);
        ICommand GetResultRelationSublectLinkFiller(DataTable table);
        ICommand GetJudgmentAndExecutiveObligationTypeFiller(DataTable table);
        ICommand GetObligationTypeGRFiller(DataTable table);
        ICommand GetSubjectType(DataTable table);
    }
}
