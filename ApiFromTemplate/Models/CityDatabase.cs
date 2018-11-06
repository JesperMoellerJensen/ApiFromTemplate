using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFromTemplate.Models
{
    public static class CityDatabase
    {
        public static List<City> Cities { get; set; } = new List<City>()
        {
            new City
            {
                Id = 1,
                Name = "By 1",
                Desciption = "i'm am city number 1",
                Attractions = new List<Attraction>
                {
                    new Attraction
                    {
                        Id = 1,
                        Name = "Gågade",
                        Desciption = "En gade hvor man kan gå"
                    },
                    new Attraction
                    {
                        Id = 4,
                        Name = "Havnen",
                        Desciption = "Bordtennis og både"
                    },
                }
            },
            new City
            {
                Id = 2,
                Name = "By 2",
                Desciption = "i'm am city number 2",
                Attractions = new List<Attraction>
                {
                    new Attraction
                    {
                        Id = 3,
                        Name = "Tårnet",
                        Desciption = "Det højt og flot"
                    },
                    new Attraction
                    {
                        Id = 2,
                        Name = "Biograf",
                        Desciption = "Viser kun Marvel film"
                    },
                }
            }

        };
    }
}
