namespace daily_log_api.IServices
{
    public interface IDefaultService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity, int id);
        Task Delete(int id);

    }
}
