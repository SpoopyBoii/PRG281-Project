
namespace PRG281_Project
{
    partial class uc_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Home));
            this.lblHomeWelcome = new System.Windows.Forms.Label();
            this.rbxHome_Info = new System.Windows.Forms.RichTextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeWelcome
            // 
            this.lblHomeWelcome.AutoSize = true;
            this.lblHomeWelcome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.lblHomeWelcome.Location = new System.Drawing.Point(33, 28);
            this.lblHomeWelcome.Name = "lblHomeWelcome";
            this.lblHomeWelcome.Size = new System.Drawing.Size(303, 28);
            this.lblHomeWelcome.TabIndex = 0;
            this.lblHomeWelcome.Text = "Welcome to Muzik Mash!";
            this.lblHomeWelcome.Click += new System.EventHandler(this.lblHomeWelcome_Click_1);
            // 
            // rbxHome_Info
            // 
            this.rbxHome_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbxHome_Info.BackColor = System.Drawing.SystemColors.Control;
            this.rbxHome_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rbxHome_Info.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbxHome_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(207)))));
            this.rbxHome_Info.Location = new System.Drawing.Point(38, 85);
            this.rbxHome_Info.Name = "rbxHome_Info";
            this.rbxHome_Info.ReadOnly = true;
            this.rbxHome_Info.Size = new System.Drawing.Size(771, 425);
            this.rbxHome_Info.TabIndex = 1;
            this.rbxHome_Info.Text = resources.GetString("rbxHome_Info.Text");
            // 
            // picLogo
            // 
            this.picLogo.Image = global::PRG281_Project.Properties.Resources.Icon;
            this.picLogo.Location = new System.Drawing.Point(752, 125);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 300);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // uc_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.rbxHome_Info);
            this.Controls.Add(this.lblHomeWelcome);
            this.Name = "uc_Home";
            this.Size = new System.Drawing.Size(1080, 600);
            this.Load += new System.EventHandler(this.uc_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHomeWelcome;
        public System.Windows.Forms.RichTextBox rbxHome_Info;
        public System.Windows.Forms.PictureBox picLogo;
    }
}
