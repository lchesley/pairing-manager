using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public class PromotedClass : Class
    {
        public string PromotedFromString { get; set; }
        public BaseClass PromotedFrom { get; set; }
    }
}