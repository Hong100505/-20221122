namespace Map
{
	partial class CreateCityForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.citynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.citynameIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.citynameVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.citynameVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.citynameIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.citynameVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.citynameVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citynameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.citynameIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(30, 107);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.Size = new System.Drawing.Size(207, 235);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(66, 21);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(171, 22);
			this.cityTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "城市:";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(162, 62);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "加入";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// citynameDataGridViewTextBoxColumn
			// 
			this.citynameDataGridViewTextBoxColumn.DataPropertyName = "Cityname";
			this.citynameDataGridViewTextBoxColumn.HeaderText = "Cityname";
			this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
			this.citynameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// citynameIndexVMBindingSource
			// 
			this.citynameIndexVMBindingSource.DataSource = typeof(Map.ViewModels.CitynameIndexVM);
			// 
			// citynameVMBindingSource1
			// 
			this.citynameVMBindingSource1.DataSource = typeof(Map.ViewModels.CitynameVM);
			// 
			// citynameVMBindingSource
			// 
			this.citynameVMBindingSource.DataSource = typeof(Map.ViewModels.CitynameVM);
			// 
			// CreateCityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 363);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CreateCityForm";
			this.Text = "城市編輯";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.citynameIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.citynameVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.citynameVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource citynameVMBindingSource;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.BindingSource citynameVMBindingSource1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.BindingSource citynameIndexVMBindingSource;
	}
}