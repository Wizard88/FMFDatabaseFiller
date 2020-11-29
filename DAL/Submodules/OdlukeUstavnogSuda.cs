using System;
using System.Data;

namespace DAL.Submodules
{
    internal class OdlukeUstavnogSuda : ICommand
    {
        private readonly DataSet _dataSet;

        public OdlukeUstavnogSuda(DataSet dataSet)
        {
            _dataSet = dataSet;
        }

        public void Execute()
        {
            try
            {
                TableCase.Scope.Factory.GetObligationTypeFiller(_dataSet.Tables["VrstaObaveze"]).Execute();
                TableCase.Scope.Factory.GetBudgetYearFiller(_dataSet.Tables["BudzetskaGodina"]).Execute();
                TableCase.Scope.Factory.GetPaymentStatusFiller(_dataSet.Tables["StatusPlacanja"]).Execute();
                TableCase.Scope.Factory.GetPersonTypeFiller(_dataSet.Tables["TipOsobe"]).Execute();
                TableCase.Scope.Factory.GetCurrencyTypeFiller(_dataSet.Tables["VrstaValute"]).Execute();
                TableCase.Scope.Factory.GetDecisionFiller(_dataSet.Tables["APCH_odluke"], _dataSet.Tables["odluke_CH"]).Execute();
                TableCase.Scope.Factory.GetDecisionPaymentFiller(_dataSet.Tables["APCH_odlukeIsplata"]).Execute();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
