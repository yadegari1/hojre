using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.CommandBars;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000BB RID: 187
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x001A6638 File Offset: 0x001A4A38
		public Form1()
		{
			base.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
			base.Load += new EventHandler(this.Form1_Load);
			Form1.__ENCAddToList(this);
			Grid_SelectItem selectItem = new Grid_SelectItem();
			this.SelectItem = selectItem;
			this.InitializeComponent();
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x001A6694 File Offset: 0x001A4A94
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form1.__ENCList.Count == Form1.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form1.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form1.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form1.__ENCList[num] = Form1.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num);
						Form1.__ENCList.Capacity = Form1.__ENCList.Count;
					}
					Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x001A6B80 File Offset: 0x001A4F80
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x001A6B98 File Offset: 0x001A4F98
		internal virtual MetroTileItem MetroTileItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetroTileItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MetroTileItem4 = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x001A6BA4 File Offset: 0x001A4FA4
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x001A6BBC File Offset: 0x001A4FBC
		internal virtual DataEntryGrid GridEX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyDown);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyUp);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.KeyUp -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.KeyUp += value3;
				}
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x001A6C44 File Offset: 0x001A5044
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x001A6C5C File Offset: 0x001A505C
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

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x001A6C68 File Offset: 0x001A5068
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x001A6C80 File Offset: 0x001A5080
		public Grid_SelectItem SelectItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectItem;
			}
			[DebuggerNonUserCode]
			set
			{
				this._SelectItem = value;
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x001A6C8C File Offset: 0x001A508C
		private void UiCommandBar1_CommandClick(object sender, CommandEventArgs e)
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x001A6C90 File Offset: 0x001A5090
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				bool visible = this.SelectItem.Visible;
				if (visible)
				{
					this.SelectItem.Visible = false;
				}
				else
				{
					this.Close();
				}
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x001A6CD8 File Offset: 0x001A50D8
		private void Form1_Load(object sender, EventArgs e)
		{
			Furush_Hag furush_Hag = new Furush_Hag();
			DataTable detailByID = furush_Hag.GetDetailByID(149L);
			this.GridEX1.set_DataSource(detailByID);
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Code", "کد", 15));
			itemCollection.Add(new Column("name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 25));
			this.SelectItem.items = itemCollection;
			this.Controls.Add(this.SelectItem);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x001A6D74 File Offset: 0x001A5174
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Down;
			if (flag)
			{
				bool flag2 = this.GridEX1.get_Col() == this.GridEX1.get_RootTable().get_Columns().get_Item("moshtari_name").get_Position();
				if (flag2)
				{
					bool visible = this.SelectItem.Visible;
					if (visible)
					{
						this.SelectItem.GridEx1.Focus();
						e.SuppressKeyPress = true;
					}
				}
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x001A6DF0 File Offset: 0x001A51F0
		private void GridEX1_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.get_Col() == this.GridEX1.get_RootTable().get_Columns().get_Item("moshtari_name").get_Position());
					if (flag)
					{
						bool flag2 = this.GridEX1.get_EditTextBox() != null;
						if (flag2)
						{
							bool flag3 = Operators.CompareString(this.GridEX1.get_EditTextBox().Text, string.Empty, false) != 0;
							if (flag3)
							{
								bool flag4 = Operators.CompareString(this.GridEX1.get_CurrentRow().get_Cells().get_Item("moshtari_name").get_Value().ToString(), this.GridEX1.get_EditTextBox().Text, false) != 0;
								if (flag4)
								{
									Rectangle cellBounds = this.GridEX1.GetCellBounds(this.GridEX1.get_Row(), this.GridEX1.get_RootTable().get_Columns().get_Item("moshtari_name").get_Position());
									Rectangle bounds = this.GridEX1.Bounds;
									bounds.Location = this.GridEX1.Parent.PointToScreen(bounds.Location);
									this.SelectItem.Left = cellBounds.Left - this.SelectItem.Width + cellBounds.Width;
									this.SelectItem.Top = cellBounds.Top + cellBounds.Height;
									this.SelectItem.Show();
									this.SelectItem.BringToFront();
									this.SelectItem.RowFilter(this.GridEX1.get_EditTextBox().Text);
								}
								else
								{
									this.SelectItem.Hide();
								}
							}
							else
							{
								this.SelectItem.Hide();
							}
						}
					}
				}
			}
		}

		// Token: 0x0400059E RID: 1438
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005A0 RID: 1440
		[AccessedThroughProperty("MetroTileItem4")]
		private MetroTileItem _MetroTileItem4;

		// Token: 0x040005A1 RID: 1441
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040005A2 RID: 1442
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040005A3 RID: 1443
		[CompilerGenerated]
		private Grid_SelectItem _SelectItem;
	}
}
