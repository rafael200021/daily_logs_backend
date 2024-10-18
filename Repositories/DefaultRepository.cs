using daily_log_api.Data;
using daily_log_api.IRepositories;
using daily_log_api.Models;
using Microsoft.EntityFrameworkCore;

namespace daily_log_api.Repositories
{
    public class DefaultRepository<T>:IDefaultRepository<T> where T : class
    {

        public readonly DbDailyLogContext _context;

        public readonly DbSet<T> _entity;


        public DefaultRepository(DbDailyLogContext context) {
        
            _context = context;

            _entity = context.Set<T>();

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entity.FindAsync(id);
        }

        public virtual async Task Create(T entity)
        {
            await _entity.AddAsync(entity);

            await _context.SaveChangesAsync();

        }

        public virtual async Task Update(T entity,int id)
        {

            var entityData = await _entity.FindAsync(id);

            if(entityData != null) {


                foreach (var property in typeof(T).GetProperties())
                {
                    var newValue = property.GetValue(entity);

                    if (newValue != null)
                    {
                        property.SetValue(entityData, newValue);
                    }
                }

                await _context.SaveChangesAsync();
           

            }


        }

        public async Task Delete(int id)
        {

            T entity = await _entity.FindAsync(id);

            if (entity != null)
            {
                _entity.Remove(entity);

                await _context.SaveChangesAsync();

            }

        }


    }
}
