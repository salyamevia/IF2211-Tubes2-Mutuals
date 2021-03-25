
namespace e_Handbook
{
    partial class FriendRecommendation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendRecommendation));
            this.toHome = new System.Windows.Forms.Button();
            this.friendRecTitle = new System.Windows.Forms.Label();
            this.bottomContainer = new System.Windows.Forms.Panel();
            this.bottomFakeStroke = new System.Windows.Forms.Panel();
            this.socialTabHeader = new System.Windows.Forms.PictureBox();
            this.eHandbookLogo = new System.Windows.Forms.PictureBox();
            this.topContainer = new System.Windows.Forms.Panel();
            this.topFakeStroke = new System.Windows.Forms.Panel();
            this.chosenAccount = new System.Windows.Forms.Label();
            this.friendListContainer = new System.Windows.Forms.Panel();
            this.bottomFakeStroke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socialTabHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHandbookLogo)).BeginInit();
            this.topContainer.SuspendLayout();
            this.topFakeStroke.SuspendLayout();
            this.SuspendLayout();
            // 
            // toHome
            // 
            this.toHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.toHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toHome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toHome.ForeColor = System.Drawing.Color.White;
            this.toHome.Location = new System.Drawing.Point(682, 381);
            this.toHome.Name = "toHome";
            this.toHome.Size = new System.Drawing.Size(106, 27);
            this.toHome.TabIndex = 41;
            this.toHome.Text = "Return";
            this.toHome.UseMnemonic = false;
            this.toHome.UseVisualStyleBackColor = false;
            this.toHome.Click += new System.EventHandler(this.toHome_Click_1);
            // 
            // friendRecTitle
            // 
            this.friendRecTitle.AutoSize = true;
            this.friendRecTitle.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendRecTitle.ForeColor = System.Drawing.Color.White;
            this.friendRecTitle.Location = new System.Drawing.Point(21, 92);
            this.friendRecTitle.Name = "friendRecTitle";
            this.friendRecTitle.Size = new System.Drawing.Size(392, 24);
            this.friendRecTitle.TabIndex = 30;
            this.friendRecTitle.Text = "FRIEND RECOMMENDATION(S) FOR";
            this.friendRecTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // bottomContainer
            // 
            this.bottomContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomContainer.Location = new System.Drawing.Point(0, 3);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Size = new System.Drawing.Size(800, 24);
            this.bottomContainer.TabIndex = 3;
            // 
            // bottomFakeStroke
            // 
            this.bottomFakeStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.bottomFakeStroke.Controls.Add(this.bottomContainer);
            this.bottomFakeStroke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomFakeStroke.Location = new System.Drawing.Point(0, 423);
            this.bottomFakeStroke.Name = "bottomFakeStroke";
            this.bottomFakeStroke.Size = new System.Drawing.Size(800, 27);
            this.bottomFakeStroke.TabIndex = 40;
            // 
            // socialTabHeader
            // 
            this.socialTabHeader.Image = ((System.Drawing.Image)(resources.GetObject("socialTabHeader.Image")));
            this.socialTabHeader.Location = new System.Drawing.Point(23, 21);
            this.socialTabHeader.Name = "socialTabHeader";
            this.socialTabHeader.Size = new System.Drawing.Size(213, 41);
            this.socialTabHeader.TabIndex = 3;
            this.socialTabHeader.TabStop = false;
            // 
            // eHandbookLogo
            // 
            this.eHandbookLogo.Image = ((System.Drawing.Image)(resources.GetObject("eHandbookLogo.Image")));
            this.eHandbookLogo.Location = new System.Drawing.Point(551, 12);
            this.eHandbookLogo.Name = "eHandbookLogo";
            this.eHandbookLogo.Size = new System.Drawing.Size(228, 50);
            this.eHandbookLogo.TabIndex = 0;
            this.eHandbookLogo.TabStop = false;
            // 
            // topContainer
            // 
            this.topContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.topContainer.Controls.Add(this.socialTabHeader);
            this.topContainer.Controls.Add(this.eHandbookLogo);
            this.topContainer.Location = new System.Drawing.Point(0, 0);
            this.topContainer.Name = "topContainer";
            this.topContainer.Size = new System.Drawing.Size(800, 77);
            this.topContainer.TabIndex = 1;
            // 
            // topFakeStroke
            // 
            this.topFakeStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.topFakeStroke.Controls.Add(this.chosenAccount);
            this.topFakeStroke.Controls.Add(this.topContainer);
            this.topFakeStroke.Controls.Add(this.friendRecTitle);
            this.topFakeStroke.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFakeStroke.Location = new System.Drawing.Point(0, 0);
            this.topFakeStroke.Name = "topFakeStroke";
            this.topFakeStroke.Size = new System.Drawing.Size(800, 134);
            this.topFakeStroke.TabIndex = 39;
            // 
            // chosenAccount
            // 
            this.chosenAccount.AutoSize = true;
            this.chosenAccount.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenAccount.ForeColor = System.Drawing.Color.White;
            this.chosenAccount.Location = new System.Drawing.Point(419, 92);
            this.chosenAccount.Name = "chosenAccount";
            this.chosenAccount.Size = new System.Drawing.Size(0, 24);
            this.chosenAccount.TabIndex = 31;
            // 
            // friendListContainer
            // 
            this.friendListContainer.AutoScroll = true;
            this.friendListContainer.Location = new System.Drawing.Point(0, 140);
            this.friendListContainer.Name = "friendListContainer";
            this.friendListContainer.Size = new System.Drawing.Size(635, 277);
            this.friendListContainer.TabIndex = 42;
            // 
            // FriendRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.friendListContainer);
            this.Controls.Add(this.toHome);
            this.Controls.Add(this.bottomFakeStroke);
            this.Controls.Add(this.topFakeStroke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FriendRecommendation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Handbook Social Tab";
            this.bottomFakeStroke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.socialTabHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHandbookLogo)).EndInit();
            this.topContainer.ResumeLayout(false);
            this.topFakeStroke.ResumeLayout(false);
            this.topFakeStroke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button toHome;
        private System.Windows.Forms.Label friendRecTitle;
        private System.Windows.Forms.Panel bottomContainer;
        private System.Windows.Forms.Panel bottomFakeStroke;
        private System.Windows.Forms.PictureBox socialTabHeader;
        private System.Windows.Forms.PictureBox eHandbookLogo;
        private System.Windows.Forms.Panel topContainer;
        private System.Windows.Forms.Panel topFakeStroke;
        private System.Windows.Forms.Label chosenAccount;
        private System.Windows.Forms.Panel friendListContainer;
    }
}