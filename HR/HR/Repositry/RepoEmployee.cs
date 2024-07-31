using HR.Data;
using HR_Models.Models;
using HR_Models.Models.VM;

namespace HR.Repositry
{
    public class RepoEmployee : RepositryAllModels<Employee,EmployeeSummary>
    {
        public RepoEmployee(HR_Context context) : base(context)
        {

        }
    }
}
