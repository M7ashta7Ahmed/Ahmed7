using AutoMapper;
<<<<<<< HEAD
using Azure.Core.Serialization;
using HR.Data;
using HR.Repositry.Serves;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Converters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.XPath;

namespace HR.Repositry
{
    public class RepositryAllModels<T,V> :
        IRepositryAllModels<T,V>
=======
using HR.Data;
using HR.Repositry.Serves;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace HR.Repositry
{
    public class RepositryAllModels<T,V> : 
        IRepositryAllModels<T,V>

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        where T : Entity
        where V:class
   
    {
        private readonly HR_Context context;
        private readonly IMapper mapper;

<<<<<<< HEAD
     /* Constracor */   public RepositryAllModels(HR_Context context)
=======
        public RepositryAllModels(HR_Context context)
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        {
            this.context = context;
        }

<<<<<<< HEAD
     /* Constracor */      public RepositryAllModels(HR_Context context,IMapper mapper)
=======
        public RepositryAllModels(HR_Context context,IMapper mapper)
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        {
            this.context = context;
            this.mapper = mapper;
        }


<<<<<<< HEAD
        // All Models 
=======

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        public T Add(T item)
        {
            var entity = context.Set<T>().Add(item).Entity;
            context.SaveChanges();
            return entity;
        }

<<<<<<< HEAD
=======



>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
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

<<<<<<< HEAD
=======

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        public async Task<List<V>> GetAll()
        {
            var getAll =context.Set<T>().ToList();
            var maps = mapper.Map<List<V>>(getAll).ToList();
            return maps;
        }

<<<<<<< HEAD
=======

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        public async Task<V?> GetById(Guid id)
        {
            var get = context.Set<T>()
                .AsNoTracking()
                .FirstOrDefault(x => x.id == id);

            if (get == null)
            {
                return null;
            }

<<<<<<< HEAD
            var map=mapper.Map<V?>(get);
=======
            var map=mapper.Map<V>(get);
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

            return map;
        }

<<<<<<< HEAD
        public async Task<T> Put(Guid id, T item)
        {
            var get =await GetById(id)?? null;
            try
            {
                context.Set<T>().Update(item);

                 context.SaveChanges();
            }
            catch (Exception exp)
            {
                throw new Exception("An error occurred while updating the entity.", exp);
            }

            return item;
        }


        public async Task<T> UpdateAsync(Guid id, JsonPatchDocument<T> json)
        {
            var get = context.Set<T>().Find(id);
=======

        public async Task<V> Patch(Guid id, T item)
        {
            var get =await GetById(id);

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
            if (get == null)
            {
                return null;
            }
<<<<<<< HEAD

            var mapping = mapper.Map<T>(get);
            json.ApplyTo(mapping);

            var added = mapper.Map(mapping, get);

            context.SaveChanges();

            return added;
        }

















        public async Task<List<T>> GetAllEmplyeeAndSalarys()
        {
            var get = context.Set<T>()
                            .Include("salaries")
                            .ToList();
=======
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
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
            return get;
        }



<<<<<<< HEAD
        // Controller : City , return LIST Employees 
        public async Task<List<T>> GetEmployeesInCity()
        {

            var getlist = context.Set<T>().Include("employees").ToList();

            return getlist;

        }

















=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3



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

<<<<<<< HEAD
        
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
    }
    
}
