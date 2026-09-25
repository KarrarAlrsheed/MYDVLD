using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDVLD.People;
namespace MyDVLD
{
	public partial class MainFrm : Form
	{
		public MainFrm()
		{
			InitializeComponent();
		}

		private void MainFrm_Load(object sender, EventArgs e)
		{
		}

		private void applecationToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new MangePeopleFrm();
			frm.ShowDialog(); 
		}
	}
}
