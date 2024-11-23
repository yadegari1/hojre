using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000056 RID: 86
	public class AsyncSQL
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00139E14 File Offset: 0x00138214
		public AsyncSQL()
		{
			this.cnn = new SqlConnection();
			this.cnn = new SqlConnection(Public_Function.Connection.ConnectionString);
			this.cnn.Open();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00139E4C File Offset: 0x0013824C
		public object ExecuteScalar(string Command)
		{
			SqlCommand sqlCommand = new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			};
			return sqlCommand.ExecuteScalar();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00139E84 File Offset: 0x00138284
		public bool ExecuteNonQuery(string Command)
		{
			bool flag = Operators.CompareString(Command, string.Empty, false) == 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				SqlTransaction sqlTransaction = Public_Function.Connection.BeginTransaction();
				try
				{
					SqlCommand sqlCommand = new SqlCommand
					{
						Connection = this.cnn,
						CommandText = Command
					};
					sqlCommand.Transaction = sqlTransaction;
					sqlCommand.ExecuteNonQuery();
					sqlTransaction.Commit();
					result = true;
				}
				catch (SqlException expr_64)
				{
					ProjectData.SetProjectError(expr_64);
					sqlTransaction.Rollback();
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00139F28 File Offset: 0x00138328
		public DataTable FillData(string Command)
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			sqlDataAdapter.SelectCommand = new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			};
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00139F74 File Offset: 0x00138374
		public DataTable FillSchema(string Command)
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			sqlDataAdapter.SelectCommand = new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			};
			sqlDataAdapter.FillSchema(dataTable, SchemaType.Mapped);
			return dataTable;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00139FC0 File Offset: 0x001383C0
		public DataRow FillDataRow(string Command)
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			sqlDataAdapter.SelectCommand = new SqlCommand
			{
				Connection = this.cnn,
				CommandText = Command
			};
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count > 0;
			DataRow result;
			if (flag)
			{
				result = dataTable.Rows[0];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0400017D RID: 381
		private SqlConnection cnn;
	}
}
