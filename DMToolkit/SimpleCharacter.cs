using System;

namespace DMToolkit
{
    public class SimpleCharacter
    {
        private string name;
        private int init;
        private int physDamage = 0;
        private int stunDamage = 0;
        private int physDamageMax = 9;
        private int stunDamageMax = 9;

        // Primary Attributes
        private int body = 1;
        private int agility = 1;
        private int reaction = 1;
        private int strength = 1;
        private int charisma = 1;
        private int intuition = 1;
        private int logic = 1;
        private int willpower = 1;

        // Special Attributes
        private int edge = 1;
        private int magic = 0;
        private int resonance = 0;
        private int depth = 0;

        // Derived Attributes
        private int armor = 0;

        public SimpleCharacter(string charName, int initiative, int BOD, int AGI, int REA, int STR, int CHA, int INT, int LOG, int WIL)
        {
            this.name = charName;
            this.init = initiative;
            this.body = BOD;
            this.agility = AGI;
            this.reaction = REA;
            this.strength = STR;
            this.charisma = CHA;
            this.intuition = INT;
            this.logic = LOG;
            this.willpower = WIL;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Init
        {
            get { return this.init; }
            set { this.init = value; }
        }
        // Primary Attribute Getters/Setters
        public int Body
        {
            get { return this.body; }
            set { this.body = value; }
        }
        public int Agility
        {
            get { return this.agility; }
            set { this.agility = value; }
        }
        public int Reaction
        {
            get { return this.reaction; }
            set { this.reaction = value; }
        }
        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }
        public int Charisma
        {
            get { return this.charisma; }
            set { this.charisma = value; }
        }
        public int Intuition
        {
            get { return this.intuition; }
            set { this.intuition = value; }
        }
        public int Logic
        {
            get { return this.logic; }
            set { this.logic = value; }
        }
        public int Willpower
        {
            get { return this.willpower; }
            set { this.willpower = value; }
        }
        // Derived Stat Getters/Setters
        public int PhysDamage
        {
            get { return this.physDamage; }
            set { this.physDamage = value; }
        }
        public int StunDamage
        {
            get { return this.stunDamage; }
            set { this.stunDamage = value; }
        }
        public int PhysDamageMax
        {
            get { return this.physDamageMax; }
            set { this.physDamageMax = value; }
        }
        public int StunDamageMax
        {
            get { return this.stunDamageMax; }
            set { this.stunDamageMax = value; }
        }
    }
}
