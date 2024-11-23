using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000052 RID: 82
	public class Base_User_Control
	{
		// Token: 0x06000398 RID: 920 RVA: 0x001395A0 File Offset: 0x001379A0
		[DebuggerNonUserCode]
		public Base_User_Control()
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x001395AC File Offset: 0x001379AC
		public void DeleteUserPermission(string userid)
		{
			Public_Function.ExecuteNonQuery("delete from User_Controls where user_Id=" + userid);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x001395C4 File Offset: 0x001379C4
		public DataTable GetUserPermission(string UserName)
		{
			return Public_Function.FillData("SELECT  User_Controls.Control_ID  FROM Users   INNER JOIN User_Controls ON Users.ID = User_Controls.User_ID where username=N'" + UserName + "'");
		}

		// Token: 0x0600039B RID: 923 RVA: 0x001395F0 File Offset: 0x001379F0
		public DataTable FormChild_Permission(string name)
		{
			return Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Controls.Name  FROM         User_Controls INNER JOIN  Controls ON User_Controls.Control_ID = Controls.ID INNER JOIN  Controls AS PControls ON Controls.Parent_ID = PControls.ID where User_Controls.User_ID=",
				Conversions.ToString(Public_Function.CurrentData.UserID),
				" AND PControls.Name=N'",
				name,
				"'"
			}));
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0013964C File Offset: 0x00137A4C
		public bool Form_Permission(string name)
		{
			string left = Conversions.ToString(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"SELECT    top 1 Controls.Name   FROM         Controls INNER JOIN   User_Controls ON Controls.ID = User_Controls.Control_ID INNER JOIN   Controls AS PControls ON Controls.Parent_ID = PControls.ID   WHERE     (PControls.Parent_ID IS NULL) AND User_Controls.User_ID=",
				Conversions.ToString(Public_Function.CurrentData.UserID),
				" AND Controls.Name=N'",
				name,
				"'"
			})));
			return Operators.CompareString(left, string.Empty, false) == 0;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x001396C8 File Offset: 0x00137AC8
		public bool Form_Control_Permission(string Form, string Control)
		{
			object expr_16 = Public_Function.ExecuteScalar("select id from controls where name=" + Public_Function.GetValue(Form));
			int? num2;
			int? num = (expr_16 != null) ? ((int?)expr_16) : num2;
			bool flag = num.HasValue;
			bool result;
			if (flag)
			{
				object expr_6C = Public_Function.ExecuteScalar("select id from controls where parent_id=" + (num.HasValue ? Conversions.ToString(num.GetValueOrDefault()) : null) + " AND Name=" + Public_Function.GetValue(Control));
				int? num3 = (expr_6C != null) ? ((int?)expr_6C) : num2;
				flag = num3.HasValue;
				if (flag)
				{
					string left = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 id from user_controls where user_id=" + Conversions.ToString(Public_Function.CurrentData.UserID) + " AND Control_ID=" + (num3.HasValue ? Conversions.ToString(num3.GetValueOrDefault()) : null)));
					flag = (Operators.CompareString(left, string.Empty, false) == 0);
					result = flag;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x001397D8 File Offset: 0x00137BD8
		public DataTable Main_Permission()
		{
			return Public_Function.FillData("SELECT     Controls.Name    FROM         User_Controls INNER JOIN    Controls ON User_Controls.Control_ID = Controls.ID    WHERE     (User_Controls.User_ID = " + Conversions.ToString(Public_Function.CurrentData.UserID) + ") AND (Controls.Parent_ID IS NULL)");
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00139810 File Offset: 0x00137C10
		public DataTable MenuPermissions()
		{
			return Public_Function.FillData("SELECT     Controls.ID, Controls.Parent_ID, Controls.Name, PControls.Name AS MainMenuName  FROM         Controls INNER JOIN  Controls AS PControls ON Controls.Parent_ID = PControls.ID INNER JOIN  User_Controls ON Controls.ID = User_Controls.Control_ID  WHERE     (Controls.Parent_ID IS NOT NULL) AND (PControls.Parent_ID IS NULL) AND (User_Controls.User_ID = " + Conversions.ToString(Public_Function.CurrentData.UserID) + ")");
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00139848 File Offset: 0x00137C48
		public void Insert(string User_ID, string Control_ID)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"insert into User_Controls (User_ID,Control_ID) values(",
				User_ID,
				",",
				Control_ID,
				") "
			}));
		}
	}
}
