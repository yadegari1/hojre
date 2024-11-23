using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000070 RID: 112
	[DesignerGenerated]
	public partial class Frm_Password : Form
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x00181C04 File Offset: 0x00180004
		public Frm_Password()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Password_KeyDown);
			Frm_Password.__ENCAddToList(this);
			int auth_type = 1;
			this.Auth_type = auth_type;
			this.user = new base_user();
			this.InitializeComponent();
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00181C50 File Offset: 0x00180050
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Password.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Password.__ENCList.Count == Frm_Password.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Password.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Password.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Password.__ENCList[num] = Frm_Password.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Password.__ENCList.RemoveRange(num, Frm_Password.__ENCList.Count - num);
						Frm_Password.__ENCList.Capacity = Frm_Password.__ENCList.Count;
					}
					Frm_Password.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x001823C0 File Offset: 0x001807C0
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x001823D8 File Offset: 0x001807D8
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x001823E4 File Offset: 0x001807E4
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x001823FC File Offset: 0x001807FC
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox1 = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00182408 File Offset: 0x00180808
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00182420 File Offset: 0x00180820
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0018242C File Offset: 0x0018082C
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00182444 File Offset: 0x00180844
		internal virtual ButtonX ButtonX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonX1_Click);
				bool flag = this._ButtonX1 != null;
				if (flag)
				{
					this._ButtonX1.Click -= value2;
				}
				this._ButtonX1 = value;
				flag = (this._ButtonX1 != null);
				if (flag)
				{
					this._ButtonX1.Click += value2;
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x001824A4 File Offset: 0x001808A4
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x001824BC File Offset: 0x001808BC
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

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x001824C8 File Offset: 0x001808C8
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x001824E0 File Offset: 0x001808E0
		internal virtual ButtonX ButtonX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonX2_Click);
				bool flag = this._ButtonX2 != null;
				if (flag)
				{
					this._ButtonX2.Click -= value2;
				}
				this._ButtonX2 = value;
				flag = (this._ButtonX2 != null);
				if (flag)
				{
					this._ButtonX2.Click += value2;
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00182540 File Offset: 0x00180940
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00182558 File Offset: 0x00180958
		public int Auth_type
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Auth_type;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Auth_type = value;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00182564 File Offset: 0x00180964
		private void ButtonX1_Click(object sender, EventArgs e)
		{
			bool flag = this.Auth_type == 1;
			bool flag2;
			if (flag)
			{
				flag2 = this.user.Login(MyProject.Forms.Form_Main.txt_user.get_SelectedItem().get_Text(), this.EditBox1.Text);
				if (flag2)
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					Public_Function.ShowMessage("گذر واژه اشتباه میباشد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
					this.EditBox1.Text = string.Empty;
					this.EditBox1.Focus();
				}
			}
			flag2 = (this.Auth_type == 2);
			if (flag2)
			{
				flag = (Operators.CompareString(this.EditBox1.Text, Public_Function.dict["pidkey"], false) == 0);
				if (flag)
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					Public_Function.ShowMessage("گذر واژه اشتباه میباشد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
					this.EditBox1.Text = string.Empty;
					this.EditBox1.Focus();
				}
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00182668 File Offset: 0x00180A68
		private void Frm_Password_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00182698 File Offset: 0x00180A98
		private void ButtonX2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x04000357 RID: 855
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000359 RID: 857
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400035A RID: 858
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400035B RID: 859
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400035C RID: 860
		[AccessedThroughProperty("ButtonX1")]
		private ButtonX _ButtonX1;

		// Token: 0x0400035D RID: 861
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400035E RID: 862
		[AccessedThroughProperty("ButtonX2")]
		private ButtonX _ButtonX2;

		// Token: 0x0400035F RID: 863
		[CompilerGenerated]
		private int _Auth_type;

		// Token: 0x04000360 RID: 864
		private base_user user;
	}
}
