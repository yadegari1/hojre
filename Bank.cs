using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000008 RID: 8
	public class Bank
	{
		// Token: 0x06000183 RID: 387 RVA: 0x001019E0 File Offset: 0x000FFDE0
		[DebuggerNonUserCode]
		public Bank()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x001019EC File Offset: 0x000FFDEC
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Bank.ID,dbo.Bank.Name From dbo.Bank");
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00101A08 File Offset: 0x000FFE08
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.Bank(Name) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00101A3C File Offset: 0x000FFE3C
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Bank SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00101A5C File Offset: 0x000FFE5C
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Bank Where Id= " + ID);
		}
	}
}
