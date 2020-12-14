using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.ExecutiveResults
{
    internal class BudgetInstitutionUser : ICommand
    {
        private readonly DataTable _table;

        public BudgetInstitutionUser(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idBudzetskiKorisnik = row["IdBudzetskiKorisnik"];
                object budzetskiKorisnik = row["BudzetskiKorisnik"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("BudgetInstitutionInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Name", budzetskiKorisnik);
                cmd.Parameters.AddWithValue("@Remark", null);
                cmd.Parameters.AddWithValue("@ContactPerson", null);
                cmd.Parameters.AddWithValue("@ContactPhone", null);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Description", null);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
