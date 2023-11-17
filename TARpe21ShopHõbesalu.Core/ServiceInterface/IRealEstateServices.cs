using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TARpe21ShopHõbesalu.Core.Domain;
using TARpe21ShopHõbesalu.Core.Dto;

namespace TARpe21ShopHõbesalu.Core.ServiceInterface
{
    public interface IRealEstatesServices
    {
        Task<RealEstate> GetAsync(Guid id);
        Task<RealEstate> Create(RealEstateDto dto);
        Task<RealEstate> Update(RealEstateDto dto);
        Task<RealEstate> Delete(Guid id);
    }
}
