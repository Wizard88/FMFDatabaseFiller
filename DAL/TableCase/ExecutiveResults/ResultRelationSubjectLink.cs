using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class ResultRelationSubjectLink : ICommand
    {
        private readonly DataTable _table;

        public ResultRelationSubjectLink(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idVezePredmeta = row["IdVezePredmeta"];
                object idPresudeIsplata = row["IdPresudeIsplata"];
                object idPresudeIR = row["IdPresudeIR"];
                object brojPredmetaVeze = row["BrojPredmetaVeze"];
                object datumPredmetaVeze = row["DatumPredmetaVeze"];
                object idTipVezePredmeta = row["IdTipVezePredmeta"];
                object idPredmetVezeOd = row["IdPredmetVezeOd"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("JudgmentAndExecutiveResultRelationSave", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResult1ID", idPresudeIR);
                cmd.Parameters.AddWithValue("@JudgmentAndExecutiveResult2ID", idPredmetVezeOd);
                cmd.Parameters.AddWithValue("@UserID", 9);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
