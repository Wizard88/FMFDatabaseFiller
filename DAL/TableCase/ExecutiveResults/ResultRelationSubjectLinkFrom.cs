using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class ResultRelationSubjectLinkFrom : ICommand
    {
        private readonly DataTable _table;

        public ResultRelationSubjectLinkFrom(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idPredmetVezeOd = row["IdPredmetVezeOd"];
                object predmetVezeOd = row["PredmetVezeOd"];

                SqlCommand cmd = new SqlCommand("JudgmentAndExecutiveResultRelationSave", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResult1ID",);
                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResult2ID",);
                cmd.Parameters.AddWithValue("@UserID",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
