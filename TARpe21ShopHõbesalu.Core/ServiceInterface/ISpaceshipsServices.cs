using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe21ShopHõbesalu.Core.Domain;
using TARpe21ShopHõbesalu.Core.Dto;

namespace TARpe21ShopHõbesalu.Core.ServiceInterface
{
    public interface ISpaceshipsServices
    {
        Task<Spaceship> Create(SpaceshipDto dto);
        //Task<Spaceship> GetUpdate(Guid id);         - not needed
        Task<Spaceship> Update(SpaceshipDto dto);
        Task<Spaceship> Delete(Guid Id);
        Task<Spaceship> GetAsync(Guid Id);
    }
}