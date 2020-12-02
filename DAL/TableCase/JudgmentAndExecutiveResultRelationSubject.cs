using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class JudgmentAndExecutiveResultRelationSubject : ICommand
    {
        private readonly DataTable _table;

        public JudgmentAndExecutiveResultRelationSubject(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object IdVezePredmeta = row["IdVezePredmeta"];
                object IdPresudeIsplata = row["IdPresudeIsplata"];
                object IdPresudeIR = row["IdPresudeIR"];
                object BrojPredmetaVeze = row["BrojPredmetaVeze"];
                object DatumPredmetaVeze = row["DatumPredmetaVeze"];
                object IdTipVezePredmeta = row["IdTipVezePredmeta"];
                object IdPredmetVezeOd = row["IdPredmetVezeOd"];
                object DatumUnosa = row["DatumUnosa"];

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
