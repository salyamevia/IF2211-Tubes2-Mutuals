﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploreFriends));
            this.toHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bottomContainer = new System.Windows.Forms.Panel();
            this.bottomFakeStroke = new System.Windows.Forms.Panel();
            this.socialTabHeader = new System.Windows.Forms.PictureBox();
            this.eHandbookLogo = new System.Windows.Forms.PictureBox();
            this.topContainer = new System.Windows.Forms.Panel();
            this.topFakeStroke = new System.Windows.Forms.Panel();
            this.algoUsed = new System.Windows.Forms.Label();
            this.exploreFriendViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.errorDialog = new System.Windows.Forms.Label();
            this.errorDialogContainer = new System.Windows.Forms.Panel();
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
            this.label2.Size = new System.Drawing.Size(222, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "EXPLORE FRIENDS ";
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
            this.topFakeStroke.Controls.Add(this.algoUsed);
            this.topFakeStroke.Controls.Add(this.topContainer);
            this.topFakeStroke.Controls.Add(this.label2);
            this.topFakeStroke.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFakeStroke.Location = new System.Drawing.Point(0, 0);
            this.topFakeStroke.Name = "topFakeStroke";
            this.topFakeStroke.Size = new System.Drawing.Size(800, 134);
            this.topFakeStroke.TabIndex = 24;
            // 
            // algoUsed
            // 
            this.algoUsed.AutoSize = true;
            this.algoUsed.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoUsed.ForeColor = System.Drawing.Color.White;
            this.algoUsed.Location = new System.Drawing.Point(249, 92);
            this.algoUsed.Name = "algoUsed";
            this.algoUsed.Size = new System.Drawing.Size(0, 24);
            this.algoUsed.TabIndex = 31;
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
            // errorDialog
            // 
            this.errorDialog.AutoSize = true;
            this.errorDialog.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.errorDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.errorDialog.Location = new System.Drawing.Point(685, 189);
            this.errorDialog.Name = "errorDialog";
            this.errorDialog.Size = new System.Drawing.Size(0, 18);
            this.errorDialog.TabIndex = 39;
            // 
            // errorDialogContainer
            // 
            this.errorDialogContainer.Location = new System.Drawing.Point(682, 189);
            this.errorDialogContainer.Name = "errorDialogContainer";
            this.errorDialogContainer.Size = new System.Drawing.Size(106, 136);
            this.errorDialogContainer.TabIndex = 40;
            // 
            // ExploreFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorDialog);
            this.Controls.Add(this.errorDialogContainer);
            this.Controls.Add(this.exploreFriendViewer);
            this.Controls.Add(this.toHome);
            this.Controls.Add(this.bottomFakeStroke);
            this.Controls.Add(this.topFakeStroke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExploreFriends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Handbook Social Tab";
            this.bottomFakeStroke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.socialTabHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHandbookLogo)).EndInit();
            this.topContainer.ResumeLayout(false);
            this.topFakeStroke.ResumeLayout(false);
            this.topFakeStroke.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button toHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bottomContainer;
        private System.Windows.Forms.Panel bottomFakeStroke;
        private System.Windows.Forms.PictureBox socialTabHeader;
        private System.Windows.Forms.PictureBox eHandbookLogo;
        private System.Windows.Forms.Panel topContainer;
        private System.Windows.Forms.Panel topFakeStroke;
        private Microsoft.Msagl.GraphViewerGdi.GViewer exploreFriendViewer;
        private System.Windows.Forms.Label errorDialog;
        private System.Windows.Forms.Label algoUsed;
        private System.Windows.Forms.Panel errorDialogContainer;
    }
}