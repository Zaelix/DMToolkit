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
            this.combatButton = new System.Windows.Forms.Button();
            this.combatPanel = new System.Windows.Forms.Panel();
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
            this.initiativeTrackerLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.bodyAtrInput = new System.Windows.Forms.NumericUpDown();
            this.combatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charInitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyAtrInput)).BeginInit();
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
            // initTrackerSortButton
            // 
            this.initTrackerSortButton.Location = new System.Drawing.Point(286, 46);
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
            this.addToTrackerButton.Location = new System.Drawing.Point(286, 21);
            this.addToTrackerButton.Name = "addToTrackerButton";
            this.addToTrackerButton.Size = new System.Drawing.Size(84, 23);
            this.addToTrackerButton.TabIndex = 2;
            this.addToTrackerButton.Text = "<<<";
            this.addToTrackerButton.UseVisualStyleBackColor = true;
            this.addToTrackerButton.Click += new System.EventHandler(this.addToTrackerButton_Click);
            // 
            // initTracker
            // 
            this.initTracker.GridLines = true;
            this.initTracker.HideSelection = false;
            this.initTracker.Location = new System.Drawing.Point(7, 21);
            this.initTracker.Name = "initTracker";
            this.initTracker.Size = new System.Drawing.Size(264, 537);
            this.initTracker.TabIndex = 1;
            this.initTracker.UseCompatibleStateImageBehavior = false;
            this.initTracker.View = System.Windows.Forms.View.Details;
            this.initTracker.SelectedIndexChanged += new System.EventHandler(this.initTracker_SelectedIndexChanged);
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
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLabel.Location = new System.Drawing.Point(541, 77);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(40, 16);
            this.bodyLabel.TabIndex = 13;
            this.bodyLabel.Text = "Body";
            // 
            // bodyAtrInput
            // 
            this.bodyAtrInput.Location = new System.Drawing.Point(594, 77);
            this.bodyAtrInput.Name = "bodyAtrInput";
            this.bodyAtrInput.Size = new System.Drawing.Size(50, 20);
            this.bodyAtrInput.TabIndex = 14;
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
            ((System.ComponentModel.ISupportInitialize)(this.charInitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyAtrInput)).EndInit();
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
    }
}

