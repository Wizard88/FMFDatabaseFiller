using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Submodules
{
    internal class OdlukeUstavnogSuda : ICommand
    {
        private readonly DataSet _dataSet;
        private readonly bool _isTransactionAllowed;

        public OdlukeUstavnogSuda(DataSet dataSet, bool isTransactionAllowed)
        {
            _dataSet = dataSet;
            _isTransactionAllowed = isTransactionAllowed;
        }

        public void Execute()
        {
            SqlTransaction transaction = null;
            try
            {
                transaction = SQLSingleton.Instance.SqlConnection.BeginTransaction("Load Submodule 'OdlukeUstavnogSuda'");

                TableCase.Scope.Factory.GetObligationTypeFiller(_dataSet.Tables["VrstaObaveze"]).Execute();
                TableCase.Scope.Factory.GetBudgetYearFiller(_dataSet.Tables["BudzetskaGodina"]).Execute();
                TableCase.Scope.Factory.GetPaymentStatusFiller(_dataSet.Tables["StatusPlacanja"]).Execute();
                TableCase.Scope.Factory.GetPersonTypeFiller(_dataSet.Tables["TipOsobe"]).Execute();
                TableCase.Scope.Factory.GetCurrencyTypeFiller(_dataSet.Tables["VrstaValute"]).Execute();
                TableCase.Scope.Factory.GetDecisionFiller(_dataSet.Tables["APCH_odluke"], _dataSet.Tables["odluke_CH"]).Execute();
                TableCase.Scope.Factory.GetDecisionPaymentFiller(_dataSet.Tables["APCH_odlukeIsplata"]).Execute();

                if (_isTransactionAllowed)
                    transaction.Commit();
                else
                    transaction.Rollback();
            }
            catch (Exception exc)
            {
                transaction.Rollback();
                throw exc;
            }
        }
    }
}
