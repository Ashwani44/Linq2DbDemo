using LinqToDB.Mapping;
using System;
using System.Collections.Generic;

namespace LinqToDbDemo.Entities
{
    public partial class Department
    {
        [Column]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }

        [Association(ThisKey = nameof(Department.Id), OtherKey = nameof(Employee.DeptId))]
        public ICollection<Employee> Employees { get; set; }
    }
}
