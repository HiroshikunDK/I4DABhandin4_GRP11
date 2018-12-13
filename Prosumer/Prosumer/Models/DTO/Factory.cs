using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsumerInfo.Models.DTO
{
    public class Factory
    {
        public ProsumerConsumptionDTO CreateProsumerConsumptionDTO(ProsumerConsumption prosumerC)
        {
            var dto = new ProsumerConsumptionDTO()
            {
                id = prosumerC.id,
                PC_Timestamp = prosumerC.PC_Timestamp,
                ProsumerBalance = prosumerC.ProsumerBalance,

                _prosumer = new Prosumer
                {
                    ProsumerType = prosumerC._prosumer.ProsumerType,
                    X10_ID = prosumerC._prosumer.X10_ID,

                    consumption = new Consumption
                    {
                        KWH = prosumerC._prosumer.consumption.KWH,
                        Consumption_time = prosumerC._prosumer.consumption.Consumption_time
                    },

                    production = new Production
                    {
                        KWH = prosumerC._prosumer.production.KWH,
                        ProductionTime = prosumerC._prosumer.production.ProductionTime
                    }
                };
                return dto;
        }
            
        }
    }
}
