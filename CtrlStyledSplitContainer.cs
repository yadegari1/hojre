using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B5 RID: 181
	public class CtrlStyledSplitContainer : SplitContainer
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x00148B9C File Offset: 0x00146F9C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlStyledSplitContainer.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlStyledSplitContainer.__ENCList.Count == CtrlStyledSplitContainer.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlStyledSplitContainer.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlStyledSplitContainer.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlStyledSplitContainer.__ENCList[num] = CtrlStyledSplitContainer.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlStyledSplitContainer.__ENCList.RemoveRange(num, CtrlStyledSplitContainer.__ENCList.Count - num);
						CtrlStyledSplitContainer.__ENCList.Capacity = CtrlStyledSplitContainer.__ENCList.Count;
					}
					CtrlStyledSplitContainer.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00148CA0 File Offset: 0x001470A0
		public CtrlStyledSplitContainer()
		{
			CtrlStyledSplitContainer.__ENCAddToList(this);
			this.TabStop = false;
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00148CBC File Offset: 0x001470BC
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00148CD4 File Offset: 0x001470D4
		[DefaultValue(false)]
		public new bool TabStop
		{
			get
			{
				return base.TabStop;
			}
			set
			{
				base.TabStop = value;
			}
		}

		// Token: 0x04000598 RID: 1432
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
