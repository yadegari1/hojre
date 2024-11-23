using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox.My
{
	// Token: 0x020000BF RID: 191
	[StandardModule, CompilerGenerated, DebuggerNonUserCode, HideModuleName]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0014AE40 File Offset: 0x00149240
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
