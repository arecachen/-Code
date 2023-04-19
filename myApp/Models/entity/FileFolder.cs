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
   
    //public partial class FileFolder
    //{

    //    public Collection<FileFolder> findAll()
    //    {
    //        Collection<FileFolder> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from FileFolder order by FileFolderTID asc", "FileFolder");
    //            if (ds.Tables["FileFolder"].Rows.Count > 0)
    //            {
    //                c = new Collection<FileFolder>();
    //                foreach (DataRow dr in ds.Tables["FileFolder"].Rows)
    //                {
    //                    FileFolder am = new FileFolder();
    //                    am.FolderTitle = Convert.ToString(dr["FolderTitle"]);
    //                    am.FolderInstroduction = Convert.ToString(dr["FolderInstroduction"]);
    //                    am.FolderCreateDate = Convert.ToString(dr["FolderCreateDate"]);
    //                    am.FolderEditDate = Convert.ToString(dr["FolderEditDate"]);
    //                    am.FileGroupID = Convert.ToInt32(dr["FileGroupID"]);
    //                    am.FileFolderTID = Convert.ToInt32(dr["FileFolderTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<FileFolder> findByKeyword(String sqlCmd)
    //    {
    //        Collection<FileFolder> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FileFolder");
    //            if (ds.Tables["FileFolder"].Rows.Count > 0)
    //            {
    //                c = new Collection<FileFolder>();
    //                foreach (DataRow dr in ds.Tables["FileFolder"].Rows)
    //                {
    //                    FileFolder am = new FileFolder();
    //                    am.FolderTitle = Convert.ToString(dr["FolderTitle"]);
    //                    am.FolderInstroduction = Convert.ToString(dr["FolderInstroduction"]);
    //                    am.FolderCreateDate = Convert.ToString(dr["FolderCreateDate"]);
    //                    am.FolderEditDate = Convert.ToString(dr["FolderEditDate"]);
    //                    am.FileGroupID = Convert.ToInt32(dr["FileGroupID"]);
    //                    am.FileFolderTID = Convert.ToInt32(dr["FileFolderTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public FileFolder findByPrimaryKey(int FileFolderTID)
    //    {
    //        FileFolder am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM FileFolder a WHERE a.FileFolderTID = " + FileFolderTID;
    //            DataSet ds = my.select(sqlCmd, "FileFolder");
    //            if (ds.Tables["FileFolder"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["FileFolder"].Rows[0];
    //                am = new FileFolder();
    //                am.FolderTitle = Convert.ToString(dr["FolderTitle"]);
    //                am.FolderInstroduction = Convert.ToString(dr["FolderInstroduction"]);
    //                am.FolderCreateDate = Convert.ToString(dr["FolderCreateDate"]);
    //                am.FolderEditDate = Convert.ToString(dr["FolderEditDate"]);
    //                am.FileGroupID = Convert.ToInt32(dr["FileGroupID"]);
    //                am.FileFolderTID = Convert.ToInt32(dr["FileFolderTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String FolderTitle, String FolderInstroduction, String FolderCreateDate, String FolderEditDate, int FileGroupID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into FileFolder(FolderTitle,FolderInstroduction,FolderCreateDate,FolderEditDate,FileGroupID) values ('" + FolderTitle + "','" + FolderInstroduction + "','" + FolderCreateDate + "','" + FolderEditDate + "'," + FileGroupID + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int FileFolderTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from FileFolder where FileFolderTID = " + FileFolderTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String FolderTitle, String FolderInstroduction, String FolderCreateDate, String FolderEditDate, int FileGroupID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FileFolder set FolderTitle ='" + FolderTitle + "',FolderInstroduction ='" + FolderInstroduction + "',FolderCreateDate ='" + FolderCreateDate + "',FolderEditDate ='" + FolderEditDate + "',FileGroupID =" + FileGroupID + " where FileFolderTID = " + this.FileFolderTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FileFolder set FolderTitle ='" + this.FolderTitle + "',FolderInstroduction ='" + this.FolderInstroduction + "',FolderCreateDate ='" + this.FolderCreateDate + "',FolderEditDate ='" + this.FolderEditDate + "',FileGroupID =" + this.FileGroupID + " where FileFolderTID = " + this.FileFolderTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FileFolder");
    //            if (ds.Tables["FileFolder"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["FileFolder"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("HowgreaterWebsite.entity.FileFolder.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}

   
}


