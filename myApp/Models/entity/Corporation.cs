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
 
    //public partial class Corporation
    //{
     
    //    public Collection<Corporation> findAll()
    //    {
    //        Collection<Corporation> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from Corporation order by corporationTID asc", "Corporation");
    //            if (ds.Tables["Corporation"].Rows.Count > 0)
    //            {
    //                c = new Collection<Corporation>();
    //                foreach (DataRow dr in ds.Tables["Corporation"].Rows)
    //                {
    //                    Corporation am = new Corporation();
    //                    am.corporationTID = Convert.ToInt32(dr["corporationTID"]);
    //                    am.corpName = Convert.ToString(dr["corpName"]);
    //                    am.corpType = Convert.ToString(dr["corpType"]);
    //                    am.corpPhone = Convert.ToString(dr["corpPhone"]);
    //                    am.corpAddress = Convert.ToString(dr["corpAddress"]);
    //                    am.corpContact = Convert.ToString(dr["corpContact"]);
    //                    am.corpMobile = Convert.ToString(dr["corpMobile"]);
    //                    am.corpStatus = Convert.ToString(dr["corpStatus"]);
    //                    am.corpOrder = Convert.ToInt32(dr["corpOrder"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<Corporation> findByKeyword(String sqlCmd)
    //    {
    //        Collection<Corporation> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "Corporation");
    //            if (ds.Tables["Corporation"].Rows.Count > 0)
    //            {
    //                c = new Collection<Corporation>();
    //                foreach (DataRow dr in ds.Tables["Corporation"].Rows)
    //                {
    //                    Corporation am = new Corporation();
    //                    am.corporationTID = Convert.ToInt32(dr["corporationTID"]);
    //                    am.corpName = Convert.ToString(dr["corpName"]);
    //                    am.corpType = Convert.ToString(dr["corpType"]);
    //                    am.corpPhone = Convert.ToString(dr["corpPhone"]);
    //                    am.corpAddress = Convert.ToString(dr["corpAddress"]);
    //                    am.corpContact = Convert.ToString(dr["corpContact"]);
    //                    am.corpMobile = Convert.ToString(dr["corpMobile"]);
    //                    am.corpStatus = Convert.ToString(dr["corpStatus"]);
    //                    am.corpOrder = Convert.ToInt32(dr["corpOrder"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Corporation findByPrimaryKey(int corporationTID)
    //    {
    //        Corporation am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM Corporation a WHERE a.corporationTID = " + corporationTID;
    //            DataSet ds = my.select(sqlCmd, "Corporation");
    //            if (ds.Tables["Corporation"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["Corporation"].Rows[0];
    //                am = new Corporation();
    //                am.corporationTID = Convert.ToInt32(dr["corporationTID"]);
    //                am.corpName = Convert.ToString(dr["corpName"]);
    //                am.corpType = Convert.ToString(dr["corpType"]);
    //                am.corpPhone = Convert.ToString(dr["corpPhone"]);
    //                am.corpAddress = Convert.ToString(dr["corpAddress"]);
    //                am.corpContact = Convert.ToString(dr["corpContact"]);
    //                am.corpMobile = Convert.ToString(dr["corpMobile"]);
    //                am.corpStatus = Convert.ToString(dr["corpStatus"]);
    //                am.corpOrder = Convert.ToInt32(dr["corpOrder"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String corpName, String corpType, String corpPhone, String corpAddress, String corpContact, String corpMobile, String corpStatus, int corpOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into Corporation(corpName,corpType,corpPhone,corpAddress,corpContact,corpMobile,corpStatus,corpOrder) values ('" + corpName + "','" + corpType + "','" + corpPhone + "','" + corpAddress + "','" + corpContact + "','" + corpMobile + "','" + corpStatus + "'," + corpOrder + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int corporationTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from Corporation where corporationTID = " + corporationTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String corpName, String corpType, String corpPhone, String corpAddress, String corpContact, String corpMobile, String corpStatus, int corpOrder)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update Corporation set corpName ='" + corpName + "',corpType ='" + corpType + "',corpPhone ='" + corpPhone + "',corpAddress ='" + corpAddress + "',corpContact ='" + corpContact + "',corpMobile ='" + corpMobile + "',corpStatus ='" + corpStatus + "',corpOrder =" + corpOrder + " where corporationTID = " + this.corporationTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update Corporation set corpName ='" + this.corpName + "',corpType ='" + this.corpType + "',corpPhone ='" + this.corpPhone + "',corpAddress ='" + this.corpAddress + "',corpContact ='" + this.corpContact + "',corpMobile ='" + this.corpMobile + "',corpStatus ='" + this.corpStatus + "',corpOrder =" + this.corpOrder + " where corporationTID = " + this.corporationTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "Corporation");
    //            if (ds.Tables["Corporation"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["Corporation"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Corporation.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}

   
}


