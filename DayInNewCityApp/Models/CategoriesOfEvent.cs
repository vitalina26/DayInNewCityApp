using System;
using System.Collections.Generic;

#nullable disable

namespace DayInNewCityApp
{
    public partial class CategoriesOfEvent
    {
        public CategoriesOfEvent()
        {
            CategoryOfEventsAndEventRs = new HashSet<CategoryOfEventsAndEventR>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CategoryOfEventsAndEventR> CategoryOfEventsAndEventRs { get; set; }
    }
}
