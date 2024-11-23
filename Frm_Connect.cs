using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000065 RID: 101
	[DesignerGenerated]
	public partial class Frm_Connect : Form
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x00176388 File Offset: 0x00174788
		[DebuggerNonUserCode]
		public Frm_Connect()
		{
			base.Activated += new EventHandler(this.Frm_Connect_Activated);
			base.Load += new EventHandler(this.Frm_Connect_Load);
			Frm_Connect.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x001763C8 File Offset: 0x001747C8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Connect.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Connect.__ENCList.Count == Frm_Connect.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Connect.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Connect.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Connect.__ENCList[num] = Frm_Connect.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Connect.__ENCList.RemoveRange(num, Frm_Connect.__ENCList.Count - num);
						Frm_Connect.__ENCList.Capacity = Frm_Connect.__ENCList.Count;
					}
					Frm_Connect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00176C60 File Offset: 0x00175060
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00176C78 File Offset: 0x00175078
		internal virtual PanelEx PanelEx1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx1 = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00176C84 File Offset: 0x00175084
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00176C9C File Offset: 0x0017509C
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

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00176CA8 File Offset: 0x001750A8
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x00176CC0 File Offset: 0x001750C0
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00176CCC File Offset: 0x001750CC
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00176CE4 File Offset: 0x001750E4
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00176D44 File Offset: 0x00175144
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00176D5C File Offset: 0x0017515C
		internal virtual UIButton btn_ViewError
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_ViewError;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_ViewError_Click);
				bool flag = this._btn_ViewError != null;
				if (flag)
				{
					this._btn_ViewError.Click -= value2;
				}
				this._btn_ViewError = value;
				flag = (this._btn_ViewError != null);
				if (flag)
				{
					this._btn_ViewError.Click += value2;
				}
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00176DBC File Offset: 0x001751BC
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00176DD4 File Offset: 0x001751D4
		internal virtual UIButton btn_try
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_try;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_try_Click);
				bool flag = this._btn_try != null;
				if (flag)
				{
					this._btn_try.Click -= value2;
				}
				this._btn_try = value;
				flag = (this._btn_try != null);
				if (flag)
				{
					this._btn_try.Click += value2;
				}
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00176E34 File Offset: 0x00175234
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00176E4C File Offset: 0x0017524C
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00176EAC File Offset: 0x001752AC
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00176EC4 File Offset: 0x001752C4
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

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00176ED0 File Offset: 0x001752D0
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00176EE8 File Offset: 0x001752E8
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00176EF4 File Offset: 0x001752F4
		private void Frm_Connect_Activated(object sender, EventArgs e)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00176EF8 File Offset: 0x001752F8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			try
			{
				ServiceController serviceController = new ServiceController("MSSQL$FRUITBOX");
				Public_Function.ShowMessage("starting service...", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk, null);
				serviceController.Start();
				Application.Restart();
			}
			catch (Exception expr_38)
			{
				ProjectData.SetProjectError(expr_38);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00176F60 File Offset: 0x00175360
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton3_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			ProjectData.EndApp();
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00176F74 File Offset: 0x00175374
		private void btn_try_Click(object sender, EventArgs e)
		{
			try
			{
				Public_Function.Connection.Open();
				this.Close();
			}
			catch (Exception expr_16)
			{
				ProjectData.SetProjectError(expr_16);
				Public_Function.ShowMessage("امکان ارتباط با بانک اطلاعاتی وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00176FC8 File Offset: 0x001753C8
		private void btn_ViewError_Click(object sender, EventArgs e)
		{
			Public_Function.ShowMessage(this.err, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00176FDC File Offset: 0x001753DC
		private void Frm_Connect_Load(object sender, EventArgs e)
		{
			this.PictureBox1.Image = Resources.Data_Connect;
		}

		// Token: 0x040002B7 RID: 695
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002B9 RID: 697
		[AccessedThroughProperty("PanelEx1")]
		private PanelEx _PanelEx1;

		// Token: 0x040002BA RID: 698
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040002BB RID: 699
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040002BC RID: 700
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040002BD RID: 701
		[AccessedThroughProperty("btn_ViewError")]
		private UIButton _btn_ViewError;

		// Token: 0x040002BE RID: 702
		[AccessedThroughProperty("btn_try")]
		private UIButton _btn_try;

		// Token: 0x040002BF RID: 703
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040002C0 RID: 704
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040002C1 RID: 705
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040002C2 RID: 706
		private string err;
	}
}
