namespace TeamProjectPhase1
{
    partial class PizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrder));
            this.grpMeat = new System.Windows.Forms.GroupBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkArtichokes = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkAnch = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkCapricola = new System.Windows.Forms.CheckBox();
            this.grpVeggies = new System.Windows.Forms.GroupBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkKalamata = new System.Windows.Forms.CheckBox();
            this.chkBlack = new System.Windows.Forms.CheckBox();
            this.chkBanana = new System.Windows.Forms.CheckBox();
            this.chkScallions = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkBell = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radExtra = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radPersonal = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rtbPrice = new System.Windows.Forms.RichTextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpMeat.SuspendLayout();
            this.grpVeggies.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMeat
            // 
            this.grpMeat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpMeat.Controls.Add(this.chkPineapple);
            this.grpMeat.Controls.Add(this.chkArtichokes);
            this.grpMeat.Controls.Add(this.chkCheese);
            this.grpMeat.Controls.Add(this.chkChicken);
            this.grpMeat.Controls.Add(this.chkBacon);
            this.grpMeat.Controls.Add(this.chkSausage);
            this.grpMeat.Controls.Add(this.chkAnch);
            this.grpMeat.Controls.Add(this.chkPepperoni);
            this.grpMeat.Controls.Add(this.chkHam);
            this.grpMeat.Controls.Add(this.chkCapricola);
            this.grpMeat.ForeColor = System.Drawing.Color.White;
            this.grpMeat.Location = new System.Drawing.Point(31, 75);
            this.grpMeat.Name = "grpMeat";
            this.grpMeat.Size = new System.Drawing.Size(115, 265);
            this.grpMeat.TabIndex = 0;
            this.grpMeat.TabStop = false;
            this.grpMeat.Text = "Meats";
            this.toolTip1.SetToolTip(this.grpMeat, "Pick Your Meats");
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(7, 235);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(73, 17);
            this.chkPineapple.TabIndex = 9;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkArtichokes
            // 
            this.chkArtichokes.AutoSize = true;
            this.chkArtichokes.Location = new System.Drawing.Point(7, 211);
            this.chkArtichokes.Name = "chkArtichokes";
            this.chkArtichokes.Size = new System.Drawing.Size(76, 17);
            this.chkArtichokes.TabIndex = 8;
            this.chkArtichokes.Text = "Artichokes";
            this.chkArtichokes.UseVisualStyleBackColor = true;
            this.chkArtichokes.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.BackColor = System.Drawing.Color.Transparent;
            this.chkCheese.Location = new System.Drawing.Point(7, 187);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(89, 17);
            this.chkCheese.TabIndex = 7;
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = false;
            this.chkCheese.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.BackColor = System.Drawing.Color.Transparent;
            this.chkChicken.ForeColor = System.Drawing.Color.White;
            this.chkChicken.Location = new System.Drawing.Point(7, 164);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(108, 17);
            this.chkChicken.TabIndex = 6;
            this.chkChicken.Text = "Roasted Chicken";
            this.chkChicken.UseVisualStyleBackColor = false;
            this.chkChicken.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.BackColor = System.Drawing.Color.Transparent;
            this.chkBacon.ForeColor = System.Drawing.Color.White;
            this.chkBacon.Location = new System.Drawing.Point(7, 140);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 5;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = false;
            this.chkBacon.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.BackColor = System.Drawing.Color.Transparent;
            this.chkSausage.ForeColor = System.Drawing.Color.White;
            this.chkSausage.Location = new System.Drawing.Point(7, 116);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(99, 17);
            this.chkSausage.TabIndex = 4;
            this.chkSausage.Text = "Italian Sausage";
            this.chkSausage.UseVisualStyleBackColor = false;
            this.chkSausage.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkAnch
            // 
            this.chkAnch.AutoSize = true;
            this.chkAnch.BackColor = System.Drawing.Color.Transparent;
            this.chkAnch.ForeColor = System.Drawing.Color.White;
            this.chkAnch.Location = new System.Drawing.Point(7, 92);
            this.chkAnch.Name = "chkAnch";
            this.chkAnch.Size = new System.Drawing.Size(76, 17);
            this.chkAnch.TabIndex = 3;
            this.chkAnch.Text = "Anchovies";
            this.chkAnch.UseVisualStyleBackColor = false;
            this.chkAnch.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.BackColor = System.Drawing.Color.Transparent;
            this.chkPepperoni.ForeColor = System.Drawing.Color.White;
            this.chkPepperoni.Location = new System.Drawing.Point(7, 68);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = false;
            this.chkPepperoni.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.BackColor = System.Drawing.Color.Transparent;
            this.chkHam.ForeColor = System.Drawing.Color.White;
            this.chkHam.Location = new System.Drawing.Point(7, 44);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(48, 17);
            this.chkHam.TabIndex = 1;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = false;
            this.chkHam.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkCapricola
            // 
            this.chkCapricola.AutoSize = true;
            this.chkCapricola.BackColor = System.Drawing.Color.Transparent;
            this.chkCapricola.ForeColor = System.Drawing.Color.White;
            this.chkCapricola.Location = new System.Drawing.Point(7, 20);
            this.chkCapricola.Name = "chkCapricola";
            this.chkCapricola.Size = new System.Drawing.Size(70, 17);
            this.chkCapricola.TabIndex = 0;
            this.chkCapricola.Text = "Capricola";
            this.chkCapricola.UseVisualStyleBackColor = false;
            this.chkCapricola.CheckedChanged += new System.EventHandler(this.anyCheckChanged);
            this.chkCapricola.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // grpVeggies
            // 
            this.grpVeggies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpVeggies.Controls.Add(this.chkTomato);
            this.grpVeggies.Controls.Add(this.chkKalamata);
            this.grpVeggies.Controls.Add(this.chkBlack);
            this.grpVeggies.Controls.Add(this.chkBanana);
            this.grpVeggies.Controls.Add(this.chkScallions);
            this.grpVeggies.Controls.Add(this.chkMushroom);
            this.grpVeggies.Controls.Add(this.chkBell);
            this.grpVeggies.Controls.Add(this.chkOnion);
            this.grpVeggies.ForeColor = System.Drawing.Color.White;
            this.grpVeggies.Location = new System.Drawing.Point(30, 346);
            this.grpVeggies.Name = "grpVeggies";
            this.grpVeggies.Size = new System.Drawing.Size(116, 215);
            this.grpVeggies.TabIndex = 1;
            this.grpVeggies.TabStop = false;
            this.grpVeggies.Text = "Veggies";
            this.toolTip1.SetToolTip(this.grpVeggies, "Pick Your Vegtables");
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.BackColor = System.Drawing.Color.Transparent;
            this.chkTomato.ForeColor = System.Drawing.Color.White;
            this.chkTomato.Location = new System.Drawing.Point(7, 188);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(73, 17);
            this.chkTomato.TabIndex = 7;
            this.chkTomato.Text = "Tomatoes";
            this.chkTomato.UseVisualStyleBackColor = false;
            this.chkTomato.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkKalamata
            // 
            this.chkKalamata.AutoSize = true;
            this.chkKalamata.BackColor = System.Drawing.Color.Transparent;
            this.chkKalamata.ForeColor = System.Drawing.Color.White;
            this.chkKalamata.Location = new System.Drawing.Point(7, 164);
            this.chkKalamata.Name = "chkKalamata";
            this.chkKalamata.Size = new System.Drawing.Size(102, 17);
            this.chkKalamata.TabIndex = 6;
            this.chkKalamata.Text = "Kalamata Olives";
            this.chkKalamata.UseVisualStyleBackColor = false;
            this.chkKalamata.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkBlack
            // 
            this.chkBlack.AutoSize = true;
            this.chkBlack.BackColor = System.Drawing.Color.Transparent;
            this.chkBlack.ForeColor = System.Drawing.Color.White;
            this.chkBlack.Location = new System.Drawing.Point(7, 140);
            this.chkBlack.Name = "chkBlack";
            this.chkBlack.Size = new System.Drawing.Size(85, 17);
            this.chkBlack.TabIndex = 5;
            this.chkBlack.Text = "Black Olives";
            this.chkBlack.UseVisualStyleBackColor = false;
            this.chkBlack.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkBanana
            // 
            this.chkBanana.AutoSize = true;
            this.chkBanana.BackColor = System.Drawing.Color.Transparent;
            this.chkBanana.ForeColor = System.Drawing.Color.White;
            this.chkBanana.Location = new System.Drawing.Point(7, 116);
            this.chkBanana.Name = "chkBanana";
            this.chkBanana.Size = new System.Drawing.Size(105, 17);
            this.chkBanana.TabIndex = 4;
            this.chkBanana.Text = "Banana Peppers";
            this.chkBanana.UseVisualStyleBackColor = false;
            this.chkBanana.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkScallions
            // 
            this.chkScallions.AutoSize = true;
            this.chkScallions.BackColor = System.Drawing.Color.Transparent;
            this.chkScallions.ForeColor = System.Drawing.Color.White;
            this.chkScallions.Location = new System.Drawing.Point(7, 92);
            this.chkScallions.Name = "chkScallions";
            this.chkScallions.Size = new System.Drawing.Size(68, 17);
            this.chkScallions.TabIndex = 3;
            this.chkScallions.Text = "Scallions";
            this.chkScallions.UseVisualStyleBackColor = false;
            this.chkScallions.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.BackColor = System.Drawing.Color.Transparent;
            this.chkMushroom.ForeColor = System.Drawing.Color.White;
            this.chkMushroom.Location = new System.Drawing.Point(7, 68);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(75, 17);
            this.chkMushroom.TabIndex = 2;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = false;
            this.chkMushroom.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkBell
            // 
            this.chkBell.AutoSize = true;
            this.chkBell.BackColor = System.Drawing.Color.Transparent;
            this.chkBell.ForeColor = System.Drawing.Color.White;
            this.chkBell.Location = new System.Drawing.Point(7, 44);
            this.chkBell.Name = "chkBell";
            this.chkBell.Size = new System.Drawing.Size(80, 17);
            this.chkBell.TabIndex = 1;
            this.chkBell.Text = "Bell Pepper";
            this.chkBell.UseVisualStyleBackColor = false;
            this.chkBell.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.Transparent;
            this.chkOnion.ForeColor = System.Drawing.Color.White;
            this.chkOnion.Location = new System.Drawing.Point(7, 20);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 0;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.Click += new System.EventHandler(this.anyCheckChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Location = new System.Drawing.Point(168, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, "Enter Quantity");
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(10, 51);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(22, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity:";
            this.toolTip1.SetToolTip(this.lblQuantity, "Enter a Quantity");
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(316, 469);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 44);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Submit Order");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnCancel, "Return to Home Page");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.radExtra);
            this.groupBox2.Controls.Add(this.radLarge);
            this.groupBox2.Controls.Add(this.radMedium);
            this.groupBox2.Controls.Add(this.radPersonal);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(168, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            this.toolTip1.SetToolTip(this.groupBox2, "Choose Your Size");
            // 
            // radExtra
            // 
            this.radExtra.AutoSize = true;
            this.radExtra.BackColor = System.Drawing.Color.Transparent;
            this.radExtra.Location = new System.Drawing.Point(7, 91);
            this.radExtra.Name = "radExtra";
            this.radExtra.Size = new System.Drawing.Size(79, 17);
            this.radExtra.TabIndex = 3;
            this.radExtra.TabStop = true;
            this.radExtra.Text = "Extra Large";
            this.radExtra.UseVisualStyleBackColor = false;
            this.radExtra.CheckedChanged += new System.EventHandler(this.radExtra_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.BackColor = System.Drawing.Color.Transparent;
            this.radLarge.Location = new System.Drawing.Point(7, 67);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = false;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.BackColor = System.Drawing.Color.Transparent;
            this.radMedium.Location = new System.Drawing.Point(7, 43);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = false;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radPersonal
            // 
            this.radPersonal.AutoSize = true;
            this.radPersonal.BackColor = System.Drawing.Color.Transparent;
            this.radPersonal.Location = new System.Drawing.Point(7, 19);
            this.radPersonal.Name = "radPersonal";
            this.radPersonal.Size = new System.Drawing.Size(66, 17);
            this.radPersonal.TabIndex = 0;
            this.radPersonal.TabStop = true;
            this.radPersonal.Text = "Personal";
            this.radPersonal.UseVisualStyleBackColor = false;
            this.radPersonal.CheckedChanged += new System.EventHandler(this.radPersonal_CheckedChanged);
            // 
            // rtbPrice
            // 
            this.rtbPrice.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbPrice.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPrice.ForeColor = System.Drawing.Color.White;
            this.rtbPrice.Location = new System.Drawing.Point(168, 230);
            this.rtbPrice.Name = "rtbPrice";
            this.rtbPrice.ReadOnly = true;
            this.rtbPrice.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbPrice.Size = new System.Drawing.Size(283, 225);
            this.rtbPrice.TabIndex = 9;
            this.rtbPrice.Text = resources.GetString("rtbPrice.Text");
            this.toolTip1.SetToolTip(this.rtbPrice, "Pricing Info");
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(334, 107);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(117, 20);
            this.txtSub.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Custom Pizza Price:";
            // 
            // txtToppings
            // 
            this.txtToppings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppings.ForeColor = System.Drawing.Color.White;
            this.txtToppings.Location = new System.Drawing.Point(280, 181);
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.ReadOnly = true;
            this.txtToppings.Size = new System.Drawing.Size(171, 26);
            this.txtToppings.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chosen Toppings:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TeamProjectPhase1.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 63);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::TeamProjectPhase1.Properties.Resources.th_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToppings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.rtbPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpVeggies);
            this.Controls.Add(this.grpMeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order Form";
            this.grpMeat.ResumeLayout(false);
            this.grpMeat.PerformLayout();
            this.grpVeggies.ResumeLayout(false);
            this.grpVeggies.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMeat;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkAnch;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkCapricola;
        private System.Windows.Forms.GroupBox grpVeggies;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkKalamata;
        private System.Windows.Forms.CheckBox chkBlack;
        private System.Windows.Forms.CheckBox chkBanana;
        private System.Windows.Forms.CheckBox chkScallions;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkBell;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radExtra;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radPersonal;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox rtbPrice;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkArtichokes;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

