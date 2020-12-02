using System.Data;

namespace DAL.TableCase
{
    public class Factory : IFactory
    {
        //decisions
        public ICommand GetDecisionFiller(DataTable tableAPCH, DataTable tableCH)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.Decision(tableAPCH, tableCH);
        }

        public ICommand GetDecisionPaymentAndInstallmentFiller(DataTable table)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.DecisionPaymentAndInstallment(table);
        }

        public ICommand GetPaymentStatusFiller(DataTable table)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.PaymentStatus(table);
        }

        public ICommand GetBudgetYearFiller(DataTable table)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.BudgetYear(table);
        }

        public ICommand GetCurrencyTypeFiller(DataTable table)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.CurrencyType(table);
        }

        public ICommand GetPersonTypeFiller(DataTable table)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.PersonType(table);
        }

        //refunds
        public ICommand GetBudgetInstitutionFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.BudgetInstitution(table);
        }

        public ICommand GetTaxPayerFiller(DataTable tableApplicant, DataTable tableNameOfApplicant)
        {
            return new DAL.TableCase.Refunds.TaxPayer(tableApplicant, tableNameOfApplicant);
        }

        public ICommand GetRefundFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.Refund(table);
        }

        public ICommand GetRefundPaymentAndInstallmentFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.RefundPaymentAndInstallment(table);
        }

        public ICommand GetMinistryBankAccountFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.MinistryBankAccount(table);
        }

        public ICommand GetOrdinalNumberFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.OrdinalNumber(table);
        }

        public ICommand GetMunicipalityFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.Municipality(table);
        }

        public ICommand GetRefundPaymentStatusFiller(DataTable table)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.PaymentStatus(table);
        }

        public ICommand GetRefundSubjectStatusFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.RefundSubjectStatus(table);
        }

        public ICommand GetRefundSideTaxPayerFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.TaxPayerRefundSide(table);
        }

        public ICommand GetNameOfWhomTaxPayerFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.TaxPayerNameOfWhom(table);
        }

        public ICommand GetRefundRelationFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.RefundRelation(table);
        }

        public ICommand GetReturnTypeFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.ReturnType(table);
        }

        public ICommand GetIncomeTypeFiller(DataTable table)
        {
            return new DAL.TableCase.Refunds.IncomeType(table);
        }

        //ExecutiveResult
        public ICommand GetBankFiller(DataTable table)
        {
            return new DAL.TableCase.ExecutiveResults.Bank(table);
        }

        public ICommand GetExecutiveResultBudgetInstitutionFiller(DataTable table)
        {
            return new DAL.TableCase.ExecutiveResults.BudgetInstitution(table);
        }

        public ICommand GetJudgmentAndExecutiveResultTaxPayerFiller(DataTable tableNamePersonFirm, DataTable tablePersonFirm)
        {
            return new DAL.TableCase.ExecutiveResults.TaxPayer(tableNamePersonFirm, tablePersonFirm);
        }

        public ICommand GetJudgementDelivery(DataTable table)
        {
            return new DAL.TableCase.ExecutiveResults.JudgementDelivery(table);
        }

        public ICommand GetPaymentMethod(DataTable table)
        {
            return new DAL.TableCase.ExecutiveResults.PaymentMethod(table);
        }





        public ICommand GetJudgmentAndExecutiveResultRelationFiller(DataTable dataTable)
        {
            throw new System.NotImplementedException();
        }

        public ICommand GetObligationTypeFiller(DataTable table)
        {
            return new DAL.TableCase.DecisionsOConstitutionalCourt.ObligationType(table);
        }

        public ICommand GetExecutiveResultBudgetYearFiller(DataTable table)
        {
            return new DAL.TableCase.ExecutiveResults.BudgetYear(table);
        }
    }
}
