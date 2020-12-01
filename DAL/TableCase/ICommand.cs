using System.Data.SqlClient;

namespace DAL.TableCase
{
    internal interface ICommand
    {
        void Execute(SqlTransaction transaction);
    }
}
