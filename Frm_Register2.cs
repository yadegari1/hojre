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
	// Token: 0x02000074 RID: 116
	[DesignerGenerated]
	public partial class Frm_Register2 : Form
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x00185898 File Offset: 0x00183C98
		public Frm_Register2()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_Secure_FormClosing);
			base.Load += new EventHandler(this.Frm_Register2_Load);
			Frm_Register2.__ENCAddToList(this);
			int days = -1;
			this.days = days;
			bool continueto = false;
			this.continueto = continueto;
			this.lic_dict = new Dictionary<string, bool>();
			this.b = true;
			this.InitializeComponent();
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0018590C File Offset: 0x00183D0C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Register2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Register2.__ENCList.Count == Frm_Register2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Register2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Register2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Register2.__ENCList[num] = Frm_Register2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Register2.__ENCList.RemoveRange(num, Frm_Register2.__ENCList.Count - num);
						Frm_Register2.__ENCList.Capacity = Frm_Register2.__ENCList.Count;
					}
					Frm_Register2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00186D44 File Offset: 0x00185144
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00186D5C File Offset: 0x0018515C
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

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00186D68 File Offset: 0x00185168
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00186D80 File Offset: 0x00185180
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
				EventHandler value2 = new EventHandler(this.UiGroupBox2_Click);
				bool flag = this._UiGroupBox2 != null;
				if (flag)
				{
					this._UiGroupBox2.Click -= value2;
				}
				this._UiGroupBox2 = value;
				flag = (this._UiGroupBox2 != null);
				if (flag)
				{
					this._UiGroupBox2.Click += value2;
				}
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00186DE0 File Offset: 0x001851E0
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00186DF8 File Offset: 0x001851F8
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00186E04 File Offset: 0x00185204
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00186E1C File Offset: 0x0018521C
		internal virtual Label txt_days
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_days;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_days = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00186E28 File Offset: 0x00185228
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00186E40 File Offset: 0x00185240
		internal virtual Label txt_days0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_days0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_days0 = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00186E4C File Offset: 0x0018524C
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00186E64 File Offset: 0x00185264
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

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00186EC4 File Offset: 0x001852C4
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00186EDC File Offset: 0x001852DC
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

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00186F3C File Offset: 0x0018533C
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00186F54 File Offset: 0x00185354
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00186F60 File Offset: 0x00185360
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00186F78 File Offset: 0x00185378
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00186F84 File Offset: 0x00185384
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00186F9C File Offset: 0x0018539C
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00186FA8 File Offset: 0x001853A8
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00186FC0 File Offset: 0x001853C0
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00186FCC File Offset: 0x001853CC
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00186FE4 File Offset: 0x001853E4
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00186FF0 File Offset: 0x001853F0
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00187008 File Offset: 0x00185408
		internal virtual Label txt_precode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_precode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_precode = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00187014 File Offset: 0x00185414
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0018702C File Offset: 0x0018542C
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0018708C File Offset: 0x0018548C
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x001870A4 File Offset: 0x001854A4
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x001870B0 File Offset: 0x001854B0
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x001870C8 File Offset: 0x001854C8
		internal virtual Label txt_installdate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_installdate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_installdate = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x001870D4 File Offset: 0x001854D4
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x001870EC File Offset: 0x001854EC
		internal virtual EditBox txt_code
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_code;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_code = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x001870F8 File Offset: 0x001854F8
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00187110 File Offset: 0x00185510
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0018711C File Offset: 0x0018551C
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00187134 File Offset: 0x00185534
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00187140 File Offset: 0x00185540
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00187158 File Offset: 0x00185558
		internal virtual Label txt_owner
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_owner;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_owner = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00187164 File Offset: 0x00185564
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0018717C File Offset: 0x0018557C
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00187188 File Offset: 0x00185588
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x001871A0 File Offset: 0x001855A0
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x001871AC File Offset: 0x001855AC
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x001871C4 File Offset: 0x001855C4
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00187224 File Offset: 0x00185624
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x0018723C File Offset: 0x0018563C
		public int days
		{
			[DebuggerNonUserCode]
			get
			{
				return this._days;
			}
			[DebuggerNonUserCode]
			set
			{
				this._days = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00187248 File Offset: 0x00185648
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00187260 File Offset: 0x00185660
		private bool continueto
		{
			[DebuggerNonUserCode]
			get
			{
				return this._continueto;
			}
			[DebuggerNonUserCode]
			set
			{
				this._continueto = value;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0018726C File Offset: 0x0018566C
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton2_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00187278 File Offset: 0x00185678
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_code.Text, string.Empty, false) == 0;
			if (!flag)
			{
				fp fp = new fp();
				string text = string.Empty;
				try
				{
					Dictionary<string, bool>.Enumerator enumerator = this.lic_dict.GetEnumerator();
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, bool> current = enumerator.Current;
						flag = !current.Value;
						if (flag)
						{
							text = current.Key;
							break;
						}
					}
				}
				finally
				{
					Dictionary<string, bool>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				string text2 = this.txt_code.Text.ToUpper();
				text2 = text2.Replace("_", "-");
				flag = fp.Check_licy(text, text2);
				if (flag)
				{
					try
					{
						File.AppendAllText(Application.StartupPath + "\\fr3.snk", text + ":" + text2 + Environment.NewLine);
						Application.Restart();
					}
					catch (Exception expr_E6)
					{
						ProjectData.SetProjectError(expr_E6);
						Frm_RegHelp frm_RegHelp = new Frm_RegHelp();
						frm_RegHelp.ShowDialog();
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x001873AC File Offset: 0x001857AC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Frm_Secure_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.continueto;
			if (flag)
			{
				ProjectData.EndApp();
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x001873D0 File Offset: 0x001857D0
		private void Frm_Register2_Load(object sender, EventArgs e)
		{
			this.txt_owner.Text = Public_Function.dict["owner"];
			this.txt_installdate.Text = Public_Function.MiladiToShamsi(Conversions.ToDate(Public_Function.dict["installdate"]));
			fp fp = new fp();
			string str = string.Empty;
			bool flag;
			try
			{
				Dictionary<string, bool>.Enumerator enumerator = this.lic_dict.GetEnumerator();
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, bool> current = enumerator.Current;
					flag = !current.Value;
					if (flag)
					{
						str = current.Key;
						break;
					}
				}
			}
			finally
			{
				Dictionary<string, bool>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.txt_precode.Text = fp.GetPreCode() + "-" + str;
			flag = (this.days != -1);
			if (flag)
			{
				this.txt_days.Text = Conversions.ToString(this.days);
				this.UiButton3.Visible = true;
			}
			else
			{
				this.txt_days.Visible = false;
				this.txt_days0.Visible = false;
				this.UiButton3.Visible = false;
				flag = (this.lic_dict.Count == 1);
				if (flag)
				{
				}
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00187524 File Offset: 0x00185924
		private void UiButton3_Click(object sender, EventArgs e)
		{
			this.continueto = true;
			this.Close();
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00187538 File Offset: 0x00185938
		private void UiGroupBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0018753C File Offset: 0x0018593C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this.b;
			if (flag)
			{
				this.Label7.ForeColor = Color.Red;
				this.b = false;
			}
			else
			{
				this.b = true;
				this.Label7.ForeColor = Color.Black;
			}
		}

		// Token: 0x04000391 RID: 913
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000393 RID: 915
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000394 RID: 916
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000395 RID: 917
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000396 RID: 918
		[AccessedThroughProperty("txt_days")]
		private Label _txt_days;

		// Token: 0x04000397 RID: 919
		[AccessedThroughProperty("txt_days0")]
		private Label _txt_days0;

		// Token: 0x04000398 RID: 920
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000399 RID: 921
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x0400039A RID: 922
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400039B RID: 923
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400039C RID: 924
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400039D RID: 925
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400039E RID: 926
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400039F RID: 927
		[AccessedThroughProperty("txt_precode")]
		private Label _txt_precode;

		// Token: 0x040003A0 RID: 928
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040003A1 RID: 929
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040003A2 RID: 930
		[AccessedThroughProperty("txt_installdate")]
		private Label _txt_installdate;

		// Token: 0x040003A3 RID: 931
		[AccessedThroughProperty("txt_code")]
		private EditBox _txt_code;

		// Token: 0x040003A4 RID: 932
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003A5 RID: 933
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003A6 RID: 934
		[AccessedThroughProperty("txt_owner")]
		private Label _txt_owner;

		// Token: 0x040003A7 RID: 935
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040003A8 RID: 936
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040003A9 RID: 937
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040003AA RID: 938
		[CompilerGenerated]
		private int _days;

		// Token: 0x040003AB RID: 939
		[CompilerGenerated]
		private bool _continueto;

		// Token: 0x040003AC RID: 940
		public Dictionary<string, bool> lic_dict;

		// Token: 0x040003AD RID: 941
		private bool b;
	}
}
