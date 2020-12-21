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
                TableCase.Scope.Factory.GetBudgetInstitutionUserFiller(_dataSet.Tables["BudzetskiKorisnik"]).Execute(transaction);
                TableCase.Scope.Factory.GetJudgementDelivery(_dataSet.Tables["DostavljenoOd"]).Execute(transaction);
                TableCase.Scope.Factory.GetExecutiveResultBudgetYearFiller(_dataSet.Tables["GodinaBudzeta"]).Execute(transaction);
                TableCase.Scope.Factory.GetPaymentMethod(_dataSet.Tables["NacinPlacanja"]).Execute(transaction);
                TableCase.Scope.Factory.GetTaxPayerFirmFiller(_dataSet.Tables["NazivOsobaFirma"], _dataSet.Tables["OsobaFirma"]).Execute(transaction);
                TableCase.Scope.Factory.GetResultRelationSublectLinkFromFiller(_dataSet.Tables["PredmetVezeOd"]).Execute(transaction);
                TableCase.Scope.Factory.GetJudgmentAndExecutiveResultFiller(_dataSet.Tables["PresudeIR"], _dataSet.Tables["PresudeIsplata"]).Execute(transaction);
                TableCase.Scope.Factory.GetExecutiveResultInstallmentAndPaymentFiller(_dataSet.Tables["PresudeIsplata"]).Execute(transaction);
                TableCase.Scope.Factory.GetMunicipalityFiller(_dataSet.Tables["Sjediste"]).Execute(transaction);
                TableCase.Scope.Factory.GetExecResSubjectStatusSubjectFiller(_dataSet.Tables["StatusPredmeta"]).Execute(transaction);
                TableCase.Scope.Factory.GetExecResSubjectStatusPaymentFiller(_dataSet.Tables["StatusPlacanja"]).Execute(transaction);
                TableCase.Scope.Factory.GetSubjectStatus(_dataSet.Tables["TipVezePredmeta"]).Execute(transaction);
                TableCase.Scope.Factory.GetBudgetInstitutionRespodentFiller(_dataSet.Tables["TuzenaStrana"]).Execute(transaction);
                TableCase.Scope.Factory.GetTaxPayerRespondentFiller(_dataSet.Tables["TuzenaStrana"]).Execute(transaction);
                TableCase.Scope.Factory.GetResultRelationSublectLinkFiller(_dataSet.Tables["VezePredmeta"]).Execute(transaction);
                TableCase.Scope.Factory.GetJudgmentAndExecutiveObligationTypeFiller(_dataSet.Tables["VrstaObaveze"]).Execute(transaction);
                TableCase.Scope.Factory.GetObligationTypeGRFiller(_dataSet.Tables["VrstaObavezeGR"]).Execute(transaction);
                TableCase.Scope.Factory.GetSubjectType(_dataSet.Tables["VrstaPredmeta"]).Execute(transaction);

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
