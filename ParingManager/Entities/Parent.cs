using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public class Parent : Character
    {
        public string AvailableChildName { get; set; }
        public Character AvailableChild { get; set; }
    }
}