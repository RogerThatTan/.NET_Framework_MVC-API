﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WeatherDTO
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public string Condition { get; set; }
        
        public DateTime Date { get; set; }
    }
}
