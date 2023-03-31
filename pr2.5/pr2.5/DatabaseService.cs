
using Npgsql;

namespace pr2._5
{
    public class DatabaseService
    {
        private static NpgsqlConnection? _connection;

        private static string GetConnectionString()
        {
            return @"Host=10.30.0.137;Port=5432;Database=gr612_ryatse;Username=gr612_ryatse;Password=********";
        }

        public static NpgsqlConnection GetSqlConnection()
        {
            if (_connection is null)
            {
                _connection = new NpgsqlConnection(GetConnectionString());
                _connection.Open();
            }

            return _connection;
        }
    }
}