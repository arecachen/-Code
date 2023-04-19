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
   
    //public partial class CustomerType
    //{
      
    //    public Collection<CustomerType> findAll()
    //    {
    //        Collection<CustomerType> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CustomerType order by customerTypeTID asc", "CustomerType");
    //            if (ds.Tables["CustomerType"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerType>();
    //                foreach (DataRow dr in ds.Tables["CustomerType"].Rows)
    //                {
    //                    CustomerType am = new CustomerType();
    //                    am.customerTypeTID = Convert.ToInt32(dr["customerTypeTID"]);
    //                    am.custTypeName = Convert.ToString(dr["custTypeName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CustomerType> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CustomerType> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerType");
    //            if (ds.Tables["CustomerType"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerType>();
    //                foreach (DataRow dr in ds.Tables["CustomerType"].Rows)
    //                {
    //                    CustomerType am = new CustomerType();
    //                    am.customerTypeTID = Convert.ToInt32(dr["customerTypeTID"]);
    //                    am.custTypeName = Convert.ToString(dr["custTypeName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CustomerType findByPrimaryKey(int customerTypeTID)
    //    {
    //        CustomerType am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CustomerType a WHERE a.customerTypeTID = " + customerTypeTID;
    //            DataSet ds = my.select(sqlCmd, "CustomerType");
    //            if (ds.Tables["CustomerType"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CustomerType"].Rows[0];
    //                am = new CustomerType();
    //                am.customerTypeTID = Convert.ToInt32(dr["customerTypeTID"]);
    //                am.custTypeName = Convert.ToString(dr["custTypeName"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String custTypeName, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerType(custTypeName,memo,status) values ('" + custTypeName + "','" + memo + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int customerTypeTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CustomerType where customerTypeTID = " + customerTypeTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String custTypeName, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerType set custTypeName ='" + custTypeName + "',memo ='" + memo + "',status ='" + status + "' where customerTypeTID = " + this.customerTypeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerType set custTypeName ='" + this.custTypeName + "',memo ='" + this.memo + "',status ='" + this.status + "' where customerTypeTID = " + this.customerTypeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerType");
    //            if (ds.Tables["CustomerType"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CustomerType"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerType.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
    
    
}


