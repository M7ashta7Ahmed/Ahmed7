using AutoMapper;
using HR_Models.Models.Creation;
using HR_Models.Models.VM;

namespace HR_Models.Models.Profile_Map
{
    public class Map : Profile
    {

        public Map()
        {
            CreateMap<Employee, EmployeeSummary>();
            CreateMap<EmployeeSummary, Employee>();
            CreateMap<Employee, EmployeeCreation>();
            CreateMap<EmployeeCreation, Employee>();
            CreateMap<EmployeeCreation, EmployeeSummary>();
            CreateMap<EmployeeSummary, EmployeeCreation>();



            CreateMap<City, CitySummary>();
            CreateMap<CitySummary, City>();
            CreateMap<CityCreation, CitySummary>();
            CreateMap<CitySummary, CityCreation>();
            CreateMap<CityCreation, City>();
            CreateMap<City, CityCreation>();


            CreateMap<UniverCity, UniverCitySummary>();
            CreateMap<UniverCitySummary, UniverCity>();
            CreateMap<UniverCityCreation, UniverCity>();
            CreateMap<UniverCity, UniverCityCreation>();
            CreateMap<UniverCityCreation, UniverCitySummary>();
            CreateMap<UniverCitySummary, UniverCityCreation>();


            CreateMap<Salary, SalarySummary>();
            CreateMap<SalarySummary, Salary>();
            CreateMap<SalaryCreation, Salary>();
            CreateMap<Salary, SalaryCreation>();
            CreateMap<SalaryCreation, SalarySummary>();
            CreateMap<SalarySummary, SalaryCreation>();



        }


    }
}
