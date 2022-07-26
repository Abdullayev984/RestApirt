
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Entities;

namespace RestApi.DAL.Repositories.IRepositories
{
  public  interface ISectorRepository
    {
        Task<Sector> Get(int SectorId);
        Task <List<Sector>>Get();
       
        Task<Sector> Add(Sector sector);
        Task<Sector> Update(Sector sector);
        Task Delete(int SectorId);
       
    }
}
