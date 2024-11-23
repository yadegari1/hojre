using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200006F RID: 111
	[DesignerGenerated]
	public partial class Frm_NewVersion : Form
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x00180EA8 File Offset: 0x0017F2A8
		[DebuggerNonUserCode]
		public Frm_NewVersion()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_NewVersion_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_NewVersion_KeyDown);
			base.Load += new EventHandler(this.Frm_NewVersion_Load);
			Frm_NewVersion.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00180F08 File Offset: 0x0017F308
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_NewVersion.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_NewVersion.__ENCList.Count == Frm_NewVersion.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_NewVersion.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_NewVersion.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_NewVersion.__ENCList[num] = Frm_NewVersion.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_NewVersion.__ENCList.RemoveRange(num, Frm_NewVersion.__ENCList.Count - num);
						Frm_NewVersion.__ENCList.Capacity = Frm_NewVersion.__ENCList.Count;
					}
					Frm_NewVersion.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x001818A8 File Offset: 0x0017FCA8
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x001818C0 File Offset: 0x0017FCC0
		internal virtual PanelEx PanelEx3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx3 = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x001818CC File Offset: 0x0017FCCC
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x001818E4 File Offset: 0x0017FCE4
		internal virtual UIButton UiButton11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton11_Click);
				bool flag = this._UiButton11 != null;
				if (flag)
				{
					this._UiButton11.Click -= value2;
				}
				this._UiButton11 = value;
				flag = (this._UiButton11 != null);
				if (flag)
				{
					this._UiButton11.Click += value2;
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00181944 File Offset: 0x0017FD44
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x0018195C File Offset: 0x0017FD5C
		internal virtual UIButton UiButton10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton10_Click);
				bool flag = this._UiButton10 != null;
				if (flag)
				{
					this._UiButton10.Click -= value2;
				}
				this._UiButton10 = value;
				flag = (this._UiButton10 != null);
				if (flag)
				{
					this._UiButton10.Click += value2;
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x001819BC File Offset: 0x0017FDBC
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x001819D4 File Offset: 0x0017FDD4
		internal virtual PictureBox PictureBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox3 = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x001819E0 File Offset: 0x0017FDE0
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x001819F8 File Offset: 0x0017FDF8
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00181A04 File Offset: 0x0017FE04
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00181A1C File Offset: 0x0017FE1C
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00181A28 File Offset: 0x0017FE28
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00181A40 File Offset: 0x0017FE40
		internal virtual TextBox txt_help
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_help;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_help = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00181A4C File Offset: 0x0017FE4C
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00181A64 File Offset: 0x0017FE64
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00181A70 File Offset: 0x0017FE70
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00181A88 File Offset: 0x0017FE88
		internal virtual UICheckBox txt_show
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_show;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_show = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00181A94 File Offset: 0x0017FE94
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00181AAC File Offset: 0x0017FEAC
		public string Version
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Version;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00181AB8 File Offset: 0x0017FEB8
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00181AD0 File Offset: 0x0017FED0
		public string HelpText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HelpText;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HelpText = value;
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00181ADC File Offset: 0x0017FEDC
		private void UiButton11_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00181AE8 File Offset: 0x0017FEE8
		private void UiButton10_Click(object sender, EventArgs e)
		{
			string fileName = "https://www.tazminco.ir";
			Process.Start(fileName);
			this.Close();
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00181B0C File Offset: 0x0017FF0C
		private void Frm_NewVersion_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			setting.Update("show_newversion", Conversions.ToString(!this.txt_show.get_Checked()));
			Public_Function.dict["show_newversion"] = Conversions.ToString(!this.txt_show.get_Checked());
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00181B64 File Offset: 0x0017FF64
		private void Frm_NewVersion_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00181B8C File Offset: 0x0017FF8C
		private void Frm_NewVersion_Load(object sender, EventArgs e)
		{
			string text = "نسخه " + this.Version + " نرم افزار منتشر شد";
			this.Label10.Text = text;
			string[] array = this.HelpText.Split(new char[]
			{
				Conversions.ToChar(Environment.NewLine)
			});
			this.txt_help.Text = this.HelpText;
		}

		// Token: 0x0400034A RID: 842
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400034C RID: 844
		[AccessedThroughProperty("PanelEx3")]
		private PanelEx _PanelEx3;

		// Token: 0x0400034D RID: 845
		[AccessedThroughProperty("UiButton11")]
		private UIButton _UiButton11;

		// Token: 0x0400034E RID: 846
		[AccessedThroughProperty("UiButton10")]
		private UIButton _UiButton10;

		// Token: 0x0400034F RID: 847
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		// Token: 0x04000350 RID: 848
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000351 RID: 849
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000352 RID: 850
		[AccessedThroughProperty("txt_help")]
		private TextBox _txt_help;

		// Token: 0x04000353 RID: 851
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000354 RID: 852
		[AccessedThroughProperty("txt_show")]
		private UICheckBox _txt_show;

		// Token: 0x04000355 RID: 853
		[CompilerGenerated]
		private string _Version;

		// Token: 0x04000356 RID: 854
		[CompilerGenerated]
		private string _HelpText;
	}
}
