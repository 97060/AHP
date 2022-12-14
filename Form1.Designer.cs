namespace AHP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.criteriaNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generateListButton = new System.Windows.Forms.Button();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.numberOfCriteriaGroupBOx = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaNumberNumericUpDown)).BeginInit();
            this.generalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.numberOfCriteriaGroupBOx.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // criteriaNumberNumericUpDown
            // 
            this.criteriaNumberNumericUpDown.Location = new System.Drawing.Point(6, 22);
            this.criteriaNumberNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.criteriaNumberNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.criteriaNumberNumericUpDown.Name = "criteriaNumberNumericUpDown";
            this.criteriaNumberNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.criteriaNumberNumericUpDown.TabIndex = 1;
            this.criteriaNumberNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // generateListButton
            // 
            this.generateListButton.Location = new System.Drawing.Point(132, 22);
            this.generateListButton.Name = "generateListButton";
            this.generateListButton.Size = new System.Drawing.Size(75, 23);
            this.generateListButton.TabIndex = 3;
            this.generateListButton.Text = "Generuj";
            this.generateListButton.UseVisualStyleBackColor = true;
            this.generateListButton.Click += new System.EventHandler(this.GenerateListButton_Click);
            // 
            // generalPanel
            // 
            this.generalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPanel.AutoScroll = true;
            this.generalPanel.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            this.generalPanel.Controls.Add(this.pictureBox2);
            this.generalPanel.Controls.Add(this.pictureBox1);
            this.generalPanel.Controls.Add(this.calculateButton);
            this.generalPanel.Controls.Add(this.tableLayoutPanel);
            this.generalPanel.Controls.Add(this.numberOfCriteriaGroupBOx);
            this.generalPanel.Controls.Add(this.menuStrip1);
            this.generalPanel.Location = new System.Drawing.Point(-2, 0);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(1216, 785);
            this.generalPanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(539, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(669, 419);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(539, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(445, 47);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(530, 695);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // numberOfCriteriaGroupBOx
            // 
            this.numberOfCriteriaGroupBOx.Controls.Add(this.criteriaNumberNumericUpDown);
            this.numberOfCriteriaGroupBOx.Controls.Add(this.generateListButton);
            this.numberOfCriteriaGroupBOx.Location = new System.Drawing.Point(3, 27);
            this.numberOfCriteriaGroupBOx.Name = "numberOfCriteriaGroupBOx";
            this.numberOfCriteriaGroupBOx.Size = new System.Drawing.Size(214, 54);
            this.numberOfCriteriaGroupBOx.TabIndex = 4;
            this.numberOfCriteriaGroupBOx.TabStop = false;
            this.numberOfCriteriaGroupBOx.Text = "Numer kryteriów";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 791);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1188, 121);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 924);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generalPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AHP calculator";
            ((System.ComponentModel.ISupportInitialize)(this.criteriaNumberNumericUpDown)).EndInit();
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.numberOfCriteriaGroupBOx.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown criteriaNumberNumericUpDown;
        private Button generateListButton;
        private Panel generalPanel;
        private TableLayoutPanel tableLayoutPanel;
        private GroupBox numberOfCriteriaGroupBOx;
        private Button calculateButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}