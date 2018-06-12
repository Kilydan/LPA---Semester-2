using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RPGClicker
{
    public partial class Form1 : Form
    {
        int currentEnemyHealth = 10;
        int currentCharacterHealth;
        int totalKills = 0;
        int totalGold = 0;

        GameOption gameoption = new GameOption();
        Character character;
        Enemy enemy;

        public Form1()
        {
            InitializeComponent();
            progressBarEnemyHealth.Maximum = currentEnemyHealth;
            progressBarEnemyHealth.Value = progressBarEnemyHealth.Maximum;
            MobCreatorTab.Enabled = false;
            enemy = gameoption.summonEnemy();
            if (character == null)
            {
                tableLayoutPanel1.Enabled = false;
                tableLayoutPanel2.Enabled = false;
            }
        }

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                character = gameoption.createCharacter(cbCharacterClass.Text, tbCharacterName.Text, (int)numCharacterAge.Value, CheckAdmin.Checked);

                if (character == null)
                {
                    throw new ArgumentNullException("Please select an character");
                }
                if (character is Warrior)
                {
                    ProgressBarSpecialAbility.Maximum = 100;
                    ProgressBarSpecialAbility.Value = 0;
                }
                else if (character is Mage)
                {
                    ProgressBarSpecialAbility.Maximum = 200;
                    ProgressBarSpecialAbility.Value = ProgressBarSpecialAbility.Maximum;
                }
                else
                {
                    ProgressBarSpecialAbility.Maximum = 30;
                    ProgressBarSpecialAbility.Value = 0;
                }
                enemy = gameoption.Enemies[0];
                timer.Enabled = true;
                AbilityLabel();
                startUp();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (character is Summoner)
            {
                Summoner summoner = character as Summoner;
                progressBarEnemyHealth.Step = -summoner.Dps;
                progressBarEnemyHealth.PerformStep();
                //AbilityLabel();
            }
            updateLabels();
            EnemyDies();
            characterInfo();
            AbilityLabel();
        }

        private void pbClickDmg_Click(object sender, EventArgs e)
        {
            DamageEnemy(character.Attack());
            if (character is Warrior)
            {
                Warrior warrior = character as Warrior;
                ProgressBarSpecialAbility.Value = warrior.Rage;
                ProgressBarSpecialAbility.Maximum = 100;
                if (warrior.Rage < 100)
                {
                    ProgressBarSpecialAbility.Step = 1;
                    ProgressBarSpecialAbility.PerformStep();
                    ProgressBarSpecialAbility.Value = warrior.Rage;
                    warrior.Rage++;
                }
            }
        }

        private void pbHeal_Click(object sender, EventArgs e)
        {
            currentCharacterHealth += character.Heal();
            if (currentCharacterHealth >= character.Health + character.GetUpgradeValue("Health"))
            {
                currentCharacterHealth = character.Health + character.GetUpgradeValue("Health");
            }
            characterInfo();
        }


        private void btnSpecialAbility_Click(object sender, EventArgs e)
        {
            int dmg = 0;
            if (character is Summoner)
            {
                Summoner summoner = character as Summoner;
                if (summoner.Cooldown >= 30)
                {
                    summoner.Cooldown = 0;
                    summoner.SummonMinion(summoner.Cooldown, (summoner.ClickDamage + character.GetUpgradeValue("ClickDamage")));

                    ProgressBarSpecialAbility.Step = -30;
                    ProgressBarSpecialAbility.PerformStep();
                    AbilityLabel();
                }
                else
                {
                    MessageBox.Show("It's still on cooldown, please wait " + (30 - summoner.Cooldown) + " seconds");
                }
            }
            if (character is Warrior)
            {
                Warrior warrior = character as Warrior;
                if (warrior.Rage > 0)
                {
                    ProgressBarSpecialAbility.Value = 0;
                    AbilityLabel();
                    dmg = warrior.UseRage(warrior.Rage);
                }
                else
                {
                    MessageBox.Show("You need rage to cast this");
                }
            }
            if (character is Mage)
            {
                Mage mage = character as Mage;
                if (mage.Mana >= 40)
                {
                    ProgressBarSpecialAbility.Step = -40;
                    ProgressBarSpecialAbility.PerformStep();
                    dmg = mage.UseSpell(40);
                    AbilityLabel();
                }
                else
                {
                    MessageBox.Show("Not enough mana");
                }
            }
            DamageEnemy(dmg);
        }

        private void btnBuyUpgrade_Click(object sender, EventArgs e)
        {
            try
            {
                Upgrade upgr = (Upgrade)lbUpgrade.SelectedItem;
                if (upgr != null)
                {
                    if (upgr.BuyPrice() <= totalGold)
                    {
                        character.Upgrade((Upgrade)lbUpgrade.SelectedItem);
                        totalGold -= upgr.BuyPrice();
                        updateLabels();
                        foreach (Upgrade upgrade in gameoption.Upgrades)
                        {
                            upgrade.TimesBought = upgrade.TimesBought + 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough gold :c");
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateLabels();
            updateUpgradeList();
        }

        private void btnEquipItem1_Click(object sender, EventArgs e)
        {
            equipItem((Item)cbNotEquipedItem.SelectedItem, lItemSlot1);
        }

        private void btnEquipItem_Click(object sender, EventArgs e)
        {
            equipItem((Item)cbNotEquipedItem.SelectedItem, lItemSlot2);
        }

        private void btnEquipItem3_Click(object sender, EventArgs e)
        {
            equipItem((Item)cbNotEquipedItem.SelectedItem, lItemSlot3);
        }

        private void btnSellItem_Click(object sender, EventArgs e)
        {
            if (cbEquipedItem.Text == "" || cbNotEquipedItem.Text == "")
            {
                MessageBox.Show("Please select an item to sell");
            }
            else
            {
                checkIfLabelMatches();
                sellItem(cbNotEquipedItem);
                sellItem(cbEquipedItem);
            }
        }

        private void btnUnequipItem_Click(object sender, EventArgs e)
        {
            try
            {
                character.RemoveItem((Item)cbEquipedItem.SelectedItem);
                cbNotEquipedItem.Items.Add((Item)cbEquipedItem.SelectedItem);
                checkIfLabelMatches();
                cbEquipedItem.Items.Remove(cbEquipedItem.SelectedItem);
                cbEquipedItem.Text = "";
                if (currentCharacterHealth > character.Health + character.GetUpgradeValue("Health"))
                {
                    currentCharacterHealth = character.Health + character.GetUpgradeValue("Health");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateMob_Click(object sender, EventArgs e)
        {
            if (!CheckBoxBossYN.Checked)
            {
                try
                {
                    Enemy createdEnemy = new Enemy(tbMCName.Text, (int)numMCHealth.Value, (int)numMCDamage.Value);
                    gameoption.addEnemy(createdEnemy);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Boss boss = new Boss(tbMCName.Text, (int)numMCHealth.Value, (int)numMCDamage.Value, (int)NumMCTimer.Value);
                    gameoption.addEnemy(boss);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbCharacterClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            charaterPictureBox(pbCharSelect, cbCharacterClass.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("create a .bin file or select one to override");
                string directoryPath = getFileName();
                if (gameoption.Save(directoryPath, character))
                {
                    character.EquipedItems.Clear();
                    refreshItemLabels();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("select a .bin file to load");
            try
            {
                string directoryPath = getFileName();
                if (directoryPath != null || directoryPath != "")
                {
                    ProgressBarSpecialAbility.Value = 0;
                    character = gameoption.Load(directoryPath, character);
                    if (character is Summoner)
                    {
                        charaterPictureBox(pbCharacter, "Summoner");
                    }
                    else if (character is Mage)
                    {
                        charaterPictureBox(pbCharacter, "Mage");
                    }
                    else if (character is Warrior)
                    {
                        charaterPictureBox(pbCharacter, "Warrior");
                    }
                    if (character != null)
                    {
                        timer.Enabled = true;
                        currentCharacterHealth = character.Health;
                        fillItemList();
                        updateLabels();
                        updateUpgradeList();
                        cbEquipedItem.Items.Clear();
                        refreshItemLabels();
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnequipedAll_Click(object sender, EventArgs e)
        {
            if (character.EquipedItems.Count != 0)
            {
                character.EquipedItems.Clear();
                refreshItemLabels();
            }
            else
            {
                MessageBox.Show("You do not have any items equiped");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Own Functions
        /// </summary>
        private void abilities()
        {
            if (character is Summoner)
            {
                Summoner summoner = character as Summoner;
                if (summoner.Cooldown > 0)
                {
                    summoner.Cooldown--;
                }
            }
            if (character is Mage)
            {
                Mage mage = character as Mage;
                if (mage.Mana < 200)
                {
                    ProgressBarSpecialAbility.Step = 1;
                    ProgressBarSpecialAbility.PerformStep();
                    AbilityLabel();
                    mage.Mana++;
                }
            }
        }


        private void refreshItemLabels()
        {
            lItemSlot1.Text = "No item equiped";
            lItemSlot2.Text = "No item equiped";
            lItemSlot3.Text = "No item equiped";
            cbEquipedItem.Items.Clear();
            cbNotEquipedItem.Items.Clear();
            foreach (Item a in character.EquipedItems)
            {
                cbEquipedItem.Items.Add(a);
            }
            foreach (Item a in character.Items)
            {
                cbNotEquipedItem.Items.Add(a);
            }
        }

        private string createItemName()
        {
            string directoryPath = "C:/Users/timho/Google Drive/thuis/RPGClicker/RPGClicker/itemName.txt";
            try
            {
                if (!File.Exists(directoryPath))
                {
                    throw new FileNotFoundException();
                }
                if (!directoryPath.Contains(".txt"))
                {
                    throw new FormatException();
                }
                string fileContent = File.ReadAllText(directoryPath);
                string[] output = fileContent.Split('(', ')');
                int i = 0;
                string PrefixName = "";
                string SuffixName = "";
                foreach (string a in output)
                {
                    var newArray = new List<String>(output);
                    newArray.ToArray();
                    if (i == 1)
                    {
                        string[] Prefix = a.Split(',');
                        int PrefixL = Prefix.Length;
                        Random random = new Random();
                        int prefixNameIndex = random.Next(0, PrefixL);
                        PrefixName = Prefix[prefixNameIndex];
                    }
                    else if (i == 3)
                    {
                        string[] Suffix = a.Split(',');
                        int SuffixL = Suffix.Length;
                        Random random = new Random();
                        int suffixNameIndex = random.Next(0, SuffixL);
                        SuffixName = Suffix[suffixNameIndex];
                    }
                    i++;
                }
                string fullName = PrefixName + "" + SuffixName;
                return fullName;
            }
            catch (FormatException)
            {
                MessageBox.Show("Select a .txt file to open");
                return "";
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
                return "";
            }
        }

        private void characterInfo()
        {
            int dps = 0;
            if (character is Summoner)
            {
                Summoner summoner = character as Summoner;
                dps = summoner.Dps;
            }
            lbCharacterInfo.Items.Clear();
            lbCharacterInfo.Items.Add("Name: " + character.Name + "    Age: " + character.Age);
            lbCharacterInfo.Items.Add("Health: " + currentCharacterHealth + "/" + (character.Health + character.GetUpgradeValue("Health")));
            lbCharacterInfo.Items.Add("Total Kills: " + totalKills);
            lbCharacterInfo.Items.Add("Gold: " + totalGold);
            lbCharacterInfo.Items.Add("Armor: " + (character.Armor + character.GetUpgradeValue("Armor")));
            lbCharacterInfo.Items.Add("Dps: " + dps);
        }

        private void characterDies()
        {
            if (currentCharacterHealth <= 0)
            {
                totalKills -= totalKills / 10;
                totalGold -= totalGold / 10;
                currentCharacterHealth = character.Health + character.GetUpgradeValue("Health");
                createMob();
            }
        }

        private void createMob()
        {
            Enemy newEnemy = new Enemy("Derpmander", 10, 1);
            enemy = gameoption.summonEnemy();
            lEnemyName.Text = enemy.Name;
            progressBarEnemyHealth.Maximum = enemy.Health;
            progressBarEnemyHealth.Value = progressBarEnemyHealth.Maximum;
        }

        private void itemDropped()
        {
            string rarity;
            Random r = new Random();
            int random = r.Next(1, 101);
            int val = r.Next(1, 11);
            if (random <= 80)
            {
                rarity = "Common";
            }
            else if (random <= 99)
            {
                rarity = "Rare";
                val += 2;
            }
            else
            {
                rarity = "Epic";
                val += 5;
            }
            int number = r.Next(1, 4);
            string itemType = "";
            switch (number)
            {
                case 1:
                    itemType = "Health";
                    break;
                case 2:
                    itemType = "Armor";
                    break;
                case 3:
                    itemType = "ClickDamage";
                    break;
            }
            string itemName = createItemName();
            try
            {
                Item droppedItem = new Item(rarity, itemName, itemType, val);
                character.Items.Add(droppedItem);
                lbLog.Items.Add(droppedItem.Rarity.ToString() + " item !");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }

            fillItemList();
            characterInfo();
        }

        private void fillItemList()
        {
            cbNotEquipedItem.Items.Clear();
            if (character.Items != null)
            {
                foreach (Item a in character.Items)
                {
                    cbNotEquipedItem.Items.Add(a);
                }
            }
        }

        private void startUp()
        {
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel2.Enabled = true;
            if (character.Admin)
            {
                MobCreatorTab.Enabled = true;
            }
            updateUpgradeList();
            charaterPictureBox(pbCharacter, cbCharacterClass.Text);
            TabControl.SelectedIndex = 1;
            currentCharacterHealth = character.Health + character.GetUpgradeValue("Health");
            updateLabels();
        }

        private string getFileName()
        {
            string directoryPath = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                directoryPath = openFileDialog1.FileName;
                if (directoryPath == null) throw new ArgumentNullException("Filename");
                try
                {
                    if (!File.Exists(directoryPath))
                    {
                        throw new FileNotFoundException();
                    }
                    if (!directoryPath.Contains(".bin"))
                    {
                        throw new FormatException();
                    }
                    return directoryPath;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Select a .bin file to open");
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File not found");
                }
            }
            return "";
        }

        private void checkIfLabelMatches()
        {
            if (lItemSlot1.Text == cbEquipedItem.SelectedItem.ToString())
            {
                lItemSlot1.Text = "No item equiped";
            }
            else if (lItemSlot2.Text == cbEquipedItem.SelectedItem.ToString())
            {
                lItemSlot2.Text = "No item equiped";
            }
            else
            {
                lItemSlot3.Text = "No item equiped";
            }
        }

        private void AbilityLabel()
        {
            lProgressBar.Text = ProgressBarSpecialAbility.Value + "/" + ProgressBarSpecialAbility.Maximum;
            if (character is Warrior)
            {
                Warrior warrior = character as Warrior;
                ProgressBarSpecialAbility.Value = warrior.Rage;
                ProgressBarSpecialAbility.Maximum = 100;
            }
            else if (character is Mage)
            {
                Mage mage = character as Mage;
                ProgressBarSpecialAbility.Step = 1;
                ProgressBarSpecialAbility.PerformStep();
                ProgressBarSpecialAbility.Maximum = 200;
            }
            else if (character is Summoner)
            {
                Summoner summoner = character as Summoner;
                summoner.Cooldown++;
                ProgressBarSpecialAbility.Step = 1;
                ProgressBarSpecialAbility.PerformStep();
                ProgressBarSpecialAbility.Maximum = 30;
            }
        }

        private void sellItem(ComboBox cb)
        {
            try
            {
                Item item = (Item)cb.SelectedItem;
                int sellGold = item.SellItem();
                totalGold += sellGold;
                lbLog.Items.Add("Item sold, " + sellGold + " G has been added");
                cb.Items.Remove(item);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void equipItem(Item item, Label label)
        {
            if (label.Text == "No item equiped")
            {
                try
                {
                    character.AddItem(item);
                    cbEquipedItem.Items.Add(item);
                    label.Text = item.ToString();
                    cbNotEquipedItem.Items.Remove(item);
                    cbNotEquipedItem.Text = "";
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Unequip an item before you can equip one");
            }
        }

        private void charaterPictureBox(PictureBox pb, string Class)
        {
            switch (Class)
            {
                case "Warrior":
                    pb.Image = RPGClicker.Properties.Resources.Warrior;
                    break;
                case "Mage":
                    pb.Image = RPGClicker.Properties.Resources.Mage;
                    break;
                case "Summoner":
                    pb.Image = RPGClicker.Properties.Resources.Summoner;
                    break;
            }
        }

        private void updateUpgradeList()
        {
            lbUpgrade.Items.Clear();
            foreach (Upgrade upgrade in gameoption.Upgrades)
            {
                lbUpgrade.Items.Add(upgrade);
            }
        }

        private void DamageEnemy(int dmg)
        {
            progressBarEnemyHealth.Step = -dmg;
            progressBarEnemyHealth.PerformStep();
            lProgressBar.Text = ProgressBarSpecialAbility.Value + "/" + ProgressBarSpecialAbility.Maximum;

            updateLabels();
        }

        private void updateLabels()
        {
            lEnemyHealth.Text = progressBarEnemyHealth.Value + " / " + progressBarEnemyHealth.Maximum + "";
            lClickDamage.Text = "Dmg: " + character.Attack();
            lHealAmount.Text = "Heal: " + character.Heal().ToString();
            lEnemyName.Text = enemy.Name;
            //AbilityLabel();
        }

        private void EnemyDies()
        {
            if (progressBarEnemyHealth.Value <= 0)
            {
                totalKills++;
                totalGold += enemy.GoldDrop;
                if (enemy.OnDeathEvent(enemy.ItemDropChance))
                {
                    itemDropped();
                }
                lbLog.Items.Add(enemy.ToString());
                lbLog.TopIndex = lbLog.Items.Count - 1;
                lbLog.ClearSelected();
                createMob();
                updateLabels();
            }
            else
            {
                int damageTaken = character.Armor + character.GetUpgradeValue("Armor") - enemy.Damage;
                if (damageTaken < 0)
                {
                    currentCharacterHealth += damageTaken;
                    characterDies();
                }
            }
        }
    }
}