using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000073 RID: 115
	[DesignerGenerated]
	public partial class Frm_Register : Form
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x00183FF0 File Offset: 0x001823F0
		public Frm_Register()
		{
			base.Load += new EventHandler(this.Frm_Register_Load);
			Frm_Register.__ENCAddToList(this);
			this.fp = new fp();
			this.InitializeComponent();
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00184028 File Offset: 0x00182428
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Register.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Register.__ENCList.Count == Frm_Register.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Register.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Register.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Register.__ENCList[num] = Frm_Register.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Register.__ENCList.RemoveRange(num, Frm_Register.__ENCList.Count - num);
						Frm_Register.__ENCList.Capacity = Frm_Register.__ENCList.Count;
					}
					Frm_Register.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00185164 File Offset: 0x00183564
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0018517C File Offset: 0x0018357C
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00185188 File Offset: 0x00183588
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x001851A0 File Offset: 0x001835A0
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

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x001851AC File Offset: 0x001835AC
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x001851C4 File Offset: 0x001835C4
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x001851D0 File Offset: 0x001835D0
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x001851E8 File Offset: 0x001835E8
		internal virtual EditBox EditBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox2_Leave);
				EventHandler value3 = new EventHandler(this.EditBox2_Enter);
				bool flag = this._EditBox2 != null;
				if (flag)
				{
					this._EditBox2.Leave -= value2;
					this._EditBox2.Enter -= value3;
				}
				this._EditBox2 = value;
				flag = (this._EditBox2 != null);
				if (flag)
				{
					this._EditBox2.Leave += value2;
					this._EditBox2.Enter += value3;
				}
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00185270 File Offset: 0x00183670
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00185288 File Offset: 0x00183688
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x001852E8 File Offset: 0x001836E8
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00185300 File Offset: 0x00183700
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00185360 File Offset: 0x00183760
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00185378 File Offset: 0x00183778
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00185384 File Offset: 0x00183784
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0018539C File Offset: 0x0018379C
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox1 = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x001853A8 File Offset: 0x001837A8
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x001853C0 File Offset: 0x001837C0
		internal virtual EditBox txt_head2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_head2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_head2 = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x001853CC File Offset: 0x001837CC
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x001853E4 File Offset: 0x001837E4
		internal virtual EditBox txt_head1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_head1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_head1 = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x001853F0 File Offset: 0x001837F0
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00185408 File Offset: 0x00183808
		internal virtual EditBox txt_company
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_company;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_company = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00185414 File Offset: 0x00183814
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0018542C File Offset: 0x0018382C
		internal virtual UIGroupBox UiGroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox4 = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00185438 File Offset: 0x00183838
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00185450 File Offset: 0x00183850
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0018545C File Offset: 0x0018385C
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00185474 File Offset: 0x00183874
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00185480 File Offset: 0x00183880
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00185498 File Offset: 0x00183898
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

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x001854A4 File Offset: 0x001838A4
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x001854BC File Offset: 0x001838BC
		internal virtual Label lbl_head2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_head2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_head2 = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x001854C8 File Offset: 0x001838C8
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x001854E0 File Offset: 0x001838E0
		internal virtual Label lbl_head1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_head1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_head1 = value;
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x001854EC File Offset: 0x001838EC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton2_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x001854F8 File Offset: 0x001838F8
		private void Frm_Register_Load(object sender, EventArgs e)
		{
			this.EditBox1.Text = this.fp.Value();
			Clipboard.SetText(this.EditBox1.Text);
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select value from setting where [key]=" + Public_Function.GetValue("head1")));
			bool flag = text != null && Operators.CompareString(text, "نسخه نمایشی", false) != 0 && Operators.CompareString(text, "", false) != 0;
			if (flag)
			{
				this.txt_head1.Visible = false;
				this.Label7.Visible = false;
				this.lbl_head1.Visible = false;
			}
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select value from setting where [key]=" + Public_Function.GetValue("head2")));
			flag = (text2 != null && Operators.CompareString(text2, "نسخه نمایشی", false) != 0 && Operators.CompareString(text2, "", false) != 0);
			if (flag)
			{
				this.txt_head2.Visible = false;
				this.Label8.Visible = false;
				this.lbl_head2.Visible = false;
			}
			flag = (!this.txt_head1.Visible && !this.txt_head2.Visible);
			if (flag)
			{
				this.UiGroupBox4.Visible = false;
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00185644 File Offset: 0x00183A44
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_head1.Visible;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(this.txt_head1.Text, string.Empty, false) == 0);
				if (flag2)
				{
					this.txt_head1.ShowTip("سربرگ را وارد نمایید");
					return;
				}
			}
			flag2 = this.txt_head2.Visible;
			if (flag2)
			{
				flag = (Operators.CompareString(this.txt_head2.Text, string.Empty, false) == 0);
				if (flag)
				{
					this.txt_head2.ShowTip("سربرگ را وارد نمایید");
					return;
				}
			}
			string text = this.EditBox2.Text.ToUpper();
			text = text.Replace("_", "-");
			flag2 = (Operators.CompareString(text, this.fp.Value2(this.EditBox1.Text), false) == 0);
			if (flag2)
			{
				flag = (Public_Function.AppType == 1 | Public_Function.AppType == 3);
				if (flag)
				{
					try
					{
						File.WriteAllText(Application.StartupPath + "\\fr.snk", text);
					}
					catch (Exception expr_10E)
					{
						ProjectData.SetProjectError(expr_10E);
						Frm_RegHelp frm_RegHelp = new Frm_RegHelp();
						frm_RegHelp.ShowDialog();
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					File.WriteAllText(Application.StartupPath + "\\fr2.snk", text);
				}
				try
				{
					setting setting = new setting();
					flag2 = this.txt_head1.Visible;
					if (flag2)
					{
						setting.Update("head1", this.txt_head1.Text);
					}
					flag2 = this.txt_head2.Visible;
					if (flag2)
					{
						setting.Update("head2", this.txt_head2.Text);
					}
					flag2 = this.txt_head1.Visible;
					if (flag2)
					{
						setting.Update("owner", this.txt_head1.Text);
					}
					ProjectData.EndApp();
				}
				catch (Exception expr_1CF)
				{
					ProjectData.SetProjectError(expr_1CF);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				Public_Function.ShowMessage("سریال فعال سازی اشتباه می باشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				this.EditBox2.Focus();
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00185870 File Offset: 0x00183C70
		private void EditBox2_Enter(object sender, EventArgs e)
		{
			Public_Function.SetEnglish();
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0018587C File Offset: 0x00183C7C
		private void EditBox2_Leave(object sender, EventArgs e)
		{
			Public_Function.SetFarsi();
		}

		// Token: 0x0400037D RID: 893
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400037F RID: 895
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000380 RID: 896
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000381 RID: 897
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000382 RID: 898
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x04000383 RID: 899
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000384 RID: 900
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000385 RID: 901
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000386 RID: 902
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04000387 RID: 903
		[AccessedThroughProperty("txt_head2")]
		private EditBox _txt_head2;

		// Token: 0x04000388 RID: 904
		[AccessedThroughProperty("txt_head1")]
		private EditBox _txt_head1;

		// Token: 0x04000389 RID: 905
		[AccessedThroughProperty("txt_company")]
		private EditBox _txt_company;

		// Token: 0x0400038A RID: 906
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x0400038B RID: 907
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400038C RID: 908
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400038D RID: 909
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400038E RID: 910
		[AccessedThroughProperty("lbl_head2")]
		private Label _lbl_head2;

		// Token: 0x0400038F RID: 911
		[AccessedThroughProperty("lbl_head1")]
		private Label _lbl_head1;

		// Token: 0x04000390 RID: 912
		private fp fp;
	}
}
