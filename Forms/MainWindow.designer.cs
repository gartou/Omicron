﻿using System.Windows.Forms;

namespace Omicron_Pi
{
    partial class OmicronPiMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OmicronPiMainWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.createNewConfigButton = new System.Windows.Forms.Button();
            this.openExistingConfigButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enable_banteam_bypass_geoblocking = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enable_banteam_reserved_slots = new System.Windows.Forms.CheckBox();
            this.enable_banteam_access = new System.Windows.Forms.CheckBox();
            this.enable_manager_access = new System.Windows.Forms.CheckBox();
            this.enable_staff_access = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reqKickPowerNumUD = new System.Windows.Forms.NumericUpDown();
            this.kickPowerNumUD = new System.Windows.Forms.NumericUpDown();
            this.badgeColourComboBox = new System.Windows.Forms.ComboBox();
            this.badgeHiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.badgeCoverCheckBox = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.badgeNameTextBox = new System.Windows.Forms.TextBox();
            this.permissionsBox = new System.Windows.Forms.GroupBox();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.KickingAndShortTermBanning = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.BanningUpToDay = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.LongTermBanning = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.ForceclassSelf = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ForceclassToSpectator = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.GivingItems = new System.Windows.Forms.CheckBox();
            this.AFKImmunity = new System.Windows.Forms.CheckBox();
            this.ForceclassWithoutRestrictions = new System.Windows.Forms.CheckBox();
            this.Noclip = new System.Windows.Forms.CheckBox();
            this.WarheadEvents = new System.Windows.Forms.CheckBox();
            this.PlayerSensitiveDataAccess = new System.Windows.Forms.CheckBox();
            this.RespawnEvents = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.RoundEvents = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.GameplayData = new System.Windows.Forms.CheckBox();
            this.SetGroup = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.FacilityManagement = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Overwatch = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.PlayersManagement = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.PermissionsManagement = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ServerConsoleCommands = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ViewHiddenBadges = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Broadcasting = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ServerConfigs = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupsRemoveButton = new System.Windows.Forms.Button();
            this.groupsAddButton = new System.Windows.Forms.Button();
            this.Groups = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.steamUrlLabel = new System.Windows.Forms.LinkLabel();
            this.showSteamInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.enableSteamInfo = new System.Windows.Forms.Button();
            this.steamNameLabel = new System.Windows.Forms.Label();
            this.changeGroupCombo = new System.Windows.Forms.ComboBox();
            this.changeUserGroup = new System.Windows.Forms.Button();
            this.removeUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.assignmentGroupsCombo = new System.Windows.Forms.ComboBox();
            this.steamAvatar = new System.Windows.Forms.PictureBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.saveCFGButton = new System.Windows.Forms.Button();
            this.startAgainButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.ViewHiddenGlobalBadges = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.AdminChat = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.Announcer = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.Effects = new System.Windows.Forms.CheckBox();
            this.FriendlyFireDetectorImmunity = new System.Windows.Forms.CheckBox();
            this.FriendlyFireDetectorTempDisable = new System.Windows.Forms.CheckBox();
            this.label49 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqKickPowerNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickPowerNumUD)).BeginInit();
            this.permissionsBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steamAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTabPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(1, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1203, 856);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.label42);
            this.generalTabPage.Controls.Add(this.label41);
            this.generalTabPage.Controls.Add(this.label40);
            this.generalTabPage.Controls.Add(this.createNewConfigButton);
            this.generalTabPage.Controls.Add(this.openExistingConfigButton);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(1195, 830);
            this.generalTabPage.TabIndex = 3;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(4, 803);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(574, 13);
            this.label42.TabIndex = 7;
            this.label42.Text = "If you have any issues with the program or you just wanna make a comment you can " +
    "contact on Discord @ Takail#6969";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(7, 11);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(191, 39);
            this.label41.TabIndex = 6;
            this.label41.Text = "Omicron PI";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(15, 58);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(871, 36);
            this.label40.TabIndex = 5;
            this.label40.Text = resources.GetString("label40.Text");
            // 
            // createNewConfigButton
            // 
            this.createNewConfigButton.Location = new System.Drawing.Point(201, 115);
            this.createNewConfigButton.Name = "createNewConfigButton";
            this.createNewConfigButton.Size = new System.Drawing.Size(176, 27);
            this.createNewConfigButton.TabIndex = 4;
            this.createNewConfigButton.Text = "Create New Config";
            this.createNewConfigButton.UseVisualStyleBackColor = true;
            this.createNewConfigButton.Click += new System.EventHandler(this.createNewConfigButton_Click);
            // 
            // openExistingConfigButton
            // 
            this.openExistingConfigButton.Location = new System.Drawing.Point(19, 115);
            this.openExistingConfigButton.Name = "openExistingConfigButton";
            this.openExistingConfigButton.Size = new System.Drawing.Size(176, 27);
            this.openExistingConfigButton.TabIndex = 3;
            this.openExistingConfigButton.Text = "Open Existing Config";
            this.openExistingConfigButton.UseVisualStyleBackColor = true;
            this.openExistingConfigButton.Click += new System.EventHandler(this.openExistingConfigButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.enable_banteam_bypass_geoblocking);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.enable_banteam_reserved_slots);
            this.tabPage1.Controls.Add(this.enable_banteam_access);
            this.tabPage1.Controls.Add(this.enable_manager_access);
            this.tabPage1.Controls.Add(this.enable_staff_access);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1195, 830);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(520, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "This setting will allow all global moderators to join your server regardless of a" +
    "n geo restrictions you might have.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "This setting will allow all global moderators to join your server even when its f" +
    "ull.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "This setting will allow all global moderators to access your servers RemoteAdmin." +
    "";
            // 
            // enable_banteam_bypass_geoblocking
            // 
            this.enable_banteam_bypass_geoblocking.AutoSize = true;
            this.enable_banteam_bypass_geoblocking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_banteam_bypass_geoblocking.Location = new System.Drawing.Point(20, 366);
            this.enable_banteam_bypass_geoblocking.Name = "enable_banteam_bypass_geoblocking";
            this.enable_banteam_bypass_geoblocking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enable_banteam_bypass_geoblocking.Size = new System.Drawing.Size(235, 17);
            this.enable_banteam_bypass_geoblocking.TabIndex = 8;
            this.enable_banteam_bypass_geoblocking.Text = "Allow the ban team to bypass georestrictions";
            this.enable_banteam_bypass_geoblocking.UseVisualStyleBackColor = true;
            this.enable_banteam_bypass_geoblocking.CheckedChanged += new System.EventHandler(this.globalBadgeOptionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Settings required for server verification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "This setting will allow department managers and the CEO access to your remoteadmi" +
    "n.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Optional Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "This setting will allow low level studio members such as tech support or SL Disco" +
    "rd moderators to access your remoteadmin.";
            // 
            // enable_banteam_reserved_slots
            // 
            this.enable_banteam_reserved_slots.AutoSize = true;
            this.enable_banteam_reserved_slots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_banteam_reserved_slots.Location = new System.Drawing.Point(20, 307);
            this.enable_banteam_reserved_slots.Name = "enable_banteam_reserved_slots";
            this.enable_banteam_reserved_slots.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enable_banteam_reserved_slots.Size = new System.Drawing.Size(208, 17);
            this.enable_banteam_reserved_slots.TabIndex = 3;
            this.enable_banteam_reserved_slots.Text = "Give ban team members reserved slots";
            this.enable_banteam_reserved_slots.UseVisualStyleBackColor = true;
            this.enable_banteam_reserved_slots.CheckedChanged += new System.EventHandler(this.globalBadgeOptionChanged);
            // 
            // enable_banteam_access
            // 
            this.enable_banteam_access.AutoSize = true;
            this.enable_banteam_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_banteam_access.Location = new System.Drawing.Point(20, 247);
            this.enable_banteam_access.Name = "enable_banteam_access";
            this.enable_banteam_access.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enable_banteam_access.Size = new System.Drawing.Size(204, 17);
            this.enable_banteam_access.TabIndex = 2;
            this.enable_banteam_access.Text = "Allow ban team RemoteAdmin access";
            this.enable_banteam_access.UseVisualStyleBackColor = true;
            this.enable_banteam_access.CheckedChanged += new System.EventHandler(this.globalBadgeOptionChanged);
            // 
            // enable_manager_access
            // 
            this.enable_manager_access.AutoSize = true;
            this.enable_manager_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_manager_access.Location = new System.Drawing.Point(20, 119);
            this.enable_manager_access.Name = "enable_manager_access";
            this.enable_manager_access.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enable_manager_access.Size = new System.Drawing.Size(323, 17);
            this.enable_manager_access.TabIndex = 1;
            this.enable_manager_access.Text = "Allow SCP:SL Managers and the CEO  access to remote admin";
            this.enable_manager_access.UseVisualStyleBackColor = true;
            this.enable_manager_access.CheckedChanged += new System.EventHandler(this.globalBadgeOptionChanged);
            // 
            // enable_staff_access
            // 
            this.enable_staff_access.AutoSize = true;
            this.enable_staff_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_staff_access.Location = new System.Drawing.Point(20, 61);
            this.enable_staff_access.Name = "enable_staff_access";
            this.enable_staff_access.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enable_staff_access.Size = new System.Drawing.Size(231, 17);
            this.enable_staff_access.TabIndex = 0;
            this.enable_staff_access.Text = "Allow SCP:SL Staff access to remote admin";
            this.enable_staff_access.UseVisualStyleBackColor = true;
            this.enable_staff_access.CheckedChanged += new System.EventHandler(this.globalBadgeOptionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.permissionsBox);
            this.tabPage2.Controls.Add(this.groupsRemoveButton);
            this.tabPage2.Controls.Add(this.groupsAddButton);
            this.tabPage2.Controls.Add(this.Groups);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1195, 830);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Groups and Permissions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(3, 2);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(58, 18);
            this.label37.TabIndex = 54;
            this.label37.Text = "Groups";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reqKickPowerNumUD);
            this.groupBox3.Controls.Add(this.kickPowerNumUD);
            this.groupBox3.Controls.Add(this.badgeColourComboBox);
            this.groupBox3.Controls.Add(this.badgeHiddenCheckBox);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.badgeCoverCheckBox);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.badgeNameTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(174, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1015, 128);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group Settings";
            // 
            // reqKickPowerNumUD
            // 
            this.reqKickPowerNumUD.Location = new System.Drawing.Point(644, 62);
            this.reqKickPowerNumUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.reqKickPowerNumUD.Name = "reqKickPowerNumUD";
            this.reqKickPowerNumUD.Size = new System.Drawing.Size(120, 20);
            this.reqKickPowerNumUD.TabIndex = 15;
            this.reqKickPowerNumUD.ValueChanged += new System.EventHandler(this.reqKickPowerNumUD_ValueChanged);
            // 
            // kickPowerNumUD
            // 
            this.kickPowerNumUD.Location = new System.Drawing.Point(644, 25);
            this.kickPowerNumUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kickPowerNumUD.Name = "kickPowerNumUD";
            this.kickPowerNumUD.Size = new System.Drawing.Size(120, 20);
            this.kickPowerNumUD.TabIndex = 14;
            this.kickPowerNumUD.ValueChanged += new System.EventHandler(this.kickPowerNumUD_ValueChanged);
            // 
            // badgeColourComboBox
            // 
            this.badgeColourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.badgeColourComboBox.FormattingEnabled = true;
            this.badgeColourComboBox.Items.AddRange(new object[] {
            "Pink",
            "Red",
            "Default",
            "Brown",
            "Silver",
            "Light Green",
            "Crimson",
            "Cyan",
            "Aqua",
            "Deep Pink",
            "Tomato",
            "Yellow",
            "Magenta",
            "Blue Green",
            "Orange",
            "Lime",
            "Green",
            "Emerald",
            "Carmine",
            "Nickel",
            "Mint",
            "Army Green",
            "Pumpkin"});
            this.badgeColourComboBox.Location = new System.Drawing.Point(148, 62);
            this.badgeColourComboBox.Name = "badgeColourComboBox";
            this.badgeColourComboBox.Size = new System.Drawing.Size(173, 21);
            this.badgeColourComboBox.TabIndex = 13;
            this.badgeColourComboBox.SelectedIndexChanged += new System.EventHandler(this.badgeColourComboBox_SelectedIndexChanged);
            // 
            // badgeHiddenCheckBox
            // 
            this.badgeHiddenCheckBox.AutoSize = true;
            this.badgeHiddenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badgeHiddenCheckBox.Location = new System.Drawing.Point(749, 98);
            this.badgeHiddenCheckBox.Name = "badgeHiddenCheckBox";
            this.badgeHiddenCheckBox.Size = new System.Drawing.Size(15, 14);
            this.badgeHiddenCheckBox.TabIndex = 12;
            this.badgeHiddenCheckBox.UseVisualStyleBackColor = true;
            this.badgeHiddenCheckBox.CheckedChanged += new System.EventHandler(this.badgeHiddenCheckBox_CheckedChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(431, 97);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(107, 13);
            this.label34.TabIndex = 11;
            this.label34.Text = "Group Badge Hidden";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(431, 62);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(139, 13);
            this.label35.TabIndex = 10;
            this.label35.Text = "Group Required Kick Power";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(431, 28);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(93, 13);
            this.label36.TabIndex = 9;
            this.label36.Text = "Group Kick Power";
            // 
            // badgeCoverCheckBox
            // 
            this.badgeCoverCheckBox.AutoSize = true;
            this.badgeCoverCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badgeCoverCheckBox.Location = new System.Drawing.Point(306, 97);
            this.badgeCoverCheckBox.Name = "badgeCoverCheckBox";
            this.badgeCoverCheckBox.Size = new System.Drawing.Size(15, 14);
            this.badgeCoverCheckBox.TabIndex = 6;
            this.badgeCoverCheckBox.UseVisualStyleBackColor = true;
            this.badgeCoverCheckBox.CheckedChanged += new System.EventHandler(this.badgeCoverCheckBox_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(25, 97);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(101, 13);
            this.label33.TabIndex = 5;
            this.label33.Text = "Group Badge Cover";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(25, 62);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Group Badge Colour";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(25, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "Group Badge";
            // 
            // badgeNameTextBox
            // 
            this.badgeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badgeNameTextBox.Location = new System.Drawing.Point(148, 25);
            this.badgeNameTextBox.MaxLength = 25;
            this.badgeNameTextBox.Name = "badgeNameTextBox";
            this.badgeNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.badgeNameTextBox.TabIndex = 0;
            this.badgeNameTextBox.TextChanged += new System.EventHandler(this.badgeNameTextBox_TextChanged);
            // 
            // permissionsBox
            // 
            this.permissionsBox.Controls.Add(this.label49);
            this.permissionsBox.Controls.Add(this.label43);
            this.permissionsBox.Controls.Add(this.label44);
            this.permissionsBox.Controls.Add(this.label45);
            this.permissionsBox.Controls.Add(this.ViewHiddenGlobalBadges);
            this.permissionsBox.Controls.Add(this.label46);
            this.permissionsBox.Controls.Add(this.AdminChat);
            this.permissionsBox.Controls.Add(this.label47);
            this.permissionsBox.Controls.Add(this.Announcer);
            this.permissionsBox.Controls.Add(this.label48);
            this.permissionsBox.Controls.Add(this.Effects);
            this.permissionsBox.Controls.Add(this.FriendlyFireDetectorImmunity);
            this.permissionsBox.Controls.Add(this.FriendlyFireDetectorTempDisable);
            this.permissionsBox.Controls.Add(this.deselectAllButton);
            this.permissionsBox.Controls.Add(this.selectAllButton);
            this.permissionsBox.Controls.Add(this.KickingAndShortTermBanning);
            this.permissionsBox.Controls.Add(this.label30);
            this.permissionsBox.Controls.Add(this.BanningUpToDay);
            this.permissionsBox.Controls.Add(this.label29);
            this.permissionsBox.Controls.Add(this.LongTermBanning);
            this.permissionsBox.Controls.Add(this.label28);
            this.permissionsBox.Controls.Add(this.ForceclassSelf);
            this.permissionsBox.Controls.Add(this.label27);
            this.permissionsBox.Controls.Add(this.ForceclassToSpectator);
            this.permissionsBox.Controls.Add(this.label26);
            this.permissionsBox.Controls.Add(this.GivingItems);
            this.permissionsBox.Controls.Add(this.AFKImmunity);
            this.permissionsBox.Controls.Add(this.ForceclassWithoutRestrictions);
            this.permissionsBox.Controls.Add(this.Noclip);
            this.permissionsBox.Controls.Add(this.WarheadEvents);
            this.permissionsBox.Controls.Add(this.PlayerSensitiveDataAccess);
            this.permissionsBox.Controls.Add(this.RespawnEvents);
            this.permissionsBox.Controls.Add(this.label25);
            this.permissionsBox.Controls.Add(this.RoundEvents);
            this.permissionsBox.Controls.Add(this.label24);
            this.permissionsBox.Controls.Add(this.GameplayData);
            this.permissionsBox.Controls.Add(this.SetGroup);
            this.permissionsBox.Controls.Add(this.label23);
            this.permissionsBox.Controls.Add(this.FacilityManagement);
            this.permissionsBox.Controls.Add(this.label22);
            this.permissionsBox.Controls.Add(this.Overwatch);
            this.permissionsBox.Controls.Add(this.label21);
            this.permissionsBox.Controls.Add(this.PlayersManagement);
            this.permissionsBox.Controls.Add(this.label20);
            this.permissionsBox.Controls.Add(this.PermissionsManagement);
            this.permissionsBox.Controls.Add(this.label19);
            this.permissionsBox.Controls.Add(this.ServerConsoleCommands);
            this.permissionsBox.Controls.Add(this.label18);
            this.permissionsBox.Controls.Add(this.ViewHiddenBadges);
            this.permissionsBox.Controls.Add(this.label17);
            this.permissionsBox.Controls.Add(this.Broadcasting);
            this.permissionsBox.Controls.Add(this.label16);
            this.permissionsBox.Controls.Add(this.ServerConfigs);
            this.permissionsBox.Controls.Add(this.label15);
            this.permissionsBox.Controls.Add(this.label8);
            this.permissionsBox.Controls.Add(this.label14);
            this.permissionsBox.Controls.Add(this.label9);
            this.permissionsBox.Controls.Add(this.label13);
            this.permissionsBox.Controls.Add(this.label10);
            this.permissionsBox.Controls.Add(this.label12);
            this.permissionsBox.Controls.Add(this.label11);
            this.permissionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionsBox.Location = new System.Drawing.Point(174, 141);
            this.permissionsBox.Name = "permissionsBox";
            this.permissionsBox.Size = new System.Drawing.Size(1015, 684);
            this.permissionsBox.TabIndex = 52;
            this.permissionsBox.TabStop = false;
            this.permissionsBox.Text = "Group Permissions";
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Location = new System.Drawing.Point(171, 637);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(139, 23);
            this.deselectAllButton.TabIndex = 53;
            this.deselectAllButton.Text = "Un-Tick All";
            this.deselectAllButton.UseVisualStyleBackColor = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(9, 636);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(139, 23);
            this.selectAllButton.TabIndex = 52;
            this.selectAllButton.Text = "Tick All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // KickingAndShortTermBanning
            // 
            this.KickingAndShortTermBanning.AutoSize = true;
            this.KickingAndShortTermBanning.Location = new System.Drawing.Point(6, 22);
            this.KickingAndShortTermBanning.Name = "KickingAndShortTermBanning";
            this.KickingAndShortTermBanning.Size = new System.Drawing.Size(15, 14);
            this.KickingAndShortTermBanning.TabIndex = 5;
            this.KickingAndShortTermBanning.UseVisualStyleBackColor = true;
            this.KickingAndShortTermBanning.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(354, 566);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(181, 26);
            this.label30.TabIndex = 51;
            this.label30.Text = "AFK Immunity\r\nAllows you to bypass the AFK kicker.";
            // 
            // BanningUpToDay
            // 
            this.BanningUpToDay.AutoSize = true;
            this.BanningUpToDay.Location = new System.Drawing.Point(6, 78);
            this.BanningUpToDay.Name = "BanningUpToDay";
            this.BanningUpToDay.Size = new System.Drawing.Size(15, 14);
            this.BanningUpToDay.TabIndex = 6;
            this.BanningUpToDay.UseVisualStyleBackColor = true;
            this.BanningUpToDay.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(354, 518);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(190, 26);
            this.label29.TabIndex = 50;
            this.label29.Text = "Noclip\r\nAllows you to use the noclip command.";
            // 
            // LongTermBanning
            // 
            this.LongTermBanning.AutoSize = true;
            this.LongTermBanning.Location = new System.Drawing.Point(6, 133);
            this.LongTermBanning.Name = "LongTermBanning";
            this.LongTermBanning.Size = new System.Drawing.Size(15, 14);
            this.LongTermBanning.TabIndex = 7;
            this.LongTermBanning.UseVisualStyleBackColor = true;
            this.LongTermBanning.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(354, 458);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(297, 39);
            this.label28.TabIndex = 49;
            this.label28.Text = "Player sensitive data access\r\nAllows you to see sensitive player data such as a p" +
    "layers auth\r\n token and IP in the request section of remoteadmin.";
            // 
            // ForceclassSelf
            // 
            this.ForceclassSelf.AutoSize = true;
            this.ForceclassSelf.Location = new System.Drawing.Point(6, 186);
            this.ForceclassSelf.Name = "ForceclassSelf";
            this.ForceclassSelf.Size = new System.Drawing.Size(15, 14);
            this.ForceclassSelf.TabIndex = 8;
            this.ForceclassSelf.UseVisualStyleBackColor = true;
            this.ForceclassSelf.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(354, 406);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(174, 26);
            this.label27.TabIndex = 48;
            this.label27.Text = "Broadcasting\r\nAllows you to use the bc command.";
            // 
            // ForceclassToSpectator
            // 
            this.ForceclassToSpectator.AutoSize = true;
            this.ForceclassToSpectator.Location = new System.Drawing.Point(6, 240);
            this.ForceclassToSpectator.Name = "ForceclassToSpectator";
            this.ForceclassToSpectator.Size = new System.Drawing.Size(15, 14);
            this.ForceclassToSpectator.TabIndex = 9;
            this.ForceclassToSpectator.UseVisualStyleBackColor = true;
            this.ForceclassToSpectator.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(354, 353);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(330, 26);
            this.label26.TabIndex = 47;
            this.label26.Text = "Server Configs\r\nAllows you to edit config_gameplay settings from within remoteadm" +
    "in.";
            // 
            // GivingItems
            // 
            this.GivingItems.AutoSize = true;
            this.GivingItems.Location = new System.Drawing.Point(6, 361);
            this.GivingItems.Name = "GivingItems";
            this.GivingItems.Size = new System.Drawing.Size(15, 14);
            this.GivingItems.TabIndex = 10;
            this.GivingItems.UseVisualStyleBackColor = true;
            this.GivingItems.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // AFKImmunity
            // 
            this.AFKImmunity.AutoSize = true;
            this.AFKImmunity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFKImmunity.Location = new System.Drawing.Point(333, 569);
            this.AFKImmunity.Name = "AFKImmunity";
            this.AFKImmunity.Size = new System.Drawing.Size(15, 14);
            this.AFKImmunity.TabIndex = 46;
            this.AFKImmunity.UseVisualStyleBackColor = true;
            this.AFKImmunity.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // ForceclassWithoutRestrictions
            // 
            this.ForceclassWithoutRestrictions.AutoSize = true;
            this.ForceclassWithoutRestrictions.Location = new System.Drawing.Point(6, 308);
            this.ForceclassWithoutRestrictions.Name = "ForceclassWithoutRestrictions";
            this.ForceclassWithoutRestrictions.Size = new System.Drawing.Size(15, 14);
            this.ForceclassWithoutRestrictions.TabIndex = 11;
            this.ForceclassWithoutRestrictions.UseVisualStyleBackColor = true;
            this.ForceclassWithoutRestrictions.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // Noclip
            // 
            this.Noclip.AutoSize = true;
            this.Noclip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noclip.Location = new System.Drawing.Point(333, 521);
            this.Noclip.Name = "Noclip";
            this.Noclip.Size = new System.Drawing.Size(15, 14);
            this.Noclip.TabIndex = 45;
            this.Noclip.UseVisualStyleBackColor = true;
            this.Noclip.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // WarheadEvents
            // 
            this.WarheadEvents.AutoSize = true;
            this.WarheadEvents.Location = new System.Drawing.Point(6, 417);
            this.WarheadEvents.Name = "WarheadEvents";
            this.WarheadEvents.Size = new System.Drawing.Size(15, 14);
            this.WarheadEvents.TabIndex = 12;
            this.WarheadEvents.UseVisualStyleBackColor = true;
            this.WarheadEvents.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // PlayerSensitiveDataAccess
            // 
            this.PlayerSensitiveDataAccess.AutoSize = true;
            this.PlayerSensitiveDataAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSensitiveDataAccess.Location = new System.Drawing.Point(333, 461);
            this.PlayerSensitiveDataAccess.Name = "PlayerSensitiveDataAccess";
            this.PlayerSensitiveDataAccess.Size = new System.Drawing.Size(15, 14);
            this.PlayerSensitiveDataAccess.TabIndex = 44;
            this.PlayerSensitiveDataAccess.UseVisualStyleBackColor = true;
            this.PlayerSensitiveDataAccess.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // RespawnEvents
            // 
            this.RespawnEvents.AutoSize = true;
            this.RespawnEvents.Location = new System.Drawing.Point(6, 466);
            this.RespawnEvents.Name = "RespawnEvents";
            this.RespawnEvents.Size = new System.Drawing.Size(15, 14);
            this.RespawnEvents.TabIndex = 13;
            this.RespawnEvents.UseVisualStyleBackColor = true;
            this.RespawnEvents.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(354, 302);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(313, 26);
            this.label25.TabIndex = 42;
            this.label25.Text = "View hidden badges\r\nAllows you to view the badges of people with their badge hidd" +
    "en.";
            // 
            // RoundEvents
            // 
            this.RoundEvents.AutoSize = true;
            this.RoundEvents.Location = new System.Drawing.Point(6, 519);
            this.RoundEvents.Name = "RoundEvents";
            this.RoundEvents.Size = new System.Drawing.Size(15, 14);
            this.RoundEvents.TabIndex = 14;
            this.RoundEvents.UseVisualStyleBackColor = true;
            this.RoundEvents.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(354, 239);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(285, 52);
            this.label24.TabIndex = 41;
            this.label24.Text = "Server Console Commands\r\nAllows you to execute commands as the server console by " +
    "\r\nprefixing your command with /\r\nBE CAREFUL WITH WHO YOU GIVE THIS PERM TO.";
            // 
            // GameplayData
            // 
            this.GameplayData.AutoSize = true;
            this.GameplayData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameplayData.Location = new System.Drawing.Point(333, 620);
            this.GameplayData.Name = "GameplayData";
            this.GameplayData.Size = new System.Drawing.Size(15, 14);
            this.GameplayData.TabIndex = 15;
            this.GameplayData.UseVisualStyleBackColor = true;
            this.GameplayData.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // SetGroup
            // 
            this.SetGroup.AutoSize = true;
            this.SetGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetGroup.Location = new System.Drawing.Point(6, 568);
            this.SetGroup.Name = "SetGroup";
            this.SetGroup.Size = new System.Drawing.Size(15, 14);
            this.SetGroup.TabIndex = 16;
            this.SetGroup.UseVisualStyleBackColor = true;
            this.SetGroup.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(354, 188);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(227, 39);
            this.label23.TabIndex = 40;
            this.label23.Text = "Permission Management\r\nAllows you to use the PM command ingame to \r\nmanipulate pe" +
    "rmissions.";
            // 
            // FacilityManagement
            // 
            this.FacilityManagement.AutoSize = true;
            this.FacilityManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityManagement.Location = new System.Drawing.Point(333, 74);
            this.FacilityManagement.Name = "FacilityManagement";
            this.FacilityManagement.Size = new System.Drawing.Size(15, 14);
            this.FacilityManagement.TabIndex = 17;
            this.FacilityManagement.UseVisualStyleBackColor = true;
            this.FacilityManagement.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(354, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(307, 39);
            this.label22.TabIndex = 39;
            this.label22.Text = "Player Management\r\nAllows you to set players HP, enable/disable god mode, telepor" +
    "t\r\nplayers, mute/unmute players, and timeout/reset the intercom.";
            // 
            // Overwatch
            // 
            this.Overwatch.AutoSize = true;
            this.Overwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overwatch.Location = new System.Drawing.Point(333, 19);
            this.Overwatch.Name = "Overwatch";
            this.Overwatch.Size = new System.Drawing.Size(15, 14);
            this.Overwatch.TabIndex = 18;
            this.Overwatch.UseVisualStyleBackColor = true;
            this.Overwatch.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(354, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(286, 39);
            this.label21.TabIndex = 38;
            this.label21.Text = "Facility Management\r\nAllows you to use bypass, door management, and intercom \r\nti" +
    "meout/reset commands.";
            // 
            // PlayersManagement
            // 
            this.PlayersManagement.AutoSize = true;
            this.PlayersManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersManagement.Location = new System.Drawing.Point(333, 130);
            this.PlayersManagement.Name = "PlayersManagement";
            this.PlayersManagement.Size = new System.Drawing.Size(15, 14);
            this.PlayersManagement.TabIndex = 19;
            this.PlayersManagement.UseVisualStyleBackColor = true;
            this.PlayersManagement.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(354, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(253, 26);
            this.label20.TabIndex = 37;
            this.label20.Text = "Overwatch\r\nAllows you to make use of the overwatch command.";
            // 
            // PermissionsManagement
            // 
            this.PermissionsManagement.AutoSize = true;
            this.PermissionsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermissionsManagement.Location = new System.Drawing.Point(333, 191);
            this.PermissionsManagement.Name = "PermissionsManagement";
            this.PermissionsManagement.Size = new System.Drawing.Size(15, 14);
            this.PermissionsManagement.TabIndex = 20;
            this.PermissionsManagement.UseVisualStyleBackColor = true;
            this.PermissionsManagement.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(354, 620);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(239, 39);
            this.label19.TabIndex = 36;
            this.label19.Text = "Gameplay Data\r\nAllows you to data such as HP and class with the\r\ndata request but" +
    "ton.";
            // 
            // ServerConsoleCommands
            // 
            this.ServerConsoleCommands.AutoSize = true;
            this.ServerConsoleCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerConsoleCommands.Location = new System.Drawing.Point(333, 243);
            this.ServerConsoleCommands.Name = "ServerConsoleCommands";
            this.ServerConsoleCommands.Size = new System.Drawing.Size(15, 14);
            this.ServerConsoleCommands.TabIndex = 21;
            this.ServerConsoleCommands.UseVisualStyleBackColor = true;
            this.ServerConsoleCommands.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 567);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(301, 39);
            this.label18.TabIndex = 35;
            this.label18.Text = "Set Group\r\nAllows you to change players permission group ingame via the \r\npm comm" +
    "and.";
            // 
            // ViewHiddenBadges
            // 
            this.ViewHiddenBadges.AutoSize = true;
            this.ViewHiddenBadges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewHiddenBadges.Location = new System.Drawing.Point(333, 305);
            this.ViewHiddenBadges.Name = "ViewHiddenBadges";
            this.ViewHiddenBadges.Size = new System.Drawing.Size(15, 14);
            this.ViewHiddenBadges.TabIndex = 22;
            this.ViewHiddenBadges.UseVisualStyleBackColor = true;
            this.ViewHiddenBadges.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(252, 26);
            this.label17.TabIndex = 34;
            this.label17.Text = "Round Events\r\nAllows you to force start, lock, and restart the round.";
            // 
            // Broadcasting
            // 
            this.Broadcasting.AutoSize = true;
            this.Broadcasting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Broadcasting.Location = new System.Drawing.Point(333, 409);
            this.Broadcasting.Name = "Broadcasting";
            this.Broadcasting.Size = new System.Drawing.Size(15, 14);
            this.Broadcasting.TabIndex = 23;
            this.Broadcasting.UseVisualStyleBackColor = true;
            this.Broadcasting.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 463);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 26);
            this.label16.TabIndex = 33;
            this.label16.Text = "Respawn Events\r\nAllows you to force an MTF or CI spawn.";
            // 
            // ServerConfigs
            // 
            this.ServerConfigs.AutoSize = true;
            this.ServerConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerConfigs.Location = new System.Drawing.Point(333, 356);
            this.ServerConfigs.Name = "ServerConfigs";
            this.ServerConfigs.Size = new System.Drawing.Size(15, 14);
            this.ServerConfigs.TabIndex = 24;
            this.ServerConfigs.UseVisualStyleBackColor = true;
            this.ServerConfigs.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 415);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 26);
            this.label15.TabIndex = 32;
            this.label15.Text = "Warhead Events\r\nAllows you start stop and detonate the warhead.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "Kicking and short term banning\r\nAllows kicking and banning up to 1 hour.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 26);
            this.label14.TabIndex = 31;
            this.label14.Text = "Give items\r\nAllows you to spawn items.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Banning up to one day\r\nAllows banning up to 24hrs.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 26);
            this.label13.TabIndex = 30;
            this.label13.Text = "Forceclass without restrictions\r\nAllows you to forceclass others to any class.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 26);
            this.label10.TabIndex = 27;
            this.label10.Text = "Long term banning\r\nAllows banning over 24hrs.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 26);
            this.label12.TabIndex = 29;
            this.label12.Text = "Forceclass to spectator\r\nAllows you to forceclass others to spectator only.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 26);
            this.label11.TabIndex = 28;
            this.label11.Text = "Forceclass self\r\nAllows you to forceclass yourself.";
            // 
            // groupsRemoveButton
            // 
            this.groupsRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsRemoveButton.Location = new System.Drawing.Point(7, 801);
            this.groupsRemoveButton.Name = "groupsRemoveButton";
            this.groupsRemoveButton.Size = new System.Drawing.Size(161, 22);
            this.groupsRemoveButton.TabIndex = 2;
            this.groupsRemoveButton.Text = "Remove Group";
            this.groupsRemoveButton.UseVisualStyleBackColor = true;
            this.groupsRemoveButton.Click += new System.EventHandler(this.GroupsRemoveButton_Click);
            // 
            // groupsAddButton
            // 
            this.groupsAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsAddButton.Location = new System.Drawing.Point(7, 778);
            this.groupsAddButton.Name = "groupsAddButton";
            this.groupsAddButton.Size = new System.Drawing.Size(161, 22);
            this.groupsAddButton.TabIndex = 1;
            this.groupsAddButton.Text = "New Group";
            this.groupsAddButton.UseVisualStyleBackColor = true;
            this.groupsAddButton.Click += new System.EventHandler(this.GroupsAddButton_Click);
            // 
            // Groups
            // 
            this.Groups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groups.FormattingEnabled = true;
            this.Groups.ItemHeight = 16;
            this.Groups.Location = new System.Drawing.Point(6, 25);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(162, 740);
            this.Groups.TabIndex = 0;
            this.Groups.SelectedIndexChanged += new System.EventHandler(this.Groups_SelectedIndexChanged);
            this.Groups.DoubleClick += new System.EventHandler(this.Groups_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.steamUrlLabel);
            this.tabPage3.Controls.Add(this.showSteamInfoCheckBox);
            this.tabPage3.Controls.Add(this.enableSteamInfo);
            this.tabPage3.Controls.Add(this.steamNameLabel);
            this.tabPage3.Controls.Add(this.changeGroupCombo);
            this.tabPage3.Controls.Add(this.changeUserGroup);
            this.tabPage3.Controls.Add(this.removeUser);
            this.tabPage3.Controls.Add(this.addUser);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.label38);
            this.tabPage3.Controls.Add(this.assignmentGroupsCombo);
            this.tabPage3.Controls.Add(this.steamAvatar);
            this.tabPage3.Controls.Add(this.Users);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1195, 830);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Role Assignment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // steamUrlLabel
            // 
            this.steamUrlLabel.AutoSize = true;
            this.steamUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamUrlLabel.Location = new System.Drawing.Point(199, 514);
            this.steamUrlLabel.Name = "steamUrlLabel";
            this.steamUrlLabel.Size = new System.Drawing.Size(99, 24);
            this.steamUrlLabel.TabIndex = 67;
            this.steamUrlLabel.TabStop = true;
            this.steamUrlLabel.Text = "SteamURL";
            this.steamUrlLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.steamUrlLabel_LinkClicked);
            // 
            // showSteamInfoCheckBox
            // 
            this.showSteamInfoCheckBox.AutoSize = true;
            this.showSteamInfoCheckBox.Location = new System.Drawing.Point(204, 256);
            this.showSteamInfoCheckBox.Name = "showSteamInfoCheckBox";
            this.showSteamInfoCheckBox.Size = new System.Drawing.Size(220, 17);
            this.showSteamInfoCheckBox.TabIndex = 66;
            this.showSteamInfoCheckBox.Text = "Show Steam Info. (Will slow things down)";
            this.showSteamInfoCheckBox.UseVisualStyleBackColor = true;
            this.showSteamInfoCheckBox.Visible = false;
            this.showSteamInfoCheckBox.CheckedChanged += new System.EventHandler(this.showSteamInfoCheckBox_CheckedChanged);
            // 
            // enableSteamInfo
            // 
            this.enableSteamInfo.Location = new System.Drawing.Point(204, 253);
            this.enableSteamInfo.Name = "enableSteamInfo";
            this.enableSteamInfo.Size = new System.Drawing.Size(203, 23);
            this.enableSteamInfo.TabIndex = 65;
            this.enableSteamInfo.Text = "Enable Steam Info";
            this.enableSteamInfo.UseVisualStyleBackColor = true;
            this.enableSteamInfo.Click += new System.EventHandler(this.enableSteamInfo_Click);
            // 
            // steamNameLabel
            // 
            this.steamNameLabel.AutoSize = true;
            this.steamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamNameLabel.Location = new System.Drawing.Point(199, 488);
            this.steamNameLabel.Name = "steamNameLabel";
            this.steamNameLabel.Size = new System.Drawing.Size(119, 24);
            this.steamNameLabel.TabIndex = 63;
            this.steamNameLabel.Text = "Steam Name";
            // 
            // changeGroupCombo
            // 
            this.changeGroupCombo.CausesValidation = false;
            this.changeGroupCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeGroupCombo.FormattingEnabled = true;
            this.changeGroupCombo.Location = new System.Drawing.Point(204, 154);
            this.changeGroupCombo.Name = "changeGroupCombo";
            this.changeGroupCombo.Size = new System.Drawing.Size(203, 21);
            this.changeGroupCombo.TabIndex = 60;
            // 
            // changeUserGroup
            // 
            this.changeUserGroup.Location = new System.Drawing.Point(204, 183);
            this.changeUserGroup.Name = "changeUserGroup";
            this.changeUserGroup.Size = new System.Drawing.Size(203, 23);
            this.changeUserGroup.TabIndex = 59;
            this.changeUserGroup.Text = "Change Selected User Selected Role";
            this.changeUserGroup.UseVisualStyleBackColor = true;
            this.changeUserGroup.Click += new System.EventHandler(this.changeUserGroup_Click);
            // 
            // removeUser
            // 
            this.removeUser.Location = new System.Drawing.Point(204, 83);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(203, 23);
            this.removeUser.TabIndex = 58;
            this.removeUser.Text = "Remove selected users role";
            this.removeUser.UseVisualStyleBackColor = true;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(204, 54);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(203, 23);
            this.addUser.TabIndex = 57;
            this.addUser.Text = "Add a user to this role";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(200, 2);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(50, 18);
            this.label39.TabIndex = 56;
            this.label39.Text = "Group";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(3, 2);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 18);
            this.label38.TabIndex = 55;
            this.label38.Text = "Users";
            // 
            // assignmentGroupsCombo
            // 
            this.assignmentGroupsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignmentGroupsCombo.FormattingEnabled = true;
            this.assignmentGroupsCombo.Location = new System.Drawing.Point(204, 25);
            this.assignmentGroupsCombo.Name = "assignmentGroupsCombo";
            this.assignmentGroupsCombo.Size = new System.Drawing.Size(203, 21);
            this.assignmentGroupsCombo.TabIndex = 2;
            this.assignmentGroupsCombo.SelectedIndexChanged += new System.EventHandler(this.assignmentGroupsCombo_SelectedIndexChanged);
            // 
            // steamAvatar
            // 
            this.steamAvatar.ErrorImage = global::OmicronMain.Properties.Resources.omipilogo;
            this.steamAvatar.Image = global::OmicronMain.Properties.Resources.omipilogo;
            this.steamAvatar.InitialImage = global::OmicronMain.Properties.Resources.omipilogo;
            this.steamAvatar.Location = new System.Drawing.Point(204, 282);
            this.steamAvatar.Name = "steamAvatar";
            this.steamAvatar.Size = new System.Drawing.Size(203, 203);
            this.steamAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.steamAvatar.TabIndex = 61;
            this.steamAvatar.TabStop = false;
            // 
            // Users
            // 
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 16;
            this.Users.Location = new System.Drawing.Point(6, 25);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(192, 788);
            this.Users.TabIndex = 1;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // saveCFGButton
            // 
            this.saveCFGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCFGButton.Location = new System.Drawing.Point(1044, 865);
            this.saveCFGButton.Name = "saveCFGButton";
            this.saveCFGButton.Size = new System.Drawing.Size(157, 24);
            this.saveCFGButton.TabIndex = 4;
            this.saveCFGButton.Text = "Save Config";
            this.saveCFGButton.UseVisualStyleBackColor = true;
            this.saveCFGButton.Click += new System.EventHandler(this.saveCFGButton_Click);
            // 
            // startAgainButton
            // 
            this.startAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAgainButton.Location = new System.Drawing.Point(872, 865);
            this.startAgainButton.Name = "startAgainButton";
            this.startAgainButton.Size = new System.Drawing.Size(157, 24);
            this.startAgainButton.TabIndex = 5;
            this.startAgainButton.Text = "Start Again";
            this.startAgainButton.UseVisualStyleBackColor = true;
            this.startAgainButton.Click += new System.EventHandler(this.startAgainButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "config_remoteadmin.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "config_remoteadmin";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OmicronMain.Properties.Resources.omicronpifull;
            this.pictureBox1.Location = new System.Drawing.Point(12, 865);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1123, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(709, 299);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(232, 39);
            this.label43.TabIndex = 65;
            this.label43.Text = "Friendly Fire Detector Temp Disable\r\nAllows the user access to the command to tem" +
    "p\r\ndisable the friendly fire detectoe system.";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(709, 236);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(232, 39);
            this.label44.TabIndex = 64;
            this.label44.Text = "Friendly Fire Detector Immunity\r\nGrants the user immunity to punishment from the\r" +
    "\nfriendly fire detector.";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(709, 185);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(245, 26);
            this.label45.TabIndex = 63;
            this.label45.Text = "Effects\r\nAllows the user access to status effect commands.";
            // 
            // ViewHiddenGlobalBadges
            // 
            this.ViewHiddenGlobalBadges.AutoSize = true;
            this.ViewHiddenGlobalBadges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewHiddenGlobalBadges.Location = new System.Drawing.Point(688, 71);
            this.ViewHiddenGlobalBadges.Name = "ViewHiddenGlobalBadges";
            this.ViewHiddenGlobalBadges.Size = new System.Drawing.Size(15, 14);
            this.ViewHiddenGlobalBadges.TabIndex = 54;
            this.ViewHiddenGlobalBadges.UseVisualStyleBackColor = true;
            this.ViewHiddenGlobalBadges.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(709, 124);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(227, 26);
            this.label46.TabIndex = 62;
            this.label46.Text = "Announcer\r\nAllows the user access to intercom commands.";
            // 
            // AdminChat
            // 
            this.AdminChat.AutoSize = true;
            this.AdminChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminChat.Location = new System.Drawing.Point(688, 16);
            this.AdminChat.Name = "AdminChat";
            this.AdminChat.Size = new System.Drawing.Size(15, 14);
            this.AdminChat.TabIndex = 55;
            this.AdminChat.UseVisualStyleBackColor = true;
            this.AdminChat.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(709, 68);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(272, 39);
            this.label47.TabIndex = 61;
            this.label47.Text = "View Hidden Global Badges\r\nAllows the user to see the global badges that have bee" +
    "n\r\n hidden such as a hidden global mod badge.";
            // 
            // Announcer
            // 
            this.Announcer.AutoSize = true;
            this.Announcer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Announcer.Location = new System.Drawing.Point(688, 127);
            this.Announcer.Name = "Announcer";
            this.Announcer.Size = new System.Drawing.Size(15, 14);
            this.Announcer.TabIndex = 56;
            this.Announcer.UseVisualStyleBackColor = true;
            this.Announcer.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(709, 14);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(254, 39);
            this.label48.TabIndex = 60;
            this.label48.Text = "Admin Chat\r\nAllows the user to see messages sent with the admin\r\nbroadcast comman" +
    "d.";
            // 
            // Effects
            // 
            this.Effects.AutoSize = true;
            this.Effects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Effects.Location = new System.Drawing.Point(688, 188);
            this.Effects.Name = "Effects";
            this.Effects.Size = new System.Drawing.Size(15, 14);
            this.Effects.TabIndex = 57;
            this.Effects.UseVisualStyleBackColor = true;
            this.Effects.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // FriendlyFireDetectorImmunity
            // 
            this.FriendlyFireDetectorImmunity.AutoSize = true;
            this.FriendlyFireDetectorImmunity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendlyFireDetectorImmunity.Location = new System.Drawing.Point(688, 240);
            this.FriendlyFireDetectorImmunity.Name = "FriendlyFireDetectorImmunity";
            this.FriendlyFireDetectorImmunity.Size = new System.Drawing.Size(15, 14);
            this.FriendlyFireDetectorImmunity.TabIndex = 58;
            this.FriendlyFireDetectorImmunity.UseVisualStyleBackColor = true;
            this.FriendlyFireDetectorImmunity.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // FriendlyFireDetectorTempDisable
            // 
            this.FriendlyFireDetectorTempDisable.AutoSize = true;
            this.FriendlyFireDetectorTempDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendlyFireDetectorTempDisable.Location = new System.Drawing.Point(688, 302);
            this.FriendlyFireDetectorTempDisable.Name = "FriendlyFireDetectorTempDisable";
            this.FriendlyFireDetectorTempDisable.Size = new System.Drawing.Size(15, 14);
            this.FriendlyFireDetectorTempDisable.TabIndex = 59;
            this.FriendlyFireDetectorTempDisable.UseVisualStyleBackColor = true;
            this.FriendlyFireDetectorTempDisable.CheckedChanged += new System.EventHandler(this.permUpdate);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(685, 471);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(302, 26);
            this.label49.TabIndex = 66;
            this.label49.Text = "Notice a missing config? Please notify Takail#6969 \r\non Discord. Thanks :)\r\n";
            // 
            // OmicronPiMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 894);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startAgainButton);
            this.Controls.Add(this.saveCFGButton);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OmicronPiMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Omicron Pi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OmicronPiMainWindow_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqKickPowerNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickPowerNumUD)).EndInit();
            this.permissionsBox.ResumeLayout(false);
            this.permissionsBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steamAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox enable_banteam_reserved_slots;
        private System.Windows.Forms.CheckBox enable_banteam_access;
        private System.Windows.Forms.CheckBox enable_manager_access;
        private System.Windows.Forms.CheckBox enable_staff_access;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox enable_banteam_bypass_geoblocking;
        private System.Windows.Forms.ListBox Groups;
        private System.Windows.Forms.Button groupsRemoveButton;
        private System.Windows.Forms.Button groupsAddButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ServerConfigs;
        private System.Windows.Forms.CheckBox Broadcasting;
        private System.Windows.Forms.CheckBox ViewHiddenBadges;
        private System.Windows.Forms.CheckBox ServerConsoleCommands;
        private System.Windows.Forms.CheckBox PermissionsManagement;
        private System.Windows.Forms.CheckBox PlayersManagement;
        private System.Windows.Forms.CheckBox Overwatch;
        private System.Windows.Forms.CheckBox FacilityManagement;
        private System.Windows.Forms.CheckBox SetGroup;
        private System.Windows.Forms.CheckBox GameplayData;
        private System.Windows.Forms.CheckBox RoundEvents;
        private System.Windows.Forms.CheckBox RespawnEvents;
        private System.Windows.Forms.CheckBox WarheadEvents;
        private System.Windows.Forms.CheckBox ForceclassWithoutRestrictions;
        private System.Windows.Forms.CheckBox GivingItems;
        private System.Windows.Forms.CheckBox ForceclassToSpectator;
        private System.Windows.Forms.CheckBox ForceclassSelf;
        private System.Windows.Forms.CheckBox LongTermBanning;
        private System.Windows.Forms.CheckBox BanningUpToDay;
        private System.Windows.Forms.CheckBox KickingAndShortTermBanning;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox permissionsBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox AFKImmunity;
        private System.Windows.Forms.CheckBox Noclip;
        private System.Windows.Forms.CheckBox PlayerSensitiveDataAccess;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox badgeHiddenCheckBox;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox badgeCoverCheckBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox badgeNameTextBox;
        private System.Windows.Forms.ComboBox badgeColourComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveCFGButton;
        private System.Windows.Forms.Button startAgainButton;
        private System.Windows.Forms.NumericUpDown reqKickPowerNumUD;
        private System.Windows.Forms.NumericUpDown kickPowerNumUD;
        private ListBox Users;
        private ComboBox assignmentGroupsCombo;
        private Label label37;
        private Label label38;
        private Label label39;
        private ComboBox changeGroupCombo;
        private Button changeUserGroup;
        private Button removeUser;
        private Button addUser;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button deselectAllButton;
        private Button selectAllButton;
        private TabPage generalTabPage;
        private Label label42;
        private Label label41;
        private Label label40;
        private Button createNewConfigButton;
        private Button openExistingConfigButton;
        private PictureBox steamAvatar;
        private Label steamNameLabel;
        private Button enableSteamInfo;
        private CheckBox showSteamInfoCheckBox;
        private LinkLabel steamUrlLabel;
        private Button backButton;
        private Label label49;
        private Label label43;
        private Label label44;
        private Label label45;
        private CheckBox ViewHiddenGlobalBadges;
        private Label label46;
        private CheckBox AdminChat;
        private Label label47;
        private CheckBox Announcer;
        private Label label48;
        private CheckBox Effects;
        private CheckBox FriendlyFireDetectorImmunity;
        private CheckBox FriendlyFireDetectorTempDisable;
    }
}

