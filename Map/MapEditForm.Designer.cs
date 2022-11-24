namespace Map
{
	partial class MapEditForm
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
			this.kindoffunTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.updateButton = new System.Windows.Forms.Button();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// kindoffunTextBox
			// 
			this.kindoffunTextBox.Location = new System.Drawing.Point(86, 30);
			this.kindoffunTextBox.Name = "kindoffunTextBox";
			this.kindoffunTextBox.Size = new System.Drawing.Size(171, 22);
			this.kindoffunTextBox.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 20;
			this.label4.Text = "種類:";
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(86, 159);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 19;
			this.updateButton.Text = "Save";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(86, 114);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(171, 22);
			this.nameTextBox.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 13;
			this.label3.Text = "名稱:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(86, 86);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(171, 22);
			this.addressTextBox.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 14;
			this.label2.Text = "地址:";
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(86, 58);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(171, 22);
			this.cityTextBox.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 16;
			this.label1.Text = "城市:";
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(182, 159);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 22;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// MapEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 227);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.kindoffunTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.label1);
			this.Name = "MapEditForm";
			this.Text = "MapEditForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox kindoffunTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button deleteButton;
	}
}