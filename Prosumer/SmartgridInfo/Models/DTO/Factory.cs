using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartgridInfo.Models.DTOInterface;

namespace SmartgridInfo.Models.DTO
{
    public class Factory : IFactory
    {
        public VillageSmartGridFullDTO createFullVSGDTO(VillageSmartGrid _vsg)
        {
            var dto = new VillageSmartGridFullDTO
            {
                id = _vsg.ID,
                Name = _vsg.Name,
                smartmeter = new SmartMeterDTO
                {
                    id = _vsg._smartmeter.ID,
                    sm_ID = _vsg._smartmeter.SMID,
                    _request = new RequestDTO
                    {
                        id = _vsg._smartmeter._request.ID,
                        Balance = _vsg._smartmeter._request.PowerBalance,
                        _timestamp = _vsg._smartmeter._request.TimeStamp
                    }
                },
                _breaker = new BreakerDTO
                {
                    id = _vsg._breaker.ID,
                    BreakerID = _vsg._breaker.BreakID,
                    Connection1 = _vsg._breaker.Connector1,
                    Connection2 = _vsg._breaker.Connector2
                }


            };

            return dto;
        }
        public BreakerSingleDTO createSingleBreakerDTO(Breaker _breaker, VillageSmartGrid _vsg)
        {
            var dto = new BreakerSingleDTO
            {
                id = _breaker.ID,
                BreakerID = _breaker.BreakID,
                Connection1 = _breaker.Connector1,
                Connection2 = _breaker.Connector2,
                //FK
                VSGID = _breaker._vsgID
            };
            return dto;
        }

        public RequestSingleDTO createSingleRequestDTO(Request _req, Smartmeter _smartmeter)
        {
            var dto = new RequestSingleDTO
            {
                id = _req.ID,
                Balance = _req.PowerBalance,
                _timestamp = _req.TimeStamp,
                //FK
                _samrtmeterID = _smartmeter.ID
            };
            return dto;
        }
    }
}
