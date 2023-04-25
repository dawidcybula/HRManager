namespace HRManagerWeb.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);



        
    
    }
}
