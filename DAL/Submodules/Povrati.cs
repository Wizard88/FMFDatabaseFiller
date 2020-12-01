using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Submodules
{
    internal class Povrati : ICommand
    {
        private readonly DataSet _dataSet;
        private readonly bool _isTransactionAllowed;

        public Povrati(DataSet dataSet, bool isTransactionAllowed)
        {
            _dataSet = dataSet;
            _isTransactionAllowed = isTransactionAllowed;
        }

        public void Execute()
        {
            SqlTransaction transaction = null;

            try
            {
                transaction = SQLSingleton.Instance.SqlConnection.BeginTransaction("Load SubModule 'Povrati'");

                TableCase.Scope.Factory.GetBudgetYearFiller(_dataSet.Tables["BudzetskaGodina"]).Execute(transaction);
                TableCase.Scope.Factory.GetControlAuthorityFiller(_dataSet.Tables["KontrolniOrgan"]).Execute(transaction);
                TableCase.Scope.Factory.GetTaxPayerFiller(_dataSet.Tables["PodnosilacZahtjeva"], _dataSet.Tables["NazivPodnosilacZahtjeva"]).Execute(transaction);
                TableCase.Scope.Factory.GetRefundFiller(_dataSet.Tables["Povrati"]).Execute(transaction);
                TableCase.Scope.Factory.GetRefundPaymentFiller(_dataSet.Tables["PovratiPlacanje"]).Execute(transaction);
                TableCase.Scope.Factory.GetBankAccountFiller(_dataSet.Tables["RacunPlacanja"]).Execute(transaction);
                TableCase.Scope.Factory.GetOrdinalNumberFiller(_dataSet.Tables["Rata"]).Execute(transaction);
                TableCase.Scope.Factory.GetMunicipalityFiller(_dataSet.Tables["Sjediste"]).Execute(transaction);
                TableCase.Scope.Factory.GetRefundSubjectStatusFiller(_dataSet.Tables["StatusPredmeta"]).Execute(transaction);
                TableCase.Scope.Factory.GetRefundRelationFiller(_dataSet.Tables["VezePredmeta"]).Execute(transaction);
                TableCase.Scope.Factory.GetReturnTypeFiller(_dataSet.Tables["VrstaPovrata"]).Execute(transaction);
                TableCase.Scope.Factory.GetIncomeTypeFiller(_dataSet.Tables["VrstaPrihoda"]).Execute(transaction);

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
