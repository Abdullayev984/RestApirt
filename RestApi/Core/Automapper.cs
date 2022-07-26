using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Entities;
using RestApi.Models;

namespace RestApi.Core
{
    public class Automapper:Profile
    {
        public Automapper()
        {


            CreateMap<EmployeeToAddOrUpdateDTO, Employee>();
           
            CreateMap<Employee, EmployeeToListDTO>();
            CreateMap<SectorToAddOrUpdateDTO, Sector>();
            
            CreateMap<Sector, SectorToListDTO>();
            CreateMap<DepartmentToAddOrUpdateDTO, Department>();
            
            CreateMap<Department, DepartmentToListDTO>();
          
      



        }

    }
}
