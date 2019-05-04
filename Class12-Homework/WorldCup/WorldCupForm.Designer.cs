namespace WorldCup
{
    partial class WorldCupForm
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
            this.cbxTeams = new System.Windows.Forms.ComboBox();
            this.lblSelectedTeam = new System.Windows.Forms.Label();
            this.pboxBadge = new System.Windows.Forms.PictureBox();
            this.pboxTeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBadge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTeams
            // 
            this.cbxTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTeams.FormattingEnabled = true;
            this.cbxTeams.Location = new System.Drawing.Point(24, 15);
            this.cbxTeams.Margin = new System.Windows.Forms.Padding(6);
            this.cbxTeams.Name = "cbxTeams";
            this.cbxTeams.Size = new System.Drawing.Size(238, 38);
            this.cbxTeams.TabIndex = 0;
            this.cbxTeams.SelectedIndexChanged += new System.EventHandler(this.cbxTeams_SelectedIndexChanged);
            // 
            // lblSelectedTeam
            // 
            this.lblSelectedTeam.AutoSize = true;
            this.lblSelectedTeam.Location = new System.Drawing.Point(320, 15);
            this.lblSelectedTeam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedTeam.Name = "lblSelectedTeam";
            this.lblSelectedTeam.Size = new System.Drawing.Size(0, 31);
            this.lblSelectedTeam.TabIndex = 1;
            // 
            // pboxBadge
            // 
            this.pboxBadge.Location = new System.Drawing.Point(24, 60);
            this.pboxBadge.Name = "pboxBadge";
            this.pboxBadge.Size = new System.Drawing.Size(296, 317);
            this.pboxBadge.TabIndex = 2;
            this.pboxBadge.TabStop = false;
            // 
            // pboxTeam
            // 
            this.pboxTeam.Location = new System.Drawing.Point(326, 60);
            this.pboxTeam.Name = "pboxTeam";
            this.pboxTeam.Size = new System.Drawing.Size(472, 317);
            this.pboxTeam.TabIndex = 3;
            this.pboxTeam.TabStop = false;
            // 
            // WorldCupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 889);
            this.Controls.Add(this.pboxTeam);
            this.Controls.Add(this.pboxBadge);
            this.Controls.Add(this.lblSelectedTeam);
            this.Controls.Add(this.cbxTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1084, 936);
            this.Name = "WorldCupForm";
            this.Text = "World Cup Images";
            this.Load += new System.EventHandler(this.WorldCupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBadge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeams;
        private System.Windows.Forms.Label lblSelectedTeam;
        private System.Windows.Forms.PictureBox pboxBadge;
        private System.Windows.Forms.PictureBox pboxTeam;
    }
}

