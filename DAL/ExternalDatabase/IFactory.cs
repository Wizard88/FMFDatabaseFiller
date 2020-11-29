namespace DAL.ExternalDatabase
{
    public interface IFactory
    {
        IExternalDatabaseFileReader GetDatabaseFileReader();
    }
}
