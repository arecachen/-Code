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
   
    //public partial class CustomerContact
    //{

    //    public Collection<CustomerContact> findAll()
    //    {
    //        Collection<CustomerContact> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CustomerContact order by customerContactTID asc", "CustomerContact");
    //            if (ds.Tables["CustomerContact"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerContact>();
    //                foreach (DataRow dr in ds.Tables["CustomerContact"].Rows)
    //                {
    //                    CustomerContact am = new CustomerContact();
    //                    am.customerContactTID = Convert.ToInt32(dr["customerContactTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.custName = Convert.ToString(dr["custName"]);
    //                    am.custPhone = Convert.ToString(dr["custPhone"]);
    //                    am.custMobile = Convert.ToString(dr["custMobile"]);
    //                    am.custEmail = Convert.ToString(dr["custEmail"]);
    //                    am.custFax = Convert.ToString(dr["custFax"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CustomerContact> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CustomerContact> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerContact");
    //            if (ds.Tables["CustomerContact"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerContact>();
    //                foreach (DataRow dr in ds.Tables["CustomerContact"].Rows)
    //                {
    //                    CustomerContact am = new CustomerContact();
    //                    am.customerContactTID = Convert.ToInt32(dr["customerContactTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.custName = Convert.ToString(dr["custName"]);
    //                    am.custPhone = Convert.ToString(dr["custPhone"]);
    //                    am.custMobile = Convert.ToString(dr["custMobile"]);
    //                    am.custEmail = Convert.ToString(dr["custEmail"]);
    //                    am.custFax = Convert.ToString(dr["custFax"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CustomerContact findByPrimaryKey(int customerContactTID)
    //    {
    //        CustomerContact am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CustomerContact a WHERE a.customerContactTID = " + customerContactTID;
    //            DataSet ds = my.select(sqlCmd, "CustomerContact");
    //            if (ds.Tables["CustomerContact"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CustomerContact"].Rows[0];
    //                am = new CustomerContact();
    //                am.customerContactTID = Convert.ToInt32(dr["customerContactTID"]);
    //                am.custID = Convert.ToInt32(dr["custID"]);
    //                am.custName = Convert.ToString(dr["custName"]);
    //                am.custPhone = Convert.ToString(dr["custPhone"]);
    //                am.custMobile = Convert.ToString(dr["custMobile"]);
    //                am.custEmail = Convert.ToString(dr["custEmail"]);
    //                am.custFax = Convert.ToString(dr["custFax"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int custID, String custName, String custPhone, String custMobile, String custEmail, String custFax, String memo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerContact(custID,custName,custPhone,custMobile,custEmail,custFax,memo) values (" + custID + ",'" + custName + "','" + custPhone + "','" + custMobile + "','" + custEmail + "','" + custFax + "','" + memo + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int customerContactTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CustomerContact where customerContactTID = " + customerContactTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int custID, String custName, String custPhone, String custMobile, String custEmail, String custFax, String memo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerContact set custID =" + custID + ",custName ='" + custName + "',custPhone ='" + custPhone + "',custMobile ='" + custMobile + "',custEmail ='" + custEmail + "',custFax ='" + custFax + "',memo ='" + memo + "' where customerContactTID = " + this.customerContactTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerContact set custID =" + this.custID + ",custName ='" + this.custName + "',custPhone ='" + this.custPhone + "',custMobile ='" + this.custMobile + "',custEmail ='" + this.custEmail + "',custFax ='" + this.custFax + "',memo ='" + this.memo + "' where customerContactTID = " + this.customerContactTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerContact");
    //            if (ds.Tables["CustomerContact"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CustomerContact"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerContact.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}

   
}


