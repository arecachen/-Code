using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
namespace hsintongERP2022.Models
{
    //public partial class EmployeeMsessage
    //{
      
    //    public Collection<EmployeeMsessage> findAll()
    //    {
    //        Collection<EmployeeMsessage> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from EmployeeMsessage order by EmpMsgTID asc", "EmployeeMsessage");
    //            if (ds.Tables["EmployeeMsessage"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeMsessage>();
    //                foreach (DataRow dr in ds.Tables["EmployeeMsessage"].Rows)
    //                {
    //                    EmployeeMsessage am = new EmployeeMsessage();
    //                    am.EmpMsgTID = Convert.ToInt32(dr["EmpMsgTID"]);
    //                    am.CreateDateTime = Convert.ToInt64(dr["CreateDateTime"]);
    //                    am.MessageDate = Convert.ToInt64(dr["MessageDate"]);
    //                    am.CreateBy = Convert.ToInt32(dr["CreateBy"]);
    //                    am.CreateTo = Convert.ToString(dr["CreateTo"]);
    //                    am.MsgPublic = Convert.ToInt32(dr["MsgPublic"]);
    //                    am.MsgTitle = Convert.ToString(dr["MsgTitle"]);
    //                    am.MsgPriority = Convert.ToString(dr["MsgPriority"]);
    //                    am.MsgBody = Convert.ToString(dr["MsgBody"]);
    //                    am.SourceMsgID = Convert.ToInt32(dr["SourceMsgID"]);
    //                    am.MsgStatus = Convert.ToString(dr["MsgStatus"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeMsessage> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeMsessage> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeMsessage");
    //            if (ds.Tables["EmployeeMsessage"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeMsessage>();
    //                foreach (DataRow dr in ds.Tables["EmployeeMsessage"].Rows)
    //                {
    //                    EmployeeMsessage am = new EmployeeMsessage();
    //                    am.EmpMsgTID = Convert.ToInt32(dr["EmpMsgTID"]);
    //                    am.CreateDateTime = Convert.ToInt64(dr["CreateDateTime"]);
    //                    am.MessageDate = Convert.ToInt64(dr["MessageDate"]);
    //                    am.CreateBy = Convert.ToInt32(dr["CreateBy"]);
    //                    am.CreateTo = Convert.ToString(dr["CreateTo"]);
    //                    am.MsgPublic = Convert.ToInt32(dr["MsgPublic"]);
    //                    am.MsgTitle = Convert.ToString(dr["MsgTitle"]);
    //                    am.MsgPriority = Convert.ToString(dr["MsgPriority"]);
    //                    am.MsgBody = Convert.ToString(dr["MsgBody"]);
    //                    am.SourceMsgID = Convert.ToInt32(dr["SourceMsgID"]);
    //                    am.MsgStatus = Convert.ToString(dr["MsgStatus"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeMsessage findByPrimaryKey(int EmpMsgTID)
    //    {
    //        EmployeeMsessage am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeeMsessage a WHERE a.EmpMsgTID = " + EmpMsgTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeMsessage");
    //            if (ds.Tables["EmployeeMsessage"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeMsessage"].Rows[0];
    //                am = new EmployeeMsessage();
    //                am.EmpMsgTID = Convert.ToInt32(dr["EmpMsgTID"]);
    //                am.CreateDateTime = Convert.ToInt64(dr["CreateDateTime"]);
    //                am.MessageDate = Convert.ToInt64(dr["MessageDate"]);
    //                am.CreateBy = Convert.ToInt32(dr["CreateBy"]);
    //                am.CreateTo = Convert.ToString(dr["CreateTo"]);
    //                am.MsgPublic = Convert.ToInt32(dr["MsgPublic"]);
    //                am.MsgTitle = Convert.ToString(dr["MsgTitle"]);
    //                am.MsgPriority = Convert.ToString(dr["MsgPriority"]);
    //                am.MsgBody = Convert.ToString(dr["MsgBody"]);
    //                am.SourceMsgID = Convert.ToInt32(dr["SourceMsgID"]);
    //                am.MsgStatus = Convert.ToString(dr["MsgStatus"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(long CreateDateTime, long MessageDate, int CreateBy, String CreateTo, int MsgPublic, String MsgTitle, String MsgPriority, String MsgBody, int SourceMsgID, String MsgStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into EmployeeMsessage(CreateDateTime,MessageDate,CreateBy,CreateTo,MsgPublic,MsgTitle,MsgPriority,MsgBody,SourceMsgID,MsgStatus) values (" + CreateDateTime + "," + MessageDate + "," + CreateBy + ",'" + CreateTo + "'," + MsgPublic + ",'" + MsgTitle + "','" + MsgPriority + "','" + MsgBody + "'," + SourceMsgID + ",'" + MsgStatus + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int EmpMsgTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from EmployeeMsessage where EmpMsgTID = " + EmpMsgTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.delete() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int DeleteByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(long CreateDateTime, long MessageDate, int CreateBy, String CreateTo, int MsgPublic, String MsgTitle, String MsgPriority, String MsgBody, int SourceMsgID, String MsgStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update EmployeeMsessage set CreateDateTime =" + CreateDateTime + ",MessageDate =" + MessageDate + ",CreateBy =" + CreateBy + ",CreateTo ='" + CreateTo + "',MsgPublic =" + MsgPublic + ",MsgTitle ='" + MsgTitle + "',MsgPriority ='" + MsgPriority + "',MsgBody ='" + MsgBody + "',SourceMsgID =" + SourceMsgID + ",MsgStatus ='" + MsgStatus + "' where EmpMsgTID = " + this.EmpMsgTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update EmployeeMsessage set CreateDateTime =" + this.CreateDateTime + ",MessageDate =" + this.MessageDate + ",CreateBy =" + this.CreateBy + ",CreateTo ='" + this.CreateTo + "',MsgPublic =" + this.MsgPublic + ",MsgTitle ='" + this.MsgTitle + "',MsgPriority ='" + this.MsgPriority + "',MsgBody ='" + this.MsgBody + "',SourceMsgID =" + this.SourceMsgID + ",MsgStatus ='" + this.MsgStatus + "' where EmpMsgTID = " + this.EmpMsgTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeMsessage");
    //            if (ds.Tables["EmployeeMsessage"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeMsessage"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMsessage.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


