using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DAL.ExternalDatabase
{
    internal class ExternalDatabaseFileReader : IExternalDatabaseFileReader
    {
        public ExternalDatabaseFileReader()
        {
        }

        public DataSet GetDataSet(string path)
        {
            DataSet dataSet = new DataSet();

            string connestionString = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}", path);
            OleDbConnection connection = new OleDbConnection(connestionString);
            connection.Open();

            string[] restrictions = new string[4];
            restrictions[3] = "Table";

            DataTable userTables = connection.GetSchema("Tables", restrictions);
            List<string> listOfTableNames = userTables.AsEnumerable().Select(r => r.Field<string>("TABLE_NAME")).ToList();
            SubModule subModule = GetDataSetName(listOfTableNames);

            foreach (string item in listOfTableNames)
            {
                string strSQL = string.Format("SELECT * FROM {0}", item);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, connection);

                dataAdapter.Fill(dataSet, item);
            }

            connection.Close();
            dataSet.DataSetName = subModule.ToString();

            return dataSet;
        }

        private SubModule GetDataSetName(List<string> listOfTableNames)
        {
            if (listOfTableNames.Contains("APCH_odlukeIsplata")) return SubModule.OdlukeUstavnogSuda;
            else if (listOfTableNames.Contains("PovratiPlacanje")) return SubModule.Povrati;
            else
                return SubModule.OdlukeUstavnogSuda;
        }
    }
}