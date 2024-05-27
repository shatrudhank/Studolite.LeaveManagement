namespace Studolite.LeaveManagement.Application.Contract.Persistence
{
    public interface IGenericRespository<T> where T : class
    {
        Task<T> GetAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);

    }

}
