using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000021 RID: 33
	public class DaryaftPardakht
	{
		// Token: 0x060001FD RID: 509 RVA: 0x001047E0 File Offset: 0x00102BE0
		public DaryaftPardakht()
		{
			this.sanad = new Sanad();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x001047F8 File Offset: 0x00102BF8
		public string AddRowStr_Moshtari_beMoshtari(string Tarikh, string Moshtari_id, string BeMoshtari_id, string Mablagh, string Tozih, string Pardakht_id)
		{
			string text = string.Empty;
			text = text + " select @codehesab_id = codehesab_id from moshtari where id=" + Moshtari_id + ";";
			text = text + " select top 1  @codehesab_id2 = codehesab_id from moshtari where id= " + BeMoshtari_id + ";";
			bool flag = Operators.CompareString(Pardakht_id, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				text += this.sanad.InsertStr("@codehesab_id2", Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbed_id=scope_identity();";
				text += this.sanad.InsertStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbes_id=scope_identity();";
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,bemoshtari_id,Mablagh,Tozih,Tarikh_Fa) VALUES(39,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",@sanadbed_id,@sanadbes_id,",
					Moshtari_id,
					",",
					BeMoshtari_id,
					",",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					");select @pardakht_id=scope_identity();"
				});
				result = text;
			}
			else
			{
				text = text + " select @pardakht_id=" + Pardakht_id + ";";
				text = text + "select @sanadbed_id=sanadbed_id , @sanadbes_id=sanadbes_id from daryaftPardakht where id= " + Pardakht_id;
				text += this.sanad.UpdateStr("@codehesab_id", Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
				text += this.sanad.UpdateStr("@codehesab_id2", Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID", Sanad.SanadType.@null);
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=39 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,bemoshtari_id= ",
					BeMoshtari_id,
					" ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
					Pardakht_id,
					";"
				});
				result = text;
			}
			return result;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00104A54 File Offset: 0x00102E54
		public string AddRowStrKart_Pardakht_Moshtari(string Tarikh, string Moshtari_id, string BankHesab_ID, string Mablagh, string Tozih, string Pardakht_id)
		{
			string text = string.Empty;
			text = text + " select @codehesab_id = codehesab_id from moshtari where id=" + Moshtari_id + ";";
			text = text + " select top 1  @codehesab_id2 = CodeHesab_Mojodi from bank_hesab where id= " + BankHesab_ID + ";";
			bool flag = Operators.CompareString(Pardakht_id, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				text += this.sanad.InsertStr("@codehesab_id", Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbed_id=scope_identity();";
				text += this.sanad.InsertStr("@codehesab_id2", Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbes_id=scope_identity();";
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(29,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",@sanadbed_id,@sanadbes_id,",
					Moshtari_id,
					",",
					BankHesab_ID,
					",1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					");select @pardakht_id=scope_identity();"
				});
				result = text;
			}
			else
			{
				text = text + " select @pardakht_id=" + Pardakht_id + ";";
				text = text + "select @sanadbed_id=sanadbed_id , @sanadbes_id=sanadbes_id from daryaftPardakht where id= " + Pardakht_id;
				text += this.sanad.UpdateStr("@codehesab_id", Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
				text += this.sanad.UpdateStr("@codehesab_id2", Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID", Sanad.SanadType.@null);
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=29 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,BankHesab_ID= ",
					BankHesab_ID,
					" ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
					Pardakht_id,
					";"
				});
				result = text;
			}
			return result;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00104CB0 File Offset: 0x001030B0
		public string AddRowStrKartMoshtari(string Tarikh, string Moshtari_id, string Mablagh, string Tozih, string Daryaft_id)
		{
			string text = string.Empty;
			text = text + " select @codehesab_id = codehesab_id from moshtari where id=" + Moshtari_id + ";";
			text += " select top 1  @codehesab_id2 = CodeHesab_Mojodi,@bank_hesab_id=id from bank_hesab  ;";
			bool flag = Operators.CompareString(Daryaft_id, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				text += this.sanad.InsertStr("@codehesab_id2", Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbed_id=scope_identity();";
				text += this.sanad.InsertStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbes_id=scope_identity();";
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(3,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",@sanadbed_id,@sanadbes_id,",
					Moshtari_id,
					",@bank_hesab_id,1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					");select @daryaft_id=scope_identity();"
				});
				result = text;
			}
			else
			{
				text = text + " select @daryaft_id=" + Daryaft_id + ";";
				text = text + "select @sanadbed_id=sanadbed_id , @sanadbes_id=sanadbes_id from daryaftPardakht where id= " + Daryaft_id;
				text += this.sanad.UpdateStr("@codehesab_id2", Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
				text += this.sanad.UpdateStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID", Sanad.SanadType.@null);
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=3 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,BankHesab_ID=@bank_hesab_id  ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
					Daryaft_id,
					";"
				});
				result = text;
			}
			return result;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00104EE0 File Offset: 0x001032E0
		public string AddRowStrNaghd_Pardakht_Moshtari(string Tarikh, string Moshtari_id, string Mablagh, string Tozih, string Pardakht_ID)
		{
			string text = string.Empty;
			text = text + " select @codehesab_id = codehesab_id from moshtari where id=" + Moshtari_id + ";";
			bool flag = Operators.CompareString(Pardakht_ID, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(13,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",",
					Moshtari_id,
					",1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					");select @pardakht_id=scope_identity();"
				});
				text += this.sanad.InsertStr("@codehesab_id", Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbed_id=scope_identity();";
				text += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbes_id=scope_identity();";
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,parent_id) VALUES(10,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",@sanadbed_id,@sanadbes_id,",
					Moshtari_id,
					",1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					", @pardakht_id);"
				});
				result = text;
			}
			else
			{
				text = text + " select @pardakht_id=" + Pardakht_ID + ";";
				text = text + "select @sanadbed_id=sanadbed_id , @sanadbes_id=sanadbes_id from daryaftPardakht where parent_id= " + Pardakht_ID;
				text += this.sanad.UpdateStr("@codehesab_id", Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
				text += this.sanad.UpdateStr(Conversions.ToString(1), Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID", Sanad.SanadType.@null);
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=13 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
					Pardakht_ID,
					";"
				});
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=10 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where parent_ID=",
					Pardakht_ID,
					";"
				});
				result = text;
			}
			return result;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0010520C File Offset: 0x0010360C
		public string AddRowStrNaghdMoshtari(string Tarikh, string Moshtari_id, string Mablagh, string Tozih, string Daryaft_id)
		{
			string text = string.Empty;
			text = text + " select @codehesab_id = codehesab_id from moshtari where id=" + Moshtari_id + ";";
			bool flag = Operators.CompareString(Daryaft_id, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(4,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",",
					Moshtari_id,
					",1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					");select @daryaft_id=scope_identity();"
				});
				text += this.sanad.InsertStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbed_id=scope_identity();";
				text += this.sanad.InsertStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
				text += " select @sanadbes_id=scope_identity();";
				text = string.Concat(new string[]
				{
					text,
					" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,parent_id) VALUES(1,",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					",@sanadbed_id,@sanadbes_id,",
					Moshtari_id,
					",1,",
					Mablagh,
					",",
					Public_Function.GetValue(Tozih),
					",",
					Public_Function.GetValue(Tarikh),
					", @daryaft_id);"
				});
				result = text;
			}
			else
			{
				text = text + " select @daryaft_id=" + Daryaft_id + ";";
				text = text + "select @sanadbed_id=sanadbed_id , @sanadbes_id=sanadbes_id from daryaftPardakht where parent_id= " + Daryaft_id;
				text += this.sanad.UpdateStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
				text += this.sanad.UpdateStr("@codehesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID", Sanad.SanadType.@null);
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=4 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
					Daryaft_id,
					";"
				});
				text = string.Concat(new string[]
				{
					text,
					"Update dbo.DaryaftPardakht SET dptype_id=1 ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" ,Moshtari_ID= ",
					Moshtari_id,
					" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
					Mablagh,
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh),
					" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where parent_ID=",
					Daryaft_id,
					";"
				});
				result = text;
			}
			return result;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00105538 File Offset: 0x00103938
		public DataTable RefreshVusul(string ID)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,   DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,   DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Bank_1.Name AS CheckBank_Name, Bank_3.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,   DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,   Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID,   Bank_2.Name + '-' + Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name, DaryaftPardakht.BankHesab_ID2, Bank.Name+' '+ Bank_Hesab_1.Shobe+' - '+ Bank_Hesab_1.SahebHesab AS BankHesab_Name2    FROM         Bank AS Bank_1 RIGHT OUTER JOIN    Bank AS Bank_2 INNER JOIN    Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID RIGHT OUTER JOIN    dpType INNER JOIN    DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN    Bank_Hesab AS Bank_Hesab_1 INNER JOIN    Bank ON Bank_Hesab_1.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID2 = Bank_Hesab_1.ID LEFT OUTER JOIN    Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID ON Moshtari_Hesab.ID = DaryaftPardakht.MoshtariHesab_ID ON    Bank_1.ID = DaryaftPardakht.CheckBank_ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN    Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN    Bank AS Bank_3 ON Bank_Hesab.Bank_ID = Bank_3.ID    WHERE     DaryaftPardakht.ID = " + ID + " OR parent_id=" + ID);
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			dataTable.Columns.Add("Moshtari_Name2", typeof(string));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 14, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 17, false))
					{
						goto IL_BC;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
					{
						goto IL_BC;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 19, false))
					{
						goto IL_D8;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false))
					{
						goto IL_F7;
					}
					bool arg_F9_0 = false;
					IL_F8:
					bool flag = arg_F9_0;
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
					continue;
					IL_F7:
					arg_F9_0 = true;
					goto IL_F8;
					IL_D8:
					goto IL_F7;
					IL_BC:
					goto IL_D8;
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			dataTable.Columns.Add(new DataColumn("Daryaft_identity", typeof(int)));
			return dataTable;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x001056E8 File Offset: 0x00103AE8
		public string AddRowStrToDaryaft(string Tarikh, string Mablagh, string Tozih, DaryaftPardakht.CodeHesab CodeHesab)
		{
			string text = string.Empty;
			text += this.sanad.InsertStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
			text += "select @sanadbed_id=scope_identity();";
			text += this.sanad.InsertStr(Conversions.ToString((int)CodeHesab), Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			return string.Concat(new string[]
			{
				text,
				"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(-1,",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				",@sanadbed_id,@sanadbes_id,-1,1,",
				Mablagh,
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValue(Tarikh),
				");"
			});
		}

		// Token: 0x06000205 RID: 517 RVA: 0x001057C8 File Offset: 0x00103BC8
		public string UpdateRowStrToDaryaft(string Tarikh, string Mablagh, string Tozih, string Daryaft_ID, DaryaftPardakht.CodeHesab CodeHesab)
		{
			string text = string.Empty;
			text = text + "select @sanadbed_id=sanadbed_id , @sanadbes_id=sanadbes_id from daryaftPardakht where id= " + Daryaft_ID;
			text += this.sanad.UpdateStr(Conversions.ToString(1), Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
			text += this.sanad.UpdateStr(Conversions.ToString((int)CodeHesab), Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@SanadBes_ID", Sanad.SanadType.@null);
			return string.Concat(new string[]
			{
				text,
				"Update dbo.DaryaftPardakht SET dptype_id=-1 ,Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				" ,Moshtari_ID=-1  ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
				Mablagh,
				" ,Tozih=",
				Public_Function.GetValue(Tozih),
				" ,Tarikh_Fa=",
				Public_Function.GetValue(Tarikh),
				" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
				Daryaft_ID,
				";"
			});
		}

		// Token: 0x06000206 RID: 518 RVA: 0x001058BC File Offset: 0x00103CBC
		public string AddRowStrToPardakht(string Tarikh, string Mablagh, string Tozih, string Moshtari_ID, DaryaftPardakht.dptype_ID dptype, DaryaftPardakht.CodeHesab CodeHesab, string Return_ID = "")
		{
			string text = string.Empty;
			bool flag = CodeHesab != DaryaftPardakht.CodeHesab.NULL;
			if (flag)
			{
				text += this.sanad.InsertStr(Conversions.ToString((int)CodeHesab), Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += "select @sanadbed_id=scope_identity();";
			}
			else
			{
				text += "select @sanadbed_id=NULL;";
			}
			text += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_id,Mablagh,Tozih,Tarikh_Fa) VALUES(",
				Conversions.ToString((int)dptype),
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				",@sanadbed_id,@sanadbes_id,",
				Public_Function.GetValueInt(Moshtari_ID),
				",1,",
				Mablagh,
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValue(Tarikh),
				");"
			});
			flag = (Operators.CompareString(Return_ID, "", false) != 0);
			if (flag)
			{
				text = text + " Select " + Return_ID + "=scope_Identity();";
			}
			return text;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00105A10 File Offset: 0x00103E10
		public string AddKerayeNesie(string Tarikh, string Mablagh, string Tozih, string Moshtari_ID, DaryaftPardakht.CodeHesab CodeHesab, string Return_ID = "")
		{
			string text = string.Empty;
			bool flag = CodeHesab != DaryaftPardakht.CodeHesab.NULL;
			if (flag)
			{
				text += this.sanad.InsertStr(Conversions.ToString((int)CodeHesab), Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += "select @sanadbed_id=scope_identity();";
			}
			else
			{
				text += "select @sanadbed_id=NULL;";
			}
			text = text + "select @moshtari_hesab_id=codehesab_id from moshtari where id=" + Moshtari_ID + ";";
			text += this.sanad.InsertStr("@moshtari_hesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_id,Mablagh,Tozih,Tarikh_Fa,sh_fish) VALUES(-2,",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				",@sanadbed_id,@sanadbes_id,",
				Public_Function.GetValueInt(Moshtari_ID),
				",1,",
				Mablagh,
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValue(Tarikh),
				",'1');"
			});
			flag = (Operators.CompareString(Return_ID, "", false) != 0);
			if (flag)
			{
				text = text + " Select " + Return_ID + "=scope_Identity();";
			}
			return text;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00105B60 File Offset: 0x00103F60
		public string UpdateKerayeNesie(string Tarikh, string Mablagh, string Tozih, string Moshtari_ID, DaryaftPardakht.CodeHesab CodeHesab, string ID)
		{
			string text = string.Empty;
			text = "select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=" + ID + ";";
			bool flag = CodeHesab != DaryaftPardakht.CodeHesab.NULL;
			if (flag)
			{
				text += this.sanad.UpdateStr(Conversions.ToString((int)CodeHesab), Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
			}
			text = text + "select @moshtari_hesab_id=codehesab_id from moshtari where id=" + Moshtari_ID + ";";
			text += this.sanad.UpdateStr("@moshtari_hesab_id", Conversions.ToString(0), Mablagh, Tarikh, Tozih, "@sanadbes_id", Sanad.SanadType.@null);
			return string.Concat(new string[]
			{
				text,
				"Update dbo.DaryaftPardakht SET dpType_ID=-2 ,Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				" ,Moshtari_ID= ",
				Public_Function.GetValueInt(Moshtari_ID),
				" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
				Mablagh,
				" ,Tozih=",
				Public_Function.GetValue(Tozih),
				" ,Tarikh_Fa=",
				Public_Function.GetValue(Tarikh),
				" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = '1'  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
				ID,
				";"
			});
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00105C90 File Offset: 0x00104090
		public void AddRowPardakhtExtend(string Tarikh, string Mablagh, string Tozih, string Moshtari_ID, DaryaftPardakht.dptype_ID dptype, DaryaftPardakht.CodeHesab CodeHesab, string table, string field, string idvalue)
		{
			string text = "declare @sanadbed_id int;";
			bool flag = CodeHesab != DaryaftPardakht.CodeHesab.NULL;
			if (flag)
			{
				text += this.sanad.InsertStr(Conversions.ToString((int)CodeHesab), Mablagh, Conversions.ToString(0), Tarikh, Tozih, Sanad.SanadType.@null);
				text += "select @sanadbed_id=scope_identity();";
			}
			else
			{
				text += "select @sanadbed_id=NULL;";
			}
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_id,Mablagh,Tozih,Tarikh_Fa) VALUES(",
				Conversions.ToString((int)dptype),
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				",@sanadbed_id,NULL,",
				Public_Function.GetValueInt(Moshtari_ID),
				",1,",
				Mablagh,
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValue(Tarikh),
				");"
			});
			text = string.Concat(new string[]
			{
				text,
				"update ",
				table,
				" set ",
				field,
				"=scope_identity() where id=",
				idvalue
			});
			flag = (text.Length > 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00105DDC File Offset: 0x001041DC
		public void DeleteDaryaftPardakhtRadif(string id, string Furush_id = "", string Kharid_ID = "")
		{
			string text = "declare @sanadbed_id int, @sanadbes_id int,@tarikh_fa nvarchar(10);";
			bool flag = Operators.CompareString(Furush_id, "", false) != 0;
			if (flag)
			{
				text = text + "update furush_keraye set keraye_pardakht_id=null where id=" + Furush_id + ";";
			}
			flag = (Operators.CompareString(Kharid_ID, "", false) != 0);
			if (flag)
			{
				text = text + "update kharid_keraye set keraye_pardakht_id=null where id=" + Kharid_ID + ";";
			}
			text = text + "select @tarikh_fa=tarikh_fa from daryaftpardakht where id=" + id + ";";
			text = text + "select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=" + id + ";";
			text = text + "delete from daryaftpardakht where id=" + id + ";";
			text += "delete from sanad where id =@sanadbed_id;";
			text += "delete from sanad where id=@sanadbes_id;";
			text += " select @tarikh_fa;";
			Sandugh sandugh = new Sandugh();
			string tarikh = Conversions.ToString(Public_Function.ExecuteScalar(text));
			sandugh.SynckasrEzafe(tarikh);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00105EB8 File Offset: 0x001042B8
		public void DeleteDaryaftPardakhtRadifExtend(string daryaftpardakht_ID, string table, string field, string idvalue)
		{
			bool flag = Operators.CompareString(daryaftpardakht_ID, "0", false) == 0 || Operators.CompareString(daryaftpardakht_ID, string.Empty, false) == 0;
			if (!flag)
			{
				string text = "declare @sanadbed_id int, @sanadbes_id int,@tarikh_fa nvarchar(10);";
				flag = (Operators.CompareString(table, string.Empty, false) != 0);
				if (flag)
				{
					text = string.Concat(new string[]
					{
						text,
						"update ",
						table,
						" set ",
						field,
						"=null where id=",
						idvalue,
						";"
					});
				}
				text = text + "select @tarikh_fa=tarikh_fa from daryaftpardakht where id=" + daryaftpardakht_ID + ";";
				text = string.Concat(new string[]
				{
					text,
					"delete from sanad where id in (select sanadbed_id from daryaftpardakht where id=",
					daryaftpardakht_ID,
					" or parent_id=",
					daryaftpardakht_ID,
					");"
				});
				text = string.Concat(new string[]
				{
					text,
					"delete from sanad where id in (select sanadbes_id from daryaftpardakht where id=",
					daryaftpardakht_ID,
					" or parent_id=",
					daryaftpardakht_ID,
					");"
				});
				text = string.Concat(new string[]
				{
					text,
					"delete from daryaftpardakht where id=",
					daryaftpardakht_ID,
					" or parent_id=",
					daryaftpardakht_ID,
					";"
				});
				text += " select isnull(@tarikh_fa,'');";
				string text2 = Conversions.ToString(Public_Function.ExecuteScalar(text));
				flag = (Operators.CompareString(text2, string.Empty, false) != 0);
				if (flag)
				{
					Sandugh sandugh = new Sandugh();
					sandugh.SynckasrEzafe(text2);
				}
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00106058 File Offset: 0x00104458
		public string UpdateRowStrToPardakht(string Tarikh, string Mablagh, string Tozih, string Moshtari_ID, string Pardakht_ID, DaryaftPardakht.dptype_ID dptype, DaryaftPardakht.CodeHesab CodeHesab)
		{
			string text = string.Empty;
			text = text + "select @sanadbed_id=sanadbed_id , @sanadbes_id=sanadbes_id from daryaftPardakht where id= " + Pardakht_ID + ";";
			bool flag = CodeHesab != DaryaftPardakht.CodeHesab.NULL;
			if (flag)
			{
				text += this.sanad.UpdateStr(Conversions.ToString((int)CodeHesab), Mablagh, Conversions.ToString(0), Tarikh, Tozih, "@sanadbed_id", Sanad.SanadType.@null);
			}
			return string.Concat(new string[]
			{
				text,
				"Update dbo.DaryaftPardakht SET dpType_ID=",
				Conversions.ToString((int)dptype),
				" ,Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				" ,Moshtari_ID= ",
				Public_Function.GetValueInt(Moshtari_ID),
				" ,Sandug_ID=1 ,Hazine_ID=Null ,Mablagh=",
				Mablagh,
				" ,Tozih=",
				Public_Function.GetValue(Tozih),
				" ,Tarikh_Fa=",
				Public_Function.GetValue(Tarikh),
				" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  Where ID=",
				Pardakht_ID,
				";"
			});
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00106160 File Offset: 0x00104560
		public DataTable GetKeraye(string Tarikh)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,   DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,   DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Bank_1.Name AS CheckBank_Name, Bank_3.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,   DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,   Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID,   Bank_2.Name + '-' + Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name, DaryaftPardakht.BankHesab_ID2, Bank.Name+' '+ Bank_Hesab_1.Shobe+' - '+ Bank_Hesab_1.SahebHesab AS BankHesab_Name2    FROM         Bank AS Bank_1 RIGHT OUTER JOIN    Bank AS Bank_2 INNER JOIN    Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID RIGHT OUTER JOIN    dpType INNER JOIN    DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN    Bank_Hesab AS Bank_Hesab_1 INNER JOIN    Bank ON Bank_Hesab_1.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID2 = Bank_Hesab_1.ID LEFT OUTER JOIN    Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID ON Moshtari_Hesab.ID = DaryaftPardakht.MoshtariHesab_ID ON    Bank_1.ID = DaryaftPardakht.CheckBank_ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN    Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN    Bank AS Bank_3 ON Bank_Hesab.Bank_ID = Bank_3.ID    WHERE     DaryaftPardakht.Tarikh = " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " AND dpType_id in (-2) ");
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			dataTable.Columns.Add("Moshtari_Name2", typeof(string));
			dataTable.Columns.Add(new DataColumn("Daryaft_identity", typeof(int)));
			return dataTable;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x001061EC File Offset: 0x001045EC
		public DataTable GetFurushNaghd(string Tarikh)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,   DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,   DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Bank_1.Name AS CheckBank_Name, Bank_3.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,   DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,   Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID,   Bank_2.Name + '-' + Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name, DaryaftPardakht.BankHesab_ID2, Bank.Name+' '+ Bank_Hesab_1.Shobe+' - '+ Bank_Hesab_1.SahebHesab AS BankHesab_Name2    FROM         Bank AS Bank_1 RIGHT OUTER JOIN    Bank AS Bank_2 INNER JOIN    Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID RIGHT OUTER JOIN    dpType INNER JOIN    DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN    Bank_Hesab AS Bank_Hesab_1 INNER JOIN    Bank ON Bank_Hesab_1.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID2 = Bank_Hesab_1.ID LEFT OUTER JOIN    Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID ON Moshtari_Hesab.ID = DaryaftPardakht.MoshtariHesab_ID ON    Bank_1.ID = DaryaftPardakht.CheckBank_ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN    Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN    Bank AS Bank_3 ON Bank_Hesab.Bank_ID = Bank_3.ID    WHERE     DaryaftPardakht.Tarikh = " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " AND dpType_id in (-1) ");
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			dataTable.Columns.Add("Moshtari_Name2", typeof(string));
			dataTable.Columns.Add(new DataColumn("Daryaft_identity", typeof(int)));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["Tozih"]);
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x001062EC File Offset: 0x001046EC
		public DataTable GetDaryaftRefresh(string Tarikh)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,   DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,   DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Bank_1.Name AS CheckBank_Name, Bank_3.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,   DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,   Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID,   Bank_2.Name + '-' + Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name, DaryaftPardakht.BankHesab_ID2, Bank.Name+' '+ Bank_Hesab_1.Shobe+' - '+ Bank_Hesab_1.SahebHesab AS BankHesab_Name2    FROM         Bank AS Bank_1 RIGHT OUTER JOIN    Bank AS Bank_2 INNER JOIN    Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID RIGHT OUTER JOIN    dpType INNER JOIN    DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN    Bank_Hesab AS Bank_Hesab_1 INNER JOIN    Bank ON Bank_Hesab_1.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID2 = Bank_Hesab_1.ID LEFT OUTER JOIN    Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID ON Moshtari_Hesab.ID = DaryaftPardakht.MoshtariHesab_ID ON    Bank_1.ID = DaryaftPardakht.CheckBank_ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN    Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN    Bank AS Bank_3 ON Bank_Hesab.Bank_ID = Bank_3.ID    WHERE     DaryaftPardakht.Tarikh = " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " AND dpType_id in (35) ");
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			dataTable.Columns.Add("Moshtari_Name2", typeof(string));
			dataTable.Columns.Add(new DataColumn("Daryaft_identity", typeof(int)));
			return dataTable;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00106378 File Offset: 0x00104778
		public DataTable GetPardakhtRefresh(string Tarikh)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,   DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,   DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Bank_1.Name AS CheckBank_Name, Bank_3.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,   DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,   Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID,   Bank_2.Name + '-' + Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name, DaryaftPardakht.BankHesab_ID2, Bank.Name+' '+ Bank_Hesab_1.Shobe+' - '+ Bank_Hesab_1.SahebHesab AS BankHesab_Name2    FROM         Bank AS Bank_1 RIGHT OUTER JOIN    Bank AS Bank_2 INNER JOIN    Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID RIGHT OUTER JOIN    dpType INNER JOIN    DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN    Bank_Hesab AS Bank_Hesab_1 INNER JOIN    Bank ON Bank_Hesab_1.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID2 = Bank_Hesab_1.ID LEFT OUTER JOIN    Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID ON Moshtari_Hesab.ID = DaryaftPardakht.MoshtariHesab_ID ON    Bank_1.ID = DaryaftPardakht.CheckBank_ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN    Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN    Bank AS Bank_3 ON Bank_Hesab.Bank_ID = Bank_3.ID    WHERE     DaryaftPardakht.Tarikh = " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " AND dpType_id in (-2,-5) ");
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			dataTable.Columns.Add("Moshtari_Name2", typeof(string));
			dataTable.Columns.Add(new DataColumn("Daryaft_identity", typeof(int)));
			return dataTable;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00106404 File Offset: 0x00104804
		public DataTable GetDaryaftByDate(string Tarikh)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,  DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Mablagh AS Mablagh2, DaryaftPardakht.Tozih,  DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab,  DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name,  Moshtari_1.Name + ' ' + Moshtari_1.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name,  Bank.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name, DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish,  DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID, DaryaftPardakht.CheckBarg_ID, Hazine.Name AS Hazine_Name,  DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name, DaryaftPardakht.beMoshtari_ID,  Moshtari.Name + ' ' + Moshtari.Family AS BeMoshtari_Name   FROM         Daramad RIGHT OUTER JOIN  dpType INNER JOIN  DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN  Moshtari ON DaryaftPardakht.beMoshtari_ID = Moshtari.ID ON Daramad.ID = DaryaftPardakht.Daramad_ID LEFT OUTER JOIN  Moshtari AS Moshtari_1 ON DaryaftPardakht.Moshtari_ID = Moshtari_1.ID LEFT OUTER JOIN  Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN  Bank_Hesab LEFT OUTER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN  Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID  WHERE   Tarikh= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " AND (dpType.type = 1)  ORDER BY DaryaftPardakht.ID");
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -1, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -6, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 6, false);
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_Name"]);
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 25, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 27, false))
					{
						goto IL_175;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 33, false))
					{
						goto IL_175;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 36, false))
					{
						goto IL_191;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 40, false))
					{
						goto IL_1B0;
					}
					bool arg_1B2_0 = false;
					IL_1B1:
					flag = arg_1B2_0;
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
					continue;
					IL_1B0:
					arg_1B2_0 = true;
					goto IL_1B1;
					IL_191:
					goto IL_1B0;
					IL_175:
					goto IL_191;
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			dataTable.AcceptChanges();
			return dataTable;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00106660 File Offset: 0x00104A60
		public DataTable GetPardakhtByDate(string Tarikh)
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,    DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,    DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name, Moshtari_1.Name + ' ' + Moshtari_1.Family AS Moshtari_Name,    Bank_1.Name AS CheckBank_Name, Bank_3.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,    DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,    Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID,    Bank_2.Name + '-' + Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name, DaryaftPardakht.BankHesab_ID2,    Bank.Name + ' ' + Bank_Hesab_1.Shobe + ' - ' + Bank_Hesab_1.SahebHesab AS BankHesab_Name2, DaryaftPardakht.beMoshtari_ID,    Moshtari.Name + ' ' + Moshtari.Family AS beMoshtari_Name    FROM         Bank AS Bank_2 INNER JOIN    Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID RIGHT OUTER JOIN    dpType INNER JOIN    DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.beMoshtari_ID = Moshtari.ID ON Moshtari_Hesab.ID = DaryaftPardakht.MoshtariHesab_ID LEFT OUTER JOIN    Bank_Hesab AS Bank_Hesab_1 INNER JOIN    Bank ON Bank_Hesab_1.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID2 = Bank_Hesab_1.ID LEFT OUTER JOIN    Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN    Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID LEFT OUTER JOIN    Moshtari AS Moshtari_1 ON DaryaftPardakht.Moshtari_ID = Moshtari_1.ID LEFT OUTER JOIN    Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN    Bank AS Bank_3 ON Bank_Hesab.Bank_ID = Bank_3.ID    WHERE     DaryaftPardakht.Tarikh = ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				" AND dpType.type=2 AND DaryaftPardakht.id not in( select id from daryaftpardakht where tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
				" and (dptype_id=29 and parent_id is not null))  order by DaryaftPardakht.ID"
			}));
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			dataTable.Columns.Add("Moshtari_Name2", typeof(string));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 14, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 17, false))
					{
						goto IL_FA;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
					{
						goto IL_FA;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 19, false))
					{
						goto IL_116;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false))
					{
						goto IL_132;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 37, false))
					{
						goto IL_151;
					}
					bool arg_153_0 = false;
					IL_152:
					bool flag = arg_153_0;
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -7, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false);
					if (flag)
					{
						dataRow["hazine_id"] = RuntimeHelpers.GetObjectValue(dataRow["pardakhtcheck_id"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false);
					bool flag2;
					if (flag)
					{
						flag2 = (dataRow["moshtari_id"] != DBNull.Value);
						if (flag2)
						{
							dataRow["moshtari_id2"] = 5;
							string value = Conversions.ToString(dataRow["moshtari_name"]);
							string value2 = Conversions.ToString(dataRow["moshtari_id"]);
							dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
							dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_ID"]);
							dataRow["hazine_id"] = value2;
							dataRow["hazine_name"] = value;
						}
						else
						{
							dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
							dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_ID"]);
						}
						flag2 = (dataRow["checkbarg_id"] != DBNull.Value);
						if (flag2)
						{
							dataRow["moshtari_id2"] = 2;
						}
						else
						{
							flag2 = (dataRow["pardakhtcheck_id"] != DBNull.Value);
							if (flag2)
							{
								dataRow["moshtari_id2"] = 3;
								dataRow["bankhesab_id2"] = RuntimeHelpers.GetObjectValue(dataRow["pardakhtcheck_id"]);
							}
							else
							{
								flag2 = (dataRow["bankhesab_id"] != DBNull.Value);
								if (flag2)
								{
									dataRow["moshtari_id2"] = 4;
								}
								else
								{
									flag2 = (dataRow["moshtari_id2"] == DBNull.Value);
									if (flag2)
									{
										dataRow["moshtari_id2"] = 1;
									}
								}
							}
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 37, false);
					if (flag2)
					{
						flag = (dataRow["sandug_id"] != DBNull.Value);
						if (flag)
						{
							dataRow["moshtari_id2"] = 1;
						}
						else
						{
							dataRow["moshtari_id2"] = 2;
						}
						flag2 = (dataRow["sh_fish"] != DBNull.Value);
						if (flag2)
						{
							DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     DaryaftPardakht.Tarikh_Fa+' - '+cast( DaryaftPardakht.Mablagh as nvarchar(20)) as name, DaryaftPardakht.ID, Bank.Name +' '+ Bank_Hesab.Shobe+' '+Bank_Hesab.SahebHesab as bankhesab_name   FROM         DaryaftPardakht INNER JOIN  Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID  WHERE     (DaryaftPardakht.ID = ", dataRow["sh_fish"]), ")")));
							flag2 = (dataRow2 != null);
							if (flag2)
							{
								dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["sh_fish"]);
								dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow2["name"]);
							}
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 38, false);
					if (flag2)
					{
						flag = (dataRow["sandug_id"] != DBNull.Value);
						if (flag)
						{
							dataRow["moshtari_id2"] = 1;
						}
						else
						{
							dataRow["moshtari_id2"] = 2;
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 31, false);
					if (flag2)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
						dataRow["bankhesab_id"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_id2"]);
						dataRow["bankhesab_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name2"]);
					}
					flag2 = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 30, false) && dataRow["hazine_id"] != DBNull.Value);
					if (flag2)
					{
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_ID"]);
					}
					flag2 = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 29, false) && dataRow["hazine_id"] != DBNull.Value);
					if (flag2)
					{
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
					}
					continue;
					IL_151:
					arg_153_0 = true;
					goto IL_152;
					IL_132:
					goto IL_151;
					IL_116:
					goto IL_132;
					IL_FA:
					goto IL_116;
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			dataTable.Columns.Add(new DataColumn("Daryaft_identity", typeof(int)));
			dataTable.AcceptChanges();
			this.Delete_Tekrari_Pardakht(dataTable);
			return dataTable;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00106D80 File Offset: 0x00105180
		private bool delete(DataRow row)
		{
			bool flag = false;
			DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where tarikh=" + Public_Function.GetValue(Conversions.ToString(row["tarikh"])) + " and parent_id=", row["id"])));
			bool flag2;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 10, false);
					if (flag2)
					{
						this.DeleteDaryaftPardakhtRadif(Conversions.ToString(dataRow["id"]), "", "");
						flag = true;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag2 = (enumerator is IDisposable);
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			flag2 = flag;
			if (flag2)
			{
				this.DeleteDaryaftPardakhtRadif(Conversions.ToString(row["id"]), "", "");
			}
			return flag;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00106EA4 File Offset: 0x001052A4
		private void Find_Tekrar(DataTable dt, DataRow row)
		{
			DataRow[] array = dt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("dptype_id=15 and id<>", row["id"]), " and mablagh="), row["mablagh"]), " and hazine_id="), row["hazine_id"])));
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						this.DeleteDaryaftPardakhtRadif(Conversions.ToString(dataRow["id"]), "", "");
						dataRow.Delete();
					}
				}
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00106F58 File Offset: 0x00105358
		private void Find_Tekrar2(DataTable dt, DataRow row)
		{
			DataRow[] array = dt.Select(Conversions.ToString(Operators.ConcatenateObject("parent_id=", row["id"])));
			bool flag = array.Length > 0;
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectNotEqual(array[0]["dptype_id"], 10, false);
				if (flag2)
				{
					return;
				}
			}
			DataRow[] array2 = dt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("dptype_id=13 and id<>", row["id"]), " and mablagh="), row["mablagh"]), " and moshtari_id="), row["moshtari_id"])));
			flag2 = (array2.Length > 0);
			checked
			{
				if (flag2)
				{
					DataRow[] array3 = array2;
					for (int i = 0; i < array3.Length; i++)
					{
						DataRow dataRow = array3[i];
						flag = this.delete(dataRow);
						if (flag)
						{
							dataRow.Delete();
						}
					}
				}
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00107054 File Offset: 0x00105454
		private void Delete_Tekrari_Pardakht(DataTable dt)
		{
			DataRow[] array = dt.Select("dptype_id=15");
			bool flag = array.Length > 0;
			checked
			{
				bool flag2;
				if (flag)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						flag2 = (dataRow.RowState == DataRowState.Deleted);
						if (!flag2)
						{
							this.Find_Tekrar(dt, dataRow);
						}
					}
					dt.AcceptChanges();
				}
				array = dt.Select("dptype_id=13");
				flag2 = (array.Length > 0);
				if (flag2)
				{
					DataRow[] array3 = array;
					for (int j = 0; j < array3.Length; j++)
					{
						DataRow dataRow2 = array3[j];
						flag = (dataRow2.RowState == DataRowState.Deleted);
						if (!flag)
						{
							this.Find_Tekrar2(dt, dataRow2);
						}
					}
					dt.AcceptChanges();
				}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0010711C File Offset: 0x0010551C
		public DataTable GetPardakhtByID(string ID)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,   DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,   DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID,DaryaftPardakht.HazineKharid_ID,dpType.Name AS dp_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Bank_1.Name AS CheckBank_Name, Bank_3.Name + ' ' + Bank_Hesab.Shobe + ' - ' + Bank_Hesab.SahebHesab AS BankHesab_Name,   DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,   Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID,   Bank_2.Name + '-' + Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name, DaryaftPardakht.BankHesab_ID2, Bank.Name+' '+ Bank_Hesab_1.Shobe+' - '+ Bank_Hesab_1.SahebHesab AS BankHesab_Name2    FROM         Bank AS Bank_1 RIGHT OUTER JOIN    Bank AS Bank_2 INNER JOIN    Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID RIGHT OUTER JOIN    dpType INNER JOIN    DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN    Bank_Hesab AS Bank_Hesab_1 INNER JOIN    Bank ON Bank_Hesab_1.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID2 = Bank_Hesab_1.ID LEFT OUTER JOIN    Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID ON Moshtari_Hesab.ID = DaryaftPardakht.MoshtariHesab_ID ON    Bank_1.ID = DaryaftPardakht.CheckBank_ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN    Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN    Bank AS Bank_3 ON Bank_Hesab.Bank_ID = Bank_3.ID    WHERE     DaryaftPardakht.ID = " + ID + " OR DaryaftPardakht.Parent_ID=" + ID);
			dataTable.Columns.Add("Moshtari_ID2", typeof(int));
			dataTable.Columns.Add("Moshtari_Name2", typeof(string));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 14, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 17, false))
					{
						goto IL_BC;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
					{
						goto IL_BC;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 19, false))
					{
						goto IL_D8;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false))
					{
						goto IL_F7;
					}
					bool arg_F9_0 = false;
					IL_F8:
					bool flag = arg_F9_0;
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false);
					if (flag)
					{
						dataRow["hazine_id"] = RuntimeHelpers.GetObjectValue(dataRow["pardakhtcheck_id"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false);
					if (flag)
					{
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_ID"]);
						flag = (dataRow["checkbarg_id"] != DBNull.Value);
						if (flag)
						{
							dataRow["moshtari_id2"] = 2;
						}
						flag = (dataRow["pardakhtcheck_id"] != DBNull.Value);
						if (flag)
						{
							dataRow["moshtari_id2"] = 3;
							dataRow["bankhesab_id2"] = RuntimeHelpers.GetObjectValue(dataRow["pardakhtcheck_id"]);
						}
						flag = (dataRow["checkbarg_id"] == DBNull.Value && dataRow["pardakhtcheck_id"] == DBNull.Value);
						if (flag)
						{
							dataRow["moshtari_id2"] = 1;
						}
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 31, false);
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
						dataRow["bankhesab_id"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_id2"]);
						dataRow["bankhesab_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name2"]);
					}
					flag = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 30, false) && dataRow["hazine_id"] != DBNull.Value);
					if (flag)
					{
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_ID"]);
					}
					flag = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 29, false) && dataRow["hazine_id"] != DBNull.Value);
					if (flag)
					{
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Hazine_Name"]);
					}
					continue;
					IL_F7:
					arg_F9_0 = true;
					goto IL_F8;
					IL_D8:
					goto IL_F7;
					IL_BC:
					goto IL_D8;
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			dataTable.Columns.Add(new DataColumn("Daryaft_identity", typeof(int)));
			return dataTable;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00107578 File Offset: 0x00105978
		private void AddNaghddaryaft(DataTable dt)
		{
			DataRow[] array = dt.Select("dptype_ID=4");
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						bool flag2 = dataRow["ID"] == DBNull.Value;
						DataRow[] array3;
						if (flag2)
						{
							array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject("parent_identity=", dataRow["identity"])));
						}
						else
						{
							array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("parent_id=", dataRow["id"]), " OR parent_identity="), dataRow["identity"])));
						}
						flag2 = (array3.Length == 0);
						if (flag2)
						{
							DataRow dataRow2 = dt.NewRow();
							dataRow2["dptype_id"] = 1;
							dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh"]);
							dataRow2["moshtari_id"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_id"]);
							dataRow2["sandug_id"] = RuntimeHelpers.GetObjectValue(dataRow["sandug_id"]);
							dataRow2["mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
							dataRow2["mablagh2"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh2"]);
							dataRow2["tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh_Fa"]);
							dataRow2["dp_name"] = "دریافت نقد";
							dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
							dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["identity"]);
							dt.Rows.Add(dataRow2);
						}
					}
				}
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0010776C File Offset: 0x00105B6C
		public void UpdateDaryaft(string Tarikh, DataTable dt, List<long> lst)
		{
			string text = string.Empty;
			string text2 = "declare @sanadbed_id int,@sanadbes_id int;declare @moshtari_hesabid int;declare @bank_mojodi int;declare @parent_id int;declare @althesab_id int;declare @altsanad_id int;";
			this.DeleteNaghdRowsDaryaft(Tarikh, dt);
			this.AddNaghddaryaft(dt);
			checked
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -1, false);
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 5, false);
							if (!flag)
							{
								flag = (dataRow["parent_identity"] != DBNull.Value);
								if (!flag)
								{
									flag = (dataRow["tarikh"] != DBNull.Value);
									bool flag2;
									if (flag)
									{
										flag2 = (Operators.CompareString(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["tarikh"])), Tarikh, false) != 0);
										if (flag2)
										{
											continue;
										}
									}
									object left = dataRow["dptype_id"];
									flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 3, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 4, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 34, false))) ? true : false);
									if (flag2)
									{
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
									}
									else
									{
										flag2 = Operators.ConditionalCompareObjectEqual(left, 6, false);
										if (flag2)
										{
											text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from Daramad where id=", dataRow["Moshtari_ID"]), ";")));
										}
										else
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left, 8, false);
											if (flag2)
											{
												text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left, 25, false);
												if (flag2)
												{
													flag = (dataRow["moshtari_id"] != DBNull.Value);
													if (flag)
													{
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=codehesab_mojodi from bank_hesab where id=", dataRow["Moshtari_ID"]), ";")));
													}
													else
													{
														text2 += "select @moshtari_hesabid=1";
													}
												}
												else
												{
													flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 27, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 33, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 36, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 40, false))) ? true : false);
													if (flag2)
													{
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @bank_mojodi=codehesab_mojodi from bank_hesab where id=", dataRow["Moshtari_ID"]), ";")));
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left, 28, false);
														if (flag2)
														{
															flag = Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -1, false);
															if (flag)
															{
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
															}
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left, 43, false);
															if (flag2)
															{
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_id from moshtari where id=", dataRow["beMoshtari_ID"]), ";")));
															}
														}
													}
												}
											}
										}
									}
									flag2 = (dataRow["ID"] == DBNull.Value);
									if (flag2)
									{
										object left2 = dataRow["dpType_ID"];
										flag = Operators.ConditionalCompareObjectEqual(left2, 1, false);
										if (flag)
										{
											text = Conversions.ToString(Operators.ConcatenateObject("دریافت نقد از ", dataRow["Moshtari_Name"]));
											text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
											text2 += "select @sanadbed_id=scope_identity();";
											text = "دریافت نقد";
											text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
											text2 += "select @sanadbes_id=scope_identity();";
											text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
										}
										else
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left2, 2, false);
											if (flag2)
											{
												text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک از ", dataRow["Moshtari_Name"]));
												text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
												text2 += "select @sanadbed_id=scope_identity();";
												text = "دریافت چک در تاریخ " + Tarikh;
												text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
												text2 += "select @sanadbes_id=scope_identity();";
												text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_ShomareHesab"]))), ",1);")));
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left2, 3, false);
												if (flag2)
												{
													text = Conversions.ToString(Operators.ConcatenateObject("دریافت حواله بانکی از ", dataRow["Moshtari_Name"]));
													flag2 = (dataRow["Tozih"] != DBNull.Value);
													if (flag2)
													{
														text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
													}
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @bank_mojodi=CodeHesab_Mojodi from bank_hesab where id=", dataRow["BankHesab_ID"]), ";")));
													text2 += this.sanad.InsertStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
													text2 += "select @sanadbed_id=scope_identity();";
													text = Conversions.ToString(Operators.ConcatenateObject(" حواله بانکی به ", dataRow["bankhesab_Name"]));
													flag2 = (dataRow["Tozih"] != DBNull.Value);
													if (flag2)
													{
														text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
													}
													text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
													text2 += "select @sanadbes_id=scope_identity();";
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,CheckBank_ID,Check_Shobe,Sh_Fish) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["BankHesab_ID"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), ","), Public_Function.GetValue(dataRow["Sh_Fish"].ToString())), ");")));
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left2, 43, false);
													if (flag2)
													{
														text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("دریافت حواله ارزی از ", dataRow["Moshtari_Name"]), " به میزان "), Public_Function.FormatPrice(Conversions.ToString(dataRow["mablagh"]))), " دلار "), " -نرخ تبدیل "), Public_Function.FormatPrice(Conversions.ToString(dataRow["fishvariz_fa"]))), " ریال "));
														flag2 = (dataRow["Tozih"] != DBNull.Value);
														if (flag2)
														{
															text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
														}
														text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(Operators.MultiplyObject(dataRow["Mablagh"], dataRow["fishvariz_fa"])), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
														text2 += "select @sanadbed_id=scope_identity();";
														text = Conversions.ToString(Operators.ConcatenateObject(" حواله ارزی به ", dataRow["bemoshtari_Name"]));
														flag2 = (dataRow["Tozih"] != DBNull.Value);
														if (flag2)
														{
															text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
														}
														text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(Operators.MultiplyObject(dataRow["Mablagh"], dataRow["fishvariz_fa"])), Tarikh, text, Sanad.SanadType.@null);
														text2 += "select @sanadbes_id=scope_identity();";
														text2 += this.sanad.InsertStrArzi("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
														text2 += "select @altsanad_id=scope_identity();";
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,bemoshtari_ID,Mablagh,Tozih,Tarikh_Fa,CheckBank_ID,Check_Shobe,Sh_Fish,fishvariz_fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["bemoshtari_ID"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), ",@altsanad_id,"), Public_Function.GetValue(dataRow["fishvariz_fa"].ToString())), ");")));
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left2, 4, false);
														if (flag2)
														{
															text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");select @parent_id=scope_identity();")));
															int arg_EDB_0 = dt.Rows.IndexOf(dataRow) + 1;
															int num = dt.Rows.Count - 1;
															int num2 = arg_EDB_0;
															while (true)
															{
																int arg_149B_0 = num2;
																int num3 = num;
																if (arg_149B_0 > num3)
																{
																	break;
																}
																flag2 = (dt.Rows[num2]["parent_identity"] == DBNull.Value);
																if (!flag2)
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["parent_identity"], dataRow["identity"], false);
																	if (flag2)
																	{
																		object left3 = dt.Rows[num2]["dpType_ID"];
																		flag = Operators.ConditionalCompareObjectEqual(left3, 1, false);
																		if (flag)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("دریافت نقد از ", dataRow["Moshtari_Name"]));
																			text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(dt.Rows[num2]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbed_id=scope_identity();";
																			text = "دریافت نقد";
																			flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																			}
																			text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dt.Rows[num2]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity();";
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Parent_ID) VALUES(", dt.Rows[num2]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num2]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ",@parent_id);")));
																		}
																		else
																		{
																			flag2 = Operators.ConditionalCompareObjectEqual(left3, 2, false);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dt.Rows[num2]["Sh_Check"].ToString() + " بتاریخ ", dt.Rows[num2]["Check_Sarresid_Fa"]));
																				text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(dt.Rows[num2]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbed_id=scope_identity();";
																				text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dt.Rows[num2]["Sh_Check"].ToString() + " بتاریخ ", dt.Rows[num2]["Check_Sarresid_Fa"]));
																				text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dt.Rows[num2]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbes_id=scope_identity();";
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,Parent_ID) VALUES(", dt.Rows[num2]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num2]["Mablagh"]), ","), Public_Function.GetValue(dt.Rows[num2]["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num2]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num2]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num2]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num2]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num2]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num2]["Check_ShomareHesab"].ToString())), ",1,@parent_id);")));
																			}
																		}
																	}
																}
																num2++;
															}
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left2, 6, false);
															if (flag2)
															{
																text = Conversions.ToString(Operators.ConcatenateObject("دریافت نقد بابت ", dataRow["Moshtari_Name"]));
																text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbed_id=scope_identity();";
																text = Conversions.ToString(Operators.ConcatenateObject("بابت  ", dataRow["Moshtari_Name"]));
																text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbes_id=scope_identity();";
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Daramad_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(left2, 8, false);
																if (flag2)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject("تفاوت ", dataRow["Moshtari_Name"]));
																	text2 += this.sanad.InsertStr(Conversions.ToString(27), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																	text2 += "select @sanadbed_id=scope_identity();";
																	text = Conversions.ToString(Operators.ConcatenateObject("تفاوت  ", dataRow["Moshtari_Name"]));
																	text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																	text2 += "select @sanadbes_id=scope_identity();";
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left2, 25, false);
																	if (flag2)
																	{
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,bankhesab_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,"), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");select @parent_id=scope_identity();")));
																		int num4 = dt.Rows.IndexOf(dataRow) + 1;
																		while (dt.Rows[num4]["Parent_Identity"] != DBNull.Value)
																		{
																			object left4 = dt.Rows[num4]["dpType_ID"];
																			flag2 = Operators.ConditionalCompareObjectEqual(left4, 26, false);
																			if (flag2)
																			{
																				text = "نقد کردن چک به شماره " + dt.Rows[num4]["sh_check"].ToString();
																				text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num4]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbed_id=scope_identity();";
																				text2 += this.sanad.InsertStr("33", Conversions.ToString(0), Conversions.ToString(dt.Rows[num4]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbes_id=scope_identity();";
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,bankhesab_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num4]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id, "), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), " ,1,"), dt.Rows[num4]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num4]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num4]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num4]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num4]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num4]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num4]["Check_ShomareHesab"].ToString())), ",3,"), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num4]["PardakhtCheck_ID"]))), ",@parent_id);")));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num4]["PardakhtCheck_ID"]), ";")));
																			}
																			num4++;
																			flag2 = (num4 == dt.Rows.Count);
																			if (flag2)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(left2, 27, false);
																		if (flag2)
																		{
																			text = "دریافت از کارتخوان";
																			flag2 = (dataRow["tozih"] != DBNull.Value);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																			text2 += this.sanad.InsertStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbed_id=scope_identity();";
																			text2 += this.sanad.InsertStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity();";
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Parent_ID) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ",NULL);")));
																		}
																		else
																		{
																			flag2 = Operators.ConditionalCompareObjectEqual(left2, 28, false);
																			if (flag2)
																			{
																				flag = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false);
																				if (flag)
																				{
																					text2 += "select @moshtari_hesabid=1;";
																				}
																				text = "فروش بارروی زمین  - " + dataRow["Tozih"].ToString();
																				text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbed_id=scope_identity();";
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																			}
																			else
																			{
																				flag2 = Operators.ConditionalCompareObjectEqual(left2, 33, false);
																				if (flag2)
																				{
																					text = "دریافت تسهیلات";
																					flag2 = (dataRow["tozih"] != DBNull.Value);
																					if (flag2)
																					{
																						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																					}
																					text2 += this.sanad.InsertStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																					text2 += "select @sanadbed_id=scope_identity();";
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Parent_ID) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ",@parent_id);")));
																				}
																				else
																				{
																					flag2 = Operators.ConditionalCompareObjectEqual(left2, 34, false);
																					if (flag2)
																					{
																						text = "حقوق ماهیانه ";
																						flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																						if (flag2)
																						{
																							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																						}
																						text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																						text2 += "select @sanadbes_id=scope_identity();";
																						text = Conversions.ToString(Operators.ConcatenateObject("هزینه حقوق ", dataRow["moshtari_name"]));
																						flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																						if (flag2)
																						{
																							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																						}
																						text2 += this.sanad.InsertStr("39", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																						text2 += "select @sanadbed_id=scope_identity();";
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																					}
																					else
																					{
																						flag2 = Operators.ConditionalCompareObjectEqual(left2, 35, false);
																						if (flag2)
																						{
																							text = "فروش روزانه";
																							flag2 = (dataRow["tozih"] != DBNull.Value);
																							if (flag2)
																							{
																								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																							}
																							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(text)), ","), Public_Function.GetValue(Tarikh)), ");")));
																						}
																						else
																						{
																							flag2 = Operators.ConditionalCompareObjectEqual(left2, 36, false);
																							if (flag2)
																							{
																								text = "دریافت سود بانکی";
																								flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["Tozih"], string.Empty, false));
																								if (flag2)
																								{
																									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																								}
																								text2 += this.sanad.InsertStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																								text2 += "select @sanadbed_id=scope_identity();";
																								text2 += this.sanad.InsertStr("31", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																								text2 += "select @sanadbes_id=scope_identity();";
																								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), " );")));
																							}
																							else
																							{
																								flag2 = Operators.ConditionalCompareObjectEqual(left2, 40, false);
																								if (flag2)
																								{
																									text = "انتقال وجه به صندوق";
																									flag2 = (dataRow["sh_check"] != DBNull.Value);
																									if (flag2)
																									{
																										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" از طریق دسته چک به شماره", dataRow["sh_check"])));
																									}
																									flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["Tozih"], string.Empty, false));
																									if (flag2)
																									{
																										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																									}
																									text2 += this.sanad.InsertStr("@bank_mojodi", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																									text2 += "select @sanadbes_id=scope_identity();";
																									text2 += this.sanad.InsertStr("1", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																									text2 += "select @sanadbed_id=scope_identity();";
																									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,checkbarg_id,check_status,sh_check) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValueInt(dataRow["checkbarg_id"].ToString())), " ,3,"), Public_Function.GetValue(dataRow["sh_check"].ToString())), ");")));
																								}
																								else
																								{
																									flag2 = Operators.ConditionalCompareObjectEqual(left2, 41, false);
																									if (flag2)
																									{
																										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");select @parent_id=scope_identity();")));
																										int num5 = dt.Rows.IndexOf(dataRow) + 1;
																										while (dt.Rows[num5]["Parent_Identity"] != DBNull.Value)
																										{
																											object left5 = dt.Rows[num5]["dpType_ID"];
																											flag2 = Operators.ConditionalCompareObjectEqual(left5, 42, false);
																											if (flag2)
																											{
																												text = "دریافت چک از مشتری نقدی به شماره " + dt.Rows[num5]["sh_check"].ToString();
																												text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(dt.Rows[num5]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																												text2 += "select @sanadbed_id=scope_identity();";
																												text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Sandug_ID,moshtari_id,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num5]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,null ,1,"), dt.Rows[num5]["moshtari_id"]), ","), dt.Rows[num5]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num5]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num5]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num5]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num5]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num5]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num5]["Check_ShomareHesab"].ToString())), ",1,"), Public_Function.GetValueInt(dt.Rows[num5]["PardakhtCheck_ID"].ToString())), ",@parent_id);")));
																											}
																											num5++;
																											flag2 = (num5 == dt.Rows.Count);
																											if (flag2)
																											{
																												break;
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									else
									{
										object left6 = dataRow["dpType_ID"];
										flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left6, -1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left6, 5, false))) ? true : false);
										if (!flag2)
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left6, 1, false);
											if (flag2)
											{
												text = Conversions.ToString(Operators.ConcatenateObject("دریافت نقد از ", dataRow["Moshtari_Name"]));
												text2 += this.sanad.UpdateStr(Conversions.ToString(1), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
												text = "دریافت نقد در تاریخ " + Tarikh;
												text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
												text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left6, 2, false);
												if (flag2)
												{
													text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dataRow["Sh_Check"].ToString() + " بتاریخ ", dataRow["Check_Sarresid_Fa"]));
													text2 += this.sanad.UpdateStr(Conversions.ToString(33), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
													text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dataRow["Sh_Check"].ToString() + " بتاریخ ", dataRow["Check_Sarresid_Fa"]));
													text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET  ,Tozih=" + Public_Function.GetValue(dataRow["Tozih"].ToString()) + " ,Sh_Check=" + Public_Function.GetValue(dataRow["Sh_Check"].ToString()) + " ,[CheckBank_ID] = " + Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString()) + " ,Check_Shobe=" + Public_Function.GetValue(dataRow["Check_Shobe"].ToString()) + " ,Check_Sarresid=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString())) + " ,Check_Sarresid_Fa=" + Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString()) + " ,Check_ShomareHesab=" + Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString()) + " ,[Sh_Fish] = null " + " ,[FishVariz] = null " + " ,[FishVariz_Fa] = null " + " Where ID=", dataRow["PardakhtCheck_ID"]), ";")));
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left6, 3, false);
													if (flag2)
													{
														text = Conversions.ToString(Operators.ConcatenateObject("دریافت حواله بانکی از ", dataRow["Moshtari_Name"]));
														flag2 = (dataRow["Tozih"] != DBNull.Value);
														if (flag2)
														{
															text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
														}
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @bank_mojodi=CodeHesab_Mojodi from bank_hesab where id=", dataRow["BankHesab_ID"]), ";")));
														text2 += this.sanad.UpdateStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
														text = Conversions.ToString(Operators.ConcatenateObject(" حواله بانکی به ", dataRow["bankhesab_Name"]));
														flag2 = (dataRow["Tozih"] != DBNull.Value);
														if (flag2)
														{
															text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
														}
														text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,BankHesab_ID="), Public_Function.GetValueInt(dataRow["BankHesab_ID"].ToString())), " ,Sandug_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,CheckBank_ID="), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), " ,Sh_Fish="), Public_Function.GetValue(dataRow["Sh_Fish"].ToString())), " ,[Sh_Check] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left6, 43, false);
														if (flag2)
														{
															text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("دریافت حواله ارزی از ", dataRow["Moshtari_Name"]), " به میزان "), Public_Function.FormatPrice(Conversions.ToString(dataRow["mablagh"]))), " دلار "), " -نرخ تبدیل "), Public_Function.FormatPrice(Conversions.ToString(dataRow["fishvariz_fa"]))), " ریال "));
															flag2 = (dataRow["Tozih"] != DBNull.Value);
															if (flag2)
															{
																text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
															}
															text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(Operators.MultiplyObject(dataRow["Mablagh"], dataRow["fishvariz_fa"])), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
															text = Conversions.ToString(Operators.ConcatenateObject(" حواله بانکی به ", dataRow["bemoshtari_Name"]));
															flag2 = (dataRow["Tozih"] != DBNull.Value);
															if (flag2)
															{
																text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
															}
															text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(Operators.MultiplyObject(dataRow["Mablagh"], dataRow["fishvariz_fa"])), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
															text2 += this.sanad.UpdateStrArzi("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["sh_fish"]), Sanad.SanadType.@null);
															text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,bemoshtari_id="), Public_Function.GetValueInt(dataRow["bemoshtari_id"].ToString())), " ,Sandug_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,CheckBank_ID="), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), " ,Sh_Fish="), Public_Function.GetValue(dataRow["Sh_Fish"].ToString())), " ,Fishvariz_fa="), Public_Function.GetValue(dataRow["fishvariz_fa"].ToString())), " ,[Sh_Check] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left6, 4, false);
															if (flag2)
															{
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,[sanadbed_id]=null "), " ,[sanadbes_id]=null "), " Where ID="), dataRow["ID"]), ";select @parent_id="), dataRow["ID"]), ";")));
																int arg_3B2E_0 = dt.Rows.IndexOf(dataRow) + 1;
																int num6 = dt.Rows.Count - 1;
																int num7 = arg_3B2E_0;
																while (true)
																{
																	int arg_49EA_0 = num7;
																	int num3 = num6;
																	if (arg_49EA_0 > num3)
																	{
																		break;
																	}
																	flag2 = (dt.Rows[num7]["parent_identity"] == DBNull.Value);
																	if (!flag2)
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(dt.Rows[num7]["parent_identity"], dataRow["identity"], false);
																		if (flag2)
																		{
																			object left7 = dt.Rows[num7]["dpType_ID"];
																			flag = Operators.ConditionalCompareObjectEqual(left7, 1, false);
																			if (flag)
																			{
																				bool flag3 = dt.Rows[num7]["ID"] == DBNull.Value;
																				if (flag3)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject("دریافت نقد از ", dataRow["Moshtari_Name"]));
																					text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																					text2 += "select @sanadbed_id=scope_identity();";
																					text = "دریافت نقد";
																					flag3 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																					if (flag3)
																					{
																						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																					}
																					text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																					text2 += "select @sanadbes_id=scope_identity();";
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Parent_ID) VALUES(", dt.Rows[num7]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num7]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ",@parent_id);")));
																				}
																				else
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject("دریافت نقد از ", dataRow["Moshtari_Name"]));
																					text2 += this.sanad.UpdateStr(Conversions.ToString(1), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num7]["SanadBed_ID"]), Sanad.SanadType.@null);
																					text = "دریافت نقد ";
																					flag3 = (dataRow["tozih"] != DBNull.Value);
																					if (flag3)
																					{
																						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																					}
																					text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num7]["SanadBes_ID"]), Sanad.SanadType.@null);
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num7]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num7]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dt.Rows[num7]["ID"]), ";")));
																				}
																			}
																			else
																			{
																				bool flag3 = Operators.ConditionalCompareObjectEqual(left7, 2, false);
																				if (flag3)
																				{
																					flag2 = (dt.Rows[num7]["ID"] == DBNull.Value);
																					if (flag2)
																					{
																						text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dt.Rows[num7]["Sh_Check"].ToString() + " بتاریخ ", dt.Rows[num7]["Check_Sarresid_Fa"]));
																						text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																						text2 += "select @sanadbed_id=scope_identity();";
																						text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dt.Rows[num7]["Sh_Check"].ToString() + " بتاریخ ", dt.Rows[num7]["Check_Sarresid_Fa"]));
																						text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																						text2 += "select @sanadbes_id=scope_identity();";
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,Parent_ID) VALUES(", dt.Rows[num7]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num7]["Mablagh"]), ","), Public_Function.GetValue(dt.Rows[num7]["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num7]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num7]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num7]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num7]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num7]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num7]["Check_ShomareHesab"].ToString())), ",1,@parent_id);")));
																					}
																					else
																					{
																						text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dt.Rows[num7]["Sh_Check"].ToString() + " بتاریخ ", dt.Rows[num7]["Check_Sarresid_Fa"]));
																						text2 += this.sanad.UpdateStr(Conversions.ToString(33), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num7]["SanadBed_ID"]), Sanad.SanadType.@null);
																						text = Conversions.ToString(Operators.ConcatenateObject("دریافت چک شماره " + dt.Rows[num7]["Sh_Check"].ToString() + " بتاریخ ", dt.Rows[num7]["Check_Sarresid_Fa"]));
																						text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dt.Rows[num7]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num7]["SanadBes_ID"]), Sanad.SanadType.@null);
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num7]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num7]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dt.Rows[num7]["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num7]["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dt.Rows[num7]["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num7]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num7]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num7]["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dt.Rows[num7]["Check_ShomareHesab"].ToString())), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dt.Rows[num7]["ID"]), ";")));
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET  Tozih=" + Public_Function.GetValue(dt.Rows[num7]["Tozih"].ToString()) + " ,Sh_Check=" + Public_Function.GetValue(dt.Rows[num7]["Sh_Check"].ToString()) + " ,[CheckBank_ID] = " + Public_Function.GetValueInt(dt.Rows[num7]["CheckBank_ID"].ToString()) + " ,Check_Shobe=" + Public_Function.GetValue(dt.Rows[num7]["Check_Shobe"].ToString()) + " ,Check_Sarresid=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num7]["Check_Sarresid_Fa"].ToString())) + " ,Check_Sarresid_Fa=" + Public_Function.GetValue(dt.Rows[num7]["Check_Sarresid_Fa"].ToString()) + " ,Check_ShomareHesab=" + Public_Function.GetValue(dt.Rows[num7]["Check_ShomareHesab"].ToString()) + " ,[Sh_Fish] = null " + " ,[FishVariz] = null " + " ,[FishVariz_Fa] = null " + " Where PardakhtCheck_ID=", dt.Rows[num7]["ID"]), ";")));
																						flag3 = Operators.ConditionalCompareObjectNotEqual(dt.Rows[num7]["Mablagh"], dt.Rows[num7]["Mablagh2"], false);
																						if (flag3)
																						{
																							text2 += this.EslahCheck(dt.Rows[num7], lst);
																						}
																					}
																				}
																			}
																		}
																	}
																	num7++;
																}
															}
															else
															{
																bool flag3 = Operators.ConditionalCompareObjectEqual(left6, 6, false);
																if (flag3)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject("دریافت نقد بابت ", dataRow["Moshtari_Name"]));
																	text2 += this.sanad.UpdateStr(Conversions.ToString(1), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																	text = Conversions.ToString(Operators.ConcatenateObject("بابت ", dataRow["Moshtari_Name"]));
																	text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Daramad_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																}
																else
																{
																	flag3 = Operators.ConditionalCompareObjectEqual(left6, 8, false);
																	if (flag3)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject("تفاوت ", dataRow["Moshtari_Name"]));
																		text2 += this.sanad.UpdateStr(Conversions.ToString(27), Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																		text = Conversions.ToString(Operators.ConcatenateObject("تفاوت ", dataRow["Moshtari_Name"]));
																		text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																	}
																	else
																	{
																		flag3 = Operators.ConditionalCompareObjectEqual(left6, 25, false);
																		if (flag3)
																		{
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,[sanadbed_id]=null "), " ,[sanadbes_id]=null "), " Where ID="), dataRow["ID"]), ";select @parent_id="), dataRow["ID"]), ";")));
																			int num8 = dt.Rows.IndexOf(dataRow) + 1;
																			while (dt.Rows[num8]["Parent_Identity"] != DBNull.Value)
																			{
																				object left8 = dt.Rows[num8]["dpType_ID"];
																				flag3 = Operators.ConditionalCompareObjectEqual(left8, 26, false);
																				if (flag3)
																				{
																					flag2 = (dt.Rows[num8]["ID"] == DBNull.Value);
																					if (flag2)
																					{
																						text = "نقد کردن چک به شماره  " + dt.Rows[num8]["sh_check"].ToString();
																						text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num8]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																						text2 += "select @sanadbed_id=scope_identity();";
																						text2 += this.sanad.InsertStr("33", Conversions.ToString(0), Conversions.ToString(dt.Rows[num8]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																						text2 += "select @sanadbes_id=scope_identity();";
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,bankhesab_id,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num8]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num8]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num8]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num8]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num8]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num8]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num8]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num8]["Check_ShomareHesab"].ToString())), ",3,"), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num8]["PardakhtCheck_ID"]))), ",@parent_id);")));
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num8]["PardakhtCheck_ID"]), ";")));
																					}
																					else
																					{
																						text = "نقد کردن چک به شماره  " + dt.Rows[num8]["sh_check"].ToString();
																						text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num8]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num8]["SanadBed_ID"]), Sanad.SanadType.@null);
																						text2 += this.sanad.UpdateStr("33", Conversions.ToString(0), Conversions.ToString(dt.Rows[num8]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num8]["SanadBes_ID"]), Sanad.SanadType.@null);
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num8]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num8]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num8]["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dt.Rows[num8]["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num8]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num8]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num8]["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dt.Rows[num8]["Check_ShomareHesab"].ToString())), " ,Check_status=3"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " Where ID="), dt.Rows[num8]["ID"]), ";")));
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num8]["PardakhtCheck_ID"]), ";")));
																					}
																				}
																				num8++;
																				flag3 = (num8 == dt.Rows.Count);
																				if (flag3)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			flag3 = Operators.ConditionalCompareObjectEqual(left6, 27, false);
																			if (flag3)
																			{
																				text = "دریافت از کارتخوان";
																				flag3 = (dataRow["tozih"] != DBNull.Value);
																				if (flag3)
																				{
																					text = text + " - " + dataRow["tozih"].ToString();
																				}
																				text2 += this.sanad.UpdateStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																				text2 += this.sanad.UpdateStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), dataRow["Moshtari_ID"]), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Parent_ID] = null "), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																			}
																			else
																			{
																				flag3 = Operators.ConditionalCompareObjectEqual(left6, 28, false);
																				if (flag3)
																				{
																					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false);
																					if (flag2)
																					{
																						text2 += "select @moshtari_hesabid=1;";
																					}
																					text = "فروش بارروی زمین  - " + dataRow["Tozih"].ToString();
																					flag3 = (dataRow["sanadbed_ID"] != DBNull.Value);
																					if (flag3)
																					{
																						text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["sanadBed_ID"]), Sanad.SanadType.@null);
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject("select @sanadbed_id=", dataRow["sanadbed_id"])));
																					}
																					else
																					{
																						text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																						text2 += "select @sanadbed_id=scope_identity();";
																					}
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,Moshtari_ID="), dataRow["Moshtari_ID"]), " ,SanadBed_ID=@sanadbed_id"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																				}
																				else
																				{
																					flag3 = Operators.ConditionalCompareObjectEqual(left6, 33, false);
																					if (flag3)
																					{
																						text = "دریافت تسهیلات";
																						flag3 = (dataRow["tozih"] != DBNull.Value);
																						if (flag3)
																						{
																							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																						}
																						flag3 = (dataRow["sanadbed_id"] != DBNull.Value);
																						if (flag3)
																						{
																							text2 += this.sanad.UpdateStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, dataRow["SanadBed_ID"].ToString(), Sanad.SanadType.@null);
																						}
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), dataRow["Moshtari_ID"]), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																					}
																					else
																					{
																						flag3 = Operators.ConditionalCompareObjectEqual(left6, 34, false);
																						if (flag3)
																						{
																							text = "حقوق ماهیانه ";
																							flag3 = (dataRow["tozih"] != DBNull.Value);
																							if (flag3)
																							{
																								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																							}
																							text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																							text = Conversions.ToString(Operators.ConcatenateObject("هزینه حقوق ", dataRow["moshtari_name"]));
																							flag3 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																							if (flag3)
																							{
																								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																							}
																							flag3 = (dataRow["sanadbed_id"] == DBNull.Value);
																							if (flag3)
																							{
																								text2 += this.sanad.InsertStr("39", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																								text2 += "select @sanadbed_id=scope_identity();";
																							}
																							else
																							{
																								text2 += this.sanad.UpdateStr("39", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @sanadbed_id= ", dataRow["Sanadbed_id"]), ";")));
																							}
																							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sanadbed_id=@sanadbed_id"), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																						}
																						else
																						{
																							flag3 = Operators.ConditionalCompareObjectEqual(left6, 35, false);
																							if (flag3)
																							{
																								text = "فروش روزانه";
																								flag3 = (dataRow["tozih"] != DBNull.Value);
																								if (flag3)
																								{
																									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																								}
																								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID=1"), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(text)), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																							}
																							else
																							{
																								flag3 = Operators.ConditionalCompareObjectEqual(left6, 36, false);
																								if (flag3)
																								{
																									text = "دریافت سود بانکی";
																									flag3 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["Tozih"], string.Empty, false));
																									if (flag3)
																									{
																										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																									}
																									text2 += this.sanad.UpdateStr("@bank_mojodi", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																									text2 += this.sanad.UpdateStr("31", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), dataRow["Moshtari_ID"]), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																								}
																								else
																								{
																									flag3 = Operators.ConditionalCompareObjectEqual(left6, 40, false);
																									if (flag3)
																									{
																										text = "انتقال وجه به صندوق";
																										flag3 = (dataRow["sh_check"] != DBNull.Value);
																										if (flag3)
																										{
																											text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" از طریق دسته چک به شماره", dataRow["sh_check"])));
																										}
																										flag3 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["Tozih"], string.Empty, false));
																										if (flag3)
																										{
																											text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																										}
																										text2 += this.sanad.UpdateStr("@bank_mojodi", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																										text2 += this.sanad.UpdateStr("1", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), dataRow["Moshtari_ID"]), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Checkbarg_id="), Public_Function.GetValue(dataRow["checkbarg_id"].ToString())), " ,[Sh_Check] =  "), Public_Function.GetValue(dataRow["sh_check"].ToString())), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =3 "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																									}
																									else
																									{
																										flag3 = Operators.ConditionalCompareObjectEqual(left6, 41, false);
																										if (flag3)
																										{
																											text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,[sanadbed_id]=null "), " ,[sanadbes_id]=null "), " Where ID="), dataRow["ID"]), ";select @parent_id="), dataRow["ID"]), ";")));
																											int num9 = dt.Rows.IndexOf(dataRow) + 1;
																											while (dt.Rows[num9]["Parent_Identity"] != DBNull.Value)
																											{
																												object left9 = dt.Rows[num9]["dpType_ID"];
																												flag3 = Operators.ConditionalCompareObjectEqual(left9, 42, false);
																												if (flag3)
																												{
																													flag2 = (dt.Rows[num9]["ID"] == DBNull.Value);
																													if (flag2)
																													{
																														text = "دریافت چک از مشتری نقدی به شماره  " + dt.Rows[num9]["sh_check"].ToString();
																														text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(dt.Rows[num9]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																														text2 += "select @sanadbed_id=scope_identity();";
																														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Sandug_ID,moshtari_id,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num9]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,NULL,1,"), dt.Rows[num9]["moshtari_id"]), ","), dt.Rows[num9]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num9]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num9]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num9]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num9]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num9]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num9]["Check_ShomareHesab"].ToString())), ",1,"), Public_Function.GetValueInt(dt.Rows[num9]["PardakhtCheck_ID"].ToString())), ",@parent_id);")));
																													}
																													else
																													{
																														text = "نقد کردن چک به شماره  " + dt.Rows[num9]["sh_check"].ToString();
																														text2 += this.sanad.UpdateStr(Conversions.ToString(1), Conversions.ToString(dt.Rows[num9]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num9]["SanadBed_ID"]), Sanad.SanadType.@null);
																														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num9]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,moshtari_id="), dt.Rows[num9]["moshtari_id"]), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num9]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num9]["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dt.Rows[num9]["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num9]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num9]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num9]["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dt.Rows[num9]["Check_ShomareHesab"].ToString())), " ,Check_status=1"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " Where ID="), dt.Rows[num9]["ID"]), ";")));
																													}
																												}
																												num9++;
																												flag3 = (num9 == dt.Rows.Count);
																												if (flag3)
																												{
																													break;
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag3 = enumerator is IDisposable;
					if (flag3)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0010E7FC File Offset: 0x0010CBFC
		public void EslahJamKol(List<long> lst)
		{
			string text = string.Empty;
			long num = 0L;
			bool flag;
			try
			{
				List<long>.Enumerator enumerator = lst.GetEnumerator();
				while (enumerator.MoveNext())
				{
					long current = enumerator.Current;
					DataTable dataTable = Public_Function.FillData("select * from daryaftpardakht  where parent_id=" + Conversions.ToString(current));
					try
					{
						IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator2.Current;
							num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
						}
					}
					finally
					{
						IEnumerator enumerator2;
						flag = (enumerator2 is IDisposable);
						if (flag)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					text = string.Concat(new string[]
					{
						text,
						"update daryaftpardakht set mablagh=",
						Conversions.ToString(num),
						" where id= ",
						Conversions.ToString(current),
						";"
					});
					num = 0L;
				}
			}
			finally
			{
				List<long>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0010E95C File Offset: 0x0010CD5C
		private string EslahCheck(DataRow row, List<long> lst)
		{
			DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("select * from daryaftpardakht where pardakhtcheck_id=", row["id"])));
			string text = string.Empty;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set mablagh=", row["mablagh"]), " where id="), dataRow["ID"]), ";")));
					bool flag = dataRow["sanadbed_id"] != DBNull.Value;
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update sanad set bed=", row["Mablagh"]), " where id="), dataRow["sanadbed_id"]), ";")));
					}
					flag = (dataRow["sanadbes_id"] != DBNull.Value);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update sanad set bes=", row["Mablagh"]), " where id="), dataRow["sanadbes_id"]), ";")));
					}
					flag = !lst.Contains(Conversions.ToLong(dataRow["parent_id"]));
					if (flag)
					{
						lst.Add(Conversions.ToLong(dataRow["parent_ID"]));
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return text;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0010EB48 File Offset: 0x0010CF48
		private bool Check_SayerAmaliyat(long id, string Tarikh)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from daryaftpardakht where pardakhtcheck_id=" + Conversions.ToString(id) + " and tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))));
			bool flag = num == 0;
			return !flag;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0010EB98 File Offset: 0x0010CF98
		private void DeleteNaghdRowsDaryaft(string Tarikh, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
				{
					"select sanadbed_id,sanadbes_id from daryaftpardakht where tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" AND dptype_id in(1) AND ID NOT IN(",
					iD,
					");"
				}));
				flag = (dataTable.Rows.Count > 0);
				if (flag)
				{
					text = string.Concat(new string[]
					{
						text,
						"update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where tarikh=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
						" and dptype_id in(1) AND ID NOT IN (",
						iD,
						");"
					});
					text = text + "delete from sanad where id in(" + Public_Function.GetID(dataTable, "sanadbed_id", "") + ");";
					text = text + "delete from sanad where id in(" + Public_Function.GetID(dataTable, "sanadbes_id", "") + ");";
					text = string.Concat(new string[]
					{
						text,
						"delete from daryaftpardakht  Where Tarikh=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
						" AND dptype_id in(1)  AND ID NOT IN(",
						iD,
						");"
					});
				}
				flag = (text.Length > 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0010ED08 File Offset: 0x0010D108
		private void DeleteNaghdRows(string Tarikh, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
				{
					"select sanadbed_id,sanadbes_id from daryaftpardakht where tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
					" AND dptype_id in(10) AND ID NOT IN(",
					iD,
					");"
				}));
				flag = (dataTable.Rows.Count > 0);
				if (flag)
				{
					string iD2 = Public_Function.GetID(dataTable, "sanadbed_id", "");
					string iD3 = Public_Function.GetID(dataTable, "sanadbes_id", "");
					text = string.Concat(new string[]
					{
						text,
						"update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where tarikh=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
						" and dptype_id in(10) AND ID NOT IN (",
						iD,
						");"
					});
					flag = (iD2.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + iD2 + ");";
					}
					flag = (iD3.Length > 0);
					if (flag)
					{
						text = text + "delete from sanad where id in(" + iD3 + ");";
					}
					text = string.Concat(new string[]
					{
						text,
						"delete from daryaftpardakht  Where Tarikh=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
						" AND dptype_id in(10)  AND ID NOT IN(",
						iD,
						");"
					});
				}
				flag = (text.Length > 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0010EEB8 File Offset: 0x0010D2B8
		private bool Isused(DataTable dt, long Pardakhtcheck_id)
		{
			bool result;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["pardakhtcheck_id"] != DBNull.Value;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["pardakhtcheck_id"], Pardakhtcheck_id, false);
						if (flag2)
						{
							result = true;
							return result;
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0010EF64 File Offset: 0x0010D364
		private void AddNaghdPardakht(DataTable dt)
		{
			DataRow[] array = dt.Select("dptype_ID=13");
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						bool flag2 = dataRow["ID"] == DBNull.Value;
						DataRow[] array3;
						if (flag2)
						{
							array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject("parent_identity=", dataRow["identity"])));
						}
						else
						{
							array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("parent_id=", dataRow["id"]), " OR parent_identity="), dataRow["identity"])));
						}
						flag2 = (array3.Length == 0);
						if (flag2)
						{
							DataRow dataRow2 = dt.NewRow();
							dataRow2["dptype_id"] = 10;
							dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh"]);
							dataRow2["moshtari_id"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_id"]);
							dataRow2["sandug_id"] = RuntimeHelpers.GetObjectValue(dataRow["sandug_id"]);
							dataRow2["mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
							dataRow2["tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh_Fa"]);
							dataRow2["dp_name"] = "پرداخت نقد";
							dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
							dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["identity"]);
							dt.Rows.Add(dataRow2);
						}
					}
				}
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0010F13C File Offset: 0x0010D53C
		public void UpdatePardakht(string Tarikh, DataTable dt)
		{
			string text = string.Empty;
			string text2 = "declare @sanadbed_id int,@sanadbes_id int,@moshtari_hesabid int;declare @parent_id int;declare @althesab_id int;declare @check_id int;declare @stat_id int;";
			this.DeleteNaghdRows(Tarikh, dt);
			this.AddNaghdPardakht(dt);
			checked
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["parent_identity"] != DBNull.Value;
						if (!flag)
						{
							flag = (dataRow["dptype_id"] == DBNull.Value || dataRow["dptype_id"] == null);
							if (!flag)
							{
								flag = (dataRow["tarikh"] != DBNull.Value);
								bool flag2;
								if (flag)
								{
									flag2 = (Operators.CompareString(Public_Function.MiladiToShamsi(Conversions.ToDate(dataRow["tarikh"])), Tarikh, false) != 0);
									if (flag2)
									{
										continue;
									}
								}
								object left = dataRow["dptype_id"];
								flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, -2, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, -3, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 16, false))) ? true : false);
								if (!flag2)
								{
									flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 13, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 32, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 45, false))) ? true : false);
									if (flag2)
									{
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
									}
									else
									{
										flag2 = Operators.ConditionalCompareObjectEqual(left, 14, false);
										if (flag2)
										{
											text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_Mojodi from Bank_Hesab where id=", dataRow["Moshtari_ID"]), ";")));
										}
										else
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left, 15, false);
											if (flag2)
											{
												text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from Hazine where id=", dataRow["Moshtari_ID"]), ";")));
												flag2 = (dataRow["bankhesab_id"] != DBNull.Value);
												if (flag2)
												{
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Mojodi from Bank_Hesab where id=", dataRow["bankhesab_id"]), ";")));
												}
												else
												{
													flag2 = (dataRow["hazine_id"] != DBNull.Value);
													if (flag2)
													{
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_id from moshtari where id=", dataRow["hazine_id"]), ";")));
													}
												}
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left, 17, false);
												if (flag2)
												{
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_Vusul from Bank_Hesab where id=", dataRow["Moshtari_ID"]), ";")));
												}
												else
												{
													flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left, 29, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 30, false))) ? true : false);
													if (flag2)
													{
														flag = (dataRow["hazine_id"] != DBNull.Value);
														if (flag)
														{
															text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from hazine where id=", dataRow["hazine_id"]), ";")));
														}
														else
														{
															text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
														}
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=codehesab_mojodi from bank_hesab where id=", dataRow["bankhesab_id"]), ";")));
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left, 31, false);
														if (flag2)
														{
															text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_mojodi from Bank_Hesab where id=", dataRow["Moshtari_ID"]), ";")));
															text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=codehesab_mojodi from bank_hesab where id=", dataRow["bankhesab_id"]), ";")));
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left, 37, false);
															if (flag2)
															{
																flag = (dataRow["bankhesab_id"] != DBNull.Value);
																if (flag)
																{
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_mojodi from Bank_Hesab where id=", dataRow["bankhesab_id"]), ";")));
																}
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(left, 38, false);
																if (flag2)
																{
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
																	flag2 = (dataRow["bankhesab_id"] != DBNull.Value);
																	if (flag2)
																	{
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=codehesab_mojodi from bank_hesab where id=", dataRow["bankhesab_id"]), ";")));
																	}
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left, 39, false);
																	if (flag2)
																	{
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_id from moshtari where id=", dataRow["beMoshtari_id"]), ";")));
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(left, 44, false);
																		if (flag2)
																		{
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dataRow["Moshtari_ID"]), ";")));
																			flag2 = (dataRow["bemoshtari_id"] != DBNull.Value);
																			if (flag2)
																			{
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_id from moshtari where id=", dataRow["bemoshtari_id"]), ";")));
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									flag2 = (dataRow["ID"] == DBNull.Value);
									if (flag2)
									{
										object left2 = dataRow["dpType_ID"];
										flag = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left2, -2, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left2, -3, false))) ? true : false);
										if (!flag)
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left2, 13, false);
											if (flag2)
											{
												text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,moshtarihesab_id) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValueInt(dataRow["moshtarihesab_id"].ToString())), ");select @parent_id=scope_identity();")));
												int arg_817_0 = dt.Rows.IndexOf(dataRow) + 1;
												int num = dt.Rows.Count - 1;
												int num2 = arg_817_0;
												while (true)
												{
													int arg_12B9_0 = num2;
													int num3 = num;
													if (arg_12B9_0 > num3)
													{
														break;
													}
													flag2 = (dt.Rows[num2]["parent_identity"] == DBNull.Value);
													if (!flag2)
													{
														flag2 = Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["parent_identity"], dataRow["identity"], false);
														if (flag2)
														{
															object left3 = dt.Rows[num2]["dpType_ID"];
															flag = Operators.ConditionalCompareObjectEqual(left3, 10, false);
															if (flag)
															{
																text = "پرداخت نقد";
																flag2 = (dataRow["tozih"] != DBNull.Value);
																if (flag2)
																{
																	flag = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																	if (flag)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																	}
																}
																text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num2]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbed_id=scope_identity();";
																text = Conversions.ToString(Operators.ConcatenateObject("پرداخت نقد به ", dataRow["Moshtari_Name"]));
																text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Conversions.ToString(dt.Rows[num2]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbes_id=scope_identity();";
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Parent_ID) VALUES(", dt.Rows[num2]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num2]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ",@parent_id);")));
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(left3, 11, false);
																if (flag2)
																{
																	string[] array = dt.Rows[num2]["bankhesab_name"].ToString().Split(new char[]
																	{
																		'-'
																	});
																	text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت از دسته چک " + array[0] + " بشماره ", dt.Rows[num2]["Sh_Check"]), "به سررسید  "), dt.Rows[num2]["Check_Sarresid_Fa"]));
																	flag2 = (dataRow["tozih"] != DBNull.Value);
																	if (flag2)
																	{
																		flag = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																		if (flag)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																		}
																	}
																	text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num2]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																	text2 += "select @sanadbed_id=scope_identity();";
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Sarresid,Check_Sarresid_Fa,CheckBarg_ID,BankHesab_ID,Check_Status,Parent_ID) VALUES(", dt.Rows[num2]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), dt.Rows[num2]["Mablagh"]), ","), Public_Function.GetValue(dt.Rows[num2]["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num2]["Sh_Check"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num2]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num2]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValueInt(dt.Rows[num2]["CheckBarg_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num2]["BankHesab_ID"].ToString())), ",5,@parent_id);")));
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left3, 12, false);
																	if (flag2)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت چک ", dt.Rows[num2]["checkbank_name"]), " "), dt.Rows[num2]["check_shobe"]), " به شماره "), dt.Rows[num2]["sh_check"]), " به سررسید "), dt.Rows[num2]["check_sarresid_fa"]));
																		flag2 = (dataRow["tozih"] != DBNull.Value);
																		if (flag2)
																		{
																			flag = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																			if (flag)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																			}
																		}
																		text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num2]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																		text2 += "select @sanadbed_id=scope_identity();";
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت چک ", dt.Rows[num2]["checkbank_name"]), " "), dt.Rows[num2]["check_shobe"]), " به شماره "), dt.Rows[num2]["sh_check"]), " به سررسید "), dt.Rows[num2]["check_sarresid_fa"]));
																		flag2 = (dataRow["tozih"] != DBNull.Value);
																		if (flag2)
																		{
																			flag = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																			if (flag)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																			}
																		}
																		text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dt.Rows[num2]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																		text2 += "select @sanadbes_id=scope_identity();";
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num2]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num2]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num2]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num2]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num2]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num2]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num2]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num2]["Check_ShomareHesab"].ToString())), ",5,"), Public_Function.GetValueInt(dt.Rows[num2]["PardakhtCheck_ID"].ToString())), ",@parent_id);")));
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dt.Rows[num2]["PardakhtCheck_ID"]), ";")));
																	}
																}
															}
														}
													}
													num2++;
												}
											}
											else
											{
												flag2 = Operators.ConditionalCompareObjectEqual(left2, 17, false);
												if (flag2)
												{
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");select @parent_id=scope_identity();")));
													int num4 = dt.Rows.IndexOf(dataRow) + 1;
													while (dt.Rows[num4]["Parent_Identity"] != DBNull.Value)
													{
														object left4 = dt.Rows[num4]["dpType_ID"];
														flag2 = Operators.ConditionalCompareObjectEqual(left4, 18, false);
														if (flag2)
														{
															text = "واگذاری چک در تاریخ " + Tarikh;
															text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num4]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
															text2 += "select @sanadbed_id=scope_identity();";
															text = Conversions.ToString(Operators.ConcatenateObject("واگذاری چک به ", dataRow["Moshtari_Name"]));
															text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dt.Rows[num4]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
															text2 += "select @sanadbes_id=scope_identity();";
															text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num4]["dptype_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num4]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num4]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num4]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num4]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num4]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num4]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num4]["Check_ShomareHesab"].ToString())), ",2,"), Public_Function.GetValueInt(dt.Rows[num4]["PardakhtCheck_ID"].ToString())), ",@parent_id);")));
															flag2 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num4]["PardakhtCheck_ID"]), Tarikh);
															if (flag2)
															{
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=2 where id=", dt.Rows[num4]["PardakhtCheck_ID"]), ";")));
															}
														}
														num4++;
														flag2 = (num4 == dt.Rows.Count);
														if (flag2)
														{
															break;
														}
													}
												}
												else
												{
													flag2 = Operators.ConditionalCompareObjectEqual(left2, 14, false);
													if (flag2)
													{
														text = "انتقال وجه نقد از صندوق ";
														flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
														if (flag2)
														{
															text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - واریزی فیش ", dataRow["tozih"])));
														}
														text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
														text2 += "select @sanadbed_id=scope_identity();";
														text = "انتقال وجه نقد به حساب بانکی در تاریخ " + Tarikh;
														text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
														text2 += "select @sanadbes_id=scope_identity();";
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
													}
													else
													{
														flag2 = Operators.ConditionalCompareObjectEqual(left2, 15, false);
														if (flag2)
														{
															object left5 = dataRow["moshtari_id2"];
															flag = Operators.ConditionalCompareObjectEqual(left5, 1, false);
															if (flag)
															{
																text = Conversions.ToString(Operators.ConcatenateObject("هزینه  ", dataRow["Moshtari_Name"]));
																flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																if (flag2)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																}
																text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbed_id=scope_identity();";
																text = Conversions.ToString(Operators.ConcatenateObject("پرداخت هزینه  ", dataRow["Moshtari_Name"]));
																flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																if (flag2)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																}
																text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbes_id=scope_identity();";
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Hazine_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(left5, 2, false);
																if (flag2)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["moshtari_name"]), " از طریق "), " دسته چک بشماره "), dataRow["Sh_Check"]), "به سررسید  "), dataRow["Check_Sarresid_Fa"]));
																	flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																	if (flag2)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																	}
																	text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																	text2 += "select @sanadbed_id=scope_identity();";
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Hazine_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Sarresid,Check_Sarresid_Fa,CheckBarg_ID,BankHesab_ID,Check_Status) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ","), Public_Function.GetValueInt(dataRow["CheckBarg_ID"].ToString())), ","), Public_Function.GetValue(dataRow["BankHesab_ID"].ToString())), ",5);")));
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left5, 3, false);
																	if (flag2)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["moshtari_name"]), " از طریق چک بشماره "), dataRow["sh_check"]));
																		flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																		if (flag2)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																		}
																		text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																		text2 += "select @sanadbed_id=scope_identity();";
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["moshtari_name"]), " از طریق چک بشماره "), dataRow["sh_check"]));
																		flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																		if (flag2)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																		}
																		text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																		text2 += "select @sanadbes_id=scope_identity();";
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Hazine_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), ",5,"), Public_Function.GetValueInt(dataRow["PardakhtCheck_ID"].ToString())), ");")));
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dataRow["PardakhtCheck_ID"]), ";")));
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(left5, 4, false);
																		if (flag2)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("هزینه  ", dataRow["Moshtari_Name"]));
																			flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																			text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbed_id=scope_identity();";
																			text = Conversions.ToString(Operators.ConcatenateObject("پرداخت هزینه  ", dataRow["Moshtari_Name"]));
																			flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																			text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity();";
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Hazine_ID,bankhesab_id,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Bankhesab_id"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																		}
																		else
																		{
																			flag2 = Operators.ConditionalCompareObjectEqual(left5, 5, false);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject("هزینه  ", dataRow["Moshtari_Name"]));
																				flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																				}
																				text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbed_id=scope_identity();";
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["Moshtari_Name"]), " از تنخواه"));
																				flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																				}
																				text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbes_id=scope_identity();";
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Hazine_ID,moshtari_id,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["hazine_id"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																			}
																		}
																	}
																}
															}
														}
														else
														{
															flag2 = Operators.ConditionalCompareObjectEqual(left2, 19, false);
															if (flag2)
															{
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,"), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");select @parent_id=scope_identity();")));
																int num5 = dt.Rows.IndexOf(dataRow) + 1;
																while (dt.Rows[num5]["Parent_Identity"] != DBNull.Value)
																{
																	object left6 = dt.Rows[num5]["dpType_ID"];
																	flag2 = Operators.ConditionalCompareObjectEqual(left6, 20, false);
																	if (flag2)
																	{
																		flag = (dt.Rows[num5]["checkbarg_ID"] == DBNull.Value);
																		if (flag)
																		{
																			string right = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
																			{
																				Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", dt.Rows[num5]["pardakhtcheck_ID"])
																			}, null, null, null));
																			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک دریافتی از  ", dt.Rows[num5]["CheckBank_Name"]), " به شماره "), dt.Rows[num5]["Sh_Check"]), " از "), right));
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dt.Rows[num5]["Moshtari_ID"]), ";")));
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=codehesab_mojodi from bank_hesab where id=", dt.Rows[num5]["Moshtari_ID"]), ";")));
																			text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num5]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbed_id=scope_identity();";
																			text = Conversions.ToString(Operators.ConcatenateObject("وصول چک شماره  ", dt.Rows[num5]["Sh_Check"]));
																			text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num5]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity();";
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num5]["dptype_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num5]["Moshtari_ID"]))), ","), dt.Rows[num5]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num5]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num5]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num5]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num5]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num5]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num5]["Check_ShomareHesab"].ToString())), ",3,"), dt.Rows[num5]["PardakhtCheck_ID"]), ",@parent_id);")));
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num5]["PardakhtCheck_ID"]), ";")));
																		}
																		else
																		{
																			string right2 = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
																			{
																				Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", dt.Rows[num5]["pardakhtcheck_ID"])
																			}, null, null, null));
																			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک پرداختی به شماره ", dt.Rows[num5]["Sh_Check"]), "به سررسید  "), dt.Rows[num5]["Check_Sarresid_Fa"]), " به "), right2));
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Mojodi from bank_hesab where id=", dt.Rows[num5]["CheckBank_ID"]), ";")));
																			text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num5]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity();";
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,CheckBarg_ID,Parent_ID) VALUES(", dt.Rows[num5]["dptype_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,@sanadbes_id ,"), Public_Function.GetValueInt(dt.Rows[num5]["CheckBank_ID"].ToString())), ","), dt.Rows[num5]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num5]["Sh_Check"].ToString())), ","), Public_Function.GetValue(dt.Rows[num5]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num5]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num5]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num5]["Check_ShomareHesab"].ToString())), ",3,"), dt.Rows[num5]["PardakhtCheck_ID"]), ","), dt.Rows[num5]["checkbarg_ID"]), ",@parent_id);")));
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num5]["PardakhtCheck_ID"]), ";")));
																		}
																	}
																	num5++;
																	flag2 = (num5 == dt.Rows.Count);
																	if (flag2)
																	{
																		break;
																	}
																}
															}
															else
															{
																flag2 = Operators.ConditionalCompareObjectEqual(left2, 21, false);
																if (flag2)
																{
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,NULL,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");select @parent_id=scope_identity();")));
																	int num6 = dt.Rows.IndexOf(dataRow) + 1;
																	while (dt.Rows[num6]["Parent_Identity"] != DBNull.Value)
																	{
																		object left7 = dt.Rows[num6]["dpType_ID"];
																		flag2 = Operators.ConditionalCompareObjectEqual(left7, 22, false);
																		if (flag2)
																		{
																			bool flag3 = true;
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dt.Rows[num6]["Moshtari_ID"]), ";")));
																			flag2 = (dt.Rows[num6]["BankHesab_ID"] == DBNull.Value);
																			if (flag2)
																			{
																				flag = (dt.Rows[num6]["Moshtari_id2"] != DBNull.Value);
																				if (flag)
																				{
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_id from moshtari where id=", dt.Rows[num6]["Moshtari_ID2"]), ";")));
																				}
																				else
																				{
																					flag2 = (dt.Rows[num6]["CheckBarg_ID"] != DBNull.Value);
																					if (flag2)
																					{
																						flag3 = false;
																						text2 += " select @althesab_id=NULL;";
																					}
																					else
																					{
																						text2 += "select @althesab_id=1";
																					}
																				}
																			}
																			else
																			{
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dt.Rows[num6]["BankHesab_ID"]), ";")));
																			}
																			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگشت چک شماره  ", dt.Rows[num6]["Sh_Check"]), " "), dt.Rows[num6]["checkbank_name"]), " "), dt.Rows[num6]["Check_Shobe"]), " به سررسید  "), dt.Rows[num6]["Check_Sarresid_Fa"]));
																			flag2 = (dataRow["Tozih"] != DBNull.Value);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																			}
																			text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num6]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbed_id=scope_identity();";
																			flag2 = flag3;
																			if (flag2)
																			{
																				text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num6]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbes_id=scope_identity();";
																			}
																			else
																			{
																				text2 += "select @sanadbes_id=null;";
																			}
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,checkbarg_id,Parent_ID) VALUES(", dt.Rows[num6]["dptype_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num6]["Moshtari_ID"]))), ","), Public_Function.GetValueInt(dt.Rows[num6]["BankHesab_ID"].ToString())), ","), dt.Rows[num6]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num6]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num6]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num6]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num6]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num6]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num6]["Check_ShomareHesab"].ToString())), ",4,"), dt.Rows[num6]["PardakhtCheck_ID"]), ","), Public_Function.GetValueInt(dt.Rows[num6]["checkbarg_id"].ToString())), ",@parent_id);")));
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=4 where id=", dt.Rows[num6]["PardakhtCheck_ID"]), ";")));
																		}
																		num6++;
																		flag2 = (num6 == dt.Rows.Count);
																		if (flag2)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	flag2 = Operators.ConditionalCompareObjectEqual(left2, 29, false);
																	if (flag2)
																	{
																		flag = (dataRow["hazine_id"] != DBNull.Value);
																		if (flag)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت برای پرداخت هزینه ", dataRow["moshtari_name"]));
																		}
																		else
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت از ", dataRow["BankHesab_Name"]));
																			flag2 = (dataRow["tozih"] != DBNull.Value);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																		}
																		text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																		text2 += "select @sanadbed_id=scope_identity();";
																		flag2 = (dataRow["hazine_id"] != DBNull.Value);
																		if (flag2)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت برای پرداخت هزینه ", dataRow["moshtari_name"]));
																		}
																		else
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت به ", dataRow["moshtari_Name"]));
																			flag2 = (dataRow["tozih"] != DBNull.Value);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																		}
																		text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																		text2 += "select @sanadbes_id=scope_identity();";
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_id,hazine_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["hazine_id"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["bankhesab_id"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																	}
																	else
																	{
																		flag2 = Operators.ConditionalCompareObjectEqual(left2, 30, false);
																		if (flag2)
																		{
																			flag = (dataRow["hazine_id"] != DBNull.Value);
																			if (flag)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت ", dataRow["moshtari_name"]), " از بانک "), dataRow["bankhesab_name"]));
																				flag2 = (dataRow["tozih"] != DBNull.Value);
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" بابت ", dataRow["tozih"])));
																				}
																			}
																			else
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت به ", dataRow["moshtari_name"]), " از بانک "), dataRow["bankhesab_name"]));
																				flag2 = (dataRow["tozih"] != DBNull.Value);
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" بابت ", dataRow["tozih"])));
																				}
																			}
																			text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbed_id=scope_identity();";
																			flag2 = (dataRow["hazine_id"] != DBNull.Value);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject("پرداخت ", dataRow["moshtari_name"]));
																				flag2 = (dataRow["tozih"] != DBNull.Value);
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" بابت ", dataRow["tozih"])));
																				}
																			}
																			else
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject("پرداخت به ", dataRow["moshtari_name"]));
																				flag2 = (dataRow["tozih"] != DBNull.Value);
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" بابت ", dataRow["tozih"])));
																				}
																			}
																			text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity();";
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_id,hazine_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["hazine_id"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["bankhesab_id"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																		}
																		else
																		{
																			flag2 = Operators.ConditionalCompareObjectEqual(left2, 31, false);
																			if (flag2)
																			{
																				flag = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																				if (flag)
																				{
																					text = dataRow["tozih"].ToString();
																				}
																				else
																				{
																					text = "انتقال از بانک " + dataRow["bankhesab_name"].ToString();
																				}
																				text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbed_id=scope_identity();";
																				flag2 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																				if (flag2)
																				{
																					text = dataRow["tozih"].ToString();
																				}
																				else
																				{
																					text = "انتقال به " + dataRow["moshtari_name"].ToString();
																				}
																				text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbes_id=scope_identity();";
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,BankHesab_ID,BankHesab_ID2,Mablagh,Tozih,Tarikh_Fa,sh_check,checkbarg_id) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["moshtari_id"]))), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["bankhesab_id"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["sh_check"].ToString())), ","), Public_Function.GetValueInt(dataRow["checkbarg_id"].ToString())), ");")));
																			}
																			else
																			{
																				flag2 = Operators.ConditionalCompareObjectEqual(left2, 32, false);
																				if (flag2)
																				{
																					text = "الباقی فاکتور فروش";
																					text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																					text2 += "select @sanadbed_id=scope_identity();";
																					text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																					text2 += "select @sanadbes_id=scope_identity();";
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,sandug_ID,Moshtari_id,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,1,"), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																				}
																				else
																				{
																					flag2 = Operators.ConditionalCompareObjectEqual(left2, 37, false);
																					if (flag2)
																					{
																						long num7 = Conversions.ToLong(Public_Function.ExecuteScalar("select mablagh from daryaftpardakht where id=" + Public_Function.GetValue(Conversions.ToString(dataRow["moshtari_id"]))));
																						long num8 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=37 and sh_fish=" + Public_Function.GetValue(Conversions.ToString(dataRow["moshtari_id"]))));
																						flag2 = (num8 < num7);
																						long num9;
																						if (flag2)
																						{
																							num8 = Conversions.ToLong(Operators.AddObject(num8, dataRow["mablagh"]));
																							num9 = num8 - num7;
																						}
																						else
																						{
																							num9 = Conversions.ToLong(dataRow["mablagh"]);
																						}
																						text = "پرداخت اقساط";
																						flag2 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																						if (flag2)
																						{
																							text = text + " - " + dataRow["tozih"].ToString();
																						}
																						flag2 = (num9 > 0L);
																						if (flag2)
																						{
																							text2 += this.sanad.InsertStr("32", Conversions.ToString(num9), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																							text2 += "select @sanadbed_id=scope_identity();";
																						}
																						else
																						{
																							text2 += "select @sanadbed_id=NULL;";
																						}
																						string right3 = "NULL";
																						flag2 = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id2"], 1, false);
																						if (flag2)
																						{
																							text2 += this.sanad.InsertStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																							right3 = "1";
																						}
																						else
																						{
																							text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																						}
																						text2 += "select @sanadbes_id=scope_identity();";
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,sandug_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,sh_fish) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), right3), ","), Public_Function.GetValueInt(dataRow["bankhesab_id"].ToString())), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["moshtari_id"].ToString())), ");")));
																					}
																					else
																					{
																						flag2 = Operators.ConditionalCompareObjectEqual(left2, 38, false);
																						if (flag2)
																						{
																							text = "دریافت تنخواه";
																							flag2 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																							if (flag2)
																							{
																								text = text + " - " + dataRow["tozih"].ToString();
																							}
																							text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																							text2 += "select @sanadbed_id=scope_identity();";
																							text = Conversions.ToString(Operators.ConcatenateObject("پرداخت تنخواه به ", dataRow["moshtari_name"]));
																							flag2 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																							if (flag2)
																							{
																								text = text + " - " + dataRow["tozih"].ToString();
																							}
																							string right4 = "NULL";
																							flag2 = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id2"], 1, false);
																							if (flag2)
																							{
																								text2 += this.sanad.InsertStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																								right4 = "1";
																							}
																							else
																							{
																								text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																							}
																							text2 += "select @sanadbes_id=scope_identity();";
																							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,sandug_id,moshtari_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), right4), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["moshtari_id"]))), ","), Public_Function.GetValueInt(dataRow["bankhesab_id"].ToString())), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ");")));
																						}
																						else
																						{
																							flag2 = Operators.ConditionalCompareObjectEqual(left2, 39, false);
																							if (flag2)
																							{
																								text = Conversions.ToString(Operators.ConcatenateObject("مشتری به مشتری - ", dataRow["beMoshtari_ID"]));
																								flag2 = (dataRow["tozih"] != DBNull.Value);
																								if (flag2)
																								{
																									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																								}
																								text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																								text2 += "select @sanadbes_id=scope_identity();";
																								text = Conversions.ToString(Operators.ConcatenateObject("پرداخت از ", dataRow["moshtari_name"]));
																								flag2 = (dataRow["tozih"] != DBNull.Value);
																								if (flag2)
																								{
																									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																								}
																								text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																								text2 += "select @sanadbed_id=scope_identity();";
																								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_id,Mablagh,Tozih,Tarikh_Fa,beMoshtari_ID) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), dataRow["beMoshtari_ID"]), ");")));
																							}
																							else
																							{
																								flag2 = Operators.ConditionalCompareObjectEqual(left2, 44, false);
																								if (flag2)
																								{
																									text = " پرداخت حواله ارزی -  نرخ تبدیل " + Public_Function.FormatPrice(Conversions.ToString(dataRow["fishvariz_fa"])) + " ریال ";
																									flag2 = (Operators.CompareString(dataRow["tozih"].ToString(), "", false) != 0);
																									if (flag2)
																									{
																										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																									}
																									text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																									text2 += "select @sanadbed_id=scope_identity();";
																									text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" حواله ارزی به ", dataRow["moshtari_Name"]), " به میزان "), Public_Function.FormatPrice(Conversions.ToString(dataRow["mablagh"]))), " دلار "), " -نرخ تبدیل "), Public_Function.FormatPrice(Conversions.ToString(dataRow["fishvariz_fa"]))), " ریال "));
																									flag2 = (dataRow["Tozih"] != DBNull.Value);
																									if (flag2)
																									{
																										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																									}
																									text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(Operators.MultiplyObject(dataRow["Mablagh"], dataRow["fishvariz_fa"])), Tarikh, text, Sanad.SanadType.@null);
																									text2 += "select @sanadbes_id=scope_identity();";
																									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,bemoshtari_id,Mablagh,Tozih,Tarikh_Fa,fishvariz_fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["bemoshtari_id"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["fishvariz_fa"].ToString())), ");")));
																								}
																								else
																								{
																									flag2 = Operators.ConditionalCompareObjectEqual(left2, 45, false);
																									if (flag2)
																									{
																										text = "تخفیف ";
																										flag2 = (Operators.CompareString(dataRow["tozih"].ToString(), "", false) != 0);
																										if (flag2)
																										{
																											text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																										}
																										text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																										text2 += "select @sanadbed_id=scope_identity();";
																										text = Conversions.ToString(Operators.ConcatenateObject("تخفیف به ", dataRow["moshtari_Name"]));
																										flag2 = (dataRow["Tozih"] != DBNull.Value);
																										if (flag2)
																										{
																											text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																										}
																										text2 += this.sanad.InsertStr("43", Conversions.ToString(dataRow["mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																										text2 += "select @sanadbes_id=scope_identity();";
																										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Mablagh,Tozih,Tarikh_Fa,fishvariz_fa) VALUES(", dataRow["dpType_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["fishvariz_fa"].ToString())), ");")));
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									else
									{
										object left8 = dataRow["dpType_ID"];
										flag2 = Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(left8, -2, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left8, -3, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left8, 16, false))) ? true : false);
										if (!flag2)
										{
											flag2 = Operators.ConditionalCompareObjectEqual(left8, 13, false);
											if (flag2)
											{
												text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Moshtarihesab_id="), Public_Function.GetValueInt(dataRow["moshtarihesab_id"].ToString())), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,[sanadbed_id]=null "), " ,[sanadbes_id]=null "), " Where ID="), dataRow["ID"]), ";select @parent_id="), dataRow["ID"]), ";")));
												int arg_4F59_0 = dt.Rows.IndexOf(dataRow) + 1;
												int num10 = dt.Rows.Count - 1;
												int num11 = arg_4F59_0;
												while (true)
												{
													int arg_6674_0 = num11;
													int num3 = num10;
													if (arg_6674_0 > num3)
													{
														break;
													}
													flag2 = (dt.Rows[num11]["parent_identity"] == DBNull.Value);
													if (!flag2)
													{
														flag2 = Operators.ConditionalCompareObjectEqual(dt.Rows[num11]["parent_identity"], dataRow["identity"], false);
														if (flag2)
														{
															object left9 = dt.Rows[num11]["dpType_ID"];
															flag = Operators.ConditionalCompareObjectEqual(left9, 10, false);
															if (flag)
															{
																bool flag4 = dt.Rows[num11]["ID"] == DBNull.Value;
																if (flag4)
																{
																	text = "پرداخت نقد";
																	flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																	if (flag4)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																	}
																	text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num11]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																	text2 += "select @sanadbed_id=scope_identity();";
																	text = Conversions.ToString(Operators.ConcatenateObject("پرداخت نقد به ", dataRow["Moshtari_Name"]));
																	text2 += this.sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Conversions.ToString(dt.Rows[num11]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																	text2 += "select @sanadbes_id=scope_identity();";
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Parent_ID) VALUES(", dt.Rows[num11]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num11]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ",@parent_id);")));
																}
																else
																{
																	text = Conversions.ToString(Operators.ConcatenateObject("پرداخت نقد به ", dataRow["Moshtari_Name"]));
																	text2 += this.sanad.UpdateStr(Conversions.ToString(1), Conversions.ToString(0), Conversions.ToString(dt.Rows[num11]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num11]["SanadBes_ID"]), Sanad.SanadType.@null);
																	text = "پرداخت نقد";
																	flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																	if (flag4)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																	}
																	text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num11]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num11]["SanadBed_ID"]), Sanad.SanadType.@null);
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num11]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num11]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dt.Rows[num11]["ID"]), ";")));
																}
															}
															else
															{
																bool flag4 = Operators.ConditionalCompareObjectEqual(left9, 11, false);
																if (flag4)
																{
																	flag2 = (dt.Rows[num11]["ID"] == DBNull.Value);
																	if (flag2)
																	{
																		string[] array = dt.Rows[num11]["bankhesab_name"].ToString().Split(new char[]
																		{
																			'-'
																		});
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت از دسته چک " + array[0] + " بشماره ", dt.Rows[num11]["Sh_Check"]), "به سررسید  "), dt.Rows[num11]["Check_Sarresid_Fa"]));
																		flag4 = (dataRow["tozih"] != DBNull.Value);
																		if (flag4)
																		{
																			flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																			}
																		}
																		text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num11]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																		text2 += "select @sanadbed_id=scope_identity();";
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Sarresid,Check_Sarresid_Fa,CheckBarg_ID,BankHesab_ID,Check_Status,Parent_ID) VALUES(", dt.Rows[num11]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,NULL ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num11]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num11]["Sh_Check"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num11]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num11]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValueInt(dt.Rows[num11]["CheckBarg_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num11]["BankHesab_ID"].ToString())), ",5,@parent_id);")));
																	}
																	else
																	{
																		string[] array = dt.Rows[num11]["bankhesab_name"].ToString().Split(new char[]
																		{
																			'-'
																		});
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت از دسته چک " + array[0] + " بشماره ", dt.Rows[num11]["Sh_Check"]), "به سررسید  "), dt.Rows[num11]["Check_Sarresid_Fa"]));
																		flag4 = (dataRow["tozih"] != DBNull.Value);
																		if (flag4)
																		{
																			flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																			}
																		}
																		text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num11]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num11]["SanadBed_ID"]), Sanad.SanadType.@null);
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num11]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num11]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dt.Rows[num11]["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num11]["Sh_Check"].ToString())), " ,CheckBarg_ID="), Public_Function.GetValueInt(dt.Rows[num11]["CheckBarg_ID"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num11]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num11]["Check_Sarresid_Fa"].ToString())), " ,BankHesab_ID= "), Public_Function.GetValueInt(dt.Rows[num11]["BankHesab_ID"].ToString())), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dt.Rows[num11]["ID"]), ";")));
																		flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num11]["ID"]), Tarikh);
																		if (flag4)
																		{
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dt.Rows[num11]["ID"]), ";")));
																		}
																	}
																}
																else
																{
																	flag4 = Operators.ConditionalCompareObjectEqual(left9, 12, false);
																	if (flag4)
																	{
																		flag2 = (dt.Rows[num11]["ID"] == DBNull.Value);
																		if (flag2)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت چک ", dt.Rows[num11]["checkbank_name"]), " "), dt.Rows[num11]["check_shobe"]), " به شماره "), dt.Rows[num11]["sh_check"]), " به سررسید "), dt.Rows[num11]["check_sarresid_fa"]));
																			flag4 = (dataRow["tozih"] != DBNull.Value);
																			if (flag4)
																			{
																				flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																				}
																			}
																			text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dt.Rows[num11]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity();";
																			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت چک ", dt.Rows[num11]["checkbank_name"]), " "), dt.Rows[num11]["check_shobe"]), " به شماره "), dt.Rows[num11]["sh_check"]), " به سررسید "), dt.Rows[num11]["check_sarresid_fa"]));
																			flag4 = (dataRow["tozih"] != DBNull.Value);
																			if (flag4)
																			{
																				flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																				}
																			}
																			text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num11]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbed_id=scope_identity();";
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num11]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num11]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num11]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num11]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num11]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num11]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num11]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num11]["Check_ShomareHesab"].ToString())), ",5,"), Public_Function.GetValueInt(dt.Rows[num11]["PardakhtCheck_ID"].ToString())), ",@parent_id);")));
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dt.Rows[num11]["PardakhtCheck_ID"]), ";")));
																		}
																		else
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت چک ", dt.Rows[num11]["checkbank_name"]), " "), dt.Rows[num11]["check_shobe"]), " به شماره "), dt.Rows[num11]["sh_check"]), " به سررسید "), dt.Rows[num11]["check_sarresid_fa"]));
																			flag4 = (dataRow["tozih"] != DBNull.Value);
																			if (flag4)
																			{
																				flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false);
																				if (flag2)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																				}
																			}
																			text2 += this.sanad.UpdateStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dt.Rows[num11]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num11]["SanadBes_ID"]), Sanad.SanadType.@null);
																			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت چک ", dt.Rows[num11]["checkbank_name"]), " "), dt.Rows[num11]["check_shobe"]), " به شماره "), dt.Rows[num11]["sh_check"]), " به سررسید "), dt.Rows[num11]["check_sarresid_fa"]));
																			text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num11]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num11]["SanadBed_ID"]), Sanad.SanadType.@null);
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num11]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num11]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num11]["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dt.Rows[num11]["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num11]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num11]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num11]["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dt.Rows[num11]["Check_ShomareHesab"].ToString())), " ,Check_status=5"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = "), dt.Rows[num11]["PardakhtCheck_ID"]), " Where ID="), dt.Rows[num11]["ID"]), ";")));
																			flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num11]["PardakhtCheck_ID"]), Tarikh);
																			if (flag4)
																			{
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dt.Rows[num11]["PardakhtCheck_ID"]), ";")));
																			}
																		}
																	}
																}
															}
														}
													}
													num11++;
												}
											}
											else
											{
												bool flag4 = Operators.ConditionalCompareObjectEqual(left8, 17, false);
												if (flag4)
												{
													text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID=NULL"), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,[sanadbed_id]=null "), " ,[sanadbes_id]=null "), " Where ID="), dataRow["ID"]), ";select @parent_id="), dataRow["ID"]), ";")));
													int num12 = dt.Rows.IndexOf(dataRow) + 1;
													while (dt.Rows[num12]["Parent_Identity"] != DBNull.Value)
													{
														object left10 = dt.Rows[num12]["dpType_ID"];
														flag4 = Operators.ConditionalCompareObjectEqual(left10, 18, false);
														if (flag4)
														{
															flag2 = (dt.Rows[num12]["ID"] == DBNull.Value);
															if (flag2)
															{
																text = Conversions.ToString(Operators.ConcatenateObject("واگذاری چک به ", dataRow["Moshtari_Name"]));
																text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dt.Rows[num12]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbes_id=scope_identity();";
																text = "واگذاری چک در تاریخ " + Tarikh;
																text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num12]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																text2 += "select @sanadbed_id=scope_identity();";
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num12]["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), ",1,"), dt.Rows[num12]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num12]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num12]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num12]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num12]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num12]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num12]["Check_ShomareHesab"].ToString())), ",2,"), Public_Function.GetValueInt(dt.Rows[num12]["PardakhtCheck_ID"].ToString())), ",@parent_id);")));
																flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num12]["PardakhtCheck_ID"]), Tarikh);
																if (flag4)
																{
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=2 where id=", dt.Rows[num12]["PardakhtCheck_ID"]), ";")));
																}
															}
															else
															{
																text = Conversions.ToString(Operators.ConcatenateObject("واگذاری چک به ", dataRow["Moshtari_Name"]));
																text2 += this.sanad.UpdateStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dt.Rows[num12]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num12]["SanadBes_ID"]), Sanad.SanadType.@null);
																text = "واگذاری چک در تاریخ " + Tarikh;
																text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num12]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num12]["SanadBed_ID"]), Sanad.SanadType.@null);
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num12]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID=NULL"), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num12]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num12]["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dt.Rows[num12]["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num12]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num12]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num12]["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dt.Rows[num12]["Check_ShomareHesab"].ToString())), " ,Check_status=2"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = "), dt.Rows[num12]["PardakhtCheck_ID"]), " Where ID="), dt.Rows[num12]["ID"]), ";")));
																flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num12]["PardakhtCheck_ID"]), Tarikh);
																if (flag4)
																{
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=2 where id=", dt.Rows[num12]["PardakhtCheck_ID"]), ";")));
																}
															}
														}
														num12++;
														flag4 = (num12 == dt.Rows.Count);
														if (flag4)
														{
															break;
														}
													}
												}
												else
												{
													flag4 = Operators.ConditionalCompareObjectEqual(left8, 14, false);
													if (flag4)
													{
														text = "انتقال وجه نقد از صندوق ";
														flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
														if (flag4)
														{
															text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - واریزی فیش ", dataRow["tozih"])));
														}
														text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
														text = "انتقال وجه نقد به حساب بانکی در تاریخ " + Tarikh;
														text2 += this.sanad.UpdateStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
														text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID=1 "), " ,BankHesab_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Moshtari_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
													}
													else
													{
														flag4 = Operators.ConditionalCompareObjectEqual(left8, 15, false);
														if (flag4)
														{
															object left11 = dataRow["moshtari_id2"];
															flag2 = Operators.ConditionalCompareObjectEqual(left11, 1, false);
															if (flag2)
															{
																text = Conversions.ToString(Operators.ConcatenateObject("هزینه  ", dataRow["Moshtari_Name"]));
																flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																if (flag4)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																}
																text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																text = Conversions.ToString(Operators.ConcatenateObject("پرداخت هزینه  ", dataRow["Moshtari_Name"]));
																flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																if (flag4)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																}
																text2 += this.sanad.UpdateStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID=1 "), " ,BankHesab_ID=NULL"), " ,Moshtari_ID=null"), " ,Hazine_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
															}
															else
															{
																flag4 = Operators.ConditionalCompareObjectEqual(left11, 2, false);
																if (flag4)
																{
																	text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["moshtari_name"]), " از طریق "), " دسته چک بشماره "), dataRow["Sh_Check"]), "به سررسید  "), dataRow["Check_Sarresid_Fa"]));
																	flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																	if (flag4)
																	{
																		text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																	}
																	text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Hazine_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,moshtari_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), " ,CheckBarg_ID="), Public_Function.GetValueInt(dataRow["CheckBarg_ID"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString())), " ,BankHesab_ID= "), Public_Function.GetValueInt(dataRow["BankHesab_ID"].ToString())), " ,CheckBank_ID=NULL"), " ,Check_Shobe=NULL"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,SanadBes_ID=NULL"), " Where ID="), dataRow["ID"]), ";")));
																	flag4 = (dataRow["sanadBes_ID"] != DBNull.Value);
																	if (flag4)
																	{
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id=", dataRow["sanadbes_ID"]), ";")));
																	}
																	flag4 = (dataRow["bankhesab_id2"] != DBNull.Value);
																	if (flag4)
																	{
																		flag2 = !this.Isused(dt, Conversions.ToLong(dataRow["bankhesab_id2"]));
																		if (flag2)
																		{
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set check_status=1 where id=", dataRow["bankhesab_id2"]), ";")));
																		}
																	}
																}
																else
																{
																	flag4 = Operators.ConditionalCompareObjectEqual(left11, 3, false);
																	if (flag4)
																	{
																		string right5 = string.Empty;
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["moshtari_name"]), " از طریق چک بشماره "), dataRow["sh_check"]));
																		flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																		if (flag4)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																		}
																		flag4 = (dataRow["SanadBes_ID"] != DBNull.Value);
																		if (flag4)
																		{
																			text2 += this.sanad.UpdateStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																		}
																		else
																		{
																			text2 += this.sanad.InsertStr(Conversions.ToString(33), Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																			text2 += "select @sanadbes_id=scope_identity(); ";
																			right5 = " ,SanadBes_ID=@sanadbes_id";
																		}
																		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["moshtari_name"]), " از طریق چک بشماره "), dataRow["sh_check"]));
																		flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																		if (flag4)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																		}
																		text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,hazine_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID="), Public_Function.GetValueInt(dataRow["Sandug_ID"].ToString())), " ,BankHesab_ID=null"), " ,Mablagh="), dataRow["Mablagh"]), right5), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), " ,CheckBarg_ID=NULL"), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), " ,Check_status=5"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = "), dataRow["PardakhtCheck_ID"]), " Where ID="), dataRow["ID"]), ";")));
																		flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dataRow["PardakhtCheck_ID"]), Tarikh);
																		if (flag4)
																		{
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dataRow["PardakhtCheck_ID"]), ";")));
																		}
																		flag4 = (dataRow["bankhesab_id2"] != DBNull.Value);
																		if (flag4)
																		{
																			flag2 = !this.Isused(dt, Conversions.ToLong(dataRow["bankhesab_id2"]));
																			if (flag2)
																			{
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set check_status=1 where id=", dataRow["bankhesab_id2"]), ";")));
																			}
																		}
																	}
																	else
																	{
																		flag4 = Operators.ConditionalCompareObjectEqual(left11, 4, false);
																		if (flag4)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("هزینه  ", dataRow["Moshtari_Name"]));
																			flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																			text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																			text = Conversions.ToString(Operators.ConcatenateObject("پرداخت هزینه  ", dataRow["Moshtari_Name"]));
																			flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																			text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID=1 "), " ,BankHesab_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["bankhesab_id"]))), " ,Moshtari_ID=null"), " ,Hazine_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																		}
																		else
																		{
																			flag4 = Operators.ConditionalCompareObjectEqual(left11, 5, false);
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject("هزینه  ", dataRow["Moshtari_Name"]));
																				flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																				if (flag4)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																				}
																				text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت هزینه ", dataRow["Moshtari_Name"]), " از تنخواه"));
																				flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																				if (flag4)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																				}
																				text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID=null "), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["hazine_id"]))), " ,Hazine_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																			}
																		}
																	}
																}
															}
														}
														else
														{
															flag4 = Operators.ConditionalCompareObjectEqual(left8, 19, false);
															if (flag4)
															{
																text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID="), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), " ,Sandug_ID=NULL"), " ,Moshtari_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,[sanadbed_id]=null "), " ,[sanadbes_id]=null "), " Where ID="), dataRow["ID"]), ";select @parent_id="), dataRow["ID"]), ";")));
																int num13 = dt.Rows.IndexOf(dataRow) + 1;
																while (dt.Rows[num13]["Parent_Identity"] != DBNull.Value)
																{
																	object left12 = dt.Rows[num13]["dpType_ID"];
																	flag4 = Operators.ConditionalCompareObjectEqual(left12, 20, false);
																	if (flag4)
																	{
																		flag2 = (dt.Rows[num13]["ID"] == DBNull.Value);
																		if (flag2)
																		{
																			flag = (dt.Rows[num13]["checkbarg_ID"] == DBNull.Value);
																			if (flag)
																			{
																				string right6 = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
																				{
																					Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", dt.Rows[num13]["pardakhtcheck_ID"])
																				}, null, null, null));
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک دریافتی از  ", dt.Rows[num13]["CheckBank_Name"]), " به شماره "), dt.Rows[num13]["Sh_Check"]), " از "), right6));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dt.Rows[num13]["Moshtari_ID"]), ";")));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=codehesab_mojodi from bank_hesab where id=", dt.Rows[num13]["Moshtari_ID"]), ";")));
																				text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num13]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbed_id=scope_identity();";
																				text = Conversions.ToString(Operators.ConcatenateObject("وصول چک شماره  ", dt.Rows[num13]["Sh_Check"]));
																				text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num13]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbes_id=scope_identity();";
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID) VALUES(", dt.Rows[num13]["dptype_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num13]["Moshtari_ID"]))), ","), dt.Rows[num13]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num13]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num13]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num13]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num13]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num13]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num13]["Check_ShomareHesab"].ToString())), ",3,"), dt.Rows[num13]["PardakhtCheck_ID"]), ",@parent_id);")));
																				flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num13]["PardakhtCheck_ID"]), Tarikh);
																				if (flag4)
																				{
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num13]["PardakhtCheck_ID"]), ";")));
																				}
																			}
																			else
																			{
																				string right7 = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
																				{
																					Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", dt.Rows[num13]["pardakhtcheck_ID"])
																				}, null, null, null));
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک پرداختی به شماره ", dt.Rows[num13]["Sh_Check"]), "به سررسید  "), dt.Rows[num13]["Check_Sarresid_Fa"]), " به "), right7));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Mojodi from bank_hesab where id=", dt.Rows[num13]["CheckBank_ID"]), ";")));
																				text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num13]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbes_id=scope_identity();";
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Checkbarg_ID,Parent_ID) VALUES(", dt.Rows[num13]["dptype_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,@sanadbes_id ,"), Public_Function.GetValueInt(dt.Rows[num13]["CheckBank_ID"].ToString())), ","), dt.Rows[num13]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num13]["Sh_Check"].ToString())), ","), Public_Function.GetValue(dt.Rows[num13]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num13]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num13]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num13]["Check_ShomareHesab"].ToString())), ",3,"), dt.Rows[num13]["PardakhtCheck_ID"]), ","), dt.Rows[num13]["checkbarg_ID"]), ",@parent_id);")));
																				flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num13]["PardakhtCheck_ID"]), Tarikh);
																				if (flag4)
																				{
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num13]["PardakhtCheck_ID"]), ";")));
																				}
																			}
																		}
																		else
																		{
																			flag4 = (dt.Rows[num13]["checkbarg_ID"] == DBNull.Value);
																			if (flag4)
																			{
																				string right8 = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
																				{
																					Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", dt.Rows[num13]["pardakhtcheck_ID"])
																				}, null, null, null));
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک دریافتی از  ", dt.Rows[num13]["CheckBank_Name"]), " به شماره "), dt.Rows[num13]["Sh_Check"]), " از "), right8));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dt.Rows[num13]["Moshtari_ID"]), ";")));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=codehesab_mojodi from bank_hesab where id=", dt.Rows[num13]["Moshtari_ID"]), ";")));
																				text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num13]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num13]["SanadBed_ID"]), Sanad.SanadType.@null);
																				text = Conversions.ToString(Operators.ConcatenateObject("وصول چک شماره  ", dt.Rows[num13]["Sh_Check"]));
																				text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num13]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num13]["SanadBes_ID"]), Sanad.SanadType.@null);
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num13]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID="), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num13]["Moshtari_ID"]))), " ,Sandug_ID=NULL"), " ,Moshtari_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num13]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num13]["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dt.Rows[num13]["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num13]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num13]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num13]["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dt.Rows[num13]["Check_ShomareHesab"].ToString())), " ,Check_status=3"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = "), dt.Rows[num13]["PardakhtCheck_ID"]), " Where ID="), dt.Rows[num13]["ID"]), ";")));
																				flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num13]["PardakhtCheck_ID"]), Tarikh);
																				if (flag4)
																				{
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num13]["PardakhtCheck_ID"]), ";")));
																				}
																			}
																			else
																			{
																				string right9 = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
																				{
																					Operators.ConcatenateObject("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name  FROM         DaryaftPardakht INNER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     DaryaftPardakht.ID = ", dt.Rows[num13]["pardakhtcheck_ID"])
																				}, null, null, null));
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("وصول چک پرداختی به شماره ", dt.Rows[num13]["Sh_Check"]), "به سررسید  "), dt.Rows[num13]["Check_Sarresid_Fa"]), " به "), right9));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Mojodi from bank_hesab where id=", dt.Rows[num13]["BankHesab_ID"]), ";")));
																				text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num13]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num13]["SanadBes_ID"]), Sanad.SanadType.@null);
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num13]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID="), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num13]["bankhesab_id"]))), " ,Sandug_ID=NULL"), " ,Moshtari_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num13]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num13]["Sh_Check"].ToString())), " ,[CheckBank_ID] = NULL"), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num13]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num13]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num13]["Check_Sarresid_Fa"].ToString())), " ,Check_status=3"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[CheckBarg_ID]="), dt.Rows[num13]["checkbarg_ID"]), " ,[PardakhtCheck_ID] = "), dt.Rows[num13]["PardakhtCheck_ID"]), " Where ID="), dt.Rows[num13]["ID"]), ";")));
																				flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num13]["PardakhtCheck_ID"]), Tarikh);
																				if (flag4)
																				{
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=3 where id=", dt.Rows[num13]["PardakhtCheck_ID"]), ";")));
																				}
																			}
																		}
																	}
																	num13++;
																	flag4 = (num13 == dt.Rows.Count);
																	if (flag4)
																	{
																		break;
																	}
																}
															}
															else
															{
																flag4 = Operators.ConditionalCompareObjectEqual(left8, 21, false);
																if (flag4)
																{
																	text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID=NULL"), " ,Sandug_ID=NULL"), " ,Moshtari_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,[sanadbed_id]=null "), " ,[sanadbes_id]=null "), " Where ID="), dataRow["ID"]), ";select @parent_id="), dataRow["ID"]), ";")));
																	int num14 = dt.Rows.IndexOf(dataRow) + 1;
																	while (dt.Rows[num14]["Parent_Identity"] != DBNull.Value)
																	{
																		bool flag5 = true;
																		object left13 = dt.Rows[num14]["dpType_ID"];
																		flag4 = Operators.ConditionalCompareObjectEqual(left13, 22, false);
																		if (flag4)
																		{
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @moshtari_hesabid=Codehesab_id from moshtari where id=", dt.Rows[num14]["Moshtari_ID"]), ";")));
																			flag4 = (dt.Rows[num14]["BankHesab_ID"] == DBNull.Value);
																			if (flag4)
																			{
																				flag2 = (dt.Rows[num14]["Moshtari_id2"] != DBNull.Value);
																				if (flag2)
																				{
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_id from moshtari where id=", dt.Rows[num14]["Moshtari_ID2"]), ";")));
																				}
																				else
																				{
																					flag4 = (dt.Rows[num14]["CheckBarg_ID"] != DBNull.Value);
																					if (flag4)
																					{
																						flag5 = false;
																						text2 += " select @althesab_id=NULL;";
																					}
																					else
																					{
																						text2 += "select @althesab_id=1";
																					}
																				}
																			}
																			else
																			{
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @althesab_id=Codehesab_Vusul from bank_hesab where id=", dt.Rows[num14]["BankHesab_ID"]), ";")));
																			}
																			flag4 = (dt.Rows[num14]["ID"] == DBNull.Value);
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگشت چک شماره  ", dt.Rows[num14]["Sh_Check"]), " "), dt.Rows[num14]["checkbank_name"]), " "), dt.Rows[num14]["Check_Shobe"]), " به سررسید  "), dt.Rows[num14]["Check_Sarresid_Fa"]));
																				flag4 = (dataRow["Tozih"] != DBNull.Value);
																				if (flag4)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																				}
																				text2 += this.sanad.InsertStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num14]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																				text2 += "select @sanadbed_id=scope_identity();";
																				flag4 = flag5;
																				if (flag4)
																				{
																					text2 += this.sanad.InsertStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num14]["Mablagh"]), Tarikh, text, Sanad.SanadType.@null);
																					text2 += "select @sanadbes_id=scope_identity();";
																				}
																				else
																				{
																					text2 += "select @sanadbes_id=null;";
																				}
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,checkbarg_id,Parent_ID) VALUES(", dt.Rows[num14]["dptype_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",@sanadbed_id,@sanadbes_id ,"), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num14]["Moshtari_ID"]))), ","), Public_Function.GetValueInt(dt.Rows[num14]["BankHesab_ID"].ToString())), ","), dt.Rows[num14]["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dt.Rows[num14]["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dt.Rows[num14]["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dt.Rows[num14]["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dt.Rows[num14]["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dt.Rows[num14]["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dt.Rows[num14]["Check_ShomareHesab"].ToString())), ",4,"), dt.Rows[num14]["PardakhtCheck_ID"]), ","), Public_Function.GetValueInt(dt.Rows[num14]["checkbarg_id"].ToString())), ",@parent_id);")));
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=4 where id=", dt.Rows[num14]["PardakhtCheck_ID"]), ";")));
																			}
																			else
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگشت چک شماره  ", dt.Rows[num14]["Sh_Check"]), " "), dt.Rows[num14]["checkbank_name"]), " "), dt.Rows[num14]["Check_Shobe"]), " به سررسید  "), dt.Rows[num14]["Check_Sarresid_Fa"]));
																				flag4 = (dataRow["Tozih"] != DBNull.Value);
																				if (flag4)
																				{
																					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																				}
																				text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dt.Rows[num14]["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dt.Rows[num14]["SanadBed_ID"]), Sanad.SanadType.@null);
																				flag4 = flag5;
																				if (flag4)
																				{
																					text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dt.Rows[num14]["Mablagh"]), Tarikh, text, Conversions.ToString(dt.Rows[num14]["SanadBes_ID"]), Sanad.SanadType.@null);
																				}
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dt.Rows[num14]["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dt.Rows[num14]["Moshtari_ID"]))), " ,BankHesab_ID="), Public_Function.GetValueInt(dt.Rows[num14]["BankHesab_ID"].ToString())), " ,Sandug_ID=NULL"), " ,Hazine_ID=Null"), " ,Mablagh="), dt.Rows[num14]["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dt.Rows[num14]["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dt.Rows[num14]["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dt.Rows[num14]["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dt.Rows[num14]["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dt.Rows[num14]["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dt.Rows[num14]["Check_ShomareHesab"].ToString())), " ,Check_status=4"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,checkbarg_id="), Public_Function.GetValueInt(dt.Rows[num14]["checkbarg_id"].ToString())), " ,[PardakhtCheck_ID] = "), dt.Rows[num14]["PardakhtCheck_ID"]), " Where ID="), dt.Rows[num14]["ID"]), ";")));
																				flag4 = !this.Check_SayerAmaliyat(Conversions.ToLong(dt.Rows[num14]["PardakhtCheck_ID"]), Tarikh);
																				if (flag4)
																				{
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=4 where id=", dt.Rows[num14]["PardakhtCheck_ID"]), ";")));
																				}
																			}
																		}
																		num14++;
																		flag4 = (num14 == dt.Rows.Count);
																		if (flag4)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	flag4 = Operators.ConditionalCompareObjectEqual(left8, 29, false);
																	if (flag4)
																	{
																		flag2 = (dataRow["hazine_id"] != DBNull.Value);
																		if (flag2)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت برای پرداخت هزینه ", dataRow["moshtari_name"]));
																		}
																		else
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت از ", dataRow["BankHesab_Name"]));
																			flag4 = (dataRow["tozih"] != DBNull.Value);
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																		}
																		text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																		flag4 = (dataRow["hazine_id"] != DBNull.Value);
																		if (flag4)
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت برای پرداخت هزینه ", dataRow["moshtari_name"]));
																		}
																		else
																		{
																			text = Conversions.ToString(Operators.ConcatenateObject("کارت به کارت به ", dataRow["moshtari_Name"]));
																			flag4 = (dataRow["tozih"] != DBNull.Value);
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																			}
																		}
																		text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																		text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID="), dataRow["bankhesab_id"]), " ,Moshtari_ID="), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), " ,Hazine_ID="), Public_Function.GetValueInt(dataRow["Hazine_ID"].ToString())), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																	}
																	else
																	{
																		flag4 = Operators.ConditionalCompareObjectEqual(left8, 30, false);
																		if (flag4)
																		{
																			flag2 = (dataRow["hazine_id"] != DBNull.Value);
																			if (flag2)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت ", dataRow["moshtari_name"]), " از بانک "), dataRow["bankhesab_name"]));
																				dataRow["moshtari_id"] = DBNull.Value;
																			}
																			else
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت به ", dataRow["moshtari_name"]), " از بانک "), dataRow["bankhesab_name"]));
																			}
																			flag4 = (dataRow["tozih"] != DBNull.Value);
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" بابت ", dataRow["tozih"])));
																			}
																			text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																			flag4 = (dataRow["hazine_id"] != DBNull.Value);
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject("پرداخت ", dataRow["moshtari_name"]));
																				dataRow["moshtari_id"] = DBNull.Value;
																			}
																			else
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject("پرداخت به ", dataRow["moshtari_name"]));
																			}
																			flag4 = (dataRow["tozih"] != DBNull.Value);
																			if (flag4)
																			{
																				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" بابت ", dataRow["tozih"])));
																			}
																			text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																			text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID="), dataRow["bankhesab_id"]), " ,Moshtari_ID="), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), " ,Hazine_id="), Public_Function.GetValueInt(dataRow["hazine_id"].ToString())), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																		}
																		else
																		{
																			flag4 = Operators.ConditionalCompareObjectEqual(left8, 31, false);
																			if (flag4)
																			{
																				text = "انتقال از بانک " + dataRow["bankhesab_name"].ToString();
																				flag4 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																				if (flag4)
																				{
																					text = text + " - " + dataRow["tozih"].ToString();
																				}
																				text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																				text = "انتقال به " + dataRow["moshtari_name"].ToString();
																				flag4 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																				if (flag4)
																				{
																					text = text + " - " + dataRow["tozih"].ToString();
																				}
																				text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID="), dataRow["moshtari_id"]), " ,BankHesab_ID2="), dataRow["BankHesab_ID"]), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = "), Public_Function.GetValue(dataRow["sh_check"].ToString())), " ,[checkbarg_id] = "), Public_Function.GetValueInt(dataRow["checkbarg_id"].ToString())), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																			}
																			else
																			{
																				flag4 = Operators.ConditionalCompareObjectEqual(left8, 32, false);
																				if (flag4)
																				{
																					text = "الباقی فاکتور فروش";
																					text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																					text2 += this.sanad.UpdateStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID=1"), " ,Moshtari_ID="), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																				}
																				else
																				{
																					flag4 = Operators.ConditionalCompareObjectEqual(left8, 37, false);
																					if (flag4)
																					{
																						long num15 = Conversions.ToLong(Public_Function.ExecuteScalar("select mablagh from daryaftpardakht where id=" + Public_Function.GetValue(Conversions.ToString(dataRow["moshtari_id"]))));
																						long num16 = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
																						{
																							Operators.ConcatenateObject("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=37 and sh_fish=" + Public_Function.GetValue(Conversions.ToString(dataRow["moshtari_id"])) + " and id <>", dataRow["ID"])
																						}, null, null, null));
																						flag4 = (num16 < num15);
																						long num17;
																						if (flag4)
																						{
																							num16 = Conversions.ToLong(Operators.AddObject(num16, dataRow["mablagh"]));
																							num17 = num16 - num15;
																						}
																						else
																						{
																							num17 = Conversions.ToLong(dataRow["mablagh"]);
																						}
																						text = "پرداخت اقساط";
																						flag4 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
																						if (flag4)
																						{
																							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																						}
																						flag4 = (num17 > 0L);
																						if (flag4)
																						{
																							flag2 = (dataRow["sanadbed_id"] == DBNull.Value);
																							if (flag2)
																							{
																								text2 += this.sanad.InsertStr("32", Conversions.ToString(num17), Conversions.ToString(0), Tarikh, text, Sanad.SanadType.@null);
																								text2 += "select @sanadbed_id=scope_identity();";
																							}
																							else
																							{
																								text2 += this.sanad.UpdateStr("32", Conversions.ToString(num17), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["sanadbed_id"]), Sanad.SanadType.@null);
																								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("select @sanadbed_id=", dataRow["sanadbed_id"]), ";")));
																							}
																						}
																						else
																						{
																							flag4 = (dataRow["sanadbed_id"] != DBNull.Value);
																							if (flag4)
																							{
																								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id=", dataRow["sanadbed_id"]), ";")));
																							}
																							text2 += "select @sanadbed_id=NULL;";
																						}
																						string right10 = "NULL";
																						flag4 = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id2"], 1, false);
																						if (flag4)
																						{
																							text2 += this.sanad.UpdateStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																							right10 = "1";
																						}
																						else
																						{
																							text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																						}
																						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID= "), right10), " ,BankHesab_ID="), Public_Function.GetValueInt(dataRow["bankhesab_id"].ToString())), " ,sanadbed_id=@sanadbed_id"), " ,Moshtari_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = "), Public_Function.GetValue(dataRow["moshtari_id"].ToString())), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																					}
																					else
																					{
																						flag4 = Operators.ConditionalCompareObjectEqual(left8, 38, false);
																						if (flag4)
																						{
																							text = "دریافت تنخواه";
																							flag4 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																							if (flag4)
																							{
																								text = text + " - " + dataRow["tozih"].ToString();
																							}
																							text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																							text = Conversions.ToString(Operators.ConcatenateObject("پرداخت تنخواه به ", dataRow["moshtari_name"]));
																							flag4 = (Operators.CompareString(dataRow["tozih"].ToString(), string.Empty, false) != 0);
																							if (flag4)
																							{
																								text = text + " - " + dataRow["tozih"].ToString();
																							}
																							string right11 = "NULL";
																							flag4 = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id2"], 1, false);
																							if (flag4)
																							{
																								text2 += this.sanad.UpdateStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																								right11 = "1";
																							}
																							else
																							{
																								text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																							}
																							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Sandug_ID= "), right11), " ,BankHesab_ID="), Public_Function.GetValueInt(dataRow["bankhesab_id"].ToString())), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["moshtari_id"]))), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																						}
																						else
																						{
																							flag4 = Operators.ConditionalCompareObjectEqual(left8, 39, false);
																							if (flag4)
																							{
																								text = Conversions.ToString(Operators.ConcatenateObject("مشتری به مشتری  - ", dataRow["beMoshtari_Name"]));
																								text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																								text = Conversions.ToString(Operators.ConcatenateObject("پرداخت از ", dataRow["Moshtari_Name"]));
																								flag4 = (dataRow["tozih"] != DBNull.Value);
																								if (flag4)
																								{
																									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["tozih"])));
																								}
																								text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(dataRow["Mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,BankHesab_ID=NULL"), " ,Moshtari_ID="), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), " ,Hazine_ID=NULL"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,beMoshtari_ID="), Public_Function.GetValueInt("beMoshtari_ID")), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																							}
																							else
																							{
																								flag4 = Operators.ConditionalCompareObjectEqual(left8, 44, false);
																								if (flag4)
																								{
																									text = " پرداخت حواله ارزی -  نرخ تبدیل " + Public_Function.FormatPrice(Conversions.ToString(dataRow["fishvariz_fa"])) + " ریال ";
																									flag4 = (dataRow["Tozih"] != DBNull.Value);
																									if (flag4)
																									{
																										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																									}
																									text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(Operators.MultiplyObject(dataRow["Mablagh"], dataRow["fishvariz_fa"])), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																									text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" حواله ارزی به ", dataRow["moshtari_Name"]), " به میزان "), Public_Function.FormatPrice(Conversions.ToString(dataRow["mablagh"]))), " دلار "), " -نرخ تبدیل "), Public_Function.FormatPrice(Conversions.ToString(dataRow["fishvariz_fa"]))), " ریال "));
																									flag4 = (dataRow["Tozih"] != DBNull.Value);
																									if (flag4)
																									{
																										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																									}
																									text2 += this.sanad.UpdateStr("@althesab_id", Conversions.ToString(0), Conversions.ToString(Operators.MultiplyObject(dataRow["Mablagh"], dataRow["fishvariz_fa"])), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,bemoshtari_id="), Public_Function.GetValueInt(dataRow["bemoshtari_id"].ToString())), " ,Sandug_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,CheckBank_ID="), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), " ,Sh_Fish="), Public_Function.GetValue(dataRow["Sh_Fish"].ToString())), " ,Fishvariz_fa="), Public_Function.GetValue(dataRow["fishvariz_fa"].ToString())), " ,[Sh_Check] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																								}
																								else
																								{
																									flag4 = Operators.ConditionalCompareObjectEqual(left8, 45, false);
																									if (flag4)
																									{
																										text = "تخفیف ";
																										flag4 = (Operators.CompareString(dataRow["tozih"].ToString(), "", false) != 0);
																										if (flag4)
																										{
																											text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																										}
																										text2 += this.sanad.UpdateStr("@moshtari_hesabid", Conversions.ToString(0), Conversions.ToString(dataRow["mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBed_ID"]), Sanad.SanadType.@null);
																										text = Conversions.ToString(Operators.ConcatenateObject("تخفیف به ", dataRow["moshtari_Name"]));
																										flag4 = (dataRow["Tozih"] != DBNull.Value);
																										if (flag4)
																										{
																											text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" - ", dataRow["Tozih"])));
																										}
																										text2 += this.sanad.UpdateStr("43", Conversions.ToString(dataRow["mablagh"]), Conversions.ToString(0), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
																										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"]))), " ,Sandug_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,CheckBank_ID=NULL"), " ,Check_Shobe=NULL"), " ,Sh_Fish=NULL"), " ,Fishvariz_fa=NULL"), " ,[Sh_Check] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag4 = enumerator is IDisposable;
					if (flag4)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0011B228 File Offset: 0x00119628
		public void delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.DaryaftPardakht Where Id= " + ID);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0011B240 File Offset: 0x00119640
		public void DeleteKeraye(string tarikh)
		{
			string command = string.Concat(new string[]
			{
				"SELECT     Keraye_Pardakht_ID as id FROM Furush_Keraye where Keraye_Pardakht_ID is not null and tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
				"  union all   SELECT     Keraye_Pardakht_ID as id   FROM         Kharid_Keraye where Keraye_Pardakht_ID is not null and tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
				" union all  SELECT     Keraye_Pardakht_ID as id  FROM         ErsalBar_Keraye where Keraye_Pardakht_ID is not null and tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
				" union all  SELECT     Keraye_Pardakht_ID  as id  FROM         Kharid_Sardkhane_Keraye where Keraye_Pardakht_ID is not null and tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
				" union all  SELECT     Keraye_Pardakht_ID as id  FROM         Furush_Sardkhane_Keraye where Keraye_Pardakht_ID is not null and tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh))
			});
			DataTable dataTable = Public_Function.FillData(command);
			bool flag = dataTable.Rows.Count == 0;
			if (flag)
			{
				string command2 = "delete from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id=-2 ";
				Public_Function.ExecuteNonQuery(command2);
			}
			else
			{
				string command3 = string.Concat(new string[]
				{
					"delete from daryaftpardakht where tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
					" and dptype_id=-2 and id not in (",
					Public_Function.GetID(dataTable, "id", ""),
					")"
				});
				Public_Function.ExecuteNonQuery(command3);
			}
		}

		// Token: 0x040000C6 RID: 198
		private Sanad sanad;

		// Token: 0x02000022 RID: 34
		public enum dptype_ID
		{
			// Token: 0x040000C8 RID: 200
			فروش_نقد = -1,
			// Token: 0x040000C9 RID: 201
			پرداخت_کرایه = -2,
			// Token: 0x040000CA RID: 202
			پرداخت_مخارج = -3,
			// Token: 0x040000CB RID: 203
			پرداخت_کرایه_کارت = -4,
			// Token: 0x040000CC RID: 204
			خرید_نقدی = -5
		}

		// Token: 0x02000023 RID: 35
		public enum CodeHesab
		{
			// Token: 0x040000CE RID: 206
			NULL,
			// Token: 0x040000CF RID: 207
			فروش_نقد_حق_العملکاری = 2,
			// Token: 0x040000D0 RID: 208
			فروش_نقد_خرید,
			// Token: 0x040000D1 RID: 209
			فروش_نقد_سردخانه,
			// Token: 0x040000D2 RID: 210
			کرایه_حق_العمل,
			// Token: 0x040000D3 RID: 211
			مخارج_حق_العمل = 8,
			// Token: 0x040000D4 RID: 212
			کرایه_خرید = 6,
			// Token: 0x040000D5 RID: 213
			کرایه_فروش_سردخانه,
			// Token: 0x040000D6 RID: 214
			مخارج_خرید = 9,
			// Token: 0x040000D7 RID: 215
			کرایه_ارسال_بار = 25,
			// Token: 0x040000D8 RID: 216
			مخارج_ارسال_بار
		}
	}
}
