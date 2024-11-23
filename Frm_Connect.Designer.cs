namespace FruitBox
{
	// Token: 0x02000065 RID: 101
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Connect : global::System.Windows.Forms.Form
	{
		// Token: 0x06000722 RID: 1826 RVA: 0x001764CC File Offset: 0x001748CC
		[global::System.Diagnostics.DebuggerNonUserCode]
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

		// Token: 0x06000723 RID: 1827 RVA: 0x0017651C File Offset: 0x0017491C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.PanelEx1 = new global::DevComponents.DotNetBar.PanelEx();
			this.btn_try = new global::Janus.Windows.EditControls.UIButton();
			this.UiButton3 = new global::Janus.Windows.EditControls.UIButton();
			this.btn_ViewError = new global::Janus.Windows.EditControls.UIButton();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.PanelEx1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.PanelEx1.set_CanvasColor(global::System.Drawing.SystemColors.Control);
			this.PanelEx1.set_ColorSchemeStyle(7);
			this.PanelEx1.Controls.Add(this.btn_try);
			this.PanelEx1.Controls.Add(this.UiButton3);
			this.PanelEx1.Controls.Add(this.btn_ViewError);
			this.PanelEx1.Controls.Add(this.PictureBox1);
			this.PanelEx1.Controls.Add(this.Label3);
			this.PanelEx1.Controls.Add(this.Label2);
			this.PanelEx1.Controls.Add(this.Label1);
			this.PanelEx1.set_DisabledBackColor(global::System.Drawing.Color.Empty);
			this.PanelEx1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control arg_18B_0 = this.PanelEx1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_18B_0.Location = location;
			this.PanelEx1.Name = "PanelEx1";
			global::System.Windows.Forms.Control arg_1BC_0 = this.PanelEx1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(441, 175);
			arg_1BC_0.Size = size;
			this.PanelEx1.get_Style().set_Alignment(global::System.Drawing.StringAlignment.Center);
			this.PanelEx1.get_Style().get_BackColor1().set_Color(global::System.Drawing.Color.White);
			this.PanelEx1.get_Style().get_BackColor2().set_Color(global::System.Drawing.Color.White);
			this.PanelEx1.get_Style().set_Border(2);
			this.PanelEx1.get_Style().get_BorderColor().set_ColorSchemePart(53);
			this.PanelEx1.get_Style().get_ForeColor().set_ColorSchemePart(54);
			this.PanelEx1.get_Style().set_GradientAngle(90);
			this.PanelEx1.TabIndex = 0;
			this.btn_try.set_HighlightActiveButton(false);
			global::System.Windows.Forms.Control arg_292_0 = this.btn_try;
			location = new global::System.Drawing.Point(278, 135);
			arg_292_0.Location = location;
			this.btn_try.Name = "btn_try";
			this.btn_try.set_ShowFocusRectangle(false);
			global::System.Windows.Forms.Control arg_2CA_0 = this.btn_try;
			size = new global::System.Drawing.Size(115, 28);
			arg_2CA_0.Size = size;
			this.btn_try.TabIndex = 2;
			this.btn_try.Text = "سعی مجدد";
			this.btn_try.Visible = false;
			this.btn_try.set_VisualStyle(7);
			this.UiButton3.set_HighlightActiveButton(false);
			global::System.Windows.Forms.Control arg_32B_0 = this.UiButton3;
			location = new global::System.Drawing.Point(12, 135);
			arg_32B_0.Location = location;
			this.UiButton3.Name = "UiButton3";
			this.UiButton3.set_ShowFocusRectangle(false);
			global::System.Windows.Forms.Control arg_363_0 = this.UiButton3;
			size = new global::System.Drawing.Size(116, 28);
			arg_363_0.Size = size;
			this.UiButton3.TabIndex = 2;
			this.UiButton3.Text = "خروج";
			this.UiButton3.Visible = false;
			this.UiButton3.set_VisualStyle(7);
			this.btn_ViewError.set_HighlightActiveButton(false);
			global::System.Windows.Forms.Control arg_3C7_0 = this.btn_ViewError;
			location = new global::System.Drawing.Point(134, 135);
			arg_3C7_0.Location = location;
			this.btn_ViewError.Name = "btn_ViewError";
			this.btn_ViewError.set_ShowFocusRectangle(false);
			global::System.Windows.Forms.Control arg_402_0 = this.btn_ViewError;
			size = new global::System.Drawing.Size(138, 28);
			arg_402_0.Size = size;
			this.btn_ViewError.TabIndex = 2;
			this.btn_ViewError.Text = "مشاهده خطا";
			this.btn_ViewError.Visible = false;
			this.btn_ViewError.set_VisualStyle(7);
			global::System.Windows.Forms.Control arg_452_0 = this.PictureBox1;
			location = new global::System.Drawing.Point(12, 6);
			arg_452_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control arg_483_0 = this.PictureBox1;
			size = new global::System.Drawing.Size(128, 128);
			arg_483_0.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_4E8_0 = this.Label1;
			location = new global::System.Drawing.Point(146, 19);
			arg_4E8_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_516_0 = this.Label1;
			size = new global::System.Drawing.Size(283, 39);
			arg_516_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "ارتباط با بانک اطلاعاتی قطع میباشد";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_590_0 = this.Label2;
			location = new global::System.Drawing.Point(146, 49);
			arg_590_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_5BE_0 = this.Label2;
			size = new global::System.Drawing.Size(283, 39);
			arg_5BE_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "در حال خطایابی";
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_61A_0 = this.Label3;
			location = new global::System.Drawing.Point(146, 88);
			arg_61A_0.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control arg_648_0 = this.Label3;
			size = new global::System.Drawing.Size(283, 39);
			arg_648_0.Size = size;
			this.Label3.TabIndex = 0;
			this.Label3.Text = "لطفا شکیبا باشید...";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(441, 175);
			this.ClientSize = size;
			this.Controls.Add(this.PanelEx1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Connect";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frm_Connect";
			this.PanelEx1.ResumeLayout(false);
			this.PanelEx1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040002B8 RID: 696
		private global::System.ComponentModel.IContainer components;
	}
}
