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
    //public partial class FileInformation
    //{

    //    public Collection<FileInformation> findAll()
    //    {
    //        Collection<FileInformation> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from FileInformation order by FileInformationTID asc", "FileInformation");
    //            if (ds.Tables["FileInformation"].Rows.Count > 0)
    //            {
    //                c = new Collection<FileInformation>();
    //                foreach (DataRow dr in ds.Tables["FileInformation"].Rows)
    //                {
    //                    FileInformation am = new FileInformation();
    //                    am.InfoRelName = Convert.ToString(dr["InfoRelName"]);
    //                    am.InfoSysName = Convert.ToString(dr["InfoSysName"]);
    //                    am.FileFolderID = Convert.ToInt32(dr["FileFolderID"]);
    //                    am.FileInformationTID = Convert.ToInt32(dr["FileInformationTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<FileInformation> findByKeyword(String sqlCmd)
    //    {
    //        Collection<FileInformation> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FileInformation");
    //            if (ds.Tables["FileInformation"].Rows.Count > 0)
    //            {
    //                c = new Collection<FileInformation>();
    //                foreach (DataRow dr in ds.Tables["FileInformation"].Rows)
    //                {
    //                    FileInformation am = new FileInformation();
    //                    am.InfoRelName = Convert.ToString(dr["InfoRelName"]);
    //                    am.InfoSysName = Convert.ToString(dr["InfoSysName"]);
    //                    am.FileFolderID = Convert.ToInt32(dr["FileFolderID"]);
    //                    am.FileInformationTID = Convert.ToInt32(dr["FileInformationTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public FileInformation findByPrimaryKey(int FileInformationTID)
    //    {
    //        FileInformation am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM FileInformation a WHERE a.FileInformationTID = " + FileInformationTID;
    //            DataSet ds = my.select(sqlCmd, "FileInformation");
    //            if (ds.Tables["FileInformation"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["FileInformation"].Rows[0];
    //                am = new FileInformation();
    //                am.InfoRelName = Convert.ToString(dr["InfoRelName"]);
    //                am.InfoSysName = Convert.ToString(dr["InfoSysName"]);
    //                am.FileFolderID = Convert.ToInt32(dr["FileFolderID"]);
    //                am.FileInformationTID = Convert.ToInt32(dr["FileInformationTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String InfoRelName, String InfoSysName, int FileFolderID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into FileInformation(InfoRelName,InfoSysName,FileFolderID) values ('" + InfoRelName + "','" + InfoSysName + "'," + FileFolderID + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int FileInformationTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from FileInformation where FileInformationTID = " + FileInformationTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String InfoRelName, String InfoSysName, int FileFolderID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FileInformation set InfoRelName ='" + InfoRelName + "',InfoSysName ='" + InfoSysName + "',FileFolderID =" + FileFolderID + " where FileInformationTID = " + this.FileInformationTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FileInformation set InfoRelName ='" + this.InfoRelName + "',InfoSysName ='" + this.InfoSysName + "',FileFolderID =" + this.FileFolderID + " where FileInformationTID = " + this.FileInformationTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FileInformation");
    //            if (ds.Tables["FileInformation"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["FileInformation"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


