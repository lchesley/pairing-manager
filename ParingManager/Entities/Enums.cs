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
        public const string RallyMagic = "Rally Magic";
        public const string Tomefaire = "Tomefaire";
        public const string Miracle = "Miracle";
        public const string RallyLuck = "Rally Luck";
        public const string Renewal = "Renewal";
        public const string Countermagic = "Countermagic";
        public const string DartingBlow = "Darting Blow";
        public const string Camaraderie = "Camaraderie";
        public const string RallySpeed = "Rally Speed";
        public const string WardingBlow = "Warding Blow";
        public const string AirSuperiority = "Air Superiority";
        public const string Amaterasu = "Amaterasu";
        public const string Skill2 = "Skill +2";
        public const string QuickDraw = "Quick Draw";
        public const string CertainBlow = "Certain Blow";
        public const string Bowfaire = "Bowfaire";
        public const string Evenhanded = "Evenhanded";
        public const string Beastbane = "Beastbane";
        public const string EvenBetter = "Even Better";
        public const string GrislyWound = "Grisly Wound";
        public const string ElbowRoom = "Elbow Room";
        public const string Shelter = "Shelter";
        public const string Defender = "Defender";
        public const string Aegis = "Aegis";
        public const string Luna = "Luna";
        public const string ArmoredBlow = "Armored Blow";
        public const string Defense2 = "Defense +2";
        public const string NaturalCover = "Natural Cover";
        public const string WaryFighter = "Wary Fighter";
        public const string Pavise = "Pavise";
        public const string HP5 = "HP +5";
        public const string Gamble = "Gamble";
        public const string RallyStrength = "Rally Strength";
        public const string Axefaire = "Axefaire";
        public const string Sol = "Sol";
        public const string Axebreaker = "Axebreaker";
        public const string GoodFortune = "Good Fortune";
        public const string StrongRiposte = "Strong Riposte";
        public const string RallySkill = "Rally Skill";
        public const string Shurikenbreaker = "Shurikenbreaker";
        public const string Movement1 = "Movement +1";
        public const string LuckySeven = "Lucky Seven";
        public const string Pass = "Pass";
        public const string Strength2 = "Strength +2";
        public const string Lunge = "Lunge";
        public const string RallyDefense = "Rally Defense";
        public const string Swordbreaker = "Swordbreaker";
        public const string SavageBlow = "Savage Blow";
        public const string Trample = "Trample";
        public const string Heartseeker = "Heartseeker";
        public const string MaleficAura = "Malefic Aura";
        public const string Vengeance = "Vengeance";
        public const string Bowbreaker = "Bowbreaker";
        public const string SealMagic = "Seal Magic";
        public const string Lifetaker = "Lifetaker";
        public const string Resistance2 = "Resistance +2";
        public const string Gentilhomme = "Gentilhomme/Demoiselle";
        public const string RallyResistance = "Rally Resistance";
        public const string Inspiration = "Inspiration";
        public const string LiveToServe = "Live to Serve";
        public const string Tomebreaker = "Tomebreaker";
        public const string OddShaped = "Odd Shaped";
        public const string BetterOdds = "Better Odds";
        public const string Survey = "Survey";
        public const string OpportunityShot = "Opportunity Shot";
        public const string RifledBarrel = "Rifled Barrel";
        public const string Surefooted = "Surefooted";
        public const string Shadowgift = "Shadowgift";
        public const string WitchsBrew = "Witch's Brew";
        public const string Warp = "Warp";
        public const string ToxicBrew = "Toxic Brew";
        public const string GentleBlade = "Gentle Blade";
        public const string Charm = "Charm";
        public const string DualGuardsman = "Dual Guardsman";
        public const string Speedtaker = "Speedtaker";
        public const string HeavyBlade = "Heavy Blade";
        public const string VeteranIntuition = "Veteran Intuition";
        public const string Aether = "Aether";
        public const string Strengthtaker = "Strengthtaker";
        public const string DualStriker = "Dual Striker";
        public const string Awakening = "Awakening";
        public const string TacticalGuide = "Tactical Guide";
        public const string Solidarity = "Solidarity";
        public const string Ignis = "Ignis";
        public const string RallySpectrum = "Rally Spectrum";
        public const string Supportive = "Supportive";
        public const string DraconicHeir = "Draconic Heir";
        public const string HealingDescant = "Healing Descant";
        public const string DevotedPartner = "Devoted Partner";
        public const string EvasivePartner = "Evasive Partner";
        public const string BornSteward = "Born Steward";
        public const string MiraculousSave = "Miraculous Save";
        public const string LuckyCharm = "Lucky Charm";
        public const string PerfectPitch = "Perfect Pitch";
        public const string VowOfFriendship = "Vow of Friendship";
        public const string Mischievous = "Mischievous";
        public const string Highwayman = "Highwayman";
        public const string Forager = "Forager";
        public const string InExtremis = "In Extremis";
        public const string Peacebringer = "Peacebringer";
        public const string FieryBlood = "Fiery Blood";
        public const string QuietStrength = "Quiet Strength";
        public const string FearsomeBlow = "Fearsome Blow";
        public const string Perfectionist = "Perfectionist";
        public const string Prodigy = "Prodigy";
        public const string Pyrotechnics = "Pyrotechnics";
        public const string SweetTooth = "Sweet Tooth";
        public const string Capture = "Capture";
        public const string RallyingCry = "Rallying Cry";
        public const string DivineRetribution = "Divine Retribution";
        public const string Haiku = "Haiku";
        public const string Optimistic = "Optimistic";
        public const string Pride = "Pride";
        public const string Vendetta = "Vendetta";
        public const string NohrEnmity = "Nohr Enmity";
        public const string TripleThreat = "Triple Threat";
        public const string Calm = "Calm";
        public const string Competitive = "Competitive";
        public const string Optimist = "Optimist";
        public const string ShurikenMastery = "Shurkien Mastery";
        public const string MorbidCelebration = "Morbid Celebration";
        public const string Reciprocity = "Reciprocity";
        public const string Playthings = "Playthings";
        public const string Bushido = "Bushido";
        public const string NobleCause = "Noble Cause";
        public const string Perspicacious = "Perspicacious";
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
        public const string ShrineMaiden = "Shrine Maiden";
        public const string Monk = "Monk";
        public const string Priestess = "Priestess";
        public const string GreatMaster = "Great Master";
        public const string SkyKnight = "Sky Knight";
        public const string FalconKnight = "Falcon Knight";
        public const string KinshiKnight = "Kinshi Knight";
        public const string Archer = "Archer";
        public const string Sniper = "Sniper";
        public const string Kitsune = "Kitsune";
        public const string NineTails = "Nine-Tails";
        public const string Cavelier = "Cavalier";
        public const string Paladin = "Paladin";
        public const string GreatKnight = "Great Knight";
        public const string Knight = "Knight";
        public const string General = "General";
        public const string Fighter = "Fighter";
        public const string Berserker = "Berserker";
        public const string Hero = "Hero";
        public const string Mercenary = "Mercenary";
        public const string BowKnight = "Bow Knight";
        public const string Outlaw = "Outlaw";
        public const string Adventurer = "Adventurer";
        public const string WyvernRider = "Wyvern Rider";
        public const string WyvernLord = "Wyvern Lord";
        public const string MaligKnight = "Malig Knight";
        public const string DarkMage = "Dark Mage";
        public const string Sorceror = "Sorceror";
        public const string DarkKnight = "Dark Knight";
        public const string Troubadour = "Troubadour";
        public const string Strategist = "Strategist";
        public const string Butler = "Butler/Maid";
        public const string Wolfskin = "Wolfskin";
        public const string Wolfssegner = "Wolfssegner";
        public const string Ballistician = "Ballistician";
        public const string Witch = "Witch";
        public const string Lodestar = "Lodestar";
        public const string Vanguard = "Vanguard";
        public const string GreatLord = "GreatLord";
        public const string Grandmaster = "Grandmaster";
    }

    public class CharacterNames
    {
        public const string Avatar = "Avatar";
        public const string Kana = "Kana";
        public const string Jakob = "Jakob";
        public const string Kaze = "Kaze";
        public const string Silas = "Silas";
        public const string Ryoma = "Ryoma";
        public const string Takumi = "Takumi";
        public const string Azama = "Azama";
        public const string Hayato = "Hayato";
        public const string Hinata = "Hinata";
        public const string Kaden = "Kaden";
        public const string Saizo = "Saizo";
        public const string Subaki = "Subaki";
        public const string Izana = "Izana";
        public const string Shura = "Shura";
        public const string Yukimura = "Yukimura";
        public const string Azura = "Azura";
        public const string Felicia = "Felicia";
        public const string Mozu = "Mozu";
        public const string Hinoka = "Hinoka";
        public const string Sakura = "Sakura";
        public const string Hana = "Hana";
        public const string Kagero = "Kagero";
        public const string Oboro = "Oboro";
        public const string Orochi = "Orochi";
        public const string Rinkah = "Rinkah";
        public const string Setsuna = "Setsuna";
        public const string Reina = "Reina";
        public const string Scarlet = "Scarlet";
        public const string Dwyer = "Dwyer";
        public const string Shigure = "Shigure";
        public const string Shiro = "Shiro";
        public const string Kiragi = "Kiragi";
        public const string Asugi = "Asugi";
        public const string Hisame = "Hisame";
        public const string Midori = "Midori";
        public const string Sophie = "Sophie";
        public const string Caeldori = "Caeldori";
        public const string Mitama = "Mitama";
        public const string Rhajat = "Rhajat";
        public const string Selkie = "Selkie";
    }

}