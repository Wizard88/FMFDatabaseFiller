using System.Data;

namespace DAL.Submodules
{
    public interface IFactory
    {
        ICommand GetDecisionsOfTheConstitutionalCourt(DataSet dataSet, bool isTransactionAllowed);
        ICommand GetJudgmentsRefunds(DataSet dataSet, bool isTransactionAllowed);
    }
}
