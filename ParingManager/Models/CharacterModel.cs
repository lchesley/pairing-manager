using ParingManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParingManager.Models
{
    public class CharacterModel
    {
        List<Character> characters;
        public ClassModel classes;        

        public CharacterModel()
        {
            characters = new List<Character>();
            classes = new ClassModel();

            LoadCharacters();
        }

        private void LoadCharacters()
        {
            List<Character> list = new List<Character>();

            list.Add(new Parent { Name = CharacterNames.Avatar, AvailableOn = Path.All, PersonalSkill = classes.GetSkillByName(SkillNames.Supportive), StartingClass = classes.GetClassByClassName(ClassNames.DarkPrincess), AlternateClass = new BaseClass(), InheritanceA = new BaseClass(), InheritanceB = new BaseClass(), FriendshipSupportList = "", FriendshipSupports = new List<Character>(), RomanticSupportsList = "", RomanticSupports = new List<Character>(), AvailableChildName = CharacterNames.Kana, AvailableChild = new Child() });
            list.Add(new Child { Name = CharacterNames.Kana, AvailableOn = Path.All, PersonalSkill = classes.GetSkillByName(SkillNames.DraconicHex), StartingClass = classes.GetClassByClassName(ClassNames.DarkPrincess), AlternateClass = new BaseClass(), InheritanceA = new BaseClass(), InheritanceB = new BaseClass(), RomanticSupports = new List<Character>(), RomanticSupportsList = "", FriendshipSupports = new List<Character>(), FriendshipSupportList = "", PrimaryParent = GetCharacterByCharacterName(CharacterNames.Avatar), PrimaryParentName = "Avatar" });
            list.Add(new Parent { Name = CharacterNames.Azura, AvailableOn = Path.All, PersonalSkill = classes.GetSkillByName(SkillNames.HealingDescant), StartingClass = classes.GetClassByClassName(ClassNames.Songstress), AlternateClass = classes.GetClassByClassName(ClassNames.Troubadour), InheritanceA = classes.GetClassByClassName(ClassNames.SkyKnight), InheritanceB = classes.GetClassByClassName(ClassNames.WyvernRider), AvailableChild = new Child(), AvailableChildName = CharacterNames.Shigure, FriendshipSupportList = "Hinoka, Sakura, Elise, Avatar", FriendshipSupports = new List<Character>(), RomanticSupportsList = "Azama, Hayato, Hinata, Kaden, Ryoma, Saizo, Subaki, Takumi, Arthur, Benny, Keaton, Laslow, Leo, Niles, Odin, Xander, Avatar, Jakob, Kaze, Silas", RomanticSupports = new List<Character>() });
            list.Add(new Character { Name = CharacterNames.Felicia, AvailableOn = Path.All, PersonalSkill = classes.GetSkillByName(SkillNames.DevotedPartner), StartingClass = classes.GetClassByClassName(ClassNames.Troubadour), AlternateClass = classes.GetClassByClassName(ClassNames.Mercenary), InheritanceA = new BaseClass(), InheritanceB = classes.GetClassByClassName(ClassNames.Samurai), FriendshipSupportList = "Hana, Peri, Flora, Avatar", FriendshipSupports = new List<Character>(), RomanticSupportsList = "Azama, Hayato, Hinata, Kaden, Ryoma, Saizo, Takumi, Arthur, Benny, Keaton, Laslow, Leo, Niles, Odin, Xander, Avatar, Jakob, Kaze, Silas", RomanticSupports = new List<Character>() });
            list.Add(new Parent { Name = CharacterNames.Jakob, AvailableOn = Path.All, PersonalSkill = classes.GetSkillByName(SkillNames.EvasivePartner), StartingClass = classes.GetClassByClassName(ClassNames.Troubadour), AlternateClass = classes.GetClassByClassName(ClassNames.Cavelier), InheritanceA = new BaseClass(), InheritanceB = classes.GetClassByClassName(ClassNames.Ninja), FriendshipSupportList = "Takumi, Avatar, Gunter, Silas", FriendshipSupports = new List<Character>(), RomanticSupportsList = "Hana, Hinkoka, Kagero, Oboro, Orochi, Rinkah, Sakura, Setsuna, Beruka, Camilla, Charlotte, Effie, Elise, Nyx, Peri, Selena, Avatar, Azura, Felicia, Mozu", RomanticSupports = new List<Character>(), AvailableChild = new Child(), AvailableChildName = CharacterNames.Dwyer });
            list.Add(new Child { Name = CharacterNames.Dwyer, AvailableOn = Path.All, PersonalSkill = classes.GetSkillByName(SkillNames.BornSteward), StartingClass = classes.GetClassByClassName(ClassNames.Troubadour), AlternateClass = classes.GetClassByClassName(ClassNames.Cavelier), InheritanceA = new BaseClass(), InheritanceB = new BaseClass(), FriendshipSupportList = "Asugi, Kiragi, Percy, Avatar, Jakob", FriendshipSupports = new List<Character>(), RomanticSupportsList = "Caeldori, Mitama, Rhajat, Selkie, Nina, Ophelia, Soliel, Velouria, Avatar, Kana, Sophie, Midori", RomanticSupports = new List<Character>(), PrimaryParent = new Parent(), PrimaryParentName = CharacterNames.Jakob });

            characters = list;
        }

        public Character GetCharacterByCharacterName(string name)
        {
            return characters.Where(o => o.Name == name).FirstOrDefault();
        }

        public List<string> GetCharacterNames()
        {
            List<string> list = new List<string>();

            list = characters.OrderBy(o => o.Name).Select(o => o.Name).ToList<string>();

            return list;
        }
    }
}