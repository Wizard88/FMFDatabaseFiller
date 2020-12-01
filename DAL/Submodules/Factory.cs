using System.Data;

namespace DAL.Submodules
{
    public class Factory : IFactory
    {
        public ICommand GetDecisionsOfTheConstitutionalCourt(DataSet dataSet, bool isTransactionAllowed)
        {
            return new OdlukeUstavnogSuda(dataSet, isTransactionAllowed);
        }

        public ICommand GetJudgmentsRefunds(DataSet dataSet, bool isTransactionAllowed)
        {
            return new Povrati(dataSet, isTransactionAllowed);
        }
    }
}
