using System;
using System.Collections.Generic;

#nullable disable

namespace DayInNewCityApp
{
    public partial class Event
    {
        public Event()
        {
            CategoryOfEventsAndEventRs = new HashSet<CategoryOfEventsAndEventR>();
            EventComments = new HashSet<EventComment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionInfo { get; set; }
        public string Contacts { get; set; }
        public string Address { get; set; }
        public DateTime? EventDay { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<CategoryOfEventsAndEventR> CategoryOfEventsAndEventRs { get; set; }
        public virtual ICollection<EventComment> EventComments { get; set; }
    }
}
