/*Written by Blaine Simcox 4/25/2013 - 4/27/2013
         * CIT 195 Final Take-Home
         * Jeff Straw
         * using original algorithms
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
    public partial class Character : Form
    {
        public Character()
        {
            InitializeComponent();
        }
        public string racialText = "";//a Whole lot of Variables to keep track of things
        public string classText = "";

        private int randIncrement = 0;

        public bool paladin = false;
        public bool fighter = false;
        public bool rogue = false;
        public bool sorcerer = false;
        public bool cleric = false;
        public bool mage = false;
        public bool ranger = false;
        public bool druid = false;
        public string player = "";

        public int strength = 0;
        public int intelligence = 0;
        public int wisdom = 0;
        public int dexterity = 0;
        public int constitution = 0;
        public int charisma = 0;

        public string playerClass = "";
        public string sex = "";
        public string race = "";
        public string alignment = "Neutral";
        public string characterName = "Enter A new Character";

        public int exp = 0;
        public int gp = 65;

        public int maxHp = 0;
        public int spellsPerDay = 0;
        public string characterBio = "";


        public int strengthMod = 0;
        public int intelligenceMod = 0;
        public int wisdomMod = 0;
        public int dexterityMod = 0;
        public int constitutionMod = 0;
        public int charismaMod = 0;

        public int adjustedStrength = 0;
        public int adjustedIntelligence = 0;
        public int adjustedWisdom = 0;
        public int adjustedDexterity = 0;
        public int adjustedConstitution = 0;
        public int adjustedCharisma = 0;

        


        public int racialStrengthMod = 0;
        public int racialIntelligenceMod = 0;
        public int racialWisdomMod = 0;
        public int racialDexterityMod = 0;
        public int racialConstitutionMod = 0;
        public int racialCharismaMod = 0;
        
        
        


        private void Character_Load(object sender, EventArgs e)//loads character Sheet
        {
            initializeText();
            cboAlignment.DropDownStyle = ComboBoxStyle.DropDownList;
            radDwarf.Checked = true;
            radMale.Checked = true;
            radPaladin.Checked = true;
            
        }

        private void initializeText()//concatenates the expressions for the whole Form
        {

            lblStrength.Text = "Strength: " + adjustedStrength + "    " + strengthMod + "    " + racialStrengthMod;
            lblIntelligence.Text = "Intelligence: " + adjustedIntelligence + "    " + intelligenceMod + "    " + racialIntelligenceMod;
            lblWisdom.Text = "Wisdom: " + adjustedWisdom + "    " + wisdomMod + "    " + racialWisdomMod;
            lblConstitution.Text = "Constitution: " + adjustedConstitution + "    " + constitutionMod + "    " + racialConstitutionMod;
            lblDexterity.Text = "Dexterity: " + adjustedDexterity + "    " + dexterityMod + "    " + racialDexterityMod;
            lblCharisma.Text = "Charisma: " + adjustedCharisma + "    " + charismaMod + "    " + racialCharismaMod;
            lblEXp.Text = Convert.ToString(exp);
            lblGp.Text = Convert.ToString(gp);
            lblMaxHp.Text = "Max Hp: " + maxHp;
            lblSPD.Text = "Spells Per Day: " + spellsPerDay;
            cboAlignment.Text = alignment;
            characterName = txtCharName.Text;
            player = txtPlayer.Text;
            characterBio = rtbBio.Text;
        }
        private int dice(int seed, int min, int max)//random number generator, seed to stop same number from being generated
        {
            Random random = new Random(seed);
            return random.Next(min, max);
            
        }
       
        private void txtCharName_MouseClick(object sender, MouseEventArgs e)//clears character textbox on click
        {
            if (txtCharName.Text != "")
            {
                txtCharName.Text = "";
                txtCharName.Focus();
            }
            else
                txtCharName.Focus();
        }

        private bool isNamePresent(TextBox text)//checks textboxes to make sure they are not empty
        {
            if (text.Text == "")
            {
                text.Focus();
                return false;
            }
            else
                return true;
        }
       
        #region StatisticsModificationMethods
 
        private void setRacialModifiers(int str, int intg, int wis, int dex, int con, int chr)//sets racial attribute modifiers
        {
            racialStrengthMod = str;
            racialIntelligenceMod = intg;
            racialWisdomMod = wis;
            racialDexterityMod = dex;
            racialConstitutionMod = con;
            racialCharismaMod = chr;
        }
        private int returnMod(int attribute)//case structure to get modifier after die is rolled for character stats
        {
            int modifier = 0;

            switch (attribute)
            {
                case 1:
                    modifier =  -5;
                    break;
                case 2:
                    modifier = -4;
                    break;
                case 3:
                    modifier = -4;
                    break;
                case 4:
                    modifier = -3;
                    break;
                case 5:
                    modifier = -3;
                    break;
                case 6:
                    modifier = -2;
                    break;
                case 7:
                    modifier = -2;
                    break;
                case 8:
                    modifier = -1;
                    break;
                case 9:
                    modifier = -1;
                    break;
                case 10:
                    modifier = 0;
                    break;
                case 11:
                    modifier = 0;
                    break;
                case 12:
                    modifier = 1;
                    break;
                case 13:
                    modifier = 1;
                    break;
                case 14:
                    modifier = 2;
                    break;
                case 15:
                    modifier = 2;
                    break;
                case 16:
                    modifier = 3;
                    break;
                case 17:
                    modifier = 3;
                    break;
                case 18:
                    modifier = 4;
                    break;
                case 19:
                    modifier = 4;
                    break;
                case 20:
                    modifier = 5;
                    break;
                case 21:
                    modifier = 5;
                    break;
                default:
                    break;

            }
            return modifier;
        }
        
        private void clearAdjustedStats()//clears all adjusted stats
        {
            adjustedStrength = 0;
            adjustedIntelligence = 0;
            adjustedWisdom = 0;
            adjustedDexterity = 0;
            adjustedConstitution = 0;
            adjustedCharisma = 0;
        }
        private void clearRacialModifiers()//clear racial mods
        {
            racialStrengthMod = 0;
            racialIntelligenceMod = 0;
            racialWisdomMod = 0;
            racialDexterityMod = 0;
            racialConstitutionMod = 0;
            racialCharismaMod = 0;
        }
        private void adjustedStats()// creates Adjusted Statistics by combining racial mods
        {
            clearAdjustedStats();
            adjustedStrength = strength + racialStrengthMod;
            adjustedIntelligence = intelligence + racialIntelligenceMod;
            adjustedWisdom = wisdom + racialWisdomMod;
            adjustedDexterity = dexterity + racialDexterityMod;
            adjustedConstitution = constitution + racialConstitutionMod;
            adjustedCharisma = charisma + racialCharismaMod;
        }

        
        #endregion

        #region RacialStats

        private void radDwarf_CheckedChanged(object sender, EventArgs e)//Next seven functions set racialMods set the text everywhere
        {
            racialText = "";
            clearRacialModifiers();
            setRacialModifiers(0, 0, 0, 0, +2, -2);
            race = "Dwarf";
            adjustedStats();
            initializeText();
            racialText = "Medium-size\nDarkvision 60ft. Black & White Only\n+2 On any Checks to Detect Stonework Traps\n+2 Saving Throw Against Poison and Spells\n+1 Against Orc and Goblinoids\n+4 Dodge Against Giants\n+2 Racial Bonus on Apprasise Checks\n\n";
            fillSkillsRacialAbilities();
            
        }

        private void radElf_CheckedChanged(object sender, EventArgs e)
        {
            racialText = "";
            clearRacialModifiers();
            setRacialModifiers(0, 0, 0, +2, -2, 0);
            race = "Elf";
            adjustedStats();
            initializeText();
            racialText = "Medium-size\nLow-Light Vision\n +2 Against Enchanments\nImmune to Sleep Spells\n+2 to Listen, Search, and Spot Checks\n\n";
            fillSkillsRacialAbilities();
        }

        private void radHuman_CheckedChanged(object sender, EventArgs e)
        {
            clearRacialModifiers();
            setRacialModifiers(0, 0, 0, 0, 0, 0);
            race = "Human";
            adjustedStats();
            initializeText();
            racialText = "Medium-sized\n4 Extra Skill Points on First Level\n1 Extra Skill Point per Level\n1Extra Feat at First Level\n\n";
            fillSkillsRacialAbilities();
        }

        private void radHalfling_CheckedChanged(object sender, EventArgs e)
        {
            clearRacialModifiers();
            setRacialModifiers(-2, 0, 0, +2, 0, 0);
            race = "Halfling";
            adjustedStats();
            initializeText();
            racialText = "Small +1 to AC and Attack Against Larger\n+4 Hide Checks\n+2 Climb and Listen Checks\n+2 Fear Checks\n+1 Thrown Weapons\n\n";
            fillSkillsRacialAbilities();
        }

        private void radGnome_CheckedChanged(object sender, EventArgs e)
        {
            clearRacialModifiers();
            setRacialModifiers(-2, 0, 0, 0, +2, 0);
            race = "Gnome";
            adjustedStats();
            initializeText();
            racialText = "Small +1 to AC and Attack Against Larger\n+4 Hide Checks\n+4 Dodge Against Giants\n+2 Alchemy and Listen Checks\nIf Intelligence is greater than 10\nGnome May Cast 0 Level Spells\nEach Once A Day\n\n";
            fillSkillsRacialAbilities();
        }

        private void radHalf_CheckedChanged(object sender, EventArgs e)
        {
            clearRacialModifiers();
            setRacialModifiers(0, 0, 0, 0, 0, 0);
            race = "Half-Elf";
            adjustedStats();
            initializeText();
            racialText = "Medium-Sized\nImmune To Sleep\nLow-Light Vision\n+1 Search, Spot, And Listen Checks\n\n";
            fillSkillsRacialAbilities();
        }

        private void radOrc_CheckedChanged(object sender, EventArgs e)
        {
            clearRacialModifiers();
            setRacialModifiers(+2, -2, 0, 0, 0, -2);
            race = "Half-Orc";
            adjustedStats();
            initializeText();
            racialText = "Medium-Sized\nCan Use All Orcish Weapons\nDarkvision 60ft.\n\n";
            fillSkillsRacialAbilities();
        }

        private void btnRoll_Click(object sender, EventArgs e)//the Primary algorithm for the character roller
        {

            strength = dice(1 + randIncrement, 3, 18);
            statMod(strength);
            strengthMod = returnMod(strength);
            randIncrement++;

            intelligence = dice(2 + randIncrement, 3, 18);
            statMod(intelligence);
            intelligenceMod = returnMod(intelligence);
            randIncrement++;

            wisdom = dice(2 + randIncrement, 3, 18);
            statMod(wisdom);
            wisdomMod = returnMod(wisdom);
            randIncrement++;

            dexterity = dice(3 + randIncrement, 3, 18);
            statMod(dexterity);
            dexterityMod = returnMod(dexterity);
            randIncrement++;

            constitution = dice(4 + randIncrement, 3, 18);
            statMod(constitution);
            constitutionMod = returnMod(constitution);
            randIncrement++;

            charisma = dice(5 + randIncrement, 3, 18);
            statMod(charisma);
            charismaMod = returnMod(charisma);
            randIncrement++;

            adjustedStats();
            initializeText();
        }
        private int statMod(int stat)//stops attribute from being <3 or >18
        {
            if (stat < 3)
                return stat = 3;
            else if (stat > 18)
                return stat = 18;
            else
                return stat;
        } 
        #endregion
        private void fillSkillsRacialAbilities()//method to fill the rtbSkills box
        {
            rtbClass.Text = "";
            rtbClass.Text = racialText + classText;
        }

        private void cboAlignment_SelectedIndexChanged(object sender, EventArgs e)//stops Paladins from being Lawful Good, Druids From Being Totally Neutral
        {
            if (radPaladin.Checked == true)
            {
                cboAlignment.Text = "Lawful Good";
            }
            else if (radDruid.Checked == true)
            {
                cboAlignment.Text = "Neutral";
            }
        }

        #region ClassStats

        private void clearClass()//clears Boolean Values For Load in
        {
            paladin = false;
            ranger = false;
            rogue = false;
            sorcerer = false;
            cleric = false;
            mage= false;
            fighter = false;
            druid= false;
        }
        private void radRogue_CheckedChanged(object sender, EventArgs e)//next 8 Methods are to fill Character Class Data
        {
            clearClass();
            rogue = true;
            playerClass = "Mage";
            classText = "";
            classText = "Weapons: Daggers, Darts, Crossbow, Mace,\nShortBow, and Shortsword\nArmor: Only Light Carries No Penalty\n\n+1d6 Sneak Attack form Lvl 1\nan additional 1d6 every two levels thereafter\nCan use Search for traps higher than Skill Level 20\nAt 3rd Level, Rogue Retains Dex bonus\nregardless of Being Caught Off Guard";
            fillSkillsRacialAbilities();
            maxHp = 6 + constitutionMod;
            initializeText();
        }

        private void radPaladin_CheckedChanged(object sender, EventArgs e)
        {
            clearClass();
            cboAlignment.Text = "Lawful Good";
            paladin = true;
            playerClass = "Paladin";
            classText = "";
            classText = "Weapons: All\nArmor: All\n\nAt Will: Detect Evil\nSaving Throws:  All Saving Throws +Charisma Mod\nOnce Per Day Heal Hp Equal to Level * Charisma Mod\nOr Deal Equal Damage to Undead\nImmune to All Diseases\nImmune to Fear 2nd Level\nOnce per Day, Smite Evil\nWeapon Dice + Level\nTurn Undead 2nd Level = 3 + Charisma Mod";
            fillSkillsRacialAbilities();
            maxHp = 10 + constitutionMod;
            initializeText();
        }

        private void radFighter_CheckedChanged(object sender, EventArgs e)
        {
            clearClass();
            fighter = true;
            playerClass = "Fighter";
            classText = "";
            classText = "Weapons: ALL\nArmor: All\n\nBonus Feat At 1st Level\nWeapon Specialization 4th Level +2 Damage With Chosen Weapon";
            fillSkillsRacialAbilities();
            maxHp = 10 + constitutionMod;
            initializeText();
        }

        private void radRanger_CheckedChanged(object sender, EventArgs e)
        {
            clearClass();
            ranger = true;
            playerClass = "Ranger";
            classText = "";
            classText = "Weapons: All\nArmor: Up to Medium\n\n4th Level or Higher With Wis 10+\nCan Cast A Small Number of Divine Spells\nRangers Get Track As A Bonus Feat\nStarting at 1st Level and Every fifth Level thereafter\nRanger Gets To Choose Favored Enemy\n+1 on All Bluff, Listen, Spot, Sense Motive\nor Wilderness Lore Checks and +1 Damage";
            fillSkillsRacialAbilities();
            maxHp = 10 + constitutionMod;
            initializeText();
        }

        private void radSorcerer_CheckedChanged(object sender, EventArgs e)
        {
            clearClass();
            sorcerer = true;
            playerClass = "Sorcerer";
            classText = "";
            classText = "Weapons: All Simple Weapons\nArmor: None\n\n1 New Spell Every Level\n1st level Spells Per Day Equal to Level Up to 6\n3 Second Level Spells at Level 4";
            fillSkillsRacialAbilities();
            maxHp = 4 + constitutionMod;
            spellsPerDay = 1;
            initializeText();
        }

        private void radMage_CheckedChanged(object sender, EventArgs e)
        {
            clearClass();
            mage = true;
            playerClass = "Mage";
            classText = "";
            classText = "Weapons: Club, Dagger, Crossbow, and Quarterstaff\nArmor: None\n\nSpells Per Day: 1 at 1st Level, 2 at 2nd,\n3 at 3rd + 1 2nd Level Spell";
            fillSkillsRacialAbilities();
            maxHp = 4 + constitutionMod;
            spellsPerDay = 1;
            initializeText();
        }

        private void radDruid_CheckedChanged(object sender, EventArgs e)
        {
            clearClass();
            cboAlignment.Text = "Neutral";
            druid = true;
            playerClass = "Druid";
            classText = "";
            classText = "Weapons: Club, Dagger, Dart, Halfspear, Longspear\nQuarterstaff, Scimitar, and Sling\nArmor: Padded, Leather, or Hide\n\nWoodland Stride:  At 2nd Level, Druid\nMay Move Unhindered and Without damage,\nThrough Woodland Brush and Thorns\nAt 3rd Level Druid Leaves No Tracks\n5th Level Gain Ability to assume Animal Form Once A Day";
            fillSkillsRacialAbilities();
            maxHp = 8 + constitutionMod;
            initializeText();
        }

        private void radCleric_CheckedChanged(object sender, EventArgs e)
        {
            clearClass();
            cleric = true;
            playerClass = "Cleric";
            classText = "";
            classText = "Weapons: All\nArmor: All\n\nSpells Per Day:1 + 1 Domain Spell,\n2 at 3, 3 at 5, 4 at 7\nCan Sacrifice A Prepped Spell to Healing Spell of Same Level\nCan't Cast Spells Against Cleric's Alignment\nTurn or Rebuke Undead 3 + Charisma Mod Per Day";
            fillSkillsRacialAbilities();
            maxHp = 8 + constitutionMod;
            initializeText();
        } 
        #endregion

        private void radFemale_CheckedChanged(object sender, EventArgs e)//sets the string value of sex, next function is just oposite button, same effect
        {
            if (radFemale.Checked == true)
            {
                sex = "Female";
            }
            else
                sex = "Male";
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked == true)
            {
                sex = "Female";
            }
            else
                sex = "Male";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNamePresent(txtCharName) && isNamePresent(txtPlayer)  && strength > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure You want to save this Character?", "Alert", MessageBoxButtons.OKCancel);//prompts user with confirmation window
                if (result == DialogResult.OK)
                {
                    save file = new save(paladin, fighter, rogue, sorcerer, cleric, mage, ranger, druid, strength, intelligence, wisdom, dexterity, constitution, charisma, playerClass, sex, race, alignment, characterName, exp, gp, maxHp, spellsPerDay, characterBio, player);
                    writeXml(file);//create new save object, write to xml
                }
            }
            else//exception handling
                MessageBox.Show("You must enter both a name for your character and yourself!", "Error");
        }

        private void writeXml(save file)//write algorithm 
        {
            XmlWriterSettings settings = new XmlWriterSettings();//defines indetation of elements and nodes inside of element
            settings.Indent = true;
            settings.IndentChars = "    ";


            using (XmlWriter writer = XmlWriter.Create(@"..\..\xml\" + characterName + ".xml", settings))//create new instance of Xml writer class to write to relative path
            {
                writer.WriteStartDocument();//starts the XML
                writer.WriteStartElement("Character");//Adds Header Element

                writer.WriteStartElement("Character"); //Start new Employee Element

                    writer.WriteElementString("PlayerName", file.Player);//output to Xml
                    writer.WriteElementString("CharacterName", file.CharacterName);//output to Xml

                    writer.WriteElementString("Druid", file.Druid.ToString());//output to Xml
                    writer.WriteElementString("Mage", file.Mage.ToString());//output to Xml
                    writer.WriteElementString("Sorcerer", file.Sorcerer.ToString());//output to Xml
                    writer.WriteElementString("Paladin", file.Paladin.ToString());//output to Xml
                    writer.WriteElementString("Fighter", file.Fighter.ToString());//output to Xml
                    writer.WriteElementString("Ranger", file.Ranger.ToString());//output to Xml
                    writer.WriteElementString("Cleric", file.Cleric.ToString());//output to Xml
                    writer.WriteElementString("Rogue", file.Rogue.ToString());//output to Xml

                    writer.WriteElementString("Strength", file.Strength.ToString());//output to Xml
                    writer.WriteElementString("Intelligence", file.Intelligence.ToString());//output to Xml
                    writer.WriteElementString("Wisdom", file.Wisdom.ToString());//output to Xml
                    writer.WriteElementString("Dexterity", file.Dexterity.ToString());//output to Xml
                    writer.WriteElementString("Constitution", file.Constitution.ToString());//output to Xml
                    writer.WriteElementString("Charisma", file.Charisma.ToString());//output to Xml


                    writer.WriteElementString("PlayerClass", file.PlayerClass.ToString());//output to Xml
                    writer.WriteElementString("Sex", file.Sex.ToString());//output to Xml
                    writer.WriteElementString("Race", file.Race.ToString());//output to Xml
                    writer.WriteElementString("Alignment", file.Alignment.ToString());//output to Xml

                    writer.WriteElementString("Exp", file.Exp.ToString());//output to Xml
                    writer.WriteElementString("Gp", file.Gp.ToString());//output to Xml
                    writer.WriteElementString("MaxHp", file.MaxHp.ToString());//output to Xml
                    writer.WriteElementString("SpellsPerDay", file.SpellsPerDay.ToString());//output to Xml

                    writer.WriteElementString("CharacterBio", file.CharacterBio.ToString());//output to Xml


                    writer.WriteEndElement();//end Employee element
                    
                

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }//finish using instance of Xml Writer 
        }

        /*Written by Blaine Simcox 4/25/2013 - 4/27/2013
         * CIT 195 Final Take-Home
         * Jeff Straw
         * using original algorithms
         */
    }
}
