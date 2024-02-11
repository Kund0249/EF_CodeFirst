using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Model.EntityModel
{
    [Table("TDEPARTMENT")]
   public class DepartmentEntity
    {
        [Key]
        public int DepartmentId { get; set; }

        [Column("DeptCode")]
        public string DepartmentCode { get; set; }
        [Column("DeptName")]
        public string DepartmentName { get; set; }
    }
}
