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
                object idTuzenaStrana = row["IdTuzenaStrana"];
                object idPresudeIsplata = row["IdPresudeIsplata"];
                object idPresudeIR = row["IdPresudeIR"];
                object idTuzeni = row["IdTuzeni"];
                object idVrstaIsplate = row["IdVrstaIsplate"];
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
                cmd.Parameters.AddWithValue("@zOrder",);
                cmd.Parameters.AddWithValue("@Description",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
