using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.TableCase.ExecutiveResults
{
    internal class TaxPayerFirm : ICommand
    {
        private readonly DataTable _tableNamePersonFirm;
        private readonly DataTable _tablePersonFirm;

        public TaxPayerFirm(DataTable tableNamePersonFirm, DataTable tablePersonFirm)
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

                string tempAdresa = string.Format("{0},{1}", adresa, sjediste);

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

                cmd.Parameters.AddWithValue("@Name", nazivOsobaFirma);
                cmd.Parameters.AddWithValue("@Description", null);
                cmd.Parameters.AddWithValue("@CreatedBy", datumUnosa);
                cmd.Parameters.AddWithValue("@TaxNumber", null);
                cmd.Parameters.AddWithValue("@Address", tempAdresa);
                cmd.Parameters.AddWithValue("@CantonID", null);
                cmd.Parameters.AddWithValue("@MunicipalityID", null);
                cmd.Parameters.AddWithValue("@JMBG_JIB", jmbgJib);
                cmd.Parameters.AddWithValue("@CountryID", null);
                cmd.Parameters.AddWithValue("@Phone", null);
                cmd.Parameters.AddWithValue("@Fax", null);
                cmd.Parameters.AddWithValue("@Email", null);
                cmd.Parameters.AddWithValue("@TaxPayerTypeID", 2);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
