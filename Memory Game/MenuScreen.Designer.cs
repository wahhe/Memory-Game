namespace Memory_Game
{
    partial class MenuScreen
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
            this.exitB = new System.Windows.Forms.Button();
            this.startB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Transparent;
            this.exitB.BackgroundImage = global::Memory_Game.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitB.FlatAppearance.BorderSize = 0;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.Location = new System.Drawing.Point(213, 369);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(386, 127);
            this.exitB.TabIndex = 1;
            this.exitB.UseVisualStyleBackColor = false;
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.Color.Transparent;
            this.startB.BackgroundImage = global::Memory_Game.Properties.Resources.play;
            this.startB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startB.FlatAppearance.BorderSize = 0;
            this.startB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startB.Location = new System.Drawing.Point(213, 203);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(386, 127);
            this.startB.TabIndex = 0;
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 135);
            this.label1.TabIndex = 2;
            this.label1.Text = "Memory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(471, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 135);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.startB);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(800, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
