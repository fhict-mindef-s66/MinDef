using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinDef_Sensor_MockService.Model
{
    public class AcousticMessage
    {
        public int degrees { get; set; }
        public int decibel { get; set; }
        public int distanceInMeters { get; set; }
        public DateTime time { get; set; }
    }
}
