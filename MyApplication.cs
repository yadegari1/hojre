using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox.My
{
	// Token: 0x02000002 RID: 2
	[EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("MyTemplate", "8.0.0.0")]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0014F1F8 File Offset: 0x0014D5F8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = MyApplication.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = MyApplication.__ENCList.Count == MyApplication.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = MyApplication.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = MyApplication.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									MyApplication.__ENCList[num] = MyApplication.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						MyApplication.__ENCList.RemoveRange(num, MyApplication.__ENCList.Count - num);
						MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count;
					}
					MyApplication.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0014F2FC File Offset: 0x0014D6FC
		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerHidden, STAThread]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0014F338 File Offset: 0x0014D738
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ShowSplash1()
		{
			bool flag = !File.Exists(Public_Function.Startup_Path() + "\\server.txt");
			if (flag)
			{
				Public_Function.Server = ".";
				Public_Function.SQLInstance = "fruitbox";
			}
			else
			{
				string[] array = File.ReadAllLines(Public_Function.Startup_Path() + "\\server.txt");
				flag = (array.Length > 0);
				if (flag)
				{
					Public_Function.Server = array[0];
				}
				flag = (array.Length > 1);
				if (flag)
				{
					Public_Function.SQLInstance = array[1];
				}
				else
				{
					Public_Function.SQLInstance = "fruitbox";
				}
			}
			Frm_Splash frm_Splash = new Frm_Splash();
			frm_Splash.Show();
			bool flag2 = false;
			MyProject.Application.DoEvents();
			try
			{
				CultureInfo currentCulture = new CultureInfo("en-US", false);
				Thread.CurrentThread.CurrentCulture = currentCulture;
				flag = !Public_Function.DBExist();
				if (flag)
				{
					frm_Splash.Label1.Text = "مقدار دهی اولیه";
					flag2 = true;
					Public_Function.FirstRun();
				}
				frm_Splash.Label1.Text = "اتصال به پایگاه داده";
				frm_Splash.Label1.Refresh();
				flag = !File.Exists(Public_Function.Startup_Path() + "\\db.txt");
				if (flag)
				{
					Public_Function.Connection = new SqlConnection(string.Concat(new string[]
					{
						"Data Source=",
						Public_Function.Server,
						"\\",
						Public_Function.SQLInstance,
						";Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=1"
					}));
					Public_Function.Connection.Open();
					DataTable dataTable = Public_Function.FillData("select * from sys.databases where name like 'fruitbox%' order by name");
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							MyProject.Forms.Form_Main.txt_database.get_Items().Add(Conversions.ToString(dataRow["name"]), RuntimeHelpers.GetObjectValue(dataRow["name"]));
						}
					}
					finally
					{
						IEnumerator enumerator;
						flag = (enumerator is IDisposable);
						if (flag)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					flag = (dataTable.Rows.Count == 1);
					if (flag)
					{
						MyProject.Forms.Form_Main.Label9.Visible = false;
						MyProject.Forms.Form_Main.txt_database.Visible = false;
					}
					else
					{
						MyProject.Forms.Form_Main.Label9.Visible = true;
						MyProject.Forms.Form_Main.txt_database.Visible = true;
					}
					Public_Function.Connection.Close();
				}
				else
				{
					string[] array2 = File.ReadAllLines(Public_Function.Startup_Path() + "\\db.txt");
					flag = (array2.Length > 0);
					if (flag)
					{
						MyProject.Forms.Form_Main.txt_database.get_Items().Add(array2[0], array2[0]);
						MyProject.Forms.Form_Main.Label9.Visible = false;
						MyProject.Forms.Form_Main.txt_database.Visible = false;
					}
				}
				MyProject.Forms.Form_Main.txt_database.remove_SelectedValueChanged(new EventHandler(MyProject.Forms.Form_Main.txt_database_SelectedValueChanged));
				MyProject.Forms.Form_Main.txt_database.set_SelectedIndex(checked(MyProject.Forms.Form_Main.txt_database.get_Items().Count - 1));
				MyProject.Forms.Form_Main.txt_database.add_SelectedValueChanged(new EventHandler(MyProject.Forms.Form_Main.txt_database_SelectedValueChanged));
				Public_Function.Connection = new SqlConnection(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Data Source=" + Public_Function.Server + "\\" + Public_Function.SQLInstance + ";Initial Catalog=", MyProject.Forms.Form_Main.txt_database.get_SelectedValue()), ";Persist Security Info=True;User ID=sa;Password=1")));
				Public_Function.Connection.Open();
				flag = flag2;
				if (flag)
				{
					CreateDB createDB = new CreateDB();
					createDB.init_first_db();
				}
				frm_Splash.Label1.Text = "بارگذاری تنظیمات برنامه";
				frm_Splash.Label1.Refresh();
				Public_Function.LoadApplicationSetting();
				flag = Public_Function.dict.ContainsKey("hlt");
				bool flag4;
				if (flag)
				{
					bool flag3 = Conversions.ToBoolean(Public_Function.dict["hlt"]);
					if (flag3)
					{
						try
						{
							flag4 = File.Exists(Public_Function.Startup_Path() + "\\fr.snk");
							if (flag4)
							{
								File.Delete(Public_Function.Startup_Path() + "\\fr.snk");
							}
						}
						catch (Exception expr_491)
						{
							ProjectData.SetProjectError(expr_491);
							ProjectData.ClearProjectError();
						}
						Application.Exit();
						ProjectData.EndApp();
					}
				}
				frm_Splash.lbl_owner.Text = Public_Function.dict["owner"];
				frm_Splash.lbl_owner.Refresh();
				frm_Splash.Label1.Text = "بارگذاری اطلاعات پایه";
				frm_Splash.Label1.Refresh();
				AppRun appRun = new AppRun();
				appRun.mmm();
				Initdb initdb = new Initdb();
				initdb.InitDb1();
				initdb.initdb2();
				initdb.InitDB3();
				initdb.Create_Deleted_Objects();
				initdb.Initdir();
				flag4 = Conversions.ToBoolean(Public_Function.dict["fullscreen"]);
				if (flag4)
				{
					MyProject.Forms.Form_Main.FormBorderStyle = FormBorderStyle.None;
				}
				else
				{
					MyProject.Forms.Form_Main.FormBorderStyle = FormBorderStyle.Sizable;
				}
				flag4 = Conversions.ToBoolean(Public_Function.dict["showstatus"]);
				if (flag4)
				{
					MyProject.Forms.Form_Main.RibbonStatusBar1.Visible = true;
				}
				else
				{
					MyProject.Forms.Form_Main.RibbonStatusBar1.Visible = false;
				}
				MyProject.Application.MainForm = MyProject.Forms.Form_Main;
				frm_Splash.Close();
			}
			catch (Exception expr_5D8)
			{
				ProjectData.SetProjectError(expr_5D8);
				Exception ex = expr_5D8;
				Public_Function.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				MyProject.Application.MainForm = MyProject.Forms.Frm_Connect;
				MyProject.Forms.Frm_Connect.Show();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0014F9B4 File Offset: 0x0014DDB4
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ShowSplash2()
		{
			bool flag = !File.Exists(Public_Function.Startup_Path() + "\\server.txt");
			if (flag)
			{
				Public_Function.Server = ".";
				Public_Function.SQLInstance = "fruitbox";
			}
			else
			{
				string[] array = File.ReadAllLines(Public_Function.Startup_Path() + "\\server.txt");
				flag = (array.Length > 0);
				if (flag)
				{
					Public_Function.Server = array[0];
				}
				flag = (array.Length > 1);
				if (flag)
				{
					Public_Function.SQLInstance = array[1];
				}
				else
				{
					Public_Function.SQLInstance = "fruitbox";
				}
			}
			Frm_Splash2 frm_Splash = new Frm_Splash2();
			frm_Splash.Show();
			bool flag2 = false;
			MyProject.Application.DoEvents();
			try
			{
				CultureInfo currentCulture = new CultureInfo("en-US", false);
				Thread.CurrentThread.CurrentCulture = currentCulture;
				flag = !Public_Function.DBExist();
				if (flag)
				{
					frm_Splash.Label1.Text = "مقدار دهی اولیه";
					flag2 = true;
					Public_Function.FirstRun();
				}
				frm_Splash.Label1.Text = "اتصال به پایگاه داده";
				frm_Splash.Label1.Refresh();
				Public_Function.Connection = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					Public_Function.Server,
					"\\",
					Public_Function.SQLInstance,
					";Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=1"
				}));
				Public_Function.Connection.Open();
				DataTable dataTable = Public_Function.FillData("select * from sys.databases where name like 'fruitbox%' order by name");
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						MyProject.Forms.Form_Main.txt_database.get_Items().Add(Conversions.ToString(dataRow["name"]), RuntimeHelpers.GetObjectValue(dataRow["name"]));
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				flag = (dataTable.Rows.Count == 1);
				if (flag)
				{
					MyProject.Forms.Form_Main.Label9.Visible = false;
					MyProject.Forms.Form_Main.txt_database.Visible = false;
				}
				else
				{
					MyProject.Forms.Form_Main.Label9.Visible = true;
					MyProject.Forms.Form_Main.txt_database.Visible = true;
				}
				MyProject.Forms.Form_Main.txt_database.remove_SelectedValueChanged(new EventHandler(MyProject.Forms.Form_Main.txt_database_SelectedValueChanged));
				MyProject.Forms.Form_Main.txt_database.set_SelectedIndex(checked(MyProject.Forms.Form_Main.txt_database.get_Items().Count - 1));
				MyProject.Forms.Form_Main.txt_database.add_SelectedValueChanged(new EventHandler(MyProject.Forms.Form_Main.txt_database_SelectedValueChanged));
				Public_Function.Connection.Close();
				Public_Function.Connection = new SqlConnection(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Data Source=" + Public_Function.Server + "\\" + Public_Function.SQLInstance + ";Initial Catalog=", MyProject.Forms.Form_Main.txt_database.get_SelectedValue()), ";Persist Security Info=True;User ID=sa;Password=1")));
				Public_Function.Connection.Open();
				flag = flag2;
				if (flag)
				{
					CreateDB createDB = new CreateDB();
					createDB.init_first_db();
				}
				frm_Splash.Label1.Text = "بارگذاری تنظیمات برنامه";
				frm_Splash.Label1.Refresh();
				Public_Function.LoadApplicationSetting();
				flag = Public_Function.dict.ContainsKey("hlt");
				bool flag4;
				if (flag)
				{
					bool flag3 = Conversions.ToBoolean(Public_Function.dict["hlt"]);
					if (flag3)
					{
						try
						{
							flag4 = File.Exists(Public_Function.Startup_Path() + "\\fr.snk");
							if (flag4)
							{
								File.Delete(Public_Function.Startup_Path() + "\\fr.snk");
							}
						}
						catch (Exception expr_3FB)
						{
							ProjectData.SetProjectError(expr_3FB);
							ProjectData.ClearProjectError();
						}
						Application.Exit();
						ProjectData.EndApp();
					}
				}
				frm_Splash.lbl_owner.Text = Public_Function.dict["owner"];
				frm_Splash.lbl_owner.Refresh();
				frm_Splash.Label1.Text = "بارگذاری اطلاعات پایه";
				frm_Splash.Label1.Refresh();
				AppRun appRun = new AppRun();
				appRun.mmm2();
				Initdb initdb = new Initdb();
				initdb.InitDb1();
				initdb.initdb2();
				initdb.InitDB3();
				initdb.Initdir();
				flag4 = Conversions.ToBoolean(Public_Function.dict["fullscreen"]);
				if (flag4)
				{
					MyProject.Forms.Form_Main.FormBorderStyle = FormBorderStyle.None;
				}
				else
				{
					MyProject.Forms.Form_Main.FormBorderStyle = FormBorderStyle.Sizable;
				}
				flag4 = Conversions.ToBoolean(Public_Function.dict["showstatus"]);
				if (flag4)
				{
					MyProject.Forms.Form_Main.RibbonStatusBar1.Visible = true;
				}
				else
				{
					MyProject.Forms.Form_Main.RibbonStatusBar1.Visible = false;
				}
				MyProject.Application.MainForm = MyProject.Forms.Form_Main;
				frm_Splash.Close();
			}
			catch (Exception expr_53A)
			{
				ProjectData.SetProjectError(expr_53A);
				Exception ex = expr_53A;
				Public_Function.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				MyProject.Application.MainForm = MyProject.Forms.Frm_Connect;
				MyProject.Forms.Frm_Connect.Show();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0014FF90 File Offset: 0x0014E390
		private void MyApplication_Startup(object sender, StartupEventArgs e)
		{
			bool flag = Public_Function.AppType == 1 | Public_Function.AppType == 3;
			if (flag)
			{
				this.ShowSplash1();
			}
			else
			{
				this.ShowSplash2();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0014FFC8 File Offset: 0x0014E3C8
		private void MyApplication_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0014FFCC File Offset: 0x0014E3CC
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			base.Startup += new StartupEventHandler(this.MyApplication_Startup);
			base.StartupNextInstance += new StartupNextInstanceEventHandler(this.MyApplication_StartupNextInstance);
			MyApplication.__ENCAddToList(this);
			this.IsSingleInstance = true;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00150034 File Offset: 0x0014E434
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.Form_Main;
		}

		// Token: 0x04000001 RID: 1
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
