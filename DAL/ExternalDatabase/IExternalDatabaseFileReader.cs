using System.Data;

namespace DAL.ExternalDatabase
{
    public interface IExternalDatabaseFileReader
    {
        DataSet GetDataSet(string path);
    }
}
