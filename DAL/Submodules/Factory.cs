using System.Data;

namespace DAL.Submodules
{
    public class Factory : IFactory
    {
        public ICommand GetDecisionsOfTheConstitutionalCourt(DataSet dataSet)
        {
            return new OdlukeUstavnogSuda(dataSet);
        }
    }
}
