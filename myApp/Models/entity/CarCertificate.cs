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
    //public partial class CarCertificate
    //{        
    //    public Collection<CarCertificate> findAll()
    //    {
    //        Collection<CarCertificate> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from CarCertificate order by carCertificateTID asc", "CarCertificate");
    //            if (ds.Tables["CarCertificate"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarCertificate>();
    //                foreach (DataRow dr in ds.Tables["CarCertificate"].Rows)
    //                {
    //                    CarCertificate am = new CarCertificate();
    //                    am.carCertificateTID = Convert.ToInt32(dr["carCertificateTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarCertificate> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarCertificate> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarCertificate");
    //            if (ds.Tables["CarCertificate"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarCertificate>();
    //                foreach (DataRow dr in ds.Tables["CarCertificate"].Rows)
    //                {
    //                    CarCertificate am = new CarCertificate();
    //                    am.carCertificateTID = Convert.ToInt32(dr["carCertificateTID"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarCertificate findByPrimaryKey(int carCertificateTID)
    //    {
    //        CarCertificate am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM CarCertificate a WHERE a.carCertificateTID = " + carCertificateTID;
    //            DataSet ds = my.select(sqlCmd, "CarCertificate");
    //            if (ds.Tables["CarCertificate"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarCertificate"].Rows[0];
    //                am = new CarCertificate();
    //                am.carCertificateTID = Convert.ToInt32(dr["carCertificateTID"]);
    //                am.carID = Convert.ToString(dr["carID"]);
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String carID, int certTypeID, String certID, String certImgSrc, int certImgShow, String cerDoc, int certRequiredUpdate, long certCreateDatetime, long certUpdateDatetime, long certRenewDate, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into CarCertificate(carID,certTypeID,certID,certImgSrc,certImgShow,cerDoc,certRequiredUpdate,certCreateDatetime,certUpdateDatetime,certRenewDate,memo,status) values ('" + carID + "'," + certTypeID + ",'" + certID + "','" + certImgSrc + "'," + certImgShow + ",'" + cerDoc + "'," + certRequiredUpdate + "," + certCreateDatetime + "," + certUpdateDatetime + "," + certRenewDate + ",'" + memo + "','" + status + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carCertificateTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarCertificate where carCertificateTID = " + carCertificateTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String carID, int certTypeID, String certID, String certImgSrc, int certImgShow, String cerDoc, int certRequiredUpdate, long certCreateDatetime, long certUpdateDatetime, long certRenewDate, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarCertificate set carID ='" + carID + "',certTypeID =" + certTypeID + ",certID ='" + certID + "',certImgSrc ='" + certImgSrc + "',certImgShow =" + certImgShow + ",cerDoc ='" + cerDoc + "',certRequiredUpdate =" + certRequiredUpdate + ",certCreateDatetime =" + certCreateDatetime + ",certUpdateDatetime =" + certUpdateDatetime + ",certRenewDate =" + certRenewDate + ",memo ='" + memo + "',status ='" + status + "' where carCertificateTID = " + this.carCertificateTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarCertificate set carID ='" + this.carID + "',certTypeID =" + this.certTypeID + ",certID ='" + this.certID + "',certImgSrc ='" + this.certImgSrc + "',certImgShow =" + this.certImgShow + ",cerDoc ='" + this.cerDoc + "',certRequiredUpdate =" + this.certRequiredUpdate + ",certCreateDatetime =" + this.certCreateDatetime + ",certUpdateDatetime =" + this.certUpdateDatetime + ",certRenewDate =" + this.certRenewDate + ",memo ='" + this.memo + "',status ='" + this.status + "' where carCertificateTID = " + this.carCertificateTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "CarCertificate");
    //            if (ds.Tables["CarCertificate"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarCertificate"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


