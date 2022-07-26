﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Entities;

namespace RestApi.DAL.Repositories.IRepositories
{
   public interface IEmployeeRepository
    {
        Task<Employee> Get(int EmpId);
        Task<List<Employee>> Get();
        Task<Employee> Add(Employee employee);
        Task<Employee> Update(Employee employee);
        Task Delete(int EmpId);
    }
}
