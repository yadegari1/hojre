using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FruitBox.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000058 RID: 88
	internal class AppRun
	{
		// Token: 0x060003BB RID: 955 RVA: 0x0013A964 File Offset: 0x00138D64
		[DebuggerNonUserCode]
		public AppRun()
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0013A970 File Offset: 0x00138D70
		public void mmm()
		{
			bool flag = !File.Exists(Application.StartupPath + "\\fr.snk");
			if (flag)
			{
				this.CheckInstallDate();
			}
			else
			{
				string text = File.ReadAllText(Application.StartupPath + "\\fr.snk");
				fp fp = new fp();
				string right = fp.Value2(fp.Value());
				flag = (Operators.CompareString(text, right, false) != 0);
				if (flag)
				{
					this.CheckInstallDate();
				}
				else
				{
					Public_Function.dict.Add("key", text);
					this.mms();
					this.mms2();
				}
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0013AA0C File Offset: 0x00138E0C
		private bool Check_lic(string tarikh, string[] lic)
		{
			fp fp = new fp();
			checked
			{
				bool result;
				for (int i = 0; i < lic.Length; i++)
				{
					string lic2 = lic[i];
					bool flag = fp.Check_lic(tarikh, lic2);
					if (flag)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0013AA58 File Offset: 0x00138E58
		public void mms()
		{
			fp fp = new fp();
			fp.Check_Rd();
			DateTime dateTime = Conversions.ToDate(Public_Function.ShamsiToMiladi(Public_Function.dict["rd"].Split(new char[]
			{
				':'
			})[0])).AddYears(1);
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
			bool flag = File.Exists(Application.StartupPath + "\\fr3.snk");
			string[] array;
			if (flag)
			{
				array = File.ReadAllLines(Application.StartupPath + "\\fr3.snk");
			}
			bool flag2;
			while (DateAndTime.Now.Subtract(dateTime).Days > 0)
			{
				flag = (array == null || array.Length == 0);
				if (flag)
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
					dateTime = dateTime.AddYears(1);
				}
				else
				{
					flag = (array != null);
					if (flag)
					{
						flag2 = !this.Check_lic(Public_Function.MiladiToShamsi(dateTime), array);
						if (flag2)
						{
							dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
						}
					}
					else
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
					}
					dateTime = dateTime.AddYears(1);
				}
			}
			flag2 = (dictionary.Count > 0);
			if (flag2)
			{
				new Frm_Register2
				{
					lic_dict = dictionary
				}.ShowDialog();
			}
			else
			{
				flag2 = (Math.Abs(DateAndTime.Now.Subtract(dateTime).Days) < 30);
				bool flag3;
				if (flag2)
				{
					flag = (array != null);
					if (flag)
					{
						flag3 = !this.Check_lic(Public_Function.MiladiToShamsi(dateTime), array);
						if (flag3)
						{
							dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
						}
					}
					else
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
					}
				}
				flag3 = (dictionary.Count > 0);
				if (flag3)
				{
					new Frm_Register2
					{
						days = Math.Abs(DateAndTime.Now.Subtract(dateTime).Days),
						lic_dict = dictionary
					}.ShowDialog();
				}
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0013AC70 File Offset: 0x00139070
		public void mms2()
		{
			fp fp = new fp();
			fp.Check_Rd();
			DateTime dateTime = Conversions.ToDate(Public_Function.ExecuteScalar("select top 1 tarikh from furush_hag_detail order by id desc"));
			DateTime dateTime2 = Conversions.ToDate(Public_Function.ExecuteScalar("select top 1 tarikh from kharid_furush order by id desc"));
			DateTime dateTime3 = Conversions.ToDate(Public_Function.ExecuteScalar("select top 1 tarikh from furush_sardkhane_detail order by id desc"));
			bool flag = DateTime.Compare(dateTime, dateTime2) > 0;
			DateTime t;
			if (flag)
			{
				t = dateTime;
			}
			else
			{
				t = dateTime2;
			}
			flag = (DateTime.Compare(t, dateTime3) < 0);
			if (flag)
			{
				t = dateTime3;
			}
			DateTime dateTime4 = Conversions.ToDate(Public_Function.ShamsiToMiladi(Public_Function.dict["rd"].Split(new char[]
			{
				':'
			})[0])).AddYears(1);
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
			flag = File.Exists(Application.StartupPath + "\\fr3.snk");
			string[] array;
			if (flag)
			{
				array = File.ReadAllLines(Application.StartupPath + "\\fr3.snk");
			}
			bool flag2;
			while (t.Subtract(dateTime4).Days > 0)
			{
				flag = (array == null || array.Length == 0);
				if (flag)
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
					dateTime4 = dateTime4.AddYears(1);
				}
				else
				{
					flag = (array != null);
					if (flag)
					{
						flag2 = !this.Check_lic(Public_Function.MiladiToShamsi(dateTime4), array);
						if (flag2)
						{
							dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
						}
					}
					else
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
					}
					dateTime4 = dateTime4.AddYears(1);
				}
			}
			flag2 = (dictionary.Count > 0);
			if (flag2)
			{
				new Frm_Register2
				{
					lic_dict = dictionary
				}.ShowDialog();
			}
			else
			{
				flag2 = (Math.Abs(t.Subtract(dateTime4).Days) < 30);
				bool flag3;
				if (flag2)
				{
					flag = (array != null);
					if (flag)
					{
						flag3 = !this.Check_lic(Public_Function.MiladiToShamsi(dateTime4), array);
						if (flag3)
						{
							dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
						}
					}
					else
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
					}
				}
				flag3 = (dictionary.Count > 0);
				if (flag3)
				{
					new Frm_Register2
					{
						days = Math.Abs(t.Subtract(dateTime4).Days),
						lic_dict = dictionary
					}.ShowDialog();
				}
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0013AEDC File Offset: 0x001392DC
		public void mmm2()
		{
			bool flag = !File.Exists(Application.StartupPath + "\\fr2.snk");
			if (flag)
			{
				this.CheckInstallDate();
			}
			else
			{
				string left = File.ReadAllText(Application.StartupPath + "\\fr2.snk");
				fp fp = new fp();
				string right = fp.Value2(fp.Value());
				flag = (Operators.CompareString(left, right, false) != 0);
				if (flag)
				{
					this.CheckInstallDate();
				}
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0013AF54 File Offset: 0x00139354
		public void CheckInstallDate()
		{
			bool flag = !Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				Public_Function.dict.Add("eval", Conversions.ToString(true));
				flag = Public_Function.dict.ContainsKey("eval");
				if (flag)
				{
					Public_Function.dict["head1"] = "فقط برای آزمایش و تست نرم افزار";
					Public_Function.dict["head2"] = "فقط برای آزمایش و تست نرم افزار";
				}
			}
			setting setting = new setting();
			flag = !Public_Function.dict.ContainsKey("installdate");
			if (flag)
			{
				setting.Update("installdate", DateTime.Now.ToShortDateString());
				Public_Function.dict.Add("installdate", DateTime.Now.ToShortDateString());
			}
			flag = !Public_Function.dict.ContainsKey("owner");
			if (flag)
			{
				Public_Function.dict.Add("owner", "نسخه نمایشی");
				MyProject.Forms.Form_Main.txt_CompanyName.set_Text("نسخه نمایشی");
			}
			else
			{
				Public_Function.dict["owner"] = "نسخه نمایشی";
				MyProject.Forms.Form_Main.txt_CompanyName.set_Text("نسخه نمایشی");
			}
			DateTime value = DateTime.Parse(Public_Function.dict["installdate"]);
			flag = (DateTime.Now.Subtract(value).Days > 30);
			if (flag)
			{
				Frm_Secure frm_Secure = new Frm_Secure();
				frm_Secure.ShowDialog();
			}
		}
	}
}
