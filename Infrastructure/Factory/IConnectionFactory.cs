using System.Data;

namespace Infrastructure.Factory
{
    /// <summary>
    /// Simulate a connection to a real Database
    /// </summary>
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}