using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace hsintongERP2022.Models
{
    //[MetadataType(typeof(QRCodeJobMetadata))]
    //public partial class QRCodeJob
    //{
        
    //    public Collection<QRCodeJob> findAll()
    //    {
    //        Collection<QRCodeJob> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from QRCodeJob order by QRCJobTID asc", "QRCodeJob");
    //            if (ds.Tables["QRCodeJob"].Rows.Count > 0)
    //            {
    //                c = new Collection<QRCodeJob>();
    //                foreach (DataRow dr in ds.Tables["QRCodeJob"].Rows)
    //                {
    //                    QRCodeJob am = new QRCodeJob();
    //                    am.QRCodeJobType = Convert.ToString(dr["QRCodeJobType"]);
    //                    am.JobLinkTable = Convert.ToString(dr["JobLinkTable"]);
    //                    am.JobTaskName = Convert.ToString(dr["JobTaskName"]);
    //                    am.JobDescription = Convert.ToString(dr["JobDescription"]);
    //                    am.JobReqUserInfo = Convert.ToInt32(dr["JobReqUserInfo"]);
    //                    am.JobReqDetails = Convert.ToInt32(dr["JobReqDetails"]);
    //                    am.JobValidDate = Convert.ToInt64(dr["JobValidDate"]);
    //                    am.JobQRCodeName = Convert.ToString(dr["JobQRCodeName"]);
    //                    am.JobQRCodeLongURL = Convert.ToString(dr["JobQRCodeLongURL"]);
    //                    am.JobQRCodeShortURL = Convert.ToString(dr["JobQRCodeShortURL"]);
    //                    am.QRCJobStatus = Convert.ToString(dr["QRCJobStatus"]);
    //                    am.QRCJobTID = Convert.ToInt32(dr["QRCJobTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<QRCodeJob> findByKeyword(String sqlCmd)
    //    {
    //        Collection<QRCodeJob> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "QRCodeJob");
    //            if (ds.Tables["QRCodeJob"].Rows.Count > 0)
    //            {
    //                c = new Collection<QRCodeJob>();
    //                foreach (DataRow dr in ds.Tables["QRCodeJob"].Rows)
    //                {
    //                    QRCodeJob am = new QRCodeJob();
    //                    am.QRCodeJobType = Convert.ToString(dr["QRCodeJobType"]);
    //                    am.JobLinkTable = Convert.ToString(dr["JobLinkTable"]);
    //                    am.JobTaskName = Convert.ToString(dr["JobTaskName"]);
    //                    am.JobDescription = Convert.ToString(dr["JobDescription"]);
    //                    am.JobReqUserInfo = Convert.ToInt32(dr["JobReqUserInfo"]);
    //                    am.JobReqDetails = Convert.ToInt32(dr["JobReqDetails"]);
    //                    am.JobValidDate = Convert.ToInt64(dr["JobValidDate"]);
    //                    am.JobQRCodeName = Convert.ToString(dr["JobQRCodeName"]);
    //                    am.JobQRCodeLongURL = Convert.ToString(dr["JobQRCodeLongURL"]);
    //                    am.JobQRCodeShortURL = Convert.ToString(dr["JobQRCodeShortURL"]);
    //                    am.QRCJobStatus = Convert.ToString(dr["QRCJobStatus"]);
    //                    am.QRCJobTID = Convert.ToInt32(dr["QRCJobTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public QRCodeJob findByPrimaryKey(int QRCJobTID)
    //    {
    //        QRCodeJob am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM QRCodeJob a WHERE a.QRCJobTID = " + QRCJobTID;
    //            DataSet ds = my.select(sqlCmd, "QRCodeJob");
    //            if (ds.Tables["QRCodeJob"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["QRCodeJob"].Rows[0];
    //                am = new QRCodeJob();
    //                am.QRCodeJobType = Convert.ToString(dr["QRCodeJobType"]);
    //                am.JobLinkTable = Convert.ToString(dr["JobLinkTable"]);
    //                am.JobTaskName = Convert.ToString(dr["JobTaskName"]);
    //                am.JobDescription = Convert.ToString(dr["JobDescription"]);
    //                am.JobReqUserInfo = Convert.ToInt32(dr["JobReqUserInfo"]);
    //                am.JobReqDetails = Convert.ToInt32(dr["JobReqDetails"]);
    //                am.JobValidDate = Convert.ToInt64(dr["JobValidDate"]);
    //                am.JobQRCodeName = Convert.ToString(dr["JobQRCodeName"]);
    //                am.JobQRCodeLongURL = Convert.ToString(dr["JobQRCodeLongURL"]);
    //                am.JobQRCodeShortURL = Convert.ToString(dr["JobQRCodeShortURL"]);
    //                am.QRCJobStatus = Convert.ToString(dr["QRCJobStatus"]);
    //                am.QRCJobTID = Convert.ToInt32(dr["QRCJobTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String QRCodeJobType, String JobLinkTable, String JobTaskName, String JobDescription, int JobReqUserInfo, int JobReqDetails, long JobValidDate, String JobQRCodeName, String JobQRCodeLongURL, String JobQRCodeShortURL, String QRCJobStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(QRCodeJobType) ? "''" : "N'" + Regex.Replace(QRCodeJobType, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JobLinkTable) ? "''" : "N'" + Regex.Replace(JobLinkTable, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JobTaskName) ? "''" : "N'" + Regex.Replace(JobTaskName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JobDescription) ? "null" : "N'" + Regex.Replace(JobDescription, "'", "''") + "'") + ",");
    //            sb_value.Append(JobReqUserInfo + ",");
    //            sb_value.Append(JobReqDetails + ",");
    //            sb_value.Append(JobValidDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JobQRCodeName) ? "''" : "N'" + Regex.Replace(JobQRCodeName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JobQRCodeLongURL) ? "''" : "N'" + Regex.Replace(JobQRCodeLongURL, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(JobQRCodeShortURL) ? "''" : "N'" + Regex.Replace(JobQRCodeShortURL, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(QRCJobStatus) ? "''" : "N'" + Regex.Replace(QRCJobStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into QRCodeJob(QRCodeJobType,JobLinkTable,JobTaskName,JobDescription,JobReqUserInfo,JobReqDetails,JobValidDate,JobQRCodeName,JobQRCodeLongURL,JobQRCodeShortURL,QRCJobStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.create() : " + e.ToString());
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
    //            sb_value.Append((String.IsNullOrEmpty(this.QRCodeJobType) ? "''" : "N'" + Regex.Replace(this.QRCodeJobType, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JobLinkTable) ? "''" : "N'" + Regex.Replace(this.JobLinkTable, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JobTaskName) ? "''" : "N'" + Regex.Replace(this.JobTaskName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JobDescription) ? "null" : "N'" + Regex.Replace(this.JobDescription, "'", "''") + "'") + ",");
    //            sb_value.Append(this.JobReqUserInfo + ",");
    //            sb_value.Append(this.JobReqDetails + ",");
    //            sb_value.Append(this.JobValidDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JobQRCodeName) ? "''" : "N'" + Regex.Replace(this.JobQRCodeName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JobQRCodeLongURL) ? "''" : "N'" + Regex.Replace(this.JobQRCodeLongURL, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.JobQRCodeShortURL) ? "''" : "N'" + Regex.Replace(this.JobQRCodeShortURL, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(this.QRCJobStatus) ? "''" : "N'" + Regex.Replace(this.QRCJobStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into QRCodeJob(QRCodeJobType,JobLinkTable,JobTaskName,JobDescription,JobReqUserInfo,JobReqDetails,JobValidDate,JobQRCodeName,JobQRCodeLongURL,JobQRCodeShortURL,QRCJobStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int QRCJobTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from QRCodeJob where QRCJobTID = " + QRCJobTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String QRCodeJobType, String JobLinkTable, String JobTaskName, String JobDescription, int JobReqUserInfo, int JobReqDetails, long JobValidDate, String JobQRCodeName, String JobQRCodeLongURL, String JobQRCodeShortURL, String QRCJobStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("QRCodeJobType=" + (String.IsNullOrEmpty(QRCodeJobType) ? "''" : "N'" + Regex.Replace(QRCodeJobType, "'", "''") + "'") + ",");
    //            sb_value.Append("JobLinkTable=" + (String.IsNullOrEmpty(JobLinkTable) ? "''" : "N'" + Regex.Replace(JobLinkTable, "'", "''") + "'") + ",");
    //            sb_value.Append("JobTaskName=" + (String.IsNullOrEmpty(JobTaskName) ? "''" : "N'" + Regex.Replace(JobTaskName, "'", "''") + "'") + ",");
    //            sb_value.Append("JobDescription=" + (String.IsNullOrEmpty(JobDescription) ? "null" : "N'" + Regex.Replace(JobDescription, "'", "''") + "'") + ",");
    //            sb_value.Append("JobReqUserInfo =" + JobReqUserInfo + ",");
    //            sb_value.Append("JobReqDetails =" + JobReqDetails + ",");
    //            sb_value.Append("JobValidDate =" + JobValidDate + ",");
    //            sb_value.Append("JobQRCodeName=" + (String.IsNullOrEmpty(JobQRCodeName) ? "''" : "N'" + Regex.Replace(JobQRCodeName, "'", "''") + "'") + ",");
    //            sb_value.Append("JobQRCodeLongURL=" + (String.IsNullOrEmpty(JobQRCodeLongURL) ? "''" : "N'" + Regex.Replace(JobQRCodeLongURL, "'", "''") + "'") + ",");
    //            sb_value.Append("JobQRCodeShortURL=" + (String.IsNullOrEmpty(JobQRCodeShortURL) ? "''" : "N'" + Regex.Replace(JobQRCodeShortURL, "'", "''") + "'") + ",");
    //            sb_value.Append("QRCJobStatus=" + (String.IsNullOrEmpty(QRCJobStatus) ? "''" : "N'" + Regex.Replace(QRCJobStatus, "'", "''") + "'"));

    //            String sqlCmd = "update QRCodeJob set  " + sb_value.ToString() + "  where QRCJobTID = " + this.QRCJobTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.create() : " + e.ToString());
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
    //            sb_value.Append("QRCodeJobType=" + (String.IsNullOrEmpty(this.QRCodeJobType) ? "''" : "N'" + Regex.Replace(this.QRCodeJobType, "'", "''") + "'") + ",");
    //            sb_value.Append("JobLinkTable=" + (String.IsNullOrEmpty(this.JobLinkTable) ? "''" : "N'" + Regex.Replace(this.JobLinkTable, "'", "''") + "'") + ",");
    //            sb_value.Append("JobTaskName=" + (String.IsNullOrEmpty(this.JobTaskName) ? "''" : "N'" + Regex.Replace(this.JobTaskName, "'", "''") + "'") + ",");
    //            sb_value.Append("JobDescription=" + (String.IsNullOrEmpty(this.JobDescription) ? "null" : "N'" + Regex.Replace(this.JobDescription, "'", "''") + "'") + ",");
    //            sb_value.Append("JobReqUserInfo =" + this.JobReqUserInfo + ",");
    //            sb_value.Append("JobReqDetails =" + this.JobReqDetails + ",");
    //            sb_value.Append("JobValidDate =" + this.JobValidDate + ",");
    //            sb_value.Append("JobQRCodeName=" + (String.IsNullOrEmpty(this.JobQRCodeName) ? "''" : "N'" + Regex.Replace(this.JobQRCodeName, "'", "''") + "'") + ",");
    //            sb_value.Append("JobQRCodeLongURL=" + (String.IsNullOrEmpty(this.JobQRCodeLongURL) ? "''" : "N'" + Regex.Replace(this.JobQRCodeLongURL, "'", "''") + "'") + ",");
    //            sb_value.Append("JobQRCodeShortURL=" + (String.IsNullOrEmpty(this.JobQRCodeShortURL) ? "''" : "N'" + Regex.Replace(this.JobQRCodeShortURL, "'", "''") + "'") + ",");
    //            sb_value.Append("QRCJobStatus=" + (String.IsNullOrEmpty(this.QRCJobStatus) ? "''" : "N'" + Regex.Replace(this.QRCJobStatus, "'", "''") + "'"));

    //            String sqlCmd = "update QRCodeJob set  " + sb_value.ToString() + "  where QRCJobTID = " + this.QRCJobTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "QRCodeJob");
    //            if (ds.Tables["QRCodeJob"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["QRCodeJob"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.QRCodeJob.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
    //public class QRCodeJobMetadata
    //{
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<QRCJobShareInfo> QRCJobShareInfo { get; set; }
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<QRCodeJobReport> QRCodeJobReport { get; set; }
    //}
}


