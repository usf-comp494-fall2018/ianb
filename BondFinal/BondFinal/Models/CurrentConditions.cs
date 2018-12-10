using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondFinal.Models
{
    class CurrentConditions
    {
        public int Id { get; set; }
        public string ObservationTime { get; set; }
        public string Weather { get; set; }
        public double TempF { get; set; }
        public string RelativeHumidity { get; set; }
        public string WindDir { get; set; }
        public double WindMph { get; set; }
        public DateTime Lastcheck { get; set; }
    }
}
