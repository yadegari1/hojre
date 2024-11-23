using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000063 RID: 99
	[DesignerGenerated]
	public partial class Frm_cmd : Form
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x00173EB8 File Offset: 0x001722B8
		[DebuggerNonUserCode]
		public Frm_cmd()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_cmd_KeyDown);
			base.Load += new EventHandler(this.Frm_cmd_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_cmd_FormClosing);
			Frm_cmd.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00173F18 File Offset: 0x00172318
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_cmd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_cmd.__ENCList.Count == Frm_cmd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_cmd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_cmd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_cmd.__ENCList[num] = Frm_cmd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_cmd.__ENCList.RemoveRange(num, Frm_cmd.__ENCList.Count - num);
						Frm_cmd.__ENCList.Capacity = Frm_cmd.__ENCList.Count;
					}
					Frm_cmd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00174250 File Offset: 0x00172650
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00174268 File Offset: 0x00172668
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00174274 File Offset: 0x00172674
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0017428C File Offset: 0x0017268C
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x001742EC File Offset: 0x001726EC
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ExecuteNonQuery(this.TextBox1.Text);
			if (flag)
			{
				MessageBox.Show("OK");
				Public_Function.SetFarsi();
				this.Close();
			}
			else
			{
				MessageBox.Show("Error");
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00174338 File Offset: 0x00172738
		private void Frm_cmd_FormClosing(object sender, FormClosingEventArgs e)
		{
			Public_Function.SetFarsi();
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00174344 File Offset: 0x00172744
		private void Frm_cmd_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0017436C File Offset: 0x0017276C
		private void Frm_cmd_Load(object sender, EventArgs e)
		{
			Public_Function.SetEnglish();
		}

		// Token: 0x0400029A RID: 666
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400029C RID: 668
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400029D RID: 669
		[AccessedThroughProperty("Button1")]
		private Button _Button1;
	}
}
