using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox.My
{
	// Token: 0x020000BE RID: 190
	[EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x0014AD94 File Offset: 0x00149194
		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = MyProject.Application.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0014ADC0 File Offset: 0x001491C0
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						flag = !MySettings.addedHandler;
						if (flag)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x040005AA RID: 1450
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x040005AB RID: 1451
		private static bool addedHandler;

		// Token: 0x040005AC RID: 1452
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
