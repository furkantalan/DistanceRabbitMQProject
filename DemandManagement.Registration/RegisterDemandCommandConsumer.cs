using DemandManagement.MessageContracts;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace DemandManagement.Registration
{
    public class RegisterDemandCommandConsumer : IConsumer<DistanceRequest>
    {
        public async Task Consume(ConsumeContext<DistanceRequest> context)
        {
            var message = context.Message;
            var guid = Guid.NewGuid();
            int plateCode1 = message.PlateCode1;
            int plateCode2 = message.PlateCode2;
            var Turkiye = new Country();
            City city1 = Turkiye.Cities.Find(city => city.PlateCode == plateCode1);
            City city2 = Turkiye.Cities.Find(city => city.PlateCode == plateCode2);

            if(city1 == null || city2 == null)
            {
                Console.WriteLine($"One of the given cities not found with given plate codes({plateCode1}, {plateCode2}).");
                return;
            }

            Console.WriteLine($"Distance between {city1.Name} and {city2.Name} calculating.");
            double distance = this.GetDistance(city1, city2);
            Console.WriteLine($"Distance between {city1.Name} and {city2.Name} is {distance} kilometers.");
            Console.WriteLine($"----------------------------------------------------------------");
        }

        private double GetDistance(City city1, City city2)
        {
            var lat1 = city1.Latitute;
            var lon1 = city1.Longitude;

            var lat2 = city2.Latitute;
            var lon2 = city2.Longitude;

            var d1 = lat1 * (Math.PI / 180.0);
            var num1 = lon1 * (Math.PI / 180.0);
            var d2 = lat2 * (Math.PI / 180.0);
            var num2 = lon2 * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
                     Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            return 6371 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }
    }
}
