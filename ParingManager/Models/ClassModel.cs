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

            list.Add(new BaseClass { Name = ClassNames.DarkPrincess, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_B, WeaponProficiency.Dragonstone_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Nobility), skills.GetSkillByName(SkillNames.DragonFang) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.HoshidoNoble + ", " + ClassNames.NohrNoble });
            list.Add(new PromotedClass { Name = ClassNames.HoshidoNoble, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_A, WeaponProficiency.Staff_B, WeaponProficiency.Dragonstone_A }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.DragonWard), skills.GetSkillByName(SkillNames.HoshidanUnity) }, PromotedFromList = ClassNames.DarkPrincess, PromotedFrom = new List<BaseClass>() });
            list.Add(new PromotedClass { Name = ClassNames.NohrNoble, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_A, WeaponProficiency.Tome_B, WeaponProficiency.Dragonstone_A }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.DraconicHex), skills.GetSkillByName(SkillNames.NohrianTrust) }, PromotedFromList = ClassNames.DarkPrincess, PromotedFrom = new List<BaseClass>() });
            list.Add(new SpecialClass { Name = ClassNames.Songstress, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_C }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Luck4), skills.GetSkillByName(SkillNames.InspiringSong), skills.GetSkillByName(SkillNames.VoiceOfPeace), skills.GetSkillByName(SkillNames.ForeignPrincess) }, CanPassDown = false });
            list.Add(new SpecialClass { Name = ClassNames.DreadFighter, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_A, WeaponProficiency.Axe_B, WeaponProficiency.Dagger_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.EvenKeel), skills.GetSkillByName(SkillNames.IronWill), skills.GetSkillByName(SkillNames.Clarity), skills.GetSkillByName(SkillNames.Aggressor) }, CanPassDown = false });
            list.Add(new SpecialClass { Name = ClassNames.DarkFalcon, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_B, WeaponProficiency.Tome_A }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Speed2), skills.GetSkillByName(SkillNames.Relief), skills.GetSkillByName(SkillNames.RallyMovement), skills.GetSkillByName(SkillNames.Galeforce) }, CanPassDown = false });
            list.Add(new BaseClass { Name = ClassNames.Samurai, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_B }, Skills = new List<Skill> {skills.GetSkillByName(SkillNames.DuelistsBlow), skills.GetSkillByName(SkillNames.Vantage) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.Swordmaster + ", " + ClassNames.MasterOfArms });
            list.Add(new PromotedClass { Name = ClassNames.Swordmaster, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_S }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Astra), skills.GetSkillByName(SkillNames.Swordfaire) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.Samurai });
            list.Add(new PromotedClass { Name = ClassNames.MasterOfArms, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_A, WeaponProficiency.Spear_B, WeaponProficiency.Axe_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.SealStrength), skills.GetSkillByName(SkillNames.LifeAndDeath) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.Samurai + ", " + ClassNames.Villager });
            list.Add(new BaseClass { Name = ClassNames.Villager, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_C }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Aptitude), skills.GetSkillByName(SkillNames.Underdog) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.MasterOfArms + ", " + ClassNames.Merchant });
            list.Add(new PromotedClass { Name = ClassNames.Merchant, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_B, WeaponProficiency.Bow_A }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Profiteer), skills.GetSkillByName(SkillNames.Spendthrift) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.Villager + ", " + ClassNames.Apothecary });
            list.Add(new BaseClass { Name = ClassNames.Apothecary, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Bow_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.PotentPotion), skills.GetSkillByName(SkillNames.QuickSalve) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.Merchant + ", " + ClassNames.Mechanist });
            list.Add(new PromotedClass { Name = ClassNames.Mechanist, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Dagger_A, WeaponProficiency.Bow_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Golembane), skills.GetSkillByName(SkillNames.Replicate) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.Apothecary + ", " + ClassNames.Ninja });
            list.Add(new BaseClass { Name = ClassNames.Ninja, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Dagger_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Locktouch), skills.GetSkillByName(SkillNames.PoisonStrike) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.MasterNinja + ", " + ClassNames.Mechanist });
            list.Add(new PromotedClass { Name = ClassNames.MasterNinja, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Sword_B, WeaponProficiency.Dagger_S }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Lethality), skills.GetSkillByName(SkillNames.Shurikenfaire) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.Ninja });
            list.Add(new BaseClass { Name = ClassNames.OniSavage, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Axe_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.SealResistance), skills.GetSkillByName(SkillNames.Shove) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.OniSavage + ", " + ClassNames.Blacksmith });
            list.Add(new PromotedClass { Name = ClassNames.OniChieftain, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Axe_A, WeaponProficiency.Tome_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.DeathBlow), skills.GetSkillByName(SkillNames.Counter) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.OniSavage });
            list.Add(new PromotedClass { Name = ClassNames.Blacksmith, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Axe_A, WeaponProficiency.Sword_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.SalvageBlow), skills.GetSkillByName(SkillNames.Lancebreaker) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.OniSavage });
            list.Add(new BaseClass { Name = ClassNames.SpearFighter, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.SealDefense), skills.GetSkillByName(SkillNames.Swap) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.SpearMaster + ", " + ClassNames.Basara });
            list.Add(new PromotedClass { Name = ClassNames.SpearMaster, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_S }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.SealSpeed), skills.GetSkillByName(SkillNames.Lancefaire) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.SpearFighter });
            list.Add(new PromotedClass { Name = ClassNames.Basara, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Spear_A, WeaponProficiency.Tome_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.RendHeaven), skills.GetSkillByName(SkillNames.Quixotic) }, PromotedFrom = new List<BaseClass>(), PromotedFromList = ClassNames.SpearFighter + ", " + ClassNames.Diviner });
            list.Add(new BaseClass { Name = ClassNames.Diviner, Proficiencies = new List<WeaponProficiency> { WeaponProficiency.Tome_B }, Skills = new List<Skill> { skills.GetSkillByName(SkillNames.Magic2), skills.GetSkillByName(SkillNames.FutureSight) }, PromotesTo = new List<PromotedClass>(), PromotesToList = ClassNames.Basara + ", " + ClassNames.Onmyoji });

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