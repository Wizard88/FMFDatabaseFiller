using System.Data;

namespace DAL.TableCase
{
    public class Factory : IFactory
    {
        public ICommand GetBankAccount(DataTable table)
        {
            return new BankAccount(table);
        }

        public ICommand GetBudgetYearFiller(DataTable table)
        {
            return new BudgetYear(table);
        }

        public ICommand GetControlAuthority(DataTable table)
        {
            throw new System.NotImplementedException();
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

        public ICommand GetIncomeType(DataTable table)
        {
            throw new System.NotImplementedException();
        }

        public ICommand GetMunicipality(DataTable table)
        {
            throw new System.NotImplementedException();
        }

        public ICommand GetObligationTypeFiller(DataTable table)
        {
            return new ObligationType(table);
        }

        public ICommand GetOrdinalNumber(DataTable table)
        {
            throw new System.NotImplementedException();
        }

        public ICommand GetPaymentStatusFiller(DataTable table)
        {
            return new PaymentStatus(table);
        }

        public ICommand GetPersonTypeFiller(DataTable table)
        {
            return new PersonType(table);
        }

        public ICommand GetRefund(DataTable table)
        {
            return new Refund(table);
        }

        public ICommand GetRefundPayment(DataTable table)
        {
            return new RefundPayment(table);
        }

        public ICommand GetRefundRelation(DataTable table)
        {
            return new RefundRelation(table);
        }

        public ICommand GetRefundSubjectStatus(DataTable table)
        {
            return new RefundSubjectStatus(table);
        }

        public ICommand GetReturnType(DataTable table)
        {
            return new ReturnType(table);
        }

        public ICommand GetTaxPayer(DataTable tableApplicant, DataTable tableNameOfApplicant)
        {
            return new TaxPayer(tableApplicant, tableNameOfApplicant);
        }
    }
}
