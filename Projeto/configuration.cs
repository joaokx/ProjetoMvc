using Microsoft.EntityFrameworkCore.Infrastructure;

internal class configuration
{
    internal static Action<SqlServerDbContextOptionsBuilder>? GetConnectionString(string v)
    {
        throw new NotImplementedException();
    }
}