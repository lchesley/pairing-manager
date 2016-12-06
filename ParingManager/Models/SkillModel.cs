using ParingManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Models
{
    public class SkillModel
    {
        List<Skill> skills;

        public SkillModel()
        {
            skills = new List<Skill>();
            LoadSkills();
        }

        private void LoadSkills()
        {
            List<Skill> list = new List<Skill>();

            list.Add(new Skill { Name = "Nobility", Description = "Increases Exp. earned by 20%.", LevelLearned = 1 });
            list.Add(new Skill { Name = "Dragon Fang", Description = "[Skl * 0.75] Adds 50% of your Atk to your damage.", LevelLearned = 10 });
            list.Add(new Skill { Name = "Dragon Ward", Description = "[Ally's Lck * 0.5] When an adjacent ally is attacked, they take half damage.", LevelLearned = 5 });
            list.Add(new Skill { Name = "Hoshidan Unity", Description = "Increases your skill activation rates by +10%.", LevelLearned = 15 });
            list.Add(new Skill { Name = "Draconic Hex", Description = "After battle, enemy's stats -4 until the next turn.", LevelLearned = 5 });
            list.Add(new Skill { Name = "Nohrian Trust", Description = "During Attack or Guard Stance, user shares their support unit's activation battle skills (i.e.Astra)", LevelLearned = 15 });
            list.Add(new Skill { Name = "Luck +4", Description = "+4 Luck stat.", LevelLearned = 1 });
            list.Add(new Skill { Name = "Inspiring Song", Description = "Target of song gains SKL, SPD, and LUC +3 for one turn.", LevelLearned = 10 });
            list.Add(new Skill { Name = "Voice of Peace", Description = "Enemies within two tiles deal 2 less damage.", LevelLearned = 25 });
            list.Add(new Skill { Name = "Foreign Princess", Description = "Foreign army enemies within two tiles deal 2 less damage and take 2 extra damage.", LevelLearned = 35 });

            skills = list;
        }

        public Skill GetSkillByName(string name)
        {
            Skill skill = new Skill();

            skill = skills.Where(o => o.Name == name).FirstOrDefault();

            return skill;
        }

        public List<string> GetSkillNames()
        {
            List<string> list = new List<string>();

            list = skills.OrderBy(o => o.Name).Select(o => o.Name).ToList<string>();

            return list;
        }
    }
}