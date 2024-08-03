using HR_Models.Models.VM;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Models.Models
{
    public class Salary : Entity
    {
        public required DateTime Date_Salarys { get; set; }
        public int? Month
        {
            get
            {
                return Date_Salarys.Month;
            }
        }
        public int? Year
        {
            get
            {
                return Date_Salarys.Year;
            }
        }
<<<<<<< HEAD
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
=======

        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        public DateTime Receipt_Date { get; set; }
        public DateTime Issue_Date { get; set; }


<<<<<<< HEAD

=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        public Salary()
        {


        }
    }
}
