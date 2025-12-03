using Library.Dal.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Library.Dal.ContextClasses;
using Library.Entities.Models;
using System.Linq.Expressions;

namespace Library.Dal.Repositories.EfConcretes
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly MyContext _context;
        protected readonly DbSet<T> _dbSet;

        protected BaseRepository(MyContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T oldEntity, T newEntity)
        {
            _dbSet.Entry(oldEntity).CurrentValues.SetValues(newEntity);
            await SaveChangesAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            return _dbSet.Where(exp);
        }
    }
}
