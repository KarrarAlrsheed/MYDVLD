namespace MyDVLD.People
{
	partial class frmListPeople
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPeople = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deletePoersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkRed;
			this.label1.Location = new System.Drawing.Point(494, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mange People";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dgvPeople
			// 
			this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPeople.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvPeople.Location = new System.Drawing.Point(-1, 237);
			this.dgvPeople.Name = "dgvPeople";
			this.dgvPeople.Size = new System.Drawing.Size(1167, 202);
			this.dgvPeople.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDeToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deletePoersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(195, 232);
			// 
			// showDeToolStripMenuItem
			// 
			this.showDeToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.PersonDetails_32;
			this.showDeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showDeToolStripMenuItem.Name = "showDeToolStripMenuItem";
			this.showDeToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
			this.showDeToolStripMenuItem.Text = "Show Details";
			this.showDeToolStripMenuItem.Click += new System.EventHandler(this.showDeToolStripMenuItem_Click);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.AddPerson_32;
			this.addToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
			this.addToolStripMenuItem.Text = "Add New Person ";
			// 
			// deletePoersonToolStripMenuItem
			// 
			this.deletePoersonToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.edit_32;
			this.deletePoersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deletePoersonToolStripMenuItem.Name = "deletePoersonToolStripMenuItem";
			this.deletePoersonToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
			this.deletePoersonToolStripMenuItem.Text = "Editen ";
			// 
			// deletePersonToolStripMenuItem
			// 
			this.deletePersonToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.Delete_32;
			this.deletePersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
			this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
			this.deletePersonToolStripMenuItem.Text = "Delete ";
			this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
			// 
			// sendEmailToolStripMenuItem
			// 
			this.sendEmailToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.send_email_32;
			this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
			this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
			this.sendEmailToolStripMenuItem.Text = "Send Email";
			// 
			// phoneToolStripMenuItem
			// 
			this.phoneToolStripMenuItem.Image = global::MyDVLD.Properties.Resources.Phone_321;
			this.phoneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
			this.phoneToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
			this.phoneToolStripMenuItem.Text = "Phone Call";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDVLD.Properties.Resources.Add_Person_72;
			this.pictureBox2.Location = new System.Drawing.Point(1103, 181);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(55, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD.Properties.Resources.People_400;
			this.pictureBox1.Location = new System.Drawing.Point(498, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(102, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// frmListPeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1170, 591);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.dgvPeople);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmListPeople";
			this.Text = "MangePeople";
			((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvPeople;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deletePoersonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
	}
}