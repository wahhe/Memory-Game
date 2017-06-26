namespace Memory_Game
{
    partial class GameoverScreen
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
            this.outputlabel1 = new System.Windows.Forms.Label();
            this.playaginB = new System.Windows.Forms.Button();
            this.exitgameB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputlabel1
            // 
            this.outputlabel1.AutoSize = true;
            this.outputlabel1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel1.ForeColor = System.Drawing.Color.Transparent;
            this.outputlabel1.Location = new System.Drawing.Point(59, 105);
            this.outputlabel1.Name = "outputlabel1";
            this.outputlabel1.Size = new System.Drawing.Size(682, 67);
            this.outputlabel1.TabIndex = 0;
            this.outputlabel1.Text = "your used time: 50 seconds!";
            this.outputlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playaginB
            // 
            this.playaginB.AllowDrop = true;
            this.playaginB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playaginB.FlatAppearance.BorderSize = 3;
            this.playaginB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playaginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playaginB.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playaginB.ForeColor = System.Drawing.Color.Gold;
            this.playaginB.Location = new System.Drawing.Point(0, 284);
            this.playaginB.Name = "playaginB";
            this.playaginB.Size = new System.Drawing.Size(800, 110);
            this.playaginB.TabIndex = 1;
            this.playaginB.Text = "PLAY AGAIN";
            this.playaginB.UseVisualStyleBackColor = true;
            this.playaginB.Click += new System.EventHandler(this.playaginB_Click);
            // 
            // exitgameB
            // 
            this.exitgameB.AllowDrop = true;
            this.exitgameB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitgameB.FlatAppearance.BorderSize = 3;
            this.exitgameB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.exitgameB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitgameB.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitgameB.ForeColor = System.Drawing.Color.Gold;
            this.exitgameB.Location = new System.Drawing.Point(0, 400);
            this.exitgameB.Name = "exitgameB";
            this.exitgameB.Size = new System.Drawing.Size(800, 110);
            this.exitgameB.TabIndex = 2;
            this.exitgameB.Text = "EXIT GAME";
            this.exitgameB.UseVisualStyleBackColor = true;
            this.exitgameB.Click += new System.EventHandler(this.exitgameB_Click);
            // 
            // GameoverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.Controls.Add(this.exitgameB);
            this.Controls.Add(this.playaginB);
            this.Controls.Add(this.outputlabel1);
            this.Name = "GameoverScreen";
            this.Size = new System.Drawing.Size(800, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputlabel1;
        private System.Windows.Forms.Button playaginB;
        private System.Windows.Forms.Button exitgameB;
    }
}
