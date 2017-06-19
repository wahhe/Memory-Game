namespace Memory_Game
{
    partial class levelopitions
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
            this.hardB = new System.Windows.Forms.Button();
            this.mediumB = new System.Windows.Forms.Button();
            this.easyB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hardB
            // 
            this.hardB.BackgroundImage = global::Memory_Game.Properties.Resources.hard;
            this.hardB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hardB.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.hardB.FlatAppearance.BorderSize = 5;
            this.hardB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardB.Location = new System.Drawing.Point(544, 218);
            this.hardB.Name = "hardB";
            this.hardB.Size = new System.Drawing.Size(200, 200);
            this.hardB.TabIndex = 2;
            this.hardB.UseVisualStyleBackColor = true;
            this.hardB.Click += new System.EventHandler(this.hardB_Click);
            // 
            // mediumB
            // 
            this.mediumB.BackgroundImage = global::Memory_Game.Properties.Resources.medium;
            this.mediumB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mediumB.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.mediumB.FlatAppearance.BorderSize = 5;
            this.mediumB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumB.Location = new System.Drawing.Point(300, 218);
            this.mediumB.Name = "mediumB";
            this.mediumB.Size = new System.Drawing.Size(200, 200);
            this.mediumB.TabIndex = 1;
            this.mediumB.UseVisualStyleBackColor = true;
            this.mediumB.Click += new System.EventHandler(this.mediumB_Click);
            // 
            // easyB
            // 
            this.easyB.BackgroundImage = global::Memory_Game.Properties.Resources.easy;
            this.easyB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.easyB.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.easyB.FlatAppearance.BorderSize = 5;
            this.easyB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyB.Location = new System.Drawing.Point(56, 218);
            this.easyB.Name = "easyB";
            this.easyB.Size = new System.Drawing.Size(200, 200);
            this.easyB.TabIndex = 0;
            this.easyB.UseVisualStyleBackColor = true;
            this.easyB.Click += new System.EventHandler(this.easyB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Difficulty Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelopitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardB);
            this.Controls.Add(this.mediumB);
            this.Controls.Add(this.easyB);
            this.Name = "levelopitions";
            this.Size = new System.Drawing.Size(800, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyB;
        private System.Windows.Forms.Button mediumB;
        private System.Windows.Forms.Button hardB;
        private System.Windows.Forms.Label label1;
    }
}
