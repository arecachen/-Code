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
  
    //public partial class Customer //deprecation
    //{
    
    //    public Collection<Customer> findAll()
    //    {
    //        Collection<Customer> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from Customer order by customerTID asc", "Customer");
    //            if (ds.Tables["Customer"].Rows.Count > 0)
    //            {
    //                c = new Collection<Customer>();
    //                foreach (DataRow dr in ds.Tables["Customer"].Rows)
    //                {
    //                    Customer am = new Customer();
    //                    am.customerTID = Convert.ToInt32(dr["customerTID"]);
    //                    am.companyName = Convert.ToString(dr["companyName"]);
    //                    am.mainPhone = Convert.ToString(dr["mainPhone"]);
    //                    am.custSourceID = Convert.ToInt32(dr["custSourceID"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.caution = Convert.ToString(dr["caution"]);
    //                    am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<Customer> findByKeyword(String sqlCmd)
    //    {
    //        Collection<Customer> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "Customer");
    //            if (ds.Tables["Customer"].Rows.Count > 0)
    //            {
    //                c = new Collection<Customer>();
    //                foreach (DataRow dr in ds.Tables["Customer"].Rows)
    //                {
    //                    Customer am = new Customer();
    //                    am.customerTID = Convert.ToInt32(dr["customerTID"]);
    //                    am.companyName = Convert.ToString(dr["companyName"]);
    //                    am.mainPhone = Convert.ToString(dr["mainPhone"]);
    //                    am.custSourceID = Convert.ToInt32(dr["custSourceID"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.caution = Convert.ToString(dr["caution"]);
    //                    am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Customer findByPrimaryKey(int customerTID)
    //    {
    //        Customer am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM Customer a WHERE a.customerTID = " + customerTID;
    //            DataSet ds = my.select(sqlCmd, "Customer");
    //            if (ds.Tables["Customer"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["Customer"].Rows[0];
    //                am = new Customer();
    //                am.customerTID = Convert.ToInt32(dr["customerTID"]);
    //                am.companyName = Convert.ToString(dr["companyName"]);
    //                am.mainPhone = Convert.ToString(dr["mainPhone"]);
    //                am.custSourceID = Convert.ToInt32(dr["custSourceID"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.caution = Convert.ToString(dr["caution"]);
    //                am.busAllian = Convert.ToInt32(dr["busAllian"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String companyName, String mainPhone, int custSourceID, String memo, String caution, int busAllian, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into Customer(companyName,mainPhone,custSourceID,memo,caution,busAllian,status) values ('" + companyName + "','" + mainPhone + "'," + custSourceID + ",'" + memo + "','" + caution + "'," + busAllian + ",'" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int customerTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from Customer where customerTID = " + customerTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String companyName, String mainPhone, int custSourceID, String memo, String caution, int busAllian, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update Customer set companyName ='" + companyName + "',mainPhone ='" + mainPhone + "',custSourceID =" + custSourceID + ",memo ='" + memo + "',caution ='" + caution + "',busAllian =" + busAllian + ",status ='" + status + "' where customerTID = " + this.customerTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update Customer set companyName ='" + this.companyName + "',mainPhone ='" + this.mainPhone + "',custSourceID =" + this.custSourceID + ",memo ='" + this.memo + "',caution ='" + this.caution + "',busAllian =" + this.busAllian + ",status ='" + this.status + "' where customerTID = " + this.customerTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "Customer");
    //            if (ds.Tables["Customer"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["Customer"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.Customer.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}

  
}


