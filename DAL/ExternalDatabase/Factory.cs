namespace DAL.ExternalDatabase
{
    public class Factory : IFactory
    {
        public IExternalDatabaseFileReader GetDatabaseFileReader()
        {
            return new ExternalDatabaseFileReader();
        }
    }
}
