using System;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    public static class Utility
    {
        public static int GetTaxPayerID(string firstName, string lastName)
        {
            string name = string.Format("{0} {1}", firstName, lastName);
            string query = string.Format("Select TaxPayerID From[GlobalCode].TaxPayer where Name = '{0}'", name);

            SqlCommand cmd = new SqlCommand()
            {
                Connection = SQLSingleton.Instance.SqlConnection,
                CommandType = System.Data.CommandType.TableDirect,
                CommandText = query
            };

            SqlDataReader dataReader = cmd.ExecuteReader();

            int id = 0;
            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader["TaxPayerID"]);
                break;
            }

            return id;
        }

        internal static int GetBudgetYear(int idBudzetskaGodina)
        {
            string query = string.Format("Select BudgetYear From [GlobalCode].BudgetYear where BudgetYearID={0}", idBudzetskaGodina);

            SqlCommand cmd = new SqlCommand()
            {
                Connection = SQLSingleton.Instance.SqlConnection,
                CommandType = System.Data.CommandType.TableDirect,
                CommandText = query
            };

            SqlDataReader dataReader = cmd.ExecuteReader();

            int budgetYear = 0;
            while (dataReader.Read())
            {
                budgetYear = Convert.ToInt32(dataReader["BudgetYear"]);
                break;
            }

            return budgetYear;
        }
    }
}
