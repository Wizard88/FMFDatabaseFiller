using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.Refunds
{
    internal class TaxPayerRefundSide : ICommand
    {
        private readonly DataTable _table;

        public TaxPayerRefundSide(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idStranaZaPovrat = row["IdStranaZaPovrat"];
                object stranaZaPovrat = row["StranaZaPovrat"];
                object idSjediste = row["IdSjediste"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("TaxPayer.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Name", stranaZaPovrat);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@CreatedBy", 9);
                cmd.Parameters.AddWithValue("@TaxNumber", null);
                cmd.Parameters.AddWithValue("@Address", tempSjediste);
                cmd.Parameters.AddWithValue("@CantonID", null);
                cmd.Parameters.AddWithValue("@MunicipalityID", null);
                cmd.Parameters.AddWithValue("@JMBG_JIB", null);
                cmd.Parameters.AddWithValue("@CountryID", null);
                cmd.Parameters.AddWithValue("@Phone", null);
                cmd.Parameters.AddWithValue("@Fax", null);
                cmd.Parameters.AddWithValue("@Email", null);
                cmd.Parameters.AddWithValue("@TaxPayerTypeID", null);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
