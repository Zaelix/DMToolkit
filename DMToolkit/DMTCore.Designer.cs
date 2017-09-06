namespace DMToolkit
{
    partial class DMTool
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
            this.combatButton = new System.Windows.Forms.Button();
            this.combatPanel = new System.Windows.Forms.Panel();
            this.addToTrackerWithRollsButton = new System.Windows.Forms.Button();
            this.removeFromTrackerButton = new System.Windows.Forms.Button();
            this.willpowerAtrInput = new System.Windows.Forms.NumericUpDown();
            this.willpowerLabel = new System.Windows.Forms.Label();
            this.logicAtrInput = new System.Windows.Forms.NumericUpDown();
            this.logicLabel = new System.Windows.Forms.Label();
            this.intuitionAtrInput = new System.Windows.Forms.NumericUpDown();
            this.intuitionLabel = new System.Windows.Forms.Label();
            this.charismaAtrInput = new System.Windows.Forms.NumericUpDown();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.strengthAtrInput = new System.Windows.Forms.NumericUpDown();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.reactionAtrInput = new System.Windows.Forms.NumericUpDown();
            this.reactionLabel = new System.Windows.Forms.Label();
            this.agilityAtrInput = new System.Windows.Forms.NumericUpDown();
            this.agilityLabel = new System.Windows.Forms.Label();
            this.bodyAtrInput = new System.Windows.Forms.NumericUpDown();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.initTrackerSortButton = new System.Windows.Forms.Button();
            this.delCharButton = new System.Windows.Forms.Button();
            this.editCharButton = new System.Windows.Forms.Button();
            this.charListLabel = new System.Windows.Forms.Label();
            this.charInitLabel = new System.Windows.Forms.Label();
            this.charInitBox = new System.Windows.Forms.NumericUpDown();
            this.createCharButton = new System.Windows.Forms.Button();
            this.charNameBox = new System.Windows.Forms.TextBox();
            this.charListBox = new System.Windows.Forms.ListBox();
            this.addToTrackerButton = new System.Windows.Forms.Button();
            this.initTracker = new System.Windows.Forms.ListView();
            this.InitiativeTrackerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editInitiativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initiativeTrackerLabel = new System.Windows.Forms.Label();
            this.editInitPanel = new System.Windows.Forms.Panel();
            this.editInitLabel = new System.Windows.Forms.Label();
            this.EditInitOKButton = new System.Windows.Forms.Button();
            this.EditInitCANCELButton = new System.Windows.Forms.Button();
            this.EditInitiativeInputBox = new System.Windows.Forms.NumericUpDown();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.combatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.willpowerAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intuitionAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactionAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyAtrInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charInitBox)).BeginInit();
            this.InitiativeTrackerContextMenu.SuspendLayout();
            this.editInitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditInitiativeInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // combatButton
            // 
            this.combatButton.Location = new System.Drawing.Point(13, 13);
            this.combatButton.Name = "combatButton";
            this.combatButton.Size = new System.Drawing.Size(75, 23);
            this.combatButton.TabIndex = 0;
            this.combatButton.Text = "Combat";
            this.combatButton.UseVisualStyleBackColor = true;
            this.combatButton.Click += new System.EventHandler(this.combatButton_Click);
            // 
            // combatPanel
            // 
            this.combatPanel.Controls.Add(this.EndTurnButton);
            this.combatPanel.Controls.Add(this.editInitPanel);
            this.combatPanel.Controls.Add(this.addToTrackerWithRollsButton);
            this.combatPanel.Controls.Add(this.removeFromTrackerButton);
            this.combatPanel.Controls.Add(this.willpowerAtrInput);
            this.combatPanel.Controls.Add(this.willpowerLabel);
            this.combatPanel.Controls.Add(this.logicAtrInput);
            this.combatPanel.Controls.Add(this.logicLabel);
            this.combatPanel.Controls.Add(this.intuitionAtrInput);
            this.combatPanel.Controls.Add(this.intuitionLabel);
            this.combatPanel.Controls.Add(this.charismaAtrInput);
            this.combatPanel.Controls.Add(this.charismaLabel);
            this.combatPanel.Controls.Add(this.strengthAtrInput);
            this.combatPanel.Controls.Add(this.strengthLabel);
            this.combatPanel.Controls.Add(this.reactionAtrInput);
            this.combatPanel.Controls.Add(this.reactionLabel);
            this.combatPanel.Controls.Add(this.agilityAtrInput);
            this.combatPanel.Controls.Add(this.agilityLabel);
            this.combatPanel.Controls.Add(this.bodyAtrInput);
            this.combatPanel.Controls.Add(this.bodyLabel);
            this.combatPanel.Controls.Add(this.initTrackerSortButton);
            this.combatPanel.Controls.Add(this.delCharButton);
            this.combatPanel.Controls.Add(this.editCharButton);
            this.combatPanel.Controls.Add(this.charListLabel);
            this.combatPanel.Controls.Add(this.charInitLabel);
            this.combatPanel.Controls.Add(this.charInitBox);
            this.combatPanel.Controls.Add(this.createCharButton);
            this.combatPanel.Controls.Add(this.charNameBox);
            this.combatPanel.Controls.Add(this.charListBox);
            this.combatPanel.Controls.Add(this.addToTrackerButton);
            this.combatPanel.Controls.Add(this.initTracker);
            this.combatPanel.Controls.Add(this.initiativeTrackerLabel);
            this.combatPanel.Location = new System.Drawing.Point(13, 43);
            this.combatPanel.Name = "combatPanel";
            this.combatPanel.Size = new System.Drawing.Size(1092, 571);
            this.combatPanel.TabIndex = 1;
            // 
            // addToTrackerWithRollsButton
            // 
            this.addToTrackerWithRollsButton.Location = new System.Drawing.Point(287, 101);
            this.addToTrackerWithRollsButton.Name = "addToTrackerWithRollsButton";
            this.addToTrackerWithRollsButton.Size = new System.Drawing.Size(84, 23);
            this.addToTrackerWithRollsButton.TabIndex = 30;
            this.addToTrackerWithRollsButton.Text = "<< Roll <<";
            this.addToTrackerWithRollsButton.UseVisualStyleBackColor = true;
            this.addToTrackerWithRollsButton.Click += new System.EventHandler(this.addToTrackerWithRollsButton_Click);
            // 
            // removeFromTrackerButton
            // 
            this.removeFromTrackerButton.Location = new System.Drawing.Point(287, 127);
            this.removeFromTrackerButton.Name = "removeFromTrackerButton";
            this.removeFromTrackerButton.Size = new System.Drawing.Size(84, 23);
            this.removeFromTrackerButton.TabIndex = 29;
            this.removeFromTrackerButton.Text = ">>>";
            this.removeFromTrackerButton.UseVisualStyleBackColor = true;
            this.removeFromTrackerButton.Click += new System.EventHandler(this.removeFromTrackerButton_Click);
            // 
            // willpowerAtrInput
            // 
            this.willpowerAtrInput.Location = new System.Drawing.Point(715, 155);
            this.willpowerAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.willpowerAtrInput.Name = "willpowerAtrInput";
            this.willpowerAtrInput.Size = new System.Drawing.Size(50, 20);
            this.willpowerAtrInput.TabIndex = 28;
            this.willpowerAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // willpowerLabel
            // 
            this.willpowerLabel.AutoSize = true;
            this.willpowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.willpowerLabel.Location = new System.Drawing.Point(662, 155);
            this.willpowerLabel.Name = "willpowerLabel";
            this.willpowerLabel.Size = new System.Drawing.Size(31, 16);
            this.willpowerLabel.TabIndex = 27;
            this.willpowerLabel.Text = "WIL";
            // 
            // logicAtrInput
            // 
            this.logicAtrInput.Location = new System.Drawing.Point(715, 129);
            this.logicAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.logicAtrInput.Name = "logicAtrInput";
            this.logicAtrInput.Size = new System.Drawing.Size(50, 20);
            this.logicAtrInput.TabIndex = 26;
            this.logicAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // logicLabel
            // 
            this.logicLabel.AutoSize = true;
            this.logicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logicLabel.Location = new System.Drawing.Point(662, 129);
            this.logicLabel.Name = "logicLabel";
            this.logicLabel.Size = new System.Drawing.Size(35, 16);
            this.logicLabel.TabIndex = 25;
            this.logicLabel.Text = "LOG";
            // 
            // intuitionAtrInput
            // 
            this.intuitionAtrInput.Location = new System.Drawing.Point(715, 103);
            this.intuitionAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intuitionAtrInput.Name = "intuitionAtrInput";
            this.intuitionAtrInput.Size = new System.Drawing.Size(50, 20);
            this.intuitionAtrInput.TabIndex = 24;
            this.intuitionAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // intuitionLabel
            // 
            this.intuitionLabel.AutoSize = true;
            this.intuitionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intuitionLabel.Location = new System.Drawing.Point(662, 103);
            this.intuitionLabel.Name = "intuitionLabel";
            this.intuitionLabel.Size = new System.Drawing.Size(30, 16);
            this.intuitionLabel.TabIndex = 23;
            this.intuitionLabel.Text = "INT";
            // 
            // charismaAtrInput
            // 
            this.charismaAtrInput.Location = new System.Drawing.Point(715, 77);
            this.charismaAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charismaAtrInput.Name = "charismaAtrInput";
            this.charismaAtrInput.Size = new System.Drawing.Size(50, 20);
            this.charismaAtrInput.TabIndex = 22;
            this.charismaAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charismaLabel.Location = new System.Drawing.Point(662, 77);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(36, 16);
            this.charismaLabel.TabIndex = 21;
            this.charismaLabel.Text = "CHA";
            // 
            // strengthAtrInput
            // 
            this.strengthAtrInput.Location = new System.Drawing.Point(594, 155);
            this.strengthAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.strengthAtrInput.Name = "strengthAtrInput";
            this.strengthAtrInput.Size = new System.Drawing.Size(50, 20);
            this.strengthAtrInput.TabIndex = 20;
            this.strengthAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthLabel.Location = new System.Drawing.Point(541, 155);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(36, 16);
            this.strengthLabel.TabIndex = 19;
            this.strengthLabel.Text = "STR";
            // 
            // reactionAtrInput
            // 
            this.reactionAtrInput.Location = new System.Drawing.Point(594, 129);
            this.reactionAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reactionAtrInput.Name = "reactionAtrInput";
            this.reactionAtrInput.Size = new System.Drawing.Size(50, 20);
            this.reactionAtrInput.TabIndex = 18;
            this.reactionAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reactionLabel
            // 
            this.reactionLabel.AutoSize = true;
            this.reactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactionLabel.Location = new System.Drawing.Point(541, 129);
            this.reactionLabel.Name = "reactionLabel";
            this.reactionLabel.Size = new System.Drawing.Size(36, 16);
            this.reactionLabel.TabIndex = 17;
            this.reactionLabel.Text = "REA";
            // 
            // agilityAtrInput
            // 
            this.agilityAtrInput.Location = new System.Drawing.Point(594, 103);
            this.agilityAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.agilityAtrInput.Name = "agilityAtrInput";
            this.agilityAtrInput.Size = new System.Drawing.Size(50, 20);
            this.agilityAtrInput.TabIndex = 16;
            this.agilityAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agilityLabel
            // 
            this.agilityLabel.AutoSize = true;
            this.agilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agilityLabel.Location = new System.Drawing.Point(541, 103);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(30, 16);
            this.agilityLabel.TabIndex = 15;
            this.agilityLabel.Text = "AGI";
            // 
            // bodyAtrInput
            // 
            this.bodyAtrInput.Location = new System.Drawing.Point(594, 77);
            this.bodyAtrInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bodyAtrInput.Name = "bodyAtrInput";
            this.bodyAtrInput.Size = new System.Drawing.Size(50, 20);
            this.bodyAtrInput.TabIndex = 14;
            this.bodyAtrInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLabel.Location = new System.Drawing.Point(541, 77);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(37, 16);
            this.bodyLabel.TabIndex = 13;
            this.bodyLabel.Text = "BOD";
            // 
            // initTrackerSortButton
            // 
            this.initTrackerSortButton.Location = new System.Drawing.Point(287, 21);
            this.initTrackerSortButton.Name = "initTrackerSortButton";
            this.initTrackerSortButton.Size = new System.Drawing.Size(84, 23);
            this.initTrackerSortButton.TabIndex = 12;
            this.initTrackerSortButton.Text = "Sort Tracker";
            this.initTrackerSortButton.UseVisualStyleBackColor = true;
            this.initTrackerSortButton.Click += new System.EventHandler(this.initTrackerSortButton_Click);
            // 
            // delCharButton
            // 
            this.delCharButton.Enabled = false;
            this.delCharButton.Location = new System.Drawing.Point(747, 21);
            this.delCharButton.Name = "delCharButton";
            this.delCharButton.Size = new System.Drawing.Size(95, 23);
            this.delCharButton.TabIndex = 11;
            this.delCharButton.Text = "Delete Character";
            this.delCharButton.UseVisualStyleBackColor = true;
            this.delCharButton.Click += new System.EventHandler(this.delCharButton_Click);
            // 
            // editCharButton
            // 
            this.editCharButton.Enabled = false;
            this.editCharButton.Location = new System.Drawing.Point(654, 21);
            this.editCharButton.Name = "editCharButton";
            this.editCharButton.Size = new System.Drawing.Size(84, 23);
            this.editCharButton.TabIndex = 10;
            this.editCharButton.Text = "Edit Character";
            this.editCharButton.UseVisualStyleBackColor = true;
            this.editCharButton.Click += new System.EventHandler(this.editCharButton_Click);
            // 
            // charListLabel
            // 
            this.charListLabel.AutoSize = true;
            this.charListLabel.Location = new System.Drawing.Point(382, 4);
            this.charListLabel.Name = "charListLabel";
            this.charListLabel.Size = new System.Drawing.Size(72, 13);
            this.charListLabel.TabIndex = 9;
            this.charListLabel.Text = "Character List";
            // 
            // charInitLabel
            // 
            this.charInitLabel.AutoSize = true;
            this.charInitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charInitLabel.Location = new System.Drawing.Point(651, 51);
            this.charInitLabel.Name = "charInitLabel";
            this.charInitLabel.Size = new System.Drawing.Size(59, 16);
            this.charInitLabel.TabIndex = 8;
            this.charInitLabel.Text = "Initiative:";
            // 
            // charInitBox
            // 
            this.charInitBox.Location = new System.Drawing.Point(710, 50);
            this.charInitBox.Name = "charInitBox";
            this.charInitBox.Size = new System.Drawing.Size(55, 20);
            this.charInitBox.TabIndex = 7;
            this.charInitBox.ValueChanged += new System.EventHandler(this.charInitBox_ValueChanged);
            // 
            // createCharButton
            // 
            this.createCharButton.Location = new System.Drawing.Point(544, 21);
            this.createCharButton.Name = "createCharButton";
            this.createCharButton.Size = new System.Drawing.Size(100, 23);
            this.createCharButton.TabIndex = 6;
            this.createCharButton.Text = "Create Character";
            this.createCharButton.UseVisualStyleBackColor = true;
            this.createCharButton.Click += new System.EventHandler(this.createCharButton_Click);
            // 
            // charNameBox
            // 
            this.charNameBox.Location = new System.Drawing.Point(544, 50);
            this.charNameBox.Name = "charNameBox";
            this.charNameBox.Size = new System.Drawing.Size(100, 20);
            this.charNameBox.TabIndex = 4;
            this.charNameBox.Text = "Character Name";
            // 
            // charListBox
            // 
            this.charListBox.FormattingEnabled = true;
            this.charListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.charListBox.Location = new System.Drawing.Point(384, 21);
            this.charListBox.Name = "charListBox";
            this.charListBox.Size = new System.Drawing.Size(142, 537);
            this.charListBox.TabIndex = 3;
            this.charListBox.SelectedIndexChanged += new System.EventHandler(this.charListBox_SelectedIndexChanged);
            // 
            // addToTrackerButton
            // 
            this.addToTrackerButton.Location = new System.Drawing.Point(287, 74);
            this.addToTrackerButton.Name = "addToTrackerButton";
            this.addToTrackerButton.Size = new System.Drawing.Size(84, 23);
            this.addToTrackerButton.TabIndex = 2;
            this.addToTrackerButton.Text = "<<<";
            this.addToTrackerButton.UseVisualStyleBackColor = true;
            this.addToTrackerButton.Click += new System.EventHandler(this.addToTrackerButton_Click);
            // 
            // initTracker
            // 
            this.initTracker.ContextMenuStrip = this.InitiativeTrackerContextMenu;
            this.initTracker.FullRowSelect = true;
            this.initTracker.GridLines = true;
            this.initTracker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.initTracker.HideSelection = false;
            this.initTracker.Location = new System.Drawing.Point(7, 21);
            this.initTracker.MultiSelect = false;
            this.initTracker.Name = "initTracker";
            this.initTracker.Size = new System.Drawing.Size(264, 537);
            this.initTracker.TabIndex = 1;
            this.initTracker.UseCompatibleStateImageBehavior = false;
            this.initTracker.View = System.Windows.Forms.View.Details;
            this.initTracker.SelectedIndexChanged += new System.EventHandler(this.initTracker_SelectedIndexChanged);
            // 
            // InitiativeTrackerContextMenu
            // 
            this.InitiativeTrackerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInitiativeToolStripMenuItem});
            this.InitiativeTrackerContextMenu.Name = "contextMenuStrip1";
            this.InitiativeTrackerContextMenu.Size = new System.Drawing.Size(143, 26);
            // 
            // editInitiativeToolStripMenuItem
            // 
            this.editInitiativeToolStripMenuItem.Name = "editInitiativeToolStripMenuItem";
            this.editInitiativeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editInitiativeToolStripMenuItem.Text = "Edit Initiative";
            this.editInitiativeToolStripMenuItem.Click += new System.EventHandler(this.editInitiativeToolStripMenuItem_Click);
            // 
            // initiativeTrackerLabel
            // 
            this.initiativeTrackerLabel.AutoSize = true;
            this.initiativeTrackerLabel.Location = new System.Drawing.Point(4, 4);
            this.initiativeTrackerLabel.Name = "initiativeTrackerLabel";
            this.initiativeTrackerLabel.Size = new System.Drawing.Size(86, 13);
            this.initiativeTrackerLabel.TabIndex = 0;
            this.initiativeTrackerLabel.Text = "Initiative Tracker";
            // 
            // editInitPanel
            // 
            this.editInitPanel.Controls.Add(this.EditInitiativeInputBox);
            this.editInitPanel.Controls.Add(this.EditInitCANCELButton);
            this.editInitPanel.Controls.Add(this.EditInitOKButton);
            this.editInitPanel.Controls.Add(this.editInitLabel);
            this.editInitPanel.Location = new System.Drawing.Point(277, 179);
            this.editInitPanel.Name = "editInitPanel";
            this.editInitPanel.Size = new System.Drawing.Size(177, 103);
            this.editInitPanel.TabIndex = 2;
            this.editInitPanel.Visible = false;
            // 
            // editInitLabel
            // 
            this.editInitLabel.AutoSize = true;
            this.editInitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInitLabel.Location = new System.Drawing.Point(6, 10);
            this.editInitLabel.Name = "editInitLabel";
            this.editInitLabel.Size = new System.Drawing.Size(119, 20);
            this.editInitLabel.TabIndex = 0;
            this.editInitLabel.Text = "Edit Initiative:";
            // 
            // EditInitOKButton
            // 
            this.EditInitOKButton.Location = new System.Drawing.Point(10, 68);
            this.EditInitOKButton.Name = "EditInitOKButton";
            this.EditInitOKButton.Size = new System.Drawing.Size(75, 23);
            this.EditInitOKButton.TabIndex = 1;
            this.EditInitOKButton.Text = "OK";
            this.EditInitOKButton.UseVisualStyleBackColor = true;
            this.EditInitOKButton.Click += new System.EventHandler(this.EditInitOKButton_Click);
            // 
            // EditInitCANCELButton
            // 
            this.EditInitCANCELButton.Location = new System.Drawing.Point(91, 68);
            this.EditInitCANCELButton.Name = "EditInitCANCELButton";
            this.EditInitCANCELButton.Size = new System.Drawing.Size(75, 23);
            this.EditInitCANCELButton.TabIndex = 2;
            this.EditInitCANCELButton.Text = "CANCEL";
            this.EditInitCANCELButton.UseVisualStyleBackColor = true;
            this.EditInitCANCELButton.Click += new System.EventHandler(this.EditInitCANCELButton_Click);
            // 
            // EditInitiativeInputBox
            // 
            this.EditInitiativeInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInitiativeInputBox.Location = new System.Drawing.Point(10, 33);
            this.EditInitiativeInputBox.Name = "EditInitiativeInputBox";
            this.EditInitiativeInputBox.Size = new System.Drawing.Size(156, 29);
            this.EditInitiativeInputBox.TabIndex = 3;
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTurnButton.Location = new System.Drawing.Point(287, 48);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(84, 23);
            this.EndTurnButton.TabIndex = 31;
            this.EndTurnButton.Text = "END TURN";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // DMTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 626);
            this.Controls.Add(this.combatPanel);
            this.Controls.Add(this.combatButton);
            this.Name = "DMTool";
            this.Text = "Dungeon Master Tool";
            this.combatPanel.ResumeLayout(false);
            this.combatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.willpowerAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intuitionAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactionAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilityAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyAtrInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charInitBox)).EndInit();
            this.InitiativeTrackerContextMenu.ResumeLayout(false);
            this.editInitPanel.ResumeLayout(false);
            this.editInitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditInitiativeInputBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button combatButton;
        private System.Windows.Forms.Panel combatPanel;
        private System.Windows.Forms.ListView initTracker;
        private System.Windows.Forms.Label initiativeTrackerLabel;
        private System.Windows.Forms.ListBox charListBox;
        private System.Windows.Forms.Button addToTrackerButton;
        private System.Windows.Forms.TextBox charNameBox;
        private System.Windows.Forms.Button createCharButton;
        private System.Windows.Forms.NumericUpDown charInitBox;
        private System.Windows.Forms.Label charInitLabel;
        private System.Windows.Forms.Label charListLabel;
        private System.Windows.Forms.Button editCharButton;
        private System.Windows.Forms.Button delCharButton;
        private System.Windows.Forms.Button initTrackerSortButton;
        private System.Windows.Forms.NumericUpDown bodyAtrInput;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.NumericUpDown agilityAtrInput;
        private System.Windows.Forms.Label agilityLabel;
        private System.Windows.Forms.NumericUpDown reactionAtrInput;
        private System.Windows.Forms.Label reactionLabel;
        private System.Windows.Forms.NumericUpDown willpowerAtrInput;
        private System.Windows.Forms.Label willpowerLabel;
        private System.Windows.Forms.NumericUpDown logicAtrInput;
        private System.Windows.Forms.Label logicLabel;
        private System.Windows.Forms.NumericUpDown intuitionAtrInput;
        private System.Windows.Forms.Label intuitionLabel;
        private System.Windows.Forms.NumericUpDown charismaAtrInput;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.NumericUpDown strengthAtrInput;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Button removeFromTrackerButton;
        private System.Windows.Forms.Button addToTrackerWithRollsButton;
        private System.Windows.Forms.ContextMenuStrip InitiativeTrackerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editInitiativeToolStripMenuItem;
        private System.Windows.Forms.Panel editInitPanel;
        private System.Windows.Forms.NumericUpDown EditInitiativeInputBox;
        private System.Windows.Forms.Button EditInitCANCELButton;
        private System.Windows.Forms.Button EditInitOKButton;
        private System.Windows.Forms.Label editInitLabel;
        private System.Windows.Forms.Button EndTurnButton;
    }
}

