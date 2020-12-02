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

                TableCase.Scope.Factory.GetJudgmentAndExecutiveResultTaxPayer(_dataSet.Tables["NazivOsobaFirma"], _dataSet.Tables["OsobaFirma"]).Execute(transaction);

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
