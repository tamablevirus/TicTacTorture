namespace CapstoneIndividual
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
            this.gbPlayers = new System.Windows.Forms.GroupBox();
            this.rb2Players = new System.Windows.Forms.RadioButton();
            this.rb1Player = new System.Windows.Forms.RadioButton();
            this.gbModes = new System.Windows.Forms.GroupBox();
            this.rb6x6 = new System.Windows.Forms.RadioButton();
            this.rbUltimate = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.lblPlayer1Prompt = new System.Windows.Forms.Label();
            this.lblPlayer2Prompt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblModeName = new System.Windows.Forms.Label();
            this.lblModeDescription = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.gbPlayers.SuspendLayout();
            this.gbModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayers
            // 
            this.gbPlayers.Controls.Add(this.rb2Players);
            this.gbPlayers.Controls.Add(this.rb1Player);
            this.gbPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayers.ForeColor = System.Drawing.Color.White;
            this.gbPlayers.Location = new System.Drawing.Point(72, 169);
            this.gbPlayers.Name = "gbPlayers";
            this.gbPlayers.Size = new System.Drawing.Size(220, 98);
            this.gbPlayers.TabIndex = 0;
            this.gbPlayers.TabStop = false;
            this.gbPlayers.Text = "How Many Players?";
            // 
            // rb2Players
            // 
            this.rb2Players.AutoSize = true;
            this.rb2Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2Players.Location = new System.Drawing.Point(6, 64);
            this.rb2Players.Name = "rb2Players";
            this.rb2Players.Size = new System.Drawing.Size(91, 24);
            this.rb2Players.TabIndex = 1;
            this.rb2Players.TabStop = true;
            this.rb2Players.Text = "2 Players";
            this.rb2Players.UseVisualStyleBackColor = true;
            this.rb2Players.CheckedChanged += new System.EventHandler(this.rb2Players_CheckedChanged);
            // 
            // rb1Player
            // 
            this.rb1Player.AutoSize = true;
            this.rb1Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1Player.Location = new System.Drawing.Point(6, 30);
            this.rb1Player.Name = "rb1Player";
            this.rb1Player.Size = new System.Drawing.Size(83, 24);
            this.rb1Player.TabIndex = 0;
            this.rb1Player.TabStop = true;
            this.rb1Player.Text = "1 Player";
            this.rb1Player.UseVisualStyleBackColor = true;
            this.rb1Player.CheckedChanged += new System.EventHandler(this.rb1Player_CheckedChanged);
            // 
            // gbModes
            // 
            this.gbModes.Controls.Add(this.rb6x6);
            this.gbModes.Controls.Add(this.rbUltimate);
            this.gbModes.Controls.Add(this.rbNormal);
            this.gbModes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModes.ForeColor = System.Drawing.Color.White;
            this.gbModes.Location = new System.Drawing.Point(441, 61);
            this.gbModes.Name = "gbModes";
            this.gbModes.Size = new System.Drawing.Size(220, 137);
            this.gbModes.TabIndex = 1;
            this.gbModes.TabStop = false;
            this.gbModes.Text = "What Game Mode?";
            // 
            // rb6x6
            // 
            this.rb6x6.AutoSize = true;
            this.rb6x6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb6x6.Location = new System.Drawing.Point(6, 98);
            this.rb6x6.Name = "rb6x6";
            this.rb6x6.Size = new System.Drawing.Size(52, 24);
            this.rb6x6.TabIndex = 2;
            this.rb6x6.TabStop = true;
            this.rb6x6.Text = "6x6";
            this.rb6x6.UseVisualStyleBackColor = true;
            // 
            // rbUltimate
            // 
            this.rbUltimate.AutoSize = true;
            this.rbUltimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUltimate.Location = new System.Drawing.Point(6, 64);
            this.rbUltimate.Name = "rbUltimate";
            this.rbUltimate.Size = new System.Drawing.Size(86, 24);
            this.rbUltimate.TabIndex = 1;
            this.rbUltimate.TabStop = true;
            this.rbUltimate.Text = "Ultimate";
            this.rbUltimate.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(6, 30);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(77, 24);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // lblPlayer1Prompt
            // 
            this.lblPlayer1Prompt.AutoSize = true;
            this.lblPlayer1Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Prompt.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Prompt.Location = new System.Drawing.Point(37, 61);
            this.lblPlayer1Prompt.Name = "lblPlayer1Prompt";
            this.lblPlayer1Prompt.Size = new System.Drawing.Size(159, 25);
            this.lblPlayer1Prompt.TabIndex = 2;
            this.lblPlayer1Prompt.Text = "Player 1 Name:";
            // 
            // lblPlayer2Prompt
            // 
            this.lblPlayer2Prompt.AutoSize = true;
            this.lblPlayer2Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Prompt.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Prompt.Location = new System.Drawing.Point(37, 101);
            this.lblPlayer2Prompt.Name = "lblPlayer2Prompt";
            this.lblPlayer2Prompt.Size = new System.Drawing.Size(159, 25);
            this.lblPlayer2Prompt.TabIndex = 3;
            this.lblPlayer2Prompt.Text = "Player 2 Name:";
            this.lblPlayer2Prompt.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(202, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // lblModeName
            // 
            this.lblModeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeName.ForeColor = System.Drawing.Color.White;
            this.lblModeName.Location = new System.Drawing.Point(436, 231);
            this.lblModeName.Name = "lblModeName";
            this.lblModeName.Size = new System.Drawing.Size(237, 23);
            this.lblModeName.TabIndex = 6;
            this.lblModeName.Text = "*put mode in later";
            // 
            // lblModeDescription
            // 
            this.lblModeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeDescription.ForeColor = System.Drawing.Color.White;
            this.lblModeDescription.Location = new System.Drawing.Point(441, 277);
            this.lblModeDescription.Name = "lblModeDescription";
            this.lblModeDescription.Size = new System.Drawing.Size(232, 154);
            this.lblModeDescription.TabIndex = 7;
            this.lblModeDescription.Text = "*put description in later";
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.White;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(267, 357);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(185, 49);
            this.btnBegin.TabIndex = 8;
            this.btnBegin.Text = "Begin Game";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblModeDescription);
            this.Controls.Add(this.lblModeName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPlayer2Prompt);
            this.Controls.Add(this.lblPlayer1Prompt);
            this.Controls.Add(this.gbModes);
            this.Controls.Add(this.gbPlayers);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Torture!";
            this.gbPlayers.ResumeLayout(false);
            this.gbPlayers.PerformLayout();
            this.gbModes.ResumeLayout(false);
            this.gbModes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayers;
        private System.Windows.Forms.RadioButton rb2Players;
        private System.Windows.Forms.RadioButton rb1Player;
        private System.Windows.Forms.GroupBox gbModes;
        private System.Windows.Forms.RadioButton rb6x6;
        private System.Windows.Forms.RadioButton rbUltimate;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label lblPlayer1Prompt;
        private System.Windows.Forms.Label lblPlayer2Prompt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblModeName;
        private System.Windows.Forms.Label lblModeDescription;
        private System.Windows.Forms.Button btnBegin;
    }
}

