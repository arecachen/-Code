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
    //public partial class CustomerWithTypes
    //{
    //    public Collection<CustomerWithTypes> findAll()
    //    {
    //        Collection<CustomerWithTypes> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CustomerWithTypes order by CustomerWithTypeTID asc", "CustomerWithTypes");
    //            if (ds.Tables["CustomerWithTypes"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerWithTypes>();
    //                foreach (DataRow dr in ds.Tables["CustomerWithTypes"].Rows)
    //                {
    //                    CustomerWithTypes am = new CustomerWithTypes();
    //                    am.CustomerWithTypeTID = Convert.ToInt32(dr["CustomerWithTypeTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.custTypeID = Convert.ToInt32(dr["custTypeID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CustomerWithTypes> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CustomerWithTypes> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerWithTypes");
    //            if (ds.Tables["CustomerWithTypes"].Rows.Count > 0)
    //            {
    //                c = new Collection<CustomerWithTypes>();
    //                foreach (DataRow dr in ds.Tables["CustomerWithTypes"].Rows)
    //                {
    //                    CustomerWithTypes am = new CustomerWithTypes();
    //                    am.CustomerWithTypeTID = Convert.ToInt32(dr["CustomerWithTypeTID"]);
    //                    am.custID = Convert.ToInt32(dr["custID"]);
    //                    am.custTypeID = Convert.ToInt32(dr["custTypeID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CustomerWithTypes findByPrimaryKey(int CustomerWithTypeTID)
    //    {
    //        CustomerWithTypes am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CustomerWithTypes a WHERE a.CustomerWithTypeTID = " + CustomerWithTypeTID;
    //            DataSet ds = my.select(sqlCmd, "CustomerWithTypes");
    //            if (ds.Tables["CustomerWithTypes"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CustomerWithTypes"].Rows[0];
    //                am = new CustomerWithTypes();
    //                am.CustomerWithTypeTID = Convert.ToInt32(dr["CustomerWithTypeTID"]);
    //                am.custID = Convert.ToInt32(dr["custID"]);
    //                am.custTypeID = Convert.ToInt32(dr["custTypeID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int custID, int custTypeID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CustomerWithTypes(custID,custTypeID) values (" + custID + "," + custTypeID + ")";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int CustomerWithTypeTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CustomerWithTypes where CustomerWithTypeTID = " + CustomerWithTypeTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int custID, int custTypeID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerWithTypes set custID =" + custID + ",custTypeID =" + custTypeID + " where CustomerWithTypeTID = " + this.CustomerWithTypeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CustomerWithTypes set custID =" + this.custID + ",custTypeID =" + this.custTypeID + " where CustomerWithTypeTID = " + this.CustomerWithTypeTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CustomerWithTypes");
    //            if (ds.Tables["CustomerWithTypes"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CustomerWithTypes"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerWithTypes.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


