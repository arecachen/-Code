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
    //public partial class CustomerAddress
    //{
   
    //    public Collection<CustomerAddress> findAll()
    //    {
    //        Collection<CustomerAddress> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CustomerAddress order by customerAddressTID asc", "CustomerAddress");
    //            if (ds.Tables["CustomerAddress"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerAddress>();
    //                foreach (DataRow dr in ds.Tables["CustomerAddress"].Rows)
    //                {
    //                    CustomerAddress am = new CustomerAddress();
    //                    am.customerAddressTID = Convert.ToInt32(dr["customerAddressTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.custCity = Convert.ToString(dr["custCity"]);
    //                    am.custSuburb = Convert.ToString(dr["custSuburb"]);
    //                    am.custPostCode = Convert.ToString(dr["custPostCode"]);
    //                    am.custStreet = Convert.ToString(dr["custStreet"]);
    //                    am.custAddType = Convert.ToString(dr["custAddType"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CustomerAddress> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CustomerAddress> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerAddress");
    //            if (ds.Tables["CustomerAddress"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerAddress>();
    //                foreach (DataRow dr in ds.Tables["CustomerAddress"].Rows)
    //                {
    //                    CustomerAddress am = new CustomerAddress();
    //                    am.customerAddressTID = Convert.ToInt32(dr["customerAddressTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.custCity = Convert.ToString(dr["custCity"]);
    //                    am.custSuburb = Convert.ToString(dr["custSuburb"]);
    //                    am.custPostCode = Convert.ToString(dr["custPostCode"]);
    //                    am.custStreet = Convert.ToString(dr["custStreet"]);
    //                    am.custAddType = Convert.ToString(dr["custAddType"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CustomerAddress findByPrimaryKey(int customerAddressTID)
    //    {
    //        CustomerAddress am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CustomerAddress a WHERE a.customerAddressTID = " + customerAddressTID;
    //            DataSet ds = my.select(sqlCmd, "CustomerAddress");
    //            if (ds.Tables["CustomerAddress"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CustomerAddress"].Rows[0];
    //                am = new CustomerAddress();
    //                am.customerAddressTID = Convert.ToInt32(dr["customerAddressTID"]);
    //                am.custID = Convert.ToInt32(dr["custID"]);
    //                am.custCity = Convert.ToString(dr["custCity"]);
    //                am.custSuburb = Convert.ToString(dr["custSuburb"]);
    //                am.custPostCode = Convert.ToString(dr["custPostCode"]);
    //                am.custStreet = Convert.ToString(dr["custStreet"]);
    //                am.custAddType = Convert.ToString(dr["custAddType"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int custID, String custCity, String custSuburb, String custPostCode, String custStreet, String custAddType)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerAddress(custID,custCity,custSuburb,custPostCode,custStreet,custAddType) values (" + custID + ",'" + custCity + "','" + custSuburb + "','" + custPostCode + "','" + custStreet + "','" + custAddType + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int customerAddressTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CustomerAddress where customerAddressTID = " + customerAddressTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int custID, String custCity, String custSuburb, String custPostCode, String custStreet, String custAddType)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerAddress set custID =" + custID + ",custCity ='" + custCity + "',custSuburb ='" + custSuburb + "',custPostCode ='" + custPostCode + "',custStreet ='" + custStreet + "',custAddType ='" + custAddType + "' where customerAddressTID = " + this.customerAddressTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerAddress set custID =" + this.custID + ",custCity ='" + this.custCity + "',custSuburb ='" + this.custSuburb + "',custPostCode ='" + this.custPostCode + "',custStreet ='" + this.custStreet + "',custAddType ='" + this.custAddType + "' where customerAddressTID = " + this.customerAddressTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerAddress");
    //            if (ds.Tables["CustomerAddress"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CustomerAddress"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerAddress.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


