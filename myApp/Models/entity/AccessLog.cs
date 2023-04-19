using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
namespace hsintongERP2022.Models
{
//public partial class AccessLog{

//public Collection<AccessLog> findAll()
//{
//Collection<AccessLog> c = null;
//try
//{
//MssqlTool my = new MssqlTool("");
//DataSet ds = my.select("select * from AccessLog order by logTID asc", "AccessLog");
//if (ds.Tables["AccessLog"].Rows.Count > 0)
//{
//c = new Collection<AccessLog>();
//foreach (DataRow dr in ds.Tables["AccessLog"].Rows)
//{
//AccessLog am = new AccessLog();
//am.logDatetime =  Convert.ToInt64(dr["logDatetime"]);
//am.logAccID =  Convert.ToInt32(dr["logAccID"]);
//am.logAction =  Convert.ToString(dr["logAction"]);
//am.logDesc =  Convert.ToString(dr["logDesc"]);
//am.memo =  Convert.ToString(dr["memo"]);
//am.logTID =  Convert.ToInt32(dr["logTID"]);
//c.Add(am);
//}
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.findAll() : " + e.ToString());
//}
//return c;
//}


//public Collection<AccessLog> findByKeyword(String sqlCmd)
//{
//Collection<AccessLog> c = null;
//try
//{
//MssqlTool my = new MssqlTool("");
//DataSet ds = my.select(sqlCmd, "AccessLog");
//if (ds.Tables["AccessLog"].Rows.Count > 0)
//{
//c = new Collection<AccessLog>();
//foreach (DataRow dr in ds.Tables["AccessLog"].Rows)
//{
//AccessLog am = new AccessLog();
//am.logDatetime =  Convert.ToInt64(dr["logDatetime"]);
//am.logAccID =  Convert.ToInt32(dr["logAccID"]);
//am.logAction =  Convert.ToString(dr["logAction"]);
//am.logDesc =  Convert.ToString(dr["logDesc"]);
//am.memo =  Convert.ToString(dr["memo"]);
//am.logTID =  Convert.ToInt32(dr["logTID"]);
//c.Add(am);
//}
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.findByKeyword() : " + e.ToString());
//}
//return c;
//}


//public AccessLog findByPrimaryKey(int logTID)
//{
//AccessLog am = null;
//try
//{
//MssqlTool my = new MssqlTool("");
//String sqlCmd = "select * FROM AccessLog a WHERE a.logTID = " + logTID;
//DataSet ds = my.select(sqlCmd, "AccessLog");
//if (ds.Tables["AccessLog"].Rows.Count == 1)
//{
//DataRow dr = ds.Tables["AccessLog"].Rows[0];
//am = new AccessLog();
//am.logDatetime =  Convert.ToInt64(dr["logDatetime"]);
//am.logAccID =  Convert.ToInt32(dr["logAccID"]);
//am.logAction =  Convert.ToString(dr["logAction"]);
//am.logDesc =  Convert.ToString(dr["logDesc"]);
//am.memo =  Convert.ToString(dr["memo"]);
//am.logTID =  Convert.ToInt32(dr["logTID"]);
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.findByPrimaryKey() : " + e.ToString());
//}
//return am;
//}


//public int create( long logDatetime, int logAccID, String logAction, String logDesc, String memo)
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool("");
//StringBuilder sb_value = new StringBuilder();
//sb_value.Append(logDatetime+",");
//sb_value.Append(logAccID+",");
//sb_value.Append((String.IsNullOrEmpty(logAction) ? "''" : "N'"+Regex.Replace(logAction,"'","''")+"'")+",");
//sb_value.Append((String.IsNullOrEmpty(logDesc) ? "''" : "N'"+Regex.Replace(logDesc,"'","''")+"'")+",");
//sb_value.Append((String.IsNullOrEmpty(memo) ? "null" : "N'"+Regex.Replace(memo,"'","''")+"'"));

//String sqlCmd = "insert into AccessLog(logDatetime,logAccID,logAction,logDesc,memo) values ("+ sb_value.ToString() +")";
//count = my.insertBackIdentity(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.create() : " + e.ToString());
//}
//return count;
//}


//public int create()
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool("");
//StringBuilder sb_value = new StringBuilder();
//sb_value.Append(this.logDatetime+",");
//sb_value.Append(this.logAccID+",");
//sb_value.Append((String.IsNullOrEmpty(this.logAction) ? "''" : "N'"+Regex.Replace(this.logAction,"'","''")+"'")+",");
//sb_value.Append((String.IsNullOrEmpty(this.logDesc) ? "''" : "N'"+Regex.Replace(this.logDesc,"'","''")+"'")+",");
//sb_value.Append((String.IsNullOrEmpty(this.memo) ? "null" : "N'"+Regex.Replace(this.memo,"'","''")+"'"));

//String sqlCmd = "insert into AccessLog(logDatetime,logAccID,logAction,logDesc,memo) values ("+ sb_value.ToString() +")";
//count = my.insertBackIdentity(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.create() : " + e.ToString());
//}
//return count;
//}


//public int Delete(int logTID)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool("");
//String sqlCmd = "delete from AccessLog where logTID = " + logTID;
//count = my.delete(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.delete() : " + e.ToString());
//}
//return count;
//}


//public int DeleteByKeyword(String sqlCmd)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool("");
//count = my.delete(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.DeleteByKeyword() : " + e.ToString());
//}
//return count;
//}


//public int update( long logDatetime, int logAccID, String logAction, String logDesc, String memo)
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool("");
//StringBuilder sb_value = new StringBuilder();
//sb_value.Append("logDatetime =" + logDatetime+",");
//sb_value.Append("logAccID =" + logAccID+",");
//sb_value.Append("logAction="+ (String.IsNullOrEmpty(logAction) ? "''" : "N'"+Regex.Replace(logAction,"'","''")+"'")+",");
//sb_value.Append("logDesc="+ (String.IsNullOrEmpty(logDesc) ? "''" : "N'"+Regex.Replace(logDesc,"'","''")+"'")+",");
//sb_value.Append("memo="+ (String.IsNullOrEmpty(memo) ? "null" : "N'"+Regex.Replace(memo,"'","''")+"'"));

//String sqlCmd = "update AccessLog set  "+ sb_value.ToString() +"  where logTID = " + this.logTID;
//count = my.update(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.create() : " + e.ToString());
//}
//return count;
//}


//public int update()
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool("");
//StringBuilder sb_value = new StringBuilder();
//sb_value.Append("logDatetime =" + this.logDatetime+",");
//sb_value.Append("logAccID =" + this.logAccID+",");
//sb_value.Append("logAction="+ (String.IsNullOrEmpty(this.logAction) ? "''" : "N'"+Regex.Replace(this.logAction,"'","''")+"'")+",");
//sb_value.Append("logDesc="+ (String.IsNullOrEmpty(this.logDesc) ? "''" : "N'"+Regex.Replace(this.logDesc,"'","''")+"'")+",");
//sb_value.Append("memo="+ (String.IsNullOrEmpty(this.memo) ? "null" : "N'"+Regex.Replace(this.memo,"'","''")+"'"));

//String sqlCmd = "update AccessLog set  "+ sb_value.ToString() +"  where logTID = " + this.logTID;
//count = my.update(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.update() : " + e.ToString());
//}
//return count;
//}


//public int TotalCountByKeyword(String sqlCmd)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool("");
//DataSet ds = my.select(sqlCmd, "AccessLog");
//if (ds.Tables["AccessLog"].Rows.Count > 0)
//{
//DataRow dr = ds.Tables["AccessLog"].Rows[0];
//count = Convert.ToInt32(dr[0]);
//}
//}
//catch (Exception e)
//{
//count = 0;
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessLog.TotalCountByKeyword() : " + e.ToString());
//}
//return count;
//}


//}
}


