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
