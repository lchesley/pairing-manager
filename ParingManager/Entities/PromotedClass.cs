using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public class PromotedClass : Class
    {
        public string PromotedFromList { get; set; }
        public List<BaseClass> PromotedFrom { get; set; }
    }
}