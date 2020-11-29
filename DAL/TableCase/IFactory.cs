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
    }
}
