namespace SimcoxB_CharacterRoller
{
    partial class Character
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Character));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.grpCharacter = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpSpells = new System.Windows.Forms.GroupBox();
            this.lblSPD = new System.Windows.Forms.Label();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.radCleric = new System.Windows.Forms.RadioButton();
            this.radSorcerer = new System.Windows.Forms.RadioButton();
            this.radDruid = new System.Windows.Forms.RadioButton();
            this.radRanger = new System.Windows.Forms.RadioButton();
            this.radRogue = new System.Windows.Forms.RadioButton();
            this.radMage = new System.Windows.Forms.RadioButton();
            this.radFighter = new System.Windows.Forms.RadioButton();
            this.radPaladin = new System.Windows.Forms.RadioButton();
            this.grpHP = new System.Windows.Forms.GroupBox();
            this.lblMaxHp = new System.Windows.Forms.Label();
            this.lblCurHp = new System.Windows.Forms.Label();
            this.grpExp = new System.Windows.Forms.GroupBox();
            this.lblEXp = new System.Windows.Forms.Label();
            this.grpWealth = new System.Windows.Forms.GroupBox();
            this.lblGp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.grpRace = new System.Windows.Forms.GroupBox();
            this.radOrc = new System.Windows.Forms.RadioButton();
            this.radHalf = new System.Windows.Forms.RadioButton();
            this.radGnome = new System.Windows.Forms.RadioButton();
            this.radHalfling = new System.Windows.Forms.RadioButton();
            this.radDwarf = new System.Windows.Forms.RadioButton();
            this.radHuman = new System.Windows.Forms.RadioButton();
            this.radElf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboAlignment = new System.Windows.Forms.ComboBox();
            this.lblAlignment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbClass = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbBio = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.grpCharacter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSpells.SuspendLayout();
            this.grpClass.SuspendLayout();
            this.grpHP.SuspendLayout();
            this.grpExp.SuspendLayout();
            this.grpWealth.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.grpSex.SuspendLayout();
            this.grpRace.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save Character Sheet");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(98, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(73, 26);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.toolTip1.SetToolTip(this.btnLoad, "Load Character Sheet From Previous Session");
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(144, 160);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 26);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll Character";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SimcoxB_CharacterRoller.Properties.Resources.ddlogo;
            this.pictureBox1.Location = new System.Drawing.Point(162, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 124);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picCharacter
            // 
            this.picCharacter.Image = ((System.Drawing.Image)(resources.GetObject("picCharacter.Image")));
            this.picCharacter.Location = new System.Drawing.Point(6, 19);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(168, 186);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacter.TabIndex = 4;
            this.picCharacter.TabStop = false;
            // 
            // grpCharacter
            // 
            this.grpCharacter.BackColor = System.Drawing.Color.Transparent;
            this.grpCharacter.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.parchment;
            this.grpCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpCharacter.Controls.Add(this.groupBox1);
            this.grpCharacter.Controls.Add(this.grpSpells);
            this.grpCharacter.Controls.Add(this.grpClass);
            this.grpCharacter.Controls.Add(this.grpHP);
            this.grpCharacter.Controls.Add(this.grpExp);
            this.grpCharacter.Controls.Add(this.grpWealth);
            this.grpCharacter.Controls.Add(this.pnlStats);
            this.grpCharacter.Controls.Add(this.grpSex);
            this.grpCharacter.Controls.Add(this.grpRace);
            this.grpCharacter.Controls.Add(this.picCharacter);
            this.grpCharacter.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCharacter.ForeColor = System.Drawing.Color.DarkRed;
            this.grpCharacter.Location = new System.Drawing.Point(15, 177);
            this.grpCharacter.Name = "grpCharacter";
            this.grpCharacter.Size = new System.Drawing.Size(412, 671);
            this.grpCharacter.TabIndex = 5;
            this.grpCharacter.TabStop = false;
            this.grpCharacter.Text = "Character:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(7, 613);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 39);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // grpSpells
            // 
            this.grpSpells.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.grpSpells.Controls.Add(this.lblSPD);
            this.grpSpells.ForeColor = System.Drawing.Color.DarkRed;
            this.grpSpells.Location = new System.Drawing.Point(7, 552);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Size = new System.Drawing.Size(399, 55);
            this.grpSpells.TabIndex = 23;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells per Day";
            this.toolTip1.SetToolTip(this.grpSpells, "number of Spells per Day");
            // 
            // lblSPD
            // 
            this.lblSPD.AutoSize = true;
            this.lblSPD.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPD.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSPD.Location = new System.Drawing.Point(27, 23);
            this.lblSPD.Name = "lblSPD";
            this.lblSPD.Size = new System.Drawing.Size(172, 22);
            this.lblSPD.TabIndex = 12;
            this.lblSPD.Text = "Current Spells Per Day:";
            // 
            // grpClass
            // 
            this.grpClass.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.grpClass.Controls.Add(this.radCleric);
            this.grpClass.Controls.Add(this.radSorcerer);
            this.grpClass.Controls.Add(this.radDruid);
            this.grpClass.Controls.Add(this.radRanger);
            this.grpClass.Controls.Add(this.radRogue);
            this.grpClass.Controls.Add(this.radMage);
            this.grpClass.Controls.Add(this.radFighter);
            this.grpClass.Controls.Add(this.radPaladin);
            this.grpClass.ForeColor = System.Drawing.Color.DarkRed;
            this.grpClass.Location = new System.Drawing.Point(6, 372);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(400, 87);
            this.grpClass.TabIndex = 22;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Class:";
            this.toolTip1.SetToolTip(this.grpClass, "Choose Your Class");
            // 
            // radCleric
            // 
            this.radCleric.AutoSize = true;
            this.radCleric.Location = new System.Drawing.Point(259, 55);
            this.radCleric.Name = "radCleric";
            this.radCleric.Size = new System.Drawing.Size(68, 26);
            this.radCleric.TabIndex = 7;
            this.radCleric.TabStop = true;
            this.radCleric.Text = "Cleric";
            this.radCleric.UseVisualStyleBackColor = true;
            this.radCleric.CheckedChanged += new System.EventHandler(this.radCleric_CheckedChanged);
            // 
            // radSorcerer
            // 
            this.radSorcerer.AutoSize = true;
            this.radSorcerer.Location = new System.Drawing.Point(259, 29);
            this.radSorcerer.Name = "radSorcerer";
            this.radSorcerer.Size = new System.Drawing.Size(84, 26);
            this.radSorcerer.TabIndex = 6;
            this.radSorcerer.TabStop = true;
            this.radSorcerer.Text = "Sorcerer";
            this.radSorcerer.UseVisualStyleBackColor = true;
            this.radSorcerer.CheckedChanged += new System.EventHandler(this.radSorcerer_CheckedChanged);
            // 
            // radDruid
            // 
            this.radDruid.AutoSize = true;
            this.radDruid.Location = new System.Drawing.Point(184, 55);
            this.radDruid.Name = "radDruid";
            this.radDruid.Size = new System.Drawing.Size(69, 26);
            this.radDruid.TabIndex = 5;
            this.radDruid.TabStop = true;
            this.radDruid.Text = "Druid";
            this.radDruid.UseVisualStyleBackColor = true;
            this.radDruid.CheckedChanged += new System.EventHandler(this.radDruid_CheckedChanged);
            // 
            // radRanger
            // 
            this.radRanger.AutoSize = true;
            this.radRanger.Location = new System.Drawing.Point(184, 29);
            this.radRanger.Name = "radRanger";
            this.radRanger.Size = new System.Drawing.Size(77, 26);
            this.radRanger.TabIndex = 4;
            this.radRanger.TabStop = true;
            this.radRanger.Text = "Ranger";
            this.radRanger.UseVisualStyleBackColor = true;
            this.radRanger.CheckedChanged += new System.EventHandler(this.radRanger_CheckedChanged);
            // 
            // radRogue
            // 
            this.radRogue.AutoSize = true;
            this.radRogue.Location = new System.Drawing.Point(99, 55);
            this.radRogue.Name = "radRogue";
            this.radRogue.Size = new System.Drawing.Size(71, 26);
            this.radRogue.TabIndex = 3;
            this.radRogue.TabStop = true;
            this.radRogue.Text = "Rogue";
            this.radRogue.UseVisualStyleBackColor = true;
            this.radRogue.CheckedChanged += new System.EventHandler(this.radRogue_CheckedChanged);
            // 
            // radMage
            // 
            this.radMage.AutoSize = true;
            this.radMage.Location = new System.Drawing.Point(7, 55);
            this.radMage.Name = "radMage";
            this.radMage.Size = new System.Drawing.Size(67, 26);
            this.radMage.TabIndex = 2;
            this.radMage.TabStop = true;
            this.radMage.Text = "Mage";
            this.radMage.UseVisualStyleBackColor = true;
            this.radMage.CheckedChanged += new System.EventHandler(this.radMage_CheckedChanged);
            // 
            // radFighter
            // 
            this.radFighter.AutoSize = true;
            this.radFighter.Location = new System.Drawing.Point(85, 29);
            this.radFighter.Name = "radFighter";
            this.radFighter.Size = new System.Drawing.Size(79, 26);
            this.radFighter.TabIndex = 1;
            this.radFighter.TabStop = true;
            this.radFighter.Text = "Fighter";
            this.radFighter.UseVisualStyleBackColor = true;
            this.radFighter.CheckedChanged += new System.EventHandler(this.radFighter_CheckedChanged);
            // 
            // radPaladin
            // 
            this.radPaladin.AutoSize = true;
            this.radPaladin.Location = new System.Drawing.Point(7, 29);
            this.radPaladin.Name = "radPaladin";
            this.radPaladin.Size = new System.Drawing.Size(81, 26);
            this.radPaladin.TabIndex = 0;
            this.radPaladin.TabStop = true;
            this.radPaladin.Text = "Paladin";
            this.radPaladin.UseVisualStyleBackColor = true;
            this.radPaladin.CheckedChanged += new System.EventHandler(this.radPaladin_CheckedChanged);
            // 
            // grpHP
            // 
            this.grpHP.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.grpHP.Controls.Add(this.lblMaxHp);
            this.grpHP.Controls.Add(this.lblCurHp);
            this.grpHP.ForeColor = System.Drawing.Color.DarkRed;
            this.grpHP.Location = new System.Drawing.Point(7, 465);
            this.grpHP.Name = "grpHP";
            this.grpHP.Size = new System.Drawing.Size(399, 80);
            this.grpHP.TabIndex = 21;
            this.grpHP.TabStop = false;
            this.grpHP.Text = "Hit Points:";
            this.toolTip1.SetToolTip(this.grpHP, "Hit Points");
            // 
            // lblMaxHp
            // 
            this.lblMaxHp.AutoSize = true;
            this.lblMaxHp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHp.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMaxHp.Location = new System.Drawing.Point(173, 38);
            this.lblMaxHp.Name = "lblMaxHp";
            this.lblMaxHp.Size = new System.Drawing.Size(73, 22);
            this.lblMaxHp.TabIndex = 11;
            this.lblMaxHp.Text = "Max Hp:";
            // 
            // lblCurHp
            // 
            this.lblCurHp.AutoSize = true;
            this.lblCurHp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurHp.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCurHp.Location = new System.Drawing.Point(-1, 38);
            this.lblCurHp.Name = "lblCurHp";
            this.lblCurHp.Size = new System.Drawing.Size(93, 22);
            this.lblCurHp.TabIndex = 13;
            this.lblCurHp.Text = "Current Hp:";
            // 
            // grpExp
            // 
            this.grpExp.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.grpExp.Controls.Add(this.lblEXp);
            this.grpExp.ForeColor = System.Drawing.Color.DarkRed;
            this.grpExp.Location = new System.Drawing.Point(161, 314);
            this.grpExp.Name = "grpExp";
            this.grpExp.Size = new System.Drawing.Size(118, 52);
            this.grpExp.TabIndex = 20;
            this.grpExp.TabStop = false;
            this.grpExp.Text = "EXP:";
            this.toolTip1.SetToolTip(this.grpExp, "Box to Write Your Experience");
            // 
            // lblEXp
            // 
            this.lblEXp.AutoSize = true;
            this.lblEXp.Location = new System.Drawing.Point(7, 24);
            this.lblEXp.Name = "lblEXp";
            this.lblEXp.Size = new System.Drawing.Size(43, 22);
            this.lblEXp.TabIndex = 0;
            this.lblEXp.Text = "EXP";
            // 
            // grpWealth
            // 
            this.grpWealth.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.grpWealth.Controls.Add(this.lblGp);
            this.grpWealth.Controls.Add(this.label10);
            this.grpWealth.ForeColor = System.Drawing.Color.DarkRed;
            this.grpWealth.Location = new System.Drawing.Point(285, 314);
            this.grpWealth.Name = "grpWealth";
            this.grpWealth.Size = new System.Drawing.Size(121, 52);
            this.grpWealth.TabIndex = 19;
            this.grpWealth.TabStop = false;
            this.grpWealth.Text = "Money:";
            this.toolTip1.SetToolTip(this.grpWealth, "Box For Your Money");
            // 
            // lblGp
            // 
            this.lblGp.AutoSize = true;
            this.lblGp.Location = new System.Drawing.Point(6, 24);
            this.lblGp.Name = "lblGp";
            this.lblGp.Size = new System.Drawing.Size(30, 22);
            this.lblGp.TabIndex = 2;
            this.lblGp.Text = "Gp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "GP";
            // 
            // pnlStats
            // 
            this.pnlStats.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.pnlStats.Controls.Add(this.label8);
            this.pnlStats.Controls.Add(this.label7);
            this.pnlStats.Controls.Add(this.btnRoll);
            this.pnlStats.Controls.Add(this.lblStrength);
            this.pnlStats.Controls.Add(this.lblIntelligence);
            this.pnlStats.Controls.Add(this.lblCharisma);
            this.pnlStats.Controls.Add(this.lblWisdom);
            this.pnlStats.Controls.Add(this.lblConstitution);
            this.pnlStats.Controls.Add(this.lblDexterity);
            this.pnlStats.Location = new System.Drawing.Point(184, 19);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(222, 186);
            this.pnlStats.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Racial Mods";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stat Mods";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStrength.Location = new System.Drawing.Point(31, 18);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(74, 22);
            this.lblStrength.TabIndex = 5;
            this.lblStrength.Text = "Strength:";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIntelligence.Location = new System.Drawing.Point(10, 43);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(97, 22);
            this.lblIntelligence.TabIndex = 6;
            this.lblIntelligence.Text = "Intelligence:";
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharisma.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCharisma.Location = new System.Drawing.Point(27, 131);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(78, 22);
            this.lblCharisma.TabIndex = 10;
            this.lblCharisma.Text = "Charisma:";
            // 
            // lblWisdom
            // 
            this.lblWisdom.AutoSize = true;
            this.lblWisdom.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWisdom.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWisdom.Location = new System.Drawing.Point(34, 65);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(71, 22);
            this.lblWisdom.TabIndex = 7;
            this.lblWisdom.Text = "Wisdom:";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstitution.ForeColor = System.Drawing.Color.DarkRed;
            this.lblConstitution.Location = new System.Drawing.Point(3, 109);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(102, 22);
            this.lblConstitution.TabIndex = 9;
            this.lblConstitution.Text = "Constitution:";
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDexterity.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDexterity.Location = new System.Drawing.Point(23, 87);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(82, 22);
            this.lblDexterity.TabIndex = 8;
            this.lblDexterity.Text = "Dexterity:";
            // 
            // grpSex
            // 
            this.grpSex.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.grpSex.Controls.Add(this.radFemale);
            this.grpSex.Controls.Add(this.radMale);
            this.grpSex.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSex.ForeColor = System.Drawing.Color.DarkRed;
            this.grpSex.Location = new System.Drawing.Point(6, 313);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(149, 52);
            this.grpSex.TabIndex = 18;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Sex";
            this.toolTip1.SetToolTip(this.grpSex, "Pick Your Gender");
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.ForeColor = System.Drawing.Color.DarkRed;
            this.radFemale.Location = new System.Drawing.Point(69, 20);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(78, 26);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            this.radFemale.CheckedChanged += new System.EventHandler(this.radFemale_CheckedChanged);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.ForeColor = System.Drawing.Color.DarkRed;
            this.radMale.Location = new System.Drawing.Point(7, 20);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(64, 26);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radMale_CheckedChanged);
            // 
            // grpRace
            // 
            this.grpRace.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.grpRace.Controls.Add(this.radOrc);
            this.grpRace.Controls.Add(this.radHalf);
            this.grpRace.Controls.Add(this.radGnome);
            this.grpRace.Controls.Add(this.radHalfling);
            this.grpRace.Controls.Add(this.radDwarf);
            this.grpRace.Controls.Add(this.radHuman);
            this.grpRace.Controls.Add(this.radElf);
            this.grpRace.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRace.ForeColor = System.Drawing.Color.DarkRed;
            this.grpRace.Location = new System.Drawing.Point(6, 211);
            this.grpRace.Name = "grpRace";
            this.grpRace.Size = new System.Drawing.Size(400, 96);
            this.grpRace.TabIndex = 17;
            this.grpRace.TabStop = false;
            this.grpRace.Text = "Race";
            this.toolTip1.SetToolTip(this.grpRace, "Pick Your Race");
            // 
            // radOrc
            // 
            this.radOrc.AutoSize = true;
            this.radOrc.Location = new System.Drawing.Point(178, 56);
            this.radOrc.Name = "radOrc";
            this.radOrc.Size = new System.Drawing.Size(88, 26);
            this.radOrc.TabIndex = 20;
            this.radOrc.TabStop = true;
            this.radOrc.Text = "Half-Orc";
            this.radOrc.UseVisualStyleBackColor = true;
            this.radOrc.CheckedChanged += new System.EventHandler(this.radOrc_CheckedChanged);
            // 
            // radHalf
            // 
            this.radHalf.AutoSize = true;
            this.radHalf.Location = new System.Drawing.Point(85, 56);
            this.radHalf.Name = "radHalf";
            this.radHalf.Size = new System.Drawing.Size(86, 26);
            this.radHalf.TabIndex = 19;
            this.radHalf.TabStop = true;
            this.radHalf.Text = "Half-Elf";
            this.radHalf.UseVisualStyleBackColor = true;
            this.radHalf.CheckedChanged += new System.EventHandler(this.radHalf_CheckedChanged);
            // 
            // radGnome
            // 
            this.radGnome.AutoSize = true;
            this.radGnome.Location = new System.Drawing.Point(7, 56);
            this.radGnome.Name = "radGnome";
            this.radGnome.Size = new System.Drawing.Size(76, 26);
            this.radGnome.TabIndex = 18;
            this.radGnome.TabStop = true;
            this.radGnome.Text = "Gnome";
            this.radGnome.UseVisualStyleBackColor = true;
            this.radGnome.CheckedChanged += new System.EventHandler(this.radGnome_CheckedChanged);
            // 
            // radHalfling
            // 
            this.radHalfling.AutoSize = true;
            this.radHalfling.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHalfling.ForeColor = System.Drawing.Color.DarkRed;
            this.radHalfling.Location = new System.Drawing.Point(226, 19);
            this.radHalfling.Name = "radHalfling";
            this.radHalfling.Size = new System.Drawing.Size(86, 26);
            this.radHalfling.TabIndex = 17;
            this.radHalfling.TabStop = true;
            this.radHalfling.Text = "Halfling";
            this.radHalfling.UseVisualStyleBackColor = true;
            this.radHalfling.CheckedChanged += new System.EventHandler(this.radHalfling_CheckedChanged);
            // 
            // radDwarf
            // 
            this.radDwarf.AutoSize = true;
            this.radDwarf.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDwarf.ForeColor = System.Drawing.Color.DarkRed;
            this.radDwarf.Location = new System.Drawing.Point(6, 19);
            this.radDwarf.Name = "radDwarf";
            this.radDwarf.Size = new System.Drawing.Size(73, 26);
            this.radDwarf.TabIndex = 14;
            this.radDwarf.TabStop = true;
            this.radDwarf.Text = "Dwarf";
            this.radDwarf.UseVisualStyleBackColor = true;
            this.radDwarf.CheckedChanged += new System.EventHandler(this.radDwarf_CheckedChanged);
            // 
            // radHuman
            // 
            this.radHuman.AutoSize = true;
            this.radHuman.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHuman.ForeColor = System.Drawing.Color.DarkRed;
            this.radHuman.Location = new System.Drawing.Point(141, 19);
            this.radHuman.Name = "radHuman";
            this.radHuman.Size = new System.Drawing.Size(79, 26);
            this.radHuman.TabIndex = 16;
            this.radHuman.TabStop = true;
            this.radHuman.Text = "Human";
            this.radHuman.UseVisualStyleBackColor = true;
            this.radHuman.CheckedChanged += new System.EventHandler(this.radHuman_CheckedChanged);
            // 
            // radElf
            // 
            this.radElf.AutoSize = true;
            this.radElf.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radElf.ForeColor = System.Drawing.Color.DarkRed;
            this.radElf.Location = new System.Drawing.Point(85, 19);
            this.radElf.Name = "radElf";
            this.radElf.Size = new System.Drawing.Size(50, 26);
            this.radElf.TabIndex = 15;
            this.radElf.TabStop = true;
            this.radElf.Text = "Elf";
            this.radElf.UseVisualStyleBackColor = true;
            this.radElf.CheckedChanged += new System.EventHandler(this.radElf_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 851);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dungeons and Dragons, the logo, and the rules contained here in are copyrighted b" +
                "y  Wizards of The Coast Inc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 864);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Character Sheet program written by Blaine Simcox based from DandD rule sets for t" +
                "his assignment";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.groupBox2.Controls.Add(this.cboAlignment);
            this.groupBox2.Controls.Add(this.lblAlignment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCharName);
            this.groupBox2.Controls.Add(this.txtPlayer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(6, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 191);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Info:";
            // 
            // cboAlignment
            // 
            this.cboAlignment.FormattingEnabled = true;
            this.cboAlignment.Items.AddRange(new object[] {
            "Lawful Good",
            "Lawful Neutral",
            "Chaotic Good",
            "Lawful Neutral",
            "Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Neutral Evil",
            "Chaotic Evil"});
            this.cboAlignment.Location = new System.Drawing.Point(140, 98);
            this.cboAlignment.Name = "cboAlignment";
            this.cboAlignment.Size = new System.Drawing.Size(171, 30);
            this.cboAlignment.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboAlignment, "Choose Alignment(note some alignments not availble for certain clasess)");
            this.cboAlignment.SelectedIndexChanged += new System.EventHandler(this.cboAlignment_SelectedIndexChanged);
            // 
            // lblAlignment
            // 
            this.lblAlignment.AutoSize = true;
            this.lblAlignment.Location = new System.Drawing.Point(44, 101);
            this.lblAlignment.Name = "lblAlignment";
            this.lblAlignment.Size = new System.Drawing.Size(88, 22);
            this.lblAlignment.TabIndex = 4;
            this.lblAlignment.Text = "Alignment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Character Name:";
            // 
            // txtCharName
            // 
            this.txtCharName.Location = new System.Drawing.Point(140, 61);
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(171, 29);
            this.txtCharName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCharName, "Enter Character\'s Name");
            this.txtCharName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCharName_MouseClick);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(140, 26);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(171, 29);
            this.txtPlayer.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPlayer, "Enter Your Name");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.parchment;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.rtbClass);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rtbBio);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(433, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 671);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skills:";
            // 
            // rtbClass
            // 
            this.rtbClass.Location = new System.Drawing.Point(10, 418);
            this.rtbClass.Name = "rtbClass";
            this.rtbClass.ReadOnly = true;
            this.rtbClass.Size = new System.Drawing.Size(327, 247);
            this.rtbClass.TabIndex = 29;
            this.rtbClass.Text = "";
            this.toolTip1.SetToolTip(this.rtbClass, "Displays Class and Racial Abilities");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Class/Racial Abilities:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Character Bio:";
            // 
            // rtbBio
            // 
            this.rtbBio.ForeColor = System.Drawing.Color.DarkRed;
            this.rtbBio.Location = new System.Drawing.Point(6, 247);
            this.rtbBio.Name = "rtbBio";
            this.rtbBio.Size = new System.Drawing.Size(331, 143);
            this.rtbBio.TabIndex = 26;
            this.rtbBio.Text = "";
            this.toolTip1.SetToolTip(this.rtbBio, "Write Character Bio Here");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(199, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 36);
            this.label5.TabIndex = 27;
            this.label5.Text = "Quick Character Generation Program";
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SimcoxB_CharacterRoller.Properties.Resources.scroll;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 898);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCharacter);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(804, 936);
            this.MinimumSize = new System.Drawing.Size(804, 936);
            this.Name = "Character";
            this.Text = "Character Sheet";
            this.Load += new System.EventHandler(this.Character_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.grpCharacter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.grpHP.ResumeLayout(false);
            this.grpHP.PerformLayout();
            this.grpExp.ResumeLayout(false);
            this.grpExp.PerformLayout();
            this.grpWealth.ResumeLayout(false);
            this.grpWealth.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.grpRace.ResumeLayout(false);
            this.grpRace.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.GroupBox grpCharacter;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblCurHp;
        private System.Windows.Forms.Label lblSPD;
        private System.Windows.Forms.Label lblMaxHp;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox grpRace;
        private System.Windows.Forms.RadioButton radHalfling;
        private System.Windows.Forms.RadioButton radDwarf;
        private System.Windows.Forms.RadioButton radHuman;
        private System.Windows.Forms.RadioButton radElf;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.GroupBox grpExp;
        private System.Windows.Forms.GroupBox grpWealth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.RadioButton radRogue;
        private System.Windows.Forms.RadioButton radMage;
        private System.Windows.Forms.RadioButton radFighter;
        private System.Windows.Forms.RadioButton radPaladin;
        private System.Windows.Forms.Label lblEXp;
        private System.Windows.Forms.Label lblGp;
        private System.Windows.Forms.RadioButton radDruid;
        private System.Windows.Forms.RadioButton radRanger;
        private System.Windows.Forms.GroupBox grpSpells;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCharName;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAlignment;
        private System.Windows.Forms.Label lblAlignment;
        private System.Windows.Forms.RichTextBox rtbBio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radOrc;
        private System.Windows.Forms.RadioButton radHalf;
        private System.Windows.Forms.RadioButton radGnome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radCleric;
        private System.Windows.Forms.RadioButton radSorcerer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

