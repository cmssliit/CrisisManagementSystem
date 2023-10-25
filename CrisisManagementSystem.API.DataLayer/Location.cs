using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int PostalCode { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }

    }
}
