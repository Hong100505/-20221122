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
	public partial class CreateKof : Form
	{
		private KofVM[] products = null;
		public CreateKof()
		{
			InitializeComponent();
			DisplayKof();
		}
		private void DisplayKof()
		{
			string sql = "select * from kindoffuntable";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			products = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();

			BindData(products);

		}
		private void BindData(KofVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private KofVM ParseToIndexVM(DataRow row)  //視窗
		{
			return new KofVM
			{
				Id = row.Field<int>("Id"),
				KindOfFun = row.Field<string>("KindOfFun"),

			};
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string inputkof = kofTextBox.Text;


			// 將它們繫結到ViewModel
			KofVM model = new KofVM
			{
				KindOfFun = inputkof,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"KindOfFun", kofTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			//};

			string sql = @"INSERT INTO kindoffuntable (KindOfFun)
VALUES
(@KindOfFun)"
			;

			var parameters = new SqlParametersBuider()
				.AddNVarchar("KindOfFun", 50, model.KindOfFun)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
			DisplayKof();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			KofVM row = this.products[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditKofForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayKof();
			}

		}
	}
}
