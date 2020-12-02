using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class BudgetYear : ICommand
    {
        private readonly DataTable _table;

        public BudgetYear(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idGodinaBudzeta = row["IdGodinaBudzeta"];
                object godinaBudzeta = row["GodinaBudzeta"];

                SqlCommand cmd = new SqlCommand("BudgetYearInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@BudgetYear", );
                cmd.Parameters.AddWithValue("@Description", );
                cmd.Parameters.AddWithValue("@zOrder", );
                cmd.Parameters.AddWithValue("@CreateDate", );
                cmd.Parameters.AddWithValue("@UserID", );
                cmd.Parameters.AddWithValue("@Active", );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
