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
   
    //public partial class FileGroup
    //{

    //    public Collection<FileGroup> findAll()
    //    {
    //        Collection<FileGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from FileGroup order by FileGroupTID asc", "FileGroup");
    //            if (ds.Tables["FileGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<FileGroup>();
    //                foreach (DataRow dr in ds.Tables["FileGroup"].Rows)
    //                {
    //                    FileGroup am = new FileGroup();
    //                    am.GroupName = Convert.ToString(dr["GroupName"]);
    //                    am.GroupOrder = dr["GroupOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["GroupOrder"]);
    //                    am.FileGroupTID = Convert.ToInt32(dr["FileGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<FileGroup> findByKeyword(String sqlCmd)
    //    {
    //        Collection<FileGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FileGroup");
    //            if (ds.Tables["FileGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<FileGroup>();
    //                foreach (DataRow dr in ds.Tables["FileGroup"].Rows)
    //                {
    //                    FileGroup am = new FileGroup();
    //                    am.GroupName = Convert.ToString(dr["GroupName"]);
    //                    am.GroupOrder = dr["GroupOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["GroupOrder"]);
    //                    am.FileGroupTID = Convert.ToInt32(dr["FileGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public FileGroup findByPrimaryKey(int FileGroupTID)
    //    {
    //        FileGroup am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM FileGroup a WHERE a.FileGroupTID = " + FileGroupTID;
    //            DataSet ds = my.select(sqlCmd, "FileGroup");
    //            if (ds.Tables["FileGroup"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["FileGroup"].Rows[0];
    //                am = new FileGroup();
    //                am.GroupName = Convert.ToString(dr["GroupName"]);
    //                am.GroupOrder = dr["GroupOrder"] == DBNull.Value ? -999 : Convert.ToInt32(dr["GroupOrder"]);
    //                am.FileGroupTID = Convert.ToInt32(dr["FileGroupTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String GroupName, int GroupOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into FileGroup(GroupName,GroupOrder) values ('" + GroupName + "'," + GroupOrder + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int FileGroupTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from FileGroup where FileGroupTID = " + FileGroupTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String GroupName, int GroupOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FileGroup set GroupName ='" + GroupName + "',GroupOrder =" + GroupOrder + " where FileGroupTID = " + this.FileGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FileGroup set GroupName ='" + this.GroupName + "',GroupOrder =" + this.GroupOrder + " where FileGroupTID = " + this.FileGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FileGroup");
    //            if (ds.Tables["FileGroup"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["FileGroup"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileGroup.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
  
}


