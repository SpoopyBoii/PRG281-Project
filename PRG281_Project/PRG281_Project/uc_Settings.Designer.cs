
namespace PRG281_Project
{
    partial class uc_Settings
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
            this.lblTargetScoreNum = new System.Windows.Forms.Label();
            this.lblTargetScore = new System.Windows.Forms.Label();
            this.chkDarkmode = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblSingleplayer = new System.Windows.Forms.Label();
            this.lblMultiplayer = new System.Windows.Forms.Label();
            this.lblTotalTurns = new System.Windows.Forms.Label();
            this.lblTotalTurnsNum = new System.Windows.Forms.Label();
            this.cbTotalTurns = new System.Windows.Forms.ComboBox();
            this.cbTotalScore = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTargetScoreNum
            // 
            this.lblTargetScoreNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTargetScoreNum.AutoSize = true;
            this.lblTargetScoreNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblTargetScoreNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetScoreNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblTargetScoreNum.Location = new System.Drawing.Point(26, 259);
            this.lblTargetScoreNum.Name = "lblTargetScoreNum";
            this.lblTargetScoreNum.Size = new System.Drawing.Size(130, 23);
            this.lblTargetScoreNum.TabIndex = 7;
            this.lblTargetScoreNum.Text = "Target Score:";
            // 
            // lblTargetScore
            // 
            this.lblTargetScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTargetScore.AutoSize = true;
            this.lblTargetScore.BackColor = System.Drawing.SystemColors.Control;
            this.lblTargetScore.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblTargetScore.Location = new System.Drawing.Point(27, 241);
            this.lblTargetScore.Name = "lblTargetScore";
            this.lblTargetScore.Size = new System.Drawing.Size(348, 18);
            this.lblTargetScore.TabIndex = 8;
            this.lblTargetScore.Text = "First one to reach this score in multiplayer wins:";
            // 
            // chkDarkmode
            // 
            this.chkDarkmode.AutoSize = true;
            this.chkDarkmode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDarkmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDarkmode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.chkDarkmode.Location = new System.Drawing.Point(30, 45);
            this.chkDarkmode.Name = "chkDarkmode";
            this.chkDarkmode.Size = new System.Drawing.Size(186, 28);
            this.chkDarkmode.TabIndex = 13;
            this.chkDarkmode.Text = "Toggle Dark Mode";
            this.chkDarkmode.UseVisualStyleBackColor = false;
            this.chkDarkmode.CheckedChanged += new System.EventHandler(this.chkDarkmode_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnSave.Location = new System.Drawing.Point(30, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(268, 70);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGeneral
            // 
            this.lblGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.lblGeneral.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblGeneral.Location = new System.Drawing.Point(24, 10);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(121, 32);
            this.lblGeneral.TabIndex = 15;
            this.lblGeneral.Text = "General";
            // 
            // lblSingleplayer
            // 
            this.lblSingleplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSingleplayer.AutoSize = true;
            this.lblSingleplayer.BackColor = System.Drawing.SystemColors.Control;
            this.lblSingleplayer.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleplayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblSingleplayer.Location = new System.Drawing.Point(24, 94);
            this.lblSingleplayer.Name = "lblSingleplayer";
            this.lblSingleplayer.Size = new System.Drawing.Size(288, 32);
            this.lblSingleplayer.TabIndex = 16;
            this.lblSingleplayer.Text = "Single Player Settings";
            // 
            // lblMultiplayer
            // 
            this.lblMultiplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMultiplayer.AutoSize = true;
            this.lblMultiplayer.BackColor = System.Drawing.SystemColors.Control;
            this.lblMultiplayer.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblMultiplayer.Location = new System.Drawing.Point(24, 200);
            this.lblMultiplayer.Name = "lblMultiplayer";
            this.lblMultiplayer.Size = new System.Drawing.Size(266, 32);
            this.lblMultiplayer.TabIndex = 17;
            this.lblMultiplayer.Text = "Multiplayer Settings";
            // 
            // lblTotalTurns
            // 
            this.lblTotalTurns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalTurns.AutoSize = true;
            this.lblTotalTurns.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalTurns.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblTotalTurns.Location = new System.Drawing.Point(27, 134);
            this.lblTotalTurns.Name = "lblTotalTurns";
            this.lblTotalTurns.Size = new System.Drawing.Size(247, 18);
            this.lblTotalTurns.TabIndex = 19;
            this.lblTotalTurns.Text = "Total turns in single player mode:";
            // 
            // lblTotalTurnsNum
            // 
            this.lblTotalTurnsNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalTurnsNum.AutoSize = true;
            this.lblTotalTurnsNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalTurnsNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurnsNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblTotalTurnsNum.Location = new System.Drawing.Point(26, 152);
            this.lblTotalTurnsNum.Name = "lblTotalTurnsNum";
            this.lblTotalTurnsNum.Size = new System.Drawing.Size(106, 23);
            this.lblTotalTurnsNum.TabIndex = 18;
            this.lblTotalTurnsNum.Text = "Total turns:";
            // 
            // cbTotalTurns
            // 
            this.cbTotalTurns.BackColor = System.Drawing.SystemColors.Control;
            this.cbTotalTurns.FormattingEnabled = true;
            this.cbTotalTurns.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cbTotalTurns.Location = new System.Drawing.Point(138, 157);
            this.cbTotalTurns.Name = "cbTotalTurns";
            this.cbTotalTurns.Size = new System.Drawing.Size(121, 21);
            this.cbTotalTurns.TabIndex = 20;
            this.cbTotalTurns.Text = "5";
            // 
            // cbTotalScore
            // 
            this.cbTotalScore.BackColor = System.Drawing.SystemColors.Control;
            this.cbTotalScore.FormattingEnabled = true;
            this.cbTotalScore.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cbTotalScore.Location = new System.Drawing.Point(162, 264);
            this.cbTotalScore.Name = "cbTotalScore";
            this.cbTotalScore.Size = new System.Drawing.Size(121, 21);
            this.cbTotalScore.TabIndex = 21;
            this.cbTotalScore.Text = "5";
            // 
            // uc_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cbTotalScore);
            this.Controls.Add(this.cbTotalTurns);
            this.Controls.Add(this.lblTotalTurns);
            this.Controls.Add(this.lblTotalTurnsNum);
            this.Controls.Add(this.lblMultiplayer);
            this.Controls.Add(this.lblSingleplayer);
            this.Controls.Add(this.lblGeneral);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkDarkmode);
            this.Controls.Add(this.lblTargetScore);
            this.Controls.Add(this.lblTargetScoreNum);
            this.Load += new System.EventHandler(this.uc_Settings_Load);
            this.Name = "uc_Settings";
            this.Size = new System.Drawing.Size(1080, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTargetScoreNum;
        private System.Windows.Forms.Label lblTargetScore;
        private System.Windows.Forms.CheckBox chkDarkmode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblSingleplayer;
        private System.Windows.Forms.Label lblMultiplayer;
        private System.Windows.Forms.Label lblTotalTurns;
        private System.Windows.Forms.Label lblTotalTurnsNum;
        private System.Windows.Forms.ComboBox cbTotalTurns;
        private System.Windows.Forms.ComboBox cbTotalScore;
    }
}
