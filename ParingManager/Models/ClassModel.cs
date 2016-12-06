using ParingManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Models
{
    public class ClassModel
    {
        List<Class> classes;
        public SkillModel skills;

        public ClassModel()
        {
            classes = new List<Class>();
            skills = new SkillModel();
            LoadClasses();
        }

        private void LoadClasses()
        {
            List<Class> list = new List<Class>();

            list.Add(new BaseClass { Name = "Dark Prince(ss)", Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_B, WeaponProficiency.Dragonstone_B }, Skills = new List<Skill> { skills.GetSkillByName("Nobility"), skills.GetSkillByName("Dragon Fang") }, PromotesTo = new List<PromotedClass>(), PromotesToList = "Hoshido Noble, Nohr Noble" });
            list.Add(new PromotedClass { Name = "Hoshido Noble", Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_A, WeaponProficiency.Staff_B, WeaponProficiency.Dragonstone_A }, Skills = new List<Skill> { skills.GetSkillByName("Dragon Ward"), skills.GetSkillByName("Hoshidan Unity") }, PromotedFromString = "Dark Prince(ss)", PromotedFrom = new BaseClass() });
            list.Add(new PromotedClass { Name = "Nohr Noble", Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_A, WeaponProficiency.Tome_B, WeaponProficiency.Dragonstone_A }, Skills = new List<Skill> { skills.GetSkillByName("Draconic Hex"), skills.GetSkillByName("Nohrian Trust") }, PromotedFromString = "Dark Prince(ss)", PromotedFrom = new BaseClass() });
            list.Add(new SpecialClass { Name = "Songstres", Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_C }, Skills = new List<Skill> { skills.GetSkillByName("Luck +4"), skills.GetSkillByName("Inspiring Song"), skills.GetSkillByName("Voice of Peace"), skills.GetSkillByName("Foreign Princess") }, CanPassDown = false });

            classes = list;
        }

        public Class GetClassByClassName(string name)
        {
            return classes.Where(o => o.Name == name).FirstOrDefault();
        }

        public List<string> GetClassNames()
        {
            List<string> list = new List<string>();

            list = classes.OrderBy(o => o.Name).Select(o => o.Name).ToList<string>();

            return list;
        }
    }
}