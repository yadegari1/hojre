using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200005D RID: 93
	[DesignerGenerated]
	public partial class Frm_About : Form
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x0016E20C File Offset: 0x0016C60C
		[DebuggerNonUserCode]
		public Frm_About()
		{
			Frm_About.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0016E224 File Offset: 0x0016C624
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_About.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_About.__ENCList.Count == Frm_About.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_About.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_About.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_About.__ENCList[num] = Frm_About.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_About.__ENCList.RemoveRange(num, Frm_About.__ENCList.Count - num);
						Frm_About.__ENCList.Capacity = Frm_About.__ENCList.Count;
					}
					Frm_About.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0016EAD4 File Offset: 0x0016CED4
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x0016EAEC File Offset: 0x0016CEEC
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0016EAF8 File Offset: 0x0016CEF8
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x0016EB10 File Offset: 0x0016CF10
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0016EB1C File Offset: 0x0016CF1C
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x0016EB34 File Offset: 0x0016CF34
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0016EB40 File Offset: 0x0016CF40
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x0016EB58 File Offset: 0x0016CF58
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0016EB64 File Offset: 0x0016CF64
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x0016EB7C File Offset: 0x0016CF7C
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0016EB88 File Offset: 0x0016CF88
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0016EBA0 File Offset: 0x0016CFA0
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0016EBAC File Offset: 0x0016CFAC
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0016EBC4 File Offset: 0x0016CFC4
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0016EBD0 File Offset: 0x0016CFD0
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0016EBE8 File Offset: 0x0016CFE8
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0016EBF4 File Offset: 0x0016CFF4
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0016EC0C File Offset: 0x0016D00C
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x04000257 RID: 599
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000259 RID: 601
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400025A RID: 602
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400025B RID: 603
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400025C RID: 604
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400025D RID: 605
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400025E RID: 606
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400025F RID: 607
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000260 RID: 608
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000261 RID: 609
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;
	}
}
