using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Submodules
{
    internal class DecisionsOfConstitutionalCourt : ICommand
    {
        private readonly DataSet _dataSet;
        private readonly bool _isTransactionAllowed;

        public DecisionsOfConstitutionalCourt(DataSet dataSet, bool isTransactionAllowed)
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

                TableCase.Scope.Factory.GetDecisionFiller(_dataSet.Tables["APCH_odluke"], _dataSet.Tables["odluke_CH"]).Execute(transaction);
                TableCase.Scope.Factory.GetDecisionPaymentAndInstallmentFiller(_dataSet.Tables["APCH_odlukeIsplata"]).Execute(transaction);
                TableCase.Scope.Factory.GetPaymentStatusFiller(_dataSet.Tables["StatusPlacanja"]).Execute(transaction);
                //TableCase.Scope.Factory.GetBudgetYearFiller(_dataSet.Tables["BudzetskaGodina"]).Execute(transaction);
                TableCase.Scope.Factory.GetCurrencyTypeFiller(_dataSet.Tables["VrstaValute"]).Execute(transaction);
                //TableCase.Scope.Factory.GetPersonTypeFiller(_dataSet.Tables["TipOsobe"]).Execute(transaction);      
                TableCase.Scope.Factory.GetObligationTypeFiller(_dataSet.Tables["VrstaObaveze"]).Execute(transaction);

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
