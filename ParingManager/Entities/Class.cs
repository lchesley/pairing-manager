using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public abstract class Class
    {
        public string Name { get; set; }
        public List<Skill> Skills { get; set; }
        public List<WeaponProficiency> Proficiencies { get; set; }        
    }
}