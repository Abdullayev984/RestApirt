﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models
{
    public class EmployeeToAddOrUpdateDTO
    {
        public int? EmpId { get; set; }
        public string EmpName { get; set; }
        public string Surname { get; set; }

        public decimal Salary { get; set; }
      
        public int SectorId { get; set; }
      
    }
}
