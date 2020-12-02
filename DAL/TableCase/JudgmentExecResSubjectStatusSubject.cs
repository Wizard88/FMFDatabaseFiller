using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class JudgmentExecResSubjectStatusSubject : ICommand
    {
        private readonly DataTable _table;

        public JudgmentExecResSubjectStatusSubject(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idStatusPredmeta = row["IdStatusPredmeta"];
                object statusPredmeta = row["StatusPredmeta"];
                object datumUnosa = row["DatumUnosa"];

                string commandText = string.Format("Insert into JudgmentExecResSubjectStatus (JudgmentExecResSubjectStatusID,Title,Code,DateCreated,Active) VALUES ({0},{1},{2},{3},{4})",);

                SqlCommand cmd = new SqlCommand()
                {
                    Connection = SQLSingleton.Instance.SqlConnection,
                    CommandType = System.Data.CommandType.TableDirect,
                    CommandText = commandText,
                    Transaction = transaction
                };

                cmd.ExecuteNonQuery();
            }
        }
    }
}
