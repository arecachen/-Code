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
    //public partial class QRCodeJobReport
    //{
      
    //    public Collection<QRCodeJobReport> findAll()
    //    {
    //        Collection<QRCodeJobReport> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from QRCodeJobReport order by QRCJobReportTID asc", "QRCodeJobReport");
    //            if (ds.Tables["QRCodeJobReport"].Rows.Count > 0)
    //            {
    //                c = new Collection<QRCodeJobReport>();
    //                foreach (DataRow dr in ds.Tables["QRCodeJobReport"].Rows)
    //                {
    //                    QRCodeJobReport am = new QRCodeJobReport();
    //                    am.QRCJobID = Convert.ToInt32(dr["QRCJobID"]);
    //                    am.JReportDate = Convert.ToInt64(dr["JReportDate"]);
    //                    am.JReportAckDate = dr["JReportAckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["JReportAckDate"]);
    //                    am.JReportCompleteDate = dr["JReportCompleteDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["JReportCompleteDate"]);
    //                    am.JReportUserName = Convert.ToString(dr["JReportUserName"]);
    //                    am.JReportUserPhone = Convert.ToString(dr["JReportUserPhone"]);
    //                    am.JReportUserEmail = Convert.ToString(dr["JReportUserEmail"]);
    //                    am.JReportDetails = Convert.ToString(dr["JReportDetails"]);
    //                    am.JReportStatus = Convert.ToString(dr["JReportStatus"]);
    //                    am.QRCJobReportTID = Convert.ToInt32(dr["QRCJobReportTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<QRCodeJobReport> findByKeyword(String sqlCmd)
    //    {
    //        Collection<QRCodeJobReport> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "QRCodeJobReport");
    //            if (ds.Tables["QRCodeJobReport"].Rows.Count > 0)
    //            {
    //                c = new Collection<QRCodeJobReport>();
    //                foreach (DataRow dr in ds.Tables["QRCodeJobReport"].Rows)
    //                {
    //                    QRCodeJobReport am = new QRCodeJobReport();
    //                    am.QRCJobID = Convert.ToInt32(dr["QRCJobID"]);
    //                    am.JReportDate = Convert.ToInt64(dr["JReportDate"]);
    //                    am.JReportAckDate = dr["JReportAckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["JReportAckDate"]);
    //                    am.JReportCompleteDate = dr["JReportCompleteDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["JReportCompleteDate"]);
    //                    am.JReportUserName = Convert.ToString(dr["JReportUserName"]);
    //                    am.JReportUserPhone = Convert.ToString(dr["JReportUserPhone"]);
    //                    am.JReportUserEmail = Convert.ToString(dr["JReportUserEmail"]);
    //                    am.JReportDetails = Convert.ToString(dr["JReportDetails"]);
    //                    am.JReportStatus = Convert.ToString(dr["JReportStatus"]);
    //                    am.QRCJobReportTID = Convert.ToInt32(dr["QRCJobReportTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public QRCodeJobReport findByPrimaryKey(int QRCJobReportTID)
    //    {
    //        QRCodeJobReport am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM QRCodeJobReport a WHERE a.QRCJobReportTID = " + QRCJobReportTID;
    //            DataSet ds = my.select(sqlCmd, "QRCodeJobReport");
    //            if (ds.Tables["QRCodeJobReport"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["QRCodeJobReport"].Rows[0];
    //                am = new QRCodeJobReport();
    //                am.QRCJobID = Convert.ToInt32(dr["QRCJobID"]);
    //                am.JReportDate = Convert.ToInt64(dr["JReportDate"]);
    //                am.JReportAckDate = dr["JReportAckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["JReportAckDate"]);
    //                am.JReportCompleteDate = dr["JReportCompleteDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["JReportCompleteDate"]);
    //                am.JReportUserName = Convert.ToString(dr["JReportUserName"]);
    //                am.JReportUserPhone = Convert.ToString(dr["JReportUserPhone"]);
    //                am.JReportUserEmail = Convert.ToString(dr["JReportUserEmail"]);
    //                am.JReportDetails = Convert.ToString(dr["JReportDetails"]);
    //                am.JReportStatus = Convert.ToString(dr["JReportStatus"]);
    //                am.QRCJobReportTID = Convert.ToInt32(dr["QRCJobReportTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int QRCJobID, long JReportDate, long JReportAckDate, long JReportCompleteDate, String JReportUserName, String JReportUserPhone, String JReportUserEmail, String JReportDetails, String JReportStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(QRCJobID + ",");
    //            sb_value.Append(JReportDate + ",");
    //            sb_value.Append(JReportAckDate + ",");
    //            sb_value.Append(JReportCompleteDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JReportUserName) ? "null" : "N'" + Regex.Replace(JReportUserName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JReportUserPhone) ? "null" : "N'" + Regex.Replace(JReportUserPhone, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JReportUserEmail) ? "null" : "N'" + Regex.Replace(JReportUserEmail, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JReportDetails) ? "null" : "N'" + Regex.Replace(JReportDetails, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JReportStatus) ? "''" : "N'" + Regex.Replace(JReportStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into QRCodeJobReport(QRCJobID,JReportDate,JReportAckDate,JReportCompleteDate,JReportUserName,JReportUserPhone,JReportUserEmail,JReportDetails,JReportStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int create()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(this.QRCJobID + ",");
    //            sb_value.Append(this.JReportDate + ",");
    //            sb_value.Append(this.JReportAckDate + ",");
    //            sb_value.Append(this.JReportCompleteDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JReportUserName) ? "null" : "N'" + Regex.Replace(this.JReportUserName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JReportUserPhone) ? "null" : "N'" + Regex.Replace(this.JReportUserPhone, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JReportUserEmail) ? "null" : "N'" + Regex.Replace(this.JReportUserEmail, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JReportDetails) ? "null" : "N'" + Regex.Replace(this.JReportDetails, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JReportStatus) ? "''" : "N'" + Regex.Replace(this.JReportStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into QRCodeJobReport(QRCJobID,JReportDate,JReportAckDate,JReportCompleteDate,JReportUserName,JReportUserPhone,JReportUserEmail,JReportDetails,JReportStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int QRCJobReportTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from QRCodeJobReport where QRCJobReportTID = " + QRCJobReportTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.delete() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int DeleteByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int QRCJobID, long JReportDate, long JReportAckDate, long JReportCompleteDate, String JReportUserName, String JReportUserPhone, String JReportUserEmail, String JReportDetails, String JReportStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("QRCJobID =" + QRCJobID + ",");
    //            sb_value.Append("JReportDate =" + JReportDate + ",");
    //            sb_value.Append("JReportAckDate =" + JReportAckDate + ",");
    //            sb_value.Append("JReportCompleteDate =" + JReportCompleteDate + ",");
    //            sb_value.Append("JReportUserName=" + (String.IsNullOrEmpty(JReportUserName) ? "null" : "N'" + Regex.Replace(JReportUserName, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportUserPhone=" + (String.IsNullOrEmpty(JReportUserPhone) ? "null" : "N'" + Regex.Replace(JReportUserPhone, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportUserEmail=" + (String.IsNullOrEmpty(JReportUserEmail) ? "null" : "N'" + Regex.Replace(JReportUserEmail, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportDetails=" + (String.IsNullOrEmpty(JReportDetails) ? "null" : "N'" + Regex.Replace(JReportDetails, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportStatus=" + (String.IsNullOrEmpty(JReportStatus) ? "''" : "N'" + Regex.Replace(JReportStatus, "'", "''") + "'"));

    //            String sqlCmd = "update QRCodeJobReport set  " + sb_value.ToString() + "  where QRCJobReportTID = " + this.QRCJobReportTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("QRCJobID =" + this.QRCJobID + ",");
    //            sb_value.Append("JReportDate =" + this.JReportDate + ",");
    //            sb_value.Append("JReportAckDate =" + this.JReportAckDate + ",");
    //            sb_value.Append("JReportCompleteDate =" + this.JReportCompleteDate + ",");
    //            sb_value.Append("JReportUserName=" + (String.IsNullOrEmpty(this.JReportUserName) ? "null" : "N'" + Regex.Replace(this.JReportUserName, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportUserPhone=" + (String.IsNullOrEmpty(this.JReportUserPhone) ? "null" : "N'" + Regex.Replace(this.JReportUserPhone, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportUserEmail=" + (String.IsNullOrEmpty(this.JReportUserEmail) ? "null" : "N'" + Regex.Replace(this.JReportUserEmail, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportDetails=" + (String.IsNullOrEmpty(this.JReportDetails) ? "null" : "N'" + Regex.Replace(this.JReportDetails, "'", "''") + "'") + ",");
    //            sb_value.Append("JReportStatus=" + (String.IsNullOrEmpty(this.JReportStatus) ? "''" : "N'" + Regex.Replace(this.JReportStatus, "'", "''") + "'"));

    //            String sqlCmd = "update QRCodeJobReport set  " + sb_value.ToString() + "  where QRCJobReportTID = " + this.QRCJobReportTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "QRCodeJobReport");
    //            if (ds.Tables["QRCodeJobReport"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["QRCodeJobReport"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJobReport.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


