﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Entities;

namespace RestApi.DAL.Repositories.IRepositories
{
   public interface IDepartmentRepository
    {
        Task<Department> Get(int DepartmentId);
        Task<List<Department>> Get();
        Task<Department> Add(Department department);
        Task<Department> Update(Department department);
        Task Delete(int DepartmentId);

        
    }
}
