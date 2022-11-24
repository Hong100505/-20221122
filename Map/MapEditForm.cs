using ISPan.Utility;
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
	public partial class MapEditForm : Form
	{
		private int id;
		public MapEditForm(int id)
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
			string sql = "SELECT * FROM map_project WHERE Id=@Id";
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
			MapVM model = ToMapVM(data.Rows[0]);

			// 再將 viewModel值繫結到各控制項
			
			kindoffunTextBox.Text = model.KindOfFun;
			addressTextBox.Text = model.Address;
			nameTextBox.Text = model.Name;
			cityTextBox.Text = model.City;
			
		}
		private MapVM ToMapVM(DataRow row)
		{
			return new MapVM
			{
				Id = row.Field<int>("Id"),
				KindOfFun = row.Field<string>("KindOfFun"),
				Address = row.Field<string>("Address"),
				Name = row.Field<string>("Name"),
				City = row.Field<string>("City"),
			};
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string kindoffun = kindoffunTextBox.Text;
			string address = addressTextBox.Text;
			string name = nameTextBox.Text;
			string city = cityTextBox.Text;

			// 將它們繫結到ViewModel
			MapVM model = new MapVM
			{
				KindOfFun = kindoffun,
				Address = address,
				City = city,
				Name = name,
				Id = id
			};

			// 針對ViewModel進行欄位驗證
			//string errorMsg = string.Empty;
			//if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名稱必填\r\n";
			//if (model.ListPrice < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

			//if (string.IsNullOrEmpty(errorMsg) == false)
			//{
			//	//表示至少一欄有錯誤
			//	MessageBox.Show(errorMsg);
			//	return; // 不再向下執行
			//}

			// update record
			string sql = @"UPDATE map_project
			SET KindOfFun=@KindOfFun, Address=@Address, City = @City,Name=@Name
			WHERE Id=@Id";

			var parameters = new SqlParametersBuider()
				.AddNVarchar("KindOfFun", 50, model.KindOfFun)
				.AddNVarchar("Address", 50, model.Address)
				.AddNVarchar("City", 50, model.City)
				.AddNVarchar("Name", 50, model.Name)
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

			string sql = @"DELETE FROM map_project WHERE Id=@Id";

			var parameters = new SqlParametersBuider()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		
	}
}

