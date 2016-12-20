using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public class Character
    {
        public string Name { get; set; }
        public Class StartingClass { get; set; }
        public Class AlternateClass { get; set; }
        public Class AlternateClassB { get; set; }
        public Class InheritanceA { get; set; }
        public Class InheritanceB { get; set; }
        public Skill PersonalSkill { get; set; }
        public Path AvailableOn { get; set; }
        public string RomanticSupportsList { get; set; }
        public List<Character> RomanticSupports { get; set; }
        public string FriendshipSupportList { get; set; }
        public List<Character> FriendshipSupports { get; set; }
    }
}