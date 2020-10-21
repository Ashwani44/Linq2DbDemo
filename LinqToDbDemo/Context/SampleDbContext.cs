using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDbDemo.Entities;

namespace LinqToDbDemo.Context
{
    public class SampleDbContext : DataConnection
    {
        public SampleDbContext(LinqToDbConnectionOptions<SampleDbContext> options)
            : base(options)
        {

        }

        public ITable<Employee> Employees => GetTable<Employee>();
        public ITable<Department> Departments => GetTable<Department>();
    }
}
