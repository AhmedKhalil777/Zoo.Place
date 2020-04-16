using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Place.Contracts.Requests;
using Zoo.Place.Contracts.Responses;
using Zoo.Place.Data;
using Zoo.Place.Domain;

namespace Zoo.Place.Services
{
    public class ZooServices : IZooServices
    {
        private readonly ZooDbContext _context;

        public ZooServices(ZooDbContext context)
        {
            _context = context;
        }



        public async Task CreateZoo(ZooCreateViewModel model)
        {
            var newZoo = new Domain.Zoo(){
                Address = model.Address,
                Name = model.Name,
                PicPath = model.PicPath
            
            }; 
           var result = await _context.AddAsync(newZoo);
             await _context.SaveChangesAsync();
        }
    }
}
