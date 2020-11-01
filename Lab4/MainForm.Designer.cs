namespace Lab1
{
    partial class MainForm
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
            this.GenOrdinaryButton = new System.Windows.Forms.Button();
            this.GenSparseButton = new System.Windows.Forms.Button();
            this.MatrixCanvas = new System.Windows.Forms.PictureBox();
            this.RowsBox = new System.Windows.Forms.TextBox();
            this.ColumnsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BordersBox = new System.Windows.Forms.CheckBox();
            this.NonZeroBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RenumberButton = new System.Windows.Forms.Button();
            this.Restore = new System.Windows.Forms.Button();
            this.MatrixGroupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // GenOrdinaryButton
            // 
            this.GenOrdinaryButton.Location = new System.Drawing.Point(595, 73);
            this.GenOrdinaryButton.Name = "GenOrdinaryButton";
            this.GenOrdinaryButton.Size = new System.Drawing.Size(143, 25);
            this.GenOrdinaryButton.TabIndex = 0;
            this.GenOrdinaryButton.Text = "Generate ordinary matrix";
            this.GenOrdinaryButton.UseVisualStyleBackColor = true;
            this.GenOrdinaryButton.Click += new System.EventHandler(this.GenOrdinaryButton_Click);
            // 
            // GenSparseButton
            // 
            this.GenSparseButton.Location = new System.Drawing.Point(595, 104);
            this.GenSparseButton.Name = "GenSparseButton";
            this.GenSparseButton.Size = new System.Drawing.Size(143, 25);
            this.GenSparseButton.TabIndex = 1;
            this.GenSparseButton.Text = "Generate sparse matrix";
            this.GenSparseButton.UseVisualStyleBackColor = true;
            this.GenSparseButton.Click += new System.EventHandler(this.GenSparseButton_Click);
            // 
            // MatrixCanvas
            // 
            this.MatrixCanvas.BackColor = System.Drawing.Color.White;
            this.MatrixCanvas.Location = new System.Drawing.Point(19, 21);
            this.MatrixCanvas.Name = "MatrixCanvas";
            this.MatrixCanvas.Size = new System.Drawing.Size(545, 501);
            this.MatrixCanvas.TabIndex = 2;
            this.MatrixCanvas.TabStop = false;
            // 
            // RowsBox
            // 
            this.RowsBox.Location = new System.Drawing.Point(663, 21);
            this.RowsBox.Name = "RowsBox";
            this.RowsBox.Size = new System.Drawing.Size(75, 20);
            this.RowsBox.TabIndex = 3;
            // 
            // ColumnsBox
            // 
            this.ColumnsBox.Location = new System.Drawing.Point(663, 47);
            this.ColumnsBox.Name = "ColumnsBox";
            this.ColumnsBox.Size = new System.Drawing.Size(75, 20);
            this.ColumnsBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columns:";
            // 
            // BordersBox
            // 
            this.BordersBox.AutoSize = true;
            this.BordersBox.Checked = true;
            this.BordersBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BordersBox.Location = new System.Drawing.Point(595, 172);
            this.BordersBox.Name = "BordersBox";
            this.BordersBox.Size = new System.Drawing.Size(62, 17);
            this.BordersBox.TabIndex = 8;
            this.BordersBox.Text = "Borders";
            this.BordersBox.UseVisualStyleBackColor = true;
            // 
            // NonZeroBox
            // 
            this.NonZeroBox.Location = new System.Drawing.Point(681, 195);
            this.NonZeroBox.Name = "NonZeroBox";
            this.NonZeroBox.Size = new System.Drawing.Size(75, 20);
            this.NonZeroBox.TabIndex = 9;
            this.NonZeroBox.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Non zero values:";
            // 
            // RenumberButton
            // 
            this.RenumberButton.Location = new System.Drawing.Point(595, 235);
            this.RenumberButton.Name = "RenumberButton";
            this.RenumberButton.Size = new System.Drawing.Size(132, 25);
            this.RenumberButton.TabIndex = 11;
            this.RenumberButton.Text = "Renumber";
            this.RenumberButton.UseVisualStyleBackColor = true;
            this.RenumberButton.Click += new System.EventHandler(this.RenumberButton_Click);
            // 
            // Restore
            // 
            this.Restore.Location = new System.Drawing.Point(595, 266);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(132, 25);
            this.Restore.TabIndex = 12;
            this.Restore.Text = "Restore";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // MatrixGroupButton
            // 
            this.MatrixGroupButton.Location = new System.Drawing.Point(595, 135);
            this.MatrixGroupButton.Name = "MatrixGroupButton";
            this.MatrixGroupButton.Size = new System.Drawing.Size(143, 25);
            this.MatrixGroupButton.TabIndex = 13;
            this.MatrixGroupButton.Text = "Generate matrix group";
            this.MatrixGroupButton.UseVisualStyleBackColor = true;
            this.MatrixGroupButton.Click += new System.EventHandler(this.MatrixGroupButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 565);
            this.Controls.Add(this.MatrixGroupButton);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.RenumberButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NonZeroBox);
            this.Controls.Add(this.BordersBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColumnsBox);
            this.Controls.Add(this.RowsBox);
            this.Controls.Add(this.MatrixCanvas);
            this.Controls.Add(this.GenSparseButton);
            this.Controls.Add(this.GenOrdinaryButton);
            this.Name = "MainForm";
            this.Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenOrdinaryButton;
        private System.Windows.Forms.Button GenSparseButton;
        private System.Windows.Forms.PictureBox MatrixCanvas;
        private System.Windows.Forms.TextBox RowsBox;
        private System.Windows.Forms.TextBox ColumnsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox BordersBox;
        private System.Windows.Forms.TextBox NonZeroBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RenumberButton;
        private System.Windows.Forms.Button Restore;
        private System.Windows.Forms.Button MatrixGroupButton;
    }
}