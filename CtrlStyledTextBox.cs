using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B6 RID: 182
	public class CtrlStyledTextBox : TextBox, IControlWithBorder, IEndEditToDataBinding
	{
		// Token: 0x06000E5D RID: 3677 RVA: 0x00148CF0 File Offset: 0x001470F0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlStyledTextBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlStyledTextBox.__ENCList.Count == CtrlStyledTextBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlStyledTextBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlStyledTextBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlStyledTextBox.__ENCList[num] = CtrlStyledTextBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlStyledTextBox.__ENCList.RemoveRange(num, CtrlStyledTextBox.__ENCList.Count - num);
						CtrlStyledTextBox.__ENCList.Capacity = CtrlStyledTextBox.__ENCList.Count;
					}
					CtrlStyledTextBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00148DF4 File Offset: 0x001471F4
		public CtrlStyledTextBox()
		{
			CtrlStyledTextBox.__ENCAddToList(this);
			this._ConvertEnterToTab = true;
			this.borderDrawer = new BorderDrawer();
			base.BorderStyle = BorderStyle.FixedSingle;
			this.ShortcutsEnabled = true;
			this.borderDrawer.RegisterFocusHoverControl(this);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00148E40 File Offset: 0x00147240
		public void EndEditToDataBinding(ContainerControl mainControl)
		{
			mainControl.ActiveControl = null;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00148E4C File Offset: 0x0014724C
		private Color GetParentColor(Control c)
		{
			bool flag = !(c.BackColor == Color.Transparent);
			Color result;
			if (flag)
			{
				result = c.BackColor;
			}
			else
			{
				flag = (c.Parent == null);
				if (flag)
				{
					result = Color.White;
				}
				else
				{
					result = this.GetParentColor(c.Parent);
				}
			}
			return result;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00148EA4 File Offset: 0x001472A4
		protected override void OnLocationChanged(EventArgs e)
		{
			base.OnLocationChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00148EB8 File Offset: 0x001472B8
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Invalidate();
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00148ECC File Offset: 0x001472CC
		public Control PreviousControl()
		{
			Form form = base.FindForm();
			Control control = this;
			do
			{
				control = form.GetNextControl(control, false);
			}
			while (control != null && !control.TabStop);
			return control;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00148F08 File Offset: 0x00147308
		protected override bool ProcessCmdKey(ref Message m, Keys k)
		{
			bool flag = m.Msg == 256 && k == Keys.Return && !base.AcceptsReturn && this.ConvertEnterToTab;
			checked
			{
				bool result;
				if (flag)
				{
					Form form = base.FindForm();
					flag = (!this.ConvertEnterToTabForDialogs && form != null && form.AcceptButton != null);
					if (flag)
					{
						result = base.ProcessCmdKey(ref m, k);
					}
					else
					{
						SendKeys.Send("\t");
						result = true;
					}
				}
				else
				{
					flag = (m.Msg != 256 || k != (Keys.Back | Keys.Control));
					if (flag)
					{
						result = base.ProcessCmdKey(ref m, k);
					}
					else
					{
						flag = (this.Text.Length != 0);
						if (flag)
						{
							bool flag2 = this.Text.LastIndexOf(' ') == this.Text.Length - 1;
							if (flag2)
							{
								int num = this.Text.Substring(0, this.Text.Length - 1).LastIndexOf(' ');
								flag2 = (num < 0);
								if (flag2)
								{
									num = 0;
								}
								this.Text = this.Text.Remove(num);
							}
							else
							{
								this.Text = this.Text.Remove(this.Text.LastIndexOf(' ') + 1);
							}
							base.SelectionStart = this.Text.Length;
							this.SelectionLength = 0;
						}
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x06000E65 RID: 3685
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000E66 RID: 3686 RVA: 0x00149074 File Offset: 0x00147474
		public IntPtr SendMessageToMe(int msg, IntPtr wParam, IntPtr lParam)
		{
			HandleRef hWnd = new HandleRef(base.Handle, base.Handle);
			return CtrlStyledTextBox.SendMessage(hWnd, msg, wParam, lParam);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x001490A8 File Offset: 0x001474A8
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			bool flag = base.BorderStyle != BorderStyle.None && base.Visible;
			if (flag)
			{
				this.borderDrawer.DrawBorder(ref m, base.Width, base.Height);
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x001490F4 File Offset: 0x001474F4
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x0014910C File Offset: 0x0014750C
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				bool flag = value == Color.Transparent;
				if (flag)
				{
					bool flag2 = base.Parent == null;
					if (flag2)
					{
						base.BackColor = Color.White;
					}
					else
					{
						base.BackColor = this.GetParentColor(base.Parent);
					}
				}
				else
				{
					base.BackColor = value;
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00149170 File Offset: 0x00147570
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00149190 File Offset: 0x00147590
		public Color BorderColor
		{
			get
			{
				return this.borderDrawer.BorderColor;
			}
			set
			{
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00149194 File Offset: 0x00147594
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x001491AC File Offset: 0x001475AC
		public bool ConvertEnterToTab
		{
			get
			{
				return this._ConvertEnterToTab;
			}
			set
			{
				this._ConvertEnterToTab = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x001491B8 File Offset: 0x001475B8
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x001491D0 File Offset: 0x001475D0
		public bool ConvertEnterToTabForDialogs
		{
			get
			{
				return this._ConvertEnterToTabForDialogs;
			}
			set
			{
				this._ConvertEnterToTabForDialogs = value;
			}
		}

		// Token: 0x04000599 RID: 1433
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400059A RID: 1434
		private bool _ConvertEnterToTab;

		// Token: 0x0400059B RID: 1435
		private bool _ConvertEnterToTabForDialogs;

		// Token: 0x0400059C RID: 1436
		protected BorderDrawer borderDrawer;
	}
}
