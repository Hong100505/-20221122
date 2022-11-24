using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			this.IsMdiContainer = true;
		}

		private void 旅遊查詢ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new MapForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 城市編輯ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new CreateCityForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			this.Close();


		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void 類型編輯ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new CreateKof();
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
