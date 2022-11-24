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
	public partial class MapCreateForm : Form
	{
		public MapCreateForm()
		{
			InitializeComponent();
			InitCityForm();
			InitkofForm();
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string kindoffun = kofComboBox.Text;
			string address = addressTextBox.Text;
			string name = nameTextBox.Text;
			string city = cityComboBox.Text;

			// 將它們繫結到ViewModel
			MapVM model = new MapVM
			{
				KindOfFun = kindoffun,
				Address = address,
				City = city,
				Name = name,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Address", addressTextBox},
				{"Name", nameTextBox},
				{"KindOfFun", kofComboBox},
				{"City", cityComboBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			//};

			string sql = @"INSERT INTO map_project (Name, Address,City,KindOfFun)
VALUES
(@Name,@Address, @City,@KindOfFun)"
			;

			var parameters = new SqlParametersBuider()
				.AddNVarchar("KindOfFun", 50, model.KindOfFun)
				.AddNVarchar("Address", 50, model.Address)
				.AddNVarchar("City", 50, model.City)
				.AddNVarchar("Name", 50, model.Name)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void InitCityForm()
		{
			cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT distinct Cityname FROM citytable";
			var dbHelper = new SqlDbHelper("default");

			List<string> cityselect = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(x => x.Field<string>("Cityname"))
				.Prepend(string.Empty)
				.ToList();

			this.cityComboBox.DataSource = cityselect;

		}
		private void InitkofForm()
		{
			kofComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT distinct KindOfFun FROM kindOffuntable";
			var dbHelper = new SqlDbHelper("default");

			List<string> cityselect = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(x => x.Field<string>("KindOfFun"))
				.Prepend(string.Empty)
				.ToList();

			this.kofComboBox.DataSource = cityselect;

		}

	}
}
