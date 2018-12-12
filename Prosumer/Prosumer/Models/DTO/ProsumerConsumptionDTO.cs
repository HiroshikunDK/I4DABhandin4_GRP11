using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProsumerInfo.Models.DTO
{
    public class ProsumerConsumptionDTO
    {
        public long id { set; get; }
        [JsonRequired]
        public string PC_Timestamp { set; get; }
        [JsonRequired]
        public string ProsumerBalance { set; get; }
        [JsonRequired]
        public ProsumerDTO prosumer;
    }

    public class ProsumerDTO
    {
        [JsonRequired]
        public string prosumerType { set; get; }
        [JsonRequired]
        public string X10_ID { set; get; }

        //Underlaying elements

        [JsonRequired]
        public ConsumptionDTO consumption { set; get; }
        [JsonRequired]
        public ProductionDTO production { set; get; }

    }

    public class ConsumptionDTO
    {
        private string KWH { set; get; }
        private string consumption_time { set; get; }
    }
    public class ProductionDTO
    {
        private string KWH { set; get; }
        private string ProductionTime { set; get; }
    }
}
