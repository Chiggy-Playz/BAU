namespace Bunker_Automation_Utilty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Number_of_Minutes = new System.Windows.Forms.Label();
            this.Choose_Min = new System.Windows.Forms.NumericUpDown();
            this.Resupply_Number = new System.Windows.Forms.Label();
            this.ChooseResupply = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Choose_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseResupply)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(463, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.button1.Size = new System.Drawing.Size(270, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Number_of_Minutes
            // 
            this.Number_of_Minutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number_of_Minutes.AutoSize = true;
            this.Number_of_Minutes.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_of_Minutes.Location = new System.Drawing.Point(33, 37);
            this.Number_of_Minutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number_of_Minutes.Name = "Number_of_Minutes";
            this.Number_of_Minutes.Size = new System.Drawing.Size(858, 49);
            this.Number_of_Minutes.TabIndex = 1;
            this.Number_of_Minutes.Text = "Enter the number of minutes until the next resupply.";
            // 
            // Choose_Min
            // 
            this.Choose_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Min.Location = new System.Drawing.Point(507, 109);
            this.Choose_Min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Choose_Min.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.Choose_Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Choose_Min.Name = "Choose_Min";
            this.Choose_Min.Size = new System.Drawing.Size(186, 62);
            this.Choose_Min.TabIndex = 3;
            this.Choose_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Choose_Min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Choose_Min.ValueChanged += new System.EventHandler(this.Choose_Min_ValueChanged);
            // 
            // Resupply_Number
            // 
            this.Resupply_Number.AutoSize = true;
            this.Resupply_Number.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resupply_Number.Location = new System.Drawing.Point(30, 182);
            this.Resupply_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resupply_Number.Name = "Resupply_Number";
            this.Resupply_Number.Size = new System.Drawing.Size(727, 98);
            this.Resupply_Number.TabIndex = 4;
            this.Resupply_Number.Text = "Enter how many times you want to resupply\r\n(including this one)";
            // 
            // ChooseResupply
            // 
            this.ChooseResupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ChooseResupply.Location = new System.Drawing.Point(507, 312);
            this.ChooseResupply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChooseResupply.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ChooseResupply.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChooseResupply.Name = "ChooseResupply";
            this.ChooseResupply.Size = new System.Drawing.Size(180, 62);
            this.ChooseResupply.TabIndex = 6;
            this.ChooseResupply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChooseResupply.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChooseResupply.ValueChanged += new System.EventHandler(this.ChooseResupply_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 138);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time left \r\nuntil next \r\nresupply:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label2.Location = new System.Drawing.Point(231, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 64);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choose_Min);
            this.Controls.Add(this.ChooseResupply);
            this.Controls.Add(this.Resupply_Number);
            this.Controls.Add(this.Number_of_Minutes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bunker Automation Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Choose_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseResupply)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Number_of_Minutes;
        private System.Windows.Forms.NumericUpDown Choose_Min;
        private System.Windows.Forms.Label Resupply_Number;
        private System.Windows.Forms.NumericUpDown ChooseResupply;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
    }
}

