using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Janus.Windows.GridEX;

namespace FruitBox
{
	// Token: 0x0200008E RID: 142
	public class DataEntryGrid : GridEX
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x0019C594 File Offset: 0x0019A994
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DataEntryGrid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DataEntryGrid.__ENCList.Count == DataEntryGrid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DataEntryGrid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DataEntryGrid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DataEntryGrid.__ENCList[num] = DataEntryGrid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DataEntryGrid.__ENCList.RemoveRange(num, DataEntryGrid.__ENCList.Count - num);
						DataEntryGrid.__ENCList.Capacity = DataEntryGrid.__ENCList.Count;
					}
					DataEntryGrid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0019C698 File Offset: 0x0019AA98
		[DebuggerNonUserCode]
		public DataEntryGrid(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0019C6C4 File Offset: 0x0019AAC4
		[DebuggerNonUserCode]
		public DataEntryGrid()
		{
			DataEntryGrid.__ENCAddToList(this);
			this.InitializeComponent();
			bool designMode = this.DesignMode;
			if (designMode)
			{
				this.set_AllowAddNew(1);
				this.set_AlternatingColors(true);
				this.set_AutoEdit(true);
				this.set_EnterKeyBehavior(2);
				this.set_FocusStyle(1);
				this.set_GridLineStyle(2);
				this.set_GroupByBoxVisible(false);
				this.set_NewRowPosition(2);
				this.set_RowHeaderContent(3);
				this.set_RowHeaders(1);
				this.set_UpdateMode(1);
				this.set_VisualStyle(6);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0019C754 File Offset: 0x0019AB54
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

		// Token: 0x06000C62 RID: 3170 RVA: 0x0019C7A4 File Offset: 0x0019ABA4
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x040004BA RID: 1210
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004BB RID: 1211
		private IContainer components;
	}
}
