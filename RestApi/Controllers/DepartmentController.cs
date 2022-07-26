using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RestApi.BLL.Services.IServices;
using RestApi.Entities;
using RestApi.Models;

namespace RestApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
   
        public readonly IDepartmentService _departmentService;

        public readonly IMapper _mapper;
        public DepartmentController(IDepartmentService departmentService, IMapper mapper)
        {
   
            _departmentService = departmentService;
            _mapper = mapper;


        }
       [HttpGet]
        public async Task<IActionResult> GetList()
        {
           
            List<DepartmentToListDTO> departments = await _departmentService.Get();
            return Ok(departments);
        }
        [HttpPost]
        public async Task<IActionResult> Add(DepartmentToAddOrUpdateDTO department)
        {

            List<DepartmentToListDTO> departments = await _departmentService.Get();
         departments.Add(_mapper.Map<DepartmentToListDTO>(department) );
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(DepartmentToAddOrUpdateDTO department)
        {

           await _departmentService.Update(department);
            return Ok();

        }
        [HttpDelete]
        public async Task< IActionResult> Delete(int id )
        {
          
            await  _departmentService.Delete(Convert.ToInt32(id));
        
            return Ok();
        }
    }
}
