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

                cmd.Parameters.AddWithValue("@Name", kontrolniOrgan);
                cmd.Parameters.AddWithValue("@Remark", null);
                cmd.Parameters.AddWithValue("@ContactPerson", null);
                cmd.Parameters.AddWithValue("@ContactPhone", null);
                cmd.Parameters.AddWithValue("@UserID", 9);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@Code", idKontrolniOrgan);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
