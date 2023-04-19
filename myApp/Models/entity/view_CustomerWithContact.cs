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
    //public partial class view_CustomerWithContact
    //{
    
    //    public Collection<view_CustomerWithContact> findAll()
    //    {
    //        Collection<view_CustomerWithContact> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from view_CustomerWithContact order by customerTID asc", "view_CustomerWithContact");
    //            if (ds.Tables["view_CustomerWithContact"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_CustomerWithContact>();
    //                foreach (DataRow dr in ds.Tables["view_CustomerWithContact"].Rows)
    //                {
    //                    view_CustomerWithContact am = new view_CustomerWithContact();
    //                    am.customerTID = Convert.ToInt32(dr["customerTID"]);
    //                    am.companyName = Convert.ToString(dr["companyName"]);
    //                    am.mainPhone = Convert.ToString(dr["mainPhone"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.customerContactTID = dr["customerContactTID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["customerContactTID"]);
    //                    am.custName = Convert.ToString(dr["custName"]);
    //                    am.custPhone = Convert.ToString(dr["custPhone"]);
    //                    am.custMobile = Convert.ToString(dr["custMobile"]);
    //                    am.custEmail = Convert.ToString(dr["custEmail"]);
    //                    am.custFax = Convert.ToString(dr["custFax"]);
    //                    am.caution = Convert.ToString(dr["caution"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<view_CustomerWithContact> findByKeyword(String sqlCmd)
    //    {
    //        Collection<view_CustomerWithContact> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "view_CustomerWithContact");
    //            if (ds.Tables["view_CustomerWithContact"].Rows.Count > 0)
    //            {
    //                c = new Collection<view_CustomerWithContact>();
    //                foreach (DataRow dr in ds.Tables["view_CustomerWithContact"].Rows)
    //                {
    //                    view_CustomerWithContact am = new view_CustomerWithContact();
    //                    am.customerTID = Convert.ToInt32(dr["customerTID"]);
    //                    am.companyName = Convert.ToString(dr["companyName"]);
    //                    am.mainPhone = Convert.ToString(dr["mainPhone"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.customerContactTID = dr["customerContactTID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["customerContactTID"]);
    //                    am.custName = Convert.ToString(dr["custName"]);
    //                    am.custPhone = Convert.ToString(dr["custPhone"]);
    //                    am.custMobile = Convert.ToString(dr["custMobile"]);
    //                    am.custEmail = Convert.ToString(dr["custEmail"]);
    //                    am.custFax = Convert.ToString(dr["custFax"]);
    //                    am.caution = Convert.ToString(dr["caution"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public view_CustomerWithContact findByPrimaryKey(int customerTID)
    //    {
    //        view_CustomerWithContact am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM view_CustomerWithContact a WHERE a.customerTID = " + customerTID;
    //            DataSet ds = my.select(sqlCmd, "view_CustomerWithContact");
    //            if (ds.Tables["view_CustomerWithContact"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["view_CustomerWithContact"].Rows[0];
    //                am = new view_CustomerWithContact();
    //                am.customerTID = Convert.ToInt32(dr["customerTID"]);
    //                am.companyName = Convert.ToString(dr["companyName"]);
    //                am.mainPhone = Convert.ToString(dr["mainPhone"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.customerContactTID = dr["customerContactTID"] == DBNull.Value ? -999 : Convert.ToInt32(dr["customerContactTID"]);
    //                am.custName = Convert.ToString(dr["custName"]);
    //                am.custPhone = Convert.ToString(dr["custPhone"]);
    //                am.custMobile = Convert.ToString(dr["custMobile"]);
    //                am.custEmail = Convert.ToString(dr["custEmail"]);
    //                am.custFax = Convert.ToString(dr["custFax"]);
    //                am.caution = Convert.ToString(dr["caution"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int customerTID, String companyName, String mainPhone, String status, int customerContactTID, String custName, String custPhone, String custMobile, String custEmail, String custFax, String caution)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into view_CustomerWithContact(customerTID,companyName,mainPhone,status,customerContactTID,custName,custPhone,custMobile,custEmail,custFax,caution) values (" + customerTID + ",'" + companyName + "','" + mainPhone + "','" + status + "'," + customerContactTID + ",'" + custName + "','" + custPhone + "','" + custMobile + "','" + custEmail + "','" + custFax + "','" + caution + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int customerTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from view_CustomerWithContact where customerTID = " + customerTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int customerTID, String companyName, String mainPhone, String status, int customerContactTID, String custName, String custPhone, String custMobile, String custEmail, String custFax, String caution)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update view_CustomerWithContact set customerTID =" + customerTID + ",companyName ='" + companyName + "',mainPhone ='" + mainPhone + "',status ='" + status + "',customerContactTID =" + customerContactTID + ",custName ='" + custName + "',custPhone ='" + custPhone + "',custMobile ='" + custMobile + "',custEmail ='" + custEmail + "',custFax ='" + custFax + "',caution ='" + caution + "' where customerTID = " + this.customerTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update view_CustomerWithContact set customerTID =" + this.customerTID + ",companyName ='" + this.companyName + "',mainPhone ='" + this.mainPhone + "',status ='" + this.status + "',customerContactTID =" + this.customerContactTID + ",custName ='" + this.custName + "',custPhone ='" + this.custPhone + "',custMobile ='" + this.custMobile + "',custEmail ='" + this.custEmail + "',custFax ='" + this.custFax + "',caution ='" + this.caution + "' where customerTID = " + this.customerTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "view_CustomerWithContact");
    //            if (ds.Tables["view_CustomerWithContact"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["view_CustomerWithContact"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.ViewCustomerWithContact.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


