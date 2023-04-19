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
    //public partial class EmployeeCertType
    //{
    //    //public String certName { get; set; } //可空值,證照名稱 
    //    //public String memo { get; set; } //可空值,備註 
    //    //public String status { get; set; } //可空值,狀態，參考 [StatusTable].statusGroup='EmployeeCerType' 
    //    //public int certAlertDay { get; set; } //不可空值,該類別證件到期前多少天需要警示 
    //    //public int empCertTID { get; set; } //不可空值, 
    //    public Collection<EmployeeCertType> findAll()
    //    {
    //        Collection<EmployeeCertType> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from EmployeeCertType order by empCertTID asc", "EmployeeCertType");
    //            if (ds.Tables["EmployeeCertType"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeCertType>();
    //                foreach (DataRow dr in ds.Tables["EmployeeCertType"].Rows)
    //                {
    //                    EmployeeCertType am = new EmployeeCertType();
    //                    am.certName = Convert.ToString(dr["certName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.certAlertDay = Convert.ToInt32(dr["certAlertDay"]);
    //                    am.empCertTID = Convert.ToInt32(dr["empCertTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeCertType> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeCertType> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeCertType");
    //            if (ds.Tables["EmployeeCertType"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeCertType>();
    //                foreach (DataRow dr in ds.Tables["EmployeeCertType"].Rows)
    //                {
    //                    EmployeeCertType am = new EmployeeCertType();
    //                    am.certName = Convert.ToString(dr["certName"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.certAlertDay = Convert.ToInt32(dr["certAlertDay"]);
    //                    am.empCertTID = Convert.ToInt32(dr["empCertTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeCertType findByPrimaryKey(int empCertTID)
    //    {
    //        EmployeeCertType am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeeCertType a WHERE a.empCertTID = " + empCertTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeCertType");
    //            if (ds.Tables["EmployeeCertType"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeCertType"].Rows[0];
    //                am = new EmployeeCertType();
    //                am.certName = Convert.ToString(dr["certName"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.certAlertDay = Convert.ToInt32(dr["certAlertDay"]);
    //                am.empCertTID = Convert.ToInt32(dr["empCertTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String certName, String memo, String status, int certAlertDay)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into EmployeeCertType(certName,memo,status,certAlertDay) values ('" + certName + "','" + memo + "','" + status + "'," + certAlertDay + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int empCertTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from EmployeeCertType where empCertTID = " + empCertTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String certName, String memo, String status, int certAlertDay)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update EmployeeCertType set certName ='" + certName + "',memo ='" + memo + "',status ='" + status + "',certAlertDay =" + certAlertDay + " where empCertTID = " + this.empCertTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update EmployeeCertType set certName ='" + this.certName + "',memo ='" + this.memo + "',status ='" + this.status + "',certAlertDay =" + this.certAlertDay + " where empCertTID = " + this.empCertTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeCertType");
    //            if (ds.Tables["EmployeeCertType"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeCertType"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertType.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


