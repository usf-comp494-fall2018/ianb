using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondFinal.Models
{
    class ThreeDay
    {
        public int ThreeDayID { get; set; }
        public int Period { get; set; }
        public string Icon { get; set; }
        public string Day { get; set; }
        public string ThreeDayDesciption {get; set;}
        public DateTime ThreeDayLastChecked { get; set; }
    }
}
