//Peter Young
//11/8/19
//Cosc1430
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
        public string Discription { get; set; }
        public Races Race { get; set; }
        public Classes Class { get; set; }
        #endregion
        #region get/set fields 
        public int Strength { get => _strength; set => _strength=value; }
        public int Dexterity { get => _dexterity; set => _dexterity=value; }
        public int Constitution { get => _constitution; set => _constitution=value; }
        public int Intelligence { get => _intelligence; set => _intelligence=value; }
        public int Wisdom { get => _wisdom; set => _wisdom=value; }
        public int Charisma { get => _charisma; set => _charisma=value; }
        public int MaxHP { get => _maxHP; set => _maxHP=value; }
        public int Speed { get => _speed; set => _speed=value; }
        #endregion
        int _strength;
        int _dexterity;
        int _constitution;
        int _intelligence;
        int _wisdom;
        int _charisma;
        int _maxHP;
        int _speed;

        public override string ToString() => $"{Name} {Race} {Class}";
    }
}
