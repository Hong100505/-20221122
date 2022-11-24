namespace Map
{
	partial class MapForm
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
			this.mapMainVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mapIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.SearchButton = new System.Windows.Forms.Button();
			this.cityComboBox = new System.Windows.Forms.ComboBox();
			this.mapCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kindoffunComboBox = new System.Windows.Forms.ComboBox();
			this.mapKofVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mapCategoryVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.mapIndexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.likeTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kindOfFunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mapMainVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mapIndexBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mapCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mapKofVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mapCategoryVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mapIndexBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.kindOfFunDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.mapMainVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(18, 138);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.Size = new System.Drawing.Size(569, 229);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// mapMainVMBindingSource
			// 
			this.mapMainVMBindingSource.DataSource = typeof(Map.ViewModels.MapMainVM);
			// 
			// mapIndexBindingSource
			// 
			this.mapIndexBindingSource.DataSource = typeof(Map.ViewModels.MapIndex);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(249, 34);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 3;
			this.SearchButton.Text = "搜尋";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// cityComboBox
			// 
			this.cityComboBox.DataSource = this.mapCategoryVMBindingSource;
			this.cityComboBox.DisplayMember = "City";
			this.cityComboBox.FormattingEnabled = true;
			this.cityComboBox.Location = new System.Drawing.Point(95, 36);
			this.cityComboBox.Name = "cityComboBox";
			this.cityComboBox.Size = new System.Drawing.Size(121, 20);
			this.cityComboBox.TabIndex = 0;
			this.cityComboBox.ValueMember = "Id";
			this.cityComboBox.Click += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
			// 
			// mapCategoryVMBindingSource
			// 
			this.mapCategoryVMBindingSource.DataSource = typeof(Map.ViewModels.MapCategoryVM);
			// 
			// kindoffunComboBox
			// 
			this.kindoffunComboBox.DataSource = this.mapKofVMBindingSource;
			this.kindoffunComboBox.DisplayMember = "KindOfFun";
			this.kindoffunComboBox.FormattingEnabled = true;
			this.kindoffunComboBox.Location = new System.Drawing.Point(95, 62);
			this.kindoffunComboBox.Name = "kindoffunComboBox";
			this.kindoffunComboBox.Size = new System.Drawing.Size(121, 20);
			this.kindoffunComboBox.TabIndex = 1;
			this.kindoffunComboBox.ValueMember = "Id";
			// 
			// mapKofVMBindingSource
			// 
			this.mapKofVMBindingSource.DataSource = typeof(Map.ViewModels.MapKofVM);
			// 
			// mapCategoryVMBindingSource1
			// 
			this.mapCategoryVMBindingSource1.DataSource = typeof(Map.ViewModels.MapCategoryVM);
			// 
			// mapIndexBindingSource1
			// 
			this.mapIndexBindingSource1.DataSource = typeof(Map.ViewModels.MapIndex);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(512, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "新增內容";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.addnewButton_Click);
			// 
			// likeTextBox
			// 
			this.likeTextBox.Location = new System.Drawing.Point(95, 88);
			this.likeTextBox.Name = "likeTextBox";
			this.likeTextBox.Size = new System.Drawing.Size(121, 22);
			this.likeTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "縣市";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "類型";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 13;
			this.label3.Text = "關鍵字";
			// 
			// cityDataGridViewTextBoxColumn
			// 
			this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
			this.cityDataGridViewTextBoxColumn.HeaderText = "城市";
			this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
			this.cityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// kindOfFunDataGridViewTextBoxColumn
			// 
			this.kindOfFunDataGridViewTextBoxColumn.DataPropertyName = "KindOfFun";
			this.kindOfFunDataGridViewTextBoxColumn.HeaderText = "種類";
			this.kindOfFunDataGridViewTextBoxColumn.Name = "kindOfFunDataGridViewTextBoxColumn";
			this.kindOfFunDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "名稱";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 130;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressDataGridViewTextBoxColumn.Width = 200;
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 378);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.likeTextBox);
			this.Controls.Add(this.kindoffunComboBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.cityComboBox);
			this.Name = "MapForm";
			this.Text = "旅遊搜尋";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mapMainVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mapIndexBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mapCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mapKofVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mapCategoryVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mapIndexBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.ComboBox cityComboBox;
		private System.Windows.Forms.BindingSource mapIndexBindingSource;
		private System.Windows.Forms.ComboBox kindoffunComboBox;
		private System.Windows.Forms.BindingSource mapCategoryVMBindingSource;
		private System.Windows.Forms.BindingSource mapCategoryVMBindingSource1;
		private System.Windows.Forms.BindingSource mapIndexBindingSource1;
		private System.Windows.Forms.BindingSource mapKofVMBindingSource;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox likeTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource mapMainVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kindOfFunDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
	}
}