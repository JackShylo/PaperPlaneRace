namespace PaperPlaneRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxBets = new System.Windows.Forms.GroupBox();
            this.lblPlane = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.udPlaneID = new System.Windows.Forms.NumericUpDown();
            this.udBet = new System.Windows.Forms.NumericUpDown();
            this.rbnColin = new System.Windows.Forms.RadioButton();
            this.rbnBrian = new System.Windows.Forms.RadioButton();
            this.rbnAllan = new System.Windows.Forms.RadioButton();
            this.lblWinner = new System.Windows.Forms.Label();
            this.txtBalAllan = new System.Windows.Forms.TextBox();
            this.txtBalBrian = new System.Windows.Forms.TextBox();
            this.txtBalColin = new System.Windows.Forms.TextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.pbxPlane4 = new System.Windows.Forms.PictureBox();
            this.pbxPlane3 = new System.Windows.Forms.PictureBox();
            this.pbxPlane2 = new System.Windows.Forms.PictureBox();
            this.pbxPlane1 = new System.Windows.Forms.PictureBox();
            this.pbxRaceTrack = new System.Windows.Forms.PictureBox();
            this.txtBetColin = new System.Windows.Forms.TextBox();
            this.txtBetBrian = new System.Windows.Forms.TextBox();
            this.txtBetAllan = new System.Windows.Forms.TextBox();
            this.gbxBets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPlaneID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBets
            // 
            this.gbxBets.Controls.Add(this.txtBetColin);
            this.gbxBets.Controls.Add(this.txtBetBrian);
            this.gbxBets.Controls.Add(this.txtBetAllan);
            this.gbxBets.Controls.Add(this.btnPlaceBet);
            this.gbxBets.Controls.Add(this.lblBet);
            this.gbxBets.Controls.Add(this.txtBalColin);
            this.gbxBets.Controls.Add(this.txtBalBrian);
            this.gbxBets.Controls.Add(this.txtBalAllan);
            this.gbxBets.Controls.Add(this.lblPlane);
            this.gbxBets.Controls.Add(this.lblAmount);
            this.gbxBets.Controls.Add(this.udPlaneID);
            this.gbxBets.Controls.Add(this.udBet);
            this.gbxBets.Controls.Add(this.rbnColin);
            this.gbxBets.Controls.Add(this.rbnBrian);
            this.gbxBets.Controls.Add(this.rbnAllan);
            this.gbxBets.Location = new System.Drawing.Point(329, 450);
            this.gbxBets.Name = "gbxBets";
            this.gbxBets.Size = new System.Drawing.Size(630, 94);
            this.gbxBets.TabIndex = 8;
            this.gbxBets.TabStop = false;
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.Location = new System.Drawing.Point(135, 38);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(54, 13);
            this.lblPlane.TabIndex = 7;
            this.lblPlane.Text = "On Plane:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(135, 17);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // udPlaneID
            // 
            this.udPlaneID.Enabled = false;
            this.udPlaneID.Location = new System.Drawing.Point(190, 36);
            this.udPlaneID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPlaneID.Name = "udPlaneID";
            this.udPlaneID.Size = new System.Drawing.Size(120, 20);
            this.udPlaneID.TabIndex = 5;
            this.udPlaneID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udBet
            // 
            this.udBet.Enabled = false;
            this.udBet.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udBet.Location = new System.Drawing.Point(190, 15);
            this.udBet.Name = "udBet";
            this.udBet.Size = new System.Drawing.Size(120, 20);
            this.udBet.TabIndex = 3;
            // 
            // rbnColin
            // 
            this.rbnColin.AutoSize = true;
            this.rbnColin.Location = new System.Drawing.Point(78, 57);
            this.rbnColin.Name = "rbnColin";
            this.rbnColin.Size = new System.Drawing.Size(48, 17);
            this.rbnColin.TabIndex = 2;
            this.rbnColin.TabStop = true;
            this.rbnColin.Text = "Colin";
            this.rbnColin.UseVisualStyleBackColor = true;
            this.rbnColin.CheckedChanged += new System.EventHandler(this.rbnAll_CheckedChanged);
            // 
            // rbnBrian
            // 
            this.rbnBrian.AutoSize = true;
            this.rbnBrian.Location = new System.Drawing.Point(78, 36);
            this.rbnBrian.Name = "rbnBrian";
            this.rbnBrian.Size = new System.Drawing.Size(49, 17);
            this.rbnBrian.TabIndex = 1;
            this.rbnBrian.TabStop = true;
            this.rbnBrian.Text = "Brian";
            this.rbnBrian.UseVisualStyleBackColor = true;
            this.rbnBrian.CheckedChanged += new System.EventHandler(this.rbnAll_CheckedChanged);
            // 
            // rbnAllan
            // 
            this.rbnAllan.AutoSize = true;
            this.rbnAllan.Location = new System.Drawing.Point(78, 15);
            this.rbnAllan.Name = "rbnAllan";
            this.rbnAllan.Size = new System.Drawing.Size(48, 17);
            this.rbnAllan.TabIndex = 0;
            this.rbnAllan.TabStop = true;
            this.rbnAllan.Text = "Allan";
            this.rbnAllan.UseVisualStyleBackColor = true;
            this.rbnAllan.CheckedChanged += new System.EventHandler(this.rbnAll_CheckedChanged);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Enabled = false;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(437, 173);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(420, 108);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "X WINS!";
            this.lblWinner.Visible = false;
            // 
            // txtBalAllan
            // 
            this.txtBalAllan.Location = new System.Drawing.Point(6, 13);
            this.txtBalAllan.Name = "txtBalAllan";
            this.txtBalAllan.Size = new System.Drawing.Size(66, 20);
            this.txtBalAllan.TabIndex = 9;
            // 
            // txtBalBrian
            // 
            this.txtBalBrian.Location = new System.Drawing.Point(6, 34);
            this.txtBalBrian.Name = "txtBalBrian";
            this.txtBalBrian.Size = new System.Drawing.Size(66, 20);
            this.txtBalBrian.TabIndex = 10;
            // 
            // txtBalColin
            // 
            this.txtBalColin.Location = new System.Drawing.Point(6, 55);
            this.txtBalColin.Name = "txtBalColin";
            this.txtBalColin.Size = new System.Drawing.Size(66, 20);
            this.txtBalColin.TabIndex = 11;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(162, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(27, 19);
            this.lblBet.TabIndex = 12;
            this.lblBet.Text = "BET";
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.BackgroundImage = global::PaperPlaneRace.Properties.Resources.placeBetButton;
            this.btnPlaceBet.FlatAppearance.BorderSize = 0;
            this.btnPlaceBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceBet.Location = new System.Drawing.Point(190, 57);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(120, 25);
            this.btnPlaceBet.TabIndex = 13;
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Enabled = false;
            this.btnResetGame.FlatAppearance.BorderSize = 0;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.Image = ((System.Drawing.Image)(resources.GetObject("btnResetGame.Image")));
            this.btnResetGame.Location = new System.Drawing.Point(168, 445);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(155, 55);
            this.btnResetGame.TabIndex = 7;
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnStartRace
            // 
            this.btnStartRace.Enabled = false;
            this.btnStartRace.FlatAppearance.BorderSize = 0;
            this.btnStartRace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartRace.Image = global::PaperPlaneRace.Properties.Resources.startGameButton;
            this.btnStartRace.Location = new System.Drawing.Point(12, 445);
            this.btnStartRace.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(155, 55);
            this.btnStartRace.TabIndex = 6;
            this.btnStartRace.UseVisualStyleBackColor = false;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // pbxPlane4
            // 
            this.pbxPlane4.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlane4.Image")));
            this.pbxPlane4.Location = new System.Drawing.Point(12, 336);
            this.pbxPlane4.Name = "pbxPlane4";
            this.pbxPlane4.Size = new System.Drawing.Size(108, 108);
            this.pbxPlane4.TabIndex = 4;
            this.pbxPlane4.TabStop = false;
            // 
            // pbxPlane3
            // 
            this.pbxPlane3.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlane3.Image")));
            this.pbxPlane3.Location = new System.Drawing.Point(12, 228);
            this.pbxPlane3.Name = "pbxPlane3";
            this.pbxPlane3.Size = new System.Drawing.Size(108, 108);
            this.pbxPlane3.TabIndex = 3;
            this.pbxPlane3.TabStop = false;
            // 
            // pbxPlane2
            // 
            this.pbxPlane2.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlane2.Image")));
            this.pbxPlane2.Location = new System.Drawing.Point(12, 120);
            this.pbxPlane2.Name = "pbxPlane2";
            this.pbxPlane2.Size = new System.Drawing.Size(108, 108);
            this.pbxPlane2.TabIndex = 2;
            this.pbxPlane2.TabStop = false;
            // 
            // pbxPlane1
            // 
            this.pbxPlane1.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlane1.Image")));
            this.pbxPlane1.Location = new System.Drawing.Point(12, 12);
            this.pbxPlane1.Name = "pbxPlane1";
            this.pbxPlane1.Size = new System.Drawing.Size(108, 108);
            this.pbxPlane1.TabIndex = 1;
            this.pbxPlane1.TabStop = false;
            // 
            // pbxRaceTrack
            // 
            this.pbxRaceTrack.Image = global::PaperPlaneRace.Properties.Resources.background;
            this.pbxRaceTrack.Location = new System.Drawing.Point(12, 12);
            this.pbxRaceTrack.Name = "pbxRaceTrack";
            this.pbxRaceTrack.Size = new System.Drawing.Size(1280, 432);
            this.pbxRaceTrack.TabIndex = 0;
            this.pbxRaceTrack.TabStop = false;
            // 
            // txtBetColin
            // 
            this.txtBetColin.Location = new System.Drawing.Point(336, 54);
            this.txtBetColin.Name = "txtBetColin";
            this.txtBetColin.Size = new System.Drawing.Size(284, 20);
            this.txtBetColin.TabIndex = 16;
            // 
            // txtBetBrian
            // 
            this.txtBetBrian.Location = new System.Drawing.Point(336, 33);
            this.txtBetBrian.Name = "txtBetBrian";
            this.txtBetBrian.Size = new System.Drawing.Size(284, 20);
            this.txtBetBrian.TabIndex = 15;
            // 
            // txtBetAllan
            // 
            this.txtBetAllan.Location = new System.Drawing.Point(336, 12);
            this.txtBetAllan.Name = "txtBetAllan";
            this.txtBetAllan.Size = new System.Drawing.Size(284, 20);
            this.txtBetAllan.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 582);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.gbxBets);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnStartRace);
            this.Controls.Add(this.pbxPlane4);
            this.Controls.Add(this.pbxPlane3);
            this.Controls.Add(this.pbxPlane2);
            this.Controls.Add(this.pbxPlane1);
            this.Controls.Add(this.pbxRaceTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxBets.ResumeLayout(false);
            this.gbxBets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPlaneID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRaceTrack;
        private System.Windows.Forms.PictureBox pbxPlane1;
        private System.Windows.Forms.PictureBox pbxPlane2;
        private System.Windows.Forms.PictureBox pbxPlane3;
        private System.Windows.Forms.PictureBox pbxPlane4;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.GroupBox gbxBets;
        private System.Windows.Forms.NumericUpDown udBet;
        private System.Windows.Forms.RadioButton rbnColin;
        private System.Windows.Forms.RadioButton rbnBrian;
        private System.Windows.Forms.RadioButton rbnAllan;
        private System.Windows.Forms.NumericUpDown udPlaneID;
        private System.Windows.Forms.Label lblPlane;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.TextBox txtBalColin;
        private System.Windows.Forms.TextBox txtBalBrian;
        private System.Windows.Forms.TextBox txtBalAllan;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.TextBox txtBetColin;
        private System.Windows.Forms.TextBox txtBetBrian;
        private System.Windows.Forms.TextBox txtBetAllan;
    }
}

