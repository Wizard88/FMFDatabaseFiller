using System.Data;

namespace DAL.Submodules
{
    public interface IFactory
    {
        ICommand GetDecisionsOfTheConstitutionalCourt(DataSet dataSet);
    }
}
