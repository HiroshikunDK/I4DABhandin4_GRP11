using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProsumerInfo.Models.DTOinterface;

namespace ProsumerInfo.Models.DTO
{
    public class Factory: IFactory
    {
        public ProsumerConsumptionFullDTO CreateProsumerConsumptionDTO(ProsumerConsumption prosumerC)
        {
            var dto = new ProsumerConsumptionFullDTO()
            {
                id = prosumerC.id,
                PC_Timestamp = prosumerC.PC_Timestamp,
                ProsumerBalance = prosumerC.ProsumerBalance,

                Prosumer = new ProsumerDTO
                {
                    prosumerType = prosumerC._prosumer.ProsumerType,
                    X10_ID = prosumerC._prosumer.X10_ID,

                    consumption = new ConsumptionDTO
                    {
                        KWH = prosumerC._prosumer.consumption.KWH,
                        ConsumptionTime = prosumerC._prosumer.consumption.Consumption_time
                    },

                    production = new ProductionDTO
                    {
                        KWH = prosumerC._prosumer.production.KWH,
                        ProductionTime = prosumerC._prosumer.production.ProductionTime
                    }
                }
            };
        return dto;
        }

        public ConsumptionDTO CreateSingleConsumptionDTO(Consumption consumption)
        {
            var dto = new ConsumptionDTO
            {
                KWH = consumption.KWH,
                ConsumptionTime = consumption.Consumption_time
            };
            return dto;
        }

        public ProductionDTO CreateSingleProductionDTO(Production production)
        {

            var dto = new ProductionDTO
            {
                KWH = production.KWH,
                ProductionTime = production.ProductionTime
            };
            return dto;
        }

        public ProsumerDTO CreateSingleProsumerDTO(Prosumer prosumer)
        {
            var dto = new ProsumerDTO
            {
                prosumerType = prosumer.ProsumerType,
                X10_ID = prosumer.X10_ID,

                consumption = new ConsumptionDTO
                {
                    KWH = prosumer.consumption.KWH,
                    ConsumptionTime = prosumer.consumption.Consumption_time
                },

                production = new ProductionDTO
                {
                    KWH = prosumer.production.KWH,
                    ProductionTime = prosumer.production.ProductionTime
                }
            };
            return dto;
        }
    }
}
