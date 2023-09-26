using Npgsql;

namespace Notification.WebApi.DataAccsess.Repositories;

public class BaseRepository
{
    protected readonly NpgsqlConnection _connection;
    public BaseRepository()
    {
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        this._connection = new NpgsqlConnection("Host=notification-do-user-14588306-0.b.db.ondigitalocean.com; Port=25060; Database=notification-db; User Id=doadmin; Password=AVNS_YCZKejGAmUThwb3LdI_;");
    }
}
