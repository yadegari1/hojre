using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200005C RID: 92
	public class fp
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x0013B6CC File Offset: 0x00139ACC
		public fp()
		{
			this.fp = string.Empty;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0013B6E4 File Offset: 0x00139AE4
		public string Value()
		{
			bool flag = Public_Function.AppType == 1;
			if (flag)
			{
				this.fp = this.MakeHash(string.Concat(new string[]
				{
					"CPU >> ",
					this.cpuid(),
					"\\nBIOS >> ",
					this.biosid(),
					"\\nBASE >> ",
					this.baseid()
				}));
			}
			else
			{
				flag = (Public_Function.AppType == 2);
				if (flag)
				{
					this.fp = this.MakeHash(string.Concat(new string[]
					{
						"khCPU >> ",
						this.cpuid(),
						"\\norBIOS >> ",
						this.biosid(),
						"\\ndeBASE >> ",
						this.baseid()
					}));
				}
				else
				{
					flag = (Public_Function.AppType == 3);
					if (flag)
					{
						this.fp = this.MakeHash(string.Concat(new string[]
						{
							"barkoniCPU >> ",
							this.cpuid(),
							"\\nBIOS >> ",
							this.biosid(),
							"\\nBASE >> ",
							this.baseid()
						}));
					}
				}
			}
			return this.fp;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0013B820 File Offset: 0x00139C20
		public string Value2(string kkk)
		{
			this.fp = this.MakeHash2(kkk);
			return this.fp.Substring(0, 39);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0013B850 File Offset: 0x00139C50
		public string EncryptData(byte[] Message, byte[] md5)
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(md5);
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] bt;
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
				bt = cryptoTransform.TransformFinalBlock(Message, 0, Message.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider.Clear();
				mD5CryptoServiceProvider.Clear();
			}
			return this.GetHex(bt);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0013B8E0 File Offset: 0x00139CE0
		private byte[] Maken(byte[] bt1, byte[] bt2)
		{
			byte[] array = new byte[16];
			int num = 0;
			checked
			{
				int arg_1F_0;
				int num2;
				do
				{
					array[num] = (bt1[num] ^ bt2[num]);
					num++;
					arg_1F_0 = num;
					num2 = 15;
				}
				while (arg_1F_0 <= num2);
				return array;
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0013B914 File Offset: 0x00139D14
		private string MakeHash(string s)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(s);
			return this.GetHex(mD5CryptoServiceProvider.ComputeHash(bytes));
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0013B950 File Offset: 0x00139D50
		private string MakeHash2(string s)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(s);
			return this.EncryptData(sHA1CryptoServiceProvider.ComputeHash(bytes), mD5CryptoServiceProvider.ComputeHash(bytes));
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0013B994 File Offset: 0x00139D94
		private string GetHex(byte[] bt)
		{
			string text = string.Empty;
			int arg_0F_0 = 0;
			checked
			{
				int num = bt.Length - 1;
				int num2 = arg_0F_0;
				while (true)
				{
					int arg_D6_0 = num2;
					int num3 = num;
					if (arg_D6_0 > num3)
					{
						break;
					}
					byte b = bt[num2];
					int num4 = (int)b;
					int num5 = num4 & 15;
					int num6 = num4 >> 4 & 15;
					bool flag = num6 > 9;
					if (flag)
					{
						text += Strings.ChrW(num6 - 10 + 65).ToString();
					}
					else
					{
						text += num6.ToString();
					}
					flag = (num5 > 9);
					if (flag)
					{
						text += Strings.ChrW(num5 - 10 + 65).ToString();
					}
					else
					{
						text += num5.ToString();
					}
					flag = (num2 + 1 != bt.Length && (num2 + 1) % 2 == 0);
					if (flag)
					{
						text += "-";
					}
					num2++;
				}
				return text;
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0013BA84 File Offset: 0x00139E84
		private string id(string wmiclass, string wmiproperty, string wmibetrue)
		{
			string text = string.Empty;
			ManagementClass managementClass = new ManagementClass(wmiclass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					bool flag = Operators.CompareString(managementObject[wmibetrue].ToString(), "True", false) == 0;
					if (flag)
					{
						bool flag2 = Operators.CompareString(text, string.Empty, false) == 0;
						if (flag2)
						{
							try
							{
								text = managementObject[wmiproperty].ToString();
								break;
							}
							catch (Exception expr_78)
							{
								ProjectData.SetProjectError(expr_78);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				bool flag2 = enumerator != null;
				if (flag2)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return text;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0013BB68 File Offset: 0x00139F68
		private string id(string wmiclass, string wmiproperty)
		{
			string text = string.Empty;
			ManagementClass managementClass = new ManagementClass(wmiclass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					bool flag = Operators.CompareString(text, string.Empty, false) == 0;
					if (flag)
					{
						try
						{
							text = managementObject[wmiproperty].ToString();
							break;
						}
						catch (Exception expr_57)
						{
							ProjectData.SetProjectError(expr_57);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				bool flag = enumerator != null;
				if (flag)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return text;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0013BC28 File Offset: 0x0013A028
		private string cpuid()
		{
			string text = string.Empty;
			text = this.id("Win32_Processor", "UniqueId");
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = this.id("Win32_Processor", "ProcessorId");
				flag = (Operators.CompareString(text, string.Empty, false) == 0);
				if (flag)
				{
					text = this.id("Win32_Processor", "Name");
					flag = (Operators.CompareString(text, string.Empty, false) == 0);
					if (flag)
					{
						text = this.id("Win32_Processor", "Manufacturer");
					}
					text += this.id("Win32_Processor", "MaxClockSpeed");
				}
			}
			return text;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0013BCD8 File Offset: 0x0013A0D8
		private string biosid()
		{
			return string.Concat(new string[]
			{
				this.id("Win32_BIOS", "Manufacturer"),
				this.id("Win32_BIOS", "SMBIOSBIOSVersion"),
				this.id("Win32_BIOS", "IdentificationCode"),
				this.id("Win32_BIOS", "SerialNumber"),
				this.id("Win32_BIOS", "ReleaseDate"),
				this.id("Win32_BIOS", "Version")
			});
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0013BD70 File Offset: 0x0013A170
		private string diskid()
		{
			return this.id("Win32_DiskDrive", "Model") + this.id("Win32_DiskDrive", "Manufacturer") + this.id("Win32_DiskDrive", "Signature") + this.id("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0013BDC8 File Offset: 0x0013A1C8
		private string baseid()
		{
			return this.id("Win32_BaseBoard", "Model") + this.id("Win32_BaseBoard", "Manufacturer") + this.id("Win32_BaseBoard", "Name") + this.id("Win32_BaseBoard", "SerialNumber");
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0013BE20 File Offset: 0x0013A220
		private string VideoId()
		{
			return this.id("Win32_VideoController", "DriverVersion") + this.id("Win32_VideoController", "Name");
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0013BE58 File Offset: 0x0013A258
		private void Set_Rd(string t)
		{
			setting setting = new setting();
			string[] array = this.MakeHash(Public_Function.dict["key"]).Split(new char[]
			{
				'-'
			});
			string str = this.MakeHash(t + array[2]);
			Public_Function.dict.Add("rd", t + ":" + str);
			setting.Update("rd", Public_Function.dict["rd"]);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0013BEDC File Offset: 0x0013A2DC
		public string GetPreCode()
		{
			string[] array = this.MakeHash(Public_Function.dict["key"]).Split(new char[]
			{
				'-'
			});
			return array[2];
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0013BF1C File Offset: 0x0013A31C
		public bool Check_licy(string t, string lic)
		{
			bool flag = lic.Length < 14;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				flag = (lic.Length > 14);
				if (flag)
				{
					result = false;
				}
				else
				{
					string[] array = this.MakeHash(Public_Function.dict["key"]).Split(new char[]
					{
						'-'
					});
					string[] array2 = this.MakeHash(t + array[2]).Split(new char[]
					{
						'-'
					});
					string left = string.Concat(new string[]
					{
						array2[0],
						"-",
						array2[1],
						"-",
						array2[2]
					});
					flag = (Operators.CompareString(left, lic, false) == 0);
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0013C004 File Offset: 0x0013A404
		public bool Check_lic(string t, string lic)
		{
			string[] array = lic.Split(new char[]
			{
				':'
			});
			bool flag = array.Length < 2;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string[] array2 = this.MakeHash(Public_Function.dict["key"]).Split(new char[]
				{
					'-'
				});
				string[] array3 = this.MakeHash(t + array2[2]).Split(new char[]
				{
					'-'
				});
				string left = string.Concat(new string[]
				{
					array3[0],
					"-",
					array3[1],
					"-",
					array3[2]
				});
				flag = (Operators.CompareString(t, array[0], false) == 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(left, array[1], false) == 0;
					result = flag2;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0013C108 File Offset: 0x0013A508
		public void Check_Rd()
		{
			bool flag = !Public_Function.dict.ContainsKey("rd");
			if (flag)
			{
				bool flag2 = !Public_Function.dict.ContainsKey("installdate");
				if (flag2)
				{
					setting setting = new setting();
					flag2 = !Public_Function.dict.ContainsKey("installdate");
					if (flag2)
					{
						setting.Update("installdate", DateTime.Now.ToShortDateString());
						Public_Function.dict.Add("installdate", DateTime.Now.ToShortDateString());
					}
				}
				string text = Public_Function.MiladiToShamsi(Conversions.ToDate(Public_Function.dict["installdate"]).AddDays(30.0));
				flag2 = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag2)
				{
					this.Set_Rd(text);
				}
			}
			else
			{
				bool flag2 = !Public_Function.dict.ContainsKey("installdate");
				if (flag2)
				{
					setting setting2 = new setting();
					flag2 = !Public_Function.dict.ContainsKey("installdate");
					if (flag2)
					{
						setting2.Update("installdate", DateTime.Now.ToShortDateString());
						Public_Function.dict.Add("installdate", DateTime.Now.ToShortDateString());
					}
				}
				string[] array = Public_Function.dict["rd"].ToString().Split(new char[]
				{
					':'
				});
				flag2 = (array.Length != 2);
				if (flag2)
				{
					Public_Function.dict.Remove("rd");
					this.Check_Rd();
				}
				else
				{
					string[] array2 = this.MakeHash(Public_Function.dict["key"]).Split(new char[]
					{
						'-'
					});
					string right = this.MakeHash(Public_Function.MiladiToShamsi(Conversions.ToDate(Public_Function.dict["installdate"]).AddDays(30.0)) + array2[2]);
					flag2 = (Operators.CompareString(array[1].ToUpper(), right, false) != 0);
					if (flag2)
					{
						Public_Function.dict.Remove("rd");
						this.Check_Rd();
					}
				}
			}
		}

		// Token: 0x04000256 RID: 598
		private string fp;
	}
}
