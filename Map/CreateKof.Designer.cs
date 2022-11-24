namespace Map
{
	partial class CreateKof
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
			this.kofTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.kofindexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kindOfFunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kofindexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(166, 60);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "加入";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// kofTextBox
			// 
			this.kofTextBox.Location = new System.Drawing.Point(70, 19);
			this.kofTextBox.Name = "kofTextBox";
			this.kofTextBox.Size = new System.Drawing.Size(171, 22);
			this.kofTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "種類:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kindOfFunDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.kofindexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(34, 105);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(207, 223);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// kofindexVMBindingSource
			// 
			this.kofindexVMBindingSource.DataSource = typeof(Map.ViewModels.KofindexVM);
			// 
			// kindOfFunDataGridViewTextBoxColumn
			// 
			this.kindOfFunDataGridViewTextBoxColumn.DataPropertyName = "KindOfFun";
			this.kindOfFunDataGridViewTextBoxColumn.HeaderText = "類型";
			this.kindOfFunDataGridViewTextBoxColumn.Name = "kindOfFunDataGridViewTextBoxColumn";
			this.kindOfFunDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// CreateKof
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 345);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.kofTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CreateKof";
			this.Text = "類型設定";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kofindexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox kofTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.BindingSource kofindexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn kindOfFunDataGridViewTextBoxColumn;
	}
}