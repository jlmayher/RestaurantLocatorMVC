using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantLocatorMVC.Models
{
    public class Restaurant
    {
        public Restaurant(string name, string streetaddress, string city, string state, int zipcode)
        {
            Name = name;
            StreetAddress = streetaddress;
            City = city;
            State = state;
            ZipCode = zipcode;
        }

        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int ID { get; set; }
    }
}