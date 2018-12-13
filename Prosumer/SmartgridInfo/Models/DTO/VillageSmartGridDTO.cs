using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartgridInfo.Models.DTO
{
    public class VillageSmartGridFullDTO
    {
        public long id;
        [JsonRequired]
        public string Name { set; get; }
        [JsonRequired]
        public long BreakerID { set; get; }
        [JsonRequired]
        public BreakerDTO Breaker { set; get; }
        [JsonRequired]
        public long smID { set; get; }
        [JsonRequired]
        public SmartMeterDTO smartmeter { set; get; }
    }

    public class BreakerDTO
    {
        public long id { set; get; }
        [JsonRequired]
        public string BreakerID { set; get; }
        [JsonRequired]
        public string Connection1 { set; get; }
        [JsonRequired]
        public string Connection2 { set; get; }
    }
    public class SmartMeterDTO
    {
        public long id { set; get; }
        [JsonRequired]
        public string sm_ID { set; get; }
        [JsonRequired]
        public long reqID { set; get; }
        [JsonRequired]
        public RequestDTO _request { set; get; }

    }
    public class RequestDTO
    {
        public long id{ set; get;}
        public string Balance { set; get; }
    }
}

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
    long id { set; get; }
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
    long id { set; get; }
    [JsonRequired]
    public string KWH { set; get; }
    [JsonRequired]
    public string ConsumptionTime { set; get; }
}
public class ProductionDTO
{
    long id { set; get; }
    [JsonRequired]
    public string KWH { set; get; }
    [JsonRequired]
    public string ProductionTime { set; get; }
}