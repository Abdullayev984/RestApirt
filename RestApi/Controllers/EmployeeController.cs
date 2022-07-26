using Microsoft.AspNetCore.Mvc;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RestApi.BLL.Services.IServices;
using RestApi.Models;


namespace RestApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController :ControllerBase
    {
        public readonly IEmployeeService _employeeService;
        public readonly IMapper _mapper;



        public EmployeeController(IEmployeeService employeeService, IMapper mapper) 
           
        {
            _employeeService = employeeService;
            _mapper = mapper;


        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<EmployeeToListDTO> employees = await _employeeService.Get();
            return Ok(employees);
        }
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeToAddOrUpdateDTO employee)
        {

            List<EmployeeToListDTO> employees = await _employeeService.Get();
            employees.Add(_mapper.Map<EmployeeToListDTO>(employee));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(EmployeeToAddOrUpdateDTO employee)
        {

            await _employeeService.Update(employee);
            return Ok();

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            await _employeeService.Delete(Convert.ToInt32(id));

            return Ok();
        }
    }
}