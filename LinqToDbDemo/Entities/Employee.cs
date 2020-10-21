using LinqToDB.Mapping;
using System;

namespace LinqToDbDemo.Entities
{
    public partial class Employee
    {
        [Column]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }

        [Column]
        public Guid DeptId { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }

        public Department Department { get; set; }
    }
}
