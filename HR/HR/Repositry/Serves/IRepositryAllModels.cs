using Azure;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.JsonPatch;
<<<<<<< HEAD
using Microsoft.AspNetCore.JsonPatch.Converters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using JsonPatchDocument = Microsoft.AspNetCore.JsonPatch.JsonPatchDocument;
namespace HR.Repositry.Serves
{
        
    public interface IRepositryAllModels<T,V> : IRepositryUpdate<T> where T:class
    {

        // All Models in T=Classes and V=ClassSummary
=======
namespace HR.Repositry.Serves
{
    public interface IRepositryAllModels<T,V>
    {
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        Task<List<V>> GetAll();

        Task<V> GetById(Guid id);

        T Add(T item);

<<<<<<< HEAD
        Task<T> Put(Guid id, T item);

        Task<T> Delete(Guid id);





        // Controller Employee : return List Salarys the One Employee
        Task<List<T>> GetAllEmplyeeAndSalarys();



        // Controller City : return List Employees in City
        Task<List<T>> GetEmployeesInCity();


=======
        Task<V> Patch(Guid id, T item);

        Task<T> Delete(Guid id);

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
    }
}
