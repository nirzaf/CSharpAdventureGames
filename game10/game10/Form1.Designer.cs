namespace game {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.LookBtn = new System.Windows.Forms.Button();
            this.NBtn = new System.Windows.Forms.Button();
            this.WBtn = new System.Windows.Forms.Button();
            this.EBtn = new System.Windows.Forms.Button();
            this.SBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LookAtBtn = new System.Windows.Forms.Button();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.DropBtn = new System.Windows.Forms.Button();
            this.TakeBtn = new System.Windows.Forms.Button();
            this.InventoryBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputTB
            // 
            this.OutputTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTB.Location = new System.Drawing.Point(12, 27);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.Size = new System.Drawing.Size(846, 392);
            this.OutputTB.TabIndex = 0;
            // 
            // LookBtn
            // 
            this.LookBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LookBtn.Location = new System.Drawing.Point(577, 513);
            this.LookBtn.Name = "LookBtn";
            this.LookBtn.Size = new System.Drawing.Size(75, 23);
            this.LookBtn.TabIndex = 1;
            this.LookBtn.Text = "Look";
            this.LookBtn.UseVisualStyleBackColor = false;
            this.LookBtn.Click += new System.EventHandler(this.LookBtn_Click);
            // 
            // NBtn
            // 
            this.NBtn.Location = new System.Drawing.Point(738, 484);
            this.NBtn.Name = "NBtn";
            this.NBtn.Size = new System.Drawing.Size(75, 23);
            this.NBtn.TabIndex = 2;
            this.NBtn.Text = "N";
            this.NBtn.UseVisualStyleBackColor = true;
            this.NBtn.Click += new System.EventHandler(this.NBtn_Click);
            // 
            // WBtn
            // 
            this.WBtn.Location = new System.Drawing.Point(690, 513);
            this.WBtn.Name = "WBtn";
            this.WBtn.Size = new System.Drawing.Size(75, 23);
            this.WBtn.TabIndex = 3;
            this.WBtn.Text = "W";
            this.WBtn.UseVisualStyleBackColor = true;
            this.WBtn.Click += new System.EventHandler(this.WBtn_Click);
            // 
            // EBtn
            // 
            this.EBtn.Location = new System.Drawing.Point(778, 513);
            this.EBtn.Name = "EBtn";
            this.EBtn.Size = new System.Drawing.Size(75, 23);
            this.EBtn.TabIndex = 4;
            this.EBtn.Text = "E";
            this.EBtn.UseVisualStyleBackColor = true;
            this.EBtn.Click += new System.EventHandler(this.EBtn_Click);
            // 
            // SBtn
            // 
            this.SBtn.Location = new System.Drawing.Point(738, 542);
            this.SBtn.Name = "SBtn";
            this.SBtn.Size = new System.Drawing.Size(75, 23);
            this.SBtn.TabIndex = 5;
            this.SBtn.Text = "S";
            this.SBtn.UseVisualStyleBackColor = true;
            this.SBtn.Click += new System.EventHandler(this.SBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LookAtBtn);
            this.groupBox1.Controls.Add(this.InputTB);
            this.groupBox1.Controls.Add(this.DropBtn);
            this.groupBox1.Controls.Add(this.TakeBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select object...";
            // 
            // LookAtBtn
            // 
            this.LookAtBtn.Location = new System.Drawing.Point(229, 58);
            this.LookAtBtn.Name = "LookAtBtn";
            this.LookAtBtn.Size = new System.Drawing.Size(75, 23);
            this.LookAtBtn.TabIndex = 3;
            this.LookAtBtn.Text = "Look At";
            this.LookAtBtn.UseVisualStyleBackColor = true;
            this.LookAtBtn.Click += new System.EventHandler(this.LookAtBtn_Click);
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(7, 20);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(297, 20);
            this.InputTB.TabIndex = 2;
            // 
            // DropBtn
            // 
            this.DropBtn.Location = new System.Drawing.Point(119, 58);
            this.DropBtn.Name = "DropBtn";
            this.DropBtn.Size = new System.Drawing.Size(75, 23);
            this.DropBtn.TabIndex = 1;
            this.DropBtn.Text = "Drop";
            this.DropBtn.UseVisualStyleBackColor = true;
            this.DropBtn.Click += new System.EventHandler(this.DropBtn_Click);
            // 
            // TakeBtn
            // 
            this.TakeBtn.Location = new System.Drawing.Point(7, 58);
            this.TakeBtn.Name = "TakeBtn";
            this.TakeBtn.Size = new System.Drawing.Size(75, 23);
            this.TakeBtn.TabIndex = 0;
            this.TakeBtn.Text = "Take";
            this.TakeBtn.UseVisualStyleBackColor = true;
            this.TakeBtn.Click += new System.EventHandler(this.TakeBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Location = new System.Drawing.Point(577, 541);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Size = new System.Drawing.Size(75, 23);
            this.InventoryBtn.TabIndex = 7;
            this.InventoryBtn.Text = "Inventory";
            this.InventoryBtn.UseVisualStyleBackColor = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 588);
            this.Controls.Add(this.InventoryBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SBtn);
            this.Controls.Add(this.EBtn);
            this.Controls.Add(this.WBtn);
            this.Controls.Add(this.NBtn);
            this.Controls.Add(this.LookBtn);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Dark Neon City...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.Button LookBtn;
        private System.Windows.Forms.Button NBtn;
        private System.Windows.Forms.Button WBtn;
        private System.Windows.Forms.Button EBtn;
        private System.Windows.Forms.Button SBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.Button DropBtn;
        private System.Windows.Forms.Button TakeBtn;
        private System.Windows.Forms.Button InventoryBtn;
        private System.Windows.Forms.Button LookAtBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

