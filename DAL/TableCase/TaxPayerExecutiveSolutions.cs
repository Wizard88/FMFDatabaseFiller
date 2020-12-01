using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.TableCase
{
    internal class TaxPayerExecutiveSolutions : ICommand
    {
        private readonly DataTable _tableNamePersonFirm;
        private readonly DataTable _tablePersonFirm;

        public TaxPayerExecutiveSolutions(DataTable tableNamePersonFirm, DataTable tablePersonFirm)
        {
            _tableNamePersonFirm = tableNamePersonFirm;
            _tablePersonFirm = tablePersonFirm;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _tablePersonFirm.Rows)
            {
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
            }
        }
    }
}
