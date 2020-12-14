using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class ExecResSubjectStatusPayment : ICommand
    {
        private readonly DataTable _table;

        public ExecResSubjectStatusPayment(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object statusPlacanja = row["StatusPlacanja"];
                object datumUnosa = row["DatumUnosa"];

                string commandText = string.Format("Insert into JudgmentExecResSubjectStatus (JudgmentExecResSubjectStatusID,Title,Code,DateCreated,Active) " +
                                                    "VALUES ({0},{1},{2},{3},{4})", idStatusPlacanja, statusPlacanja,, datumUnosa,);

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
