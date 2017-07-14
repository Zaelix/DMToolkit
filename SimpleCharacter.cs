using System;

namespace DMToolkit
{
    public class SimpleCharacter
    {
        private string name;
        private int init;
        private int physDamage;
        private int stunDamage;
        private int physDamageMax;
        private int stunDamageMax;

        public SimpleCharacter(string charName, int initiative)
        {
            this.name = charName;
            this.init = initiative;
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
    }
}
