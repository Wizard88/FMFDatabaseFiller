using System.Data;
using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal class CurrencyType : ICommand
    {
        private readonly DataTable _table;

        public CurrencyType(DataTable table)
        {
            _table = table;
        }

        public void Execute()
        {
            foreach (DataRow row in _table.Rows)
            {
                object vrstaValute = row["VrstaValute"];
                object datumUnosa = row["DatumUnosa"];

                SqlCommand cmd = new SqlCommand("CurrencyTypeInsert", SQLSingleton.Instance.SqlConnection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Title", vrstaValute);
                //cmd.Parameters.AddWithValue("@Description", );
                //cmd.Parameters.AddWithValue("@zOrder", );
                cmd.Parameters.AddWithValue("@CreateDate", datumUnosa);
                //cmd.Parameters.AddWithValue("@UserID", );
                //cmd.Parameters.AddWithValue("@Active", );
                //cmd.Parameters.AddWithValue("@Code", );
                //cmd.Parameters.AddWithValue("@LocalCurrency", );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
