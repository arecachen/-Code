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
    //public partial class SystemImage
    //{
     
    //    public Collection<SystemImage> findAll()
    //    {
    //        Collection<SystemImage> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from SystemImage order by systemImageTID asc", "SystemImage");
    //            if (ds.Tables["SystemImage"].Rows.Count > 0)
    //            {
    //                c = new Collection<SystemImage>();
    //                foreach (DataRow dr in ds.Tables["SystemImage"].Rows)
    //                {
    //                    SystemImage am = new SystemImage();
    //                    am.systemImageTID = Convert.ToInt32(dr["systemImageTID"]);
    //                    am.imageCode = Convert.ToString(dr["imageCode"]);
    //                    am.imageName = Convert.ToString(dr["imageName"]);
    //                    am.imageFile = Convert.ToString(dr["imageFile"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<SystemImage> findByKeyword(String sqlCmd)
    //    {
    //        Collection<SystemImage> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "SystemImage");
    //            if (ds.Tables["SystemImage"].Rows.Count > 0)
    //            {
    //                c = new Collection<SystemImage>();
    //                foreach (DataRow dr in ds.Tables["SystemImage"].Rows)
    //                {
    //                    SystemImage am = new SystemImage();
    //                    am.systemImageTID = Convert.ToInt32(dr["systemImageTID"]);
    //                    am.imageCode = Convert.ToString(dr["imageCode"]);
    //                    am.imageName = Convert.ToString(dr["imageName"]);
    //                    am.imageFile = Convert.ToString(dr["imageFile"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public SystemImage findByPrimaryKey(int systemImageTID)
    //    {
    //        SystemImage am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM SystemImage a WHERE a.systemImageTID = " + systemImageTID;
    //            DataSet ds = my.select(sqlCmd, "SystemImage");
    //            if (ds.Tables["SystemImage"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["SystemImage"].Rows[0];
    //                am = new SystemImage();
    //                am.systemImageTID = Convert.ToInt32(dr["systemImageTID"]);
    //                am.imageCode = Convert.ToString(dr["imageCode"]);
    //                am.imageName = Convert.ToString(dr["imageName"]);
    //                am.imageFile = Convert.ToString(dr["imageFile"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String imageCode, String imageName, String imageFile)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into SystemImage(imageCode,imageName,imageFile) values ('" + imageCode + "','" + imageName + "','" + imageFile + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int systemImageTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from SystemImage where systemImageTID = " + systemImageTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String imageCode, String imageName, String imageFile)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update SystemImage set imageCode ='" + imageCode + "',imageName ='" + imageName + "',imageFile ='" + imageFile + "' where systemImageTID = " + this.systemImageTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update SystemImage set imageCode ='" + this.imageCode + "',imageName ='" + this.imageName + "',imageFile ='" + this.imageFile + "' where systemImageTID = " + this.systemImageTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "SystemImage");
    //            if (ds.Tables["SystemImage"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["SystemImage"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.SystemImage.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


