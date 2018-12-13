﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProsumerInfo.Models.DTO
{
    public class ProsumerConsumptionFullDTO
    {
        public long id { set; get; }
        [JsonRequired]
        public string PC_Timestamp { set; get; }
        [JsonRequired]
        public string ProsumerBalance { set; get; }

        [JsonRequired]
        public ProsumerDTO Prosumer { set; get; }
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
        [JsonRequired]
        public string KWH { set; get; }
        [JsonRequired]
        public string ConsumptionTime { set; get; }
    }
    public class ProductionDTO
    {
        [JsonRequired]
        public string KWH { set; get; }
        [JsonRequired]
        public string ProductionTime { set; get; }
    }
}
