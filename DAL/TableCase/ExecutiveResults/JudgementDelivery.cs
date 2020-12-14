using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class JudgementDelivery : ICommand
    {
        private readonly DataTable _table;

        public JudgementDelivery(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idDostavljenoOd = row["IdDostavljenoOd"];
                object dostavljenoOd = row["DostavljenoOd"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("JudgementDelivery.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Title", dostavljenoOd);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@CreateByUser", 9);
                cmd.Parameters.AddWithValue("@Code", idDostavljenoOd);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
