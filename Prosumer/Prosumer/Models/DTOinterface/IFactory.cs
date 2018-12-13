using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProsumerInfo.Models;
using ProsumerInfo.Models.DTO;


namespace ProsumerInfo.Models.DTOinterface
{
    interface IFactory
    {
        ProsumerConsumptionFullDTO CreateProsumerConsumptionDTO(ProsumerConsumption prosumerconsumption);
        ProductionSingleDTO CreateSingleProductionDTO(Production production, Prosumer prosumer);
        ConsumptionSingleDTO CreateSingleConsumptionDTO(Consumption consumption, Prosumer prosumer);
       
    }
}
