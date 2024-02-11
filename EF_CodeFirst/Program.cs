using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CodeFirst.Model.EntityModel;
using EF_CodeFirst.Model.Repository;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository repository = new DepartmentRepository();

            //DepartmentEntity entity = new DepartmentEntity()
            //{
            //    DepartmentCode = "DMGR",
            //    DepartmentName = "Department Manager"
            //};
            //repository.Save(entity);

            //DepartmentEntity Updatedentity = new DepartmentEntity()
            //{
            //    DepartmentId = 2,
            //    DepartmentCode = "DMGR",
            //    DepartmentName = "Department Manager Updated"
            //};
            //repository.Update(Updatedentity);


            //repository.Remove(1);

            var data = repository.GetDepartments;


        }
    }
}
