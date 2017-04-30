using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrototype.Models
{
    public class StationDTO
    {
        public string PlaceName { get; set; } // название места
        public string PlaceCategory { get; set; }
        public double GeoLong { get; set; } // долгота - для карт google
        public double GeoLat { get; set; } // широта - для карт google
        public AvailabilityType ToiletAvail { get; set; }
        public AvailabilityType TrafficLightAvail { get; set; }
        public AvailabilityType MenuAvail { get; set; }
        public AvailabilityType VisualAvail { get; set; }
    }
}