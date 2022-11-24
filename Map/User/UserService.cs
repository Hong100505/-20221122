using ISPan.Utility;
using Map.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Map.User
{
	internal class UserService
	{
		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null)
			{
				
				return false;
			}
			
			return (user.Password == model.Password);
		}
		public UserVM Get(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account=@Account";
			var parameters = new SqlParametersBuider()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToUserVM(data.Rows[0]);
		}

		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				Id=row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
	}
}

