using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class BudgetInstitutionRespodent : ICommand
    {
        private readonly DataTable _table;

        public BudgetInstitutionRespodent(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idTuzeni = row["IdTuzeni"];
                object tuzeni = row["Tuzeni"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("BudgetInstitutionInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Name", tuzeni);
                cmd.Parameters.AddWithValue("@Remark", null);
                cmd.Parameters.AddWithValue("@ContactPerson", null);
                cmd.Parameters.AddWithValue("@ContactPhone", null);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@zOrder", null);
                cmd.Parameters.AddWithValue("@Description", null);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
