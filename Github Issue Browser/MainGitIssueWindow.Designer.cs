
namespace VFLIssueBrowser
{
    partial class MainGitIssueWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserRepoGroupBox = new System.Windows.Forms.GroupBox();
            this.UserRepoListBox = new System.Windows.Forms.ListBox();
            this.RepoIssuesGroupBox = new System.Windows.Forms.GroupBox();
            this.RepoIssuesListBox = new System.Windows.Forms.ListBox();
            this.IssueGroupBox = new System.Windows.Forms.GroupBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.AuthenticationlStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadUserReposMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.UserRepoGroupBox.SuspendLayout();
            this.RepoIssuesGroupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSplitContainer)).BeginInit();
            this.LeftSplitContainer.Panel1.SuspendLayout();
            this.LeftSplitContainer.Panel2.SuspendLayout();
            this.LeftSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserRepoGroupBox
            // 
            this.UserRepoGroupBox.Controls.Add(this.UserRepoListBox);
            this.UserRepoGroupBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserRepoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserRepoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.UserRepoGroupBox.Name = "UserRepoGroupBox";
            this.UserRepoGroupBox.Size = new System.Drawing.Size(214, 169);
            this.UserRepoGroupBox.TabIndex = 0;
            this.UserRepoGroupBox.TabStop = false;
            this.UserRepoGroupBox.Text = "User Repos";
            // 
            // UserRepoListBox
            // 
            this.UserRepoListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserRepoListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserRepoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserRepoListBox.FormattingEnabled = true;
            this.UserRepoListBox.ItemHeight = 15;
            this.UserRepoListBox.Location = new System.Drawing.Point(3, 19);
            this.UserRepoListBox.Name = "UserRepoListBox";
            this.UserRepoListBox.Size = new System.Drawing.Size(208, 147);
            this.UserRepoListBox.TabIndex = 0;
            // 
            // RepoIssuesGroupBox
            // 
            this.RepoIssuesGroupBox.Controls.Add(this.RepoIssuesListBox);
            this.RepoIssuesGroupBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RepoIssuesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepoIssuesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RepoIssuesGroupBox.Name = "RepoIssuesGroupBox";
            this.RepoIssuesGroupBox.Size = new System.Drawing.Size(214, 226);
            this.RepoIssuesGroupBox.TabIndex = 1;
            this.RepoIssuesGroupBox.TabStop = false;
            this.RepoIssuesGroupBox.Text = "Repo Issues";
            // 
            // RepoIssuesListBox
            // 
            this.RepoIssuesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RepoIssuesListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RepoIssuesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepoIssuesListBox.FormattingEnabled = true;
            this.RepoIssuesListBox.ItemHeight = 15;
            this.RepoIssuesListBox.Location = new System.Drawing.Point(3, 19);
            this.RepoIssuesListBox.Name = "RepoIssuesListBox";
            this.RepoIssuesListBox.Size = new System.Drawing.Size(208, 204);
            this.RepoIssuesListBox.TabIndex = 0;
            // 
            // IssueGroupBox
            // 
            this.IssueGroupBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IssueGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IssueGroupBox.Location = new System.Drawing.Point(0, 0);
            this.IssueGroupBox.Name = "IssueGroupBox";
            this.IssueGroupBox.Size = new System.Drawing.Size(580, 399);
            this.IssueGroupBox.TabIndex = 2;
            this.IssueGroupBox.TabStop = false;
            this.IssueGroupBox.Text = "Issue";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthenticationlStripMenuItem,
            this.ReposToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(798, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // AuthenticationlStripMenuItem
            // 
            this.AuthenticationlStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginStripMenuItem,
            this.LogoutStripMenuItem});
            this.AuthenticationlStripMenuItem.Name = "AuthenticationlStripMenuItem";
            this.AuthenticationlStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.AuthenticationlStripMenuItem.Text = "Authentication";
            // 
            // LoginStripMenuItem
            // 
            this.LoginStripMenuItem.Name = "LoginStripMenuItem";
            this.LoginStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LoginStripMenuItem.Text = "Login";
            this.LoginStripMenuItem.Click += new System.EventHandler(this.LoginStripMenuItem_Click);
            // 
            // LogoutStripMenuItem
            // 
            this.LogoutStripMenuItem.Enabled = false;
            this.LogoutStripMenuItem.Name = "LogoutStripMenuItem";
            this.LogoutStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LogoutStripMenuItem.Text = "Logout";
            this.LogoutStripMenuItem.Click += new System.EventHandler(this.LogoutStripMenuItem_Click);
            // 
            // ReposToolStripMenuItem
            // 
            this.ReposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadUserReposMenuItem});
            this.ReposToolStripMenuItem.Name = "ReposToolStripMenuItem";
            this.ReposToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ReposToolStripMenuItem.Text = "Repos";
            // 
            // LoadUserReposMenuItem
            // 
            this.LoadUserReposMenuItem.Enabled = false;
            this.LoadUserReposMenuItem.Name = "LoadUserReposMenuItem";
            this.LoadUserReposMenuItem.Size = new System.Drawing.Size(161, 22);
            this.LoadUserReposMenuItem.Text = "Load User Repos";
            this.LoadUserReposMenuItem.Click += new System.EventHandler(this.loadUserReposToolStripMenuItem_Click);
            // 
            // LeftSplitContainer
            // 
            this.LeftSplitContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.LeftSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.LeftSplitContainer.Name = "LeftSplitContainer";
            this.LeftSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LeftSplitContainer.Panel1
            // 
            this.LeftSplitContainer.Panel1.Controls.Add(this.UserRepoGroupBox);
            // 
            // LeftSplitContainer.Panel2
            // 
            this.LeftSplitContainer.Panel2.Controls.Add(this.RepoIssuesGroupBox);
            this.LeftSplitContainer.Size = new System.Drawing.Size(214, 399);
            this.LeftSplitContainer.SplitterDistance = 169;
            this.LeftSplitContainer.TabIndex = 4;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.LeftSplitContainer);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.IssueGroupBox);
            this.MainSplitContainer.Size = new System.Drawing.Size(798, 399);
            this.MainSplitContainer.SplitterDistance = 214;
            this.MainSplitContainer.TabIndex = 5;
            // 
            // MainGitIssueWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 423);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainGitIssueWindow";
            this.Text = "VFL Issue Browser";
            this.UserRepoGroupBox.ResumeLayout(false);
            this.RepoIssuesGroupBox.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.LeftSplitContainer.Panel1.ResumeLayout(false);
            this.LeftSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftSplitContainer)).EndInit();
            this.LeftSplitContainer.ResumeLayout(false);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UserRepoGroupBox;
        private System.Windows.Forms.GroupBox RepoIssuesGroupBox;
        private System.Windows.Forms.GroupBox IssueGroupBox;
        private System.Windows.Forms.ListBox UserRepoListBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AuthenticationlStripMenuItem;
        private System.Windows.Forms.ListBox RepoIssuesListBox;
        private System.Windows.Forms.ToolStripMenuItem ReposToolStripMenuItem;
        private System.Windows.Forms.SplitContainer LeftSplitContainer;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem LoginStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem LogoutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadUserReposMenuItem;
    }
}

