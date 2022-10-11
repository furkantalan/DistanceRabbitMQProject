using System;
using System.Collections.Generic;
using System.Text;

namespace DemandManagement.MessageContracts
{
   public class City
    {

        public string Name { get; set; }
        public int PlateCode { get; set; }
        public double Longitude { get; set; }
        public double Latitute { get; set; }


        public City(int PlateCode, string Name, double Latitude, double Longitude)
        {
            this.PlateCode = PlateCode;
            this.Name = Name;
            this.Longitude = Longitude;
            this.Latitute = Latitute;
        }
        
    }
}
