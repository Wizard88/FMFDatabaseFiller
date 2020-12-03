using System.Data;

namespace DAL.Submodules
{
    public class Factory : IFactory
    {
        public ICommand GetDecisionsOfTheConstitutionalCourt(DataSet dataSet, bool isTransactionAllowed)
        {
            return new DecisionsOfConstitutionalCourt(dataSet, isTransactionAllowed);
        }

        public ICommand GetJudgmentAndExecutiveResult(DataSet dataSet, bool isTransactionAllowed)
        {
            return new JudgmentAndExecutiveResult(dataSet, isTransactionAllowed);
        }

        public ICommand GetJudgmentsRefunds(DataSet dataSet, bool isTransactionAllowed)
        {
            return new JudgmentsRefund(dataSet, isTransactionAllowed);
        }
    }
}
