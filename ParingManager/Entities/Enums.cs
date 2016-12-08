using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Entities
{
    public enum WeaponProficiency
    {
        Sword_C,
        Sword_B,
        Sword_A,
        Sword_S,
        Axe_C,
        Axe_B,
        Axe_A,
        Axe_S,
        Spear_C,
        Spear_B,
        Spear_A,
        Spear_S,
        Tome_C,
        Tome_B,
        Tome_A,
        Tome_S,
        Bow_C,
        Bow_B,
        Bow_A,
        Bow_S,
        Dagger_C,
        Dagger_B,
        Dagger_A,
        Dagger_S,
        Staff_C,
        Staff_B,
        Staff_A,
        Staff_S,
        Beaststone_C,
        Beaststone_B,
        Beaststone_A,
        Beaststone_S,
        Dragonstone_C,
        Dragonstone_B,
        Dragonstone_A,
        Dragonstone_S
    }

    public enum Path
    {
        Hoshido,
        Nohr,
        All
    }

    public class SkillNames
    {
        public const string Nobility = "Nobility";
        public const string DragonFang = "Dragon Fang";
        public const string DragonWard = "Dragon Ward";
        public const string HoshidanUnity = "Hoshidan Unity";
        public const string DraconicHex = "Draconic Hex";
        public const string NohrianTrust = "Nohrian Trust";
        public const string Luck4 = "Luck +4";
        public const string InspiringSong = "Inspiring Song";
        public const string VoiceOfPeace = "Voice of Peace";
        public const string ForeignPrincess = "Foreign Princess";
        public const string EvenKeel = "Even Keel";
        public const string IronWill = "Iron Will";
        public const string Clarity = "Clarity";
        public const string Aggressor = "Aggressor";
        public const string Speed2 = "Speed +2";
        public const string Relief = "Relief";
        public const string RallyMovement = "Rally Movement";
        public const string Galeforce = "Galeforce";
        public const string DuelistsBlow = "Duelist's Blow";
        public const string Vantage = "Vantage";
        public const string Astra = "Astra";
        public const string Swordfaire = "Swordfaire";
        public const string SealStrength = "Seal Strength";
        public const string LifeAndDeath = "Life and Death";
        public const string Aptitude = "Aptitude";
        public const string Underdog = "Underdog";
        public const string Profiteer = "Profiteer";
        public const string Spendthrift = "Spendthrift";
        public const string PotentPotion = "Potent Potion";
        public const string QuickSalve = "Quick Salve";
        public const string Golembane = "Golembane";
        public const string Replicate = "Replicate";
        public const string Locktouch = "Locktouch";
        public const string PoisonStrike = "Poison Strike";
        public const string Lethality = "Lethality";
        public const string Shurikenfaire = "Shurikenfaire";
        public const string SealResistance = "Seal Resistance";
        public const string Shove = "Shove";
        public const string DeathBlow = "Death Blow";
        public const string Counter = "Counter";
        public const string SalvageBlow = "Salvage Blow";
        public const string Lancebreaker = "Lancebreaker";
        public const string SealDefense = "Seal Defense";
        public const string Swap = "Swap";
        public const string SealSpeed = "Seal Speed";
        public const string Lancefaire = "Lancefaire";
        public const string RendHeaven = "Reand Heaven";
        public const string Quixotic = "Quixotic";
        public const string Magic2 = "Magic +2";
        public const string FutureSight = "Future Sight";

    }

    public class ClassNames
    {
        public const string DarkPrincess = "Dark Prince(ss)";
        public const string HoshidoNoble = "Hoshido Noble";
        public const string NohrNoble = "Nohr Noble";
        public const string Songstress = "Songstres";
        public const string DreadFighter = "Dread Fighter";
        public const string DarkFalcon = "Dark Falcon";
        public const string Samurai = "Samurai";
        public const string Swordmaster = "Swordmaster";
        public const string MasterOfArms = "Master of Arms";
        public const string Villager = "Villager";
        public const string Merchant = "Merchant";
        public const string Apothecary = "Apothecary";
        public const string Mechanist = "Mechanist";
        public const string Ninja = "Ninja";
        public const string MasterNinja = "Master Ninja";
        public const string OniSavage = "Oni Savage";
        public const string OniChieftain = "Oni Chieftain";
        public const string Blacksmith = "Blacksmith";
        public const string SpearFighter = "Spear Fighter";
        public const string SpearMaster = "Spear Master";
        public const string Basara = "Basara";
        public const string Diviner = "Diviner";
        public const string Onmyoji = "Onmyoji";
    }

    public class CharacterNames
    {
        public const string Avatar = "Avatar";
        public const string Kana = "Kana";
    }

}