using System.Data;

namespace DAL.TableCase
{
    public class Factory : IFactory
    {
        public ICommand GetBankAccountFiller(DataTable table)
        {
            return new MinistryBankAccount(table);
        }

        public ICommand GetBudgetYearFiller(DataTable table)
        {
            return new BudgetYear(table);
        }

        public ICommand GetControlAuthorityFiller(DataTable table)
        {
            return new ControlAuthority(table);
        }

        public ICommand GetCurrencyTypeFiller(DataTable table)
        {
            return new CurrencyType(table);
        }

        public ICommand GetDecisionFiller(DataTable tableAPCH, DataTable tableCH)
        {
            return new Decision(tableAPCH, tableCH);
        }

        public ICommand GetDecisionPaymentFiller(DataTable table)
        {
            return new DecisionPayment(table);
        }

        public ICommand GetIncomeTypeFiller(DataTable table)
        {
            return new IncomeType(table);
        }

        public ICommand GetMunicipalityFiller(DataTable table)
        {
            return new Municipality(table);
        }

        public ICommand GetObligationTypeFiller(DataTable table)
        {
            return new ObligationType(table);
        }

        public ICommand GetOrdinalNumberFiller(DataTable table)
        {
            return new OrdinalNumber(table);
        }

        public ICommand GetPaymentStatusFiller(DataTable table)
        {
            return new PaymentStatus(table);
        }

        public ICommand GetPersonTypeFiller(DataTable table)
        {
            return new PersonType(table);
        }

        public ICommand GetRefundFiller(DataTable table)
        {
            return new Refund(table);
        }

        public ICommand GetRefundPaymentFiller(DataTable table)
        {
            return new RefundInstallmentAndPayment(table);
        }

        public ICommand GetRefundRelationFiller(DataTable table)
        {
            return new RefundRelation(table);
        }

        public ICommand GetRefundSubjectStatusFiller(DataTable table)
        {
            return new RefundSubjectStatus(table);
        }

        public ICommand GetReturnTypeFiller(DataTable table)
        {
            return new ReturnType(table);
        }

        public ICommand GetTaxPayerFiller(DataTable tableApplicant, DataTable tableNameOfApplicant)
        {
            return new TaxPayer(tableApplicant, tableNameOfApplicant);
        }
    }
}
