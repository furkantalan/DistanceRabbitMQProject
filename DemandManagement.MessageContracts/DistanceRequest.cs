using System;
using System.Collections.Generic;
using System.Text;

namespace DemandManagement.MessageContracts
{
   public class DistanceRequest
    {
        public int PlateCode1 { get; set; }
        public int PlateCode2 { get; set; }

        public DistanceRequest() { }
        public DistanceRequest(int PlateCode1, int PlateCode2)
        {
            this.PlateCode1 = PlateCode1;
            this.PlateCode2 = PlateCode2;
        }
    }
}
