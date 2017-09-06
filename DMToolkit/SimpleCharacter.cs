using System;

namespace DMToolkit
{
    public class SimpleCharacter
    {
        private string name;
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
        private int initDice = 1;
        private int edge = 1;
        private int magic = 0;
        private int resonance = 0;
        private int depth = 0;

        // Derived Attributes
        private int init;
        private int currentInit;
        private int armor = 0;
        private int[] movement;

        public SimpleCharacter(string charName, int initiative, int BOD, int AGI, int REA, int STR, int CHA, int INT, int LOG, int WIL)
        {
            this.name = charName;
            this.body = BOD;
            this.agility = AGI;
            this.reaction = REA;
            this.strength = STR;
            this.charisma = CHA;
            this.intuition = INT;
            this.logic = LOG;
            this.willpower = WIL;
            this.init = REA + INT;
            this.currentInit = initiative;
            this.movement = new int[] { AGI*2, AGI*4 , 2};
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
        public int InitDice
        {
            get { return this.initDice; }
            set { this.initDice = value; }
        }
        public int CurrentInit
        {
            get { return this.currentInit; }
            set { this.currentInit = value; }
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
        public int[] Movement
        {
            get { return this.movement; }
            set { this.movement = value; }
        }
    }
}
