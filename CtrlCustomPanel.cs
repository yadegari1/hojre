using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000AF RID: 175
	public class CtrlCustomPanel : Panel, IStickyControl
	{
		// Token: 0x06000E07 RID: 3591 RVA: 0x001A53D0 File Offset: 0x001A37D0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlCustomPanel.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlCustomPanel.__ENCList.Count == CtrlCustomPanel.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlCustomPanel.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlCustomPanel.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlCustomPanel.__ENCList[num] = CtrlCustomPanel.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlCustomPanel.__ENCList.RemoveRange(num, CtrlCustomPanel.__ENCList.Count - num);
						CtrlCustomPanel.__ENCList.Capacity = CtrlCustomPanel.__ENCList.Count;
					}
					CtrlCustomPanel.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x001A54D4 File Offset: 0x001A38D4
		[DebuggerNonUserCode]
		public CtrlCustomPanel(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x001A5500 File Offset: 0x001A3900
		[DebuggerNonUserCode]
		public CtrlCustomPanel()
		{
			CtrlCustomPanel.__ENCAddToList(this);
			this._BackColour2 = Color.White;
			this._BorderColour = SystemColors.WindowFrame;
			this._BorderWidth = 1;
			this._CurveMode = CtrlCustomPanel_CornerCurveMode.All;
			this._GradientMode = CtrlCustomPanel_LinearGradientMode.None;
			this.InitializeComponent();
			this.SetDefaultControlStyles();
			this.BorderStyle = BorderStyle.None;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x001A5560 File Offset: 0x001A3960
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

		// Token: 0x06000E0B RID: 3595 RVA: 0x001A55B0 File Offset: 0x001A39B0
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x001A55C0 File Offset: 0x001A39C0
		private LinearGradientBrush CreateGlassGradientBrush(Rectangle Rectangle, Color Color1, Color Color2)
		{
			bool flag = this._GradientMode == CtrlCustomPanel_LinearGradientMode.None;
			LinearGradientBrush linearGradientBrush;
			if (flag)
			{
				linearGradientBrush = new LinearGradientBrush(Rectangle, Color1, Color2, (LinearGradientMode)this._GradientMode);
			}
			else
			{
				linearGradientBrush = new LinearGradientBrush(Rectangle, Color1, Color2, (LinearGradientMode)this._GradientMode);
			}
			Bitmap bitmap = new Bitmap(1, Rectangle.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Graphics arg_61_0 = graphics;
			Brush arg_61_1 = linearGradientBrush;
			Rectangle rect = new Rectangle(0, 0, 1, Rectangle.Height);
			arg_61_0.FillRectangle(arg_61_1, rect);
			ColorBlend colorBlend = new ColorBlend(4);
			colorBlend.Colors[0] = bitmap.GetPixel(0, 0);
			checked
			{
				colorBlend.Colors[1] = bitmap.GetPixel(0, (int)Math.Round((double)bitmap.Height / 3.0));
				colorBlend.Colors[2] = bitmap.GetPixel(0, bitmap.Height - 1);
				colorBlend.Colors[3] = bitmap.GetPixel(0, (int)Math.Round((double)bitmap.Height / 3.0));
				colorBlend.Positions[0] = 0f;
				colorBlend.Positions[1] = 0.335f;
				colorBlend.Positions[2] = 0.335f;
				colorBlend.Positions[3] = 1f;
				linearGradientBrush.InterpolationColors = colorBlend;
				graphics.Dispose();
				bitmap.Dispose();
				return linearGradientBrush;
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x001A572C File Offset: 0x001A3B2C
		public void DeleteSticky(CtrlStickyNote toDelete)
		{
			this.StickyManager.DeleteSticky(toDelete, this);
			this.StickyParent.RefreshStickyDisplay();
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x001A574C File Offset: 0x001A3B4C
		public static int DoubleToInt(double value)
		{
			return decimal.ToInt32(decimal.Floor(decimal.Parse(value.ToString())));
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x001A5774 File Offset: 0x001A3B74
		private void DrawCurvedPanel(PaintEventArgs pevent)
		{
			pevent.Graphics.Clear(this.GetColorBehindCurve());
			pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
			pevent.Graphics.InterpolationMode = InterpolationMode.High;
			pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			GraphicsPath curvedPath = this.GetCurvedPath();
			Brush backgroundBrush = this.GetBackgroundBrush(pevent);
			pevent.Graphics.FillPath(backgroundBrush, curvedPath);
			backgroundBrush.Dispose();
			bool flag = this._BorderStyle == BorderStyle.FixedSingle && this._BorderWidth > 0;
			if (flag)
			{
				Pen borderPen = this.GetBorderPen(this._BorderColour, this._BorderWidth);
				pevent.Graphics.DrawPath(borderPen, curvedPath);
				borderPen.Dispose();
			}
			curvedPath.Dispose();
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x001A5838 File Offset: 0x001A3C38
		private void DrawRectPanel(PaintEventArgs pevent)
		{
			bool flag = this._GradientMode == CtrlCustomPanel_LinearGradientMode.None || this.BackColor == this._BackColour2;
			if (flag)
			{
				pevent.Graphics.CompositingQuality = CompositingQuality.Invalid;
				pevent.Graphics.InterpolationMode = InterpolationMode.Low;
				pevent.Graphics.PixelOffsetMode = PixelOffsetMode.None;
				pevent.Graphics.SmoothingMode = SmoothingMode.None;
			}
			else
			{
				pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
				pevent.Graphics.InterpolationMode = InterpolationMode.High;
				pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			}
			Brush backgroundBrush = this.GetBackgroundBrush(pevent);
			pevent.Graphics.FillRectangle(backgroundBrush, base.ClientRectangle);
			backgroundBrush.Dispose();
			flag = (this._BorderStyle == BorderStyle.FixedSingle && this._BorderWidth > 0);
			checked
			{
				if (flag)
				{
					Pen borderPen = this.GetBorderPen(this._BorderColour, this._BorderWidth);
					Point location = base.ClientRectangle.Location;
					location.X = (int)Math.Round(unchecked((double)location.X + (double)this._BorderWidth / 2.0));
					location.Y = (int)Math.Round(unchecked((double)location.Y + (double)this._BorderWidth / 2.0));
					Size size = base.ClientRectangle.Size;
					size.Width -= this._BorderWidth;
					size.Height -= this._BorderWidth;
					Rectangle rect = new Rectangle(location, size);
					pevent.Graphics.DrawRectangle(borderPen, rect);
					borderPen.Dispose();
				}
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x001A59F0 File Offset: 0x001A3DF0
		private int GetAdjustedCurve()
		{
			bool flag = this._CurveMode == CtrlCustomPanel_CornerCurveMode.None || this._Curvature == 0;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				flag = ((double)this._Curvature > (double)base.ClientRectangle.Width / 2.0);
				if (flag)
				{
					result = CtrlCustomPanel.DoubleToInt((double)base.ClientRectangle.Width / 2.0);
				}
				else
				{
					flag = ((double)num > (double)base.ClientRectangle.Height / 2.0);
					if (flag)
					{
						result = CtrlCustomPanel.DoubleToInt((double)base.ClientRectangle.Height / 2.0);
					}
					else
					{
						result = this._Curvature;
					}
				}
			}
			return result;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x001A5AC0 File Offset: 0x001A3EC0
		private Brush GetBackgroundBrush(PaintEventArgs pevent)
		{
			bool flag = this._GradientMode == CtrlCustomPanel_LinearGradientMode.None || this.BackColor == this._BackColour2;
			Brush result;
			if (flag)
			{
				result = new SolidBrush(this.BackColor);
			}
			else
			{
				flag = !this._useGlassGradient;
				if (flag)
				{
					result = new LinearGradientBrush(base.ClientRectangle, this.BackColor, this._BackColour2, (LinearGradientMode)this._GradientMode);
				}
				else
				{
					result = this.CreateGlassGradientBrush(base.ClientRectangle, this.BackColor, this._BackColour2);
				}
			}
			return result;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x001A5B4C File Offset: 0x001A3F4C
		private Pen GetBorderPen(Color borderColor, int borderWidth)
		{
			return new Pen(borderColor, (float)borderWidth);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x001A5B68 File Offset: 0x001A3F68
		private Color GetColorBehindCurve()
		{
			Control parent = base.Parent;
			while (parent != null && parent.BackColor == Color.Transparent)
			{
				parent = parent.Parent;
			}
			bool flag = parent == null;
			Color result;
			if (flag)
			{
				result = Color.Transparent;
			}
			else
			{
				result = parent.BackColor;
			}
			return result;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x001A5BC0 File Offset: 0x001A3FC0
		protected GraphicsPath GetCurvedPath()
		{
			Rectangle clientRectangle = base.ClientRectangle;
			int adjustedCurve = this.GetAdjustedCurve();
			int num = 0;
			bool flag = this._BorderStyle == BorderStyle.FixedSingle;
			if (flag)
			{
				bool flag2 = this._BorderWidth > 1;
				if (flag2)
				{
					num = CtrlCustomPanel.DoubleToInt((double)this.BorderWidth / 2.0);
				}
				else
				{
					flag2 = (this._BorderWidth == 1);
					if (flag2)
					{
						num = 1;
					}
				}
			}
			checked
			{
				int num2 = clientRectangle.Width - 1 - num;
				int num3 = clientRectangle.Height - 1 - num;
				GraphicsPath graphicsPath = new GraphicsPath();
				bool flag2 = (this._CurveMode & CtrlCustomPanel_CornerCurveMode.TopRight) != CtrlCustomPanel_CornerCurveMode.None;
				int num4;
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num2 - num4, num, num4, num4, 270f, 90f);
				flag2 = ((this._CurveMode & CtrlCustomPanel_CornerCurveMode.BottomRight) != CtrlCustomPanel_CornerCurveMode.None);
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num2 - num4, num3 - num4, num4, num4, 0f, 90f);
				flag2 = ((this._CurveMode & CtrlCustomPanel_CornerCurveMode.BottomLeft) != CtrlCustomPanel_CornerCurveMode.None);
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num, num3 - num4, num4, num4, 90f, 90f);
				flag2 = ((this._CurveMode & CtrlCustomPanel_CornerCurveMode.TopLeft) != CtrlCustomPanel_CornerCurveMode.None);
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num, num, num4, num4, 180f, 90f);
				graphicsPath.CloseFigure();
				return graphicsPath;
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x001A5D54 File Offset: 0x001A4154
		public Point GetParentFormLocation()
		{
			return this.GetParentFormLocation(this);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x001A5D70 File Offset: 0x001A4170
		private Point GetParentFormLocation(Control c)
		{
			bool flag = c is Form;
			checked
			{
				Point result;
				if (flag)
				{
					result = c.Location;
				}
				else
				{
					flag = (c is SplitterPanel);
					if (flag)
					{
						result = this.GetParentFormLocation(c.Parent);
					}
					else
					{
						flag = (c is SplitContainer);
						if (flag)
						{
							Point parentFormLocation = this.GetParentFormLocation(c.Parent);
							parentFormLocation.X += c.Location.X;
							parentFormLocation.Y += c.Location.Y;
							SplitContainer splitContainer = (SplitContainer)c;
							flag = (splitContainer.Orientation == Orientation.Horizontal);
							if (flag)
							{
								bool flag2 = splitContainer.Panel2 == c;
								if (flag2)
								{
									parentFormLocation.Y += splitContainer.SplitterDistance;
									parentFormLocation.Y += splitContainer.SplitterWidth;
								}
								result = parentFormLocation;
							}
							else
							{
								bool flag2 = splitContainer.Panel2 == c;
								if (flag2)
								{
									parentFormLocation.X += splitContainer.SplitterDistance;
									parentFormLocation.X += splitContainer.SplitterWidth;
								}
								result = parentFormLocation;
							}
						}
						else
						{
							Point parentFormLocation2 = this.GetParentFormLocation(c.Parent);
							parentFormLocation2.X += c.Location.X;
							parentFormLocation2.Y += c.Location.Y;
							result = parentFormLocation2;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x001A5F04 File Offset: 0x001A4304
		public Point GetScreenLocation()
		{
			Point screenLocation = this.GetScreenLocation(this);
			checked
			{
				screenLocation.X += base.Padding.Left;
				screenLocation.Y += base.Padding.Top;
				bool flag = this.BorderStyle == BorderStyle.FixedSingle;
				if (flag)
				{
					screenLocation.X += this.BorderWidth;
					screenLocation.Y += this.BorderWidth;
				}
				return screenLocation;
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x001A5F98 File Offset: 0x001A4398
		private Point GetScreenLocation(Control c)
		{
			bool flag = c is Form;
			checked
			{
				Point result;
				if (flag)
				{
					Point location = c.Location;
					location.Y += 25;
					result = location;
				}
				else
				{
					flag = (c is SplitterPanel);
					if (flag)
					{
						Point screenLocation = this.GetScreenLocation(c.Parent);
						SplitContainer splitContainer = (SplitContainer)c.Parent;
						flag = (splitContainer.Orientation == Orientation.Vertical);
						if (flag)
						{
							bool flag2 = splitContainer.Panel2 == c && !splitContainer.Panel1Collapsed;
							if (flag2)
							{
								screenLocation.X += splitContainer.SplitterDistance;
								screenLocation.X += splitContainer.SplitterWidth;
								screenLocation.X += ((SplitterPanel)c).Padding.Left;
							}
							result = screenLocation;
						}
						else
						{
							bool flag2 = splitContainer.Panel2 == c && !splitContainer.Panel1Collapsed;
							if (flag2)
							{
								screenLocation.Y += splitContainer.SplitterDistance;
								screenLocation.Y += splitContainer.SplitterWidth;
								screenLocation.Y += ((SplitterPanel)c).Padding.Top;
							}
							result = screenLocation;
						}
					}
					else
					{
						bool flag2 = c is CtrlCustomPanel;
						if (flag2)
						{
							Point screenLocation2 = this.GetScreenLocation(c.Parent);
							screenLocation2.X += c.Location.X;
							screenLocation2.Y += c.Location.Y;
							flag2 = (((CtrlCustomPanel)c).BorderStyle == BorderStyle.FixedSingle);
							if (flag2)
							{
								screenLocation2.X += ((CtrlCustomPanel)c).BorderWidth;
								screenLocation2.Y += ((CtrlCustomPanel)c).BorderWidth;
							}
							result = screenLocation2;
						}
						else
						{
							Point screenLocation3 = this.GetScreenLocation(c.Parent);
							screenLocation3.X += c.Location.X;
							screenLocation3.Y += c.Location.Y;
							result = screenLocation3;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x001A61FC File Offset: 0x001A45FC
		public void HideAllStickies()
		{
			this.StickyManager.IsShowingStickies = false;
			this.RefreshStickyDisplay();
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x001A6214 File Offset: 0x001A4614
		private bool IsNormalPanel()
		{
			bool flag = this._CurveMode != CtrlCustomPanel_CornerCurveMode.None && this._Curvature > 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				flag = (this._BorderStyle == BorderStyle.FixedSingle && this._BorderWidth > 0);
				if (flag)
				{
					result = false;
				}
				else
				{
					flag = (this.BackColor != this._BackColour2 && this._GradientMode != CtrlCustomPanel_LinearGradientMode.None);
					result = !flag;
				}
			}
			return result;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x001A6294 File Offset: 0x001A4694
		public void MoveTop(int targetTop)
		{
			checked
			{
				int num = targetTop - base.Top;
				base.Top = targetTop;
				base.Height -= num;
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x001A62C4 File Offset: 0x001A46C4
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			bool flag = this.IsNormalPanel();
			if (flag)
			{
				base.OnPaintBackground(pevent);
			}
			else
			{
				flag = (this._CurveMode == CtrlCustomPanel_CornerCurveMode.None || this._Curvature == 0);
				if (flag)
				{
					this.DrawRectPanel(pevent);
				}
				else
				{
					this.DrawCurvedPanel(pevent);
				}
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x001A6318 File Offset: 0x001A4718
		public void RefreshStickyDisplay()
		{
			this.StickyParent.RefreshStickyDisplay();
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x001A6328 File Offset: 0x001A4728
		public void ScrollPanel(MouseEventArgs e)
		{
			this.OnMouseWheel(e);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x001A6334 File Offset: 0x001A4734
		private void SetDefaultControlStyles()
		{
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.UserMouse, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.ContainerControl, true);
			base.UpdateStyles();
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x001A6390 File Offset: 0x001A4790
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x001A63A8 File Offset: 0x001A47A8
		[DefaultValue(typeof(Color), "Window"), Description("The secondary background color used to paint the control."), Category("Appearance")]
		public Color BackColor2
		{
			get
			{
				return this._BackColour2;
			}
			set
			{
				this._BackColour2 = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x001A63D0 File Offset: 0x001A47D0
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x001A63E8 File Offset: 0x001A47E8
		[Description("The border color used to paint the control."), DefaultValue(typeof(Color), "WindowFrame"), Category("Appearance")]
		public Color BorderColor
		{
			get
			{
				return this._BorderColour;
			}
			set
			{
				this._BorderColour = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x001A6410 File Offset: 0x001A4810
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x001A6428 File Offset: 0x001A4828
		[Description("The border style used to paint the control."), Category("Appearance"), DefaultValue(typeof(BorderStyle), "None")]
		public new BorderStyle BorderStyle
		{
			get
			{
				return this._BorderStyle;
			}
			set
			{
				this._BorderStyle = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x001A6450 File Offset: 0x001A4850
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x001A6468 File Offset: 0x001A4868
		[DefaultValue(typeof(int), "1"), Description("The width of the border used to paint the control."), Category("Appearance")]
		public int BorderWidth
		{
			get
			{
				return this._BorderWidth;
			}
			set
			{
				this._BorderWidth = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x001A6490 File Offset: 0x001A4890
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x001A64A8 File Offset: 0x001A48A8
		[Category("Appearance"), DefaultValue(typeof(int), "0"), Description("The radius of the curve used to paint the corners of the control.")]
		public int Curvature
		{
			get
			{
				return this._Curvature;
			}
			set
			{
				this._Curvature = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x001A64D0 File Offset: 0x001A48D0
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x001A64E8 File Offset: 0x001A48E8
		[Description("The style of the curves to be drawn on the control."), Category("Appearance"), DefaultValue(typeof(CtrlCustomPanel_CornerCurveMode), "All")]
		public CtrlCustomPanel_CornerCurveMode CurveMode
		{
			get
			{
				return this._CurveMode;
			}
			set
			{
				this._CurveMode = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x001A6510 File Offset: 0x001A4910
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x001A6528 File Offset: 0x001A4928
		[Description("The gradient direction used to paint the control."), Category("Appearance"), DefaultValue(typeof(CtrlCustomPanel_LinearGradientMode), "None")]
		public CtrlCustomPanel_LinearGradientMode GradientMode
		{
			get
			{
				return this._GradientMode;
			}
			set
			{
				this._GradientMode = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x001A6550 File Offset: 0x001A4950
		public StickyManager StickyManager
		{
			get
			{
				bool flag = this._stickyManager == null;
				if (flag)
				{
					this._stickyManager = new StickyManager();
				}
				return this._stickyManager;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x001A6584 File Offset: 0x001A4984
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x001A659C File Offset: 0x001A499C
		public IStickyControl StickyParent
		{
			get
			{
				return this._stickyParent;
			}
			set
			{
				this._stickyParent = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x001A65A8 File Offset: 0x001A49A8
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x001A65C0 File Offset: 0x001A49C0
		[DefaultValue(typeof(bool), "false"), Category("Appearance"), Description("To call base.PaintBackround or not.")]
		public bool UseBasePaintFirst
		{
			get
			{
				return this._useBasePaintFirst;
			}
			set
			{
				this._useBasePaintFirst = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x001A65E8 File Offset: 0x001A49E8
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x001A6600 File Offset: 0x001A4A00
		[Description("To use glass effect gradient or not."), DefaultValue(typeof(bool), "false"), Category("Appearance")]
		public bool UseGlassGradient
		{
			get
			{
				return this._useGlassGradient;
			}
			set
			{
				this._useGlassGradient = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x0400055A RID: 1370
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400055B RID: 1371
		private IContainer components;

		// Token: 0x0400055C RID: 1372
		private Color _BackColour2;

		// Token: 0x0400055D RID: 1373
		private Color _BorderColour;

		// Token: 0x0400055E RID: 1374
		private BorderStyle _BorderStyle;

		// Token: 0x0400055F RID: 1375
		private int _BorderWidth;

		// Token: 0x04000560 RID: 1376
		private int _Curvature;

		// Token: 0x04000561 RID: 1377
		private CtrlCustomPanel_CornerCurveMode _CurveMode;

		// Token: 0x04000562 RID: 1378
		private CtrlCustomPanel_LinearGradientMode _GradientMode;

		// Token: 0x04000563 RID: 1379
		private bool _useBasePaintFirst;

		// Token: 0x04000564 RID: 1380
		private bool _useGlassGradient;

		// Token: 0x04000565 RID: 1381
		private StickyManager _stickyManager;

		// Token: 0x04000566 RID: 1382
		private IStickyControl _stickyParent;
	}
}
