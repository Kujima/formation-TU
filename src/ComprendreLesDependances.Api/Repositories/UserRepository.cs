using Dapper;
using ComprendreLesDependances.Api.Data;
using ComprendreLesDependances.Api.Models;
using ComprendreLesDependances.Api.Options;

namespace ComprendreLesDependances.Api.Repositories;

public class UserRepository
{
    private readonly SqliteDbConnectionFactory _connectionFactory;

    public UserRepository()
    {
        _connectionFactory = new SqliteDbConnectionFactory();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        using var connection = await _connectionFactory.CreateDbConnectionAsync();
        return await connection.QueryAsync<User>("select * from Users");
    }
}
