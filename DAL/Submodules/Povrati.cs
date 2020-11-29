using System;
using System.Data;

namespace DAL.Submodules
{
    internal class Povrati : ICommand
    {
        private readonly DataSet _dataSet;

        public Povrati(DataSet dataSet)
        {
            _dataSet = dataSet;
        }

        public void Execute()
        {
            try
            {
                TableCase.Scope.Factory.GetControlAuthorityFiller(_dataSet.Tables["KontrolniOrgan"]).Execute();
                TableCase.Scope.Factory.GetTaxPayerFiller(_dataSet.Tables["PodnosilacZahtjeva"], _dataSet.Tables["NazivPodnosilacZahtjeva"]).Execute();
                TableCase.Scope.Factory.GetRefundFiller(_dataSet.Tables["Povrati"]).Execute();
                TableCase.Scope.Factory.GetRefundPaymentFiller(_dataSet.Tables["PovratiPlacanje"]).Execute();
                TableCase.Scope.Factory.GetBankAccountFiller(_dataSet.Tables["RacunPlacanja"]).Execute();
                TableCase.Scope.Factory.GetOrdinalNumberFiller(_dataSet.Tables["Rata"]).Execute();
                TableCase.Scope.Factory.GetMunicipalityFiller(_dataSet.Tables["Sjediste"]).Execute();
                TableCase.Scope.Factory.GetRefundSubjectStatusFiller(_dataSet.Tables["StatusPredmeta"]).Execute();
                TableCase.Scope.Factory.GetRefundRelationFiller(_dataSet.Tables["VezePredmeta"]).Execute();
                TableCase.Scope.Factory.GetReturnTypeFiller(_dataSet.Tables["VrstaPovrata"]).Execute();
                TableCase.Scope.Factory.GetIncomeTypeFiller(_dataSet.Tables["VrstaPrihoda"]).Execute();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
