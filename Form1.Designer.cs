namespace FruitBox
{
	// Token: 0x020000BB RID: 187
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E84 RID: 3716 RVA: 0x001A6798 File Offset: 0x001A4B98
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

		// Token: 0x06000E85 RID: 3717 RVA: 0x001A67E8 File Offset: 0x001A4BE8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Form1));
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference2 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			global::Janus.Windows.Common.Layouts.JanusLayoutReference janusLayoutReference3 = new global::Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage");
			this.MetroTileItem4 = new global::DevComponents.DotNetBar.Metro.MetroTileItem();
			this.GridEX1 = new global::FruitBox.DataEntryGrid(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).BeginInit();
			this.SuspendLayout();
			this.MetroTileItem4.set_GlobalItem(false);
			this.MetroTileItem4.set_Name("MetroTileItem4");
			this.MetroTileItem4.set_SymbolColor(global::System.Drawing.Color.Empty);
			this.MetroTileItem4.set_TileColor(0);
			this.MetroTileItem4.get_TileStyle().set_CornerType(1);
			this.GridEX1.set_AcceptsEscape(false);
			this.GridEX1.set_AllowAddNew(1);
			this.GridEX1.set_AlternatingColors(true);
			this.GridEX1.set_AutoEdit(true);
			janusLayoutReference.set_Instance(global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance")));
			janusLayoutReference2.set_Instance(global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_1.Instance")));
			janusLayoutReference3.set_Instance(global::System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("GridEX1_DesignTimeLayout_Reference_2.Instance")));
			gridEXLayout.get_LayoutReferences().AddRange(new global::Janus.Windows.Common.Layouts.JanusLayoutReference[]
			{
				janusLayoutReference,
				janusLayoutReference2,
				janusLayoutReference3
			});
			gridEXLayout.set_LayoutString(componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString"));
			this.GridEX1.set_DesignTimeLayout(gridEXLayout);
			this.GridEX1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GridEX1.set_EnterKeyBehavior(2);
			this.GridEX1.set_FocusStyle(1);
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GridEX1.set_GridLineStyle(2);
			this.GridEX1.set_GroupByBoxVisible(false);
			global::System.Windows.Forms.Control arg_1F8_0 = this.GridEX1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_1F8_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.set_NewRowPosition(2);
			this.GridEX1.set_OfficeColorScheme(1);
			this.GridEX1.set_RowHeaders(1);
			global::System.Windows.Forms.Control arg_250_0 = this.GridEX1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(1452, 473);
			arg_250_0.Size = size;
			this.GridEX1.TabIndex = 14;
			this.GridEX1.set_TotalRow(1);
			this.GridEX1.get_TotalRowFormatStyle().set_BackColor(global::System.Drawing.Color.AliceBlue);
			this.GridEX1.get_TotalRowFormatStyle().set_BackColorGradient(global::System.Drawing.Color.DarkTurquoise);
			this.GridEX1.get_TotalRowFormatStyle().set_BackgroundGradientMode(2);
			this.GridEX1.set_TotalRowPosition(1);
			this.GridEX1.set_UpdateMode(1);
			this.GridEX1.set_VisualStyle(6);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(1452, 473);
			this.ClientSize = size;
			this.Controls.Add(this.GridEX1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Form1";
			((global::System.ComponentModel.ISupportInitialize)this.GridEX1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400059F RID: 1439
		private global::System.ComponentModel.IContainer components;
	}
}
