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
        public BreakerDTO _breaker { set; get; }
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
        public RequestDTO _request { set; get; }

    }
    public class RequestDTO
    {
        public long id{ set; get;}
        [JsonRequired]
        public string Balance { set; get; }
        [JsonRequired]
        public string _timestamp { set; get; }
    }

    public class BreakerSingleDTO
    {
        public long id { set; get; }
        [JsonRequired]
        public string BreakerID { set; get; }
        [JsonRequired]
        public string Connection1 { set; get; }
        [JsonRequired]
        public string Connection2 { set; get; }
        [JsonRequired]
        public long VSGID { set; get; }
    }

    public class RequestSingleDTO
    {
        public long id { set; get; }
        [JsonRequired]
        public string Balance { set; get; }
        [JsonRequired]
        public string _timestamp { set; get; }
        [JsonRequired]
        public long _samrtmeterID { set; get; }
    }
}