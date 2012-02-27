namespace StickyNote
{
    partial class StickyNoteSettingsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDirections = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExclusions = new System.Windows.Forms.TextBox();
            this.computerScreenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerScreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDirections
            // 
            this.labelDirections.BackColor = System.Drawing.Color.Transparent;
            this.labelDirections.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirections.Location = new System.Drawing.Point(189, 26);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(128, 81);
            this.labelDirections.TabIndex = 5;
            this.labelDirections.Text = "Click the area of the screen where you would like these notifications to appear.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Include notifications containing (separate with commas)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtExclusions
            // 
            this.txtExclusions.Location = new System.Drawing.Point(30, 188);
            this.txtExclusions.Name = "txtExclusions";
            this.txtExclusions.Size = new System.Drawing.Size(322, 20);
            this.txtExclusions.TabIndex = 7;
            this.txtExclusions.TextChanged += new System.EventHandler(this.txtExclusions_TextChanged);
            // 
            // computerScreenPictureBox
            // 
            this.computerScreenPictureBox.Location = new System.Drawing.Point(27, 3);
            this.computerScreenPictureBox.Name = "computerScreenPictureBox";
            this.computerScreenPictureBox.Size = new System.Drawing.Size(144, 144);
            this.computerScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerScreenPictureBox.TabIndex = 4;
            this.computerScreenPictureBox.TabStop = false;
            this.computerScreenPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.computerScreenPictureBox_MouseClick);
            // 
            // StickyNoteSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtExclusions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.computerScreenPictureBox);
            this.Name = "StickyNoteSettingsPanel";
            this.Load += new System.EventHandler(this.StickyNoteSettingsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerScreenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox computerScreenPictureBox;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExclusions;
    }
}
