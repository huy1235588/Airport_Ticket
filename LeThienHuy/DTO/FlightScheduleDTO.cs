using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThienHuy.DTO
{
    public class FlightScheduleDTO
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string FlightNumber { get; set; }
        public string CabinType { get; set; }
        public decimal CabinPrice { get; set; }
    }
}
