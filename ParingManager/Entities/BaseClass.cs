using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public class BaseClass : Class
    {
        public string PromotesToList { get; set; }
        public List<PromotedClass> PromotesTo { get; set; }
    }
}