using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class BudgetYear : ICommand
    {
        private readonly DataTable _table;

        public BudgetYear(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object budzetskaGodina = row["BudzetskaGodina"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("BudgetYearInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@BudgetYear", budzetskaGodina);
                //cmd.Parameters.AddWithValue("@Description", budzetskaGodina);
                //cmd.Parameters.AddWithValue("@zOrder", budzetskaGodina);
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                //cmd.Parameters.AddWithValue("@UserID", datumUnosa);
                //cmd.Parameters.AddWithValue("@Active", datumUnosa);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
