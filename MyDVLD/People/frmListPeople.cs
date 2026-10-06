using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
namespace MyDVLD.People
{
	public partial class frmListPeople : Form
	{
		public frmListPeople()
		{
			InitializeComponent();
			_RefreshPeooleList();
		}
		private void _RefreshPeooleList()
		{

			dgvPeople.DataSource = ClsPerson.GetAllPeople(); 
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
