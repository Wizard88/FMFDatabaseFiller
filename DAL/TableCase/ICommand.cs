using System.Data.SqlClient;

namespace DAL.TableCase
{
    public interface ICommand
    {
        void Execute(SqlTransaction transaction);
    }
}
