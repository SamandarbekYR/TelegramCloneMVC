namespace TelegramCloneMVC.Data.Interfaces
{
    public interface IRepository<TEntity>
    {
        ValueTask<int> Add(TEntity entity);
        int Update(TEntity entity, Guid id);
        int Delete(Guid id);
        IQueryable<TEntity> GetAll();
        TEntity? GetById (Guid id);
    }
}
