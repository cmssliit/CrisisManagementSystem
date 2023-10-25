using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public int DeptHeadId { get; set; }
        public User Users { get; set; }
        public List<Location> Locations { get; set; }

    }
}
