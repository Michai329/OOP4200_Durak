
namespace OOP4200_Durak
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDeckSize = new System.Windows.Forms.GroupBox();
            this.grpPlayerCount = new System.Windows.Forms.GroupBox();
            this.radio20Card = new System.Windows.Forms.RadioButton();
            this.radio36Card = new System.Windows.Forms.RadioButton();
            this.radio52Card = new System.Windows.Forms.RadioButton();
            this.radio2Player = new System.Windows.Forms.RadioButton();
            this.radio3Player = new System.Windows.Forms.RadioButton();
            this.radio4Player = new System.Windows.Forms.RadioButton();
            this.radio5Player = new System.Windows.Forms.RadioButton();
            this.radio6Player = new System.Windows.Forms.RadioButton();
            this.grpDeckSize.SuspendLayout();
            this.grpPlayerCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "OOP4200 - Durak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created By: Kristopher Hankey and Michai Pryce";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPlay.Location = new System.Drawing.Point(70, 274);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(96, 40);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnExit.Location = new System.Drawing.Point(217, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpDeckSize
            // 
            this.grpDeckSize.Controls.Add(this.radio36Card);
            this.grpDeckSize.Controls.Add(this.radio52Card);
            this.grpDeckSize.Controls.Add(this.radio20Card);
            this.grpDeckSize.Location = new System.Drawing.Point(12, 97);
            this.grpDeckSize.Name = "grpDeckSize";
            this.grpDeckSize.Size = new System.Drawing.Size(172, 95);
            this.grpDeckSize.TabIndex = 4;
            this.grpDeckSize.TabStop = false;
            this.grpDeckSize.Text = "Deck Size:";
            // 
            // grpPlayerCount
            // 
            this.grpPlayerCount.Controls.Add(this.radio6Player);
            this.grpPlayerCount.Controls.Add(this.radio5Player);
            this.grpPlayerCount.Controls.Add(this.radio4Player);
            this.grpPlayerCount.Controls.Add(this.radio3Player);
            this.grpPlayerCount.Controls.Add(this.radio2Player);
            this.grpPlayerCount.Location = new System.Drawing.Point(190, 97);
            this.grpPlayerCount.Name = "grpPlayerCount";
            this.grpPlayerCount.Size = new System.Drawing.Size(180, 147);
            this.grpPlayerCount.TabIndex = 5;
            this.grpPlayerCount.TabStop = false;
            this.grpPlayerCount.Text = "Player Count:";
            // 
            // radio20Card
            // 
            this.radio20Card.AutoSize = true;
            this.radio20Card.Location = new System.Drawing.Point(6, 19);
            this.radio20Card.Name = "radio20Card";
            this.radio20Card.Size = new System.Drawing.Size(116, 17);
            this.radio20Card.TabIndex = 0;
            this.radio20Card.TabStop = true;
            this.radio20Card.Text = "20 Cards (10 - Ace)";
            this.radio20Card.UseVisualStyleBackColor = true;
            this.radio20Card.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio36Card
            // 
            this.radio36Card.AutoSize = true;
            this.radio36Card.Location = new System.Drawing.Point(6, 42);
            this.radio36Card.Name = "radio36Card";
            this.radio36Card.Size = new System.Drawing.Size(110, 17);
            this.radio36Card.TabIndex = 1;
            this.radio36Card.TabStop = true;
            this.radio36Card.Text = "36 Cards (6 - Ace)";
            this.radio36Card.UseVisualStyleBackColor = true;
            // 
            // radio52Card
            // 
            this.radio52Card.AutoSize = true;
            this.radio52Card.Location = new System.Drawing.Point(6, 65);
            this.radio52Card.Name = "radio52Card";
            this.radio52Card.Size = new System.Drawing.Size(121, 17);
            this.radio52Card.TabIndex = 2;
            this.radio52Card.TabStop = true;
            this.radio52Card.Text = "52 Cards (Full Deck)";
            this.radio52Card.UseVisualStyleBackColor = true;
            // 
            // radio2Player
            // 
            this.radio2Player.AutoSize = true;
            this.radio2Player.Location = new System.Drawing.Point(7, 20);
            this.radio2Player.Name = "radio2Player";
            this.radio2Player.Size = new System.Drawing.Size(83, 17);
            this.radio2Player.TabIndex = 0;
            this.radio2Player.TabStop = true;
            this.radio2Player.Text = "Two Players";
            this.radio2Player.UseVisualStyleBackColor = true;
            // 
            // radio3Player
            // 
            this.radio3Player.AutoSize = true;
            this.radio3Player.Location = new System.Drawing.Point(7, 43);
            this.radio3Player.Name = "radio3Player";
            this.radio3Player.Size = new System.Drawing.Size(90, 17);
            this.radio3Player.TabIndex = 1;
            this.radio3Player.TabStop = true;
            this.radio3Player.Text = "Three Players";
            this.radio3Player.UseVisualStyleBackColor = true;
            // 
            // radio4Player
            // 
            this.radio4Player.AutoSize = true;
            this.radio4Player.Location = new System.Drawing.Point(7, 66);
            this.radio4Player.Name = "radio4Player";
            this.radio4Player.Size = new System.Drawing.Size(83, 17);
            this.radio4Player.TabIndex = 2;
            this.radio4Player.TabStop = true;
            this.radio4Player.Text = "Four Players";
            this.radio4Player.UseVisualStyleBackColor = true;
            // 
            // radio5Player
            // 
            this.radio5Player.AutoSize = true;
            this.radio5Player.Location = new System.Drawing.Point(7, 89);
            this.radio5Player.Name = "radio5Player";
            this.radio5Player.Size = new System.Drawing.Size(82, 17);
            this.radio5Player.TabIndex = 3;
            this.radio5Player.TabStop = true;
            this.radio5Player.Text = "Five Players";
            this.radio5Player.UseVisualStyleBackColor = true;
            // 
            // radio6Player
            // 
            this.radio6Player.AutoSize = true;
            this.radio6Player.Location = new System.Drawing.Point(7, 112);
            this.radio6Player.Name = "radio6Player";
            this.radio6Player.Size = new System.Drawing.Size(76, 17);
            this.radio6Player.TabIndex = 4;
            this.radio6Player.TabStop = true;
            this.radio6Player.Text = "Six Players";
            this.radio6Player.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(382, 366);
            this.Controls.Add(this.grpPlayerCount);
            this.Controls.Add(this.grpDeckSize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grpDeckSize.ResumeLayout(false);
            this.grpDeckSize.PerformLayout();
            this.grpPlayerCount.ResumeLayout(false);
            this.grpPlayerCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDeckSize;
        private System.Windows.Forms.RadioButton radio36Card;
        private System.Windows.Forms.RadioButton radio52Card;
        private System.Windows.Forms.RadioButton radio20Card;
        private System.Windows.Forms.GroupBox grpPlayerCount;
        private System.Windows.Forms.RadioButton radio6Player;
        private System.Windows.Forms.RadioButton radio5Player;
        private System.Windows.Forms.RadioButton radio4Player;
        private System.Windows.Forms.RadioButton radio3Player;
        private System.Windows.Forms.RadioButton radio2Player;
    }
}