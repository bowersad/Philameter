using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace philameter.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FontAwesomeIcon { get; set; }
    }
}