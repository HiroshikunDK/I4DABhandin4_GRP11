using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartgridInfo.Models.DTO;
using SmartgridInfo.Models;

namespace SmartgridInfo.Models.DTOInterface
{
    interface IFactory
    {
        VillageSmartGridFullDTO createFullVSGDTO(VillageSmartGrid _vsg);
        RequestSingleDTO createSingleRequestDTO(Request _req, Smartmeter _smartmeter);
        BreakerSingleDTO createSingleBreakerDTO(Breaker _breaker, VillageSmartGrid _vsg);

    }
}
