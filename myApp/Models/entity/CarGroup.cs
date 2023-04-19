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
    //public partial class CarGroup
    //{

    //    public Collection<CarGroup> findAll()
    //    {
    //        Collection<CarGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarGroup order by CarGroupTID asc", "CarGroup");
    //            if (ds.Tables["CarGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarGroup>();
    //                foreach (DataRow dr in ds.Tables["CarGroup"].Rows)
    //                {
    //                    CarGroup am = new CarGroup();
    //                    am.GroupName = Convert.ToString(dr["GroupName"]);
    //                    am.GroupOrder = Convert.ToInt32(dr["GroupOrder"]);
    //                    am.GroupStatus = Convert.ToString(dr["GroupStatus"]);
    //                    am.CarGroupTID = Convert.ToInt32(dr["CarGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarGroup> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarGroup> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarGroup");
    //            if (ds.Tables["CarGroup"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarGroup>();
    //                foreach (DataRow dr in ds.Tables["CarGroup"].Rows)
    //                {
    //                    CarGroup am = new CarGroup();
    //                    am.GroupName = Convert.ToString(dr["GroupName"]);
    //                    am.GroupOrder = Convert.ToInt32(dr["GroupOrder"]);
    //                    am.GroupStatus = Convert.ToString(dr["GroupStatus"]);
    //                    am.CarGroupTID = Convert.ToInt32(dr["CarGroupTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarGroup findByPrimaryKey(int CarGroupTID)
    //    {
    //        CarGroup am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarGroup a WHERE a.CarGroupTID = " + CarGroupTID;
    //            DataSet ds = my.select(sqlCmd, "CarGroup");
    //            if (ds.Tables["CarGroup"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarGroup"].Rows[0];
    //                am = new CarGroup();
    //                am.GroupName = Convert.ToString(dr["GroupName"]);
    //                am.GroupOrder = Convert.ToInt32(dr["GroupOrder"]);
    //                am.GroupStatus = Convert.ToString(dr["GroupStatus"]);
    //                am.CarGroupTID = Convert.ToInt32(dr["CarGroupTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String GroupName, int GroupOrder, String GroupStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarGroup(GroupName,GroupOrder,GroupStatus) values ('" + GroupName + "'," + GroupOrder + ",'" + GroupStatus + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int CarGroupTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarGroup where CarGroupTID = " + CarGroupTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String GroupName, int GroupOrder, String GroupStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarGroup set GroupName ='" + GroupName + "',GroupOrder =" + GroupOrder + ",GroupStatus ='" + GroupStatus + "' where CarGroupTID = " + this.CarGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarGroup set GroupName ='" + this.GroupName + "',GroupOrder =" + this.GroupOrder + ",GroupStatus ='" + this.GroupStatus + "' where CarGroupTID = " + this.CarGroupTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarGroup");
    //            if (ds.Tables["CarGroup"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarGroup"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarGroup.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


