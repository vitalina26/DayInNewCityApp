using System;
using System.Collections.Generic;

#nullable disable

namespace DayInNewCityApp
{
    public partial class CategoryOfEventsAndEventR
    {
        public int Id { get; set; }
        public int CategoryOfEventsId { get; set; }
        public int EventId { get; set; }

        public virtual CategoriesOfEvent CategoryOfEvents { get; set; }
        public virtual Event Event { get; set; }
    }
}
