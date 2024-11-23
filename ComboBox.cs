using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.Common;
using Janus.Windows.EditControls;

namespace FruitBox
{
	// Token: 0x0200008C RID: 140
	public class ComboBox : UIComboBox
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x0019BBC4 File Offset: 0x00199FC4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = ComboBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = ComboBox.__ENCList.Count == ComboBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = ComboBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = ComboBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									ComboBox.__ENCList[num] = ComboBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						ComboBox.__ENCList.RemoveRange(num, ComboBox.__ENCList.Count - num);
						ComboBox.__ENCList.Capacity = ComboBox.__ENCList.Count;
					}
					ComboBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0019BCC8 File Offset: 0x0019A0C8
		[DebuggerNonUserCode]
		public ComboBox(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0019BCF4 File Offset: 0x0019A0F4
		[DebuggerNonUserCode]
		public ComboBox()
		{
			ComboBox.__ENCAddToList(this);
			this.KeyDown += new KeyEventHandler(this.me_keydown);
			this.Nullable = true;
			this.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.AllowNew = true;
			this.set_VisualStyle(6);
			this.InitializeComponent();
			base.set_Text(string.Empty);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0019BD5C File Offset: 0x0019A15C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0019BDAC File Offset: 0x0019A1AC
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0019BDBC File Offset: 0x0019A1BC
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x0019BDD4 File Offset: 0x0019A1D4
		[Category("ExtendProperty")]
		public bool AllowNew
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowNew;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowNew = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0019BDE0 File Offset: 0x0019A1E0
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x0019BDF8 File Offset: 0x0019A1F8
		[Category("ExtendProperty")]
		public bool Nullable
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Nullable;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Nullable = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0019BE04 File Offset: 0x0019A204
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x0019BE1C File Offset: 0x0019A21C
		[Category("ExtendProperty")]
		public string NullToolTipText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NullToolTipText;
			}
			[DebuggerNonUserCode]
			set
			{
				this._NullToolTipText = value;
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0019BE28 File Offset: 0x0019A228
		public void SetNew()
		{
			this.set_SelectedValue(null);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0019BE34 File Offset: 0x0019A234
		public void RaiseSoftError()
		{
			JanusSuperTip janusSuperTip = new JanusSuperTip();
			janusSuperTip.set_BodyWidth(250);
			janusSuperTip.set_RightToLeft(true);
			janusSuperTip.set_AutoPopDelay(0);
			janusSuperTip.set_InitialDelay(0);
			janusSuperTip.set_Font(new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178));
			SuperTipSettings superTipSettings = new SuperTipSettings();
			superTipSettings.set_Text(this.NullToolTipText);
			Rectangle bounds = this.Bounds;
			bounds.Location = this.Parent.PointToScreen(bounds.Location);
			superTipSettings.set_HeaderImage(Resources.onebit_36);
			superTipSettings.set_HeaderText("خطا");
			JanusSuperTip arg_B4_0 = janusSuperTip;
			SuperTipSettings arg_B4_1 = superTipSettings;
			Point point = new Point(bounds.Left, bounds.Bottom);
			arg_B4_0.Show(arg_B4_1, this, point, 1500);
			this.Focus();
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0019BF04 File Offset: 0x0019A304
		public bool NullCheck()
		{
			bool flag = this.Visible && !this.Nullable && this.get_SelectedItem() == null;
			bool result;
			if (flag)
			{
				this.RaiseSoftError();
				result = true;
			}
			else
			{
				flag = (this.Visible && !this.Nullable && this.get_SelectedItem() == null && this.get_SelectedValue() != null);
				if (flag)
				{
					this.ShowTip("اطلاعات وارد شده نامعتبر میباشد");
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0019BF80 File Offset: 0x0019A380
		public void ShowTip(string Text)
		{
			JanusSuperTip janusSuperTip = new JanusSuperTip();
			janusSuperTip.set_RightToLeft(true);
			janusSuperTip.set_AutoPopDelay(0);
			janusSuperTip.set_InitialDelay(0);
			janusSuperTip.set_Font(new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178));
			SuperTipSettings superTipSettings = new SuperTipSettings();
			superTipSettings.set_Text(Text);
			Rectangle bounds = this.Bounds;
			bounds.Location = this.Parent.PointToScreen(bounds.Location);
			JanusSuperTip arg_86_0 = janusSuperTip;
			SuperTipSettings arg_86_1 = superTipSettings;
			Point point = new Point(bounds.Left, bounds.Bottom);
			arg_86_0.Show(arg_86_1, this, point);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0019C01C File Offset: 0x0019A41C
		public virtual void me_keydown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0019C050 File Offset: 0x0019A450
		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg != 770;
			if (flag)
			{
				base.WndProc(ref m);
			}
		}

		// Token: 0x040004B2 RID: 1202
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004B3 RID: 1203
		private IContainer components;

		// Token: 0x040004B4 RID: 1204
		[CompilerGenerated]
		private bool _AllowNew;

		// Token: 0x040004B5 RID: 1205
		[CompilerGenerated]
		private bool _Nullable;

		// Token: 0x040004B6 RID: 1206
		[CompilerGenerated]
		private string _NullToolTipText;
	}
}
