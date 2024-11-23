using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000075 RID: 117
	[DesignerGenerated]
	public partial class Frm_Restore : Form
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x0018759C File Offset: 0x0018599C
		[DebuggerNonUserCode]
		public Frm_Restore()
		{
			Frm_Restore.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x001875B4 File Offset: 0x001859B4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Restore.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Restore.__ENCList.Count == Frm_Restore.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Restore.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Restore.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Restore.__ENCList[num] = Frm_Restore.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Restore.__ENCList.RemoveRange(num, Frm_Restore.__ENCList.Count - num);
						Frm_Restore.__ENCList.Capacity = Frm_Restore.__ENCList.Count;
					}
					Frm_Restore.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00187C78 File Offset: 0x00186078
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00187C90 File Offset: 0x00186090
		internal virtual PanelEx PanelEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx2 = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00187C9C File Offset: 0x0018609C
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00187CB4 File Offset: 0x001860B4
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00187CC0 File Offset: 0x001860C0
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00187CD8 File Offset: 0x001860D8
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00187CE4 File Offset: 0x001860E4
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00187CFC File Offset: 0x001860FC
		internal virtual CircularProgress CircularProgress1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CircularProgress1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CircularProgress1 = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00187D08 File Offset: 0x00186108
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00187D20 File Offset: 0x00186120
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00187D80 File Offset: 0x00186180
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00187D98 File Offset: 0x00186198
		internal virtual Timer Timer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				bool flag = this._Timer2 != null;
				if (flag)
				{
					this._Timer2.Tick -= value2;
				}
				this._Timer2 = value;
				flag = (this._Timer2 != null);
				if (flag)
				{
					this._Timer2.Tick += value2;
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00187DF8 File Offset: 0x001861F8
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00187E10 File Offset: 0x00186210
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00187E1C File Offset: 0x0018621C
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00187E34 File Offset: 0x00186234
		public string Path
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Path;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Path = value;
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00187E40 File Offset: 0x00186240
		private void RestoreBackup(string OldDBName, string fileName)
		{
			string mConnection = string.Format(string.Concat(new string[]
			{
				"Provider=SQLOLEDB.1;Data Source=",
				Public_Function.Server,
				"\\",
				Public_Function.SQLInstance,
				";Initial Catalog=master;Persist Security Info=True;User ID=sa;password=1;Connect Timeout=10000"
			}), new object[0]);
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"declare @cmd varchar(20);declare @spid varchar(4);declare cur cursor for select cast(spid as varchar(4)) from master.dbo.sysprocesses  where dbid=db_id(" + Public_Function.GetValue(OldDBName) + ") open cur  fetch next from cur into @spid while @@fetch_status=0 begin  set @cmd='kill ' + @spid exec (@cmd)  fetch next from cur into @spid  end  close cur deallocate cur USE Master RESTORE DATABASE ",
				OldDBName,
				" FROM  DISK = N'",
				fileName,
				"' WITH  FILE = 1,   NOUNLOAD,  REPLACE,  STATS = 10"
			}), mConnection);
			Public_Function.Connection = new SqlConnection(string.Concat(new string[]
			{
				"Data Source=",
				Public_Function.Server,
				"\\",
				Public_Function.SQLInstance,
				";Initial Catalog=",
				OldDBName,
				";Persist Security Info=True;User ID=sa;Password=1"
			}));
			Public_Function.Connection.Open();
			Public_Function.dict.Clear();
			Public_Function.LoadApplicationSetting();
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00187F50 File Offset: 0x00186350
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.RestoreBackup(Public_Function.dict["dbname"], this.Path);
			this.Timer2.Enabled = false;
			Public_Function.ShowMessage("بازیابی اطلاعات با موفقیت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			this.Close();
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00187FAC File Offset: 0x001863AC
		private void Timer2_Tick(object sender, EventArgs e)
		{
			bool flag = this.CircularProgress1.get_Value() == 100;
			if (flag)
			{
				this.CircularProgress1.set_Value(0);
			}
			CircularProgress circularProgress = this.CircularProgress1;
			circularProgress.set_Value(checked(circularProgress.get_Value() + 10));
		}

		// Token: 0x040003AE RID: 942
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040003B0 RID: 944
		[AccessedThroughProperty("PanelEx2")]
		private PanelEx _PanelEx2;

		// Token: 0x040003B1 RID: 945
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003B2 RID: 946
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003B3 RID: 947
		[AccessedThroughProperty("CircularProgress1")]
		private CircularProgress _CircularProgress1;

		// Token: 0x040003B4 RID: 948
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040003B5 RID: 949
		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		// Token: 0x040003B6 RID: 950
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040003B7 RID: 951
		[CompilerGenerated]
		private string _Path;
	}
}
