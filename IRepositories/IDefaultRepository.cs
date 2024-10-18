namespace daily_log_api.IRepositories
{
    public interface IDefaultRepository<T> where T : class
    {

        public Task<IEnumerable<T>> GetAll();

        public Task<T> GetById(int id);

        public Task Create(T entity);

        public Task Update(T entity, int id); 
        
        public Task Delete(int id);


    }
}
