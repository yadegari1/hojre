using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200000D RID: 13
	public class Daramad
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00102778 File Offset: 0x00100B78
		[DebuggerNonUserCode]
		public Daramad()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00102784 File Offset: 0x00100B84
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Daramad.ID,dbo.Daramad.Name,dbo.Daramad.CodeHesab_ID From dbo.Daramad");
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x001027A0 File Offset: 0x00100BA0
		public long Insert(string Name, string CodeHesab_ID)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert Into dbo.Daramad(Name,CodeHesab_ID) VALUES(",
				Public_Function.GetValue(Name),
				",",
				CodeHesab_ID,
				" );Select Scope_Identity();"
			})));
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x001027F4 File Offset: 0x00100BF4
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Daramad SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00102814 File Offset: 0x00100C14
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Daramad Where Id= " + ID);
		}
	}
}
