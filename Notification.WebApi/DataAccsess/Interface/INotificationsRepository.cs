using Notification.WebApi.Domain.Entities;
using static Dapper.SqlMapper;

namespace Notification.WebApi.DataAccsess.Interface;

public interface INotificationsRepository<TEntity>
{
    public Task<long> CreateAsync(TEntity);
    public Task<Notifications> NotificationAsyn();
}
