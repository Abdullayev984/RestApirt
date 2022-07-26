using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApi.BLL.Services.IServices;
using RestApi.Entities;
using RestApi.Models;

namespace RestApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {

       
        public readonly ISectorServices _sectorServices;
       
        public readonly IMapper _mapper;

        public SectorController( ISectorServices sectorServices,
            IMapper mapper)
        {
          
            _sectorServices = sectorServices;
          
            _mapper = mapper;



        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {

            List<SectorToListDTO> sectors = await _sectorServices.Get();
            return Ok(sectors);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SectorToAddOrUpdateDTO sector)
        {

            List<SectorToListDTO> sectors = await _sectorServices.Get();
            sectors.Add(_mapper.Map<SectorToListDTO>(sector));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(SectorToAddOrUpdateDTO sector)
        {

            await _sectorServices.Update(sector);
            return Ok();

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            await _sectorServices.Delete(Convert.ToInt32(id));

            return Ok();
        }
    }
}