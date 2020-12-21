using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase.DecisionsOConstitutionalCourt
{
    internal class Relation : ICommand
    {
        private readonly DataTable _table;

        public Relation(DataTable table)
        {
            _table = table;
        }

        public void Execute(SqlTransaction transaction)
        {
            foreach (DataRow row in _table.Rows)
            {
                object idAPCHOdlukeIsplata = row["IdAPCH_odlukeIsplata"];
                object idAPCHOdluke = row["IdAPCH_odluke"];
                object brojProtokola = row["BrojProtokola"];
                object datumProtokola = row["DatumProtokola"];
                object brojRjesenjaIzvrsenja = row["BrojRjesenjaIzvrsenja"];
                object datumRjesenjaIzvrsenja = row["DatumRjesenjaIzvrsenja"];
                object datumPrijema = row["DatumPrijema"];
                object idVrstaObaveze = row["IdVrstaObaveze"];
                object idStatusPlacanja = row["IdStatusPlacanja"];
                object datumPlacanja = row["DatumPlacanja"];
                object idBudzetskaGodina = row["IdBudzetskaGodina"];
                object glavnica = row["Glavnica"];
                object sudskiTroskovi = row["SudskiTroskovi"];
                object kamata = row["Kamata"];
                object iznosValuta = row["IznosValuta"];
                object idVrstaValute = row["IdVrstaValute"];
                object idTipOsobe = row["IdTipOsobe"];
                object isplataNaIme = row["IsplataNaIme"];
                object brojDokumentaVeze = row["BrojDokumentaVeze"];
                object datumDokumentaVeze = row["DatumDokumentaVeze"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];

                //checking values
                idStatusPlacanja = (idStatusPlacanja == null) ? "Nepoznato" : idStatusPlacanja;
                double tempSudskiTroskovi = (sudskiTroskovi == null) ? 0 : Convert.ToDouble(sudskiTroskovi);
                double tempGlavnica = (glavnica == null) ? 0 : Convert.ToDouble(glavnica);
                double tempKamata = (kamata == null) ? 0 : Convert.ToDouble(kamata);

                double tempTotal = tempSudskiTroskovi + tempGlavnica + tempKamata;

                int tempBudzetskaGodinaID = Convert.ToInt32(idBudzetskaGodina);
                int tempBudzetskaGodina = Utility.GetBudgetYear(tempBudzetskaGodinaID);
                int taxPayerID = Utility.GetTaxPayerID(isplataNaIme.ToString());

                SqlCommand cmd = new SqlCommand("DecisionRelationSave", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Transaction = transaction
                };

                cmd.Parameters.AddWithValue("@Decision1ID",);//?
                cmd.Parameters.AddWithValue("@Decision2ID",);//?
                cmd.Parameters.AddWithValue("@UserID", 9);//?
            }
        }
    }
}