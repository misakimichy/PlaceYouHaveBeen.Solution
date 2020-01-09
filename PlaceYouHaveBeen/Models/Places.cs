using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Journal { get; set; }
        private static List<Place> _instances= new List<Place>{};

        public Place(string city, string country, string journal)
        {
            City = city;
            Country = country;
            Journal = journal;
            _instances.Add(this);
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}