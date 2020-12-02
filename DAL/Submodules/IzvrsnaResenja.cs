using System.Data;

namespace DAL.Submodules
{
    internal class IzvrsnaResenja : ICommand
    {
        private readonly DataSet _dataSet;

        public IzvrsnaResenja(DataSet dataSet)
        {
            _dataSet = dataSet;
        }

        public void Execute()
        {

        }
    }
}
