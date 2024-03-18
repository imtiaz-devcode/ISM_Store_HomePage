using System;
using System.Web;
using System.Configuration;
using System.Web.SessionState;
using System.Data;
using System.Collections;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Xsl;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;

namespace ISM_Store_HomePage
{
	public class DB
	{

		static CultureInfo USCulture = new CultureInfo("en-US");
		//static CultureInfo SqlServerCulture = new CultureInfo(CommonLogic.Application("ConnectionString"));

		public DB() { }

		static private String _activeDBConn = SetDBConn();
		static private String _NoLockString = "N/A";

		static private String SetDBConn()
		{
			String s = CommonLogic.Application("ConnectionString");
			return s;
		}

		static public String GetDBConn()
		{
			return _activeDBConn;
		}

		static public String GetNoLock()
		{
			if (_NoLockString == "N/A")
			{
				// must set it the first time:
				_NoLockString = String.Empty;
				if (CommonLogic.ApplicationBool("UseSQLNoLock") || CommonLogic.ApplicationBool("SQLNoLock"))
				{
					_NoLockString = " with (NOLOCK) ";
				}
			}
			return _NoLockString;
		}

		public static String SQuote(String s)
		{
			return "N'" + s.Replace("'", "''") + "'";
		}

		public static String SQuoteNotUnicode(String s)
		{
			return "'" + s.Replace("'", "''") + "'";
		}

		public static String DateQuote(String s)
		{
			return "'" + s.Replace("'", "''") + "'";
		}

		static public IDataReader GetRS(String Sql)
		{
			if (CommonLogic.ApplicationBool("DumpSQL"))
			{
				HttpContext.Current.Response.Write("SQL=" + Sql + "<br/>\n");
			}

			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();

			SqlCommand cmd = new SqlCommand(Sql, dbconn);
			return cmd.ExecuteReader(CommandBehavior.CloseConnection);
		}

		static public IDataReader SPGetRS(String procCall)
		{
			if (CommonLogic.ApplicationBool("DumpSQL"))
			{
				HttpContext.Current.Response.Write("SP=" + procCall + "<br/>\n");
			}
			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();
			SqlCommand cmd = new SqlCommand(procCall, dbconn);
			cmd.CommandType = CommandType.StoredProcedure;
			return cmd.ExecuteReader(CommandBehavior.CloseConnection);
		}

		public static DataSet SPGetDS(String Sql)
		{
			if (CommonLogic.ApplicationBool("DumpSQL"))
			{
				HttpContext.Current.Response.Write("SQL=" + Sql + "<br/>");
			}

			DataSet ds = new DataSet();
			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();

			SqlCommand cmd = new SqlCommand(Sql, dbconn);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(ds, "Table");
			dbconn.Close();
			return ds;
		}

		static public void ExecuteSQL(String Sql)
		{
			if (CommonLogic.ApplicationBool("DumpSQL"))
			{
				HttpContext.Current.Response.Write("SQL=" + Sql + "<br/>\n");
			}

			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();
			SqlCommand cmd = new SqlCommand(Sql, dbconn);

			try
			{
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				dbconn.Close();
				dbconn.Dispose();
			}
			catch (Exception ex)
			{
				cmd.Dispose();
				dbconn.Close();
				dbconn.Dispose();
				throw (ex);
			}
		}

		// NOTE FOR DB ACCESSOR FUNCTIONS: AdminSite try/catch block is needed until
		// we convert to the new admin page styles. Our "old" db accessors handled empty
		// recordset conditions, so we need to preserve that for the admin site to add 
		// new products/categories/etc...
		//
		// We do not use try/catch on the store site for speed

		// ----------------------------------------------------------------
		//
		// SIMPLE ROW FIELD ROUTINES
		//
		// ----------------------------------------------------------------

