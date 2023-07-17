using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;

namespace SqlInvokerLib
{
  public class DdlInvoker
  {

    public static void Invoke(string connectionString, string sql)
    {
     using var conn = new SqlConnection(connectionString);
     var serverConnection = new ServerConnection(conn);
     serverConnection.ExecuteNonQuery(sql);
    }

  }
}