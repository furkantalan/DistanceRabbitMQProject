using System;
using System.Threading.Tasks;
using DemandManagement.MessageContracts;
using Microsoft.AspNetCore.Mvc;

namespace DemandManagement.Api.Controllers
{
    [Route("api/distance")]
    [ApiController]
    public class DemandController : ControllerBase
    {


        // POST: api/distance
        [HttpPost]
        public async Task<IActionResult> GiveDistanceCalculationRequest([FromBody] DistanceRequest request)
        {

            var bus = BusConfigurator.ConfigureBus();

            var sendToUri = new Uri($"{RabbitMqConsts.RabbitMqUri}{RabbitMqConsts.RegisterDemandServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            
            await endPoint.Send(request);

            return Ok("Distance will be shown in console application.");
        }


    }


}
