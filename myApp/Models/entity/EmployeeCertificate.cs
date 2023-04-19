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
    //public partial class EmployeeCertificate
    //{
    //    //public int employeeOwnCertTID { get; set; } //不可空值, 
    //    //public int empID { get; set; } //不可空值,FK_EmployeeMain_employeeTID 
    //    //public int certTypeID { get; set; } //不可空值,證照種類 下拉選單 FK_Employeement_empCertTID 
    //    //public String certID { get; set; } //不可空值,證件ID/編號 
    //    //public String certImgSrc { get; set; } //可空值,證照圖檔 
    //    //public int certImgShow { get; set; } //可空值,於車籍資料列印時(訂單隨車資料)是否顯示 
    //    //public String cerDoc { get; set; } //可空值,證照相關文件 
    //    //public int certRequiredUpdate { get; set; } //不可空值,是否需要更新 
    //    //public long certCreateDatetime { get; set; } //不可空值,發證日期 
    //    //public long certUpdateDatetime { get; set; } //可空值,最後更新日 (由系統直接撈取存檔時間 
    //    //public long certRenewDate { get; set; } //可空值,證照預定更新日期 
    //    //public String memo { get; set; } //可空值,備註 
    //    //public String status { get; set; } //不可空值,狀態，參考 ([StatusTable].statusGroup='EmployeeCertificate 
    //    public Collection<EmployeeCertificate> findAll()
    //    {
    //        Collection<EmployeeCertificate> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from EmployeeCertificate order by employeeOwnCertTID asc", "EmployeeCertificate");
    //            if (ds.Tables["EmployeeCertificate"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeCertificate>();
    //                foreach (DataRow dr in ds.Tables["EmployeeCertificate"].Rows)
    //                {
    //                    EmployeeCertificate am = new EmployeeCertificate();
    //                    am.employeeOwnCertTID = Convert.ToInt32(dr["employeeOwnCertTID"]);
    //                    am.empID = Convert.ToInt32(dr["empID"]);
    //                    am.certTypeID = Convert.ToInt32(dr["certTypeID"]);
    //                    am.certID = Convert.ToString(dr["certID"]);
    //                    am.certImgSrc = Convert.ToString(dr["certImgSrc"]);
    //                    am.certImgShow = dr["certImgShow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["certImgShow"]);
    //                    am.cerDoc = Convert.ToString(dr["cerDoc"]);
    //                    am.certRequiredUpdate = Convert.ToInt32(dr["certRequiredUpdate"]);
    //                    am.certCreateDatetime = Convert.ToInt64(dr["certCreateDatetime"]);
    //                    am.certUpdateDatetime = dr["certUpdateDatetime"] == DBNull.Value ? -999 : Convert.ToInt64(dr["certUpdateDatetime"]);
    //                    am.certRenewDate = dr["certRenewDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["certRenewDate"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeCertificate> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeCertificate> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeCertificate");
    //            if (ds.Tables["EmployeeCertificate"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeCertificate>();
    //                foreach (DataRow dr in ds.Tables["EmployeeCertificate"].Rows)
    //                {
    //                    EmployeeCertificate am = new EmployeeCertificate();
    //                    am.employeeOwnCertTID = Convert.ToInt32(dr["employeeOwnCertTID"]);
    //                    am.empID = Convert.ToInt32(dr["empID"]);
    //                    am.certTypeID = Convert.ToInt32(dr["certTypeID"]);
    //                    am.certID = Convert.ToString(dr["certID"]);
    //                    am.certImgSrc = Convert.ToString(dr["certImgSrc"]);
    //                    am.certImgShow = dr["certImgShow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["certImgShow"]);
    //                    am.cerDoc = Convert.ToString(dr["cerDoc"]);
    //                    am.certRequiredUpdate = Convert.ToInt32(dr["certRequiredUpdate"]);
    //                    am.certCreateDatetime = Convert.ToInt64(dr["certCreateDatetime"]);
    //                    am.certUpdateDatetime = dr["certUpdateDatetime"] == DBNull.Value ? -999 : Convert.ToInt64(dr["certUpdateDatetime"]);
    //                    am.certRenewDate = dr["certRenewDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["certRenewDate"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeCertificate findByPrimaryKey(int employeeOwnCertTID)
    //    {
    //        EmployeeCertificate am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeeCertificate a WHERE a.employeeOwnCertTID = " + employeeOwnCertTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeCertificate");
    //            if (ds.Tables["EmployeeCertificate"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeCertificate"].Rows[0];
    //                am = new EmployeeCertificate();
    //                am.employeeOwnCertTID = Convert.ToInt32(dr["employeeOwnCertTID"]);
    //                am.empID = Convert.ToInt32(dr["empID"]);
    //                am.certTypeID = Convert.ToInt32(dr["certTypeID"]);
    //                am.certID = Convert.ToString(dr["certID"]);
    //                am.certImgSrc = Convert.ToString(dr["certImgSrc"]);
    //                am.certImgShow = dr["certImgShow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["certImgShow"]);
    //                am.cerDoc = Convert.ToString(dr["cerDoc"]);
    //                am.certRequiredUpdate = Convert.ToInt32(dr["certRequiredUpdate"]);
    //                am.certCreateDatetime = Convert.ToInt64(dr["certCreateDatetime"]);
    //                am.certUpdateDatetime = dr["certUpdateDatetime"] == DBNull.Value ? -999 : Convert.ToInt64(dr["certUpdateDatetime"]);
    //                am.certRenewDate = dr["certRenewDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["certRenewDate"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.status = Convert.ToString(dr["status"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int empID, int certTypeID, String certID, String certImgSrc, int certImgShow, String cerDoc, int certRequiredUpdate, long certCreateDatetime, long certUpdateDatetime, long certRenewDate, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into EmployeeCertificate(empID,certTypeID,certID,certImgSrc,certImgShow,cerDoc,certRequiredUpdate,certCreateDatetime,certUpdateDatetime,certRenewDate,memo,status) values (" + empID + "," + certTypeID + ",'" + certID + "','" + certImgSrc + "'," + certImgShow + ",'" + cerDoc + "'," + certRequiredUpdate + "," + certCreateDatetime + "," + certUpdateDatetime + "," + certRenewDate + ",'" + memo + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int employeeOwnCertTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from EmployeeCertificate where employeeOwnCertTID = " + employeeOwnCertTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int empID, int certTypeID, String certID, String certImgSrc, int certImgShow, String cerDoc, int certRequiredUpdate, long certCreateDatetime, long certUpdateDatetime, long certRenewDate, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update EmployeeCertificate set empID =" + empID + ",certTypeID =" + certTypeID + ",certID ='" + certID + "',certImgSrc ='" + certImgSrc + "',certImgShow =" + certImgShow + ",cerDoc ='" + cerDoc + "',certRequiredUpdate =" + certRequiredUpdate + ",certCreateDatetime =" + certCreateDatetime + ",certUpdateDatetime =" + certUpdateDatetime + ",certRenewDate =" + certRenewDate + ",memo ='" + memo + "',status ='" + status + "' where employeeOwnCertTID = " + this.employeeOwnCertTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update EmployeeCertificate set empID =" + this.empID + ",certTypeID =" + this.certTypeID + ",certID ='" + this.certID + "',certImgSrc ='" + this.certImgSrc + "',certImgShow =" + this.certImgShow + ",cerDoc ='" + this.cerDoc + "',certRequiredUpdate =" + this.certRequiredUpdate + ",certCreateDatetime =" + this.certCreateDatetime + ",certUpdateDatetime =" + this.certUpdateDatetime + ",certRenewDate =" + this.certRenewDate + ",memo ='" + this.memo + "',status ='" + this.status + "' where employeeOwnCertTID = " + this.employeeOwnCertTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeCertificate");
    //            if (ds.Tables["EmployeeCertificate"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeCertificate"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeCertificate.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


