using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFromTemplate.Models
{
    public class CityDataContext : DbContext
    {

        public DbSet<City> Cities { get; set; }
    }
}
