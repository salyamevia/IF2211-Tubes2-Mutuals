
namespace e_Handbook
{
    partial class mainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainContainer));
            this.topFakeStroke = new System.Windows.Forms.Panel();
            this.topContainer = new System.Windows.Forms.Panel();
            this.socialTabHeader = new System.Windows.Forms.PictureBox();
            this.eHandbookLogo = new System.Windows.Forms.PictureBox();
            this.bottomFakeStroke = new System.Windows.Forms.Panel();
            this.bottomContainer = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.graphFile = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.algorithm = new System.Windows.Forms.Label();
            this.radioDFS = new System.Windows.Forms.RadioButton();
            this.radioBFS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdownExploreFriends = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.fileGraphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.toExploreFriends = new System.Windows.Forms.Button();
            this.toFriendRec = new System.Windows.Forms.Button();
            this.filenameContainer = new System.Windows.Forms.Panel();
            this.filename = new System.Windows.Forms.Label();
            this.radioButtonContainer = new System.Windows.Forms.Panel();
            this.dropdownAccount = new System.Windows.Forms.ComboBox();
            this.comboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topFakeStroke.SuspendLayout();
            this.topContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socialTabHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHandbookLogo)).BeginInit();
            this.bottomFakeStroke.SuspendLayout();
            this.bottomContainer.SuspendLayout();
            this.filenameContainer.SuspendLayout();
            this.radioButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topFakeStroke
            // 
            this.topFakeStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.topFakeStroke.Controls.Add(this.topContainer);
            this.topFakeStroke.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFakeStroke.Location = new System.Drawing.Point(0, 0);
            this.topFakeStroke.Name = "topFakeStroke";
            this.topFakeStroke.Size = new System.Drawing.Size(800, 80);
            this.topFakeStroke.TabIndex = 0;
            this.topFakeStroke.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.topContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // socialTabHeader
            // 
            this.socialTabHeader.Image = ((System.Drawing.Image)(resources.GetObject("socialTabHeader.Image")));
            this.socialTabHeader.Location = new System.Drawing.Point(23, 21);
            this.socialTabHeader.Name = "socialTabHeader";
            this.socialTabHeader.Size = new System.Drawing.Size(213, 41);
            this.socialTabHeader.TabIndex = 3;
            this.socialTabHeader.TabStop = false;
            this.socialTabHeader.Click += new System.EventHandler(this.socialTabHeader_Click);
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
            // bottomFakeStroke
            // 
            this.bottomFakeStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.bottomFakeStroke.Controls.Add(this.bottomContainer);
            this.bottomFakeStroke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomFakeStroke.Location = new System.Drawing.Point(0, 423);
            this.bottomFakeStroke.Name = "bottomFakeStroke";
            this.bottomFakeStroke.Size = new System.Drawing.Size(800, 27);
            this.bottomFakeStroke.TabIndex = 2;
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
            this.exit.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // graphFile
            // 
            this.graphFile.AutoSize = true;
            this.graphFile.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.graphFile.Location = new System.Drawing.Point(19, 102);
            this.graphFile.Name = "graphFile";
            this.graphFile.Size = new System.Drawing.Size(117, 24);
            this.graphFile.TabIndex = 4;
            this.graphFile.Text = "Graph File";
            this.graphFile.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(148, 103);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(94, 24);
            this.browse.TabIndex = 5;
            this.browse.Text = "Browse";
            this.browse.UseMnemonic = false;
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // algorithm
            // 
            this.algorithm.AutoSize = true;
            this.algorithm.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.algorithm.Location = new System.Drawing.Point(19, 158);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(111, 24);
            this.algorithm.TabIndex = 7;
            this.algorithm.Text = "Algorithm";
            this.algorithm.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // radioDFS
            // 
            this.radioDFS.AutoSize = true;
            this.radioDFS.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioDFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.radioDFS.Location = new System.Drawing.Point(3, 3);
            this.radioDFS.Name = "radioDFS";
            this.radioDFS.Size = new System.Drawing.Size(49, 22);
            this.radioDFS.TabIndex = 8;
            this.radioDFS.TabStop = true;
            this.radioDFS.Text = "DFS";
            this.radioDFS.UseVisualStyleBackColor = true;
            this.radioDFS.CheckedChanged += new System.EventHandler(this.radioDFS_CheckedChanged);
            // 
            // radioBFS
            // 
            this.radioBFS.AutoSize = true;
            this.radioBFS.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioBFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.radioBFS.Location = new System.Drawing.Point(4, 28);
            this.radioBFS.Name = "radioBFS";
            this.radioBFS.Size = new System.Drawing.Size(48, 22);
            this.radioBFS.TabIndex = 9;
            this.radioBFS.TabStop = true;
            this.radioBFS.Text = "BFS";
            this.radioBFS.UseVisualStyleBackColor = true;
            this.radioBFS.CheckedChanged += new System.EventHandler(this.radioBFS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(21, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.label2.Location = new System.Drawing.Point(19, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dropdownExploreFriends
            // 
            this.dropdownExploreFriends.BackColor = System.Drawing.SystemColors.Window;
            this.dropdownExploreFriends.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownExploreFriends.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownExploreFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dropdownExploreFriends.FormattingEnabled = true;
            this.dropdownExploreFriends.Location = new System.Drawing.Point(148, 314);
            this.dropdownExploreFriends.Name = "dropdownExploreFriends";
            this.dropdownExploreFriends.Size = new System.Drawing.Size(149, 26);
            this.dropdownExploreFriends.TabIndex = 15;
            this.dropdownExploreFriends.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.label3.Location = new System.Drawing.Point(19, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Friends";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.label4.Location = new System.Drawing.Point(19, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Explore";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Days One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.label5.Location = new System.Drawing.Point(19, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "with";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(258, 377);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(94, 24);
            this.submit.TabIndex = 17;
            this.submit.Text = "Submit";
            this.submit.UseMnemonic = false;
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // fileGraphViewer
            // 
            this.fileGraphViewer.ArrowheadLength = 10D;
            this.fileGraphViewer.AsyncLayout = false;
            this.fileGraphViewer.AutoScroll = true;
            this.fileGraphViewer.BackColor = System.Drawing.Color.White;
            this.fileGraphViewer.BackwardEnabled = false;
            this.fileGraphViewer.BuildHitTree = true;
            this.fileGraphViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.fileGraphViewer.EdgeInsertButtonVisible = true;
            this.fileGraphViewer.FileName = "";
            this.fileGraphViewer.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.fileGraphViewer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.fileGraphViewer.ForwardEnabled = false;
            this.fileGraphViewer.Graph = null;
            this.fileGraphViewer.InsertingEdge = false;
            this.fileGraphViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.fileGraphViewer.LayoutEditingEnabled = true;
            this.fileGraphViewer.Location = new System.Drawing.Point(392, 95);
            this.fileGraphViewer.LooseOffsetForRouting = 0.25D;
            this.fileGraphViewer.MouseHitDistance = 0.05D;
            this.fileGraphViewer.Name = "fileGraphViewer";
            this.fileGraphViewer.NavigationVisible = true;
            this.fileGraphViewer.NeedToCalculateLayout = true;
            this.fileGraphViewer.OffsetForRelaxingInRouting = 0.6D;
            this.fileGraphViewer.PaddingForEdgeRouting = 8D;
            this.fileGraphViewer.PanButtonPressed = false;
            this.fileGraphViewer.SaveAsImageEnabled = true;
            this.fileGraphViewer.SaveAsMsaglEnabled = true;
            this.fileGraphViewer.SaveButtonVisible = true;
            this.fileGraphViewer.SaveGraphButtonVisible = true;
            this.fileGraphViewer.SaveInVectorFormatEnabled = true;
            this.fileGraphViewer.Size = new System.Drawing.Size(396, 254);
            this.fileGraphViewer.TabIndex = 18;
            this.fileGraphViewer.TightOffsetForRouting = 0.125D;
            this.fileGraphViewer.ToolBarIsVisible = true;
            this.fileGraphViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("fileGraphViewer.Transform")));
            this.fileGraphViewer.UndoRedoButtonsVisible = true;
            this.fileGraphViewer.WindowZoomButtonPressed = false;
            this.fileGraphViewer.ZoomF = 1D;
            this.fileGraphViewer.ZoomWindowThreshold = 0.05D;
            this.fileGraphViewer.Load += new System.EventHandler(this.fileGraphViewer_Load);
            // 
            // toExploreFriends
            // 
            this.toExploreFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.toExploreFriends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toExploreFriends.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toExploreFriends.ForeColor = System.Drawing.Color.White;
            this.toExploreFriends.Location = new System.Drawing.Point(392, 369);
            this.toExploreFriends.Name = "toExploreFriends";
            this.toExploreFriends.Size = new System.Drawing.Size(187, 40);
            this.toExploreFriends.TabIndex = 19;
            this.toExploreFriends.Text = "Explore Friends";
            this.toExploreFriends.UseMnemonic = false;
            this.toExploreFriends.UseVisualStyleBackColor = false;
            this.toExploreFriends.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toFriendRec
            // 
            this.toFriendRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.toFriendRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toFriendRec.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFriendRec.ForeColor = System.Drawing.Color.White;
            this.toFriendRec.Location = new System.Drawing.Point(596, 369);
            this.toFriendRec.Name = "toFriendRec";
            this.toFriendRec.Size = new System.Drawing.Size(192, 40);
            this.toFriendRec.TabIndex = 20;
            this.toFriendRec.Text = "Friend Recommendation";
            this.toFriendRec.UseMnemonic = false;
            this.toFriendRec.UseVisualStyleBackColor = false;
            this.toFriendRec.Click += new System.EventHandler(this.toFriendRec_Click);
            // 
            // filenameContainer
            // 
            this.filenameContainer.AutoScroll = true;
            this.filenameContainer.Controls.Add(this.filename);
            this.filenameContainer.Location = new System.Drawing.Point(248, 102);
            this.filenameContainer.Name = "filenameContainer";
            this.filenameContainer.Size = new System.Drawing.Size(126, 25);
            this.filenameContainer.TabIndex = 21;
            this.filenameContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.filename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.filename.Location = new System.Drawing.Point(0, 1);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(0, 18);
            this.filename.TabIndex = 0;
            // 
            // radioButtonContainer
            // 
            this.radioButtonContainer.Controls.Add(this.radioDFS);
            this.radioButtonContainer.Controls.Add(this.radioBFS);
            this.radioButtonContainer.Location = new System.Drawing.Point(148, 158);
            this.radioButtonContainer.Name = "radioButtonContainer";
            this.radioButtonContainer.Size = new System.Drawing.Size(149, 53);
            this.radioButtonContainer.TabIndex = 22;
            this.radioButtonContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.radioButtonContainer_Paint);
            // 
            // dropdownAccount
            // 
            this.dropdownAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownAccount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dropdownAccount.FormattingEnabled = true;
            this.dropdownAccount.Location = new System.Drawing.Point(148, 238);
            this.dropdownAccount.Name = "dropdownAccount";
            this.dropdownAccount.Size = new System.Drawing.Size(149, 26);
            this.dropdownAccount.TabIndex = 23;
            this.dropdownAccount.SelectedIndexChanged += new System.EventHandler(this.dropdownAccount_SelectedIndexChanged);
            // 
            // mainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dropdownAccount);
            this.Controls.Add(this.radioButtonContainer);
            this.Controls.Add(this.filenameContainer);
            this.Controls.Add(this.toFriendRec);
            this.Controls.Add(this.toExploreFriends);
            this.Controls.Add(this.fileGraphViewer);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dropdownExploreFriends);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.graphFile);
            this.Controls.Add(this.bottomFakeStroke);
            this.Controls.Add(this.topFakeStroke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Handbook Social Tab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topFakeStroke.ResumeLayout(false);
            this.topContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.socialTabHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eHandbookLogo)).EndInit();
            this.bottomFakeStroke.ResumeLayout(false);
            this.bottomContainer.ResumeLayout(false);
            this.filenameContainer.ResumeLayout(false);
            this.filenameContainer.PerformLayout();
            this.radioButtonContainer.ResumeLayout(false);
            this.radioButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topFakeStroke;
        private System.Windows.Forms.Panel topContainer;
        private System.Windows.Forms.Panel bottomFakeStroke;
        private System.Windows.Forms.Panel bottomContainer;
        private System.Windows.Forms.PictureBox eHandbookLogo;
        private System.Windows.Forms.PictureBox socialTabHeader;
        private System.Windows.Forms.Label graphFile;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label algorithm;
        private System.Windows.Forms.RadioButton radioDFS;
        private System.Windows.Forms.RadioButton radioBFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropdownExploreFriends;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit;
        private Microsoft.Msagl.GraphViewerGdi.GViewer fileGraphViewer;
        private System.Windows.Forms.Button toExploreFriends;
        private System.Windows.Forms.Button toFriendRec;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel filenameContainer;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Panel radioButtonContainer;
        private System.Windows.Forms.BindingSource comboItemBindingSource;
        private System.Windows.Forms.ComboBox dropdownAccount;
    }
}

