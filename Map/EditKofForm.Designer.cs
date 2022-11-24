namespace Map
{
	partial class EditKofForm
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
			this.kofTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// kofTextBox
			// 
			this.kofTextBox.Location = new System.Drawing.Point(94, 46);
			this.kofTextBox.Name = "kofTextBox";
			this.kofTextBox.Size = new System.Drawing.Size(171, 22);
			this.kofTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 29;
			this.label2.Text = "種類:";
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(190, 92);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 2;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(94, 92);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 1;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// EditKofForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 166);
			this.Controls.Add(this.kofTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Name = "EditKofForm";
			this.Text = "編輯類型";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox kofTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button updateButton;
	}
}