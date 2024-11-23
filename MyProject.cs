using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox.My
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("MyTemplate", "8.0.0.0"), HideModuleName, StandardModule]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00150090 File Offset: 0x0014E490
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x001500AC File Offset: 0x0014E4AC
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x001500C8 File Offset: 0x0014E4C8
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x001500E4 File Offset: 0x0014E4E4
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00150100 File Offset: 0x0014E500
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000011 RID: 17 RVA: 0x0015011C File Offset: 0x0014E51C
			// (set) Token: 0x060000C2 RID: 194 RVA: 0x00151CC4 File Offset: 0x001500C4
			public Check_Bank Check_Bank
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Check_Bank = MyProject.MyForms.Create__Instance__<Check_Bank>(this.m_Check_Bank);
					return this.m_Check_Bank;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Check_Bank;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Check_Bank>(ref this.m_Check_Bank);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000012 RID: 18 RVA: 0x00150144 File Offset: 0x0014E544
			// (set) Token: 0x060000C3 RID: 195 RVA: 0x00151D08 File Offset: 0x00150108
			public Check_Sandugh Check_Sandugh
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Check_Sandugh = MyProject.MyForms.Create__Instance__<Check_Sandugh>(this.m_Check_Sandugh);
					return this.m_Check_Sandugh;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Check_Sandugh;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Check_Sandugh>(ref this.m_Check_Sandugh);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000013 RID: 19 RVA: 0x0015016C File Offset: 0x0014E56C
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x00151D4C File Offset: 0x0015014C
			public Form1 Form1
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
					return this.m_Form1;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Form1;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form1>(ref this.m_Form1);
					}
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000014 RID: 20 RVA: 0x00150194 File Offset: 0x0014E594
			// (set) Token: 0x060000C5 RID: 197 RVA: 0x00151D90 File Offset: 0x00150190
			public Form2 Form2
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Form2 = MyProject.MyForms.Create__Instance__<Form2>(this.m_Form2);
					return this.m_Form2;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Form2;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form2>(ref this.m_Form2);
					}
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000015 RID: 21 RVA: 0x001501BC File Offset: 0x0014E5BC
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x00151DD4 File Offset: 0x001501D4
			public Form_Main Form_Main
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Form_Main = MyProject.MyForms.Create__Instance__<Form_Main>(this.m_Form_Main);
					return this.m_Form_Main;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Form_Main;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form_Main>(ref this.m_Form_Main);
					}
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000016 RID: 22 RVA: 0x001501E4 File Offset: 0x0014E5E4
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x00151E18 File Offset: 0x00150218
			public Frm_About Frm_About
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_About = MyProject.MyForms.Create__Instance__<Frm_About>(this.m_Frm_About);
					return this.m_Frm_About;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_About;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_About>(ref this.m_Frm_About);
					}
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000017 RID: 23 RVA: 0x0015020C File Offset: 0x0014E60C
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x00151E5C File Offset: 0x0015025C
			public Frm_Amniat_Setting Frm_Amniat_Setting
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Amniat_Setting = MyProject.MyForms.Create__Instance__<Frm_Amniat_Setting>(this.m_Frm_Amniat_Setting);
					return this.m_Frm_Amniat_Setting;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Amniat_Setting;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Amniat_Setting>(ref this.m_Frm_Amniat_Setting);
					}
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000018 RID: 24 RVA: 0x00150234 File Offset: 0x0014E634
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x00151EA0 File Offset: 0x001502A0
			public Frm_Backup Frm_Backup
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Backup = MyProject.MyForms.Create__Instance__<Frm_Backup>(this.m_Frm_Backup);
					return this.m_Frm_Backup;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Backup;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Backup>(ref this.m_Frm_Backup);
					}
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000019 RID: 25 RVA: 0x0015025C File Offset: 0x0014E65C
			// (set) Token: 0x060000CA RID: 202 RVA: 0x00151EE4 File Offset: 0x001502E4
			public Frm_Bank Frm_Bank
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Bank = MyProject.MyForms.Create__Instance__<Frm_Bank>(this.m_Frm_Bank);
					return this.m_Frm_Bank;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Bank;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Bank>(ref this.m_Frm_Bank);
					}
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600001A RID: 26 RVA: 0x00150284 File Offset: 0x0014E684
			// (set) Token: 0x060000CB RID: 203 RVA: 0x00151F28 File Offset: 0x00150328
			public Frm_Bank_Hesab Frm_Bank_Hesab
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Bank_Hesab = MyProject.MyForms.Create__Instance__<Frm_Bank_Hesab>(this.m_Frm_Bank_Hesab);
					return this.m_Frm_Bank_Hesab;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Bank_Hesab;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Bank_Hesab>(ref this.m_Frm_Bank_Hesab);
					}
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600001B RID: 27 RVA: 0x001502AC File Offset: 0x0014E6AC
			// (set) Token: 0x060000CC RID: 204 RVA: 0x00151F6C File Offset: 0x0015036C
			public Frm_BankReport_Design Frm_BankReport_Design
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_BankReport_Design = MyProject.MyForms.Create__Instance__<Frm_BankReport_Design>(this.m_Frm_BankReport_Design);
					return this.m_Frm_BankReport_Design;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_BankReport_Design;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_BankReport_Design>(ref this.m_Frm_BankReport_Design);
					}
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600001C RID: 28 RVA: 0x001502D4 File Offset: 0x0014E6D4
			// (set) Token: 0x060000CD RID: 205 RVA: 0x00151FB0 File Offset: 0x001503B0
			public Frm_Bargasht_Checkd Frm_Bargasht_Checkd
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Bargasht_Checkd = MyProject.MyForms.Create__Instance__<Frm_Bargasht_Checkd>(this.m_Frm_Bargasht_Checkd);
					return this.m_Frm_Bargasht_Checkd;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Bargasht_Checkd;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Bargasht_Checkd>(ref this.m_Frm_Bargasht_Checkd);
					}
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600001D RID: 29 RVA: 0x001502FC File Offset: 0x0014E6FC
			// (set) Token: 0x060000CE RID: 206 RVA: 0x00151FF4 File Offset: 0x001503F4
			public Frm_Base Frm_Base
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Base = MyProject.MyForms.Create__Instance__<Frm_Base>(this.m_Frm_Base);
					return this.m_Frm_Base;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Base;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Base>(ref this.m_Frm_Base);
					}
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600001E RID: 30 RVA: 0x00150324 File Offset: 0x0014E724
			// (set) Token: 0x060000CF RID: 207 RVA: 0x00152038 File Offset: 0x00150438
			public Frm_BastanSandug Frm_BastanSandug
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_BastanSandug = MyProject.MyForms.Create__Instance__<Frm_BastanSandug>(this.m_Frm_BastanSandug);
					return this.m_Frm_BastanSandug;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_BastanSandug;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_BastanSandug>(ref this.m_Frm_BastanSandug);
					}
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600001F RID: 31 RVA: 0x0015034C File Offset: 0x0014E74C
			// (set) Token: 0x060000D0 RID: 208 RVA: 0x0015207C File Offset: 0x0015047C
			public Frm_Calc Frm_Calc
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Calc = MyProject.MyForms.Create__Instance__<Frm_Calc>(this.m_Frm_Calc);
					return this.m_Frm_Calc;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Calc;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Calc>(ref this.m_Frm_Calc);
					}
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000020 RID: 32 RVA: 0x00150374 File Offset: 0x0014E774
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x001520C0 File Offset: 0x001504C0
			public Frm_Change_Kala_To_Kala Frm_Change_Kala_To_Kala
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Change_Kala_To_Kala = MyProject.MyForms.Create__Instance__<Frm_Change_Kala_To_Kala>(this.m_Frm_Change_Kala_To_Kala);
					return this.m_Frm_Change_Kala_To_Kala;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Change_Kala_To_Kala;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Change_Kala_To_Kala>(ref this.m_Frm_Change_Kala_To_Kala);
					}
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000021 RID: 33 RVA: 0x0015039C File Offset: 0x0014E79C
			// (set) Token: 0x060000D2 RID: 210 RVA: 0x00152104 File Offset: 0x00150504
			public Frm_Change_Kala_To_Kala_Kharid Frm_Change_Kala_To_Kala_Kharid
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Change_Kala_To_Kala_Kharid = MyProject.MyForms.Create__Instance__<Frm_Change_Kala_To_Kala_Kharid>(this.m_Frm_Change_Kala_To_Kala_Kharid);
					return this.m_Frm_Change_Kala_To_Kala_Kharid;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Change_Kala_To_Kala_Kharid;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Change_Kala_To_Kala_Kharid>(ref this.m_Frm_Change_Kala_To_Kala_Kharid);
					}
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000022 RID: 34 RVA: 0x001503C4 File Offset: 0x0014E7C4
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x00152148 File Offset: 0x00150548
			public Frm_ChapSafi Frm_ChapSafi
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_ChapSafi = MyProject.MyForms.Create__Instance__<Frm_ChapSafi>(this.m_Frm_ChapSafi);
					return this.m_Frm_ChapSafi;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_ChapSafi;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_ChapSafi>(ref this.m_Frm_ChapSafi);
					}
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000023 RID: 35 RVA: 0x001503EC File Offset: 0x0014E7EC
			// (set) Token: 0x060000D4 RID: 212 RVA: 0x0015218C File Offset: 0x0015058C
			public Frm_Check_Print Frm_Check_Print
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Check_Print = MyProject.MyForms.Create__Instance__<Frm_Check_Print>(this.m_Frm_Check_Print);
					return this.m_Frm_Check_Print;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Check_Print;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Check_Print>(ref this.m_Frm_Check_Print);
					}
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000024 RID: 36 RVA: 0x00150414 File Offset: 0x0014E814
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x001521D0 File Offset: 0x001505D0
			public Frm_CheckBargasht Frm_CheckBargasht
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_CheckBargasht = MyProject.MyForms.Create__Instance__<Frm_CheckBargasht>(this.m_Frm_CheckBargasht);
					return this.m_Frm_CheckBargasht;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_CheckBargasht;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_CheckBargasht>(ref this.m_Frm_CheckBargasht);
					}
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000025 RID: 37 RVA: 0x0015043C File Offset: 0x0014E83C
			// (set) Token: 0x060000D6 RID: 214 RVA: 0x00152214 File Offset: 0x00150614
			public Frm_CheckNaghd Frm_CheckNaghd
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_CheckNaghd = MyProject.MyForms.Create__Instance__<Frm_CheckNaghd>(this.m_Frm_CheckNaghd);
					return this.m_Frm_CheckNaghd;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_CheckNaghd;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_CheckNaghd>(ref this.m_Frm_CheckNaghd);
					}
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000026 RID: 38 RVA: 0x00150464 File Offset: 0x0014E864
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x00152258 File Offset: 0x00150658
			public Frm_Checksarresid_Daryaft Frm_Checksarresid_Daryaft
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Checksarresid_Daryaft = MyProject.MyForms.Create__Instance__<Frm_Checksarresid_Daryaft>(this.m_Frm_Checksarresid_Daryaft);
					return this.m_Frm_Checksarresid_Daryaft;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Checksarresid_Daryaft;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Checksarresid_Daryaft>(ref this.m_Frm_Checksarresid_Daryaft);
					}
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000027 RID: 39 RVA: 0x0015048C File Offset: 0x0014E88C
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x0015229C File Offset: 0x0015069C
			public Frm_Checksarresid_Pardakht Frm_Checksarresid_Pardakht
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Checksarresid_Pardakht = MyProject.MyForms.Create__Instance__<Frm_Checksarresid_Pardakht>(this.m_Frm_Checksarresid_Pardakht);
					return this.m_Frm_Checksarresid_Pardakht;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Checksarresid_Pardakht;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Checksarresid_Pardakht>(ref this.m_Frm_Checksarresid_Pardakht);
					}
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000028 RID: 40 RVA: 0x001504B4 File Offset: 0x0014E8B4
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x001522E0 File Offset: 0x001506E0
			public Frm_CheckVariz Frm_CheckVariz
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_CheckVariz = MyProject.MyForms.Create__Instance__<Frm_CheckVariz>(this.m_Frm_CheckVariz);
					return this.m_Frm_CheckVariz;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_CheckVariz;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_CheckVariz>(ref this.m_Frm_CheckVariz);
					}
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000029 RID: 41 RVA: 0x001504DC File Offset: 0x0014E8DC
			// (set) Token: 0x060000DA RID: 218 RVA: 0x00152324 File Offset: 0x00150724
			public Frm_CheckVusul Frm_CheckVusul
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_CheckVusul = MyProject.MyForms.Create__Instance__<Frm_CheckVusul>(this.m_Frm_CheckVusul);
					return this.m_Frm_CheckVusul;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_CheckVusul;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_CheckVusul>(ref this.m_Frm_CheckVusul);
					}
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00150504 File Offset: 0x0014E904
			// (set) Token: 0x060000DB RID: 219 RVA: 0x00152368 File Offset: 0x00150768
			public Frm_ClearData Frm_ClearData
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_ClearData = MyProject.MyForms.Create__Instance__<Frm_ClearData>(this.m_Frm_ClearData);
					return this.m_Frm_ClearData;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_ClearData;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_ClearData>(ref this.m_Frm_ClearData);
					}
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600002B RID: 43 RVA: 0x0015052C File Offset: 0x0014E92C
			// (set) Token: 0x060000DC RID: 220 RVA: 0x001523AC File Offset: 0x001507AC
			public Frm_cmd Frm_cmd
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_cmd = MyProject.MyForms.Create__Instance__<Frm_cmd>(this.m_Frm_cmd);
					return this.m_Frm_cmd;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_cmd;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_cmd>(ref this.m_Frm_cmd);
					}
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600002C RID: 44 RVA: 0x00150554 File Offset: 0x0014E954
			// (set) Token: 0x060000DD RID: 221 RVA: 0x001523F0 File Offset: 0x001507F0
			public Frm_Coloring Frm_Coloring
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Coloring = MyProject.MyForms.Create__Instance__<Frm_Coloring>(this.m_Frm_Coloring);
					return this.m_Frm_Coloring;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Coloring;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Coloring>(ref this.m_Frm_Coloring);
					}
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600002D RID: 45 RVA: 0x0015057C File Offset: 0x0014E97C
			// (set) Token: 0x060000DE RID: 222 RVA: 0x00152434 File Offset: 0x00150834
			public Frm_Connect Frm_Connect
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Connect = MyProject.MyForms.Create__Instance__<Frm_Connect>(this.m_Frm_Connect);
					return this.m_Frm_Connect;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Connect;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Connect>(ref this.m_Frm_Connect);
					}
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600002E RID: 46 RVA: 0x001505A4 File Offset: 0x0014E9A4
			// (set) Token: 0x060000DF RID: 223 RVA: 0x00152478 File Offset: 0x00150878
			public Frm_Daramad Frm_Daramad
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Daramad = MyProject.MyForms.Create__Instance__<Frm_Daramad>(this.m_Frm_Daramad);
					return this.m_Frm_Daramad;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Daramad;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Daramad>(ref this.m_Frm_Daramad);
					}
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x0600002F RID: 47 RVA: 0x001505CC File Offset: 0x0014E9CC
			// (set) Token: 0x060000E0 RID: 224 RVA: 0x001524BC File Offset: 0x001508BC
			public Frm_Daramad_avaldore Frm_Daramad_avaldore
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Daramad_avaldore = MyProject.MyForms.Create__Instance__<Frm_Daramad_avaldore>(this.m_Frm_Daramad_avaldore);
					return this.m_Frm_Daramad_avaldore;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Daramad_avaldore;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Daramad_avaldore>(ref this.m_Frm_Daramad_avaldore);
					}
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000030 RID: 48 RVA: 0x001505F4 File Offset: 0x0014E9F4
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x00152500 File Offset: 0x00150900
			public Frm_Daryaft_AzMoshtari Frm_Daryaft_AzMoshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Daryaft_AzMoshtari = MyProject.MyForms.Create__Instance__<Frm_Daryaft_AzMoshtari>(this.m_Frm_Daryaft_AzMoshtari);
					return this.m_Frm_Daryaft_AzMoshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Daryaft_AzMoshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Daryaft_AzMoshtari>(ref this.m_Frm_Daryaft_AzMoshtari);
					}
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000031 RID: 49 RVA: 0x0015061C File Offset: 0x0014EA1C
			// (set) Token: 0x060000E2 RID: 226 RVA: 0x00152544 File Offset: 0x00150944
			public Frm_DaryaftCheck Frm_DaryaftCheck
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_DaryaftCheck = MyProject.MyForms.Create__Instance__<Frm_DaryaftCheck>(this.m_Frm_DaryaftCheck);
					return this.m_Frm_DaryaftCheck;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_DaryaftCheck;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_DaryaftCheck>(ref this.m_Frm_DaryaftCheck);
					}
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00150644 File Offset: 0x0014EA44
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x00152588 File Offset: 0x00150988
			public Frm_DaryaftCheck_Avaldore Frm_DaryaftCheck_Avaldore
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_DaryaftCheck_Avaldore = MyProject.MyForms.Create__Instance__<Frm_DaryaftCheck_Avaldore>(this.m_Frm_DaryaftCheck_Avaldore);
					return this.m_Frm_DaryaftCheck_Avaldore;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_DaryaftCheck_Avaldore;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_DaryaftCheck_Avaldore>(ref this.m_Frm_DaryaftCheck_Avaldore);
					}
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000033 RID: 51 RVA: 0x0015066C File Offset: 0x0014EA6C
			// (set) Token: 0x060000E4 RID: 228 RVA: 0x001525CC File Offset: 0x001509CC
			public Frm_DaryaftCheck_naghd Frm_DaryaftCheck_naghd
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_DaryaftCheck_naghd = MyProject.MyForms.Create__Instance__<Frm_DaryaftCheck_naghd>(this.m_Frm_DaryaftCheck_naghd);
					return this.m_Frm_DaryaftCheck_naghd;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_DaryaftCheck_naghd;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_DaryaftCheck_naghd>(ref this.m_Frm_DaryaftCheck_naghd);
					}
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000034 RID: 52 RVA: 0x00150694 File Offset: 0x0014EA94
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x00152610 File Offset: 0x00150A10
			public Frm_DaryaftPardakht Frm_DaryaftPardakht
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_DaryaftPardakht = MyProject.MyForms.Create__Instance__<Frm_DaryaftPardakht>(this.m_Frm_DaryaftPardakht);
					return this.m_Frm_DaryaftPardakht;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_DaryaftPardakht;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_DaryaftPardakht>(ref this.m_Frm_DaryaftPardakht);
					}
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000035 RID: 53 RVA: 0x001506BC File Offset: 0x0014EABC
			// (set) Token: 0x060000E6 RID: 230 RVA: 0x00152654 File Offset: 0x00150A54
			public Frm_DasteCheck Frm_DasteCheck
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_DasteCheck = MyProject.MyForms.Create__Instance__<Frm_DasteCheck>(this.m_Frm_DasteCheck);
					return this.m_Frm_DasteCheck;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_DasteCheck;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_DasteCheck>(ref this.m_Frm_DasteCheck);
					}
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000036 RID: 54 RVA: 0x001506E4 File Offset: 0x0014EAE4
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x00152698 File Offset: 0x00150A98
			public Frm_Delete_SalMali Frm_Delete_SalMali
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Delete_SalMali = MyProject.MyForms.Create__Instance__<Frm_Delete_SalMali>(this.m_Frm_Delete_SalMali);
					return this.m_Frm_Delete_SalMali;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Delete_SalMali;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Delete_SalMali>(ref this.m_Frm_Delete_SalMali);
					}
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000037 RID: 55 RVA: 0x0015070C File Offset: 0x0014EB0C
			// (set) Token: 0x060000E8 RID: 232 RVA: 0x001526DC File Offset: 0x00150ADC
			public Frm_DeleteCheck_Opr Frm_DeleteCheck_Opr
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_DeleteCheck_Opr = MyProject.MyForms.Create__Instance__<Frm_DeleteCheck_Opr>(this.m_Frm_DeleteCheck_Opr);
					return this.m_Frm_DeleteCheck_Opr;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_DeleteCheck_Opr;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_DeleteCheck_Opr>(ref this.m_Frm_DeleteCheck_Opr);
					}
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000038 RID: 56 RVA: 0x00150734 File Offset: 0x0014EB34
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x00152720 File Offset: 0x00150B20
			public Frm_DeleteDaryaftPardakht Frm_DeleteDaryaftPardakht
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_DeleteDaryaftPardakht = MyProject.MyForms.Create__Instance__<Frm_DeleteDaryaftPardakht>(this.m_Frm_DeleteDaryaftPardakht);
					return this.m_Frm_DeleteDaryaftPardakht;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_DeleteDaryaftPardakht;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_DeleteDaryaftPardakht>(ref this.m_Frm_DeleteDaryaftPardakht);
					}
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000039 RID: 57 RVA: 0x0015075C File Offset: 0x0014EB5C
			// (set) Token: 0x060000EA RID: 234 RVA: 0x00152764 File Offset: 0x00150B64
			public Frm_EbtalCheck Frm_EbtalCheck
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_EbtalCheck = MyProject.MyForms.Create__Instance__<Frm_EbtalCheck>(this.m_Frm_EbtalCheck);
					return this.m_Frm_EbtalCheck;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_EbtalCheck;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_EbtalCheck>(ref this.m_Frm_EbtalCheck);
					}
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00150784 File Offset: 0x0014EB84
			// (set) Token: 0x060000EB RID: 235 RVA: 0x001527A8 File Offset: 0x00150BA8
			public Frm_EditUser Frm_EditUser
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_EditUser = MyProject.MyForms.Create__Instance__<Frm_EditUser>(this.m_Frm_EditUser);
					return this.m_Frm_EditUser;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_EditUser;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_EditUser>(ref this.m_Frm_EditUser);
					}
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x0600003B RID: 59 RVA: 0x001507AC File Offset: 0x0014EBAC
			// (set) Token: 0x060000EC RID: 236 RVA: 0x001527EC File Offset: 0x00150BEC
			public Frm_Error Frm_Error
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Error = MyProject.MyForms.Create__Instance__<Frm_Error>(this.m_Frm_Error);
					return this.m_Frm_Error;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Error;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Error>(ref this.m_Frm_Error);
					}
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600003C RID: 60 RVA: 0x001507D4 File Offset: 0x0014EBD4
			// (set) Token: 0x060000ED RID: 237 RVA: 0x00152830 File Offset: 0x00150C30
			public Frm_Ersal_Bar Frm_Ersal_Bar
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Ersal_Bar = MyProject.MyForms.Create__Instance__<Frm_Ersal_Bar>(this.m_Frm_Ersal_Bar);
					return this.m_Frm_Ersal_Bar;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Ersal_Bar;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Ersal_Bar>(ref this.m_Frm_Ersal_Bar);
					}
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600003D RID: 61 RVA: 0x001507FC File Offset: 0x0014EBFC
			// (set) Token: 0x060000EE RID: 238 RVA: 0x00152874 File Offset: 0x00150C74
			public Frm_Extra_Setting Frm_Extra_Setting
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Extra_Setting = MyProject.MyForms.Create__Instance__<Frm_Extra_Setting>(this.m_Frm_Extra_Setting);
					return this.m_Frm_Extra_Setting;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Extra_Setting;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Extra_Setting>(ref this.m_Frm_Extra_Setting);
					}
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600003E RID: 62 RVA: 0x00150824 File Offset: 0x0014EC24
			// (set) Token: 0x060000EF RID: 239 RVA: 0x001528B8 File Offset: 0x00150CB8
			public Frm_FoctorFurush Frm_FoctorFurush
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_FoctorFurush = MyProject.MyForms.Create__Instance__<Frm_FoctorFurush>(this.m_Frm_FoctorFurush);
					return this.m_Frm_FoctorFurush;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_FoctorFurush;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_FoctorFurush>(ref this.m_Frm_FoctorFurush);
					}
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x0600003F RID: 63 RVA: 0x0015084C File Offset: 0x0014EC4C
			// (set) Token: 0x060000F0 RID: 240 RVA: 0x001528FC File Offset: 0x00150CFC
			public frm_Frush_hag frm_Frush_hag
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frm_Frush_hag = MyProject.MyForms.Create__Instance__<frm_Frush_hag>(this.m_frm_Frush_hag);
					return this.m_frm_Frush_hag;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frm_Frush_hag;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frm_Frush_hag>(ref this.m_frm_Frush_hag);
					}
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000040 RID: 64 RVA: 0x00150874 File Offset: 0x0014EC74
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x00152940 File Offset: 0x00150D40
			public Frm_Frush_Sardkhane Frm_Frush_Sardkhane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Frush_Sardkhane = MyProject.MyForms.Create__Instance__<Frm_Frush_Sardkhane>(this.m_Frm_Frush_Sardkhane);
					return this.m_Frm_Frush_Sardkhane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Frush_Sardkhane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Frush_Sardkhane>(ref this.m_Frm_Frush_Sardkhane);
					}
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000041 RID: 65 RVA: 0x0015089C File Offset: 0x0014EC9C
			// (set) Token: 0x060000F2 RID: 242 RVA: 0x00152984 File Offset: 0x00150D84
			public Frm_Furush_Keraye Frm_Furush_Keraye
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Furush_Keraye = MyProject.MyForms.Create__Instance__<Frm_Furush_Keraye>(this.m_Frm_Furush_Keraye);
					return this.m_Frm_Furush_Keraye;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Furush_Keraye;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Furush_Keraye>(ref this.m_Frm_Furush_Keraye);
					}
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000042 RID: 66 RVA: 0x001508C4 File Offset: 0x0014ECC4
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x001529C8 File Offset: 0x00150DC8
			public Frm_Furush_Nesie Frm_Furush_Nesie
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Furush_Nesie = MyProject.MyForms.Create__Instance__<Frm_Furush_Nesie>(this.m_Frm_Furush_Nesie);
					return this.m_Frm_Furush_Nesie;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Furush_Nesie;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Furush_Nesie>(ref this.m_Frm_Furush_Nesie);
					}
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000043 RID: 67 RVA: 0x001508EC File Offset: 0x0014ECEC
			// (set) Token: 0x060000F4 RID: 244 RVA: 0x00152A0C File Offset: 0x00150E0C
			public Frm_Furush_Sardkhane_Keraye Frm_Furush_Sardkhane_Keraye
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Furush_Sardkhane_Keraye = MyProject.MyForms.Create__Instance__<Frm_Furush_Sardkhane_Keraye>(this.m_Frm_Furush_Sardkhane_Keraye);
					return this.m_Frm_Furush_Sardkhane_Keraye;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Furush_Sardkhane_Keraye;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Furush_Sardkhane_Keraye>(ref this.m_Frm_Furush_Sardkhane_Keraye);
					}
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00150914 File Offset: 0x0014ED14
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x00152A50 File Offset: 0x00150E50
			public Frm_FurushRuzane Frm_FurushRuzane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_FurushRuzane = MyProject.MyForms.Create__Instance__<Frm_FurushRuzane>(this.m_Frm_FurushRuzane);
					return this.m_Frm_FurushRuzane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_FurushRuzane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_FurushRuzane>(ref this.m_Frm_FurushRuzane);
					}
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000045 RID: 69 RVA: 0x0015093C File Offset: 0x0014ED3C
			// (set) Token: 0x060000F6 RID: 246 RVA: 0x00152A94 File Offset: 0x00150E94
			public Frm_Grouh_Moshtari Frm_Grouh_Moshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Grouh_Moshtari = MyProject.MyForms.Create__Instance__<Frm_Grouh_Moshtari>(this.m_Frm_Grouh_Moshtari);
					return this.m_Frm_Grouh_Moshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Grouh_Moshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Grouh_Moshtari>(ref this.m_Frm_Grouh_Moshtari);
					}
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00150964 File Offset: 0x0014ED64
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x00152AD8 File Offset: 0x00150ED8
			public Frm_Grouh_Moshtari2 Frm_Grouh_Moshtari2
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Grouh_Moshtari2 = MyProject.MyForms.Create__Instance__<Frm_Grouh_Moshtari2>(this.m_Frm_Grouh_Moshtari2);
					return this.m_Frm_Grouh_Moshtari2;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Grouh_Moshtari2;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Grouh_Moshtari2>(ref this.m_Frm_Grouh_Moshtari2);
					}
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000047 RID: 71 RVA: 0x0015098C File Offset: 0x0014ED8C
			// (set) Token: 0x060000F8 RID: 248 RVA: 0x00152B1C File Offset: 0x00150F1C
			public Frm_Hazine Frm_Hazine
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Hazine = MyProject.MyForms.Create__Instance__<Frm_Hazine>(this.m_Frm_Hazine);
					return this.m_Frm_Hazine;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Hazine;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Hazine>(ref this.m_Frm_Hazine);
					}
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000048 RID: 72 RVA: 0x001509B4 File Offset: 0x0014EDB4
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x00152B60 File Offset: 0x00150F60
			public Frm_Hazine_Kharid Frm_Hazine_Kharid
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Hazine_Kharid = MyProject.MyForms.Create__Instance__<Frm_Hazine_Kharid>(this.m_Frm_Hazine_Kharid);
					return this.m_Frm_Hazine_Kharid;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Hazine_Kharid;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Hazine_Kharid>(ref this.m_Frm_Hazine_Kharid);
					}
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000049 RID: 73 RVA: 0x001509DC File Offset: 0x0014EDDC
			// (set) Token: 0x060000FA RID: 250 RVA: 0x00152BA4 File Offset: 0x00150FA4
			public Frm_Help Frm_Help
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Help = MyProject.MyForms.Create__Instance__<Frm_Help>(this.m_Frm_Help);
					return this.m_Frm_Help;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Help;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Help>(ref this.m_Frm_Help);
					}
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600004A RID: 74 RVA: 0x00150A04 File Offset: 0x0014EE04
			// (set) Token: 0x060000FB RID: 251 RVA: 0x00152BE8 File Offset: 0x00150FE8
			public frm_historyLog frm_historyLog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frm_historyLog = MyProject.MyForms.Create__Instance__<frm_historyLog>(this.m_frm_historyLog);
					return this.m_frm_historyLog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frm_historyLog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frm_historyLog>(ref this.m_frm_historyLog);
					}
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600004B RID: 75 RVA: 0x00150A2C File Offset: 0x0014EE2C
			// (set) Token: 0x060000FC RID: 252 RVA: 0x00152C2C File Offset: 0x0015102C
			public Frm_Kala Frm_Kala
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Kala = MyProject.MyForms.Create__Instance__<Frm_Kala>(this.m_Frm_Kala);
					return this.m_Frm_Kala;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Kala;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Kala>(ref this.m_Frm_Kala);
					}
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600004C RID: 76 RVA: 0x00150A54 File Offset: 0x0014EE54
			// (set) Token: 0x060000FD RID: 253 RVA: 0x00152C70 File Offset: 0x00151070
			public Frm_Karmozd Frm_Karmozd
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Karmozd = MyProject.MyForms.Create__Instance__<Frm_Karmozd>(this.m_Frm_Karmozd);
					return this.m_Frm_Karmozd;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Karmozd;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Karmozd>(ref this.m_Frm_Karmozd);
					}
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00150A7C File Offset: 0x0014EE7C
			// (set) Token: 0x060000FE RID: 254 RVA: 0x00152CB4 File Offset: 0x001510B4
			public Frm_Kharid_Furush Frm_Kharid_Furush
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Kharid_Furush = MyProject.MyForms.Create__Instance__<Frm_Kharid_Furush>(this.m_Frm_Kharid_Furush);
					return this.m_Frm_Kharid_Furush;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Kharid_Furush;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Kharid_Furush>(ref this.m_Frm_Kharid_Furush);
					}
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00150AA4 File Offset: 0x0014EEA4
			// (set) Token: 0x060000FF RID: 255 RVA: 0x00152CF8 File Offset: 0x001510F8
			public Frm_Kharid_Keraye Frm_Kharid_Keraye
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Kharid_Keraye = MyProject.MyForms.Create__Instance__<Frm_Kharid_Keraye>(this.m_Frm_Kharid_Keraye);
					return this.m_Frm_Kharid_Keraye;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Kharid_Keraye;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Kharid_Keraye>(ref this.m_Frm_Kharid_Keraye);
					}
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x0600004F RID: 79 RVA: 0x00150ACC File Offset: 0x0014EECC
			// (set) Token: 0x06000100 RID: 256 RVA: 0x00152D3C File Offset: 0x0015113C
			public Frm_Kharid_Sardkhane_Keraye Frm_Kharid_Sardkhane_Keraye
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Kharid_Sardkhane_Keraye = MyProject.MyForms.Create__Instance__<Frm_Kharid_Sardkhane_Keraye>(this.m_Frm_Kharid_Sardkhane_Keraye);
					return this.m_Frm_Kharid_Sardkhane_Keraye;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Kharid_Sardkhane_Keraye;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Kharid_Sardkhane_Keraye>(ref this.m_Frm_Kharid_Sardkhane_Keraye);
					}
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00150AF4 File Offset: 0x0014EEF4
			// (set) Token: 0x06000101 RID: 257 RVA: 0x00152D80 File Offset: 0x00151180
			public Frm_Kharid_Sardkhane_Keraye2 Frm_Kharid_Sardkhane_Keraye2
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Kharid_Sardkhane_Keraye2 = MyProject.MyForms.Create__Instance__<Frm_Kharid_Sardkhane_Keraye2>(this.m_Frm_Kharid_Sardkhane_Keraye2);
					return this.m_Frm_Kharid_Sardkhane_Keraye2;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Kharid_Sardkhane_Keraye2;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Kharid_Sardkhane_Keraye2>(ref this.m_Frm_Kharid_Sardkhane_Keraye2);
					}
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000051 RID: 81 RVA: 0x00150B1C File Offset: 0x0014EF1C
			// (set) Token: 0x06000102 RID: 258 RVA: 0x00152DC4 File Offset: 0x001511C4
			public Frm_KharidSardkhane Frm_KharidSardkhane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_KharidSardkhane = MyProject.MyForms.Create__Instance__<Frm_KharidSardkhane>(this.m_Frm_KharidSardkhane);
					return this.m_Frm_KharidSardkhane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_KharidSardkhane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_KharidSardkhane>(ref this.m_Frm_KharidSardkhane);
					}
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000052 RID: 82 RVA: 0x00150B44 File Offset: 0x0014EF44
			// (set) Token: 0x06000103 RID: 259 RVA: 0x00152E08 File Offset: 0x00151208
			public Frm_KhordeFurushi Frm_KhordeFurushi
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_KhordeFurushi = MyProject.MyForms.Create__Instance__<Frm_KhordeFurushi>(this.m_Frm_KhordeFurushi);
					return this.m_Frm_KhordeFurushi;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_KhordeFurushi;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_KhordeFurushi>(ref this.m_Frm_KhordeFurushi);
					}
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000053 RID: 83 RVA: 0x00150B6C File Offset: 0x0014EF6C
			// (set) Token: 0x06000104 RID: 260 RVA: 0x00152E4C File Offset: 0x0015124C
			public Frm_KhordeFurushi_Keraye Frm_KhordeFurushi_Keraye
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_KhordeFurushi_Keraye = MyProject.MyForms.Create__Instance__<Frm_KhordeFurushi_Keraye>(this.m_Frm_KhordeFurushi_Keraye);
					return this.m_Frm_KhordeFurushi_Keraye;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_KhordeFurushi_Keraye;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_KhordeFurushi_Keraye>(ref this.m_Frm_KhordeFurushi_Keraye);
					}
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000054 RID: 84 RVA: 0x00150B94 File Offset: 0x0014EF94
			// (set) Token: 0x06000105 RID: 261 RVA: 0x00152E90 File Offset: 0x00151290
			public Frm_Kiosk_Furush Frm_Kiosk_Furush
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Kiosk_Furush = MyProject.MyForms.Create__Instance__<Frm_Kiosk_Furush>(this.m_Frm_Kiosk_Furush);
					return this.m_Frm_Kiosk_Furush;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Kiosk_Furush;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Kiosk_Furush>(ref this.m_Frm_Kiosk_Furush);
					}
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000055 RID: 85 RVA: 0x00150BBC File Offset: 0x0014EFBC
			// (set) Token: 0x06000106 RID: 262 RVA: 0x00152ED4 File Offset: 0x001512D4
			public Frm_list_BankHesab Frm_list_BankHesab
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_list_BankHesab = MyProject.MyForms.Create__Instance__<Frm_list_BankHesab>(this.m_Frm_list_BankHesab);
					return this.m_Frm_list_BankHesab;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_list_BankHesab;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_list_BankHesab>(ref this.m_Frm_list_BankHesab);
					}
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000056 RID: 86 RVA: 0x00150BE4 File Offset: 0x0014EFE4
			// (set) Token: 0x06000107 RID: 263 RVA: 0x00152F18 File Offset: 0x00151318
			public Frm_List_EbtalCheck Frm_List_EbtalCheck
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_List_EbtalCheck = MyProject.MyForms.Create__Instance__<Frm_List_EbtalCheck>(this.m_Frm_List_EbtalCheck);
					return this.m_Frm_List_EbtalCheck;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_List_EbtalCheck;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_List_EbtalCheck>(ref this.m_Frm_List_EbtalCheck);
					}
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000057 RID: 87 RVA: 0x00150C0C File Offset: 0x0014F00C
			// (set) Token: 0x06000108 RID: 264 RVA: 0x00152F5C File Offset: 0x0015135C
			public Frm_list_Moshtari Frm_list_Moshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_list_Moshtari = MyProject.MyForms.Create__Instance__<Frm_list_Moshtari>(this.m_Frm_list_Moshtari);
					return this.m_Frm_list_Moshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_list_Moshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_list_Moshtari>(ref this.m_Frm_list_Moshtari);
					}
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000058 RID: 88 RVA: 0x00150C34 File Offset: 0x0014F034
			// (set) Token: 0x06000109 RID: 265 RVA: 0x00152FA0 File Offset: 0x001513A0
			public Frm_List_Safi Frm_List_Safi
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_List_Safi = MyProject.MyForms.Create__Instance__<Frm_List_Safi>(this.m_Frm_List_Safi);
					return this.m_Frm_List_Safi;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_List_Safi;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_List_Safi>(ref this.m_Frm_List_Safi);
					}
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000059 RID: 89 RVA: 0x00150C5C File Offset: 0x0014F05C
			// (set) Token: 0x0600010A RID: 266 RVA: 0x00152FE4 File Offset: 0x001513E4
			public Frm_MainSortMenu Frm_MainSortMenu
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_MainSortMenu = MyProject.MyForms.Create__Instance__<Frm_MainSortMenu>(this.m_Frm_MainSortMenu);
					return this.m_Frm_MainSortMenu;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_MainSortMenu;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_MainSortMenu>(ref this.m_Frm_MainSortMenu);
					}
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600005A RID: 90 RVA: 0x00150C84 File Offset: 0x0014F084
			// (set) Token: 0x0600010B RID: 267 RVA: 0x00153028 File Offset: 0x00151428
			public Frm_Menu Frm_Menu
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Menu = MyProject.MyForms.Create__Instance__<Frm_Menu>(this.m_Frm_Menu);
					return this.m_Frm_Menu;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Menu;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Menu>(ref this.m_Frm_Menu);
					}
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600005B RID: 91 RVA: 0x00150CAC File Offset: 0x0014F0AC
			// (set) Token: 0x0600010C RID: 268 RVA: 0x0015306C File Offset: 0x0015146C
			public Frm_MessageBox Frm_MessageBox
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_MessageBox = MyProject.MyForms.Create__Instance__<Frm_MessageBox>(this.m_Frm_MessageBox);
					return this.m_Frm_MessageBox;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_MessageBox;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_MessageBox>(ref this.m_Frm_MessageBox);
					}
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600005C RID: 92 RVA: 0x00150CD4 File Offset: 0x0014F0D4
			// (set) Token: 0x0600010D RID: 269 RVA: 0x001530B0 File Offset: 0x001514B0
			public Frm_Moshtari Frm_Moshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Moshtari = MyProject.MyForms.Create__Instance__<Frm_Moshtari>(this.m_Frm_Moshtari);
					return this.m_Frm_Moshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Moshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Moshtari>(ref this.m_Frm_Moshtari);
					}
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600005D RID: 93 RVA: 0x00150CFC File Offset: 0x0014F0FC
			// (set) Token: 0x0600010E RID: 270 RVA: 0x001530F4 File Offset: 0x001514F4
			public Frm_Moshtari_Hesab Frm_Moshtari_Hesab
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Moshtari_Hesab = MyProject.MyForms.Create__Instance__<Frm_Moshtari_Hesab>(this.m_Frm_Moshtari_Hesab);
					return this.m_Frm_Moshtari_Hesab;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Moshtari_Hesab;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Moshtari_Hesab>(ref this.m_Frm_Moshtari_Hesab);
					}
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600005E RID: 94 RVA: 0x00150D24 File Offset: 0x0014F124
			// (set) Token: 0x0600010F RID: 271 RVA: 0x00153138 File Offset: 0x00151538
			public Frm_Moshtari_kala Frm_Moshtari_kala
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Moshtari_kala = MyProject.MyForms.Create__Instance__<Frm_Moshtari_kala>(this.m_Frm_Moshtari_kala);
					return this.m_Frm_Moshtari_kala;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Moshtari_kala;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Moshtari_kala>(ref this.m_Frm_Moshtari_kala);
					}
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600005F RID: 95 RVA: 0x00150D4C File Offset: 0x0014F14C
			// (set) Token: 0x06000110 RID: 272 RVA: 0x0015317C File Offset: 0x0015157C
			public Frm_Moshtarian Frm_Moshtarian
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Moshtarian = MyProject.MyForms.Create__Instance__<Frm_Moshtarian>(this.m_Frm_Moshtarian);
					return this.m_Frm_Moshtarian;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Moshtarian;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Moshtarian>(ref this.m_Frm_Moshtarian);
					}
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00150D74 File Offset: 0x0014F174
			// (set) Token: 0x06000111 RID: 273 RVA: 0x001531C0 File Offset: 0x001515C0
			public Frm_MoshtariSearch Frm_MoshtariSearch
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_MoshtariSearch = MyProject.MyForms.Create__Instance__<Frm_MoshtariSearch>(this.m_Frm_MoshtariSearch);
					return this.m_Frm_MoshtariSearch;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_MoshtariSearch;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_MoshtariSearch>(ref this.m_Frm_MoshtariSearch);
					}
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00150D9C File Offset: 0x0014F19C
			// (set) Token: 0x06000112 RID: 274 RVA: 0x00153204 File Offset: 0x00151604
			public Frm_NewVersion Frm_NewVersion
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_NewVersion = MyProject.MyForms.Create__Instance__<Frm_NewVersion>(this.m_Frm_NewVersion);
					return this.m_Frm_NewVersion;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_NewVersion;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_NewVersion>(ref this.m_Frm_NewVersion);
					}
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000062 RID: 98 RVA: 0x00150DC4 File Offset: 0x0014F1C4
			// (set) Token: 0x06000113 RID: 275 RVA: 0x00153248 File Offset: 0x00151648
			public Frm_Note Frm_Note
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Note = MyProject.MyForms.Create__Instance__<Frm_Note>(this.m_Frm_Note);
					return this.m_Frm_Note;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Note;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Note>(ref this.m_Frm_Note);
					}
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00150DEC File Offset: 0x0014F1EC
			// (set) Token: 0x06000114 RID: 276 RVA: 0x0015328C File Offset: 0x0015168C
			public Frm_Pardakht Frm_Pardakht
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Pardakht = MyProject.MyForms.Create__Instance__<Frm_Pardakht>(this.m_Frm_Pardakht);
					return this.m_Frm_Pardakht;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Pardakht;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Pardakht>(ref this.m_Frm_Pardakht);
					}
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00150E14 File Offset: 0x0014F214
			// (set) Token: 0x06000115 RID: 277 RVA: 0x001532D0 File Offset: 0x001516D0
			public Frm_Pardakht_BeMoshtari Frm_Pardakht_BeMoshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Pardakht_BeMoshtari = MyProject.MyForms.Create__Instance__<Frm_Pardakht_BeMoshtari>(this.m_Frm_Pardakht_BeMoshtari);
					return this.m_Frm_Pardakht_BeMoshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Pardakht_BeMoshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Pardakht_BeMoshtari>(ref this.m_Frm_Pardakht_BeMoshtari);
					}
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000065 RID: 101 RVA: 0x00150E3C File Offset: 0x0014F23C
			// (set) Token: 0x06000116 RID: 278 RVA: 0x00153314 File Offset: 0x00151714
			public Frm_PardakhtCheck Frm_PardakhtCheck
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_PardakhtCheck = MyProject.MyForms.Create__Instance__<Frm_PardakhtCheck>(this.m_Frm_PardakhtCheck);
					return this.m_Frm_PardakhtCheck;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_PardakhtCheck;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_PardakhtCheck>(ref this.m_Frm_PardakhtCheck);
					}
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00150E64 File Offset: 0x0014F264
			// (set) Token: 0x06000117 RID: 279 RVA: 0x00153358 File Offset: 0x00151758
			public Frm_PardakhtCheck_Avaldore Frm_PardakhtCheck_Avaldore
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_PardakhtCheck_Avaldore = MyProject.MyForms.Create__Instance__<Frm_PardakhtCheck_Avaldore>(this.m_Frm_PardakhtCheck_Avaldore);
					return this.m_Frm_PardakhtCheck_Avaldore;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_PardakhtCheck_Avaldore;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_PardakhtCheck_Avaldore>(ref this.m_Frm_PardakhtCheck_Avaldore);
					}
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000067 RID: 103 RVA: 0x00150E8C File Offset: 0x0014F28C
			// (set) Token: 0x06000118 RID: 280 RVA: 0x0015339C File Offset: 0x0015179C
			public Frm_PardakhtKonande Frm_PardakhtKonande
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_PardakhtKonande = MyProject.MyForms.Create__Instance__<Frm_PardakhtKonande>(this.m_Frm_PardakhtKonande);
					return this.m_Frm_PardakhtKonande;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_PardakhtKonande;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_PardakhtKonande>(ref this.m_Frm_PardakhtKonande);
					}
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00150EB4 File Offset: 0x0014F2B4
			// (set) Token: 0x06000119 RID: 281 RVA: 0x001533E0 File Offset: 0x001517E0
			public Frm_PardakhtMoshtari Frm_PardakhtMoshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_PardakhtMoshtari = MyProject.MyForms.Create__Instance__<Frm_PardakhtMoshtari>(this.m_Frm_PardakhtMoshtari);
					return this.m_Frm_PardakhtMoshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_PardakhtMoshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_PardakhtMoshtari>(ref this.m_Frm_PardakhtMoshtari);
					}
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00150EDC File Offset: 0x0014F2DC
			// (set) Token: 0x0600011A RID: 282 RVA: 0x00153424 File Offset: 0x00151824
			public Frm_Password Frm_Password
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Password = MyProject.MyForms.Create__Instance__<Frm_Password>(this.m_Frm_Password);
					return this.m_Frm_Password;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Password;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Password>(ref this.m_Frm_Password);
					}
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600006A RID: 106 RVA: 0x00150F04 File Offset: 0x0014F304
			// (set) Token: 0x0600011B RID: 283 RVA: 0x00153468 File Offset: 0x00151868
			public Frm_Print_Base Frm_Print_Base
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Print_Base = MyProject.MyForms.Create__Instance__<Frm_Print_Base>(this.m_Frm_Print_Base);
					return this.m_Frm_Print_Base;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Print_Base;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Print_Base>(ref this.m_Frm_Print_Base);
					}
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600006B RID: 107 RVA: 0x00150F2C File Offset: 0x0014F32C
			// (set) Token: 0x0600011C RID: 284 RVA: 0x001534AC File Offset: 0x001518AC
			public Frm_RegHelp Frm_RegHelp
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_RegHelp = MyProject.MyForms.Create__Instance__<Frm_RegHelp>(this.m_Frm_RegHelp);
					return this.m_Frm_RegHelp;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_RegHelp;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_RegHelp>(ref this.m_Frm_RegHelp);
					}
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00150F54 File Offset: 0x0014F354
			// (set) Token: 0x0600011D RID: 285 RVA: 0x001534F0 File Offset: 0x001518F0
			public Frm_Register Frm_Register
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Register = MyProject.MyForms.Create__Instance__<Frm_Register>(this.m_Frm_Register);
					return this.m_Frm_Register;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Register;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Register>(ref this.m_Frm_Register);
					}
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600006D RID: 109 RVA: 0x00150F7C File Offset: 0x0014F37C
			// (set) Token: 0x0600011E RID: 286 RVA: 0x00153534 File Offset: 0x00151934
			public Frm_Register2 Frm_Register2
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Register2 = MyProject.MyForms.Create__Instance__<Frm_Register2>(this.m_Frm_Register2);
					return this.m_Frm_Register2;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Register2;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Register2>(ref this.m_Frm_Register2);
					}
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00150FA4 File Offset: 0x0014F3A4
			// (set) Token: 0x0600011F RID: 287 RVA: 0x00153578 File Offset: 0x00151978
			public Frm_Restore Frm_Restore
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Restore = MyProject.MyForms.Create__Instance__<Frm_Restore>(this.m_Frm_Restore);
					return this.m_Frm_Restore;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Restore;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Restore>(ref this.m_Frm_Restore);
					}
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00150FCC File Offset: 0x0014F3CC
			// (set) Token: 0x06000120 RID: 288 RVA: 0x001535BC File Offset: 0x001519BC
			public Frm_Rizbar Frm_Rizbar
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Rizbar = MyProject.MyForms.Create__Instance__<Frm_Rizbar>(this.m_Frm_Rizbar);
					return this.m_Frm_Rizbar;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Rizbar;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Rizbar>(ref this.m_Frm_Rizbar);
					}
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000070 RID: 112 RVA: 0x00150FF4 File Offset: 0x0014F3F4
			// (set) Token: 0x06000121 RID: 289 RVA: 0x00153600 File Offset: 0x00151A00
			public Frm_Rizbar_Sardkhane Frm_Rizbar_Sardkhane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Rizbar_Sardkhane = MyProject.MyForms.Create__Instance__<Frm_Rizbar_Sardkhane>(this.m_Frm_Rizbar_Sardkhane);
					return this.m_Frm_Rizbar_Sardkhane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Rizbar_Sardkhane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Rizbar_Sardkhane>(ref this.m_Frm_Rizbar_Sardkhane);
					}
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000071 RID: 113 RVA: 0x0015101C File Offset: 0x0014F41C
			// (set) Token: 0x06000122 RID: 290 RVA: 0x00153644 File Offset: 0x00151A44
			public Frm_RizKharid Frm_RizKharid
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_RizKharid = MyProject.MyForms.Create__Instance__<Frm_RizKharid>(this.m_Frm_RizKharid);
					return this.m_Frm_RizKharid;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_RizKharid;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_RizKharid>(ref this.m_Frm_RizKharid);
					}
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00151044 File Offset: 0x0014F444
			// (set) Token: 0x06000123 RID: 291 RVA: 0x00153688 File Offset: 0x00151A88
			public Frm_Rotbe Frm_Rotbe
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Rotbe = MyProject.MyForms.Create__Instance__<Frm_Rotbe>(this.m_Frm_Rotbe);
					return this.m_Frm_Rotbe;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Rotbe;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Rotbe>(ref this.m_Frm_Rotbe);
					}
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000073 RID: 115 RVA: 0x0015106C File Offset: 0x0014F46C
			// (set) Token: 0x06000124 RID: 292 RVA: 0x001536CC File Offset: 0x00151ACC
			public Frm_Rotbe_Detailvb Frm_Rotbe_Detailvb
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Rotbe_Detailvb = MyProject.MyForms.Create__Instance__<Frm_Rotbe_Detailvb>(this.m_Frm_Rotbe_Detailvb);
					return this.m_Frm_Rotbe_Detailvb;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Rotbe_Detailvb;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Rotbe_Detailvb>(ref this.m_Frm_Rotbe_Detailvb);
					}
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00151094 File Offset: 0x0014F494
			// (set) Token: 0x06000125 RID: 293 RVA: 0x00153710 File Offset: 0x00151B10
			public Frm_rpt_bedehkaran Frm_rpt_bedehkaran
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_bedehkaran = MyProject.MyForms.Create__Instance__<Frm_rpt_bedehkaran>(this.m_Frm_rpt_bedehkaran);
					return this.m_Frm_rpt_bedehkaran;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_bedehkaran;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_bedehkaran>(ref this.m_Frm_rpt_bedehkaran);
					}
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000075 RID: 117 RVA: 0x001510BC File Offset: 0x0014F4BC
			// (set) Token: 0x06000126 RID: 294 RVA: 0x00153754 File Offset: 0x00151B54
			public Frm_rpt_bestankaran Frm_rpt_bestankaran
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_bestankaran = MyProject.MyForms.Create__Instance__<Frm_rpt_bestankaran>(this.m_Frm_rpt_bestankaran);
					return this.m_Frm_rpt_bestankaran;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_bestankaran;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_bestankaran>(ref this.m_Frm_rpt_bestankaran);
					}
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000076 RID: 118 RVA: 0x001510E4 File Offset: 0x0014F4E4
			// (set) Token: 0x06000127 RID: 295 RVA: 0x00153798 File Offset: 0x00151B98
			public Frm_rpt_checkbargasht Frm_rpt_checkbargasht
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_checkbargasht = MyProject.MyForms.Create__Instance__<Frm_rpt_checkbargasht>(this.m_Frm_rpt_checkbargasht);
					return this.m_Frm_rpt_checkbargasht;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_checkbargasht;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_checkbargasht>(ref this.m_Frm_rpt_checkbargasht);
					}
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000077 RID: 119 RVA: 0x0015110C File Offset: 0x0014F50C
			// (set) Token: 0x06000128 RID: 296 RVA: 0x001537DC File Offset: 0x00151BDC
			public Frm_rpt_checkdarjaryan Frm_rpt_checkdarjaryan
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_checkdarjaryan = MyProject.MyForms.Create__Instance__<Frm_rpt_checkdarjaryan>(this.m_Frm_rpt_checkdarjaryan);
					return this.m_Frm_rpt_checkdarjaryan;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_checkdarjaryan;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_checkdarjaryan>(ref this.m_Frm_rpt_checkdarjaryan);
					}
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00151134 File Offset: 0x0014F534
			// (set) Token: 0x06000129 RID: 297 RVA: 0x00153820 File Offset: 0x00151C20
			public Frm_rpt_checkDaryafti Frm_rpt_checkDaryafti
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_checkDaryafti = MyProject.MyForms.Create__Instance__<Frm_rpt_checkDaryafti>(this.m_Frm_rpt_checkDaryafti);
					return this.m_Frm_rpt_checkDaryafti;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_checkDaryafti;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_checkDaryafti>(ref this.m_Frm_rpt_checkDaryafti);
					}
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000079 RID: 121 RVA: 0x0015115C File Offset: 0x0014F55C
			// (set) Token: 0x0600012A RID: 298 RVA: 0x00153864 File Offset: 0x00151C64
			public Frm_rpt_checkPardakhtani Frm_rpt_checkPardakhtani
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_checkPardakhtani = MyProject.MyForms.Create__Instance__<Frm_rpt_checkPardakhtani>(this.m_Frm_rpt_checkPardakhtani);
					return this.m_Frm_rpt_checkPardakhtani;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_checkPardakhtani;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_checkPardakhtani>(ref this.m_Frm_rpt_checkPardakhtani);
					}
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x0600007A RID: 122 RVA: 0x00151184 File Offset: 0x0014F584
			// (set) Token: 0x0600012B RID: 299 RVA: 0x001538A8 File Offset: 0x00151CA8
			public Frm_rpt_checksearch Frm_rpt_checksearch
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_checksearch = MyProject.MyForms.Create__Instance__<Frm_rpt_checksearch>(this.m_Frm_rpt_checksearch);
					return this.m_Frm_rpt_checksearch;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_checksearch;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_checksearch>(ref this.m_Frm_rpt_checksearch);
					}
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x0600007B RID: 123 RVA: 0x001511AC File Offset: 0x0014F5AC
			// (set) Token: 0x0600012C RID: 300 RVA: 0x001538EC File Offset: 0x00151CEC
			public Frm_rpt_checksearchMoshtari Frm_rpt_checksearchMoshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_checksearchMoshtari = MyProject.MyForms.Create__Instance__<Frm_rpt_checksearchMoshtari>(this.m_Frm_rpt_checksearchMoshtari);
					return this.m_Frm_rpt_checksearchMoshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_checksearchMoshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_checksearchMoshtari>(ref this.m_Frm_rpt_checksearchMoshtari);
					}
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600007C RID: 124 RVA: 0x001511D4 File Offset: 0x0014F5D4
			// (set) Token: 0x0600012D RID: 301 RVA: 0x00153930 File Offset: 0x00151D30
			public Frm_rpt_checkvusul Frm_rpt_checkvusul
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_checkvusul = MyProject.MyForms.Create__Instance__<Frm_rpt_checkvusul>(this.m_Frm_rpt_checkvusul);
					return this.m_Frm_rpt_checkvusul;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_checkvusul;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_checkvusul>(ref this.m_Frm_rpt_checkvusul);
					}
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600007D RID: 125 RVA: 0x001511FC File Offset: 0x0014F5FC
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00153974 File Offset: 0x00151D74
			public Frm_rpt_dastecheck Frm_rpt_dastecheck
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_dastecheck = MyProject.MyForms.Create__Instance__<Frm_rpt_dastecheck>(this.m_Frm_rpt_dastecheck);
					return this.m_Frm_rpt_dastecheck;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_dastecheck;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_dastecheck>(ref this.m_Frm_rpt_dastecheck);
					}
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00151224 File Offset: 0x0014F624
			// (set) Token: 0x0600012F RID: 303 RVA: 0x001539B8 File Offset: 0x00151DB8
			public frm_rpt_dpNaghd frm_rpt_dpNaghd
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frm_rpt_dpNaghd = MyProject.MyForms.Create__Instance__<frm_rpt_dpNaghd>(this.m_frm_rpt_dpNaghd);
					return this.m_frm_rpt_dpNaghd;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frm_rpt_dpNaghd;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frm_rpt_dpNaghd>(ref this.m_frm_rpt_dpNaghd);
					}
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600007F RID: 127 RVA: 0x0015124C File Offset: 0x0014F64C
			// (set) Token: 0x06000130 RID: 304 RVA: 0x001539FC File Offset: 0x00151DFC
			public Frm_Rpt_Furush Frm_Rpt_Furush
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Rpt_Furush = MyProject.MyForms.Create__Instance__<Frm_Rpt_Furush>(this.m_Frm_Rpt_Furush);
					return this.m_Frm_Rpt_Furush;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Rpt_Furush;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Rpt_Furush>(ref this.m_Frm_Rpt_Furush);
					}
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00151274 File Offset: 0x0014F674
			// (set) Token: 0x06000131 RID: 305 RVA: 0x00153A40 File Offset: 0x00151E40
			public Frm_rpt_kasrezafesandug Frm_rpt_kasrezafesandug
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_kasrezafesandug = MyProject.MyForms.Create__Instance__<Frm_rpt_kasrezafesandug>(this.m_Frm_rpt_kasrezafesandug);
					return this.m_Frm_rpt_kasrezafesandug;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_kasrezafesandug;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_kasrezafesandug>(ref this.m_Frm_rpt_kasrezafesandug);
					}
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000081 RID: 129 RVA: 0x0015129C File Offset: 0x0014F69C
			// (set) Token: 0x06000132 RID: 306 RVA: 0x00153A84 File Offset: 0x00151E84
			public Frm_rpt_listsiah_bedehkaran Frm_rpt_listsiah_bedehkaran
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_listsiah_bedehkaran = MyProject.MyForms.Create__Instance__<Frm_rpt_listsiah_bedehkaran>(this.m_Frm_rpt_listsiah_bedehkaran);
					return this.m_Frm_rpt_listsiah_bedehkaran;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_listsiah_bedehkaran;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_listsiah_bedehkaran>(ref this.m_Frm_rpt_listsiah_bedehkaran);
					}
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000082 RID: 130 RVA: 0x001512C4 File Offset: 0x0014F6C4
			// (set) Token: 0x06000133 RID: 307 RVA: 0x00153AC8 File Offset: 0x00151EC8
			public Frm_rpt_nesieRuz Frm_rpt_nesieRuz
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_nesieRuz = MyProject.MyForms.Create__Instance__<Frm_rpt_nesieRuz>(this.m_Frm_rpt_nesieRuz);
					return this.m_Frm_rpt_nesieRuz;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_nesieRuz;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_nesieRuz>(ref this.m_Frm_rpt_nesieRuz);
					}
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000083 RID: 131 RVA: 0x001512EC File Offset: 0x0014F6EC
			// (set) Token: 0x06000134 RID: 308 RVA: 0x00153B0C File Offset: 0x00151F0C
			public Frm_rpt_Rizkharid Frm_rpt_Rizkharid
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_Rizkharid = MyProject.MyForms.Create__Instance__<Frm_rpt_Rizkharid>(this.m_Frm_rpt_Rizkharid);
					return this.m_Frm_rpt_Rizkharid;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_Rizkharid;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_Rizkharid>(ref this.m_Frm_rpt_Rizkharid);
					}
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00151314 File Offset: 0x0014F714
			// (set) Token: 0x06000135 RID: 309 RVA: 0x00153B50 File Offset: 0x00151F50
			public Frm_rpt_ruzane Frm_rpt_ruzane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_ruzane = MyProject.MyForms.Create__Instance__<Frm_rpt_ruzane>(this.m_Frm_rpt_ruzane);
					return this.m_Frm_rpt_ruzane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_ruzane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_ruzane>(ref this.m_Frm_rpt_ruzane);
					}
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000085 RID: 133 RVA: 0x0015133C File Offset: 0x0014F73C
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00153B94 File Offset: 0x00151F94
			public Frm_Rpt_SafiMande Frm_Rpt_SafiMande
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Rpt_SafiMande = MyProject.MyForms.Create__Instance__<Frm_Rpt_SafiMande>(this.m_Frm_Rpt_SafiMande);
					return this.m_Frm_Rpt_SafiMande;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Rpt_SafiMande;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Rpt_SafiMande>(ref this.m_Frm_Rpt_SafiMande);
					}
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000086 RID: 134 RVA: 0x00151364 File Offset: 0x0014F764
			// (set) Token: 0x06000137 RID: 311 RVA: 0x00153BD8 File Offset: 0x00151FD8
			public Frm_rpt_Sandugh Frm_rpt_Sandugh
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_rpt_Sandugh = MyProject.MyForms.Create__Instance__<Frm_rpt_Sandugh>(this.m_Frm_rpt_Sandugh);
					return this.m_Frm_rpt_Sandugh;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_rpt_Sandugh;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_rpt_Sandugh>(ref this.m_Frm_rpt_Sandugh);
					}
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000087 RID: 135 RVA: 0x0015138C File Offset: 0x0014F78C
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00153C1C File Offset: 0x0015201C
			public Frm_Rpt_TarazName Frm_Rpt_TarazName
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Rpt_TarazName = MyProject.MyForms.Create__Instance__<Frm_Rpt_TarazName>(this.m_Frm_Rpt_TarazName);
					return this.m_Frm_Rpt_TarazName;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Rpt_TarazName;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Rpt_TarazName>(ref this.m_Frm_Rpt_TarazName);
					}
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000088 RID: 136 RVA: 0x001513B4 File Offset: 0x0014F7B4
			// (set) Token: 0x06000139 RID: 313 RVA: 0x00153C60 File Offset: 0x00152060
			public Frm_Saderat Frm_Saderat
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Saderat = MyProject.MyForms.Create__Instance__<Frm_Saderat>(this.m_Frm_Saderat);
					return this.m_Frm_Saderat;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Saderat;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Saderat>(ref this.m_Frm_Saderat);
					}
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000089 RID: 137 RVA: 0x001513DC File Offset: 0x0014F7DC
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00153CA4 File Offset: 0x001520A4
			public Frm_Safi Frm_Safi
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Safi = MyProject.MyForms.Create__Instance__<Frm_Safi>(this.m_Frm_Safi);
					return this.m_Frm_Safi;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Safi;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Safi>(ref this.m_Frm_Safi);
					}
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00151404 File Offset: 0x0014F804
			// (set) Token: 0x0600013B RID: 315 RVA: 0x00153CE8 File Offset: 0x001520E8
			public Frm_Safi_Sardkhane Frm_Safi_Sardkhane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Safi_Sardkhane = MyProject.MyForms.Create__Instance__<Frm_Safi_Sardkhane>(this.m_Frm_Safi_Sardkhane);
					return this.m_Frm_Safi_Sardkhane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Safi_Sardkhane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Safi_Sardkhane>(ref this.m_Frm_Safi_Sardkhane);
					}
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600008B RID: 139 RVA: 0x0015142C File Offset: 0x0014F82C
			// (set) Token: 0x0600013C RID: 316 RVA: 0x00153D2C File Offset: 0x0015212C
			public Frm_safiEzafe Frm_safiEzafe
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_safiEzafe = MyProject.MyForms.Create__Instance__<Frm_safiEzafe>(this.m_Frm_safiEzafe);
					return this.m_Frm_safiEzafe;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_safiEzafe;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_safiEzafe>(ref this.m_Frm_safiEzafe);
					}
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00151454 File Offset: 0x0014F854
			// (set) Token: 0x0600013D RID: 317 RVA: 0x00153D70 File Offset: 0x00152170
			public Frm_SahebSaham Frm_SahebSaham
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SahebSaham = MyProject.MyForms.Create__Instance__<Frm_SahebSaham>(this.m_Frm_SahebSaham);
					return this.m_Frm_SahebSaham;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SahebSaham;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SahebSaham>(ref this.m_Frm_SahebSaham);
					}
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x0600008D RID: 141 RVA: 0x0015147C File Offset: 0x0014F87C
			// (set) Token: 0x0600013E RID: 318 RVA: 0x00153DB4 File Offset: 0x001521B4
			public Frm_Sal_Mali Frm_Sal_Mali
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sal_Mali = MyProject.MyForms.Create__Instance__<Frm_Sal_Mali>(this.m_Frm_Sal_Mali);
					return this.m_Frm_Sal_Mali;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sal_Mali;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sal_Mali>(ref this.m_Frm_Sal_Mali);
					}
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x0600008E RID: 142 RVA: 0x001514A4 File Offset: 0x0014F8A4
			// (set) Token: 0x0600013F RID: 319 RVA: 0x00153DF8 File Offset: 0x001521F8
			public Frm_Sanad_Dasti Frm_Sanad_Dasti
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sanad_Dasti = MyProject.MyForms.Create__Instance__<Frm_Sanad_Dasti>(this.m_Frm_Sanad_Dasti);
					return this.m_Frm_Sanad_Dasti;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sanad_Dasti;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sanad_Dasti>(ref this.m_Frm_Sanad_Dasti);
					}
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x0600008F RID: 143 RVA: 0x001514CC File Offset: 0x0014F8CC
			// (set) Token: 0x06000140 RID: 320 RVA: 0x00153E3C File Offset: 0x0015223C
			public Frm_Sarbarg Frm_Sarbarg
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sarbarg = MyProject.MyForms.Create__Instance__<Frm_Sarbarg>(this.m_Frm_Sarbarg);
					return this.m_Frm_Sarbarg;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sarbarg;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sarbarg>(ref this.m_Frm_Sarbarg);
					}
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x06000090 RID: 144 RVA: 0x001514F4 File Offset: 0x0014F8F4
			// (set) Token: 0x06000141 RID: 321 RVA: 0x00153E80 File Offset: 0x00152280
			public Frm_Sardkhane_RizKharid Frm_Sardkhane_RizKharid
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sardkhane_RizKharid = MyProject.MyForms.Create__Instance__<Frm_Sardkhane_RizKharid>(this.m_Frm_Sardkhane_RizKharid);
					return this.m_Frm_Sardkhane_RizKharid;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sardkhane_RizKharid;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sardkhane_RizKharid>(ref this.m_Frm_Sardkhane_RizKharid);
					}
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000091 RID: 145 RVA: 0x0015151C File Offset: 0x0014F91C
			// (set) Token: 0x06000142 RID: 322 RVA: 0x00153EC4 File Offset: 0x001522C4
			public Frm_Secure Frm_Secure
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Secure = MyProject.MyForms.Create__Instance__<Frm_Secure>(this.m_Frm_Secure);
					return this.m_Frm_Secure;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Secure;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Secure>(ref this.m_Frm_Secure);
					}
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000092 RID: 146 RVA: 0x00151544 File Offset: 0x0014F944
			// (set) Token: 0x06000143 RID: 323 RVA: 0x00153F08 File Offset: 0x00152308
			public Frm_Select_Kala_To_Kala Frm_Select_Kala_To_Kala
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Select_Kala_To_Kala = MyProject.MyForms.Create__Instance__<Frm_Select_Kala_To_Kala>(this.m_Frm_Select_Kala_To_Kala);
					return this.m_Frm_Select_Kala_To_Kala;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Select_Kala_To_Kala;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Select_Kala_To_Kala>(ref this.m_Frm_Select_Kala_To_Kala);
					}
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000093 RID: 147 RVA: 0x0015156C File Offset: 0x0014F96C
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00153F4C File Offset: 0x0015234C
			public Frm_SelectDasteCheck Frm_SelectDasteCheck
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SelectDasteCheck = MyProject.MyForms.Create__Instance__<Frm_SelectDasteCheck>(this.m_Frm_SelectDasteCheck);
					return this.m_Frm_SelectDasteCheck;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SelectDasteCheck;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SelectDasteCheck>(ref this.m_Frm_SelectDasteCheck);
					}
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000094 RID: 148 RVA: 0x00151594 File Offset: 0x0014F994
			// (set) Token: 0x06000145 RID: 325 RVA: 0x00153F90 File Offset: 0x00152390
			public Frm_SelectItem Frm_SelectItem
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SelectItem = MyProject.MyForms.Create__Instance__<Frm_SelectItem>(this.m_Frm_SelectItem);
					return this.m_Frm_SelectItem;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SelectItem;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SelectItem>(ref this.m_Frm_SelectItem);
					}
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000095 RID: 149 RVA: 0x001515BC File Offset: 0x0014F9BC
			// (set) Token: 0x06000146 RID: 326 RVA: 0x00153FD4 File Offset: 0x001523D4
			public Frm_SelectItemSql Frm_SelectItemSql
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SelectItemSql = MyProject.MyForms.Create__Instance__<Frm_SelectItemSql>(this.m_Frm_SelectItemSql);
					return this.m_Frm_SelectItemSql;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SelectItemSql;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SelectItemSql>(ref this.m_Frm_SelectItemSql);
					}
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000096 RID: 150 RVA: 0x001515E4 File Offset: 0x0014F9E4
			// (set) Token: 0x06000147 RID: 327 RVA: 0x00154018 File Offset: 0x00152418
			public Frm_Sendto_sqlite Frm_Sendto_sqlite
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sendto_sqlite = MyProject.MyForms.Create__Instance__<Frm_Sendto_sqlite>(this.m_Frm_Sendto_sqlite);
					return this.m_Frm_Sendto_sqlite;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sendto_sqlite;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sendto_sqlite>(ref this.m_Frm_Sendto_sqlite);
					}
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000097 RID: 151 RVA: 0x0015160C File Offset: 0x0014FA0C
			// (set) Token: 0x06000148 RID: 328 RVA: 0x0015405C File Offset: 0x0015245C
			public Frm_Setting Frm_Setting
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Setting = MyProject.MyForms.Create__Instance__<Frm_Setting>(this.m_Frm_Setting);
					return this.m_Frm_Setting;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Setting;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Setting>(ref this.m_Frm_Setting);
					}
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000098 RID: 152 RVA: 0x00151634 File Offset: 0x0014FA34
			// (set) Token: 0x06000149 RID: 329 RVA: 0x001540A0 File Offset: 0x001524A0
			public Frm_ShomareHesab Frm_ShomareHesab
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_ShomareHesab = MyProject.MyForms.Create__Instance__<Frm_ShomareHesab>(this.m_Frm_ShomareHesab);
					return this.m_Frm_ShomareHesab;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_ShomareHesab;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_ShomareHesab>(ref this.m_Frm_ShomareHesab);
					}
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000099 RID: 153 RVA: 0x0015165C File Offset: 0x0014FA5C
			// (set) Token: 0x0600014A RID: 330 RVA: 0x001540E4 File Offset: 0x001524E4
			public Frm_ShowItem Frm_ShowItem
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_ShowItem = MyProject.MyForms.Create__Instance__<Frm_ShowItem>(this.m_Frm_ShowItem);
					return this.m_Frm_ShowItem;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_ShowItem;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_ShowItem>(ref this.m_Frm_ShowItem);
					}
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600009A RID: 154 RVA: 0x00151684 File Offset: 0x0014FA84
			// (set) Token: 0x0600014B RID: 331 RVA: 0x00154128 File Offset: 0x00152528
			public Frm_ShowTarazData Frm_ShowTarazData
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_ShowTarazData = MyProject.MyForms.Create__Instance__<Frm_ShowTarazData>(this.m_Frm_ShowTarazData);
					return this.m_Frm_ShowTarazData;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_ShowTarazData;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_ShowTarazData>(ref this.m_Frm_ShowTarazData);
					}
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600009B RID: 155 RVA: 0x001516AC File Offset: 0x0014FAAC
			// (set) Token: 0x0600014C RID: 332 RVA: 0x0015416C File Offset: 0x0015256C
			public Frm_sms_ruzane Frm_sms_ruzane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_sms_ruzane = MyProject.MyForms.Create__Instance__<Frm_sms_ruzane>(this.m_Frm_sms_ruzane);
					return this.m_Frm_sms_ruzane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_sms_ruzane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_sms_ruzane>(ref this.m_Frm_sms_ruzane);
					}
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600009C RID: 156 RVA: 0x001516D4 File Offset: 0x0014FAD4
			// (set) Token: 0x0600014D RID: 333 RVA: 0x001541B0 File Offset: 0x001525B0
			public Frm_Sms_Setting Frm_Sms_Setting
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sms_Setting = MyProject.MyForms.Create__Instance__<Frm_Sms_Setting>(this.m_Frm_Sms_Setting);
					return this.m_Frm_Sms_Setting;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sms_Setting;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sms_Setting>(ref this.m_Frm_Sms_Setting);
					}
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600009D RID: 157 RVA: 0x001516FC File Offset: 0x0014FAFC
			// (set) Token: 0x0600014E RID: 334 RVA: 0x001541F4 File Offset: 0x001525F4
			public Frm_Sortdp Frm_Sortdp
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sortdp = MyProject.MyForms.Create__Instance__<Frm_Sortdp>(this.m_Frm_Sortdp);
					return this.m_Frm_Sortdp;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sortdp;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sortdp>(ref this.m_Frm_Sortdp);
					}
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00151724 File Offset: 0x0014FB24
			// (set) Token: 0x0600014F RID: 335 RVA: 0x00154238 File Offset: 0x00152638
			public Frm_SortMenu Frm_SortMenu
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SortMenu = MyProject.MyForms.Create__Instance__<Frm_SortMenu>(this.m_Frm_SortMenu);
					return this.m_Frm_SortMenu;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SortMenu;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SortMenu>(ref this.m_Frm_SortMenu);
					}
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x0600009F RID: 159 RVA: 0x0015174C File Offset: 0x0014FB4C
			// (set) Token: 0x06000150 RID: 336 RVA: 0x0015427C File Offset: 0x0015267C
			public Frm_Splash Frm_Splash
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Splash = MyProject.MyForms.Create__Instance__<Frm_Splash>(this.m_Frm_Splash);
					return this.m_Frm_Splash;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Splash;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Splash>(ref this.m_Frm_Splash);
					}
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00151774 File Offset: 0x0014FB74
			// (set) Token: 0x06000151 RID: 337 RVA: 0x001542C0 File Offset: 0x001526C0
			public Frm_Splash2 Frm_Splash2
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Splash2 = MyProject.MyForms.Create__Instance__<Frm_Splash2>(this.m_Frm_Splash2);
					return this.m_Frm_Splash2;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Splash2;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Splash2>(ref this.m_Frm_Splash2);
					}
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x0015179C File Offset: 0x0014FB9C
			// (set) Token: 0x06000152 RID: 338 RVA: 0x00154304 File Offset: 0x00152704
			public Frm_Startup Frm_Startup
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Startup = MyProject.MyForms.Create__Instance__<Frm_Startup>(this.m_Frm_Startup);
					return this.m_Frm_Startup;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Startup;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Startup>(ref this.m_Frm_Startup);
					}
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x001517C4 File Offset: 0x0014FBC4
			// (set) Token: 0x06000153 RID: 339 RVA: 0x00154348 File Offset: 0x00152748
			public Frm_Stimul_Report Frm_Stimul_Report
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Stimul_Report = MyProject.MyForms.Create__Instance__<Frm_Stimul_Report>(this.m_Frm_Stimul_Report);
					return this.m_Frm_Stimul_Report;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Stimul_Report;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Stimul_Report>(ref this.m_Frm_Stimul_Report);
					}
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x001517EC File Offset: 0x0014FBEC
			// (set) Token: 0x06000154 RID: 340 RVA: 0x0015438C File Offset: 0x0015278C
			public Frm_Sud Frm_Sud
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sud = MyProject.MyForms.Create__Instance__<Frm_Sud>(this.m_Frm_Sud);
					return this.m_Frm_Sud;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sud;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sud>(ref this.m_Frm_Sud);
					}
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00151814 File Offset: 0x0014FC14
			// (set) Token: 0x06000155 RID: 341 RVA: 0x001543D0 File Offset: 0x001527D0
			public Frm_Sud_Furush Frm_Sud_Furush
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sud_Furush = MyProject.MyForms.Create__Instance__<Frm_Sud_Furush>(this.m_Frm_Sud_Furush);
					return this.m_Frm_Sud_Furush;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sud_Furush;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sud_Furush>(ref this.m_Frm_Sud_Furush);
					}
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x0015183C File Offset: 0x0014FC3C
			// (set) Token: 0x06000156 RID: 342 RVA: 0x00154414 File Offset: 0x00152814
			public Frm_Sud_Kharid Frm_Sud_Kharid
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sud_Kharid = MyProject.MyForms.Create__Instance__<Frm_Sud_Kharid>(this.m_Frm_Sud_Kharid);
					return this.m_Frm_Sud_Kharid;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sud_Kharid;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sud_Kharid>(ref this.m_Frm_Sud_Kharid);
					}
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00151864 File Offset: 0x0014FC64
			// (set) Token: 0x06000157 RID: 343 RVA: 0x00154458 File Offset: 0x00152858
			public Frm_Sud_Kharid_Sardkhane Frm_Sud_Kharid_Sardkhane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Sud_Kharid_Sardkhane = MyProject.MyForms.Create__Instance__<Frm_Sud_Kharid_Sardkhane>(this.m_Frm_Sud_Kharid_Sardkhane);
					return this.m_Frm_Sud_Kharid_Sardkhane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Sud_Kharid_Sardkhane;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Sud_Kharid_Sardkhane>(ref this.m_Frm_Sud_Kharid_Sardkhane);
					}
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x0015188C File Offset: 0x0014FC8C
			// (set) Token: 0x06000158 RID: 344 RVA: 0x0015449C File Offset: 0x0015289C
			public Frm_SudKhorde Frm_SudKhorde
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SudKhorde = MyProject.MyForms.Create__Instance__<Frm_SudKhorde>(this.m_Frm_SudKhorde);
					return this.m_Frm_SudKhorde;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SudKhorde;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SudKhorde>(ref this.m_Frm_SudKhorde);
					}
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x001518B4 File Offset: 0x0014FCB4
			// (set) Token: 0x06000159 RID: 345 RVA: 0x001544E0 File Offset: 0x001528E0
			public Frm_SuratHesab_Anbar Frm_SuratHesab_Anbar
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Anbar = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Anbar>(this.m_Frm_SuratHesab_Anbar);
					return this.m_Frm_SuratHesab_Anbar;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Anbar;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Anbar>(ref this.m_Frm_SuratHesab_Anbar);
					}
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x001518DC File Offset: 0x0014FCDC
			// (set) Token: 0x0600015A RID: 346 RVA: 0x00154524 File Offset: 0x00152924
			public Frm_SuratHesab_Arzi_Moshtari Frm_SuratHesab_Arzi_Moshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Arzi_Moshtari = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Arzi_Moshtari>(this.m_Frm_SuratHesab_Arzi_Moshtari);
					return this.m_Frm_SuratHesab_Arzi_Moshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Arzi_Moshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Arzi_Moshtari>(ref this.m_Frm_SuratHesab_Arzi_Moshtari);
					}
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060000AA RID: 170 RVA: 0x00151904 File Offset: 0x0014FD04
			// (set) Token: 0x0600015B RID: 347 RVA: 0x00154568 File Offset: 0x00152968
			public Frm_SuratHesab_Bank Frm_SuratHesab_Bank
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Bank = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Bank>(this.m_Frm_SuratHesab_Bank);
					return this.m_Frm_SuratHesab_Bank;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Bank;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Bank>(ref this.m_Frm_SuratHesab_Bank);
					}
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060000AB RID: 171 RVA: 0x0015192C File Offset: 0x0014FD2C
			// (set) Token: 0x0600015C RID: 348 RVA: 0x001545AC File Offset: 0x001529AC
			public Frm_SuratHesab_Barzamin Frm_SuratHesab_Barzamin
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Barzamin = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Barzamin>(this.m_Frm_SuratHesab_Barzamin);
					return this.m_Frm_SuratHesab_Barzamin;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Barzamin;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Barzamin>(ref this.m_Frm_SuratHesab_Barzamin);
					}
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060000AC RID: 172 RVA: 0x00151954 File Offset: 0x0014FD54
			// (set) Token: 0x0600015D RID: 349 RVA: 0x001545F0 File Offset: 0x001529F0
			public Frm_SuratHesab_Daramad Frm_SuratHesab_Daramad
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Daramad = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Daramad>(this.m_Frm_SuratHesab_Daramad);
					return this.m_Frm_SuratHesab_Daramad;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Daramad;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Daramad>(ref this.m_Frm_SuratHesab_Daramad);
					}
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060000AD RID: 173 RVA: 0x0015197C File Offset: 0x0014FD7C
			// (set) Token: 0x0600015E RID: 350 RVA: 0x00154634 File Offset: 0x00152A34
			public Frm_SuratHesab_Daramad_Khorde Frm_SuratHesab_Daramad_Khorde
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Daramad_Khorde = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Daramad_Khorde>(this.m_Frm_SuratHesab_Daramad_Khorde);
					return this.m_Frm_SuratHesab_Daramad_Khorde;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Daramad_Khorde;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Daramad_Khorde>(ref this.m_Frm_SuratHesab_Daramad_Khorde);
					}
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060000AE RID: 174 RVA: 0x001519A4 File Offset: 0x0014FDA4
			// (set) Token: 0x0600015F RID: 351 RVA: 0x00154678 File Offset: 0x00152A78
			public Frm_SuratHesab_Daryafti_Moshtari Frm_SuratHesab_Daryafti_Moshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Daryafti_Moshtari = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Daryafti_Moshtari>(this.m_Frm_SuratHesab_Daryafti_Moshtari);
					return this.m_Frm_SuratHesab_Daryafti_Moshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Daryafti_Moshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Daryafti_Moshtari>(ref this.m_Frm_SuratHesab_Daryafti_Moshtari);
					}
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060000AF RID: 175 RVA: 0x001519CC File Offset: 0x0014FDCC
			// (set) Token: 0x06000160 RID: 352 RVA: 0x001546BC File Offset: 0x00152ABC
			public Frm_SuratHesab_Furush Frm_SuratHesab_Furush
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Furush = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Furush>(this.m_Frm_SuratHesab_Furush);
					return this.m_Frm_SuratHesab_Furush;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Furush;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Furush>(ref this.m_Frm_SuratHesab_Furush);
					}
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x001519F4 File Offset: 0x0014FDF4
			// (set) Token: 0x06000161 RID: 353 RVA: 0x00154700 File Offset: 0x00152B00
			public Frm_SuratHesab_HavaleArzi Frm_SuratHesab_HavaleArzi
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_HavaleArzi = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_HavaleArzi>(this.m_Frm_SuratHesab_HavaleArzi);
					return this.m_Frm_SuratHesab_HavaleArzi;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_HavaleArzi;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_HavaleArzi>(ref this.m_Frm_SuratHesab_HavaleArzi);
					}
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x00151A1C File Offset: 0x0014FE1C
			// (set) Token: 0x06000162 RID: 354 RVA: 0x00154744 File Offset: 0x00152B44
			public Frm_SuratHesab_Hazine Frm_SuratHesab_Hazine
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Hazine = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Hazine>(this.m_Frm_SuratHesab_Hazine);
					return this.m_Frm_SuratHesab_Hazine;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Hazine;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Hazine>(ref this.m_Frm_SuratHesab_Hazine);
					}
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00151A44 File Offset: 0x0014FE44
			// (set) Token: 0x06000163 RID: 355 RVA: 0x00154788 File Offset: 0x00152B88
			public Frm_SuratHesab_kargari Frm_SuratHesab_kargari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_kargari = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_kargari>(this.m_Frm_SuratHesab_kargari);
					return this.m_Frm_SuratHesab_kargari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_kargari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_kargari>(ref this.m_Frm_SuratHesab_kargari);
					}
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x00151A6C File Offset: 0x0014FE6C
			// (set) Token: 0x06000164 RID: 356 RVA: 0x001547CC File Offset: 0x00152BCC
			public Frm_SuratHesab_Kharid Frm_SuratHesab_Kharid
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Kharid = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Kharid>(this.m_Frm_SuratHesab_Kharid);
					return this.m_Frm_SuratHesab_Kharid;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Kharid;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Kharid>(ref this.m_Frm_SuratHesab_Kharid);
					}
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00151A94 File Offset: 0x0014FE94
			// (set) Token: 0x06000165 RID: 357 RVA: 0x00154810 File Offset: 0x00152C10
			public Frm_SuratHesab_KharidFurush Frm_SuratHesab_KharidFurush
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_KharidFurush = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_KharidFurush>(this.m_Frm_SuratHesab_KharidFurush);
					return this.m_Frm_SuratHesab_KharidFurush;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_KharidFurush;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_KharidFurush>(ref this.m_Frm_SuratHesab_KharidFurush);
					}
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00151ABC File Offset: 0x0014FEBC
			// (set) Token: 0x06000166 RID: 358 RVA: 0x00154854 File Offset: 0x00152C54
			public Frm_SuratHesab_Moshtari Frm_SuratHesab_Moshtari
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Moshtari = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Moshtari>(this.m_Frm_SuratHesab_Moshtari);
					return this.m_Frm_SuratHesab_Moshtari;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Moshtari;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Moshtari>(ref this.m_Frm_SuratHesab_Moshtari);
					}
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00151AE4 File Offset: 0x0014FEE4
			// (set) Token: 0x06000167 RID: 359 RVA: 0x00154898 File Offset: 0x00152C98
			public Frm_SuratHesab_Sandugh Frm_SuratHesab_Sandugh
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Sandugh = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Sandugh>(this.m_Frm_SuratHesab_Sandugh);
					return this.m_Frm_SuratHesab_Sandugh;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Sandugh;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Sandugh>(ref this.m_Frm_SuratHesab_Sandugh);
					}
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x00151B0C File Offset: 0x0014FF0C
			// (set) Token: 0x06000168 RID: 360 RVA: 0x001548DC File Offset: 0x00152CDC
			public Frm_SuratHesab_Sharik Frm_SuratHesab_Sharik
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Sharik = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Sharik>(this.m_Frm_SuratHesab_Sharik);
					return this.m_Frm_SuratHesab_Sharik;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Sharik;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Sharik>(ref this.m_Frm_SuratHesab_Sharik);
					}
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00151B34 File Offset: 0x0014FF34
			// (set) Token: 0x06000169 RID: 361 RVA: 0x00154920 File Offset: 0x00152D20
			public Frm_SuratHesab_Tafavot Frm_SuratHesab_Tafavot
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Tafavot = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Tafavot>(this.m_Frm_SuratHesab_Tafavot);
					return this.m_Frm_SuratHesab_Tafavot;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Tafavot;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Tafavot>(ref this.m_Frm_SuratHesab_Tafavot);
					}
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00151B5C File Offset: 0x0014FF5C
			// (set) Token: 0x0600016A RID: 362 RVA: 0x00154964 File Offset: 0x00152D64
			public Frm_SuratHesab_Takhlie Frm_SuratHesab_Takhlie
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Takhlie = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Takhlie>(this.m_Frm_SuratHesab_Takhlie);
					return this.m_Frm_SuratHesab_Takhlie;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Takhlie;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Takhlie>(ref this.m_Frm_SuratHesab_Takhlie);
					}
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x060000BA RID: 186 RVA: 0x00151B84 File Offset: 0x0014FF84
			// (set) Token: 0x0600016B RID: 363 RVA: 0x001549A8 File Offset: 0x00152DA8
			public Frm_SuratHesab_Takhlie2 Frm_SuratHesab_Takhlie2
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Takhlie2 = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Takhlie2>(this.m_Frm_SuratHesab_Takhlie2);
					return this.m_Frm_SuratHesab_Takhlie2;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Takhlie2;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Takhlie2>(ref this.m_Frm_SuratHesab_Takhlie2);
					}
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060000BB RID: 187 RVA: 0x00151BAC File Offset: 0x0014FFAC
			// (set) Token: 0x0600016C RID: 364 RVA: 0x001549EC File Offset: 0x00152DEC
			public Frm_SuratHesab_Tankhah Frm_SuratHesab_Tankhah
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Tankhah = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Tankhah>(this.m_Frm_SuratHesab_Tankhah);
					return this.m_Frm_SuratHesab_Tankhah;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Tankhah;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Tankhah>(ref this.m_Frm_SuratHesab_Tankhah);
					}
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00151BD4 File Offset: 0x0014FFD4
			// (set) Token: 0x0600016D RID: 365 RVA: 0x00154A30 File Offset: 0x00152E30
			public Frm_SuratHesab_Vam Frm_SuratHesab_Vam
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_SuratHesab_Vam = MyProject.MyForms.Create__Instance__<Frm_SuratHesab_Vam>(this.m_Frm_SuratHesab_Vam);
					return this.m_Frm_SuratHesab_Vam;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_SuratHesab_Vam;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_SuratHesab_Vam>(ref this.m_Frm_SuratHesab_Vam);
					}
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060000BD RID: 189 RVA: 0x00151BFC File Offset: 0x0014FFFC
			// (set) Token: 0x0600016E RID: 366 RVA: 0x00154A74 File Offset: 0x00152E74
			public Frm_TedadKala Frm_TedadKala
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_TedadKala = MyProject.MyForms.Create__Instance__<Frm_TedadKala>(this.m_Frm_TedadKala);
					return this.m_Frm_TedadKala;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_TedadKala;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_TedadKala>(ref this.m_Frm_TedadKala);
					}
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00151C24 File Offset: 0x00150024
			// (set) Token: 0x0600016F RID: 367 RVA: 0x00154AB8 File Offset: 0x00152EB8
			public Frm_User_Admin Frm_User_Admin
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_User_Admin = MyProject.MyForms.Create__Instance__<Frm_User_Admin>(this.m_Frm_User_Admin);
					return this.m_Frm_User_Admin;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_User_Admin;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_User_Admin>(ref this.m_Frm_User_Admin);
					}
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060000BF RID: 191 RVA: 0x00151C4C File Offset: 0x0015004C
			// (set) Token: 0x06000170 RID: 368 RVA: 0x00154AFC File Offset: 0x00152EFC
			public Frm_Varedat Frm_Varedat
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Varedat = MyProject.MyForms.Create__Instance__<Frm_Varedat>(this.m_Frm_Varedat);
					return this.m_Frm_Varedat;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Varedat;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Varedat>(ref this.m_Frm_Varedat);
					}
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x00151C74 File Offset: 0x00150074
			// (set) Token: 0x06000171 RID: 369 RVA: 0x00154B40 File Offset: 0x00152F40
			public Frm_Vusul_Check Frm_Vusul_Check
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Vusul_Check = MyProject.MyForms.Create__Instance__<Frm_Vusul_Check>(this.m_Frm_Vusul_Check);
					return this.m_Frm_Vusul_Check;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Vusul_Check;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Vusul_Check>(ref this.m_Frm_Vusul_Check);
					}
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x00151C9C File Offset: 0x0015009C
			// (set) Token: 0x06000172 RID: 370 RVA: 0x00154B84 File Offset: 0x00152F84
			public Frm_Vusul_Checkd Frm_Vusul_Checkd
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Frm_Vusul_Checkd = MyProject.MyForms.Create__Instance__<Frm_Vusul_Checkd>(this.m_Frm_Vusul_Checkd);
					return this.m_Frm_Vusul_Checkd;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Frm_Vusul_Checkd;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Frm_Vusul_Checkd>(ref this.m_Frm_Vusul_Checkd);
					}
				}
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00154BC8 File Offset: 0x00152FC8
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				T result;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						try
						{
							result = Activator.CreateInstance<T>();
							return result;
						}
						object arg_97_0;
						TargetInvocationException expr_9C = arg_97_0 as TargetInvocationException;
						int arg_B9_0;
						if (expr_9C == null)
						{
							arg_B9_0 = 0;
						}
						else
						{
							TargetInvocationException ex = expr_9C;
							ProjectData.SetProjectError(expr_9C);
							arg_B9_0 = (((ex.InnerException != null) > false) ? 1 : 0);
						}
						endfilter(arg_B9_0);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				result = Instance;
				return result;
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00154D04 File Offset: 0x00153104
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000175 RID: 373 RVA: 0x00154D30 File Offset: 0x00153130
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00154D3C File Offset: 0x0015313C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00154D5C File Offset: 0x0015315C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000178 RID: 376 RVA: 0x00154D74 File Offset: 0x00153174
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00154D90 File Offset: 0x00153190
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			public Check_Bank m_Check_Bank;

			// Token: 0x04000008 RID: 8
			public Check_Sandugh m_Check_Sandugh;

			// Token: 0x04000009 RID: 9
			public Form1 m_Form1;

			// Token: 0x0400000A RID: 10
			public Form2 m_Form2;

			// Token: 0x0400000B RID: 11
			public Form_Main m_Form_Main;

			// Token: 0x0400000C RID: 12
			public Frm_About m_Frm_About;

			// Token: 0x0400000D RID: 13
			public Frm_Amniat_Setting m_Frm_Amniat_Setting;

			// Token: 0x0400000E RID: 14
			public Frm_Backup m_Frm_Backup;

			// Token: 0x0400000F RID: 15
			public Frm_Bank m_Frm_Bank;

			// Token: 0x04000010 RID: 16
			public Frm_Bank_Hesab m_Frm_Bank_Hesab;

			// Token: 0x04000011 RID: 17
			public Frm_BankReport_Design m_Frm_BankReport_Design;

			// Token: 0x04000012 RID: 18
			public Frm_Bargasht_Checkd m_Frm_Bargasht_Checkd;

			// Token: 0x04000013 RID: 19
			public Frm_Base m_Frm_Base;

			// Token: 0x04000014 RID: 20
			public Frm_BastanSandug m_Frm_BastanSandug;

			// Token: 0x04000015 RID: 21
			public Frm_Calc m_Frm_Calc;

			// Token: 0x04000016 RID: 22
			public Frm_Change_Kala_To_Kala m_Frm_Change_Kala_To_Kala;

			// Token: 0x04000017 RID: 23
			public Frm_Change_Kala_To_Kala_Kharid m_Frm_Change_Kala_To_Kala_Kharid;

			// Token: 0x04000018 RID: 24
			public Frm_ChapSafi m_Frm_ChapSafi;

			// Token: 0x04000019 RID: 25
			public Frm_Check_Print m_Frm_Check_Print;

			// Token: 0x0400001A RID: 26
			public Frm_CheckBargasht m_Frm_CheckBargasht;

			// Token: 0x0400001B RID: 27
			public Frm_CheckNaghd m_Frm_CheckNaghd;

			// Token: 0x0400001C RID: 28
			public Frm_Checksarresid_Daryaft m_Frm_Checksarresid_Daryaft;

			// Token: 0x0400001D RID: 29
			public Frm_Checksarresid_Pardakht m_Frm_Checksarresid_Pardakht;

			// Token: 0x0400001E RID: 30
			public Frm_CheckVariz m_Frm_CheckVariz;

			// Token: 0x0400001F RID: 31
			public Frm_CheckVusul m_Frm_CheckVusul;

			// Token: 0x04000020 RID: 32
			public Frm_ClearData m_Frm_ClearData;

			// Token: 0x04000021 RID: 33
			public Frm_cmd m_Frm_cmd;

			// Token: 0x04000022 RID: 34
			public Frm_Coloring m_Frm_Coloring;

			// Token: 0x04000023 RID: 35
			public Frm_Connect m_Frm_Connect;

			// Token: 0x04000024 RID: 36
			public Frm_Daramad m_Frm_Daramad;

			// Token: 0x04000025 RID: 37
			public Frm_Daramad_avaldore m_Frm_Daramad_avaldore;

			// Token: 0x04000026 RID: 38
			public Frm_Daryaft_AzMoshtari m_Frm_Daryaft_AzMoshtari;

			// Token: 0x04000027 RID: 39
			public Frm_DaryaftCheck m_Frm_DaryaftCheck;

			// Token: 0x04000028 RID: 40
			public Frm_DaryaftCheck_Avaldore m_Frm_DaryaftCheck_Avaldore;

			// Token: 0x04000029 RID: 41
			public Frm_DaryaftCheck_naghd m_Frm_DaryaftCheck_naghd;

			// Token: 0x0400002A RID: 42
			public Frm_DaryaftPardakht m_Frm_DaryaftPardakht;

			// Token: 0x0400002B RID: 43
			public Frm_DasteCheck m_Frm_DasteCheck;

			// Token: 0x0400002C RID: 44
			public Frm_Delete_SalMali m_Frm_Delete_SalMali;

			// Token: 0x0400002D RID: 45
			public Frm_DeleteCheck_Opr m_Frm_DeleteCheck_Opr;

			// Token: 0x0400002E RID: 46
			public Frm_DeleteDaryaftPardakht m_Frm_DeleteDaryaftPardakht;

			// Token: 0x0400002F RID: 47
			public Frm_EbtalCheck m_Frm_EbtalCheck;

			// Token: 0x04000030 RID: 48
			public Frm_EditUser m_Frm_EditUser;

			// Token: 0x04000031 RID: 49
			public Frm_Error m_Frm_Error;

			// Token: 0x04000032 RID: 50
			public Frm_Ersal_Bar m_Frm_Ersal_Bar;

			// Token: 0x04000033 RID: 51
			public Frm_Extra_Setting m_Frm_Extra_Setting;

			// Token: 0x04000034 RID: 52
			public Frm_FoctorFurush m_Frm_FoctorFurush;

			// Token: 0x04000035 RID: 53
			public frm_Frush_hag m_frm_Frush_hag;

			// Token: 0x04000036 RID: 54
			public Frm_Frush_Sardkhane m_Frm_Frush_Sardkhane;

			// Token: 0x04000037 RID: 55
			public Frm_Furush_Keraye m_Frm_Furush_Keraye;

			// Token: 0x04000038 RID: 56
			public Frm_Furush_Nesie m_Frm_Furush_Nesie;

			// Token: 0x04000039 RID: 57
			public Frm_Furush_Sardkhane_Keraye m_Frm_Furush_Sardkhane_Keraye;

			// Token: 0x0400003A RID: 58
			public Frm_FurushRuzane m_Frm_FurushRuzane;

			// Token: 0x0400003B RID: 59
			public Frm_Grouh_Moshtari m_Frm_Grouh_Moshtari;

			// Token: 0x0400003C RID: 60
			public Frm_Grouh_Moshtari2 m_Frm_Grouh_Moshtari2;

			// Token: 0x0400003D RID: 61
			public Frm_Hazine m_Frm_Hazine;

			// Token: 0x0400003E RID: 62
			public Frm_Hazine_Kharid m_Frm_Hazine_Kharid;

			// Token: 0x0400003F RID: 63
			public Frm_Help m_Frm_Help;

			// Token: 0x04000040 RID: 64
			public frm_historyLog m_frm_historyLog;

			// Token: 0x04000041 RID: 65
			public Frm_Kala m_Frm_Kala;

			// Token: 0x04000042 RID: 66
			public Frm_Karmozd m_Frm_Karmozd;

			// Token: 0x04000043 RID: 67
			public Frm_Kharid_Furush m_Frm_Kharid_Furush;

			// Token: 0x04000044 RID: 68
			public Frm_Kharid_Keraye m_Frm_Kharid_Keraye;

			// Token: 0x04000045 RID: 69
			public Frm_Kharid_Sardkhane_Keraye m_Frm_Kharid_Sardkhane_Keraye;

			// Token: 0x04000046 RID: 70
			public Frm_Kharid_Sardkhane_Keraye2 m_Frm_Kharid_Sardkhane_Keraye2;

			// Token: 0x04000047 RID: 71
			public Frm_KharidSardkhane m_Frm_KharidSardkhane;

			// Token: 0x04000048 RID: 72
			public Frm_KhordeFurushi m_Frm_KhordeFurushi;

			// Token: 0x04000049 RID: 73
			public Frm_KhordeFurushi_Keraye m_Frm_KhordeFurushi_Keraye;

			// Token: 0x0400004A RID: 74
			public Frm_Kiosk_Furush m_Frm_Kiosk_Furush;

			// Token: 0x0400004B RID: 75
			public Frm_list_BankHesab m_Frm_list_BankHesab;

			// Token: 0x0400004C RID: 76
			public Frm_List_EbtalCheck m_Frm_List_EbtalCheck;

			// Token: 0x0400004D RID: 77
			public Frm_list_Moshtari m_Frm_list_Moshtari;

			// Token: 0x0400004E RID: 78
			public Frm_List_Safi m_Frm_List_Safi;

			// Token: 0x0400004F RID: 79
			public Frm_MainSortMenu m_Frm_MainSortMenu;

			// Token: 0x04000050 RID: 80
			public Frm_Menu m_Frm_Menu;

			// Token: 0x04000051 RID: 81
			public Frm_MessageBox m_Frm_MessageBox;

			// Token: 0x04000052 RID: 82
			public Frm_Moshtari m_Frm_Moshtari;

			// Token: 0x04000053 RID: 83
			public Frm_Moshtari_Hesab m_Frm_Moshtari_Hesab;

			// Token: 0x04000054 RID: 84
			public Frm_Moshtari_kala m_Frm_Moshtari_kala;

			// Token: 0x04000055 RID: 85
			public Frm_Moshtarian m_Frm_Moshtarian;

			// Token: 0x04000056 RID: 86
			public Frm_MoshtariSearch m_Frm_MoshtariSearch;

			// Token: 0x04000057 RID: 87
			public Frm_NewVersion m_Frm_NewVersion;

			// Token: 0x04000058 RID: 88
			public Frm_Note m_Frm_Note;

			// Token: 0x04000059 RID: 89
			public Frm_Pardakht m_Frm_Pardakht;

			// Token: 0x0400005A RID: 90
			public Frm_Pardakht_BeMoshtari m_Frm_Pardakht_BeMoshtari;

			// Token: 0x0400005B RID: 91
			public Frm_PardakhtCheck m_Frm_PardakhtCheck;

			// Token: 0x0400005C RID: 92
			public Frm_PardakhtCheck_Avaldore m_Frm_PardakhtCheck_Avaldore;

			// Token: 0x0400005D RID: 93
			public Frm_PardakhtKonande m_Frm_PardakhtKonande;

			// Token: 0x0400005E RID: 94
			public Frm_PardakhtMoshtari m_Frm_PardakhtMoshtari;

			// Token: 0x0400005F RID: 95
			public Frm_Password m_Frm_Password;

			// Token: 0x04000060 RID: 96
			public Frm_Print_Base m_Frm_Print_Base;

			// Token: 0x04000061 RID: 97
			public Frm_RegHelp m_Frm_RegHelp;

			// Token: 0x04000062 RID: 98
			public Frm_Register m_Frm_Register;

			// Token: 0x04000063 RID: 99
			public Frm_Register2 m_Frm_Register2;

			// Token: 0x04000064 RID: 100
			public Frm_Restore m_Frm_Restore;

			// Token: 0x04000065 RID: 101
			public Frm_Rizbar m_Frm_Rizbar;

			// Token: 0x04000066 RID: 102
			public Frm_Rizbar_Sardkhane m_Frm_Rizbar_Sardkhane;

			// Token: 0x04000067 RID: 103
			public Frm_RizKharid m_Frm_RizKharid;

			// Token: 0x04000068 RID: 104
			public Frm_Rotbe m_Frm_Rotbe;

			// Token: 0x04000069 RID: 105
			public Frm_Rotbe_Detailvb m_Frm_Rotbe_Detailvb;

			// Token: 0x0400006A RID: 106
			public Frm_rpt_bedehkaran m_Frm_rpt_bedehkaran;

			// Token: 0x0400006B RID: 107
			public Frm_rpt_bestankaran m_Frm_rpt_bestankaran;

			// Token: 0x0400006C RID: 108
			public Frm_rpt_checkbargasht m_Frm_rpt_checkbargasht;

			// Token: 0x0400006D RID: 109
			public Frm_rpt_checkdarjaryan m_Frm_rpt_checkdarjaryan;

			// Token: 0x0400006E RID: 110
			public Frm_rpt_checkDaryafti m_Frm_rpt_checkDaryafti;

			// Token: 0x0400006F RID: 111
			public Frm_rpt_checkPardakhtani m_Frm_rpt_checkPardakhtani;

			// Token: 0x04000070 RID: 112
			public Frm_rpt_checksearch m_Frm_rpt_checksearch;

			// Token: 0x04000071 RID: 113
			public Frm_rpt_checksearchMoshtari m_Frm_rpt_checksearchMoshtari;

			// Token: 0x04000072 RID: 114
			public Frm_rpt_checkvusul m_Frm_rpt_checkvusul;

			// Token: 0x04000073 RID: 115
			public Frm_rpt_dastecheck m_Frm_rpt_dastecheck;

			// Token: 0x04000074 RID: 116
			public frm_rpt_dpNaghd m_frm_rpt_dpNaghd;

			// Token: 0x04000075 RID: 117
			public Frm_Rpt_Furush m_Frm_Rpt_Furush;

			// Token: 0x04000076 RID: 118
			public Frm_rpt_kasrezafesandug m_Frm_rpt_kasrezafesandug;

			// Token: 0x04000077 RID: 119
			public Frm_rpt_listsiah_bedehkaran m_Frm_rpt_listsiah_bedehkaran;

			// Token: 0x04000078 RID: 120
			public Frm_rpt_nesieRuz m_Frm_rpt_nesieRuz;

			// Token: 0x04000079 RID: 121
			public Frm_rpt_Rizkharid m_Frm_rpt_Rizkharid;

			// Token: 0x0400007A RID: 122
			public Frm_rpt_ruzane m_Frm_rpt_ruzane;

			// Token: 0x0400007B RID: 123
			public Frm_Rpt_SafiMande m_Frm_Rpt_SafiMande;

			// Token: 0x0400007C RID: 124
			public Frm_rpt_Sandugh m_Frm_rpt_Sandugh;

			// Token: 0x0400007D RID: 125
			public Frm_Rpt_TarazName m_Frm_Rpt_TarazName;

			// Token: 0x0400007E RID: 126
			public Frm_Saderat m_Frm_Saderat;

			// Token: 0x0400007F RID: 127
			public Frm_Safi m_Frm_Safi;

			// Token: 0x04000080 RID: 128
			public Frm_Safi_Sardkhane m_Frm_Safi_Sardkhane;

			// Token: 0x04000081 RID: 129
			public Frm_safiEzafe m_Frm_safiEzafe;

			// Token: 0x04000082 RID: 130
			public Frm_SahebSaham m_Frm_SahebSaham;

			// Token: 0x04000083 RID: 131
			public Frm_Sal_Mali m_Frm_Sal_Mali;

			// Token: 0x04000084 RID: 132
			public Frm_Sanad_Dasti m_Frm_Sanad_Dasti;

			// Token: 0x04000085 RID: 133
			public Frm_Sarbarg m_Frm_Sarbarg;

			// Token: 0x04000086 RID: 134
			public Frm_Sardkhane_RizKharid m_Frm_Sardkhane_RizKharid;

			// Token: 0x04000087 RID: 135
			public Frm_Secure m_Frm_Secure;

			// Token: 0x04000088 RID: 136
			public Frm_Select_Kala_To_Kala m_Frm_Select_Kala_To_Kala;

			// Token: 0x04000089 RID: 137
			public Frm_SelectDasteCheck m_Frm_SelectDasteCheck;

			// Token: 0x0400008A RID: 138
			public Frm_SelectItem m_Frm_SelectItem;

			// Token: 0x0400008B RID: 139
			public Frm_SelectItemSql m_Frm_SelectItemSql;

			// Token: 0x0400008C RID: 140
			public Frm_Sendto_sqlite m_Frm_Sendto_sqlite;

			// Token: 0x0400008D RID: 141
			public Frm_Setting m_Frm_Setting;

			// Token: 0x0400008E RID: 142
			public Frm_ShomareHesab m_Frm_ShomareHesab;

			// Token: 0x0400008F RID: 143
			public Frm_ShowItem m_Frm_ShowItem;

			// Token: 0x04000090 RID: 144
			public Frm_ShowTarazData m_Frm_ShowTarazData;

			// Token: 0x04000091 RID: 145
			public Frm_sms_ruzane m_Frm_sms_ruzane;

			// Token: 0x04000092 RID: 146
			public Frm_Sms_Setting m_Frm_Sms_Setting;

			// Token: 0x04000093 RID: 147
			public Frm_Sortdp m_Frm_Sortdp;

			// Token: 0x04000094 RID: 148
			public Frm_SortMenu m_Frm_SortMenu;

			// Token: 0x04000095 RID: 149
			public Frm_Splash m_Frm_Splash;

			// Token: 0x04000096 RID: 150
			public Frm_Splash2 m_Frm_Splash2;

			// Token: 0x04000097 RID: 151
			public Frm_Startup m_Frm_Startup;

			// Token: 0x04000098 RID: 152
			public Frm_Stimul_Report m_Frm_Stimul_Report;

			// Token: 0x04000099 RID: 153
			public Frm_Sud m_Frm_Sud;

			// Token: 0x0400009A RID: 154
			public Frm_Sud_Furush m_Frm_Sud_Furush;

			// Token: 0x0400009B RID: 155
			public Frm_Sud_Kharid m_Frm_Sud_Kharid;

			// Token: 0x0400009C RID: 156
			public Frm_Sud_Kharid_Sardkhane m_Frm_Sud_Kharid_Sardkhane;

			// Token: 0x0400009D RID: 157
			public Frm_SudKhorde m_Frm_SudKhorde;

			// Token: 0x0400009E RID: 158
			public Frm_SuratHesab_Anbar m_Frm_SuratHesab_Anbar;

			// Token: 0x0400009F RID: 159
			public Frm_SuratHesab_Arzi_Moshtari m_Frm_SuratHesab_Arzi_Moshtari;

			// Token: 0x040000A0 RID: 160
			public Frm_SuratHesab_Bank m_Frm_SuratHesab_Bank;

			// Token: 0x040000A1 RID: 161
			public Frm_SuratHesab_Barzamin m_Frm_SuratHesab_Barzamin;

			// Token: 0x040000A2 RID: 162
			public Frm_SuratHesab_Daramad m_Frm_SuratHesab_Daramad;

			// Token: 0x040000A3 RID: 163
			public Frm_SuratHesab_Daramad_Khorde m_Frm_SuratHesab_Daramad_Khorde;

			// Token: 0x040000A4 RID: 164
			public Frm_SuratHesab_Daryafti_Moshtari m_Frm_SuratHesab_Daryafti_Moshtari;

			// Token: 0x040000A5 RID: 165
			public Frm_SuratHesab_Furush m_Frm_SuratHesab_Furush;

			// Token: 0x040000A6 RID: 166
			public Frm_SuratHesab_HavaleArzi m_Frm_SuratHesab_HavaleArzi;

			// Token: 0x040000A7 RID: 167
			public Frm_SuratHesab_Hazine m_Frm_SuratHesab_Hazine;

			// Token: 0x040000A8 RID: 168
			public Frm_SuratHesab_kargari m_Frm_SuratHesab_kargari;

			// Token: 0x040000A9 RID: 169
			public Frm_SuratHesab_Kharid m_Frm_SuratHesab_Kharid;

			// Token: 0x040000AA RID: 170
			public Frm_SuratHesab_KharidFurush m_Frm_SuratHesab_KharidFurush;

			// Token: 0x040000AB RID: 171
			public Frm_SuratHesab_Moshtari m_Frm_SuratHesab_Moshtari;

			// Token: 0x040000AC RID: 172
			public Frm_SuratHesab_Sandugh m_Frm_SuratHesab_Sandugh;

			// Token: 0x040000AD RID: 173
			public Frm_SuratHesab_Sharik m_Frm_SuratHesab_Sharik;

			// Token: 0x040000AE RID: 174
			public Frm_SuratHesab_Tafavot m_Frm_SuratHesab_Tafavot;

			// Token: 0x040000AF RID: 175
			public Frm_SuratHesab_Takhlie m_Frm_SuratHesab_Takhlie;

			// Token: 0x040000B0 RID: 176
			public Frm_SuratHesab_Takhlie2 m_Frm_SuratHesab_Takhlie2;

			// Token: 0x040000B1 RID: 177
			public Frm_SuratHesab_Tankhah m_Frm_SuratHesab_Tankhah;

			// Token: 0x040000B2 RID: 178
			public Frm_SuratHesab_Vam m_Frm_SuratHesab_Vam;

			// Token: 0x040000B3 RID: 179
			public Frm_TedadKala m_Frm_TedadKala;

			// Token: 0x040000B4 RID: 180
			public Frm_User_Admin m_Frm_User_Admin;

			// Token: 0x040000B5 RID: 181
			public Frm_Varedat m_Frm_Varedat;

			// Token: 0x040000B6 RID: 182
			public Frm_Vusul_Check m_Frm_Vusul_Check;

			// Token: 0x040000B7 RID: 183
			public Frm_Vusul_Checkd m_Frm_Vusul_Checkd;

			// Token: 0x040000B8 RID: 184
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x0600017A RID: 378 RVA: 0x00154DA8 File Offset: 0x001531A8
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00154DC8 File Offset: 0x001531C8
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00154DE0 File Offset: 0x001531E0
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00154DFC File Offset: 0x001531FC
			[DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00154E14 File Offset: 0x00153214
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00154E40 File Offset: 0x00153240
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000180 RID: 384 RVA: 0x00154E60 File Offset: 0x00153260
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000181 RID: 385 RVA: 0x00154E6C File Offset: 0x0015326C
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00154EA0 File Offset: 0x001532A0
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x040000B9 RID: 185
			[ThreadStatic, CompilerGenerated]
			private static T m_ThreadStaticValue;
		}
	}
}
