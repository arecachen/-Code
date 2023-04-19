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
   
    //public partial class CustomerUniCode
    //{
        
    //    public Collection<CustomerUniCode> findAll()
    //    {
    //        Collection<CustomerUniCode> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CustomerUniCode order by customerUniCodeTID asc", "CustomerUniCode");
    //            if (ds.Tables["CustomerUniCode"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerUniCode>();
    //                foreach (DataRow dr in ds.Tables["CustomerUniCode"].Rows)
    //                {
    //                    CustomerUniCode am = new CustomerUniCode();
    //                    am.customerUniCodeTID = Convert.ToInt32(dr["customerUniCodeTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.uniCode = Convert.ToString(dr["uniCode"]);
    //                    am.uniName = Convert.ToString(dr["uniName"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CustomerUniCode> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CustomerUniCode> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerUniCode");
    //            if (ds.Tables["CustomerUniCode"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerUniCode>();
    //                foreach (DataRow dr in ds.Tables["CustomerUniCode"].Rows)
    //                {
    //                    CustomerUniCode am = new CustomerUniCode();
    //                    am.customerUniCodeTID = Convert.ToInt32(dr["customerUniCodeTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.uniCode = Convert.ToString(dr["uniCode"]);
    //                    am.uniName = Convert.ToString(dr["uniName"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CustomerUniCode findByPrimaryKey(int customerUniCodeTID)
    //    {
    //        CustomerUniCode am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CustomerUniCode a WHERE a.customerUniCodeTID = " + customerUniCodeTID;
    //            DataSet ds = my.select(sqlCmd, "CustomerUniCode");
    //            if (ds.Tables["CustomerUniCode"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CustomerUniCode"].Rows[0];
    //                am = new CustomerUniCode();
    //                am.customerUniCodeTID = Convert.ToInt32(dr["customerUniCodeTID"]);
    //                am.custID = Convert.ToInt32(dr["custID"]);
    //                am.uniCode = Convert.ToString(dr["uniCode"]);
    //                am.uniName = Convert.ToString(dr["uniName"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int custID, String uniCode, String uniName)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerUniCode(custID,uniCode,uniName) values (" + custID + ",'" + uniCode + "','" + uniName + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int customerUniCodeTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CustomerUniCode where customerUniCodeTID = " + customerUniCodeTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int custID, String uniCode, String uniName)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerUniCode set custID =" + custID + ",uniCode ='" + uniCode + "',uniName ='" + uniName + "' where customerUniCodeTID = " + this.customerUniCodeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerUniCode set custID =" + this.custID + ",uniCode ='" + this.uniCode + "',uniName ='" + this.uniName + "' where customerUniCodeTID = " + this.customerUniCodeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerUniCode");
    //            if (ds.Tables["CustomerUniCode"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CustomerUniCode"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerUniCode.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
  
}


