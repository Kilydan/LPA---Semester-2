namespace RPGClicker
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numCharacterAge = new System.Windows.Forms.NumericUpDown();
            this.tbCharacterName = new System.Windows.Forms.TextBox();
            this.cbCharacterClass = new System.Windows.Forms.ComboBox();
            this.pbCharSelect = new System.Windows.Forms.PictureBox();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.CheckAdmin = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ClickerTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBuyUpgrade = new System.Windows.Forms.Button();
            this.lbUpgrade = new System.Windows.Forms.ListBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.lEnemyHealth = new System.Windows.Forms.Label();
            this.lEnemyName = new System.Windows.Forms.Label();
            this.lClickDamage = new System.Windows.Forms.Label();
            this.lHealAmount = new System.Windows.Forms.Label();
            this.pbHeal = new System.Windows.Forms.PictureBox();
            this.pbClickDmg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbCharacterInfo = new System.Windows.Forms.ListBox();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgressBarSpecialAbility = new System.Windows.Forms.ProgressBar();
            this.progressBarEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.btnSpecialAbility = new System.Windows.Forms.Button();
            this.lProgressBar = new System.Windows.Forms.Label();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnequipedAll = new System.Windows.Forms.Button();
            this.cbEquipedItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNotEquipedItem = new System.Windows.Forms.ComboBox();
            this.btnUnequipItem = new System.Windows.Forms.Button();
            this.btnEquipItem1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSellItem = new System.Windows.Forms.Button();
            this.btnEquipItem2 = new System.Windows.Forms.Button();
            this.btnEquipItem3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lItemSlot3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lItemSlot2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lItemSlot1 = new System.Windows.Forms.Label();
            this.MobCreateTab = new System.Windows.Forms.TabPage();
            this.MobCreatorTab = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numMCHealth = new System.Windows.Forms.NumericUpDown();
            this.numMCDamage = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxBossYN = new System.Windows.Forms.CheckBox();
            this.NumMCTimer = new System.Windows.Forms.NumericUpDown();
            this.pbMobCreatorImage = new System.Windows.Forms.PictureBox();
            this.btnCreateMob = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbMCName = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharacterAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharSelect)).BeginInit();
            this.ClickerTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.InventoryTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MobCreateTab.SuspendLayout();
            this.MobCreatorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMCHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMCDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMCTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMobCreatorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.HomeTab);
            this.TabControl.Controls.Add(this.ClickerTab);
            this.TabControl.Controls.Add(this.InventoryTab);
            this.TabControl.Controls.Add(this.MobCreateTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(673, 550);
            this.TabControl.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.tableLayoutPanel3);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeTab.Size = new System.Drawing.Size(665, 524);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.numCharacterAge, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tbCharacterName, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbCharacterClass, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.pbCharSelect, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCreateCharacter, 3, 10);
            this.tableLayoutPanel3.Controls.Add(this.CheckAdmin, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label19, 1, 8);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(661, 520);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(68, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Character class:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(68, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Character name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(68, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Character age:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numCharacterAge
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.numCharacterAge, 3);
            this.numCharacterAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCharacterAge.Location = new System.Drawing.Point(68, 210);
            this.numCharacterAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCharacterAge.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numCharacterAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCharacterAge.Name = "numCharacterAge";
            this.numCharacterAge.Size = new System.Drawing.Size(161, 20);
            this.numCharacterAge.TabIndex = 3;
            this.numCharacterAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbCharacterName
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.tbCharacterName, 3);
            this.tbCharacterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCharacterName.Location = new System.Drawing.Point(68, 132);
            this.tbCharacterName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCharacterName.Name = "tbCharacterName";
            this.tbCharacterName.Size = new System.Drawing.Size(161, 20);
            this.tbCharacterName.TabIndex = 4;
            // 
            // cbCharacterClass
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbCharacterClass, 3);
            this.cbCharacterClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharacterClass.FormattingEnabled = true;
            this.cbCharacterClass.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Summoner"});
            this.cbCharacterClass.Location = new System.Drawing.Point(68, 54);
            this.cbCharacterClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCharacterClass.Name = "cbCharacterClass";
            this.cbCharacterClass.Size = new System.Drawing.Size(161, 21);
            this.cbCharacterClass.TabIndex = 5;
            this.cbCharacterClass.SelectedIndexChanged += new System.EventHandler(this.cbCharacterClass_SelectedIndexChanged);
            // 
            // pbCharSelect
            // 
            this.pbCharSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCharSelect.Image = global::RPGClicker.Properties.Resources.Mage;
            this.pbCharSelect.Location = new System.Drawing.Point(299, 28);
            this.pbCharSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCharSelect.Name = "pbCharSelect";
            this.tableLayoutPanel3.SetRowSpan(this.pbCharSelect, 6);
            this.pbCharSelect.Size = new System.Drawing.Size(194, 230);
            this.pbCharSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCharSelect.TabIndex = 6;
            this.pbCharSelect.TabStop = false;
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateCharacter.Location = new System.Drawing.Point(167, 340);
            this.btnCreateCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(62, 48);
            this.btnCreateCharacter.TabIndex = 8;
            this.btnCreateCharacter.Text = "Create";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // CheckAdmin
            // 
            this.CheckAdmin.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.CheckAdmin, 3);
            this.CheckAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckAdmin.Location = new System.Drawing.Point(68, 314);
            this.CheckAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckAdmin.Name = "CheckAdmin";
            this.CheckAdmin.Size = new System.Drawing.Size(161, 22);
            this.CheckAdmin.TabIndex = 9;
            this.CheckAdmin.Text = "Yes";
            this.CheckAdmin.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label19, 2);
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(68, 286);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 26);
            this.label19.TabIndex = 10;
            this.label19.Text = "Admin:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ClickerTab
            // 
            this.ClickerTab.Controls.Add(this.tableLayoutPanel1);
            this.ClickerTab.Location = new System.Drawing.Point(4, 22);
            this.ClickerTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClickerTab.Name = "ClickerTab";
            this.ClickerTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClickerTab.Size = new System.Drawing.Size(665, 524);
            this.ClickerTab.TabIndex = 1;
            this.ClickerTab.Text = "Clicker";
            this.ClickerTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBuyUpgrade, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbUpgrade, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbEnemy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lEnemyHealth, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lEnemyName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lClickDamage, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lHealAmount, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.pbHeal, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbClickDmg, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbCharacterInfo, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.pbCharacter, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbLog, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProgressBarSpecialAbility, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.progressBarEnemyHealth, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSpecialAbility, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lProgressBar, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(381, 260);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "HP";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnBuyUpgrade
            // 
            this.btnBuyUpgrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuyUpgrade.Location = new System.Drawing.Point(68, 470);
            this.btnBuyUpgrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuyUpgrade.Name = "btnBuyUpgrade";
            this.btnBuyUpgrade.Size = new System.Drawing.Size(62, 22);
            this.btnBuyUpgrade.TabIndex = 0;
            this.btnBuyUpgrade.Text = "Buy";
            this.btnBuyUpgrade.UseVisualStyleBackColor = true;
            this.btnBuyUpgrade.Click += new System.EventHandler(this.btnBuyUpgrade_Click);
            // 
            // lbUpgrade
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbUpgrade, 2);
            this.lbUpgrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpgrade.FormattingEnabled = true;
            this.lbUpgrade.Location = new System.Drawing.Point(2, 28);
            this.lbUpgrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbUpgrade.Name = "lbUpgrade";
            this.tableLayoutPanel1.SetRowSpan(this.lbUpgrade, 8);
            this.lbUpgrade.Size = new System.Drawing.Size(128, 438);
            this.lbUpgrade.TabIndex = 1;
            // 
            // pbEnemy
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbEnemy, 3);
            this.pbEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEnemy.Image = global::RPGClicker.Properties.Resources.shar;
            this.pbEnemy.Location = new System.Drawing.Point(216, 28);
            this.pbEnemy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(227, 230);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemy.TabIndex = 2;
            this.pbEnemy.TabStop = false;
            // 
            // lEnemyHealth
            // 
            this.lEnemyHealth.AutoSize = true;
            this.lEnemyHealth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lEnemyHealth.Location = new System.Drawing.Point(282, 273);
            this.lEnemyHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEnemyHealth.Name = "lEnemyHealth";
            this.lEnemyHealth.Size = new System.Drawing.Size(95, 13);
            this.lEnemyHealth.TabIndex = 3;
            this.lEnemyHealth.Text = "Enemy Health";
            this.lEnemyHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lEnemyName
            // 
            this.lEnemyName.AutoSize = true;
            this.lEnemyName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lEnemyName.Location = new System.Drawing.Point(282, 13);
            this.lEnemyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEnemyName.Name = "lEnemyName";
            this.lEnemyName.Size = new System.Drawing.Size(95, 13);
            this.lEnemyName.TabIndex = 4;
            this.lEnemyName.Text = "<Enemy Name>";
            this.lEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lClickDamage
            // 
            this.lClickDamage.AutoSize = true;
            this.lClickDamage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lClickDamage.Location = new System.Drawing.Point(134, 390);
            this.lClickDamage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lClickDamage.Name = "lClickDamage";
            this.lClickDamage.Size = new System.Drawing.Size(78, 13);
            this.lClickDamage.TabIndex = 5;
            this.lClickDamage.Text = "<Dmg Val>";
            this.lClickDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lHealAmount
            // 
            this.lHealAmount.AutoSize = true;
            this.lHealAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lHealAmount.Location = new System.Drawing.Point(447, 390);
            this.lHealAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lHealAmount.Name = "lHealAmount";
            this.lHealAmount.Size = new System.Drawing.Size(78, 13);
            this.lHealAmount.TabIndex = 6;
            this.lHealAmount.Text = "<Heal Value>";
            this.lHealAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbHeal
            // 
            this.pbHeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHeal.Image = global::RPGClicker.Properties.Resources.healthpot;
            this.pbHeal.Location = new System.Drawing.Point(447, 288);
            this.pbHeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbHeal.Name = "pbHeal";
            this.tableLayoutPanel1.SetRowSpan(this.pbHeal, 3);
            this.pbHeal.Size = new System.Drawing.Size(78, 100);
            this.pbHeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeal.TabIndex = 7;
            this.pbHeal.TabStop = false;
            this.pbHeal.Click += new System.EventHandler(this.pbHeal_Click);
            // 
            // pbClickDmg
            // 
            this.pbClickDmg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbClickDmg.Image = global::RPGClicker.Properties.Resources.DamageIcon;
            this.pbClickDmg.Location = new System.Drawing.Point(134, 288);
            this.pbClickDmg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbClickDmg.Name = "pbClickDmg";
            this.tableLayoutPanel1.SetRowSpan(this.pbClickDmg, 3);
            this.pbClickDmg.Size = new System.Drawing.Size(78, 100);
            this.pbClickDmg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClickDmg.TabIndex = 8;
            this.pbClickDmg.TabStop = false;
            this.pbClickDmg.Click += new System.EventHandler(this.pbClickDmg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Upgrades: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnLoad, 2);
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Location = new System.Drawing.Point(529, 444);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(130, 22);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(529, 470);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 22);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbCharacterInfo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbCharacterInfo, 4);
            this.lbCharacterInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCharacterInfo.FormattingEnabled = true;
            this.lbCharacterInfo.Location = new System.Drawing.Point(216, 418);
            this.lbCharacterInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbCharacterInfo.Name = "lbCharacterInfo";
            this.tableLayoutPanel1.SetRowSpan(this.lbCharacterInfo, 4);
            this.lbCharacterInfo.Size = new System.Drawing.Size(309, 100);
            this.lbCharacterInfo.TabIndex = 13;
            // 
            // pbCharacter
            // 
            this.pbCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCharacter.Image = global::RPGClicker.Properties.Resources.Mage;
            this.pbCharacter.Location = new System.Drawing.Point(134, 418);
            this.pbCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCharacter.Name = "pbCharacter";
            this.tableLayoutPanel1.SetRowSpan(this.pbCharacter, 4);
            this.pbCharacter.Size = new System.Drawing.Size(78, 100);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCharacter.TabIndex = 14;
            this.pbCharacter.TabStop = false;
            // 
            // lbLog
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbLog, 2);
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(529, 28);
            this.lbLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbLog.Name = "lbLog";
            this.tableLayoutPanel1.SetRowSpan(this.lbLog, 6);
            this.lbLog.Size = new System.Drawing.Size(130, 386);
            this.lbLog.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(529, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Log: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarSpecialAbility
            // 
            this.ProgressBarSpecialAbility.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.ProgressBarSpecialAbility, 3);
            this.ProgressBarSpecialAbility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBarSpecialAbility.ForeColor = System.Drawing.Color.Lime;
            this.ProgressBarSpecialAbility.Location = new System.Drawing.Point(216, 392);
            this.ProgressBarSpecialAbility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProgressBarSpecialAbility.Name = "ProgressBarSpecialAbility";
            this.ProgressBarSpecialAbility.Size = new System.Drawing.Size(227, 22);
            this.ProgressBarSpecialAbility.TabIndex = 17;
            // 
            // progressBarEnemyHealth
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarEnemyHealth, 3);
            this.progressBarEnemyHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarEnemyHealth.ForeColor = System.Drawing.Color.Lime;
            this.progressBarEnemyHealth.Location = new System.Drawing.Point(216, 288);
            this.progressBarEnemyHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarEnemyHealth.Name = "progressBarEnemyHealth";
            this.progressBarEnemyHealth.Size = new System.Drawing.Size(227, 22);
            this.progressBarEnemyHealth.TabIndex = 18;
            // 
            // btnSpecialAbility
            // 
            this.btnSpecialAbility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpecialAbility.Location = new System.Drawing.Point(282, 314);
            this.btnSpecialAbility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpecialAbility.Name = "btnSpecialAbility";
            this.btnSpecialAbility.Size = new System.Drawing.Size(95, 48);
            this.btnSpecialAbility.TabIndex = 19;
            this.btnSpecialAbility.Text = "<Ability>";
            this.btnSpecialAbility.UseVisualStyleBackColor = true;
            this.btnSpecialAbility.Click += new System.EventHandler(this.btnSpecialAbility_Click);
            // 
            // lProgressBar
            // 
            this.lProgressBar.AutoSize = true;
            this.lProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lProgressBar.Location = new System.Drawing.Point(282, 364);
            this.lProgressBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProgressBar.Name = "lProgressBar";
            this.lProgressBar.Size = new System.Drawing.Size(95, 26);
            this.lProgressBar.TabIndex = 20;
            this.lProgressBar.Text = "<Special ability>";
            this.lProgressBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.tableLayoutPanel2);
            this.InventoryTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InventoryTab.Size = new System.Drawing.Size(665, 524);
            this.InventoryTab.TabIndex = 2;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.btnUnequipedAll, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbEquipedItem, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbNotEquipedItem, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnUnequipItem, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnEquipItem1, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSellItem, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnEquipItem2, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnEquipItem3, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lItemSlot3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lItemSlot2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lItemSlot1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(661, 520);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnUnequipedAll
            // 
            this.btnUnequipedAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnequipedAll.Location = new System.Drawing.Point(347, 158);
            this.btnUnequipedAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnequipedAll.Name = "btnUnequipedAll";
            this.btnUnequipedAll.Size = new System.Drawing.Size(111, 22);
            this.btnUnequipedAll.TabIndex = 26;
            this.btnUnequipedAll.Text = "Unequip All Items";
            this.btnUnequipedAll.UseVisualStyleBackColor = true;
            this.btnUnequipedAll.Click += new System.EventHandler(this.btnUnequipedAll_Click);
            // 
            // cbEquipedItem
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbEquipedItem, 2);
            this.cbEquipedItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbEquipedItem.FormattingEnabled = true;
            this.cbEquipedItem.Location = new System.Drawing.Point(2, 159);
            this.cbEquipedItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEquipedItem.Name = "cbEquipedItem";
            this.cbEquipedItem.Size = new System.Drawing.Size(226, 21);
            this.cbEquipedItem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equiped items: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbNotEquipedItem
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbNotEquipedItem, 2);
            this.cbNotEquipedItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNotEquipedItem.FormattingEnabled = true;
            this.cbNotEquipedItem.Location = new System.Drawing.Point(2, 210);
            this.cbNotEquipedItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNotEquipedItem.Name = "cbNotEquipedItem";
            this.cbNotEquipedItem.Size = new System.Drawing.Size(226, 21);
            this.cbNotEquipedItem.TabIndex = 7;
            // 
            // btnUnequipItem
            // 
            this.btnUnequipItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnequipItem.Location = new System.Drawing.Point(232, 158);
            this.btnUnequipItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnequipItem.Name = "btnUnequipItem";
            this.btnUnequipItem.Size = new System.Drawing.Size(111, 22);
            this.btnUnequipItem.TabIndex = 8;
            this.btnUnequipItem.Text = "Unequip Item";
            this.btnUnequipItem.UseVisualStyleBackColor = true;
            this.btnUnequipItem.Click += new System.EventHandler(this.btnUnequipItem_Click);
            // 
            // btnEquipItem1
            // 
            this.btnEquipItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquipItem1.Location = new System.Drawing.Point(232, 210);
            this.btnEquipItem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEquipItem1.Name = "btnEquipItem1";
            this.btnEquipItem1.Size = new System.Drawing.Size(111, 22);
            this.btnEquipItem1.TabIndex = 9;
            this.btnEquipItem1.Text = "Equip Item slot 1";
            this.btnEquipItem1.UseVisualStyleBackColor = true;
            this.btnEquipItem1.Click += new System.EventHandler(this.btnEquipItem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Not equiped items:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Currently equiped items:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSellItem
            // 
            this.btnSellItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSellItem.Location = new System.Drawing.Point(347, 236);
            this.btnSellItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSellItem.Name = "btnSellItem";
            this.btnSellItem.Size = new System.Drawing.Size(111, 22);
            this.btnSellItem.TabIndex = 16;
            this.btnSellItem.Text = "Sell";
            this.btnSellItem.UseVisualStyleBackColor = true;
            this.btnSellItem.Click += new System.EventHandler(this.btnSellItem_Click);
            // 
            // btnEquipItem2
            // 
            this.btnEquipItem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquipItem2.Location = new System.Drawing.Point(347, 210);
            this.btnEquipItem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEquipItem2.Name = "btnEquipItem2";
            this.btnEquipItem2.Size = new System.Drawing.Size(111, 22);
            this.btnEquipItem2.TabIndex = 17;
            this.btnEquipItem2.Text = "Equip Item slot 2";
            this.btnEquipItem2.UseVisualStyleBackColor = true;
            this.btnEquipItem2.Click += new System.EventHandler(this.btnEquipItem_Click);
            // 
            // btnEquipItem3
            // 
            this.btnEquipItem3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquipItem3.Location = new System.Drawing.Point(232, 236);
            this.btnEquipItem3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEquipItem3.Name = "btnEquipItem3";
            this.btnEquipItem3.Size = new System.Drawing.Size(111, 22);
            this.btnEquipItem3.TabIndex = 18;
            this.btnEquipItem3.Text = "Equip Item slot 3";
            this.btnEquipItem3.UseVisualStyleBackColor = true;
            this.btnEquipItem3.Click += new System.EventHandler(this.btnEquipItem3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(2, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 26);
            this.label15.TabIndex = 19;
            this.label15.Text = "Item slot 3:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lItemSlot3
            // 
            this.lItemSlot3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lItemSlot3, 2);
            this.lItemSlot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lItemSlot3.Location = new System.Drawing.Point(117, 78);
            this.lItemSlot3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lItemSlot3.Name = "lItemSlot3";
            this.lItemSlot3.Size = new System.Drawing.Size(226, 26);
            this.lItemSlot3.TabIndex = 20;
            this.lItemSlot3.Text = "No item equiped";
            this.lItemSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(2, 52);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 26);
            this.label18.TabIndex = 22;
            this.label18.Text = "Item slot 2:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lItemSlot2
            // 
            this.lItemSlot2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lItemSlot2, 2);
            this.lItemSlot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lItemSlot2.Location = new System.Drawing.Point(117, 52);
            this.lItemSlot2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lItemSlot2.Name = "lItemSlot2";
            this.lItemSlot2.Size = new System.Drawing.Size(226, 26);
            this.lItemSlot2.TabIndex = 23;
            this.lItemSlot2.Text = "No item equiped";
            this.lItemSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(2, 26);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 26);
            this.label17.TabIndex = 24;
            this.label17.Text = "Item slot 1:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lItemSlot1
            // 
            this.lItemSlot1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lItemSlot1, 2);
            this.lItemSlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lItemSlot1.Location = new System.Drawing.Point(117, 26);
            this.lItemSlot1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lItemSlot1.Name = "lItemSlot1";
            this.lItemSlot1.Size = new System.Drawing.Size(226, 26);
            this.lItemSlot1.TabIndex = 25;
            this.lItemSlot1.Text = "No item equiped";
            this.lItemSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MobCreateTab
            // 
            this.MobCreateTab.Controls.Add(this.MobCreatorTab);
            this.MobCreateTab.Location = new System.Drawing.Point(4, 22);
            this.MobCreateTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MobCreateTab.Name = "MobCreateTab";
            this.MobCreateTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MobCreateTab.Size = new System.Drawing.Size(665, 524);
            this.MobCreateTab.TabIndex = 3;
            this.MobCreateTab.Text = "MobCreator";
            this.MobCreateTab.UseVisualStyleBackColor = true;
            // 
            // MobCreatorTab
            // 
            this.MobCreatorTab.ColumnCount = 7;
            this.MobCreatorTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MobCreatorTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MobCreatorTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MobCreatorTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.MobCreatorTab.Controls.Add(this.label9, 0, 1);
            this.MobCreatorTab.Controls.Add(this.label10, 1, 4);
            this.MobCreatorTab.Controls.Add(this.label11, 1, 6);
            this.MobCreatorTab.Controls.Add(this.label12, 1, 8);
            this.MobCreatorTab.Controls.Add(this.label13, 1, 10);
            this.MobCreatorTab.Controls.Add(this.numMCHealth, 1, 5);
            this.MobCreatorTab.Controls.Add(this.numMCDamage, 1, 7);
            this.MobCreatorTab.Controls.Add(this.CheckBoxBossYN, 1, 9);
            this.MobCreatorTab.Controls.Add(this.NumMCTimer, 1, 11);
            this.MobCreatorTab.Controls.Add(this.pbMobCreatorImage, 5, 2);
            this.MobCreatorTab.Controls.Add(this.btnCreateMob, 3, 12);
            this.MobCreatorTab.Controls.Add(this.label16, 1, 2);
            this.MobCreatorTab.Controls.Add(this.tbMCName, 1, 3);
            this.MobCreatorTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MobCreatorTab.Location = new System.Drawing.Point(2, 2);
            this.MobCreatorTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MobCreatorTab.Name = "MobCreatorTab";
            this.MobCreatorTab.RowCount = 14;
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MobCreatorTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MobCreatorTab.Size = new System.Drawing.Size(661, 520);
            this.MobCreatorTab.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.MobCreatorTab.SetColumnSpan(this.label9, 7);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(2, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(657, 52);
            this.label9.TabIndex = 0;
            this.label9.Text = "MOB CREATOR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(35, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Health:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(35, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Damage:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(35, 234);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "Boss:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(35, 286);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "Timer:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numMCHealth
            // 
            this.MobCreatorTab.SetColumnSpan(this.numMCHealth, 3);
            this.numMCHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMCHealth.Location = new System.Drawing.Point(35, 158);
            this.numMCHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numMCHealth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numMCHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMCHealth.Name = "numMCHealth";
            this.numMCHealth.Size = new System.Drawing.Size(161, 20);
            this.numMCHealth.TabIndex = 5;
            this.numMCHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMCDamage
            // 
            this.MobCreatorTab.SetColumnSpan(this.numMCDamage, 3);
            this.numMCDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMCDamage.Location = new System.Drawing.Point(35, 210);
            this.numMCDamage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numMCDamage.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numMCDamage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMCDamage.Name = "numMCDamage";
            this.numMCDamage.Size = new System.Drawing.Size(161, 20);
            this.numMCDamage.TabIndex = 6;
            this.numMCDamage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckBoxBossYN
            // 
            this.CheckBoxBossYN.AutoSize = true;
            this.MobCreatorTab.SetColumnSpan(this.CheckBoxBossYN, 4);
            this.CheckBoxBossYN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxBossYN.Location = new System.Drawing.Point(35, 262);
            this.CheckBoxBossYN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBoxBossYN.Name = "CheckBoxBossYN";
            this.CheckBoxBossYN.Size = new System.Drawing.Size(194, 22);
            this.CheckBoxBossYN.TabIndex = 7;
            this.CheckBoxBossYN.Text = "Yes";
            this.CheckBoxBossYN.UseVisualStyleBackColor = true;
            // 
            // NumMCTimer
            // 
            this.MobCreatorTab.SetColumnSpan(this.NumMCTimer, 3);
            this.NumMCTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumMCTimer.Location = new System.Drawing.Point(35, 314);
            this.NumMCTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumMCTimer.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.NumMCTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMCTimer.Name = "NumMCTimer";
            this.NumMCTimer.Size = new System.Drawing.Size(161, 20);
            this.NumMCTimer.TabIndex = 8;
            this.NumMCTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbMobCreatorImage
            // 
            this.pbMobCreatorImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMobCreatorImage.Image = global::RPGClicker.Properties.Resources.shar;
            this.pbMobCreatorImage.Location = new System.Drawing.Point(233, 80);
            this.pbMobCreatorImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMobCreatorImage.Name = "pbMobCreatorImage";
            this.MobCreatorTab.SetRowSpan(this.pbMobCreatorImage, 11);
            this.pbMobCreatorImage.Size = new System.Drawing.Size(194, 282);
            this.pbMobCreatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMobCreatorImage.TabIndex = 9;
            this.pbMobCreatorImage.TabStop = false;
            // 
            // btnCreateMob
            // 
            this.btnCreateMob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateMob.Location = new System.Drawing.Point(134, 340);
            this.btnCreateMob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateMob.Name = "btnCreateMob";
            this.btnCreateMob.Size = new System.Drawing.Size(62, 22);
            this.btnCreateMob.TabIndex = 10;
            this.btnCreateMob.Text = "Create";
            this.btnCreateMob.UseVisualStyleBackColor = true;
            this.btnCreateMob.Click += new System.EventHandler(this.btnCreateMob_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(35, 78);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 26);
            this.label16.TabIndex = 11;
            this.label16.Text = "Name:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbMCName
            // 
            this.MobCreatorTab.SetColumnSpan(this.tbMCName, 3);
            this.tbMCName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMCName.Location = new System.Drawing.Point(35, 106);
            this.tbMCName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMCName.Name = "tbMCName";
            this.tbMCName.Size = new System.Drawing.Size(161, 20);
            this.tbMCName.TabIndex = 12;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 550);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "RPG Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharacterAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharSelect)).EndInit();
            this.ClickerTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.InventoryTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MobCreateTab.ResumeLayout(false);
            this.MobCreatorTab.ResumeLayout(false);
            this.MobCreatorTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMCHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMCDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMCTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMobCreatorImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage ClickerTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBuyUpgrade;
        private System.Windows.Forms.ListBox lbUpgrade;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.Label lEnemyHealth;
        private System.Windows.Forms.Label lEnemyName;
        private System.Windows.Forms.Label lClickDamage;
        private System.Windows.Forms.Label lHealAmount;
        private System.Windows.Forms.PictureBox pbHeal;
        private System.Windows.Forms.PictureBox pbClickDmg;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TabPage MobCreateTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbCharacterInfo;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbEquipedItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNotEquipedItem;
        private System.Windows.Forms.Button btnUnequipItem;
        private System.Windows.Forms.Button btnEquipItem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar ProgressBarSpecialAbility;
        private System.Windows.Forms.ProgressBar progressBarEnemyHealth;
        private System.Windows.Forms.Button btnSpecialAbility;
        private System.Windows.Forms.Label lProgressBar;
        private System.Windows.Forms.Button btnSellItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCharacterAge;
        private System.Windows.Forms.TextBox tbCharacterName;
        private System.Windows.Forms.ComboBox cbCharacterClass;
        private System.Windows.Forms.PictureBox pbCharSelect;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.TableLayoutPanel MobCreatorTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numMCHealth;
        private System.Windows.Forms.NumericUpDown numMCDamage;
        private System.Windows.Forms.CheckBox CheckBoxBossYN;
        private System.Windows.Forms.NumericUpDown NumMCTimer;
        private System.Windows.Forms.PictureBox pbMobCreatorImage;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEquipItem2;
        private System.Windows.Forms.Button btnEquipItem3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lItemSlot3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lItemSlot2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lItemSlot1;
        private System.Windows.Forms.Button btnCreateMob;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMCName;
        private System.Windows.Forms.CheckBox CheckAdmin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUnequipedAll;
    }
}

