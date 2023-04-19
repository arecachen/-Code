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
    //public partial class SystemMessage
    //{
       
    //    public Collection<SystemMessage> findAll()
    //    {
    //        Collection<SystemMessage> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from SystemMessage order by systemMsgTID asc", "SystemMessage");
    //            if (ds.Tables["SystemMessage"].Rows.Count > 0)
    //            {
    //                c = new Collection<SystemMessage>();
    //                foreach (DataRow dr in ds.Tables["SystemMessage"].Rows)
    //                {
    //                    SystemMessage am = new SystemMessage();
    //                    am.systemMsgTID = Convert.ToInt32(dr["systemMsgTID"]);
    //                    am.startDate = Convert.ToInt64(dr["startDate"]);
    //                    am.endDate = Convert.ToInt64(dr["endDate"]);
    //                    am.msgTitle = Convert.ToString(dr["msgTitle"]);
    //                    am.message = Convert.ToString(dr["message"]);
    //                    am.createBy = Convert.ToInt32(dr["createBy"]);
    //                    am.modifyBy = Convert.ToInt32(dr["modifyBy"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<SystemMessage> findByKeyword(String sqlCmd)
    //    {
    //        Collection<SystemMessage> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "SystemMessage");
    //            if (ds.Tables["SystemMessage"].Rows.Count > 0)
    //            {
    //                c = new Collection<SystemMessage>();
    //                foreach (DataRow dr in ds.Tables["SystemMessage"].Rows)
    //                {
    //                    SystemMessage am = new SystemMessage();
    //                    am.systemMsgTID = Convert.ToInt32(dr["systemMsgTID"]);
    //                    am.startDate = Convert.ToInt64(dr["startDate"]);
    //                    am.endDate = Convert.ToInt64(dr["endDate"]);
    //                    am.msgTitle = Convert.ToString(dr["msgTitle"]);
    //                    am.message = Convert.ToString(dr["message"]);
    //                    am.createBy = Convert.ToInt32(dr["createBy"]);
    //                    am.modifyBy = Convert.ToInt32(dr["modifyBy"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public SystemMessage findByPrimaryKey(int systemMsgTID)
    //    {
    //        SystemMessage am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM SystemMessage a WHERE a.systemMsgTID = " + systemMsgTID;
    //            DataSet ds = my.select(sqlCmd, "SystemMessage");
    //            if (ds.Tables["SystemMessage"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["SystemMessage"].Rows[0];
    //                am = new SystemMessage();
    //                am.systemMsgTID = Convert.ToInt32(dr["systemMsgTID"]);
    //                am.startDate = Convert.ToInt64(dr["startDate"]);
    //                am.endDate = Convert.ToInt64(dr["endDate"]);
    //                am.msgTitle = Convert.ToString(dr["msgTitle"]);
    //                am.message = Convert.ToString(dr["message"]);
    //                am.createBy = Convert.ToInt32(dr["createBy"]);
    //                am.modifyBy = Convert.ToInt32(dr["modifyBy"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(long startDate, long endDate, String msgTitle, String message, int createBy, int modifyBy)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into SystemMessage(startDate,endDate,msgTitle,message,createBy,modifyBy) values (" + startDate + "," + endDate + ",'" + msgTitle + "','" + message + "'," + createBy + "," + modifyBy + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int systemMsgTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from SystemMessage where systemMsgTID = " + systemMsgTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(long startDate, long endDate, String msgTitle, String message, int createBy, int modifyBy)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update SystemMessage set startDate =" + startDate + ",endDate =" + endDate + ",msgTitle ='" + msgTitle + "',message ='" + message + "',createBy =" + createBy + ",modifyBy =" + modifyBy + " where systemMsgTID = " + this.systemMsgTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update SystemMessage set startDate =" + this.startDate + ",endDate =" + this.endDate + ",msgTitle ='" + this.msgTitle + "',message ='" + this.message + "',createBy =" + this.createBy + ",modifyBy =" + this.modifyBy + " where systemMsgTID = " + this.systemMsgTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "SystemMessage");
    //            if (ds.Tables["SystemMessage"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["SystemMessage"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemMessage.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


