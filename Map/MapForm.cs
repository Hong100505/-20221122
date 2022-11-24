using ISPan.Utility;
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
	public partial class MapForm : Form
	{
		private MapIndex[] products = null;
		public MapForm()
		{
			InitializeComponent();

			InitForm();

			InitFormKOF();

			DisplayMap();

		}
		private void DisplayMap()
		{
			
			//string sql = @" SELECT * FROM map_project";
			string sql = "SELECT * FROM map_project";

			#region 加入 where 
			
			SqlParameter[] parameters = new SqlParameter[] { };

			//取得篩選值
			string cityName = cityComboBox.SelectedItem.ToString();
			string kofId = kindoffunComboBox.SelectedItem.ToString();
			string like = likeTextBox.Text;

			if (cityName != string.Empty && kofId != string.Empty && like !=string.Empty )
			{
				//sql += " WHERE KindOfFun=@KindOfFun and City=@City";
				sql += " where Name like '%' + @like +'%' and KindOfFun=@KindOfFun";

				parameters = new SqlParametersBuider()
					.AddNVarchar("KindOfFun", 50, kofId)
					.AddNVarchar("like", 50, like)
					.AddNVarchar("City", 50, cityName)
					.Build();
			}
			else if (cityName == string.Empty && kofId != string.Empty && like != string.Empty)
			{
				sql += " where Name like '%' + @like +'%' and KindOfFun=@KindOfFun";
				parameters = new SqlParametersBuider()
					.AddNVarchar("KindOfFun", 50, kofId)
					.AddNVarchar("like", 50, like)
					.Build();
			}
			else if (cityName != string.Empty && kofId == string.Empty && like != string.Empty)
			{
				sql += " where Name like '%' + @like +'%' and City=@City";
				parameters = new SqlParametersBuider()
					.AddNVarchar("like", 50, like)
					.AddNVarchar("City", 50, cityName)
					.Build();
			}
			else if (cityName != string.Empty && kofId != string.Empty && like == string.Empty)
			{
				sql += " WHERE KindOfFun=@KindOfFun and City=@City";
				parameters = new SqlParametersBuider()
					.AddNVarchar("KindOfFun", 50, kofId)
					.AddNVarchar("City", 50, cityName)
					.Build();
			}
			else if (cityName == string.Empty && kofId == string.Empty && like != string.Empty)
			{
				sql += " where Name like '%' + @like +'%' ";
				parameters = new SqlParametersBuider()
					.AddNVarchar("like", 50, like)
					.Build();
			}
			else if (cityName != string.Empty && kofId == string.Empty && like == string.Empty)
			{
				sql += " WHERE City=@City";
				parameters = new SqlParametersBuider()
					.AddNVarchar("City", 50, cityName)
					.Build();
			}
			else if (cityName == string.Empty && kofId != string.Empty && like == string.Empty)
			{
				sql += " WHERE KindOfFun=@KindOfFun";
				parameters = new SqlParametersBuider()
					.AddNVarchar("KindOfFun", 50, kofId)
					.Build();
			}
			//都沒填
			else if (cityName == string.Empty && kofId == string.Empty && like == string.Empty)
			{
				sql += " ";
				parameters = new SqlParametersBuider()
					.Build();
			}
			


			#endregion

			// 加入排序子句ㄐ
			sql += " ORDER BY City";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			products = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();

			BindData(products);
		}
		private void BindData(MapIndex[] products)
		{
			dataGridView1.DataSource = products;
		}
		private MapIndex ParseToIndexVM(DataRow row)  //視窗
		{
			return new MapIndex
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				Address = row.Field<string>("Address"),
				City = row.Field<string>("City"),
				KindOfFun = row.Field<string>("KindOfFun"),

			};
		}

		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			
			var sql = "SELECT distinct City FROM map_project";
			var dbHelper = new SqlDbHelper("default");

			List<string> cityselect = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(x=>x.Field<string>("City"))
				.Prepend(string.Empty)
				.ToList();

			this.cityComboBox.DataSource = cityselect;

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			DisplayMap();
		}

		private void kindoffunComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			InitFormKOF();
		}
		
		private void InitFormKOF()
		{
			// 設定 categoryIdComboBox property
			kindoffunComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT distinct KindOfFun FROM map_project";
			var dbHelper = new SqlDbHelper("default");

			List<string> cityselect = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(x => x.Field<string>("KindOfFun"))
				.Prepend(string.Empty)
				.ToList();

			this.kindoffunComboBox.DataSource = cityselect;

		}

		private void addnewButton_Click(object sender, EventArgs e)
		{
			var frm = new MapCreateForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayMap();
			}

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			MapIndex row = this.products[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new MapEditForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayMap();
			}

		}

		private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			InitForm();
		}

		private void kindoffunComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			InitFormKOF();
		}


	}
}
