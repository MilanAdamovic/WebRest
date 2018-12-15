using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebRest.Models
{
    [DataContract]
    public class WeatherInfo
    {
        
        public string Location { get; set; }
        
        public float Degree { get; set; }
        

        public DateTime DateTime { get; set; }

    }
}