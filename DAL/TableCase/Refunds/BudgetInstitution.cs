using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class BudgetInstitution : ICommand
    {
        private readonly DataTable _table;

        public BudgetInstitution(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idKontrolniOrgan = row["IdKontrolniOrgan"];
                object kontrolniOrgan = row["KontrolniOrgan"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("BudgetInstitutionInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Name",);
                cmd.Parameters.AddWithValue("@Remark",);
                cmd.Parameters.AddWithValue("@ContactPerson",);
                cmd.Parameters.AddWithValue("@ContactPhone",);
                cmd.Parameters.AddWithValue("@UserID",);
                cmd.Parameters.AddWithValue("@Description",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
