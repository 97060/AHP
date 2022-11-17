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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numberOfCriteriaGroupBOx = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaNumberNumericUpDown)).BeginInit();
            this.generalPanel.SuspendLayout();
            this.numberOfCriteriaGroupBOx.SuspendLayout();
            this.SuspendLayout();
            // 
            // criteriaNumberNumericUpDown
            // 
            this.criteriaNumberNumericUpDown.Location = new System.Drawing.Point(6, 22);
            this.criteriaNumberNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.criteriaNumberNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.criteriaNumberNumericUpDown.Name = "criteriaNumberNumericUpDown";
            this.criteriaNumberNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.criteriaNumberNumericUpDown.TabIndex = 1;
            this.criteriaNumberNumericUpDown.Value = new decimal(new int[] {
            2,
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
            this.generateListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // generalPanel
            // 
            this.generalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPanel.AutoScroll = true;
            this.generalPanel.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            this.generalPanel.Controls.Add(this.tableLayoutPanel1);
            this.generalPanel.Controls.Add(this.numberOfCriteriaGroupBOx);
            this.generalPanel.Location = new System.Drawing.Point(12, 12);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(532, 538);
            this.generalPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numberOfCriteriaGroupBOx
            // 
            this.numberOfCriteriaGroupBOx.Controls.Add(this.criteriaNumberNumericUpDown);
            this.numberOfCriteriaGroupBOx.Controls.Add(this.generateListButton);
            this.numberOfCriteriaGroupBOx.Location = new System.Drawing.Point(0, 3);
            this.numberOfCriteriaGroupBOx.Name = "numberOfCriteriaGroupBOx";
            this.numberOfCriteriaGroupBOx.Size = new System.Drawing.Size(532, 54);
            this.numberOfCriteriaGroupBOx.TabIndex = 4;
            this.numberOfCriteriaGroupBOx.TabStop = false;
            this.numberOfCriteriaGroupBOx.Text = "Numer kryteriów";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 562);
            this.Controls.Add(this.generalPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.criteriaNumberNumericUpDown)).EndInit();
            this.generalPanel.ResumeLayout(false);
            this.numberOfCriteriaGroupBOx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NumericUpDown criteriaNumberNumericUpDown;
        private Button generateListButton;
        private Panel generalPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox numberOfCriteriaGroupBOx;
    }
}