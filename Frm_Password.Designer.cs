namespace FruitBox
{
	// Token: 0x02000070 RID: 112
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Password : global::System.Windows.Forms.Form
	{
		// Token: 0x06000894 RID: 2196 RVA: 0x00181D54 File Offset: 0x00180154
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

		// Token: 0x06000895 RID: 2197 RVA: 0x00181DA4 File Offset: 0x001801A4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ButtonX1 = new global::DevComponents.DotNetBar.ButtonX();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.ButtonX2 = new global::DevComponents.DotNetBar.ButtonX();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.UiGroupBox1.BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_DB_0 = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(306, 22);
			arg_DB_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_109_0 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(150, 19);
			arg_109_0.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "رمز عبور را وارد نمائید";
			this.ButtonX1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.set_ColorTable(3);
			this.ButtonX1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.ButtonX1.set_Image(global::FruitBox.My.Resources.Resources.accept);
			global::System.Windows.Forms.Control arg_191_0 = this.ButtonX1;
			location = new global::System.Drawing.Point(213, 65);
			arg_191_0.Location = location;
			this.ButtonX1.Name = "ButtonX1";
			global::System.Windows.Forms.Control arg_1BC_0 = this.ButtonX1;
			size = new global::System.Drawing.Size(90, 35);
			arg_1BC_0.Size = size;
			this.ButtonX1.set_Style(8);
			this.ButtonX1.TabIndex = 2;
			this.ButtonX1.set_Text("ورود");
			this.PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.PictureBox1.Image = global::FruitBox.My.Resources.Resources.key;
			global::System.Windows.Forms.Control arg_222_0 = this.PictureBox1;
			location = new global::System.Drawing.Point(22, 15);
			arg_222_0.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control arg_24D_0 = this.PictureBox1;
			size = new global::System.Drawing.Size(64, 64);
			arg_24D_0.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_2E3_0 = this.EditBox1;
			location = new global::System.Drawing.Point(113, 18);
			arg_2E3_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = true;
			this.EditBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.EditBox1.set_PasswordChar('*');
			this.EditBox1.set_ShortcutsEnabled(false);
			global::System.Windows.Forms.Control arg_34A_0 = this.EditBox1;
			size = new global::System.Drawing.Size(190, 27);
			arg_34A_0.Size = size;
			this.EditBox1.TabIndex = 1;
			this.EditBox1.set_VisualStyle(6);
			this.UiGroupBox1.set_BackgroundStyle(3);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.EditBox1);
			this.UiGroupBox1.Controls.Add(this.PictureBox1);
			this.UiGroupBox1.Controls.Add(this.ButtonX1);
			this.UiGroupBox1.Controls.Add(this.ButtonX2);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.set_FrameStyle(0);
			global::System.Windows.Forms.Control arg_415_0 = this.UiGroupBox1;
			location = new global::System.Drawing.Point(0, 0);
			arg_415_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_443_0 = this.UiGroupBox1;
			size = new global::System.Drawing.Size(471, 127);
			arg_443_0.Size = size;
			this.UiGroupBox1.TabIndex = 5;
			this.UiGroupBox1.set_VisualStyle(6);
			this.ButtonX2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.set_ColorTable(3);
			this.ButtonX2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			this.ButtonX2.set_Image(global::FruitBox.My.Resources.Resources.delete);
			global::System.Windows.Forms.Control arg_4C4_0 = this.ButtonX2;
			location = new global::System.Drawing.Point(113, 65);
			arg_4C4_0.Location = location;
			this.ButtonX2.Name = "ButtonX2";
			global::System.Windows.Forms.Control arg_4EF_0 = this.ButtonX2;
			size = new global::System.Drawing.Size(94, 35);
			arg_4EF_0.Size = size;
			this.ButtonX2.set_Style(8);
			this.ButtonX2.TabIndex = 2;
			this.ButtonX2.set_Text("انصراف");
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(471, 127);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Password";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "رمز ویژه";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.UiGroupBox1.EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x04000358 RID: 856
		private global::System.ComponentModel.IContainer components;
	}
}
