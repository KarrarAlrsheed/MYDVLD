namespace MyDVLD.People.Contrals
{
	partial class PersonInofWithFiltterControl
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
			this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
			this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
			this.performanceCounter3 = new System.Diagnostics.PerformanceCounter();
			this.personInfoControl1 = new MyDVLD.People.Contrals.PersonInfoControl();
			this.Filtergb = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).BeginInit();
			this.Filtergb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// personInfoControl1
			// 
			this.personInfoControl1.AccessibleName = "PersonInfoControl";
			this.personInfoControl1.Location = new System.Drawing.Point(138, 176);
			this.personInfoControl1.Name = "personInfoControl1";
			this.personInfoControl1.Size = new System.Drawing.Size(856, 295);
			this.personInfoControl1.TabIndex = 0;
			// 
			// Filtergb
			// 
			this.Filtergb.Controls.Add(this.pictureBox1);
			this.Filtergb.Controls.Add(this.pictureBox2);
			this.Filtergb.Controls.Add(this.comboBox1);
			this.Filtergb.Controls.Add(this.label4);
			this.Filtergb.Location = new System.Drawing.Point(138, 120);
			this.Filtergb.Name = "Filtergb";
			this.Filtergb.Size = new System.Drawing.Size(847, 59);
			this.Filtergb.TabIndex = 1;
			this.Filtergb.TabStop = false;
			this.Filtergb.Text = "Filter";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Find By";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "1",
            "1",
            "1"});
			this.comboBox1.Location = new System.Drawing.Point(75, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDVLD.Properties.Resources.Add_Person_40;
			this.pictureBox1.Location = new System.Drawing.Point(284, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 23);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDVLD.Properties.Resources.SearchPerson;
			this.pictureBox2.Location = new System.Drawing.Point(234, 26);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 23);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			// 
			// PersonInofWithFiltterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Filtergb);
			this.Controls.Add(this.personInfoControl1);
			this.Name = "PersonInofWithFiltterControl";
			this.Size = new System.Drawing.Size(1218, 641);
			this.Load += new System.EventHandler(this.PersonInofWithFiltterControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).EndInit();
			this.Filtergb.ResumeLayout(false);
			this.Filtergb.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Diagnostics.PerformanceCounter performanceCounter1;
		private System.Diagnostics.PerformanceCounter performanceCounter2;
		private System.Diagnostics.PerformanceCounter performanceCounter3;
		private PersonInfoControl personInfoControl1;
		private System.Windows.Forms.GroupBox Filtergb;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}
