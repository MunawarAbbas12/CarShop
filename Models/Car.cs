using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShop.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Company { get; set; }
        public String Model { get; set; }
        public int CC { get; set; }
        public int Price { get; set; }
    }
}