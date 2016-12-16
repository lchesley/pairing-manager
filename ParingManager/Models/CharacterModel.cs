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