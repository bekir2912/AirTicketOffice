using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketOffice
{
    public enum Class
    {
        Business = 0,
        Economic = 1
    }
    public class Flight
    {
        public Flight()
        {
            From = new Location();
            To = new Location();
            airPlane = new AirPlane();
        }
       

        public Guid Id { get; set; }
        public Location From { get; set; }
        public Location To { get; set; }
        public float Cost { get; set; }
        public DateTime dateDeparture { get; set; }
        public DateTime dateArrival { get; set; }
        public double dateFlightMin { get; set; }
        public AirPlane airPlane { get; set; }
        public Class Classes { get; set; }
        public override string ToString()
        {
            return $"Откуда: {From.Country} , {From.City}" +
                   $"Куда : {To.Country} , {To.City}" +
                   $"Цена : {Cost}" +
                   $"Дата вылета: {dateDeparture}" +
                   $"Дата прилета: {dateArrival}" +
                   $"Время полета: {dateFlightMin}"; 
        }

    }
}
