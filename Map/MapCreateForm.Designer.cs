namespace Map
{
	partial class MapCreateForm
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
			this.saveButton = new System.Windows.Forms.Button();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cityComboBox = new System.Windows.Forms.ComboBox();
			this.mapCityVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kofComboBox = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.mapCityVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(184, 149);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "新增";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(88, 109);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(171, 22);
			this.nameTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "名稱:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(88, 81);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(171, 22);
			this.addressTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "地址:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "城市:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 11;
			this.label4.Text = "種類:";
			// 
			// cityComboBox
			// 
			this.cityComboBox.DataSource = this.mapCityVMBindingSource;
			this.cityComboBox.DisplayMember = "Cityname";
			this.cityComboBox.FormattingEnabled = true;
			this.cityComboBox.Location = new System.Drawing.Point(88, 53);
			this.cityComboBox.Name = "cityComboBox";
			this.cityComboBox.Size = new System.Drawing.Size(171, 20);
			this.cityComboBox.TabIndex = 1;
			this.cityComboBox.ValueMember = "Id";
			// 
			// mapCityVMBindingSource
			// 
			this.mapCityVMBindingSource.DataSource = typeof(Map.ViewModels.MapCityVM);
			// 
			// kofComboBox
			// 
			this.kofComboBox.DataSource = this.mapCityVMBindingSource;
			this.kofComboBox.DisplayMember = "Cityname";
			this.kofComboBox.FormattingEnabled = true;
			this.kofComboBox.Location = new System.Drawing.Point(88, 25);
			this.kofComboBox.Name = "kofComboBox";
			this.kofComboBox.Size = new System.Drawing.Size(171, 20);
			this.kofComboBox.TabIndex = 0;
			this.kofComboBox.ValueMember = "Id";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// MapCreateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 204);
			this.Controls.Add(this.kofComboBox);
			this.Controls.Add(this.cityComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MapCreateForm";
			this.Text = "新增資料";
			((System.ComponentModel.ISupportInitialize)(this.mapCityVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cityComboBox;
		private System.Windows.Forms.BindingSource mapCityVMBindingSource;
		private System.Windows.Forms.ComboBox kofComboBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}