using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000051 RID: 81
	public class base_user
	{
		// Token: 0x06000390 RID: 912 RVA: 0x001392E8 File Offset: 0x001376E8
		[DebuggerNonUserCode]
		public base_user()
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x001392F4 File Offset: 0x001376F4
		public DataRow GetByName(string Name)
		{
			return Public_Function.FillDataRow("select * from users where Username =" + Public_Function.GetValue(Name));
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0013931C File Offset: 0x0013771C
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select * from Users");
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00139338 File Offset: 0x00137738
		public int Insert(string User_Name, string Password)
		{
			return Conversions.ToInteger(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert into Users(UserName,Password,Gui) Values(",
				Public_Function.GetValue(User_Name),
				",",
				Public_Function.GetValue(Password),
				",0); Select Scope_Identity();"
			})));
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00139390 File Offset: 0x00137790
		public bool Login(string user, string pass)
		{
			DataRow dataRow = Public_Function.FillDataRow("select * from Users where username=" + Public_Function.GetValue(user) + " AND password=" + Public_Function.GetValue(pass));
			bool flag = dataRow != null;
			bool result;
			if (flag)
			{
				Public_Function.CurrentData.Username = Conversions.ToString(dataRow["username"]);
				Public_Function.CurrentData.UserID = Conversions.ToLong(dataRow["ID"]);
				Public_Function.CurrentData.Gui = Conversions.ToInteger(dataRow["gui"]);
				Public_Function.CurrentData.Password = Conversions.ToString(dataRow["password"]);
				Public_Function.CurrentData.AutoBackup = Conversions.ToBoolean(dataRow["autobackup"]);
				Public_Function.CurrentData.AutoClose = Conversions.ToBoolean(dataRow["autoclose"]);
				Public_Function.CurrentData.Tabbed = Conversions.ToBoolean(dataRow["tabbed"]);
				result = true;
			}
			else
			{
				flag = Public_Function.dict.ContainsKey("eval");
				if (flag)
				{
					bool flag2 = Operators.CompareString(user.ToLower(), "admin", false) == 0 && Operators.CompareString(pass, "1", false) == 0;
					if (flag2)
					{
						Public_Function.CurrentData.Username = "Admin";
						result = true;
						return result;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x001394EC File Offset: 0x001378EC
		public void Update(string gui, string tabbed, string autoclose, string autobackup)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"update users set gui=",
				gui,
				",tabbed=",
				tabbed,
				" ,autoclose=",
				autoclose,
				",autobackup=",
				autobackup,
				" where id=",
				Conversions.ToString(Public_Function.CurrentData.UserID)
			}));
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00139568 File Offset: 0x00137968
		public void UpdateUser(string password, string Userid)
		{
			Public_Function.ExecuteNonQuery("update users set password=" + Public_Function.GetValue(password) + " where id=" + Userid);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00139588 File Offset: 0x00137988
		public void DeleteUser(string userid)
		{
			Public_Function.ExecuteNonQuery("delete from users where id=" + userid);
		}
	}
}
