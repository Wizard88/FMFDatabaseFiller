using System.Data;

namespace DAL.TableCase
{
    internal class JudgmentAndExecutiveResult : ICommand
    {
        private readonly DataTable _table;

        public JudgmentAndExecutiveResult(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object brojPresudeIR = row["BrojPresudeIR"];
                object datumPresudeIR = row["DatumPresudeIR"];
                object brojProtokola = row["BrojProtokola"];
                object datumProtokola = row["DatumProtokola"];
                object datumPrijemaURad = row["DatumPrijemaURad"];
                object idStatusPredmeta = row["IdStatusPredmeta"];
                object idVrstaPredmeta = row["IdVrstaPredmeta"];
                object nazivPredmeta = row["NazivPredmeta"];
                object idDostavljenoOd = row["IdDostavljenoOd"];
                object brojDostavljenoOd = row["BrojDostavljenoOd"];
                object datumDostavljenoOd = row["DatumDostavljenoOd"];
                object brojPresudeOdIR = row["BrojPresudeOdIR"];
                object datumPresudeOdIR = row["DatumPresudeOdIR"];
                object idBanka = row["IdBanka"];
                object brojDokFMFPravob = row["BrojDokFMFPravob"];
                object datumFMFPravobran = row["DatumFMFPravobran"];
                object brojPravobran = row["BrojPravobran"];
                object datumPravobran = row["DatumPravobran"];
                object idTipRjesenjaPravobran = row["IdTipRjesenjaPravobran"];
                object rješenjePravobran = row["RješenjePravobran"];
                object idPresigniranoKome = row["IdPresigniranoKome"];
                object presigniranoKada = row["PresigniranoKada"];
                object presigniranoRazlog = row["PresigniranoRazlog"];
                object idRazlogPresigniranja = row["IdRazlogPresigniranja"];
                object kontrola1 = row["Kontrola1"];
                object napomena = row["Napomena"];
                object datumUnosa = row["DatumUnosa"];

            }
        }
    }
}
