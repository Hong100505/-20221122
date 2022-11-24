namespace Map
{
	partial class EditCityForm
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
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(146, 69);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 2;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(50, 69);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 1;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(50, 23);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(171, 22);
			this.cityTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 25;
			this.label2.Text = "城市:";
			// 
			// EditCityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 116);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Name = "EditCityForm";
			this.Text = "編輯城市";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label label2;
	}
}