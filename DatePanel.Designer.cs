using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX.EditControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000093 RID: 147
	[DesignerGenerated]
	public class DatePanel : UserControl
	{
		// Token: 0x06000C9C RID: 3228 RVA: 0x0019DFB0 File Offset: 0x0019C3B0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DatePanel.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DatePanel.__ENCList.Count == DatePanel.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DatePanel.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DatePanel.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DatePanel.__ENCList[num] = DatePanel.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DatePanel.__ENCList.RemoveRange(num, DatePanel.__ENCList.Count - num);
						DatePanel.__ENCList.Capacity = DatePanel.__ENCList.Count;
					}
					DatePanel.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0019E0B4 File Offset: 0x0019C4B4
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

		// Token: 0x06000C9E RID: 3230 RVA: 0x0019E104 File Offset: 0x0019C504
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem9 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem10 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem11 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem12 = new UIComboBoxItem();
			this.UiGroupBox1 = new UIGroupBox();
			this.LinkLabel1 = new LinkLabel();
			this.btn35 = new UIButton();
			this.btn34 = new UIButton();
			this.btn33 = new UIButton();
			this.btn28 = new UIButton();
			this.btn27 = new UIButton();
			this.btn26 = new UIButton();
			this.btn21 = new UIButton();
			this.btn20 = new UIButton();
			this.btn19 = new UIButton();
			this.btn32 = new UIButton();
			this.btn14 = new UIButton();
			this.btn13 = new UIButton();
			this.btn25 = new UIButton();
			this.btn12 = new UIButton();
			this.btn18 = new UIButton();
			this.btn31 = new UIButton();
			this.btn7 = new UIButton();
			this.btn6 = new UIButton();
			this.btn24 = new UIButton();
			this.btn11 = new UIButton();
			this.btn17 = new UIButton();
			this.btn30 = new UIButton();
			this.btn5 = new UIButton();
			this.btn23 = new UIButton();
			this.btn10 = new UIButton();
			this.btn16 = new UIButton();
			this.btn29 = new UIButton();
			this.btn4 = new UIButton();
			this.btn22 = new UIButton();
			this.btn9 = new UIButton();
			this.btn15 = new UIButton();
			this.btn3 = new UIButton();
			this.btn8 = new UIButton();
			this.btn2 = new UIButton();
			this.btn1 = new UIButton();
			this.Label7 = new Label();
			this.Label6 = new Label();
			this.Label5 = new Label();
			this.Label4 = new Label();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.UiComboBox1 = new UIComboBox();
			this.IntegerUpDown1 = new IntegerUpDown();
			this.Panel1 = new Panel();
			this.UiGroupBox1.BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.set_BackgroundStyle(2);
			this.UiGroupBox1.Controls.Add(this.LinkLabel1);
			this.UiGroupBox1.Controls.Add(this.btn35);
			this.UiGroupBox1.Controls.Add(this.btn34);
			this.UiGroupBox1.Controls.Add(this.btn33);
			this.UiGroupBox1.Controls.Add(this.btn28);
			this.UiGroupBox1.Controls.Add(this.btn27);
			this.UiGroupBox1.Controls.Add(this.btn26);
			this.UiGroupBox1.Controls.Add(this.btn21);
			this.UiGroupBox1.Controls.Add(this.btn20);
			this.UiGroupBox1.Controls.Add(this.btn19);
			this.UiGroupBox1.Controls.Add(this.btn32);
			this.UiGroupBox1.Controls.Add(this.btn14);
			this.UiGroupBox1.Controls.Add(this.btn13);
			this.UiGroupBox1.Controls.Add(this.btn25);
			this.UiGroupBox1.Controls.Add(this.btn12);
			this.UiGroupBox1.Controls.Add(this.btn18);
			this.UiGroupBox1.Controls.Add(this.btn31);
			this.UiGroupBox1.Controls.Add(this.btn7);
			this.UiGroupBox1.Controls.Add(this.btn6);
			this.UiGroupBox1.Controls.Add(this.btn24);
			this.UiGroupBox1.Controls.Add(this.btn11);
			this.UiGroupBox1.Controls.Add(this.btn17);
			this.UiGroupBox1.Controls.Add(this.btn30);
			this.UiGroupBox1.Controls.Add(this.btn5);
			this.UiGroupBox1.Controls.Add(this.btn23);
			this.UiGroupBox1.Controls.Add(this.btn10);
			this.UiGroupBox1.Controls.Add(this.btn16);
			this.UiGroupBox1.Controls.Add(this.btn29);
			this.UiGroupBox1.Controls.Add(this.btn4);
			this.UiGroupBox1.Controls.Add(this.btn22);
			this.UiGroupBox1.Controls.Add(this.btn9);
			this.UiGroupBox1.Controls.Add(this.btn15);
			this.UiGroupBox1.Controls.Add(this.btn3);
			this.UiGroupBox1.Controls.Add(this.btn8);
			this.UiGroupBox1.Controls.Add(this.btn2);
			this.UiGroupBox1.Controls.Add(this.btn1);
			this.UiGroupBox1.Controls.Add(this.Label7);
			this.UiGroupBox1.Controls.Add(this.Label6);
			this.UiGroupBox1.Controls.Add(this.Label5);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.UiComboBox1);
			this.UiGroupBox1.Controls.Add(this.IntegerUpDown1);
			this.UiGroupBox1.Dock = DockStyle.Fill;
			this.UiGroupBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			this.UiGroupBox1.set_FrameStyle(0);
			Control arg_716_0 = this.UiGroupBox1;
			Point location = new Point(0, 0);
			arg_716_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			Control arg_747_0 = this.UiGroupBox1;
			Size size = new Size(263, 275);
			arg_747_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.set_VisualStyle(6);
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.BackColor = Color.Transparent;
			this.LinkLabel1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_7BE_0 = this.LinkLabel1;
			location = new Point(12, 242);
			arg_7BE_0.Location = location;
			this.LinkLabel1.Name = "LinkLabel1";
			Control arg_7E8_0 = this.LinkLabel1;
			size = new Size(0, 28);
			arg_7E8_0.Size = size;
			this.LinkLabel1.TabIndex = 4;
			this.btn35.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_833_0 = this.btn35;
			location = new Point(7, 203);
			arg_833_0.Location = location;
			this.btn35.Name = "btn35";
			this.btn35.set_OfficeColorScheme(2);
			this.btn35.RightToLeft = RightToLeft.Yes;
			Control arg_878_0 = this.btn35;
			size = new Size(33, 33);
			arg_878_0.Size = size;
			this.btn35.TabIndex = 3;
			this.btn35.Text = "35";
			this.btn35.set_VisualStyle(7);
			this.btn34.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_8E2_0 = this.btn34;
			location = new Point(39, 203);
			arg_8E2_0.Location = location;
			this.btn34.Name = "btn34";
			this.btn34.RightToLeft = RightToLeft.Yes;
			Control arg_91A_0 = this.btn34;
			size = new Size(33, 33);
			arg_91A_0.Size = size;
			this.btn34.TabIndex = 3;
			this.btn34.Text = "34";
			this.btn34.set_VisualStyle(7);
			this.btn33.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_984_0 = this.btn33;
			location = new Point(71, 203);
			arg_984_0.Location = location;
			this.btn33.Name = "btn33";
			this.btn33.RightToLeft = RightToLeft.Yes;
			Control arg_9BC_0 = this.btn33;
			size = new Size(33, 33);
			arg_9BC_0.Size = size;
			this.btn33.TabIndex = 3;
			this.btn33.Text = "33";
			this.btn33.set_VisualStyle(7);
			this.btn28.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_A25_0 = this.btn28;
			location = new Point(7, 175);
			arg_A25_0.Location = location;
			this.btn28.Name = "btn28";
			this.btn28.set_OfficeColorScheme(2);
			this.btn28.RightToLeft = RightToLeft.Yes;
			Control arg_A6A_0 = this.btn28;
			size = new Size(33, 33);
			arg_A6A_0.Size = size;
			this.btn28.TabIndex = 3;
			this.btn28.Text = "28";
			this.btn28.set_VisualStyle(7);
			this.btn27.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_AD4_0 = this.btn27;
			location = new Point(39, 175);
			arg_AD4_0.Location = location;
			this.btn27.Name = "btn27";
			this.btn27.RightToLeft = RightToLeft.Yes;
			Control arg_B0C_0 = this.btn27;
			size = new Size(33, 33);
			arg_B0C_0.Size = size;
			this.btn27.TabIndex = 3;
			this.btn27.Text = "1";
			this.btn27.set_VisualStyle(7);
			this.btn26.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_B76_0 = this.btn26;
			location = new Point(71, 175);
			arg_B76_0.Location = location;
			this.btn26.Name = "btn26";
			this.btn26.RightToLeft = RightToLeft.Yes;
			Control arg_BAE_0 = this.btn26;
			size = new Size(33, 33);
			arg_BAE_0.Size = size;
			this.btn26.TabIndex = 3;
			this.btn26.Text = "1";
			this.btn26.set_VisualStyle(7);
			this.btn21.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_C17_0 = this.btn21;
			location = new Point(7, 146);
			arg_C17_0.Location = location;
			this.btn21.Name = "btn21";
			this.btn21.set_OfficeColorScheme(2);
			this.btn21.RightToLeft = RightToLeft.Yes;
			Control arg_C5C_0 = this.btn21;
			size = new Size(33, 33);
			arg_C5C_0.Size = size;
			this.btn21.TabIndex = 3;
			this.btn21.Text = "21";
			this.btn21.set_VisualStyle(7);
			this.btn20.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_CC6_0 = this.btn20;
			location = new Point(39, 145);
			arg_CC6_0.Location = location;
			this.btn20.Name = "btn20";
			this.btn20.RightToLeft = RightToLeft.Yes;
			Control arg_CFE_0 = this.btn20;
			size = new Size(33, 33);
			arg_CFE_0.Size = size;
			this.btn20.TabIndex = 3;
			this.btn20.Text = "1";
			this.btn20.set_VisualStyle(7);
			this.btn19.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_D68_0 = this.btn19;
			location = new Point(71, 146);
			arg_D68_0.Location = location;
			this.btn19.Name = "btn19";
			this.btn19.RightToLeft = RightToLeft.Yes;
			Control arg_DA0_0 = this.btn19;
			size = new Size(33, 33);
			arg_DA0_0.Size = size;
			this.btn19.TabIndex = 3;
			this.btn19.Text = "1";
			this.btn19.set_VisualStyle(7);
			this.btn32.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_E0A_0 = this.btn32;
			location = new Point(103, 203);
			arg_E0A_0.Location = location;
			this.btn32.Name = "btn32";
			this.btn32.RightToLeft = RightToLeft.Yes;
			Control arg_E42_0 = this.btn32;
			size = new Size(33, 33);
			arg_E42_0.Size = size;
			this.btn32.TabIndex = 3;
			this.btn32.Text = "32";
			this.btn32.set_VisualStyle(7);
			this.btn14.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_EA8_0 = this.btn14;
			location = new Point(7, 117);
			arg_EA8_0.Location = location;
			this.btn14.Name = "btn14";
			this.btn14.set_OfficeColorScheme(2);
			this.btn14.RightToLeft = RightToLeft.Yes;
			Control arg_EED_0 = this.btn14;
			size = new Size(33, 33);
			arg_EED_0.Size = size;
			this.btn14.TabIndex = 3;
			this.btn14.Text = "14";
			this.btn14.set_VisualStyle(7);
			this.btn13.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_F54_0 = this.btn13;
			location = new Point(39, 117);
			arg_F54_0.Location = location;
			this.btn13.Name = "btn13";
			this.btn13.RightToLeft = RightToLeft.Yes;
			Control arg_F8C_0 = this.btn13;
			size = new Size(33, 33);
			arg_F8C_0.Size = size;
			this.btn13.TabIndex = 3;
			this.btn13.Text = "13";
			this.btn13.set_VisualStyle(7);
			this.btn25.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_FF6_0 = this.btn25;
			location = new Point(103, 175);
			arg_FF6_0.Location = location;
			this.btn25.Name = "btn25";
			this.btn25.RightToLeft = RightToLeft.Yes;
			Control arg_102E_0 = this.btn25;
			size = new Size(33, 33);
			arg_102E_0.Size = size;
			this.btn25.TabIndex = 3;
			this.btn25.Text = "1";
			this.btn25.set_VisualStyle(7);
			this.btn12.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1095_0 = this.btn12;
			location = new Point(71, 117);
			arg_1095_0.Location = location;
			this.btn12.Name = "btn12";
			this.btn12.RightToLeft = RightToLeft.Yes;
			Control arg_10CD_0 = this.btn12;
			size = new Size(33, 33);
			arg_10CD_0.Size = size;
			this.btn12.TabIndex = 3;
			this.btn12.Text = "12";
			this.btn12.set_VisualStyle(7);
			this.btn18.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1137_0 = this.btn18;
			location = new Point(103, 146);
			arg_1137_0.Location = location;
			this.btn18.Name = "btn18";
			this.btn18.RightToLeft = RightToLeft.Yes;
			Control arg_116F_0 = this.btn18;
			size = new Size(33, 33);
			arg_116F_0.Size = size;
			this.btn18.TabIndex = 3;
			this.btn18.Text = "1";
			this.btn18.set_VisualStyle(7);
			this.btn31.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_11DC_0 = this.btn31;
			location = new Point(135, 203);
			arg_11DC_0.Location = location;
			this.btn31.Name = "btn31";
			this.btn31.RightToLeft = RightToLeft.Yes;
			Control arg_1214_0 = this.btn31;
			size = new Size(33, 33);
			arg_1214_0.Size = size;
			this.btn31.TabIndex = 3;
			this.btn31.Text = "31";
			this.btn31.set_VisualStyle(7);
			this.btn7.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_127A_0 = this.btn7;
			location = new Point(7, 88);
			arg_127A_0.Location = location;
			this.btn7.Name = "btn7";
			this.btn7.set_OfficeColorScheme(2);
			this.btn7.RightToLeft = RightToLeft.Yes;
			Control arg_12BF_0 = this.btn7;
			size = new Size(33, 33);
			arg_12BF_0.Size = size;
			this.btn7.TabIndex = 3;
			this.btn7.Text = "7";
			this.btn7.set_VisualStyle(7);
			this.btn6.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1326_0 = this.btn6;
			location = new Point(39, 88);
			arg_1326_0.Location = location;
			this.btn6.Name = "btn6";
			this.btn6.RightToLeft = RightToLeft.Yes;
			Control arg_135E_0 = this.btn6;
			size = new Size(33, 33);
			arg_135E_0.Size = size;
			this.btn6.TabIndex = 3;
			this.btn6.Text = "6";
			this.btn6.set_VisualStyle(7);
			this.btn24.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_13CB_0 = this.btn24;
			location = new Point(135, 175);
			arg_13CB_0.Location = location;
			this.btn24.Name = "btn24";
			this.btn24.RightToLeft = RightToLeft.Yes;
			Control arg_1403_0 = this.btn24;
			size = new Size(33, 33);
			arg_1403_0.Size = size;
			this.btn24.TabIndex = 3;
			this.btn24.Text = "1";
			this.btn24.set_VisualStyle(7);
			this.btn11.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_146A_0 = this.btn11;
			location = new Point(103, 117);
			arg_146A_0.Location = location;
			this.btn11.Name = "btn11";
			this.btn11.RightToLeft = RightToLeft.Yes;
			Control arg_14A2_0 = this.btn11;
			size = new Size(33, 33);
			arg_14A2_0.Size = size;
			this.btn11.TabIndex = 3;
			this.btn11.Text = "11";
			this.btn11.set_VisualStyle(7);
			this.btn17.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_150F_0 = this.btn17;
			location = new Point(135, 146);
			arg_150F_0.Location = location;
			this.btn17.Name = "btn17";
			this.btn17.RightToLeft = RightToLeft.Yes;
			Control arg_1547_0 = this.btn17;
			size = new Size(33, 33);
			arg_1547_0.Size = size;
			this.btn17.TabIndex = 3;
			this.btn17.Text = "1";
			this.btn17.set_VisualStyle(7);
			this.btn30.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_15B4_0 = this.btn30;
			location = new Point(167, 203);
			arg_15B4_0.Location = location;
			this.btn30.Name = "btn30";
			this.btn30.RightToLeft = RightToLeft.Yes;
			Control arg_15EC_0 = this.btn30;
			size = new Size(33, 33);
			arg_15EC_0.Size = size;
			this.btn30.TabIndex = 3;
			this.btn30.Text = "30";
			this.btn30.set_VisualStyle(7);
			this.btn5.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1653_0 = this.btn5;
			location = new Point(71, 88);
			arg_1653_0.Location = location;
			this.btn5.Name = "btn5";
			this.btn5.RightToLeft = RightToLeft.Yes;
			Control arg_168B_0 = this.btn5;
			size = new Size(33, 33);
			arg_168B_0.Size = size;
			this.btn5.TabIndex = 3;
			this.btn5.Text = "5";
			this.btn5.set_VisualStyle(7);
			this.btn23.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_16F8_0 = this.btn23;
			location = new Point(167, 175);
			arg_16F8_0.Location = location;
			this.btn23.Name = "btn23";
			this.btn23.RightToLeft = RightToLeft.Yes;
			Control arg_1730_0 = this.btn23;
			size = new Size(33, 33);
			arg_1730_0.Size = size;
			this.btn23.TabIndex = 3;
			this.btn23.Text = "1";
			this.btn23.set_VisualStyle(7);
			this.btn10.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_179A_0 = this.btn10;
			location = new Point(135, 117);
			arg_179A_0.Location = location;
			this.btn10.Name = "btn10";
			this.btn10.RightToLeft = RightToLeft.Yes;
			Control arg_17D2_0 = this.btn10;
			size = new Size(33, 33);
			arg_17D2_0.Size = size;
			this.btn10.TabIndex = 3;
			this.btn10.Text = "10";
			this.btn10.set_VisualStyle(7);
			this.btn16.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_183F_0 = this.btn16;
			location = new Point(167, 145);
			arg_183F_0.Location = location;
			this.btn16.Name = "btn16";
			this.btn16.RightToLeft = RightToLeft.Yes;
			Control arg_1877_0 = this.btn16;
			size = new Size(33, 33);
			arg_1877_0.Size = size;
			this.btn16.TabIndex = 3;
			this.btn16.Text = "1";
			this.btn16.set_VisualStyle(7);
			this.btn29.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_18E4_0 = this.btn29;
			location = new Point(199, 203);
			arg_18E4_0.Location = location;
			this.btn29.Name = "btn29";
			this.btn29.RightToLeft = RightToLeft.Yes;
			Control arg_191C_0 = this.btn29;
			size = new Size(33, 33);
			arg_191C_0.Size = size;
			this.btn29.TabIndex = 3;
			this.btn29.Text = "29";
			this.btn29.set_VisualStyle(7);
			this.btn4.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1983_0 = this.btn4;
			location = new Point(103, 88);
			arg_1983_0.Location = location;
			this.btn4.Name = "btn4";
			this.btn4.RightToLeft = RightToLeft.Yes;
			Control arg_19BB_0 = this.btn4;
			size = new Size(33, 33);
			arg_19BB_0.Size = size;
			this.btn4.TabIndex = 3;
			this.btn4.Text = "4";
			this.btn4.set_VisualStyle(7);
			this.btn22.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1A28_0 = this.btn22;
			location = new Point(199, 175);
			arg_1A28_0.Location = location;
			this.btn22.Name = "btn22";
			this.btn22.RightToLeft = RightToLeft.Yes;
			Control arg_1A60_0 = this.btn22;
			size = new Size(33, 33);
			arg_1A60_0.Size = size;
			this.btn22.TabIndex = 3;
			this.btn22.Text = "24";
			this.btn22.set_VisualStyle(7);
			this.btn9.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1ACA_0 = this.btn9;
			location = new Point(167, 117);
			arg_1ACA_0.Location = location;
			this.btn9.Name = "btn9";
			this.btn9.RightToLeft = RightToLeft.Yes;
			Control arg_1B02_0 = this.btn9;
			size = new Size(33, 33);
			arg_1B02_0.Size = size;
			this.btn9.TabIndex = 3;
			this.btn9.Text = "9";
			this.btn9.set_VisualStyle(7);
			this.btn15.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1B6F_0 = this.btn15;
			location = new Point(199, 146);
			arg_1B6F_0.Location = location;
			this.btn15.Name = "btn15";
			this.btn15.RightToLeft = RightToLeft.Yes;
			Control arg_1BA7_0 = this.btn15;
			size = new Size(33, 33);
			arg_1BA7_0.Size = size;
			this.btn15.TabIndex = 3;
			this.btn15.Text = "15";
			this.btn15.set_VisualStyle(7);
			this.btn3.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1C11_0 = this.btn3;
			location = new Point(135, 88);
			arg_1C11_0.Location = location;
			this.btn3.Name = "btn3";
			this.btn3.RightToLeft = RightToLeft.Yes;
			Control arg_1C49_0 = this.btn3;
			size = new Size(33, 33);
			arg_1C49_0.Size = size;
			this.btn3.TabIndex = 3;
			this.btn3.Text = "3";
			this.btn3.set_VisualStyle(7);
			this.btn8.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1CB3_0 = this.btn8;
			location = new Point(199, 117);
			arg_1CB3_0.Location = location;
			this.btn8.Name = "btn8";
			this.btn8.RightToLeft = RightToLeft.Yes;
			Control arg_1CEB_0 = this.btn8;
			size = new Size(33, 33);
			arg_1CEB_0.Size = size;
			this.btn8.TabIndex = 3;
			this.btn8.Text = "8";
			this.btn8.set_VisualStyle(7);
			this.btn2.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1D55_0 = this.btn2;
			location = new Point(167, 88);
			arg_1D55_0.Location = location;
			this.btn2.Name = "btn2";
			this.btn2.RightToLeft = RightToLeft.Yes;
			Control arg_1D8D_0 = this.btn2;
			size = new Size(33, 33);
			arg_1D8D_0.Size = size;
			this.btn2.TabIndex = 3;
			this.btn2.Text = "2";
			this.btn2.set_VisualStyle(7);
			this.btn1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1DF7_0 = this.btn1;
			location = new Point(199, 88);
			arg_1DF7_0.Location = location;
			this.btn1.Name = "btn1";
			this.btn1.RightToLeft = RightToLeft.Yes;
			Control arg_1E2F_0 = this.btn1;
			size = new Size(33, 33);
			arg_1E2F_0.Size = size;
			this.btn1.TabIndex = 3;
			this.btn1.Text = "1";
			this.btn1.set_VisualStyle(7);
			this.Label7.AutoSize = true;
			this.Label7.BackColor = Color.Transparent;
			this.Label7.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1EB4_0 = this.Label7;
			location = new Point(13, 56);
			arg_1EB4_0.Location = location;
			this.Label7.Name = "Label7";
			Control arg_1EDF_0 = this.Label7;
			size = new Size(24, 28);
			arg_1EDF_0.Size = size;
			this.Label7.TabIndex = 2;
			this.Label7.Text = "ج";
			this.Label6.AutoSize = true;
			this.Label6.BackColor = Color.Transparent;
			this.Label6.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1F57_0 = this.Label6;
			location = new Point(41, 56);
			arg_1F57_0.Location = location;
			this.Label6.Name = "Label6";
			Control arg_1F82_0 = this.Label6;
			size = new Size(27, 28);
			arg_1F82_0.Size = size;
			this.Label6.TabIndex = 2;
			this.Label6.Text = "پ";
			this.Label5.AutoSize = true;
			this.Label5.BackColor = Color.Transparent;
			this.Label5.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1FFA_0 = this.Label5;
			location = new Point(75, 56);
			arg_1FFA_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_2025_0 = this.Label5;
			size = new Size(24, 28);
			arg_2025_0.Size = size;
			this.Label5.TabIndex = 2;
			this.Label5.Text = "چ";
			this.Label4.AutoSize = true;
			this.Label4.BackColor = Color.Transparent;
			this.Label4.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_209D_0 = this.Label4;
			location = new Point(102, 56);
			arg_209D_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_20C8_0 = this.Label4;
			size = new Size(32, 28);
			arg_20C8_0.Size = size;
			this.Label4.TabIndex = 2;
			this.Label4.Text = "س";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = Color.Transparent;
			this.Label3.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_2143_0 = this.Label3;
			location = new Point(140, 56);
			arg_2143_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_216E_0 = this.Label3;
			size = new Size(19, 28);
			arg_216E_0.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "د";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = Color.Transparent;
			this.Label2.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_21E9_0 = this.Label2;
			location = new Point(169, 56);
			arg_21E9_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_2214_0 = this.Label2;
			size = new Size(26, 28);
			arg_2214_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "ی";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = Color.Transparent;
			this.Label1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_228F_0 = this.Label1;
			location = new Point(200, 56);
			arg_228F_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_22BA_0 = this.Label1;
			size = new Size(32, 28);
			arg_22BA_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "ش";
			this.UiComboBox1.set_ComboStyle(1);
			this.UiComboBox1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			uIComboBoxItem.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem.set_IsSeparator(false);
			uIComboBoxItem.set_Text("فروردین");
			uIComboBoxItem.set_Value("1");
			uIComboBoxItem2.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem2.set_IsSeparator(false);
			uIComboBoxItem2.set_Text("اردیبهشت");
			uIComboBoxItem2.set_Value("2");
			uIComboBoxItem3.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem3.set_IsSeparator(false);
			uIComboBoxItem3.set_Text("خرداد");
			uIComboBoxItem3.set_Value("3");
			uIComboBoxItem4.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem4.set_IsSeparator(false);
			uIComboBoxItem4.set_Text("تیر");
			uIComboBoxItem4.set_Value("4");
			uIComboBoxItem5.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem5.set_IsSeparator(false);
			uIComboBoxItem5.set_Text("مرداد");
			uIComboBoxItem5.set_Value("5");
			uIComboBoxItem6.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem6.set_IsSeparator(false);
			uIComboBoxItem6.set_Text("شهریور");
			uIComboBoxItem6.set_Value("6");
			uIComboBoxItem7.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem7.set_IsSeparator(false);
			uIComboBoxItem7.set_Text("مهر");
			uIComboBoxItem7.set_Value("7");
			uIComboBoxItem8.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem8.set_IsSeparator(false);
			uIComboBoxItem8.set_Text("آبان");
			uIComboBoxItem8.set_Value("8");
			uIComboBoxItem9.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem9.set_IsSeparator(false);
			uIComboBoxItem9.set_Text("آذر");
			uIComboBoxItem9.set_Value("9");
			uIComboBoxItem10.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem10.set_IsSeparator(false);
			uIComboBoxItem10.set_Text("دی");
			uIComboBoxItem10.set_Value("10");
			uIComboBoxItem11.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem11.set_IsSeparator(false);
			uIComboBoxItem11.set_Text("بهمن");
			uIComboBoxItem11.set_Value("11");
			uIComboBoxItem12.get_FormatStyle().set_Alpha(0);
			uIComboBoxItem12.set_IsSeparator(false);
			uIComboBoxItem12.set_Text("اسفند");
			uIComboBoxItem12.set_Value("12");
			this.UiComboBox1.get_Items().AddRange(new UIComboBoxItem[]
			{
				uIComboBoxItem,
				uIComboBoxItem2,
				uIComboBoxItem3,
				uIComboBoxItem4,
				uIComboBoxItem5,
				uIComboBoxItem6,
				uIComboBoxItem7,
				uIComboBoxItem8,
				uIComboBoxItem9,
				uIComboBoxItem10,
				uIComboBoxItem11,
				uIComboBoxItem12
			});
			Control arg_25CC_0 = this.UiComboBox1;
			location = new Point(88, 13);
			arg_25CC_0.Location = location;
			this.UiComboBox1.Name = "UiComboBox1";
			Control arg_25FA_0 = this.UiComboBox1;
			size = new Size(144, 36);
			arg_25FA_0.Size = size;
			this.UiComboBox1.TabIndex = 1;
			this.UiComboBox1.set_VisualStyle(7);
			this.IntegerUpDown1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_2650_0 = this.IntegerUpDown1;
			location = new Point(14, 13);
			arg_2650_0.Location = location;
			this.IntegerUpDown1.set_Maximum(1450);
			this.IntegerUpDown1.set_Minimum(1300);
			this.IntegerUpDown1.Name = "IntegerUpDown1";
			this.IntegerUpDown1.RightToLeft = RightToLeft.Yes;
			Control arg_26AA_0 = this.IntegerUpDown1;
			size = new Size(68, 36);
			arg_26AA_0.Size = size;
			this.IntegerUpDown1.TabIndex = 0;
			this.IntegerUpDown1.set_Value(1391);
			this.IntegerUpDown1.set_VisualStyle(6);
			this.Panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Panel1.BackColor = Color.Transparent;
			this.Panel1.Controls.Add(this.UiGroupBox1);
			Control arg_2723_0 = this.Panel1;
			location = new Point(0, 0);
			arg_2723_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_2754_0 = this.Panel1;
			size = new Size(263, 275);
			arg_2754_0.Size = size;
			this.Panel1.TabIndex = 5;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.Panel1);
			this.Name = "DatePanel";
			size = new Size(263, 275);
			this.Size = size;
			this.UiGroupBox1.EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x001A0910 File Offset: 0x0019ED10
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x001A0928 File Offset: 0x0019ED28
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

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x001A0934 File Offset: 0x0019ED34
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x001A094C File Offset: 0x0019ED4C
		internal virtual IntegerUpDown IntegerUpDown1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IntegerUpDown1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.IntegerUpDown1_ValueChanged);
				bool flag = this._IntegerUpDown1 != null;
				if (flag)
				{
					this._IntegerUpDown1.remove_ValueChanged(eventHandler);
				}
				this._IntegerUpDown1 = value;
				flag = (this._IntegerUpDown1 != null);
				if (flag)
				{
					this._IntegerUpDown1.add_ValueChanged(eventHandler);
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x001A09AC File Offset: 0x0019EDAC
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x001A09C4 File Offset: 0x0019EDC4
		internal virtual UIComboBox UiComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UiComboBox1_SelectedValueChanged);
				bool flag = this._UiComboBox1 != null;
				if (flag)
				{
					this._UiComboBox1.remove_SelectedValueChanged(eventHandler);
				}
				this._UiComboBox1 = value;
				flag = (this._UiComboBox1 != null);
				if (flag)
				{
					this._UiComboBox1.add_SelectedValueChanged(eventHandler);
				}
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x001A0A24 File Offset: 0x0019EE24
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x001A0A3C File Offset: 0x0019EE3C
		internal virtual UIButton btn35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn35 = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x001A0A48 File Offset: 0x0019EE48
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x001A0A60 File Offset: 0x0019EE60
		internal virtual UIButton btn34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn34 = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x001A0A6C File Offset: 0x0019EE6C
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x001A0A84 File Offset: 0x0019EE84
		internal virtual UIButton btn33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn33 = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x001A0A90 File Offset: 0x0019EE90
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x001A0AA8 File Offset: 0x0019EEA8
		internal virtual UIButton btn28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn28 = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x001A0AB4 File Offset: 0x0019EEB4
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x001A0ACC File Offset: 0x0019EECC
		internal virtual UIButton btn27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn27 = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x001A0AD8 File Offset: 0x0019EED8
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x001A0AF0 File Offset: 0x0019EEF0
		internal virtual UIButton btn26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn26 = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x001A0AFC File Offset: 0x0019EEFC
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x001A0B14 File Offset: 0x0019EF14
		internal virtual UIButton btn21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn21 = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x001A0B20 File Offset: 0x0019EF20
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x001A0B38 File Offset: 0x0019EF38
		internal virtual UIButton btn20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn20 = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x001A0B44 File Offset: 0x0019EF44
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x001A0B5C File Offset: 0x0019EF5C
		internal virtual UIButton btn19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn19 = value;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x001A0B68 File Offset: 0x0019EF68
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x001A0B80 File Offset: 0x0019EF80
		internal virtual UIButton btn32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn32 = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x001A0B8C File Offset: 0x0019EF8C
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x001A0BA4 File Offset: 0x0019EFA4
		internal virtual UIButton btn14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn14 = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x001A0BB0 File Offset: 0x0019EFB0
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x001A0BC8 File Offset: 0x0019EFC8
		internal virtual UIButton btn13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn13 = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x001A0BD4 File Offset: 0x0019EFD4
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x001A0BEC File Offset: 0x0019EFEC
		internal virtual UIButton btn25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn25 = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x001A0BF8 File Offset: 0x0019EFF8
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x001A0C10 File Offset: 0x0019F010
		internal virtual UIButton btn12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn12 = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x001A0C1C File Offset: 0x0019F01C
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x001A0C34 File Offset: 0x0019F034
		internal virtual UIButton btn18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn18 = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x001A0C40 File Offset: 0x0019F040
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x001A0C58 File Offset: 0x0019F058
		internal virtual UIButton btn31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn31 = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x001A0C64 File Offset: 0x0019F064
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x001A0C7C File Offset: 0x0019F07C
		internal virtual UIButton btn7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn7 = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x001A0C88 File Offset: 0x0019F088
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x001A0CA0 File Offset: 0x0019F0A0
		internal virtual UIButton btn6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn6 = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x001A0CAC File Offset: 0x0019F0AC
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x001A0CC4 File Offset: 0x0019F0C4
		internal virtual UIButton btn24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn24 = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x001A0CD0 File Offset: 0x0019F0D0
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x001A0CE8 File Offset: 0x0019F0E8
		internal virtual UIButton btn11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn11 = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x001A0CF4 File Offset: 0x0019F0F4
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x001A0D0C File Offset: 0x0019F10C
		internal virtual UIButton btn17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn17 = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x001A0D18 File Offset: 0x0019F118
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x001A0D30 File Offset: 0x0019F130
		internal virtual UIButton btn30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn30 = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x001A0D3C File Offset: 0x0019F13C
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x001A0D54 File Offset: 0x0019F154
		internal virtual UIButton btn5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn5 = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x001A0D60 File Offset: 0x0019F160
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x001A0D78 File Offset: 0x0019F178
		internal virtual UIButton btn23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn23 = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x001A0D84 File Offset: 0x0019F184
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x001A0D9C File Offset: 0x0019F19C
		internal virtual UIButton btn10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn10 = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x001A0DA8 File Offset: 0x0019F1A8
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x001A0DC0 File Offset: 0x0019F1C0
		internal virtual UIButton btn16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn16 = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x001A0DCC File Offset: 0x0019F1CC
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x001A0DE4 File Offset: 0x0019F1E4
		internal virtual UIButton btn29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn29 = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x001A0DF0 File Offset: 0x0019F1F0
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x001A0E08 File Offset: 0x0019F208
		internal virtual UIButton btn4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn4 = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x001A0E14 File Offset: 0x0019F214
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x001A0E2C File Offset: 0x0019F22C
		internal virtual UIButton btn22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn22 = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x001A0E38 File Offset: 0x0019F238
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x001A0E50 File Offset: 0x0019F250
		internal virtual UIButton btn9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn9 = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x001A0E5C File Offset: 0x0019F25C
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x001A0E74 File Offset: 0x0019F274
		internal virtual UIButton btn15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn15 = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x001A0E80 File Offset: 0x0019F280
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x001A0E98 File Offset: 0x0019F298
		internal virtual UIButton btn3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn3 = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x001A0EA4 File Offset: 0x0019F2A4
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x001A0EBC File Offset: 0x0019F2BC
		internal virtual UIButton btn8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn8 = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x001A0EC8 File Offset: 0x0019F2C8
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x001A0EE0 File Offset: 0x0019F2E0
		internal virtual UIButton btn2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn2 = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x001A0EEC File Offset: 0x0019F2EC
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x001A0F04 File Offset: 0x0019F304
		internal virtual UIButton btn1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn1 = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x001A0F10 File Offset: 0x0019F310
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x001A0F28 File Offset: 0x0019F328
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x001A0F34 File Offset: 0x0019F334
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x001A0F4C File Offset: 0x0019F34C
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

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x001A0F58 File Offset: 0x0019F358
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x001A0F70 File Offset: 0x0019F370
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

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x001A0F7C File Offset: 0x0019F37C
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x001A0F94 File Offset: 0x0019F394
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

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x001A0FA0 File Offset: 0x0019F3A0
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x001A0FB8 File Offset: 0x0019F3B8
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

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x001A0FC4 File Offset: 0x0019F3C4
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x001A0FDC File Offset: 0x0019F3DC
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

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x001A0FE8 File Offset: 0x0019F3E8
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x001A1000 File Offset: 0x0019F400
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

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x001A100C File Offset: 0x0019F40C
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x001A1024 File Offset: 0x0019F424
		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				bool flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked -= value2;
				}
				this._LinkLabel1 = value;
				flag = (this._LinkLabel1 != null);
				if (flag)
				{
					this._LinkLabel1.LinkClicked += value2;
				}
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x001A1084 File Offset: 0x0019F484
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x001A109C File Offset: 0x0019F49C
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x001A10A8 File Offset: 0x0019F4A8
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x001A10C0 File Offset: 0x0019F4C0
		public DateBox2 DateBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateBox;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DateBox = value;
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x001A10CC File Offset: 0x0019F4CC
		public DatePanel()
		{
			DatePanel.__ENCAddToList(this);
			this.btn = new UIButton[36];
			this.p = new PersianCalendar();
			this.InitializeComponent();
			this.btn[1] = this.btn1;
			this.btn[2] = this.btn2;
			this.btn[3] = this.btn3;
			this.btn[4] = this.btn4;
			this.btn[5] = this.btn5;
			this.btn[6] = this.btn6;
			this.btn[7] = this.btn7;
			this.btn[8] = this.btn8;
			this.btn[9] = this.btn9;
			this.btn[10] = this.btn10;
			this.btn[11] = this.btn11;
			this.btn[12] = this.btn12;
			this.btn[13] = this.btn13;
			this.btn[14] = this.btn14;
			this.btn[15] = this.btn15;
			this.btn[16] = this.btn16;
			this.btn[17] = this.btn17;
			this.btn[18] = this.btn18;
			this.btn[19] = this.btn19;
			this.btn[20] = this.btn20;
			this.btn[21] = this.btn21;
			this.btn[22] = this.btn22;
			this.btn[23] = this.btn23;
			this.btn[24] = this.btn24;
			this.btn[25] = this.btn25;
			this.btn[26] = this.btn26;
			this.btn[27] = this.btn27;
			this.btn[28] = this.btn28;
			this.btn[29] = this.btn29;
			this.btn[30] = this.btn30;
			this.btn[31] = this.btn31;
			this.btn[32] = this.btn32;
			this.btn[33] = this.btn33;
			this.btn[34] = this.btn34;
			this.btn[35] = this.btn35;
			int num = 1;
			checked
			{
				int arg_27F_0;
				int num2;
				do
				{
					this.btn[num].Click += new EventHandler(this.btn1_Click);
					num++;
					arg_27F_0 = num;
					num2 = 35;
				}
				while (arg_27F_0 <= num2);
				string[] array = Public_Function.MiladiToShamsi(DateAndTime.Now).Split(new char[]
				{
					'/'
				});
				this.curday = Conversions.ToInteger(array[2]);
				this.curmonth = Conversions.ToInteger(array[1]);
				this.curyear = Conversions.ToInteger(array[0]);
				int num3 = (int)(this.p.GetDayOfWeek(DateAndTime.Now) + 2);
				bool flag = num3 == 8;
				if (flag)
				{
					num3 = 1;
				}
				this.LinkLabel1.Text = string.Concat(new string[]
				{
					"امروز ",
					Public_Function.GetDayName(num3),
					" ",
					array[2],
					" ",
					Public_Function.GetMonthName(Conversions.ToInteger(array[1])),
					" ",
					array[0]
				});
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x001A1434 File Offset: 0x0019F834
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x001A144C File Offset: 0x0019F84C
		public int Sal
		{
			get
			{
				return this._Sal;
			}
			set
			{
				this._Sal = value;
				this.IntegerUpDown1.set_Value(this._Sal);
				this.SetDate();
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x001A1470 File Offset: 0x0019F870
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x001A1488 File Offset: 0x0019F888
		public int Mah
		{
			get
			{
				return this._Mah;
			}
			set
			{
				this._Mah = value;
				this.UiComboBox1.set_SelectedValue(value.ToString());
				this.SetDate();
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x001A14B0 File Offset: 0x0019F8B0
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x001A14C8 File Offset: 0x0019F8C8
		public int Ruz
		{
			get
			{
				return this._Ruz;
			}
			set
			{
				this._Ruz = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x001A14D4 File Offset: 0x0019F8D4
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x001A14EC File Offset: 0x0019F8EC
		public ToolStripDropDown DropDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DropDown;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DropDown = value;
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x001A14F8 File Offset: 0x0019F8F8
		public void SetDate()
		{
			bool flag = this.Sal == 0;
			checked
			{
				if (!flag)
				{
					flag = (this.Mah == 0);
					if (!flag)
					{
						this._day = (int)this.p.GetDayOfWeek(Conversions.ToDate(Public_Function.ShamsiToMiladi(Conversions.ToString(this.Sal) + "/" + Conversions.ToString(this.Mah) + "/1")));
						int daysInMonth = this.p.GetDaysInMonth(this.Sal, this.Mah);
						this._day += 2;
						flag = (this._day == 8);
						if (flag)
						{
							this._day = 1;
						}
						int num = 1;
						int num2 = 1;
						int arg_1AD_0;
						int num3;
						do
						{
							flag = (num2 >= this._day && num <= daysInMonth);
							if (flag)
							{
								this.btn[num2].Visible = true;
								this.btn[num2].Text = Conversions.ToString(num);
								num++;
								flag = (this.btn[num2].get_OfficeCustomColor() == Color.LawnGreen);
								if (flag)
								{
									this.btn[num2].set_OfficeColorScheme(0);
								}
							}
							else
							{
								this.btn[num2].Visible = false;
							}
							flag = (this.Sal == this.curyear && this.Mah == this.curmonth && num - 1 == this.curday);
							if (flag)
							{
								this.btn[num2].set_OfficeColorScheme(4);
								this.btn[num2].set_OfficeCustomColor(Color.LawnGreen);
							}
							else
							{
								flag = (num2 % 7 == 0);
								if (flag)
								{
									this.btn[num2].set_OfficeColorScheme(2);
								}
							}
							num2++;
							arg_1AD_0 = num2;
							num3 = 35;
						}
						while (arg_1AD_0 <= num3);
					}
				}
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x001A16B8 File Offset: 0x0019FAB8
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			bool flag = this.DateBox != null;
			if (flag)
			{
				this.DateBox.SetDate(Public_Function.MiladiToShamsi(DateAndTime.Now));
			}
			this.DropDown.Hide();
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x001A16FC File Offset: 0x0019FAFC
		private void btn1_Click(object sender, EventArgs e)
		{
			this.Ruz = Conversions.ToInteger(((UIButton)sender).Text);
			bool flag = this.DateBox != null;
			if (flag)
			{
				this.DateBox.SetDate(string.Concat(new string[]
				{
					Conversions.ToString(this.Sal),
					"/",
					Strings.Format(this.Mah, "00"),
					"/",
					Strings.Format(this.Ruz, "00")
				}));
			}
			this.DropDown.Hide();
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x001A17AC File Offset: 0x0019FBAC
		private void IntegerUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.Sal = this.IntegerUpDown1.get_Value();
			this.SetDate();
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x001A17CC File Offset: 0x0019FBCC
		private void UiComboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.Mah = Conversions.ToInteger(this.UiComboBox1.get_SelectedValue());
			this.SetDate();
		}

		// Token: 0x040004D0 RID: 1232
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004D1 RID: 1233
		private IContainer components;

		// Token: 0x040004D2 RID: 1234
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040004D3 RID: 1235
		[AccessedThroughProperty("IntegerUpDown1")]
		private IntegerUpDown _IntegerUpDown1;

		// Token: 0x040004D4 RID: 1236
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x040004D5 RID: 1237
		[AccessedThroughProperty("btn35")]
		private UIButton _btn35;

		// Token: 0x040004D6 RID: 1238
		[AccessedThroughProperty("btn34")]
		private UIButton _btn34;

		// Token: 0x040004D7 RID: 1239
		[AccessedThroughProperty("btn33")]
		private UIButton _btn33;

		// Token: 0x040004D8 RID: 1240
		[AccessedThroughProperty("btn28")]
		private UIButton _btn28;

		// Token: 0x040004D9 RID: 1241
		[AccessedThroughProperty("btn27")]
		private UIButton _btn27;

		// Token: 0x040004DA RID: 1242
		[AccessedThroughProperty("btn26")]
		private UIButton _btn26;

		// Token: 0x040004DB RID: 1243
		[AccessedThroughProperty("btn21")]
		private UIButton _btn21;

		// Token: 0x040004DC RID: 1244
		[AccessedThroughProperty("btn20")]
		private UIButton _btn20;

		// Token: 0x040004DD RID: 1245
		[AccessedThroughProperty("btn19")]
		private UIButton _btn19;

		// Token: 0x040004DE RID: 1246
		[AccessedThroughProperty("btn32")]
		private UIButton _btn32;

		// Token: 0x040004DF RID: 1247
		[AccessedThroughProperty("btn14")]
		private UIButton _btn14;

		// Token: 0x040004E0 RID: 1248
		[AccessedThroughProperty("btn13")]
		private UIButton _btn13;

		// Token: 0x040004E1 RID: 1249
		[AccessedThroughProperty("btn25")]
		private UIButton _btn25;

		// Token: 0x040004E2 RID: 1250
		[AccessedThroughProperty("btn12")]
		private UIButton _btn12;

		// Token: 0x040004E3 RID: 1251
		[AccessedThroughProperty("btn18")]
		private UIButton _btn18;

		// Token: 0x040004E4 RID: 1252
		[AccessedThroughProperty("btn31")]
		private UIButton _btn31;

		// Token: 0x040004E5 RID: 1253
		[AccessedThroughProperty("btn7")]
		private UIButton _btn7;

		// Token: 0x040004E6 RID: 1254
		[AccessedThroughProperty("btn6")]
		private UIButton _btn6;

		// Token: 0x040004E7 RID: 1255
		[AccessedThroughProperty("btn24")]
		private UIButton _btn24;

		// Token: 0x040004E8 RID: 1256
		[AccessedThroughProperty("btn11")]
		private UIButton _btn11;

		// Token: 0x040004E9 RID: 1257
		[AccessedThroughProperty("btn17")]
		private UIButton _btn17;

		// Token: 0x040004EA RID: 1258
		[AccessedThroughProperty("btn30")]
		private UIButton _btn30;

		// Token: 0x040004EB RID: 1259
		[AccessedThroughProperty("btn5")]
		private UIButton _btn5;

		// Token: 0x040004EC RID: 1260
		[AccessedThroughProperty("btn23")]
		private UIButton _btn23;

		// Token: 0x040004ED RID: 1261
		[AccessedThroughProperty("btn10")]
		private UIButton _btn10;

		// Token: 0x040004EE RID: 1262
		[AccessedThroughProperty("btn16")]
		private UIButton _btn16;

		// Token: 0x040004EF RID: 1263
		[AccessedThroughProperty("btn29")]
		private UIButton _btn29;

		// Token: 0x040004F0 RID: 1264
		[AccessedThroughProperty("btn4")]
		private UIButton _btn4;

		// Token: 0x040004F1 RID: 1265
		[AccessedThroughProperty("btn22")]
		private UIButton _btn22;

		// Token: 0x040004F2 RID: 1266
		[AccessedThroughProperty("btn9")]
		private UIButton _btn9;

		// Token: 0x040004F3 RID: 1267
		[AccessedThroughProperty("btn15")]
		private UIButton _btn15;

		// Token: 0x040004F4 RID: 1268
		[AccessedThroughProperty("btn3")]
		private UIButton _btn3;

		// Token: 0x040004F5 RID: 1269
		[AccessedThroughProperty("btn8")]
		private UIButton _btn8;

		// Token: 0x040004F6 RID: 1270
		[AccessedThroughProperty("btn2")]
		private UIButton _btn2;

		// Token: 0x040004F7 RID: 1271
		[AccessedThroughProperty("btn1")]
		private UIButton _btn1;

		// Token: 0x040004F8 RID: 1272
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040004F9 RID: 1273
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040004FA RID: 1274
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040004FB RID: 1275
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040004FC RID: 1276
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040004FD RID: 1277
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040004FE RID: 1278
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040004FF RID: 1279
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x04000500 RID: 1280
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000501 RID: 1281
		[CompilerGenerated]
		private DateBox2 _DateBox;

		// Token: 0x04000502 RID: 1282
		private int _day;

		// Token: 0x04000503 RID: 1283
		private int _Sal;

		// Token: 0x04000504 RID: 1284
		private int _Mah;

		// Token: 0x04000505 RID: 1285
		private int _Ruz;

		// Token: 0x04000506 RID: 1286
		private UIButton[] btn;

		// Token: 0x04000507 RID: 1287
		private PersianCalendar p;

		// Token: 0x04000508 RID: 1288
		private int curday;

		// Token: 0x04000509 RID: 1289
		private int curmonth;

		// Token: 0x0400050A RID: 1290
		private int curyear;

		// Token: 0x0400050B RID: 1291
		[CompilerGenerated]
		private ToolStripDropDown _DropDown;
	}
}
