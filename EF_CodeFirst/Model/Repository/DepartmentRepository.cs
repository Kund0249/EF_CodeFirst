using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CodeFirst.Model.EntityModel;

namespace EF_CodeFirst.Model.Repository
{
   public class DepartmentRepository
    {
       private DataContext context = new DataContext();

        public List<DepartmentEntity> GetDepartments { 
            get 
            {
                return context.Departments.ToList();
            } 
        }
        public void Save(DepartmentEntity entity)
        {
            //save
           
            context.Departments.Add(entity);
            context.SaveChanges();
        }

        public void Remove(int DepartmentId)
        {
            //Remove
           DepartmentEntity entity = context.Departments.SingleOrDefault(x => x.DepartmentId == DepartmentId);
            if(entity != null)
            {
                context.Departments.Remove(entity);
                context.SaveChanges();
            }
        
        }

        public void Update(DepartmentEntity entity)
        {
            DepartmentEntity _entity = context.Departments.
                SingleOrDefault(x => x.DepartmentId == entity.DepartmentId);

            if(_entity != null)
            {
                _entity.DepartmentCode = entity.DepartmentCode;
                _entity.DepartmentName = entity.DepartmentName;
                context.SaveChanges();
            }

        }
    }
}
