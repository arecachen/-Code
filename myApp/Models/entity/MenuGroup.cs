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
    //[MetadataType(typeof(MenuGroupMetadata))]
    //public partial class MenuGroup
    //{
      
    //    public Collection<MenuGroup> findAll()
    //    {
    //        Collection<MenuGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from MenuGroup order by groupTID asc", "MenuGroup");
    //            if (ds.Tables["MenuGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<MenuGroup>();
    //                foreach (DataRow dr in ds.Tables["MenuGroup"].Rows)
    //                {
    //                    MenuGroup am = new MenuGroup();
    //                    am.groupTID = Convert.ToInt32(dr["groupTID"]);
    //                    am.subMenuIDs = Convert.ToString(dr["subMenuIDs"]);
    //                    am.groupName = Convert.ToString(dr["groupName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<MenuGroup> findByKeyword(String sqlCmd)
    //    {
    //        Collection<MenuGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "MenuGroup");
    //            if (ds.Tables["MenuGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<MenuGroup>();
    //                foreach (DataRow dr in ds.Tables["MenuGroup"].Rows)
    //                {
    //                    MenuGroup am = new MenuGroup();
    //                    am.groupTID = Convert.ToInt32(dr["groupTID"]);
    //                    am.subMenuIDs = Convert.ToString(dr["subMenuIDs"]);
    //                    am.groupName = Convert.ToString(dr["groupName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public MenuGroup findByPrimaryKey(int groupTID)
    //    {
    //        MenuGroup am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM MenuGroup a WHERE a.groupTID = " + groupTID;
    //            DataSet ds = my.select(sqlCmd, "MenuGroup");
    //            if (ds.Tables["MenuGroup"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["MenuGroup"].Rows[0];
    //                am = new MenuGroup();
    //                am.groupTID = Convert.ToInt32(dr["groupTID"]);
    //                am.subMenuIDs = Convert.ToString(dr["subMenuIDs"]);
    //                am.groupName = Convert.ToString(dr["groupName"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String subMenuIDs, String groupName, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into MenuGroup(subMenuIDs,groupName,memo,status) values ('" + subMenuIDs + "','" + groupName + "','" + memo + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int groupTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from MenuGroup where groupTID = " + groupTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String subMenuIDs, String groupName, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update MenuGroup set subMenuIDs ='" + subMenuIDs + "',groupName ='" + groupName + "',memo ='" + memo + "',status ='" + status + "' where groupTID = " + this.groupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update MenuGroup set subMenuIDs ='" + this.subMenuIDs + "',groupName ='" + this.groupName + "',memo ='" + this.memo + "',status ='" + this.status + "' where groupTID = " + this.groupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "MenuGroup");
    //            if (ds.Tables["MenuGroup"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["MenuGroup"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.MenuGroup.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
  
}


