namespace apple3
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.apple = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.appleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // apple
            // 
            this.apple.BackColor = System.Drawing.Color.Transparent;
            this.apple.Image = global::apple3.Properties.Resources.New_Piskel1;
            this.apple.Location = new System.Drawing.Point(469, 318);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(32, 32);
            this.apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.apple.TabIndex = 2;
            this.apple.TabStop = false;
            this.apple.Tag = "apple";
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ground.Image = global::apple3.Properties.Resources.ground_layer2;
            this.ground.Location = new System.Drawing.Point(-6, 358);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(805, 92);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            this.ground.Tag = "ground";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::apple3.Properties.Resources.New_Piskel__15_;
            this.player.Location = new System.Drawing.Point(320, 294);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // appleLabel
            // 
            this.appleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appleLabel.Location = new System.Drawing.Point(604, 9);
            this.appleLabel.Name = "appleLabel";
            this.appleLabel.Size = new System.Drawing.Size(184, 82);
            this.appleLabel.TabIndex = 3;
            this.appleLabel.Text = "Apples: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appleLabel);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.Label appleLabel;
    }
}

