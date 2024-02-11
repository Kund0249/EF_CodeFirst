using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_CodeFirst.Model.EntityModel;

namespace EF_CodeFirst.Model.Repository
{
    class DataContext : DbContext
    {
        public DataContext() : base("name=DBCON")
        {

        }
        public DbSet<DepartmentEntity> Departments { get; set; }

       // public DbSet<EmployeeEntity> Employee { get; set; }
    }
}
