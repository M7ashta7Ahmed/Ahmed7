using HR.Data;
using HR.Repositry;
using HR.Repositry.Serves;
using HR_Models.Models;
using HR_Models.Models.VM;
using Microsoft.EntityFrameworkCore;

namespace HR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();




            builder.Services.AddDbContext<HR_Context>(
                options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                }
                );

            builder.Services.AddScoped<IRepositryAllModels<City, CitySummary>, RepositryAllModels<City, CitySummary>>();
            builder.Services.AddScoped<IRepositryAllModels<Employee, EmployeeSummary>, RepositryAllModels<Employee, EmployeeSummary>>();
            builder.Services.AddScoped<IRepositryAllModels<UniverCity, UniverCitySummary>, RepositryAllModels<UniverCity, UniverCitySummary>>();
            builder.Services.AddScoped<IRepositryAllModels<Salary, SalarySummary>, RepositryAllModels<Salary, SalarySummary>>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());






            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
