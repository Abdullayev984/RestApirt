
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Models;

namespace RestApi.BLL.Services.IServices
{
   public interface IEmployeeService
    {
        Task<EmployeeToListDTO> Add(EmployeeToAddOrUpdateDTO employeeToAddOrUpdateDTO);
        Task<EmployeeToListDTO> Update(EmployeeToAddOrUpdateDTO employeeToAddOrUpdateDTO);
        Task<List<EmployeeToListDTO>> Get();
        Task<EmployeeToListDTO> Get(int id);
        Task Delete(int id);

       
    }
}
