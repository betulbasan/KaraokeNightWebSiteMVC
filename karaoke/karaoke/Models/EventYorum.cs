using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karaoke.Models
{
    public class EventYorum
    {
        public IEnumerable<Event> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }

    }
}