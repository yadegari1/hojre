using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RestSharp;

namespace FruitBox
{
	// Token: 0x020000BC RID: 188
	[DesignerGenerated]
	public partial class Form2 : Form
	{
		// Token: 0x06000E94 RID: 3732 RVA: 0x001A6FE0 File Offset: 0x001A53E0
		[DebuggerNonUserCode]
		public Form2()
		{
			base.Load += new EventHandler(this.Form2_Load);
			Form2.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x001A700C File Offset: 0x001A540C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form2.__ENCList.Count == Form2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form2.__ENCList[num] = Form2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form2.__ENCList.RemoveRange(num, Form2.__ENCList.Count - num);
						Form2.__ENCList.Capacity = Form2.__ENCList.Count;
					}
					Form2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x001A73AC File Offset: 0x001A57AC
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x001A73C4 File Offset: 0x001A57C4
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x001A7424 File Offset: 0x001A5824
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x001A743C File Offset: 0x001A583C
		internal virtual DateBox2 txt_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tarikh = value;
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x001A7448 File Offset: 0x001A5848
		private void Form2_Load(object sender, EventArgs e)
		{
			this.txt_tarikh.SetNew();
			RestClient restClient = new RestClient("https://api.ghasedak.io/v2/verification/send/simple");
			RestRequest restRequest = new RestRequest(1);
			restRequest.AddHeader("apikey", "2661ffb3728ee0feaec22f25e0d03059a13ed9860645d2d9da13fe7ae553cec9");
			restRequest.AddParameter("receptor", "09390244096");
			restRequest.AddParameter("type", "1");
			restRequest.AddParameter("template", "surathesab");
			restRequest.AddParameter("param1", "1398/01/01");
			IRestResponse restResponse = restClient.Execute(restRequest);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x001A74D4 File Offset: 0x001A58D4
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040005A4 RID: 1444
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005A6 RID: 1446
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040005A7 RID: 1447
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;
	}
}
