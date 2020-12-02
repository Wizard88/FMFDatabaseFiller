using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class TaxPayerRespondent : ICommand
    {
        private readonly DataTable _table;

        public TaxPayerRespondent(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idNazivPodnosilacZahtjeva = row["IdTuzeni"];
                object idSjediste = row["Tuzeni"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("TaxPayer.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Name",);
                cmd.Parameters.AddWithValue("@Description",);
                cmd.Parameters.AddWithValue("@CreatedBy",);
                cmd.Parameters.AddWithValue("@TaxNumber",);
                cmd.Parameters.AddWithValue("@Address",);
                cmd.Parameters.AddWithValue("@CantonID",);
                cmd.Parameters.AddWithValue("@MunicipalityID",);
                cmd.Parameters.AddWithValue("@JMBG_JIB",);
                cmd.Parameters.AddWithValue("@CountryID",);
                cmd.Parameters.AddWithValue("@Phone",);
                cmd.Parameters.AddWithValue("@Fax",);
                cmd.Parameters.AddWithValue("@Email",);
                cmd.Parameters.AddWithValue("@TaxPayerTypeID",);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
