using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public int DeptHeadId { get; set; }
        public virtual User DeptHead { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

    }
}
