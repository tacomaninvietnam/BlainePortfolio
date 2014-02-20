/*Written by Blaine Simcox 4/25/2013 - 4/27/2013
         * CIT 195 Final Take-Home
         * Jeff Straw
         * using original algorithms
         * Dungeons & Dragons and all respective rules and materials used for this application Copyright Wizards of the Coast.
         */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace SimcoxB_CharacterRoller
{
    class save
    {
        public bool Paladin;
        public bool Fighter;
        public bool Rogue;
        public bool Sorcerer;
        public bool Cleric;
        public bool Mage;
        public bool Ranger;
        public bool Druid;


        public int Strength;
        public int Intelligence;
        public int Wisdom;
        public int Dexterity;
        public int Constitution;
        public int Charisma;

        public string PlayerClass;
        public string Sex;
        public string Race;
        public string Alignment;
        public string CharacterName;

        public int Exp;
        public int Gp;

        public int MaxHp;
        public int SpellsPerDay;
        public string CharacterBio;
        public string Player;

        public bool paladin
        {
            get { return Paladin; }
            set { Paladin = value; }
        }
        public bool fighter
        {
            get { return Fighter; }
            set { Fighter = value; }
        }
        public bool rogue
        {
            get { return Rogue; }
            set { Rogue = value; }
        }
        public bool sorcerer
        {
            get { return Sorcerer; }
            set { Sorcerer = value; }
        }
        public bool cleric
        {
            get { return Cleric; }
            set { Cleric = value; }
        }
        public bool mage
        {
            get { return Mage; }
            set { Mage = value; }
        }
        public bool ranger
        {
            get { return Ranger; }
            set { Ranger = value; }
        }
        public bool druid
        {
            get { return Druid; }
            set { Druid = value; }
        }


        public int strength
        {
            get { return Strength; }
            set { Strength = value; }
        }
        public int intelligence
        {
            get { return Intelligence; }
            set { Intelligence = value; }
        }
        public int wisdom
        {
            get { return Wisdom; }
            set { Wisdom = value; }
        }
        public int dexterity
        {
            get { return Dexterity; }
            set { Dexterity = value; }
        }
        public int constitution
        {
            get { return Constitution; }
            set { Constitution = value; }
        }
        public int charisma
        {
            get { return Charisma; }
            set { Charisma = value; }
        }


        public string sex
        {
            get { return Sex; }
            set { Sex = value; }
        }
        public string playerClass
        {
            get { return PlayerClass; }
            set { PlayerClass = value; }
        }
        public string race
        {
            get { return Race; }
            set { Race = value; }
        }
        public string alignment
        {
            get { return Alignment; }
            set { Alignment = value; }
        }
        public string characterName
        {
            get { return CharacterName; }
            set { CharacterName = value; }
        }

        public int exp
        {
            get { return Exp; }
            set { Exp = value; }
        }
        public int gp
        {
            get { return Gp; }
            set { Gp = value; }
        }

        public int maxHp
        {
            get { return MaxHp; }
            set { MaxHp = value; }
        }
        public int spellsPerDay
        {
            get { return SpellsPerDay; }
            set { SpellsPerDay = value; }
        }
        public string characterBio
        {
            get { return CharacterBio; }
            set { CharacterBio = value; }
        }
        public string player
        {
            get { return Player; }
            set { Player = value; }
        }

        public save(bool pal, bool fight, bool rog, bool sorc, bool clrc, bool mag, bool ran, bool drd, int str, int itt, int wis, int dex, int con, int chr, string pc, string sex, string race, string ali, string cn, int exp, int gp, int mhp, int spd, string bio, string player)
        {
            this.Paladin = pal;
            this.Fighter = fight;
            this.Rogue = rog;
            this.Sorcerer = sorc;
            this.Cleric = clrc;
            this.Mage = mag;
            this.Ranger = ran;
            this.Druid = drd;

            this.Strength = str;
            this.Intelligence = itt;
            this.Wisdom = wis;
            this.Dexterity = dex;
            this.Constitution = con;
            this.Charisma = chr;

            this.PlayerClass = pc;
            this.Sex = sex;
            this.Race = race;
            this.Alignment = ali;


            this.CharacterName = cn;
            this.Exp = exp;
            this.Gp = gp;
            this.MaxHp = mhp;
            this.SpellsPerDay = spd;
            this.CharacterBio = bio;
            this.Player = player;
        }
        public void foo()
        {
            MessageBox.Show("I'm working");
        }
    }
}
