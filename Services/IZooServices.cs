using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Place.Contracts.Requests;
using Zoo.Place.Contracts.Responses;

namespace Zoo.Place.Services
{
    public interface IZooServices
    {
        Task CreateZoo(ZooCreateViewModel model);

    }
}
