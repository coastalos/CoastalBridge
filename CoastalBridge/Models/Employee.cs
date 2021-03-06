﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.IdentityModel;
using Microsoft.AspNetCore.Identity;

namespace CoastalBridge.Models
{
    public enum EmployeeStatus
    {
        Active,
        Exit
    }

    public class Employee : IdentityUser
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }

        public EmployeeStatus Status { get; set; }

        public int DeptID { get; set; }
    }
}
