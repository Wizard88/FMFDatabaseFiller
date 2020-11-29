using System.Data.SqlClient;

namespace DAL
{
    internal class SQLSingleton
    {
        private static SQLSingleton _instance = null;
        private SqlConnection _sqlConnection;

        public static SQLSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SQLSingleton();

                return _instance;
            }
        }

        private SQLSingleton()
        {

        }

        public SqlConnection SqlConnection => _sqlConnection;

        public bool OpenConnection()
        {
            string connetionString = "Data Source=192.168.1.66,1433;Initial Catalog=FMF;User ID=fmfUser;Password=Pa$$w0rd";

            try
            {
                _sqlConnection = new SqlConnection(connetionString);
                _sqlConnection.Open();

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public void CloseConnection()
        {
            _sqlConnection.Close();
        }
    }
}

