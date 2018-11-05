﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiFromTemplate.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }

        [JsonIgnore]
        public List<Attraction> Attractions { get; set; }
    }
}
