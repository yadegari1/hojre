using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.Common;
using Janus.Windows.GridEX.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200008F RID: 143
	public class DateBox : MaskedEditBox
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x0019C7C4 File Offset: 0x0019ABC4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DateBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DateBox.__ENCList.Count == DateBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DateBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DateBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DateBox.__ENCList[num] = DateBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DateBox.__ENCList.RemoveRange(num, DateBox.__ENCList.Count - num);
						DateBox.__ENCList.Capacity = DateBox.__ENCList.Count;
					}
					DateBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0019C8C8 File Offset: 0x0019ACC8
		[DebuggerNonUserCode]
		public DateBox(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0019C8F4 File Offset: 0x0019ACF4
		[DebuggerNonUserCode]
		public DateBox()
		{
			DateBox.__ENCAddToList(this);
			this.set_ShortcutsEnabled(false);
			this.Nullable = true;
			this.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.AllowNew = true;
			this.set_VisualStyle(6);
			this.set_Mask("####/##/##");
			this.RightToLeft = RightToLeft.No;
			this.set_TextAlignment(1);
			this.InitializeComponent();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0019C960 File Offset: 0x0019AD60
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

		// Token: 0x06000C68 RID: 3176 RVA: 0x0019C9B0 File Offset: 0x0019ADB0
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0019C9C0 File Offset: 0x0019ADC0
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0019C9D8 File Offset: 0x0019ADD8
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0019C9E4 File Offset: 0x0019ADE4
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x0019C9FC File Offset: 0x0019ADFC
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

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0019CA08 File Offset: 0x0019AE08
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x0019CA20 File Offset: 0x0019AE20
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

		// Token: 0x06000C6F RID: 3183 RVA: 0x0019CA2C File Offset: 0x0019AE2C
		public void SetNew()
		{
			this.set_Text(string.Empty);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0019CA3C File Offset: 0x0019AE3C
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

		// Token: 0x06000C71 RID: 3185 RVA: 0x0019CB0C File Offset: 0x0019AF0C
		public bool NullCheck()
		{
			bool flag = this.Visible && this.Nullable && Operators.CompareString(this.get_Text(), string.Empty, false) != 0;
			bool flag2;
			bool result;
			if (flag)
			{
				flag2 = !Public_Function.IsValidShamsiDate(this.get_Text());
				if (flag2)
				{
					this.ShowTip("تاریخ وارد شده معتبر نمیباشد");
					this.Focus();
					result = true;
					return result;
				}
			}
			flag2 = (this.Visible && !this.Nullable);
			if (flag2)
			{
				flag = (Operators.CompareString(this.get_Text(), string.Empty, false) == 0);
				if (flag)
				{
					this.RaiseSoftError();
					result = true;
					return result;
				}
				flag2 = !Public_Function.IsValidShamsiDate(this.get_Text());
				if (flag2)
				{
					this.ShowTip("تاریخ وارد شده معتبر نمیباشد");
					this.Focus();
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0019CBE4 File Offset: 0x0019AFE4
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
			JanusSuperTip arg_8B_0 = janusSuperTip;
			SuperTipSettings arg_8B_1 = superTipSettings;
			Point point = new Point(bounds.Left, bounds.Bottom);
			arg_8B_0.Show(arg_8B_1, this, point, 1500);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0019CC84 File Offset: 0x0019B084
		public virtual void me_keydown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.Parent.SelectNextControl((Control)sender, true, true, true, true);
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0019CCB8 File Offset: 0x0019B0B8
		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg != 770;
			if (flag)
			{
				base.WndProc(ref m);
			}
		}

		// Token: 0x040004BC RID: 1212
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004BD RID: 1213
		private IContainer components;

		// Token: 0x040004BE RID: 1214
		[CompilerGenerated]
		private bool _AllowNew;

		// Token: 0x040004BF RID: 1215
		[CompilerGenerated]
		private bool _Nullable;

		// Token: 0x040004C0 RID: 1216
		[CompilerGenerated]
		private string _NullToolTipText;
	}
}
