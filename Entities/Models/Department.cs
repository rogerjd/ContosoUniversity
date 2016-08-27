using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        public string Name { get; set; }
        public decimal Budget{ get; set; }
        public DateTime StartDate{ get; set; }

    }
}