		public static String RowField(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return String.Empty;
				}
				return Convert.ToString(row[fieldname]);
			}
			catch
			{
				return String.Empty;
			}

		}

		public static bool RowFieldBool(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return false;
				}
				String s = row[fieldname].ToString().ToUpperInvariant();
				return (s == "TRUE" || s == "YES" || s == "1");
			}
			catch
			{
				return false;
			}

		}

		public static Byte RowFieldByte(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return 0;
				}
				return Convert.ToByte(row[fieldname]);
			}
			catch
			{
				return 0;
			}

		}

		public static String RowFieldGUID(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return String.Empty;
				}
				return Convert.ToString(row[fieldname]);
			}
			catch
			{
				return String.Empty;
			}

		}

		public static int RowFieldInt(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return 0;
				}
				return Convert.ToInt32(row[fieldname]);
			}
			catch
			{
				return 0;
			}

		}

		public static int RowFieldTinyInt(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return 0;
				}
				return Convert.ToInt16(row[fieldname]);
			}
			catch
			{
				return 0;
			}

		}

		public static long RowFieldLong(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return 0;
				}
				return Convert.ToInt64(row[fieldname]);
			}
			catch
			{
				return 0;
			}

		}

		public static Single RowFieldSingle(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return 0.0F;
				}
				return Convert.ToSingle(row[fieldname]);
			}
			catch
			{
				return 0.0F;
			}

		}

		public static Double RowFieldDouble(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return 0.0F;
				}
				return Convert.ToDouble(row[fieldname]);
			}
			catch
			{
				return 0.0F;
			}

		}

		public static Decimal RowFieldDecimal(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return System.Decimal.Zero;
				}
				return Convert.ToDecimal(row[fieldname]);
			}
			catch
			{
				return System.Decimal.Zero;
			}

		}


		public static DateTime RowFieldDateTime(DataRow row, String fieldname)
		{
			try
			{
				if (Convert.IsDBNull(row[fieldname]))
				{
					return System.DateTime.MinValue;
				}
				return Convert.ToDateTime(row[fieldname]);
			}
			catch
			{
				return System.DateTime.MinValue;
			}

		}

		// ----------------------------------------------------------------
		//
		// SIMPLE RS FIELD ROUTINES
		//
		// ----------------------------------------------------------------

		public static String RSField(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return String.Empty;
				}
				return rs.GetString(idx);
			}
			catch
			{
				return String.Empty;
			}

		}


		public static bool RSFieldBool(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return false;
				}
				String s = rs[fieldname].ToString().ToUpperInvariant();
				return (s == "TRUE" || s == "YES" || s == "1");
			}
			catch
			{
				return false;
			}
		}

		public static String RSFieldGUID(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return String.Empty;
				}
				return rs.GetGuid(idx).ToString();
			}
			catch
			{
				return String.Empty;
			}
		}

		public static Byte RSFieldByte(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return 0;
				}
				return rs.GetByte(idx);
			}
			catch
			{
				return 0;
			}
		}

		public static int RSFieldInt(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return 0;
				}
				return rs.GetInt32(idx);
			}
			catch
			{
				return 0;
			}
		}

		public static Int16 RSFieldTinyInt(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return 0;
				}
				return Convert.ToInt16(rs.GetValue(idx));
			}
			catch
			{
				return 0;
			}
		}

		public static long RSFieldLong(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return 0;
				}
				return rs.GetInt64(idx);
			}
			catch
			{
				return 0;
			}
		}

		public static Single RSFieldSingle(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return 0.0F;
				}
				return (Single)rs.GetDouble(idx); // SQL server seems to fail the GetFloat calls, so we have to do this
			}
			catch
			{
				return 0.0F;
			}
		}

		public static Double RSFieldDouble(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return 0.0F;
				}
				return rs.GetDouble(idx);
			}
			catch
			{
				return 0.0F;
			}
		}

		public static Decimal RSFieldDecimal(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return System.Decimal.Zero;
				}
				return rs.GetDecimal(idx);
			}
			catch
			{
				return System.Decimal.Zero;
			}
		}

		public static DateTime RSFieldDateTime(IDataReader rs, String fieldname)
		{
			try
			{
				int idx = rs.GetOrdinal(fieldname);
				if (rs.IsDBNull(idx))
				{
					return System.DateTime.MinValue;
				}
				return Convert.ToDateTime(rs[idx]);
				//return rs.GetDateTime(idx);
			}
			catch
			{
				return System.DateTime.MinValue;
			}
		}

		public static DataSet GetTable(String tablename, String orderBy, String cacheName, bool useCache)
		{
			if (useCache)
			{
				DataSet cacheds = (DataSet)HttpRuntime.Cache.Get(cacheName);
				if (cacheds != null)
				{
					return cacheds;
				}
			}
			DataSet ds = new DataSet();
			String Sql = String.Empty;
			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();
			Sql = "select * from " + tablename + " order by " + orderBy;
			SqlDataAdapter da = new SqlDataAdapter(Sql, dbconn);
			da.Fill(ds, tablename);
			dbconn.Close();
			if (useCache)
			{
				HttpRuntime.Cache.Insert(cacheName, ds);
			}
			return ds;
		}

		/// <summary>
		/// Incrementally adds tables results to a dataset
		/// </summary>
		/// <param name="ds">Dataset to add the table to</param>
		/// <param name="tableName">Name of the table to be created in the DataSet</param>
		/// <param name="sqlQuery">Query to retrieve the data for the table.</param>
		static public int FillDataSet(DataSet ds, string tableName, string sqlQuery)
		{
			int n = 0;
			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, dbconn);
			n = da.Fill(ds, tableName);
			dbconn.Close();
			return n;
		}

		public static DataSet GetDS(String Sql, String cacheName, bool useCache, System.DateTime expiresAt, int TimeoutSecs = 0)
		{
			if (useCache)
			{
				DataSet cacheds = (DataSet)HttpRuntime.Cache.Get(cacheName);
				if (cacheds != null)
				{
					if (CommonLogic.ApplicationBool("ConnectionString"))
					{
						HttpContext.Current.Response.Write("SQL=[From Cache]" + Sql + "<br/>");
					}
					return cacheds;
				}
			}
			if (CommonLogic.ApplicationBool("ConnectionString"))
			{
				HttpContext.Current.Response.Write("SQL=" + Sql + "<br/>");
			}
			DataSet ds = new DataSet();
			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();
			SqlDataAdapter da = new SqlDataAdapter(Sql, dbconn);

			if (TimeoutSecs > 0)
			{
				da.SelectCommand.CommandTimeout = TimeoutSecs;
			}

			da.Fill(ds, "Table");
			dbconn.Close();
			if (useCache)
			{
				HttpRuntime.Cache.Insert(cacheName, ds, null, expiresAt, TimeSpan.Zero);
			}
			return ds;
		}

		public static DataSet GetDS(String Sql, String cacheName, bool useCache)
		{
			return GetDS(Sql, cacheName, useCache, System.DateTime.Now.AddMinutes(30));
		}

		public static DataSet GetDS(String Sql, bool useCache, System.DateTime expiresAt, int TimeoutSecs = 0)
		{
			return GetDS(Sql, "DataSet: " + Sql.ToUpperInvariant(), useCache, expiresAt, TimeoutSecs);
		}

		public static DataSet GetDS(String Sql, bool useCache)
		{
			return GetDS(Sql, useCache, 0);
		}

		public static DataSet GetDS(String Sql, bool useCache, int TimeoutSecs)
		{
			return GetDS(Sql, useCache, System.DateTime.Now.AddMinutes(30), TimeoutSecs);
		}

		public static String GetNewGUID()
		{
			return System.Guid.NewGuid().ToString();
		}

		static public int GetSqlN(String Sql)
		{
			int N = 0;
			IDataReader rs = DB.GetRS(Sql);
			if (rs.Read())
			{
				N = DB.RSFieldInt(rs, "N");
			}
			rs.Close();
			return N;
		}

		static public DateTime GetSqlNDateTime(String Sql)
		{
			DateTime N = System.DateTime.MinValue;
			IDataReader rs = DB.GetRS(Sql);

			if (rs.Read())
			{
				N = DB.RSFieldDateTime(rs, "N");
			}
			rs.Close();
			return N;
		}

		static public bool GetSqlNBool(String Sql)
		{
			bool N = false;
			IDataReader rs = DB.GetRS(Sql);

			if (rs.Read())
			{
				int idx = rs.GetOrdinal("N");
				if (rs.IsDBNull(idx))
				{
					N = false;
				}
				else
				{
					String s = rs["N"].ToString().ToUpperInvariant();
					N = (s == "TRUE" || s == "YES" || s == "1");
				}
			}

			rs.Close();
			return N;
		}

		static public Single GetSqlNSingle(String Sql)
		{
			Single N = 0.0F;
			IDataReader rs = DB.GetRS(Sql);
			if (rs.Read())
			{
				N = DB.RSFieldSingle(rs, "N");
			}
			rs.Close();
			return N;
		}

		static public decimal GetSqlNDecimal(String Sql)
		{
			decimal N = System.Decimal.Zero;
			IDataReader rs = DB.GetRS(Sql);
			if (rs.Read())
			{
				N = DB.RSFieldDecimal(rs, "N");
			}
			rs.Close();
			return N;
		}

		static public void ExecuteLongTimeSQL(String Sql, int TimeoutSecs)
		{
			ExecuteLongTimeSQL(Sql, DB.GetDBConn(), TimeoutSecs);
		}

		static public String GetSqlSAllLocales(String Sql)
		{
			String S = String.Empty;
			IDataReader rs = DB.GetRS(Sql);
			if (rs.Read())
			{
				S = DB.RSField(rs, "S");
				if (S.Equals(DBNull.Value))
				{
					S = String.Empty;
				}
			}
			rs.Close();
			return S;
		}

		static public string GetSqlXml(String Sql, string xslTranformFile)
		{
			if (Sql.ToUpper(CultureInfo.InvariantCulture).IndexOf("FOR XML") < 1)
			{
				Sql += " FOR XML AUTO";
			}
			StringBuilder s = new StringBuilder(4096);
			IDataReader rs = DB.GetRS(Sql);
			while (rs.Read())
			{
				s.Append(rs.GetString(0));
			}
			rs.Close();
			XmlDocument xdoc = new XmlDocument();
			xdoc.LoadXml("<root>" + s.ToString() + "</root>");
			if (xslTranformFile != null && xslTranformFile.Trim() != "")
			{
				XslCompiledTransform xsl = new XslCompiledTransform();
				xsl.Load(xslTranformFile);
				TextWriter tw = new StringWriter();
				xsl.Transform(xdoc, null, tw);
				return tw.ToString();
			}
			else
			{
				return xdoc.DocumentElement.InnerXml;
			}
		}

		static public XmlDocument GetSqlXmlDoc(String Sql, string xslTranformFile)
		{
			if (Sql.ToUpper(CultureInfo.InvariantCulture).IndexOf("FOR XML") < 1)
			{
				Sql += " FOR XML AUTO";
			}
			StringBuilder s = new StringBuilder(4096);
			IDataReader rs = DB.GetRS(Sql);
			while (rs.Read())
			{
				s.Append(rs.GetString(0));
			}
			rs.Close();
			XmlDocument xdoc = new XmlDocument();
			xdoc.LoadXml("<root>" + s.ToString() + "</root>");
			if (xslTranformFile != null && xslTranformFile.Trim() != "")
			{
				XslCompiledTransform xsl = new XslCompiledTransform();
				xsl.Load(xslTranformFile);
				TextWriter tw = new StringWriter();
				xsl.Transform(xdoc, null, tw);
				xdoc.LoadXml(tw.ToString());
			}
			return xdoc;
		}

		static public string GetSqlXml(String Sql, XslCompiledTransform xsl, XsltArgumentList xslArgs)
		{
			if (Sql.ToLower().IndexOf("for xml") < 1)
			{
				Sql += " for xml auto";
			}
			StringBuilder s = new StringBuilder(4096);
			IDataReader rs = DB.GetRS(Sql);
			while (rs.Read())
			{
				s.Append(rs.GetString(0));
			}
			rs.Close();
			XmlDocument xdoc = new XmlDocument();
			xdoc.LoadXml("<root>" + s.ToString() + "</root>");
			if (xsl != null)
			{
				TextWriter tw = new StringWriter();
				xsl.Transform(xdoc, xslArgs, tw);
				return tw.ToString();
			}
			else
			{
				return xdoc.DocumentElement.InnerXml;
			}
		}

		static public int GetXml(SqlDataReader dr, string rootEl, string rowEl, bool IsPagingProc, ref StringBuilder Xml)
		{
			int rows = 0;
			if (rootEl.Length != 0)
			{
				Xml.Append("<" + rootEl + ">");
			}
			while (dr.Read())
			{
				++rows;
				if (rowEl.Length == 0)
				{
					Xml.Append("<row>");
				}
				else
				{
					Xml.Append("<" + rowEl + ">");
				}
				for (int i = 0; i < dr.FieldCount; i++)
				{
					string elname = dr.GetName(i).Replace(" ", "_");
					if (dr.IsDBNull(i))
					{
						Xml.Append("<" + elname + "/>");
					}
					else
					{
						if (System.Convert.ToString(dr.GetValue(i)).StartsWith("<ml>"))
						{
							Xml.Append("<" + elname + ">" + System.Convert.ToString(dr.GetValue(i)) + "</" + elname + ">");
						}
						else
						{
							Xml.Append("<" + elname + ">" + System.Convert.ToString(dr.GetValue(i)).Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("'", "&apos;").Replace("\"", "&quot;") + "</" + elname + ">");
						}
					}
				}
				if (rowEl.Length == 0)
				{
					Xml.Append("</row>");
				}
				else
				{
					Xml.Append("</" + rowEl + ">");
				}

			}
			if (rootEl.Length != 0)
			{
				Xml.Append("</" + rootEl + ">");
			}
			int ResultSet = 1;
			while (dr.NextResult())
			{
				ResultSet++;
				if (IsPagingProc)
				{
					if (rootEl.Length != 0)
					{
						Xml.Append("<" + rootEl + "Paging>");
					}
					else
					{
						Xml.Append("<Paging>");
					}
				}
				else
				{
					if (rootEl.Length != 0)
					{
						Xml.Append("<" + rootEl + ResultSet.ToString() + ">");
					}
				}
				while (dr.Read())
				{
					if (!IsPagingProc)
					{
						if (rowEl.Length == 0)
						{
							Xml.Append("<row>");
						}
						else
						{
							Xml.Append("<" + rowEl + ">");
						}
					}
					for (int i = 0; i < dr.FieldCount; i++)
					{
						string elname = dr.GetName(i).Replace(" ", "_");
						if (dr.IsDBNull(i))
						{
							Xml.Append("<" + elname + "/>");
						}
						else
						{
							if (System.Convert.ToString(dr.GetValue(i)).StartsWith("<ml>"))
							{
								Xml.Append("<" + elname + ">" + System.Convert.ToString(dr.GetValue(i)) + "</" + elname + ">");
							}
							else
							{
								Xml.Append("<" + elname + ">" + System.Convert.ToString(dr.GetValue(i)).Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("'", "&apos;").Replace("\"", "&quot;") + "</" + elname + ">");
							}
						}
					}
					if (!IsPagingProc)
					{
						if (rowEl.Length == 0)
						{
							Xml.Append("</row>");
						}
						else
						{
							Xml.Append("</" + rowEl + ">");
						}
					}
				}
				if (IsPagingProc)
				{
					if (rootEl.Length != 0)
					{
						Xml.Append("</" + rootEl + "Paging>");
					}
					else
					{
						Xml.Append("</Paging>");
					}
				}
				else
				{
					if (rootEl.Length != 0)
					{
						Xml.Append("</" + rootEl + ResultSet.ToString() + ">");
					}
				}
			}
			dr.Close();
			return rows;
		}

		// assumes a 2nd result set is the PAGING INFO back from the aspdnsf_PageQuery proc!!!
		// looks for aspdnsf_PageQuery in the Sql input to determine this!
		static public int GetXml(string Sql, string rootEl, string rowEl, ref string Xml)
		{
			bool IsPagingProc = (Sql.IndexOf("aspdnsf_PageQuery") != -1);
			StringBuilder s = new StringBuilder(4096);
			IDataReader rs = DB.GetRS(Sql);
			int rows = 0;
			if (rootEl.Length != 0)
			{
				s.Append("<" + rootEl + ">");
			}
			while (rs.Read())
			{
				++rows;
				if (rowEl.Length == 0)
				{
					s.Append("<row>");
				}
				else
				{
					s.Append("<" + rowEl + ">");
				}
				for (int i = 0; i < rs.FieldCount; i++)
				{
					string elname = rs.GetName(i).Replace(" ", "_");
					if (rs.IsDBNull(i))
					{
						s.Append("<" + elname + "/>");
					}
					else
					{
						if (System.Convert.ToString(rs.GetValue(i)).StartsWith("<ml>"))
						{
							s.Append("<" + elname + ">" + System.Convert.ToString(rs.GetValue(i)) + "</" + elname + ">");
						}
						else
						{
							s.Append("<" + elname + ">" + System.Convert.ToString(rs.GetValue(i)).Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("'", "&apos;").Replace("\"", "&quot;") + "</" + elname + ">");
						}
					}
				}
				if (rowEl.Length == 0)
				{
					s.Append("</row>");
				}
				else
				{
					s.Append("</" + rowEl + ">");
				}

			}
			if (rootEl.Length != 0)
			{
				s.Append("</" + rootEl + ">");
			}
			int ResultSet = 1;
			while (rs.NextResult())
			{
				ResultSet++;
				if (IsPagingProc)
				{
					if (rootEl.Length != 0)
					{
						s.Append("<" + rootEl + "Paging>");
					}
					else
					{
						s.Append("<Paging>");
					}
				}
				else
				{
					if (rootEl.Length != 0)
					{
						s.Append("<" + rootEl + ResultSet.ToString() + ">");
					}
				}
				while (rs.Read())
				{
					if (!IsPagingProc)
					{
						if (rowEl.Length == 0)
						{
							s.Append("<row>");
						}
						else
						{
							s.Append("<" + rowEl + ">");
						}
					}
					for (int i = 0; i < rs.FieldCount; i++)
					{
						string elname = rs.GetName(i).Replace(" ", "_");
						if (rs.IsDBNull(i))
						{
							s.Append("<" + elname + "/>");
						}
						else
						{
							if (System.Convert.ToString(rs.GetValue(i)).StartsWith("<ml>"))
							{
								s.Append("<" + elname + ">" + System.Convert.ToString(rs.GetValue(i)) + "</" + elname + ">");
							}
							else
							{
								s.Append("<" + elname + ">" + System.Convert.ToString(rs.GetValue(i)).Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("'", "&apos;").Replace("\"", "&quot;") + "</" + elname + ">");
							}
						}
					}
					if (!IsPagingProc)
					{
						if (rowEl.Length == 0)
						{
							s.Append("</row>");
						}
						else
						{
							s.Append("</" + rowEl + ">");
						}
					}
				}
				if (IsPagingProc)
				{
					if (rootEl.Length != 0)
					{
						s.Append("</" + rootEl + "Paging>");
					}
					else
					{
						s.Append("</Paging>");
					}
				}
				else
				{
					if (rootEl.Length != 0)
					{
						s.Append("</" + rootEl + ResultSet.ToString() + ">");
					}
				}
			}
			rs.Close();
			Xml = s.ToString();
			return rows;
		}

		static public void ExecuteLongTimeSQL(String Sql, String DBConnString, int TimeoutSecs)
		{
			if (CommonLogic.ApplicationBool("DumpSQL"))
			{
				HttpContext.Current.Response.Write("SQL=" + Sql + "<br/>\n");
			}

			SqlConnection dbconn = new SqlConnection();
			dbconn.ConnectionString = DB.GetDBConn();
			dbconn.Open();

			SqlCommand cmd = new SqlCommand(Sql, dbconn);
			cmd.CommandTimeout = TimeoutSecs;
			try
			{
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				dbconn.Close();
				dbconn.Dispose();
			}
			catch (Exception ex)
			{
				cmd.Dispose();
				dbconn.Close();
				dbconn.Dispose();
				throw (ex);
			}
		}
		// Created By Mashood 
		public static DataSet GetDataSet(string storedProced, SqlParameter[] sqlParameter)
		{
			DataSet ds = new DataSet();
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(sqlParameter);
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			da.Fill(ds);
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return ds;
		}
		public static DataSet GetDataSet(string StoredProcedureName, SqlParameter SPParameters)
		{
			DataSet ds = new DataSet();
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(StoredProcedureName, con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(SPParameters);
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			da.Fill(ds);
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return ds;
		}
		public static DataTable GetDataTable(string storedProced, SqlParameter[] sqlParameter)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(sqlParameter);
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			da.Fill(dt);
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return dt;
		}
		public static DataTable GetDataTable(string StoredProcedureName, SqlParameter SPParameters)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(StoredProcedureName, con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(SPParameters);
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			da.Fill(dt);
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return dt;
		}
		public static void ExecuteSP(string StoredProcedureName, SqlParameter[] SPParameters)
		{
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(StoredProcedureName, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(SPParameters);
			cmd.ExecuteNonQuery();
			con.Close();
			cmd.Dispose();
			con.Dispose();
		}
		public static void ExecuteSP(string storedProced, SqlParameter sqlParameter)
		{
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(sqlParameter);
			cmd.ExecuteNonQuery();
			con.Close();
			cmd.Dispose();
			con.Dispose();
		}
		public static int SPGetN(string storedProced, SqlParameter[] sqlParameter)
		{
			int i = 0;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				int.TryParse(v.ToString(), out i);
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return i;
		}
		public static int SPGetN(string storedProced, SqlParameter sqlParameter)
		{
			int i = 0;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				int.TryParse(v.ToString(), out i);
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return i;
		}
		public static string SPGetS(string storedProced, SqlParameter[] sqlParameter)
		{
			string s = string.Empty;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				s = v.ToString();
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return s;
		}
		public static string SPGetS(string storedProced, SqlParameter sqlParameter)
		{
			string s = string.Empty;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				s = v.ToString();
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return s;
		}
		public static bool SPGetBool(string storedProced, SqlParameter[] sqlParameter)
		{
			bool b = false;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				string s = v.ToString();
				if (s.ToUpper() == "TRUE" || s.ToUpper() == "YES" || s == "1")
				{
					b = true;
				}
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return b;
		}
		public static bool SPGetBool(string storedProced, SqlParameter sqlParameter)
		{
			bool b = false;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				string s = v.ToString();
				if (s.ToUpper() == "TRUE" || s.ToUpper() == "YES" || s == "1")
				{
					b = true;
				}
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return b;
		}
		public static decimal SPGetDecimal(string storedProced, SqlParameter[] sqlParameter)
		{
			decimal d = 0.0M;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				decimal.TryParse(v.ToString(), out d);
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return d;
		}
		public static decimal SPGetDecimal(string storedProced, SqlParameter sqlParameter)
		{
			decimal d = 0.0M;
			SqlConnection con = new SqlConnection(GetDBConn());
			SqlCommand cmd = new SqlCommand(storedProced, con);
			if (con.State == ConnectionState.Closed) { con.Open(); }
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(sqlParameter);
			var v = cmd.ExecuteScalar();
			if (v != null)
			{
				decimal.TryParse(v.ToString(), out d);
			}
			con.Close();
			cmd.Dispose();
			con.Dispose();
			return d;
		}
		// End Mashood Section
	}

	// currently only supported for SQL Server:
	public class DBTransaction
	{
		private ArrayList sqlCommands = new ArrayList();

		public DBTransaction() { }

		public void AddCommand(String Sql)
		{
			sqlCommands.Capacity = sqlCommands.Capacity + 1;
			sqlCommands.Add(Sql);
		}

		public void ClearCommands()
		{
			sqlCommands.Clear();
		}

		// returns true if no errors, or false if ANY Exception is found:
		public bool Commit()
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = DB.GetDBConn();
			conn.Open();
			SqlTransaction trans = conn.BeginTransaction();
			bool status = false;

			try
			{
				foreach (String s in sqlCommands)
				{
					SqlCommand comm = new SqlCommand(s, conn);
					comm.Transaction = trans;
					comm.ExecuteNonQuery();
				}
				trans.Commit();
				status = true;
			}
			catch //(SqlException ex)
			{
				trans.Rollback();
				status = false;
			}
			finally
			{
				conn.Close();
			}
			return status;
		}
	}
}