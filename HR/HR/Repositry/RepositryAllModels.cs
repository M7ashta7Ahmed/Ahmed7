using AutoMapper;
using HR.Data;
using HR.Repositry.Serves;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace HR.Repositry
{
    public class RepositryAllModels<T,V> : 
        IRepositryAllModels<T,V>

        where T : Entity
        where V:class
   
    {
        private readonly HR_Context context;
        private readonly IMapper mapper;

        public RepositryAllModels(HR_Context context)
        {
            this.context = context;
        }

        public RepositryAllModels(HR_Context context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public T Add(T item)
        {
            var entity = context.Set<T>().Add(item).Entity;
            context.SaveChanges();
            return entity;
        }




        public async Task<T> Delete(Guid id)
        {
        var get=await getPrivate(id);
            if (get == null)
            {
                return null;
            }
            context.Set<T>().Remove(get);
            context.SaveChanges();
            return get;
        }


        public async Task<List<V>> GetAll()
        {
            var getAll =context.Set<T>().ToList();
            var maps = mapper.Map<List<V>>(getAll).ToList();
            return maps;
        }


        public async Task<V?> GetById(Guid id)
        {
            var get = context.Set<T>()
                .AsNoTracking()
                .FirstOrDefault(x => x.id == id);

            if (get == null)
            {
                return null;
            }

            var map=mapper.Map<V>(get);

            return map;
        }


        public async Task<V> Patch(Guid id, T item)
        {
            var get =await GetById(id);

            if (get == null)
            {
                return null;
            }
            var map=mapper.Map(item, get);
            try
            {
                context.Set<T>().Update(item);
            }
            catch (Exception exp)
            {
                throw new Exception();
            }

            context.SaveChanges();
            return get;
        }






        //هذه الدوال خاصة بهذا الكلاس

        private async Task<T?> getPrivate(Guid id)
        {
            var get = context.Set<T>()
                .AsNoTracking()
                .FirstOrDefault(x => x.id == id);

            if (get == null)
            {
                return null;
            }
            return get;
        }

    }
    
}
