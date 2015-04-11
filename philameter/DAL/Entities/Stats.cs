using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace philameter.DAL.Entities
{
    public class Stats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Source { get; set; }
        public double Stat { get; set; }
        public string PanelClass { get; set; }
        public string FontAwesomeIcon { get; set; }


        public IEnumerable<Tags> Tags { get; set; }

    }
}