using ISPan.Utility;
using Map.Infra;
using Map.ViewModels;
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
	public partial class EditCityForm : Form
	{
		private int id;
		public EditCityForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM citytable WHERE Id=@Id";
			var parameters = new SqlParametersBuider()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);


			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				// this.Close();
				return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			CitynameVM model = ToCityVM(data.Rows[0]);

			// 再將 viewModel值繫結到各控制項


			cityTextBox.Text = model.Cityname;
			

		}
		private CitynameVM ToCityVM(DataRow row)
		{
			return new CitynameVM
			{
				Id = row.Field<int>("Id"),
				Cityname = row.Field<string>("Cityname"),
				
			};
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string getcityname = cityTextBox.Text;
			

			// 將它們繫結到ViewModel
			CitynameVM model = new CitynameVM
			{
				Cityname = getcityname,
				
				Id = id
			};

			// 針對ViewModel進行欄位驗證
			//Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			//{
			//	{"Cityname", cityTextBox},
			//};

			//bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			//if (!isValid) return;

			// update record
			string sql = @"UPDATE citytable
SET Cityname=@Cityname
WHERE Id=@Id";

			var parameters = new SqlParametersBuider()
				.AddNVarchar("Cityname", 50, model.Cityname)
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = @"DELETE FROM citytable WHERE Id=@Id";

			var parameters = new SqlParametersBuider()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
