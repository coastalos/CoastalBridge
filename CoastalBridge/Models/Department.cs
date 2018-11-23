using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoastalBridge.Models
{
    public class Department
    {
        public int DeptID { get; set; }
        public string Name  { get; set; }
        public string Email { get; set; }
    }
}
