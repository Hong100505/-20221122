namespace Map
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.旅遊查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.城市編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.類型編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.旅遊查詢ToolStripMenuItem,
            this.城市編輯ToolStripMenuItem,
            this.類型編輯ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 旅遊查詢ToolStripMenuItem
			// 
			this.旅遊查詢ToolStripMenuItem.Name = "旅遊查詢ToolStripMenuItem";
			this.旅遊查詢ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.旅遊查詢ToolStripMenuItem.Text = "旅遊查詢";
			this.旅遊查詢ToolStripMenuItem.Click += new System.EventHandler(this.旅遊查詢ToolStripMenuItem_Click);
			// 
			// 城市編輯ToolStripMenuItem
			// 
			this.城市編輯ToolStripMenuItem.Name = "城市編輯ToolStripMenuItem";
			this.城市編輯ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.城市編輯ToolStripMenuItem.Text = "城市編輯";
			this.城市編輯ToolStripMenuItem.Click += new System.EventHandler(this.城市編輯ToolStripMenuItem_Click);
			// 
			// 類型編輯ToolStripMenuItem
			// 
			this.類型編輯ToolStripMenuItem.Name = "類型編輯ToolStripMenuItem";
			this.類型編輯ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.類型編輯ToolStripMenuItem.Text = "類型編輯";
			this.類型編輯ToolStripMenuItem.Click += new System.EventHandler(this.類型編輯ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "旅遊搜尋";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 旅遊查詢ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 城市編輯ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 類型編輯ToolStripMenuItem;
	}
}