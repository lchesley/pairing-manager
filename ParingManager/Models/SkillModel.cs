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
            list.Add(new Skill { Name = SkillNames.RallyMagic, Description = "Rally command grants MAG +4 to allies within two squares.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Tomefaire, Description = "DMG +5 when user is equipped with a tome.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Miracle, Description = "LUC% of surviving a lethal hit with 1 HP.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.RallyLuck, Description = "Rally command grants LUC +8 to allies within two squares.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Renewal, Description = "Recover 30% max HP at the start of the player's turn.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Countermagic, Description = "When enemy triggers battle and inflicts magic damage, they receive the same damage in return.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.DartingBlow, Description = "When user triggers battle, double attack threshold +5.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Camaraderie, Description = "Recover 10% max HP at the start of the player turn if there is at least one ally within two tiles of the user.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.RallySpeed, Description = "Rally command grants SPD +4 to allies within two squares.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.WardingBlow, Description = "When user triggers battle, magic damage received -20.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.AirSuperiority, Description = "HIT and AVO +30 when facing Flying enemies.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Amaterasu, Description = "Allies within two tiles recover 20% max HP on the player's turn.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Skill2, Description = "Skill stat of user +2.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.QuickDraw, Description = "When user triggers battle, DMG +4.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.CertainBlow, Description = "When user triggers battle, HIT +40.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Bowfaire, Description = "DMG +5 when user is equipped with a bow.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Evenhanded, Description = "During even-numbered turns, DMG +4.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Beastbane, Description = "Kitsune and Wolfskin attacks become super-effective against Beasts.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.EvenBetter, Description = "User recovers 40% max HP at the start of even-numbered turns.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.GrislyWound, Description = "The enemy's HP is reduced by 20% after battle.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.ElbowRoom, Description = "When user fights in terrain with no terrain effects, DMG +3.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Shelter, Description = "Command: makes an adjacent ally the user's support unit.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Defender, Description = "When user is the lead unit in Guard Stance, all stats +1.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Aegis, Description = "SKL% chance to halve damage from Bow, Magic, Kunai, Dragonstone, Breath, or Ballista attacks.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Luna, Description = "SKL% chance to ignore half of the enemy's DEF/ RES (based on weapon).", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.ArmoredBlow, Description = "When user triggers battle, physical damage received -10.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Defense2, Description = "Defense stat of user +2.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.NaturalCover, Description = "When user fights in terrain with terrain effects, damage taken -3.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.WaryFighter, Description = "During battle, neither user nor opponent can double attack.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Pavise, Description = "SKL% chance to halve damage from Sword, Lance, Axe, Beaststone, Monster, or Puppet attacks.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.HP5, Description = "Maximum HP of user +5.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Gamble, Description = "User's HIT -10, but CRIT +10.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.RallyStrength, Description = "Rally command grants STR +4 to allies within two squares.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Axefaire, Description = "DMG +5 when user is equipped with an axe.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Sol, Description = "SKL% chance to recover HP equal to half the damage done to the enemy.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Axebreaker, Description = "HIT and AVO +50 when the enemy is equipped with an Axe.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.GoodFortune, Description = "LUC% chance of recovering 20% max HP at the start of the player turn.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.StrongRiposte, Description = "When enemy triggers the battle, user has DMG +3.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.RallySkill, Description = "Rally command grants SKL +4 to allies within two squares.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Shurikenbreaker, Description = "HIT and AVO +50 when the enemy is equipped with a Kunai.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Movement1, Description = "Movement range for user +1.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.LuckySeven, Description = "User's HIT and AVO +20 for the first seven turns of battle.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Pass, Description = "User can move through tiles occupied by enemy units.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Strength2, Description = "Strength stat of user +2.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Lunge, Description = "Command: attack the enemy and swap places with them afterward.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.RallyDefense, Description = "Rally command grants DEF +4 to allies within two squares.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Swordbreaker, Description = "HIT and AVO +50 when the enemy is equipped with a Sword.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.SavageBlow, Description = "When user triggers battle, enemies within 2 tiles lose 20% HP.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Trample, Description = "If the enemy is unmounted, user has DMG +5.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Heartseeker, Description = "When fighting adjacent to an enemy, that enemy's AVO -20.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.MaleficAura, Description = "Enemies within 2 tiles take +2 damage from magical attacks.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Vengeance, Description = "SKL x1.5% chance to add ((User's Max HP - User's current HP)/ 2) damage to the user's attack.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Bowbreaker, Description = "HIT and AVO +50 when the enemy is equipped with a Bow.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.SealMagic, Description = "After battle, enemy's MAG -6 until the next Turn.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Lifetaker, Description = "When user triggers battle and defeats the enemy, recover 50% max HP.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.Resistance2, Description = "Resistance stat of user +2.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Gentilhomme, Description = "Opposite sex allies within two tiles have damage taken -2 during battle.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.RallyResistance, Description = "Rally command grants DEF +4 to allies within two squares.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Inspiration, Description = "Allies within two tiles have DMG +2 and damage taken -2 during battle.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.LiveToServe, Description = "When healing an ally, the user recovers the same amount of HP.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Tomebreaker, Description = "HIT and AVO +50 when the enemy is equipped with a Tome.", LevelLearned = 15 });
            list.Add(new Skill { Name = SkillNames.OddShaped, Description = "During odd-numbered turns, DMG +4.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.BetterOdds, Description = "User recovers 40% max HP at the start of odd-numbered turns.", LevelLearned = 5 });
            list.Add(new Skill { Name = SkillNames.Survey, Description = "When using the 'Turret' command, Turret HIT +10.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.OpportunityShot, Description = "When user is a Ballistician, SKL% chance to attack an enemy within range at the start of the user's turn.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.RifledBarrel, Description = "When using the 'Turret' command, Turret range +1; inner/outer range -1.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.Surefooted, Description = "When user is a Ballistician, Movement +1 and all traversable terrain costs 1 movement point to cross.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.Shadowgift, Description = "User can equip Dark Mage-exclusive tomes, i.e. Nosferatu.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.WitchsBrew, Description = "LUC% chance of obtaining a Potion item after moving up to the 7th turn.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Warp, Description = "Command; instantly move adjacent to an ally and perform another action.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.ToxicBrew, Description = "When user triggers battle, SKL x 1.5% chance to reduce enemy's Movement to 0 and AVO by 20 after the battle(until the next turn).", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.GentleBlade, Description = "User's SPD +3, DEF -1.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Charm, Description = "Allies within 2 tiles have DMG +2 during battle.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.DualGuardsman, Description = "When user is the support unit in Guard Stance, Shield Gauge Gain +1.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.Speedtaker, Description = "When user defeats the enemy, SPD +2 for the rest of the battle. Stacks up to 10.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.HeavyBlade, Description = "User's STR +3, SPD -1.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.VeteranIntuition, Description = "CRIT EVA +15 during battles.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Aether, Description = "SKL x 0.5% chance of triggering a Sol hit and then a Luna hit.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.Strengthtaker, Description = "When user defeats the enemy, STR +2 for the rest of the battle. Stacks up to 10.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.DualStriker, Description = "User's STR +3, SPD -1.", LevelLearned = 1 });            
            list.Add(new Skill { Name = SkillNames.Awakening, Description = "When user defeats the enemy, STR +2 for the rest of the battle. Stacks up to 10.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.TacticalGuide, Description = "When user is the support unit in Guard Stance, lead unit gets HIT +10.", LevelLearned = 1 });
            list.Add(new Skill { Name = SkillNames.Solidarity, Description = "Adjacent allies receive AVO +10 and CRIT EVA +10.", LevelLearned = 10 });
            list.Add(new Skill { Name = SkillNames.Ignis, Description = "SKL% chance of adding half the user's STR (if the user has a magical weapon) or MAG (if the user has a physical weapon) as damage.", LevelLearned = 25 });
            list.Add(new Skill { Name = SkillNames.RallySpectrum, Description = "Rally command grants All Stats +2 to allies within two squares.", LevelLearned = 35 });
            list.Add(new Skill { Name = SkillNames.Supportive, Description = "When supporting a unit s/he has a C Support or higher with, the lead unit has HIT + 10, DMG + 2, and damage taken - 2.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.DraconicHeir, Description = "When Kana is equipped with a Dragonstone, s/he recovers 15% HP at the start of the turn.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.HealingDescant, Description = "Allies within 2 tiles recover 10% HP at the start of the turn.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.DevotedPartner, Description = "If Corrin is the lead Unit, Corrin's DMG +2 and damage taken -2.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.EvasivePartner, Description = "If Corrin is the lead unit, Corrin's AVO +15 and damage taken -3.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.BornSteward, Description = "When fighting in My Castle, HIT/AVO +20, DMG +2, damage taken -2.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.MiraculousSave, Description = "If Kaze is the support unit, the lead unit has a LUC% chance of surviving a lethal hit with 1 HP.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.LuckyCharm, Description = "Skills with an activation rate dependent on the LUC stat have their rate increased by 20 %.Such skills include Salvage Blow, Future Sight, Miracle, Profiteer, and Good Fortune.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.PerfectPitch, Description = "Command that causes allies within 2 tiles who have lower HP than Shigure to recover 10 % HP.Counts as a Rally.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.VowOfFriendship, Description = "If Corrin is an ally and under 50% HP, Silas' DMG +3 and damage taken -3.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Mischievous, Description = "When Sophie triggers battle and hits an enemy, her target's DEF -3 and their clothes get torn off.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Highwayman, Description = "When Shura triggers the battle and the enemy cannot counter, the enemy has STR and SPD - 3 after the battle for one turn.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Forager, Description = "When standing on Mountain, Forest, Wasteland, or Field terrain, Mozu recovers 20 % HP at the start of the turn.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.InExtremis, Description = "When Scarlet's HP is under a quarter, CRIT +30.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Peacebringer, Description = "Allies and enemies within 2 tiles receive damage taken -2.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.FieryBlood, Description = "When Rinkah's HP is not full, DMG +4.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.QuietStrength, Description = "Allies within 2 tiles take 2 less damage.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.FearsomeBlow, Description = "When Hana triggers the battle and defeats her target, enemies adjacent to Hana have their HP reduced by 20 %.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Perfectionist, Description = "When Subaki's HP is full, HIT and AVO +15.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Prodigy, Description = "At the start of battle, if the enemy's higher stat between STR or MAG is higher than Caeldori's corresponding stat, then Caeldori's DMG + 4.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Pyrotechnics, Description = "When Saizo triggers a battle at under half HP, he and all enemies within 2 tiles have their HP reduced by 20 %.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.SweetTooth, Description = "After choosing to Wait, Asugi eats sweets to recover 4 HP.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Capture, Description = "Use this command to capture enemies.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.RallyingCry, Description = "Allies within 2 tiles deal DMG +2.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.DivineRetribution, Description = "When Azama doesn't have a weapon equipped and takes damage from an adjacent enemy,the enemy receives half the same damage.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Haiku, Description = "At the start of the turn, if Mitama has one ally directly above her and another directly below, those two allies recover 5 HP and Mitama recovers 7.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Optimistic, Description = "Setsuna recovers x1.5 HP when healed by a staff.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Pride, Description = "When Hayato's level is lower than the enemy's, Hayato DMG +3.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Vendetta, Description = "When Rhajat triggers battle in a map that you've already completed before, DMG + 4.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.NohrEnmity, Description = "When engaging a Nohr-aligned enemy, Oboro deals DMG +3.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.TripleThreat, Description = "When Hinata is under half HP, half of the damage he takes from Swords, Lances, or Axes is also dealt to the enemy.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Calm, Description = "After choosing to Wait, SKL and RES +4 for one turn.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Competitive, Description = "When Takumi is the lead unit and his level is lower than that of his support unit, Takumi's CRIT +10, DMG +3, and damage taken -1.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Optimist, Description = "After choosing to Wait, SPD +4 and LUC +8 for one turn.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.ShurikenMastery, Description = "When Kagero receives damage from a Kunai attack, the attacker receives half the same damage and the Kunai's stat reduction effect.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.MorbidCelebration, Description = "When Reina triggers the battle, she recovers 20% HP if she defeats her target.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Reciprocity, Description = "When a unit heals Kaden with a healing staff, that unit recovers HP equal to half the amount Kaden was healed for.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Playthings, Description = "At the start of the turn, all enemies that are adjacent to Selkie take 5 damage.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.Bushido, Description = "When Ryoma is the lead unit, if his level is higher than his support unit's, then Ryoma's CRIT +10, DMG +2, and damage taken -2.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.NobleCause, Description = "When Shiro is the lead unit and his support unit does not have full HP, Shiro's DMG +3 and damage taken -1.", LevelLearned = 0 });
            list.Add(new Skill { Name = SkillNames.NobleCause, Description = "HIT +5 for all allies.", LevelLearned = 0 });

            skills = list;
        }
    }
}