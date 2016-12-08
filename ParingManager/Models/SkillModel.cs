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

            list.Add(new Skill { Name = SkillNames.Nobility, Description = "Increases Exp. earned by 20%.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.DragonFang, Description = "[Skl * 0.75] Adds 50% of your Atk to your damage.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.DragonWard, Description = "[Ally's Lck * 0.5] When an adjacent ally is attacked, they take half damage.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.HoshidanUnity, Description = "Increases your skill activation rates by +10%.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.DraconicHex, Description = "After battle, enemy's stats -4 until the next turn.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.NohrianTrust, Description = "During Attack or Guard Stance, user shares their support unit's activation battle skills (i.e.Astra)", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Luck4, Description = "+4 Luck stat.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.InspiringSong, Description = "Target of song gains SKL, SPD, and LUC +3 for one turn.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.VoiceOfPeace, Description = "Enemies within two tiles deal 2 less damage.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.ForeignPrincess, Description = "Foreign army enemies within two tiles deal 2 less damage and take 2 extra damage.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.EvenKeel, Description = "During even-numbered turns, magic damage received -4.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.IronWill, Description = "When enemy triggers battle, magic damage received -4.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Clarity, Description = "User recovers from status reduction effects twice as fast.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.Aggressor, Description = "When user triggers battles, DMG +7.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.Speed2, Description = "Speed stat of user +2.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Relief, Description = "Recover 20% max HP at the start of the player turn if there are no units within two tiles.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.RallyMovement, Description = "Rally command grants Move +1 to allies within two squares.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.Galeforce, Description = "When user triggers battle, they get to act again if they defeat enemy.  This can trigger once per turn.  Does not trigger in Attack / Guard Stance.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.DuelistsBlow, Description = "When user triggers the battle, AVO +30.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Vantage, Description = "When the user's HP < 50%, they attack first regardless of SPD.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Astra, Description = "SKL x 0.5% chance to trigger 5 consecutive hits at half damage.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Swordfaire, Description = "DMG +5 when user is equipped with a sword.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.SealStrength, Description = "After battle, enemy's STR -6 until the next Turn.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.LifeAndDeath, Description = "Character has DMG +10 and damage taken +10.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Aptitude, Description = "Adds 10% to all growth rates when leveling up.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Underdog, Description = "HIT and AVO +15 when user's level is lower than the enemy's.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Profiteer, Description = "LUC% chance of finding a Gold Bar after moving up to Turn 7.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Spendthrift, Description = "If you have a Gold Bar in your inventory when you initiate battle, the Gold Bar is expended to provide DMG + 10 and damage taken - 10.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.PotentPotion, Description = "The effect of healing and stat-boosting potions is increased by 50%.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.QuickSalve, Description = "After consuming a healing or stat-boosting potion, the user can act.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Golembane, Description = "Attacks become super-effective against Mechanists, Replicas, and Golems.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Replicate, Description = "Command; once per map, create a Replica of the user that has the same abilities as the user.User and Replica share the same HP pool.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Locktouch, Description = "User can open doors and chests without the use of keys.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.PoisonStrike, Description = "When user triggers the battle, the enemy's HP is reduced by 20% after the battle is completed.The enemy cannot die from this damage.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Lethality, Description = "SKL x 0.25% chance of instantly defeating the enemy. Attack must be able to deal at least 1 damage naturally for Lethality to trigger.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Shurikenfaire, Description = "DMG +5 when user is equipped with a kunai.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.SealResistance, Description = "After battle, enemy's RES -6 until the next Turn.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Shove, Description = "Command; push an adjacent ally 1 tile away from the user.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.DeathBlow, Description = "When user triggers the battle, CRIT +20.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Counter, Description = "When damaged by adjacent enemy, that enemy receives the same damage.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.SalvageBlow, Description = "When user triggers the battle, LUC% chance of receiving a Katana, Naginata, Club, Yumi, or Shuriken if the user defeats the enemy.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Lancebreaker, Description = "HIT and AVO +50 when the enemy is equipped with a Lance.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.SealDefense, Description = "After battle, enemy's DEF -6 until the next Turn.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Swap, Description = "Command; swap places with an adjacent ally on the map.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.SealSpeed, Description = "After battle, enemy's SPD -6 until the next Turn.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Lancefaire, Description = "DMG +5 when user is equipped with a spear.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.RendHeaven, Description = "(SKL x 1.5)% chance of adding half the enemy's STR (if user has a physical weapon) or MAG (if user has a magical weapon) to damage.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Quixotic, Description = "User and enemy have HIT +30 and skill activation rate +15 during battle.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Magic2, Description = "Magic stat of user +2.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.FutureSight, Description = "LUC% chance of double EXP if user triggers battle and defeats enemy.", LevelLearned = 10 });

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