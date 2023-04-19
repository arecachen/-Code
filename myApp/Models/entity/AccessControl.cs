using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace hsintongERP2022.Models
{

    //public partial class AccessControl
    //{
    //    public Collection<AccessControl> findAll()
    //    {
    //        Collection<AccessControl> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from AccessControl order by accessControlTID asc", "AccessControl");
    //            if (ds.Tables["AccessControl"].Rows.Count > 0)
    //            {
    //                c = new Collection<AccessControl>();
    //                foreach (DataRow dr in ds.Tables["AccessControl"].Rows)
    //                {
    //                    AccessControl am = new AccessControl();
    //                    am.ctPageName = Convert.ToString(dr["ctPageName"]);
    //                    am.ctlPageID = Convert.ToString(dr["ctlPageID"]);
    //                    am.ctlMemo = Convert.ToString(dr["ctlMemo"]);
    //                    am.accessControlTID = Convert.ToInt32(dr["accessControlTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<AccessControl> findByKeyword(String sqlCmd)
    //    {
    //        Collection<AccessControl> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "AccessControl");
    //            if (ds.Tables["AccessControl"].Rows.Count > 0)
    //            {
    //                c = new Collection<AccessControl>();
    //                foreach (DataRow dr in ds.Tables["AccessControl"].Rows)
    //                {
    //                    AccessControl am = new AccessControl();
    //                    am.ctPageName = Convert.ToString(dr["ctPageName"]);
    //                    am.ctlPageID = Convert.ToString(dr["ctlPageID"]);
    //                    am.ctlMemo = Convert.ToString(dr["ctlMemo"]);
    //                    am.accessControlTID = Convert.ToInt32(dr["accessControlTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public AccessControl findByPrimaryKey(int accessControlTID)
    //    {
    //        AccessControl am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM AccessControl a WHERE a.accessControlTID = " + accessControlTID;
    //            DataSet ds = my.select(sqlCmd, "AccessControl");
    //            if (ds.Tables["AccessControl"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["AccessControl"].Rows[0];
    //                am = new AccessControl();
    //                am.ctPageName = Convert.ToString(dr["ctPageName"]);
    //                am.ctlPageID = Convert.ToString(dr["ctlPageID"]);
    //                am.ctlMemo = Convert.ToString(dr["ctlMemo"]);
    //                am.accessControlTID = Convert.ToInt32(dr["accessControlTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String ctPageName, String ctlPageID, String ctlMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into AccessControl(ctPageName,ctlPageID,ctlMemo) values ('" + ctPageName + "','" + ctlPageID + "','" + ctlMemo + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int accessControlTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from AccessControl where accessControlTID = " + accessControlTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String ctPageName, String ctlPageID, String ctlMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update AccessControl set ctPageName ='" + ctPageName + "',ctlPageID ='" + ctlPageID + "',ctlMemo ='" + ctlMemo + "' where accessControlTID = " + this.accessControlTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update AccessControl set ctPageName ='" + this.ctPageName + "',ctlPageID ='" + this.ctlPageID + "',ctlMemo ='" + this.ctlMemo + "' where accessControlTID = " + this.accessControlTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "AccessControl");
    //            if (ds.Tables["AccessControl"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["AccessControl"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.AccessControl.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}

}


