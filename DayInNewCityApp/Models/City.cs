using System;
using System.Collections.Generic;

#nullable disable

namespace DayInNewCityApp
{
    public partial class City
    {
        public City()
        {
            Events = new HashSet<Event>();
            Institutions = new HashSet<Institution>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
