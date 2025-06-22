using Microsoft.Data.SqlClient;
using Dapper;

namespace DapperConsole.Non_Query_Operations_Examples;

public class DataUpdateManager
{
    public void SoftDeleteProduct(int productId)
    {
        using var connection = new SqlConnection(Config.ConnectionString);
        var sql = "UPDATE SalesLT.Products SET IsDeleted = 1 WHERE ProductId = @ProductId";
        connection.Execute(sql, new { ProductId = productId });
    }
}