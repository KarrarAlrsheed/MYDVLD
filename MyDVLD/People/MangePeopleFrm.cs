using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLD.People
{
	public partial class MangePeopleFrm : Form
	{
		public MangePeopleFrm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Form frm = new AddUpdateFrm();
			frm.ShowDialog();
		}

		private void showDeToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
