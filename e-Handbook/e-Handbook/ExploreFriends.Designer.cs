
namespace e_Handbook
{
    partial class ExploreFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploreFriends));
            this.toHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.bottomContainer = new System.Windows.Forms.Panel();
            this.bottomFakeStroke = new System.Windows.Forms.Panel();
            this.socialTabHeader = new System.Windows.Forms.PictureBox();
            this.eHandbookLogo = new System.Windows.Forms.PictureBox();
            this.topContainer = new System.Windows.Forms.Panel();
            this.topFakeStroke = new System.Windows.Forms.Panel();
            this.exploreFriendViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.comboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bottomContainer.SuspendLayout();
            this.bottomFakeStroke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socialTabHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHandbookLogo)).BeginInit();
            this.topContainer.SuspendLayout();
            this.topFakeStroke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).BeginInit();
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
            this.toHome.TabIndex = 37;
            this.toHome.Text = "Return";
            this.toHome.UseMnemonic = false;
            this.toHome.UseVisualStyleBackColor = false;
            this.toHome.Click += new System.EventHandler(this.toHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "EXPLORE FRIENDS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(13, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(19, 18);
            this.exit.TabIndex = 21;
            this.exit.Text = "x";
            this.exit.UseMnemonic = false;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bottomContainer
            // 
            this.bottomContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bottomContainer.Controls.Add(this.exit);
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
            this.bottomFakeStroke.TabIndex = 25;
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
            this.topFakeStroke.Controls.Add(this.topContainer);
            this.topFakeStroke.Controls.Add(this.label2);
            this.topFakeStroke.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFakeStroke.Location = new System.Drawing.Point(0, 0);
            this.topFakeStroke.Name = "topFakeStroke";
            this.topFakeStroke.Size = new System.Drawing.Size(800, 134);
            this.topFakeStroke.TabIndex = 24;
            // 
            // exploreFriendViewer
            // 
            this.exploreFriendViewer.ArrowheadLength = 10D;
            this.exploreFriendViewer.AsyncLayout = false;
            this.exploreFriendViewer.AutoScroll = true;
            this.exploreFriendViewer.BackColor = System.Drawing.Color.White;
            this.exploreFriendViewer.BackwardEnabled = false;
            this.exploreFriendViewer.BuildHitTree = true;
            this.exploreFriendViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.exploreFriendViewer.EdgeInsertButtonVisible = true;
            this.exploreFriendViewer.FileName = "";
            this.exploreFriendViewer.ForwardEnabled = false;
            this.exploreFriendViewer.Graph = null;
            this.exploreFriendViewer.InsertingEdge = false;
            this.exploreFriendViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.exploreFriendViewer.LayoutEditingEnabled = true;
            this.exploreFriendViewer.Location = new System.Drawing.Point(12, 152);
            this.exploreFriendViewer.LooseOffsetForRouting = 0.25D;
            this.exploreFriendViewer.MouseHitDistance = 0.05D;
            this.exploreFriendViewer.Name = "exploreFriendViewer";
            this.exploreFriendViewer.NavigationVisible = true;
            this.exploreFriendViewer.NeedToCalculateLayout = true;
            this.exploreFriendViewer.OffsetForRelaxingInRouting = 0.6D;
            this.exploreFriendViewer.PaddingForEdgeRouting = 8D;
            this.exploreFriendViewer.PanButtonPressed = false;
            this.exploreFriendViewer.SaveAsImageEnabled = true;
            this.exploreFriendViewer.SaveAsMsaglEnabled = true;
            this.exploreFriendViewer.SaveButtonVisible = true;
            this.exploreFriendViewer.SaveGraphButtonVisible = true;
            this.exploreFriendViewer.SaveInVectorFormatEnabled = true;
            this.exploreFriendViewer.Size = new System.Drawing.Size(638, 256);
            this.exploreFriendViewer.TabIndex = 38;
            this.exploreFriendViewer.TightOffsetForRouting = 0.125D;
            this.exploreFriendViewer.ToolBarIsVisible = true;
            this.exploreFriendViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("exploreFriendViewer.Transform")));
            this.exploreFriendViewer.UndoRedoButtonsVisible = true;
            this.exploreFriendViewer.WindowZoomButtonPressed = false;
            this.exploreFriendViewer.ZoomF = 1D;
            this.exploreFriendViewer.ZoomWindowThreshold = 0.05D;
            // 
            // ExploreFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exploreFriendViewer);
            this.Controls.Add(this.toHome);
            this.Controls.Add(this.bottomFakeStroke);
            this.Controls.Add(this.topFakeStroke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExploreFriends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Handbook Social Tab";
            this.bottomContainer.ResumeLayout(false);
            this.bottomFakeStroke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.socialTabHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHandbookLogo)).EndInit();
            this.topContainer.ResumeLayout(false);
            this.topFakeStroke.ResumeLayout(false);
            this.topFakeStroke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button toHome;
        private System.Windows.Forms.BindingSource comboItemBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel bottomContainer;
        private System.Windows.Forms.Panel bottomFakeStroke;
        private System.Windows.Forms.PictureBox socialTabHeader;
        private System.Windows.Forms.PictureBox eHandbookLogo;
        private System.Windows.Forms.Panel topContainer;
        private System.Windows.Forms.Panel topFakeStroke;
        private Microsoft.Msagl.GraphViewerGdi.GViewer exploreFriendViewer;
    }
}