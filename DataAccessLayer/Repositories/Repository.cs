using DataAccessLayer.AppDb;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class Repository<TEntity>(AppDBContext appDb) : IRepository<TEntity>
       where TEntity : BaseEntity
{
    public DbSet<TEntity> _dbSet = appDb.Set<TEntity>();
    public AppDBContext _dbContext = appDb;

    public async ValueTask<int> Add(TEntity entity)
    {
        await _dbSet.AddAsync(entity);

        return await _dbContext.SaveChangesAsync();
    }

    public int Delete(Guid id)
    {
        TEntity? entity = GetById(id);

        if (entity != null)
        {
            _dbSet.Remove(entity);

            return _dbContext.SaveChanges();
        }

        return 0;
    }

    public IQueryable<TEntity> GetAll() => _dbSet.AsNoTracking();

    public TEntity? GetById(Guid id)
       => _dbSet.FirstOrDefault(lam => lam.Id == id);

    public int Update(TEntity entity, Guid id)
    {
        TEntity? model = GetById(id);

        if (model != null)
        {
            _dbContext.Entry(model).CurrentValues.SetValues(entity);

            return _dbContext.SaveChanges();
        }

        return 0;
    }
}
