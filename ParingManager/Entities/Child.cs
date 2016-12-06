using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public class Child : Character  
    {
        public string PrimaryParentName { get; set; }
        public Character PrimaryParent { get; set; }
    }
}