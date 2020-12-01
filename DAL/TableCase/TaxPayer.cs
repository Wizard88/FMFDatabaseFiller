using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.TableCase
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
                object idNazivPodnosilacZahtjeva = row["IdNazivPodnosilacZahtjeva"];
                object idSjediste = row["IdSjediste"];
                object datumUnosa = row["DatumUnosa"];

                EnumerableRowCollection<DataRow> results = from myRow in _tableNameOfApplicant.AsEnumerable()
                                                           where myRow.Field<int>("IdNazivPodnosilacZahtjeva") == (int)idNazivPodnosilacZahtjeva
                                                           select myRow;

                DataRow relatedRow = results.FirstOrDefault();

                object rNazivPodnosilacZahtjeva = relatedRow["NazivPodnosilacZahtjeva"];
                object rDatumUnosa = relatedRow["DatumUnosa"];


            }
        }
    }
}
