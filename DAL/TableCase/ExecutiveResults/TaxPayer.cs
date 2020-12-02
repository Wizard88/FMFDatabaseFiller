using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.TableCase.ExecutiveResults
{
    internal class TaxPayer : ICommand
    {
        private readonly DataTable _tableNamePersonFirm;
        private readonly DataTable _tablePersonFirm;

        public TaxPayer(DataTable tableNamePersonFirm, DataTable tablePersonFirm)
        {
            _tableNamePersonFirm = tableNamePersonFirm;
            _tablePersonFirm = tablePersonFirm;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _tablePersonFirm.Rows)
            {
                object idOsobaFirma = row["IdOsobaFirma"];
                object idNazivOsobaFirma = row["IdNazivOsobaFirma"];
                object adresa = row["Adresa"];
                object idSjediste = row["IdSjediste"];
                object jmbgJib = row["JMBR/JIB"];
                object idTipOsobe = row["IdTipOsobe"];
                object datumUnosa = row["DatumUnosa"];

                EnumerableRowCollection<DataRow> results = from myRow in _tableNamePersonFirm.AsEnumerable()
                                                           where myRow.Field<int>("IdNazivOsobaFirma") == (int)idNazivOsobaFirma
                                                           select myRow;

                DataRow relatedRow = results.FirstOrDefault();

                object nazivOsobaFirma = relatedRow["NazivOsobaFirma"];
                object datumUnosaRelated = relatedRow["DatumUnosa"];

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
