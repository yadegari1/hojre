namespace FruitBox
{
	// Token: 0x02000075 RID: 117
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Restore : global::System.Windows.Forms.Form
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x001876B8 File Offset: 0x00185AB8
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

		// Token: 0x06000951 RID: 2385 RVA: 0x00187708 File Offset: 0x00185B08
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.PanelEx2 = new global::DevComponents.DotNetBar.PanelEx();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.CircularProgress1 = new global::DevComponents.DotNetBar.Controls.CircularProgress();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.PanelEx2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.PanelEx2.set_CanvasColor(global::System.Drawing.SystemColors.Control);
			this.PanelEx2.set_ColorSchemeStyle(0);
			this.PanelEx2.Controls.Add(this.PictureBox1);
			this.PanelEx2.Controls.Add(this.CircularProgress1);
			this.PanelEx2.Controls.Add(this.Label2);
			this.PanelEx2.Controls.Add(this.Label1);
			this.PanelEx2.set_DisabledBackColor(global::System.Drawing.Color.Empty);
			this.PanelEx2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control arg_134_0 = this.PanelEx2;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_134_0.Location = location;
			this.PanelEx2.Name = "PanelEx2";
			global::System.Windows.Forms.Control arg_165_0 = this.PanelEx2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(415, 262);
			arg_165_0.Size = size;
			this.PanelEx2.get_Style().set_Alignment(global::System.Drawing.StringAlignment.Center);
			this.PanelEx2.get_Style().get_BackColor1().set_Color(global::System.Drawing.Color.White);
			this.PanelEx2.get_Style().get_BackColor2().set_Color(global::System.Drawing.Color.White);
			this.PanelEx2.get_Style().set_Border(2);
			this.PanelEx2.get_Style().get_BorderColor().set_Color(global::System.Drawing.Color.FromArgb(132, 157, 189));
			this.PanelEx2.get_Style().get_ForeColor().set_ColorSchemePart(54);
			this.PanelEx2.get_Style().set_GradientAngle(90);
			this.PanelEx2.TabIndex = 2;
			this.PanelEx2.set_Text("PanelEx2");
			global::System.Windows.Forms.Control arg_24B_0 = this.PictureBox1;
			location = new global::System.Drawing.Point(12, 12);
			arg_24B_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control arg_27C_0 = this.PictureBox1;
			size = new global::System.Drawing.Size(146, 144);
			arg_27C_0.Size = size;
			this.PictureBox1.TabIndex = 2;
			this.PictureBox1.TabStop = false;
			this.CircularProgress1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.CircularProgress1.get_BackgroundStyle().set_CornerType(1);
			this.CircularProgress1.set_FocusCuesEnabled(false);
			global::System.Windows.Forms.Control arg_2DC_0 = this.CircularProgress1;
			location = new global::System.Drawing.Point(105, 86);
			arg_2DC_0.Location = location;
			this.CircularProgress1.Name = "CircularProgress1";
			this.CircularProgress1.set_ProgressBarType(4);
			global::System.Windows.Forms.Control arg_31A_0 = this.CircularProgress1;
			size = new global::System.Drawing.Size(306, 156);
			arg_31A_0.Size = size;
			this.CircularProgress1.set_Style(0);
			this.CircularProgress1.TabIndex = 1;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_38D_0 = this.Label2;
			location = new global::System.Drawing.Point(230, 65);
			arg_38D_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_3BB_0 = this.Label2;
			size = new global::System.Drawing.Size(150, 18);
			arg_3BB_0.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "... لطفا شکیبا باشید";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_432_0 = this.Label1;
			location = new global::System.Drawing.Point(194, 30);
			arg_432_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_460_0 = this.Label1;
			size = new global::System.Drawing.Size(186, 18);
			arg_460_0.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "... در حال بازیابی اطلاعات";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Timer2.Enabled = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(415, 262);
			this.ClientSize = size;
			this.Controls.Add(this.PanelEx2);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Restore";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "تهیه پشتیبان";
			this.PanelEx2.ResumeLayout(false);
			this.PanelEx2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040003AF RID: 943
		private global::System.ComponentModel.IContainer components;
	}
}
