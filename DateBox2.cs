using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000090 RID: 144
	public class DateBox2 : MaskedEditBox
	{
		// Token: 0x06000C76 RID: 3190 RVA: 0x0019CCF4 File Offset: 0x0019B0F4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DateBox2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DateBox2.__ENCList.Count == DateBox2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DateBox2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DateBox2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DateBox2.__ENCList[num] = DateBox2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DateBox2.__ENCList.RemoveRange(num, DateBox2.__ENCList.Count - num);
						DateBox2.__ENCList.Capacity = DateBox2.__ENCList.Count;
					}
					DateBox2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0019CDF8 File Offset: 0x0019B1F8
		[DebuggerNonUserCode]
		public DateBox2(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0019CE24 File Offset: 0x0019B224
		[DebuggerNonUserCode]
		public DateBox2()
		{
			DateBox2.__ENCAddToList(this);
			bool flag = true;
			this.AllowEdit = flag;
			flag = true;
			this.AcceptEnter = flag;
			int focusDatePart = 2;
			this.FocusDatePart = focusDatePart;
			this._btn = true;
			this.daysinmonth = new int[13];
			this.DatePart = 0;
			this.p = new PersianCalendar();
			this.pos = true;
			this.set_Mask("0000/00/00");
			this.set_ButtonStyle(2);
			this.set_VisualStyle(6);
			this.RightToLeft = RightToLeft.No;
			this.GotFocus += new EventHandler(this.Me_GotFocus);
			this.MouseUp += new MouseEventHandler(this.Me_MouseUp);
			this.KeyDown += new KeyEventHandler(this.Me_KeyDown);
			this.add_ButtonClick(new EventHandler(this.Me_ButtonClick));
			this.InitializeComponent();
			this.set_Text(Public_Function.MiladiToShamsi(DateAndTime.Now));
			this.sal = Conversions.ToInteger(this.get_Text().Substring(0, 4));
			this.mah = Conversions.ToInteger(this.get_Text().Substring(5, 2));
			this.ruz = Conversions.ToInteger(this.get_Text().Substring(8, 2));
			this.set_Text(string.Concat(new string[]
			{
				Conversions.ToString(this.sal),
				"/",
				Strings.Format(this.mah, "00"),
				"/",
				Strings.Format(this.ruz, "00")
			}));
			this.GetDays();
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0019CFD0 File Offset: 0x0019B3D0
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

		// Token: 0x06000C7A RID: 3194 RVA: 0x0019D020 File Offset: 0x0019B420
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0019D030 File Offset: 0x0019B430
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x0019D048 File Offset: 0x0019B448
		public bool AllowEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowEdit;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowEdit = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0019D054 File Offset: 0x0019B454
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x0019D06C File Offset: 0x0019B46C
		[Category("ExtendProperty")]
		public bool AcceptEnter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AcceptEnter;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AcceptEnter = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0019D078 File Offset: 0x0019B478
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x0019D090 File Offset: 0x0019B490
		[Category("ExtendProperty")]
		public int FocusDatePart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FocusDatePart;
			}
			[DebuggerNonUserCode]
			set
			{
				this._FocusDatePart = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0019D09C File Offset: 0x0019B49C
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0019D0B4 File Offset: 0x0019B4B4
		[Category("ExtendProperty")]
		public bool ButtonEnable
		{
			get
			{
				return this._btn;
			}
			set
			{
				this._btn = value;
				if (value)
				{
					this.set_ButtonStyle(2);
				}
				else
				{
					this.set_ButtonStyle(0);
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000C83 RID: 3203 RVA: 0x0019D0E4 File Offset: 0x0019B4E4
		// (remove) Token: 0x06000C84 RID: 3204 RVA: 0x0019D100 File Offset: 0x0019B500
		public event DateBox2.OnRightEventHandler OnRight
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnRightEvent = (DateBox2.OnRightEventHandler)Delegate.Combine(this.OnRightEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnRightEvent = (DateBox2.OnRightEventHandler)Delegate.Remove(this.OnRightEvent, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000C85 RID: 3205 RVA: 0x0019D11C File Offset: 0x0019B51C
		// (remove) Token: 0x06000C86 RID: 3206 RVA: 0x0019D138 File Offset: 0x0019B538
		public event DateBox2.OnLeftEventHandler OnLeft
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnLeftEvent = (DateBox2.OnLeftEventHandler)Delegate.Combine(this.OnLeftEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnLeftEvent = (DateBox2.OnLeftEventHandler)Delegate.Remove(this.OnLeftEvent, value);
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0019D154 File Offset: 0x0019B554
		public void SetNew()
		{
			this.SetDefault();
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0019D160 File Offset: 0x0019B560
		public void SetDefault()
		{
			this.SetDate(Public_Function.dict["today"]);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0019D17C File Offset: 0x0019B57C
		public void SetDate(DateTime _date)
		{
			string date = Public_Function.MiladiToShamsi(_date);
			this.SetDate(date);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0019D19C File Offset: 0x0019B59C
		public void SetDateToFiscalStart()
		{
			this.SetDate(Public_Function.dict["MaliStartDate"]);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0019D1B8 File Offset: 0x0019B5B8
		public void SetDateToFiscalEnd()
		{
			this.SetDate(Public_Function.dict["MaliEndDate"]);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0019D1D4 File Offset: 0x0019B5D4
		public void SetDate(string _date)
		{
			bool flag = Operators.CompareString(_date, string.Empty, false) == 0;
			if (flag)
			{
				this.SetNew();
			}
			else
			{
				string[] array = _date.Split(new char[]
				{
					'/'
				});
				this.set_Text(_date);
				this.sal = Conversions.ToInteger(array[0]);
				this.mah = Conversions.ToInteger(array[1]);
				this.ruz = Conversions.ToInteger(array[2]);
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0019D248 File Offset: 0x0019B648
		private void GetDays()
		{
			this.daysinmonth[1] = this.p.GetDaysInMonth(this.sal, 1);
			this.daysinmonth[2] = this.p.GetDaysInMonth(this.sal, 2);
			this.daysinmonth[3] = this.p.GetDaysInMonth(this.sal, 3);
			this.daysinmonth[4] = this.p.GetDaysInMonth(this.sal, 4);
			this.daysinmonth[5] = this.p.GetDaysInMonth(this.sal, 5);
			this.daysinmonth[6] = this.p.GetDaysInMonth(this.sal, 6);
			this.daysinmonth[7] = this.p.GetDaysInMonth(this.sal, 7);
			this.daysinmonth[8] = this.p.GetDaysInMonth(this.sal, 8);
			this.daysinmonth[9] = this.p.GetDaysInMonth(this.sal, 9);
			this.daysinmonth[10] = this.p.GetDaysInMonth(this.sal, 10);
			this.daysinmonth[11] = this.p.GetDaysInMonth(this.sal, 11);
			this.daysinmonth[12] = this.p.GetDaysInMonth(this.sal, 12);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0019D398 File Offset: 0x0019B798
		private void Me_ButtonClick(object sender, EventArgs e)
		{
			ToolStripDropDown toolStripDropDown = new ToolStripDropDown();
			DatePanel datePanel = new DatePanel();
			ToolStripControlHost toolStripControlHost = new ToolStripControlHost(datePanel);
			datePanel.Ruz = this.ruz;
			datePanel.Sal = this.sal;
			datePanel.Mah = this.mah;
			datePanel.DateBox = this;
			datePanel.DropDown = toolStripDropDown;
			toolStripDropDown.AutoSize = false;
			Control arg_6A_0 = toolStripDropDown;
			Size size = new Size(datePanel.Width, datePanel.Height);
			arg_6A_0.Size = size;
			toolStripControlHost.Control.Dock = DockStyle.Fill;
			toolStripControlHost.Control.Top = 0;
			toolStripControlHost.Control.Left = 0;
			toolStripDropDown.Items.Add(toolStripControlHost);
			toolStripDropDown.Show(this, 0, checked(this.Height + 1));
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0019D45C File Offset: 0x0019B85C
		private void Me_GotFocus(object sender, EventArgs e)
		{
			Trace.WriteLine(this.get_SelectionStart());
			switch (this.FocusDatePart)
			{
			case 0:
				this.set_SelectionStart(0);
				this.set_SelectionLength(4);
				this.DatePart = 0;
				break;
			case 1:
				this.set_SelectionStart(5);
				this.set_SelectionLength(2);
				this.DatePart = 1;
				break;
			case 2:
				this.set_SelectionStart(8);
				this.set_SelectionLength(2);
				this.DatePart = 2;
				break;
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0019D4E8 File Offset: 0x0019B8E8
		private string GetVal(KeyEventArgs e)
		{
			string result;
			switch (e.KeyCode)
			{
			case Keys.D0:
			case Keys.NumPad0:
				result = "0";
				return result;
			case Keys.D1:
			case Keys.NumPad1:
				result = "1";
				return result;
			case Keys.D2:
			case Keys.NumPad2:
				result = "2";
				return result;
			case Keys.D3:
			case Keys.NumPad3:
				result = "3";
				return result;
			case Keys.D4:
			case Keys.NumPad4:
				result = "4";
				return result;
			case Keys.D5:
			case Keys.NumPad5:
				result = "5";
				return result;
			case Keys.D6:
			case Keys.NumPad6:
				result = "6";
				return result;
			case Keys.D7:
			case Keys.NumPad7:
				result = "7";
				return result;
			case Keys.D8:
			case Keys.NumPad8:
				result = "8";
				return result;
			case Keys.D9:
			case Keys.NumPad9:
				result = "9";
				return result;
			}
			result = "0";
			return result;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0019D668 File Offset: 0x0019BA68
		public void Me_KeyDown(object sender, KeyEventArgs e)
		{
			bool arg_30_0;
			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				if (e.KeyData < Keys.NumPad0 || e.KeyData > Keys.NumPad9)
				{
					arg_30_0 = false;
					goto IL_2F;
				}
			}
			arg_30_0 = true;
			IL_2F:
			bool flag = arg_30_0;
			checked
			{
				if (flag)
				{
					switch (this.DatePart)
					{
					case 0:
					{
						bool flag2 = this.pos;
						if (flag2)
						{
							this.sal = Conversions.ToInteger(this.sal.ToString().Remove(2, 1));
							this.sal = Conversions.ToInteger(this.sal.ToString().Insert(2, this.GetVal(e)));
							flag2 = (this.sal >= 1304 && this.sal <= 1309);
							if (flag2)
							{
								this.sal = 1400;
							}
						}
						else
						{
							this.sal = Conversions.ToInteger(this.sal.ToString().Remove(3, 1));
							this.sal = Conversions.ToInteger(this.sal.ToString().Insert(3, this.GetVal(e)));
							flag2 = (this.sal == 1499);
							if (flag2)
							{
								this.sal = 1399;
							}
						}
						this.pos = !this.pos;
						flag2 = this.pos;
						if (flag2)
						{
							this.DatePart = 1;
						}
						break;
					}
					case 1:
					{
						bool flag2 = this.mah >= 2;
						if (flag2)
						{
							this.pos = true;
						}
						flag2 = this.pos;
						if (flag2)
						{
							flag = (Conversions.ToDouble(this.GetVal(e)) >= 2.0);
							if (flag)
							{
								this.mah = Conversions.ToInteger(this.GetVal(e));
								this.DatePart = 2;
							}
							else
							{
								flag2 = (Conversions.ToDouble(this.GetVal(e)) != 0.0);
								if (flag2)
								{
									this.mah = Conversions.ToInteger(this.GetVal(e));
									this.pos = !this.pos;
								}
							}
						}
						else
						{
							flag2 = (Conversions.ToDouble(this.GetVal(e)) <= 2.0);
							if (flag2)
							{
								this.mah = (int)Math.Round(unchecked(Conversions.ToDouble(this.mah.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
							}
							this.pos = true;
							this.DatePart = 2;
						}
						break;
					}
					case 2:
					{
						bool flag2 = this.pos;
						if (flag2)
						{
							flag = (Conversions.ToDouble(this.GetVal(e)) > 3.0);
							if (flag)
							{
								this.ruz = Conversions.ToInteger(this.GetVal(e));
							}
							else
							{
								flag2 = (Conversions.ToDouble(this.GetVal(e)) != 0.0);
								if (flag2)
								{
									this.ruz = Conversions.ToInteger(this.GetVal(e));
									this.pos = false;
								}
							}
						}
						else
						{
							flag2 = (this.ruz < 4);
							if (flag2)
							{
								flag = (this.ruz != 3);
								if (flag)
								{
									this.ruz = (int)Math.Round(unchecked(Conversions.ToDouble(this.ruz.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
									this.pos = true;
								}
								else
								{
									flag2 = (Conversions.ToDouble(this.GetVal(e)) == 0.0 || Conversions.ToDouble(this.GetVal(e)) == 1.0);
									if (flag2)
									{
										this.ruz = (int)Math.Round(unchecked(Conversions.ToDouble(this.ruz.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
										this.pos = true;
									}
									else
									{
										this.ruz = Conversions.ToInteger(this.GetVal(e));
										this.pos = true;
									}
								}
							}
							else
							{
								this.ruz = (int)Math.Round(unchecked(Conversions.ToDouble(this.ruz.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
								this.pos = true;
							}
						}
						break;
					}
					}
				}
				switch (e.KeyCode)
				{
				case Keys.Return:
				{
					bool flag2 = !this.AcceptEnter;
					if (flag2)
					{
						return;
					}
					this.Parent.SelectNextControl((Control)sender, true, true, true, true);
					break;
				}
				case Keys.Left:
				{
					this.DatePart--;
					bool flag3 = this.DatePart < 0;
					if (flag3)
					{
						this.DatePart = 0;
						flag3 = (this.Parent == null);
						if (flag3)
						{
							return;
						}
						flag3 = (this.Parent.Parent != null);
						if (flag3)
						{
							bool flag2 = this.Parent.Parent is GridEX;
							if (flag2)
							{
								flag = (((GridEX)this.Parent.Parent).get_Col() >= 0);
								if (flag)
								{
									GridEX gridEX = (GridEX)this.Parent.Parent;
									gridEX.set_Col(gridEX.get_Col() + 1);
									DateBox2.OnLeftEventHandler onLeftEvent = this.OnLeftEvent;
									flag3 = (onLeftEvent != null);
									if (flag3)
									{
										onLeftEvent();
									}
								}
							}
						}
						e.SuppressKeyPress = true;
					}
					break;
				}
				case Keys.Up:
				{
					bool flag2 = this.Parent == null;
					if (flag2)
					{
						return;
					}
					flag2 = (this.Parent.Parent != null);
					if (flag2)
					{
						flag = (this.Parent.Parent is GridEX);
						if (flag)
						{
							return;
						}
					}
					this.ParentForm.SelectNextControl((Control)sender, false, true, true, true);
					break;
				}
				case Keys.Right:
				{
					this.DatePart++;
					bool flag2 = this.DatePart > 2;
					if (flag2)
					{
						this.DatePart = 2;
						e.SuppressKeyPress = true;
						flag2 = (this.Parent == null);
						if (flag2)
						{
							return;
						}
						flag2 = (this.Parent.Parent != null);
						if (flag2)
						{
							flag = (this.Parent.Parent is GridEX);
							if (flag)
							{
								bool flag3 = ((GridEX)this.Parent.Parent).get_Col() > 0;
								if (flag3)
								{
									GridEX gridEX = (GridEX)this.Parent.Parent;
									gridEX.set_Col(gridEX.get_Col() - 1);
									DateBox2.OnRightEventHandler onRightEvent = this.OnRightEvent;
									flag3 = (onRightEvent != null);
									if (flag3)
									{
										onRightEvent();
									}
								}
							}
						}
					}
					break;
				}
				case Keys.Down:
				{
					bool flag2 = this.Parent == null;
					if (flag2)
					{
						return;
					}
					flag2 = (this.Parent.Parent != null);
					if (flag2)
					{
						flag = (this.Parent.Parent is GridEX);
						if (flag)
						{
							return;
						}
					}
					this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
					break;
				}
				case Keys.Delete:
					this.SetNew();
					break;
				}
				this.set_Text(string.Concat(new string[]
				{
					Conversions.ToString(this.sal),
					"/",
					Strings.Format(this.mah, "00"),
					"/",
					Strings.Format(this.ruz, "00")
				}));
				switch (this.DatePart)
				{
				case 0:
					this.set_SelectionStart(0);
					this.set_SelectionLength(4);
					break;
				case 1:
					this.set_SelectionStart(5);
					this.set_SelectionLength(2);
					break;
				case 2:
					this.set_SelectionStart(8);
					this.set_SelectionLength(2);
					break;
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0019DF00 File Offset: 0x0019C300
		private void Me_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.get_SelectionStart() >= 0 && this.get_SelectionStart() < 4;
			if (flag)
			{
				this.set_SelectionStart(0);
				this.set_SelectionLength(4);
				this.DatePart = 0;
			}
			flag = (this.get_SelectionStart() >= 4 && this.get_SelectionStart() <= 6);
			if (flag)
			{
				this.set_SelectionStart(5);
				this.set_SelectionLength(2);
				this.DatePart = 1;
			}
			flag = (this.get_SelectionStart() >= 7);
			if (flag)
			{
				this.set_SelectionStart(8);
				this.set_SelectionLength(2);
				this.DatePart = 2;
			}
		}

		// Token: 0x040004C1 RID: 1217
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004C2 RID: 1218
		private IContainer components;

		// Token: 0x040004C3 RID: 1219
		[CompilerGenerated]
		private bool _AllowEdit;

		// Token: 0x040004C4 RID: 1220
		[CompilerGenerated]
		private bool _AcceptEnter;

		// Token: 0x040004C5 RID: 1221
		[CompilerGenerated]
		private int _FocusDatePart;

		// Token: 0x040004C6 RID: 1222
		private bool _btn;

		// Token: 0x040004C7 RID: 1223
		private int[] daysinmonth;

		// Token: 0x040004C8 RID: 1224
		public int DatePart;

		// Token: 0x040004C9 RID: 1225
		private int sal;

		// Token: 0x040004CA RID: 1226
		private int mah;

		// Token: 0x040004CB RID: 1227
		private int ruz;

		// Token: 0x040004CC RID: 1228
		private PersianCalendar p;

		// Token: 0x040004CD RID: 1229
		private bool pos;

		// Token: 0x040004CE RID: 1230
		private DateBox2.OnRightEventHandler OnRightEvent;

		// Token: 0x040004CF RID: 1231
		private DateBox2.OnLeftEventHandler OnLeftEvent;

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000C96 RID: 3222
		public delegate void OnRightEventHandler();

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000C9A RID: 3226
		public delegate void OnLeftEventHandler();
	}
}
