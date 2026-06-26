namespace MyDVLD
{
	partial class MainFrm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.applecationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applecationToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(221, 9);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(679, 72);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// applecationToolStripMenuItem
			// 
			this.applecationToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.Application_Types_64;
			this.applecationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.applecationToolStripMenuItem.Name = "applecationToolStripMenuItem";
			this.applecationToolStripMenuItem.Size = new System.Drawing.Size(162, 68);
			this.applecationToolStripMenuItem.Text = "Applecation ";
			// 
			// peopleToolStripMenuItem
			// 
			this.peopleToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.People_64;
			this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
			this.peopleToolStripMenuItem.Size = new System.Drawing.Size(130, 68);
			this.peopleToolStripMenuItem.Text = "People ";
			// 
			// driversToolStripMenuItem
			// 
			this.driversToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.Drivers_64;
			this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
			this.driversToolStripMenuItem.Size = new System.Drawing.Size(128, 68);
			this.driversToolStripMenuItem.Text = "Drivers";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.Users_2_64;
			this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(117, 68);
			this.usersToolStripMenuItem.Text = "Users";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.account_settings_64;
			this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(134, 68);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MyDVLD.Properties.Resources.wallpaper;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1166, 569);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem applecationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}

