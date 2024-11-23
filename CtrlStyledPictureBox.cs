using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B4 RID: 180
	public class CtrlStyledPictureBox : PictureBox, IControlWithBorder
	{
		// Token: 0x06000E51 RID: 3665 RVA: 0x001489BC File Offset: 0x00146DBC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlStyledPictureBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlStyledPictureBox.__ENCList.Count == CtrlStyledPictureBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlStyledPictureBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlStyledPictureBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlStyledPictureBox.__ENCList[num] = CtrlStyledPictureBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlStyledPictureBox.__ENCList.RemoveRange(num, CtrlStyledPictureBox.__ENCList.Count - num);
						CtrlStyledPictureBox.__ENCList.Capacity = CtrlStyledPictureBox.__ENCList.Count;
					}
					CtrlStyledPictureBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00148AC0 File Offset: 0x00146EC0
		public CtrlStyledPictureBox()
		{
			CtrlStyledPictureBox.__ENCAddToList(this);
			this.borderDrawer = new BorderDrawer();
			this.borderDrawer.RegisterFocusHoverControl(this);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00148AEC File Offset: 0x00146EEC
		public void RefreshNullableImage(bool isNull)
		{
			if (isNull)
			{
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00148B04 File Offset: 0x00146F04
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			bool flag = base.BorderStyle != BorderStyle.None;
			if (flag)
			{
				this.borderDrawer.DrawBorder(ref m, base.Width, base.Height);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00148B48 File Offset: 0x00146F48
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00148B68 File Offset: 0x00146F68
		public Color BorderColor
		{
			get
			{
				return this.borderDrawer.BorderColor;
			}
			set
			{
				this.borderDrawer.BorderColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x04000596 RID: 1430
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000597 RID: 1431
		protected BorderDrawer borderDrawer;
	}
}
