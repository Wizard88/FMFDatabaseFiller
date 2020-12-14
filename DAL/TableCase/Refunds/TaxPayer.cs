using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.TableCase.Refunds
{
    internal class TaxPayer : ICommand
    {
        private readonly DataTable _tableApplicant;
        private readonly DataTable _tableNameOfApplicant;

        public TaxPayer(DataTable tableApplicant, DataTable tableNameOfApplicant)
        {
            _tableApplicant = tableApplicant;
            _tableNameOfApplicant = tableNameOfApplicant;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _tableApplicant.Rows)
            {
                object idPodnosilacZahtjeva = row["IdPodnosilacZahtjeva"];
                object idNazivPodnosilacZahtjeva = row["IdNazivPodnosilacZahtjeva"];
                object idSjediste = row["IdSjediste"];
                object datumUnosa = row["DatumUnosa"];

                EnumerableRowCollection<DataRow> results = from myRow in _tableNameOfApplicant.AsEnumerable()
                                                           where myRow.Field<int>("IdNazivPodnosilacZahtjeva") == (int)idNazivPodnosilacZahtjeva
                                                           select myRow;

                DataRow relatedRow = results.FirstOrDefault();

                object relatedNazivPodnosilacZahtjeva = relatedRow["NazivPodnosilacZahtjeva"];
                object relatedDatumUnosa = relatedRow["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("TaxPayer.Save", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Name", relatedNazivPodnosilacZahtjeva);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@CreatedBy", 9);
                cmd.Parameters.AddWithValue("@TaxNumber", null);
                cmd.Parameters.AddWithValue("@Address", );
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
