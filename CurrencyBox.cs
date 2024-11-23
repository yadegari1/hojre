using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200008D RID: 141
	public class CurrencyBox : NumericBox
	{
		// Token: 0x06000C53 RID: 3155 RVA: 0x0019C08C File Offset: 0x0019A48C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CurrencyBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CurrencyBox.__ENCList.Count == CurrencyBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CurrencyBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CurrencyBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CurrencyBox.__ENCList[num] = CurrencyBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CurrencyBox.__ENCList.RemoveRange(num, CurrencyBox.__ENCList.Count - num);
						CurrencyBox.__ENCList.Capacity = CurrencyBox.__ENCList.Count;
					}
					CurrencyBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0019C190 File Offset: 0x0019A590
		[DebuggerNonUserCode]
		public CurrencyBox(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0019C1BC File Offset: 0x0019A5BC
		[DebuggerNonUserCode]
		public CurrencyBox()
		{
			base.KeyDown += new KeyEventHandler(this.CurrencyBox_KeyDown);
			base.TextChanged += new EventHandler(this.CurrencyBox_TextChanged);
			CurrencyBox.__ENCAddToList(this);
			this.InitializeComponent();
			this.Text = "";
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0019C214 File Offset: 0x0019A614
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

		// Token: 0x06000C57 RID: 3159 RVA: 0x0019C264 File Offset: 0x0019A664
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0019C274 File Offset: 0x0019A674
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0019C28C File Offset: 0x0019A68C
		[Category("ExtendProperty")]
		public long? Value
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Value;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0019C298 File Offset: 0x0019A698
		public new void SetNew()
		{
			base.SetNew();
			long? value;
			this.Value = value;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0019C2B8 File Offset: 0x0019A6B8
		private void CurrencyBox_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
			case Keys.Up:
			{
				bool flag = this.Parent == null;
				if (!flag)
				{
					flag = (this.Parent.Parent != null);
					if (flag)
					{
						bool flag2 = this.Parent.Parent is GridEX;
						if (flag2)
						{
							break;
						}
					}
					this.ParentForm.SelectNextControl((Control)sender, false, true, true, true);
				}
				break;
			}
			case Keys.Down:
			{
				bool flag2 = this.Parent == null;
				if (!flag2)
				{
					flag2 = (this.Parent.Parent != null);
					if (flag2)
					{
						bool flag = this.Parent.Parent is GridEX;
						if (flag)
						{
							break;
						}
					}
					this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
				}
				break;
			}
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0019C3A0 File Offset: 0x0019A7A0
		private void CurrencyBox_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Text, string.Empty, false) != 0 && !Versioned.IsNumeric(this.Text);
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(this.Text, "-", false) != 0);
				if (flag2)
				{
					this.Text = string.Empty;
				}
			}
			flag2 = (Operators.CompareString(this.Text, string.Empty, false) != 0 && Operators.CompareString(this.Text, "-", false) != 0);
			if (flag2)
			{
				this.Value = Conversions.ToLong(this.Text.Replace(",", ""));
				long num = 0L;
				long? value = this.Value;
				bool? arg_E9_0;
				if (!value.HasValue)
				{
					arg_E9_0 = null;
				}
				else
				{
					bool? flag3 = new bool?(value.GetValueOrDefault() == num);
					arg_E9_0 = flag3;
				}
				bool? flag4 = arg_E9_0;
				flag2 = flag4.GetValueOrDefault();
				if (flag2)
				{
					this.Text = "0";
				}
				else
				{
					string text = string.Empty;
					text = Strings.FormatNumber(Math.Abs((T)this.Value), 0, TriState.False, TriState.False, TriState.True);
					num = 0L;
					value = this.Value;
					bool? arg_15F_0;
					if (!value.HasValue)
					{
						arg_15F_0 = null;
					}
					else
					{
						flag4 = new bool?(value.GetValueOrDefault() < num);
						arg_15F_0 = flag4;
					}
					bool? flag3 = arg_15F_0;
					flag2 = flag3.GetValueOrDefault();
					if (flag2)
					{
						text += "-";
					}
					this.Text = text;
				}
				flag2 = (this.Text.IndexOf("-") > -1);
				if (flag2)
				{
					this.set_SelectionStart(checked(this.Text.Length - 1));
				}
				else
				{
					this.set_SelectionStart(this.Text.Length);
				}
			}
			else
			{
				long? value2;
				this.Value = value2;
			}
		}

		// Token: 0x040004B7 RID: 1207
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004B8 RID: 1208
		private IContainer components;

		// Token: 0x040004B9 RID: 1209
		[CompilerGenerated]
		private long? _Value;
	}
}
