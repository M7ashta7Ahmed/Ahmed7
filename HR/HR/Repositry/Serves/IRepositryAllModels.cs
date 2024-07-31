using Azure;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.JsonPatch;
namespace HR.Repositry.Serves
{
    public interface IRepositryAllModels<T,V>
    {
        Task<List<V>> GetAll();

        Task<V> GetById(Guid id);

        T Add(T item);

        Task<V> Patch(Guid id, T item);

        Task<T> Delete(Guid id);

    }
}
