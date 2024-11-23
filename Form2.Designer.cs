namespace FruitBox
{
	// Token: 0x020000BC RID: 188
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E96 RID: 3734 RVA: 0x001A7110 File Offset: 0x001A5510
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

		// Token: 0x06000E97 RID: 3735 RVA: 0x001A7160 File Offset: 0x001A5560
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txt_tarikh = new global::FruitBox.DateBox2(this.components);
			this.SuspendLayout();
			this.Button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			global::System.Windows.Forms.Control arg_55_0 = this.Button1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(220, 71);
			arg_55_0.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control arg_82_0 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(169, 34);
			arg_82_0.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Run";
			this.Button1.UseVisualStyleBackColor = true;
			this.txt_tarikh.AcceptEnter = true;
			this.txt_tarikh.AllowEdit = true;
			this.txt_tarikh.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txt_tarikh.ButtonEnable = false;
			this.txt_tarikh.FocusDatePart = 2;
			this.txt_tarikh.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_12D_0 = this.txt_tarikh;
			location = new global::System.Drawing.Point(220, 28);
			arg_12D_0.Location = location;
			this.txt_tarikh.set_Mask("0000/00/00");
			this.txt_tarikh.Name = "txt_tarikh";
			this.txt_tarikh.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			global::System.Windows.Forms.Control arg_178_0 = this.txt_tarikh;
			size = new global::System.Drawing.Size(169, 36);
			arg_178_0.Size = size;
			this.txt_tarikh.TabIndex = 2;
			this.txt_tarikh.set_Text("1398/02/19");
			this.txt_tarikh.set_TextAlignment(3);
			this.txt_tarikh.set_VisualStyle(6);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(401, 262);
			this.ClientSize = size;
			this.Controls.Add(this.txt_tarikh);
			this.Controls.Add(this.Button1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040005A5 RID: 1445
		private global::System.ComponentModel.IContainer components;
	}
}
