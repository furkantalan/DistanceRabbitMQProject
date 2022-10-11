using System;
using System.Collections.Generic;
using System.Text;

namespace DemandManagement.MessageContracts
{
   public class Country
    {

        public Country()
        {

        }

        public string Name = "Turkiye";
        public List<City> Cities = new List<City> {
            new City(1, "Adana", 37, 35.321333),
            new City(2, "Adıyaman", 37.764751, 38.278561),
            new City(3, "Afyonkarahisar", 38.750714, 30.556692),
            new City(4, "Ağrı", 39.626922, 43.021596),
            new City(68, "Aksaray", 38.36869, 34.03698),
            new City(5, "Amasya", 40.64991, 35.83532),
            new City(6, "Ankara", 39.92077, 32.85411),
            new City(7, "Antalya", 36.88414, 30.70563),
            new City(75, "Ardahan", 41.110481, 42.702171),
            new City(10, "Artvin", 41.18277, 41.818292),
            new City(11, "Aydın", 37.856041, 37.856041),
            new City(12, "Balıkesir", 39.648369, 27.88261),
            new City(13, "Bartın", 41.581051, 32.460979),
        };
        

    }
}
