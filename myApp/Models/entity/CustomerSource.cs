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

    //public partial class CustomerSource
    //{
     
    //    public Collection<CustomerSource> findAll()
    //    {
    //        Collection<CustomerSource> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CustomerSource order by customerSourceTID asc", "CustomerSource");
    //            if (ds.Tables["CustomerSource"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerSource>();
    //                foreach (DataRow dr in ds.Tables["CustomerSource"].Rows)
    //                {
    //                    CustomerSource am = new CustomerSource();
    //                    am.customerSourceTID = Convert.ToInt32(dr["customerSourceTID"]);
    //                    am.custSourceName = Convert.ToString(dr["custSourceName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CustomerSource> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CustomerSource> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerSource");
    //            if (ds.Tables["CustomerSource"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerSource>();
    //                foreach (DataRow dr in ds.Tables["CustomerSource"].Rows)
    //                {
    //                    CustomerSource am = new CustomerSource();
    //                    am.customerSourceTID = Convert.ToInt32(dr["customerSourceTID"]);
    //                    am.custSourceName = Convert.ToString(dr["custSourceName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CustomerSource findByPrimaryKey(int customerSourceTID)
    //    {
    //        CustomerSource am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CustomerSource a WHERE a.customerSourceTID = " + customerSourceTID;
    //            DataSet ds = my.select(sqlCmd, "CustomerSource");
    //            if (ds.Tables["CustomerSource"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CustomerSource"].Rows[0];
    //                am = new CustomerSource();
    //                am.customerSourceTID = Convert.ToInt32(dr["customerSourceTID"]);
    //                am.custSourceName = Convert.ToString(dr["custSourceName"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String custSourceName, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerSource(custSourceName,memo,status) values ('" + custSourceName + "','" + memo + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int customerSourceTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CustomerSource where customerSourceTID = " + customerSourceTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String custSourceName, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerSource set custSourceName ='" + custSourceName + "',memo ='" + memo + "',status ='" + status + "' where customerSourceTID = " + this.customerSourceTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerSource set custSourceName ='" + this.custSourceName + "',memo ='" + this.memo + "',status ='" + this.status + "' where customerSourceTID = " + this.customerSourceTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerSource");
    //            if (ds.Tables["CustomerSource"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CustomerSource"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerSource.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}

  
}


