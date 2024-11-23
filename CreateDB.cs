using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000057 RID: 87
	public class CreateDB
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x0013A034 File Offset: 0x00138434
		[DebuggerNonUserCode]
		public CreateDB()
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0013A040 File Offset: 0x00138440
		public void init_first_db()
		{
			Public_Function.ExecuteNonQuery("DBCC CHECKIDENT(moshtari, RESEED, 99)");
			Public_Function.ExecuteNonQuery("delete from grid_size");
			Public_Function.ExecuteNonQuery("delete from frm_size");
			Public_Function.ExecuteNonQuery("delete from Grouh_Moshtari");
			Public_Function.ExecuteNonQuery("delete from Grouh_Moshtari2");
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0013A07C File Offset: 0x0013847C
		private string GetNextFileName(string path, string s)
		{
			string text = s.Replace("fruitbox", "");
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = Conversions.ToString(1);
			}
			else
			{
				text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
			}
			s = "fruitbox" + text;
			flag = File.Exists(path + "\\" + s + ".mdf");
			string result;
			if (flag)
			{
				result = this.GetNextFileName(path, s);
			}
			else
			{
				result = s;
			}
			return result;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0013A10C File Offset: 0x0013850C
		public string GetLastDBName()
		{
			SqlConnection sqlConnection = new SqlConnection(string.Concat(new string[]
			{
				"Data Source=",
				Public_Function.Server,
				"\\",
				Public_Function.SQLInstance,
				";Initial Catalog=master;Integrated Security=True;Connect Timeout=10000"
			}));
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand
			{
				Connection = sqlConnection,
				CommandText = "select top 1 name from sys.databases where name like 'fruitbox%' order by name desc"
			};
			string text = Conversions.ToString(sqlCommand.ExecuteScalar());
			sqlConnection.Close();
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = "fruitbox";
			}
			else
			{
				text = text.Replace("fruitbox", "");
				flag = (Operators.CompareString(text, "", false) == 0);
				if (flag)
				{
					text = Conversions.ToString(0);
				}
				text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
				result = "fruitbox" + text;
			}
			return result;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0013A210 File Offset: 0x00138610
		public string CreateDB()
		{
			string text = this.GetLastDBName();
			SqlConnection sqlConnection = new SqlConnection(string.Concat(new string[]
			{
				"Data Source=",
				Public_Function.Server,
				"\\",
				Public_Function.SQLInstance,
				";Initial Catalog=master;Integrated Security=True;Connect Timeout=10000"
			}));
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand
			{
				Connection = sqlConnection,
				CommandText = "select physical_Name from [master].[sys].[database_files] where name='master'"
			};
			string text2 = Conversions.ToString(sqlCommand.ExecuteScalar());
			string text3 = text + ".mdf";
			string text4 = text + "_log.ldf";
			text2 = text2.Replace("\\master.mdf", "");
			try
			{
				bool flag = File.Exists(text2 + "\\" + text + ".mdf");
				if (flag)
				{
					text3 = this.GetNextFileName(text2, text) + ".mdf";
				}
				flag = File.Exists(text2 + "\\" + text + "_log.ldf");
				if (flag)
				{
					text4 = this.GetNextFileName(text2, text) + "_log.ldf";
				}
			}
			catch (Exception expr_120)
			{
				ProjectData.SetProjectError(expr_120);
				ProjectData.ClearProjectError();
			}
			text = text3.Replace(".mdf", "");
			string commandText = string.Concat(new string[]
			{
				"CREATE DATABASE [",
				text,
				"] ON  PRIMARY ",
				Environment.NewLine,
				" ( NAME = N'",
				text,
				"', FILENAME = N'",
				text2,
				"\\",
				text3,
				"' , SIZE = 3072KB , FILEGROWTH = 1024KB ) ",
				Environment.NewLine,
				"  LOG ON  ",
				Environment.NewLine,
				" ( NAME = N'",
				text,
				"_log', FILENAME = N'",
				text2,
				"\\",
				text4,
				"' , SIZE = 1024KB , FILEGROWTH = 10%) ",
				Environment.NewLine,
				" COLLATE Arabic_CI_AS"
			});
			SqlCommand sqlCommand2 = new SqlCommand
			{
				Connection = sqlConnection
			};
			sqlCommand2.CommandText = commandText;
			sqlCommand2.ExecuteNonQuery();
			commandText = string.Concat(new string[]
			{
				"  ALTER DATABASE [",
				text,
				"] SET COMPATIBILITY_LEVEL = 100 ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET ANSI_NULL_DEFAULT OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET ANSI_NULLS OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET ANSI_PADDING OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET ANSI_WARNINGS OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET ARITHABORT OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET AUTO_CLOSE OFF  ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET AUTO_CREATE_STATISTICS ON ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET AUTO_SHRINK OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET AUTO_UPDATE_STATISTICS ON ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET CURSOR_CLOSE_ON_COMMIT OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET CURSOR_DEFAULT  GLOBAL  ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET CONCAT_NULL_YIELDS_NULL OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET NUMERIC_ROUNDABORT OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET QUOTED_IDENTIFIER OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET RECURSIVE_TRIGGERS OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET  DISABLE_BROKER ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET AUTO_UPDATE_STATISTICS_ASYNC OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET DATE_CORRELATION_OPTIMIZATION OFF ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET PARAMETERIZATION SIMPLE ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET  READ_WRITE ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET RECOVERY SIMPLE ",
				Environment.NewLine,
				" ALTER DATABASE [",
				text,
				"] SET  MULTI_USER ",
				Environment.NewLine,
				"ALTER DATABASE [",
				text,
				"] SET PAGE_VERIFY CHECKSUM  ",
				Environment.NewLine,
				"       USE [",
				text,
				"]",
				Environment.NewLine,
				" IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [",
				text,
				"] MODIFY FILEGROUP [PRIMARY] DEFAULT"
			});
			sqlCommand2.CommandText = commandText;
			sqlCommand2.ExecuteNonQuery();
			string text5 = text;
			string text6 = Application.StartupPath + "\\fr.bk";
			sqlCommand2.CommandText = string.Concat(new string[]
			{
				"USE Master RESTORE DATABASE ",
				text5,
				" FROM  DISK = N'",
				text6,
				"' WITH  FILE = 1, MOVE N'Fruitbox' TO N'",
				text2 + "\\" + text3,
				"',MOVE N'Fruitbox_log' TO N'",
				text2 + "\\" + text4,
				"' ,NOUNLOAD,  REPLACE,  STATS = 100"
			});
			sqlCommand2.ExecuteNonQuery();
			sqlConnection.Close();
			return text;
		}
	}
}
