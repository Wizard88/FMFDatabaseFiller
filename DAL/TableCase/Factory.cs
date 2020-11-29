using System.Data;

namespace DAL.TableCase
{
    public class Factory : IFactory
    {
        public ICommand GetBudgetYearFiller(DataTable table)
        {
            return new BudgetYear(table);
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

        public ICommand GetObligationTypeFiller(DataTable table)
        {
            return new ObligationType(table);
        }

        public ICommand GetPaymentStatusFiller(DataTable table)
        {
            return new PaymentStatus(table);
        }

        public ICommand GetPersonTypeFiller(DataTable table)
        {
            return new PersonType(table);
        }
    }
}
