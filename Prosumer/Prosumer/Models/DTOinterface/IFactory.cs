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
        ProsumerConsumptionDTO CreateProsumerConsumptionDTO(ProsumerConsumption prosumerconsumption);
        ProsumerDTO CreateSingleProsumerDTO(Prosumer prosumer);
        ProductionDTO CreateSingleProductionDTO(Production production);
        ConsumptionDTO CreateSingleConsumptionDTO(Consumption consumption);
       
    }
}
