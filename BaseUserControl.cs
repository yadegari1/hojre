using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000A7 RID: 167
	[DesignerGenerated]
	public class BaseUserControl : UserControl
	{
		// Token: 0x06000DDA RID: 3546 RVA: 0x001A5088 File Offset: 0x001A3488
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = BaseUserControl.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = BaseUserControl.__ENCList.Count == BaseUserControl.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = BaseUserControl.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = BaseUserControl.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									BaseUserControl.__ENCList[num] = BaseUserControl.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						BaseUserControl.__ENCList.RemoveRange(num, BaseUserControl.__ENCList.Count - num);
						BaseUserControl.__ENCList.Capacity = BaseUserControl.__ENCList.Count;
					}
					BaseUserControl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x001A518C File Offset: 0x001A358C
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

		// Token: 0x06000DDC RID: 3548 RVA: 0x001A51DC File Offset: 0x001A35DC
		public BaseUserControl()
		{
			BaseUserControl.__ENCAddToList(this);
			base.SetStyle(ControlStyles.UserMouse, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			base.UpdateStyles();
			this.DoubleBuffered = true;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x001A523C File Offset: 0x001A363C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x001A5268 File Offset: 0x001A3668
		public static List<Control> GetAllChildControls(Control c)
		{
			List<Control> list = new List<Control>();
			BaseUserControl.GetAllChildControlsHelper(c, list);
			return list;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x001A528C File Offset: 0x001A368C
		protected static void GetAllChildControlsHelper(Control c, List<Control> l)
		{
			l.Add(c);
			try
			{
				IEnumerator enumerator = c.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control c2 = (Control)enumerator.Current;
					BaseUserControl.GetAllChildControlsHelper(c2, l);
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x04000544 RID: 1348
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000545 RID: 1349
		private IContainer components;

		// Token: 0x04000546 RID: 1350
		public static int RichTextBoxIndentPixel = 10;

		// Token: 0x04000547 RID: 1351
		public const int WM_CHAR = 258;

		// Token: 0x04000548 RID: 1352
		public const int WM_ERASEBKGND = 20;

		// Token: 0x04000549 RID: 1353
		public const int WM_LBUTTONCLICK = 513;

		// Token: 0x0400054A RID: 1354
		public const int WM_NCCALCSIZE = 131;

		// Token: 0x0400054B RID: 1355
		public const int WM_NCPAINT = 133;

		// Token: 0x0400054C RID: 1356
		public const int WM_PAINT = 15;

		// Token: 0x0400054D RID: 1357
		public const int WM_PARENTNOTIFY = 528;

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000DE4 RID: 3556
		public delegate void BoolDelegate(bool param);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000DE8 RID: 3560
		public delegate void EmptyDelegate();

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000DEC RID: 3564
		public delegate bool PreSaveOperation(object parameter);

		// Token: 0x020000AB RID: 171
		public class SaveMessages
		{
			// Token: 0x06000DED RID: 3565 RVA: 0x001A5304 File Offset: 0x001A3704
			public SaveMessages(string initialMessage, string noNeed, string saveSucceed, string saveFailed)
			{
				this.InitialMessage = initialMessage;
				this.NoNeed = noNeed;
				this.SaveSucceed = saveSucceed;
				this.SaveFailed = saveFailed;
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06000DEE RID: 3566 RVA: 0x001A5330 File Offset: 0x001A3730
			// (set) Token: 0x06000DEF RID: 3567 RVA: 0x001A5348 File Offset: 0x001A3748
			public string InitialMessage
			{
				get
				{
					return this._InitialMessage;
				}
				set
				{
					this._InitialMessage = value;
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x001A5354 File Offset: 0x001A3754
			// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x001A536C File Offset: 0x001A376C
			public string NoNeed
			{
				get
				{
					return this._NoNeed;
				}
				set
				{
					this._NoNeed = value;
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x001A5378 File Offset: 0x001A3778
			// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x001A5390 File Offset: 0x001A3790
			public string SaveFailed
			{
				get
				{
					return this._SaveFailed;
				}
				set
				{
					this._SaveFailed = value;
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x001A539C File Offset: 0x001A379C
			// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x001A53B4 File Offset: 0x001A37B4
			public string SaveSucceed
			{
				get
				{
					return this._SaveSucceed;
				}
				set
				{
					this._SaveSucceed = value;
				}
			}

			// Token: 0x0400054E RID: 1358
			private string _InitialMessage;

			// Token: 0x0400054F RID: 1359
			private string _NoNeed;

			// Token: 0x04000550 RID: 1360
			private string _SaveFailed;

			// Token: 0x04000551 RID: 1361
			private string _SaveSucceed;
		}

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000DF9 RID: 3577
		public delegate BaseUserControl.SaveStatus SaveRecordDelegate(BaseUserControl.PreSaveOperation op, object opParameter);

		// Token: 0x020000AD RID: 173
		public enum SaveStatus
		{
			// Token: 0x04000553 RID: 1363
			NoNeed,
			// Token: 0x04000554 RID: 1364
			SaveFailed = 2,
			// Token: 0x04000555 RID: 1365
			SaveSucceeded = 1,
			// Token: 0x04000556 RID: 1366
			WillRetry = 3
		}
	}
}
