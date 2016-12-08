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

            list.Add(new Parent { Name = CharacterNames.Avatar, AvailableOn = Path.All, PersonalSkill = classes.skills.GetSkillByName("Supportive"), StartingClass = classes.GetClassByClassName(ClassNames.DarkPrincess), AlternateClass = new BaseClass(), InheritanceA = new BaseClass(), InheritanceB = new BaseClass(), FriendshipSupportList = "", FriendshipSupports = new List<Character>(), RomanticSupportsList = "", RomanticSupports = new List<Character>(), AvailableChildName = CharacterNames.Kana, AvailableChild = new Child() });

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