using ISPan.Utility;
using Map.Infra;
using Map.User;
using Map.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
	public partial class CreateCityForm : Form
	{
		private CitynameVM[] products = null;
		public CreateCityForm()
		{
			InitializeComponent();
			DisplayCity();
		}

		private void DisplayCity()
		{
			string sql = "select * from citytable";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			products = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();

			BindData(products);

		}
		private void BindData(CitynameVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private CitynameVM ParseToIndexVM(DataRow row)  //視窗
		{
			return new CitynameVM
			{
				Id = row.Field<int>("Id"),
				Cityname = row.Field<string>("Cityname"),

			};
		}

		private CitynameIndexVM ToCityNameIndexVM(DataRow row)  //視窗
		{
			return new CitynameIndexVM
			{
				//Id = row.Field<int>("Id"),
				Cityname = row.Field<string>("Cityname"),

			};
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string city = cityTextBox.Text;


			// 將它們繫結到ViewModel
			CitynameVM model = new CitynameVM
			{
				Cityname = city,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Cityname", cityTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			//};



			//string sql = @"INSERT INTO Citytable (Cityname)
			//			 VALUES
			//			(@Cityname)";

			//var parameters = new SqlParametersBuider()
			//	.AddNVarchar("Cityname", 50, model.Cityname)
			//	.Build();

			//new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			//this.DialogResult = DialogResult.OK;
			//DisplayCity();
			try
			{
				Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			CitynameVM row = this.products[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditCityForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayCity();
			}

		}





		public void Create(CitynameVM model)
		{
			bool isExists = AccountExists(model.Cityname);
			if (isExists) throw new Exception("帳號已存在");


			string sql = @"INSERT INTO citytable (Cityname)
						 VALUES
						(@Cityname)";

			var parameters = new SqlParametersBuider()
				.AddNVarchar("Cityname", 50, model.Cityname)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			this.DialogResult = DialogResult.OK;
			DisplayCity();
		}



		public bool AccountExists(string Cityname)
		{
			string sql = @"SELECT Count(*) as count FROM citytable WHERE Cityname=@Cityname";

			var parameters = new SqlParametersBuider()
				.AddNVarchar("Cityname", 50,Cityname)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
	}
}
