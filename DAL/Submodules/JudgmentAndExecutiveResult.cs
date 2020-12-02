using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Submodules
{
    internal class JudgmentAndExecutiveResult : ICommand
    {
        private readonly DataSet _dataSet;
        private readonly bool _isTransactionAllowed;

        public JudgmentAndExecutiveResult(DataSet dataSet, bool isTransactionAllowed)
        {
            _dataSet = dataSet;
            _isTransactionAllowed = isTransactionAllowed;
        }

        public void Execute()
        {
            SqlTransaction transaction = null;

            try
            {
                transaction = SQLSingleton.Instance.SqlConnection.BeginTransaction("Load SubModule 'Izvrsna resenja'");

                TableCase.Scope.Factory.GetBankFiller(_dataSet.Tables["Banka"]).Execute(transaction);
                TableCase.Scope.Factory.GetExecutiveResultBudgetInstitutionFiller(_dataSet.Tables["BudzetskiKorisnik"]).Execute(transaction);
                TableCase.Scope.Factory.GetJudgementDelivery(_dataSet.Tables["DostavljenoOd"]).Execute(transaction);
                TableCase.Scope.Factory.GetExecutiveResultBudgetYearFiller(_dataSet.Tables["GodinaBudzeta"]).Execute(transaction);
                TableCase.Scope.Factory.GetPaymentMethod(_dataSet.Tables["NacinPlacanja"]).Execute(transaction);


                TableCase.Scope.Factory.GetJudgmentAndExecutiveResultTaxPayerFiller(_dataSet.Tables["NazivOsobaFirma"], _dataSet.Tables["OsobaFirma"]).Execute(transaction);
                TableCase.Scope.Factory.GetJudgmentAndExecutiveResultRelationFiller(_dataSet.Tables["PredmetVezeOd"]).Execute(transaction);

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
