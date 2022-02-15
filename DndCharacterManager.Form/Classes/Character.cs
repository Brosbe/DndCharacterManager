using System;
using System.Collections.Generic;
using System.Text;
using DndCharacterManager.Form.Enums;

namespace DndCharacterManager.Form.Classes
{
    public class Character
    {
        //Seeing how many properties a dnd class really needs is giving me finger cramps already :)
        //I'll have to find a clever way to somehow make these all decently accessible and easily readable.
        public string Name { get; set; }
        public string Class { get; set; }
        public byte Level { get; set; }
        public string Background { get; set; }
        public string Race { get; set; }
        public Alignment alignment { get; set;}
        public byte Inspiration { get; set; }
        public byte ProficiencyBonus { get; set; }
        public int HealthMax { get; set; }
        public int HealthCur { get; set; }
        public int TempHealth { get; set; }
        public byte ArmorClass { get; set; }
        public int HitDiceMax { get; set; }
        public int HitDiceCur { get; set; }
        public bool[] DcSuccess { get; set; } //Length will be 3
        public bool[] DcFail { get; set; } //length will be 3

    }
}
