using HR.Data;
using HR.Repositry;
using HR.Repositry.Serves;
using HR_Models.Models;
using HR_Models.Models.VM;
<<<<<<< HEAD
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Serilog;
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

namespace HR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("loggers/logger.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();


            // Add services to the container.


                builder.Services.AddControllers()
                  .AddNewtonsoftJson(options =>
                  {
                      options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                  });

=======
            // Add services to the container.

            builder.Services.AddControllers();
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

<<<<<<< HEAD
              
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3



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
<<<<<<< HEAD
            builder.Services.AddScoped<IRepositryAllModels<EmployeeDepartment, EmployeeDepartmentSummary >, RepositryAllModels<EmployeeDepartment, EmployeeDepartmentSummary>>();
            builder.Services.AddScoped<IRepositryAllModels<Department, DepartmentSummary>, RepositryAllModels<Department, DepartmentSummary>>();
            builder.Services.AddScoped<IRepositryAllModels<Leave_Balances, Leave_BalancesSummary>, RepositryAllModels<Leave_Balances, Leave_BalancesSummary>>();
            builder.Services.AddScoped<IRepositryAllModels<Penalties, PenaltiesSummary>, RepositryAllModels<Penalties, PenaltiesSummary>>();
            builder.Services.AddScoped<IRepositryAllModels<Vacation, VacationSummary>, RepositryAllModels<Vacation, VacationSummary>>();
            builder.Services.AddScoped<IRepositryAllModels<Rewards, RewardsSummary>, RepositryAllModels<Rewards, RewardsSummary>>();



            builder.Services.AddScoped<HR.Repositry.RepoEmployee>();





            builder.Services.AddScoped<IRepositryUpdate<Employee>, RepositryUpdate<Employee>>();


=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


<<<<<<< HEAD
            builder.Services.AddControllers()
                   .AddNewtonsoftJson(options =>
                   {
                       options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                   });

            builder.Host.UseSerilog();
=======



>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

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
