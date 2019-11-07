using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /* properties and class race data from dnd 5e base materials base attributes no larger than 20 
     * naming for player character stats starts with pc 
    */ 
    public enum Classes{
            Barbarian,
            Bard,
            Cleric,
            Druid,
            Fighter,
            Monk,
            Paladin,
            Ranger,
            Rogue,
            Sorcerer,
            Warlock,
            Wizard
        }
    public enum Races{
        Dwarf,
        Elf,
        Halfling,
        Human,
        Dragonborn,
        Gnome,
        HalfElf, 
        HalfOrc,
        Tiefling
    }
    public class Character{
       
        
        #region Properties
        public string Name { get; set; }
        string Discription { get; set; }
        Races Race { get; set; }
        Classes Class { get; set; }
        #endregion
        int _strength;
        int _dexterity;
        int _constitution;
        int _intelligence;
        int _wisdom;
        int _charisma;
        int _maxHP;
        int _speed;

    }
}
