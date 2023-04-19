using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
namespace hsintongERP2022.Models
{
    //public partial class CarAccident
    //{

    //    public Collection<CarAccident> findAll()
    //    {
    //        Collection<CarAccident> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarAccident order by carAccidentTID asc", "CarAccident");
    //            if (ds.Tables["CarAccident"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarAccident>();
    //                foreach (DataRow dr in ds.Tables["CarAccident"].Rows)
    //                {
    //                    CarAccident am = new CarAccident();
    //                    am.caCreateatetime = Convert.ToInt64(dr["caCreateatetime"]);
    //                    am.caDatetime = Convert.ToInt64(dr["caDatetime"]);
    //                    am.caDatetimeApprox = Convert.ToInt32(dr["caDatetimeApprox"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.caDriver = Convert.ToInt32(dr["caDriver"]);
    //                    am.caOccured = Convert.ToString(dr["caOccured"]);
    //                    am.caResolution = Convert.ToString(dr["caResolution"]);
    //                    am.caDriverFund = dr["caDriverFund"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caDriverFund"]);
    //                    am.caFixIt = Convert.ToInt32(dr["caFixIt"]);
    //                    am.caRemedy = Convert.ToInt32(dr["caRemedy"]);
    //                    am.caNotifyPolice = Convert.ToInt32(dr["caNotifyPolice"]);
    //                    am.caReportToPolice = Convert.ToInt32(dr["caReportToPolice"]);
    //                    am.caUseInsurance = Convert.ToInt32(dr["caUseInsurance"]);
    //                    am.caInsuranceID = Convert.ToInt32(dr["caInsuranceID"]);
    //                    am.insuranceType = Convert.ToString(dr["insuranceType"]);
    //                    am.caInsuranceID2 = Convert.ToInt32(dr["caInsuranceID2"]);
    //                    am.insuranceType2 = Convert.ToString(dr["insuranceType2"]);
    //                    am.caInsuranceMemo = Convert.ToString(dr["caInsuranceMemo"]);
    //                    am.injuredMy = Convert.ToString(dr["injuredMy"]);
    //                    am.injuredOther = Convert.ToString(dr["injuredOther"]);
    //                    am.damageCarMy = Convert.ToString(dr["damageCarMy"]);
    //                    am.damageCarOther = Convert.ToString(dr["damageCarOther"]);
    //                    am.MemoMy = Convert.ToString(dr["MemoMy"]);
    //                    am.MemoOther = Convert.ToString(dr["MemoOther"]);
    //                    am.caStatus = Convert.ToString(dr["caStatus"]);
    //                    am.carAccidentTID = Convert.ToInt32(dr["carAccidentTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<CarAccident> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarAccident> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarAccident");
    //            if (ds.Tables["CarAccident"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarAccident>();
    //                foreach (DataRow dr in ds.Tables["CarAccident"].Rows)
    //                {
    //                    CarAccident am = new CarAccident();
    //                    am.caCreateatetime = Convert.ToInt64(dr["caCreateatetime"]);
    //                    am.caDatetime = Convert.ToInt64(dr["caDatetime"]);
    //                    am.caDatetimeApprox = Convert.ToInt32(dr["caDatetimeApprox"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.caDriver = Convert.ToInt32(dr["caDriver"]);
    //                    am.caOccured = Convert.ToString(dr["caOccured"]);
    //                    am.caResolution = Convert.ToString(dr["caResolution"]);
    //                    am.caDriverFund = dr["caDriverFund"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caDriverFund"]);
    //                    am.caFixIt = Convert.ToInt32(dr["caFixIt"]);
    //                    am.caRemedy = Convert.ToInt32(dr["caRemedy"]);
    //                    am.caNotifyPolice = Convert.ToInt32(dr["caNotifyPolice"]);
    //                    am.caReportToPolice = Convert.ToInt32(dr["caReportToPolice"]);
    //                    am.caUseInsurance = Convert.ToInt32(dr["caUseInsurance"]);
    //                    am.caInsuranceID = Convert.ToInt32(dr["caInsuranceID"]);
    //                    am.insuranceType = Convert.ToString(dr["insuranceType"]);
    //                    am.caInsuranceID2 = Convert.ToInt32(dr["caInsuranceID2"]);
    //                    am.insuranceType2 = Convert.ToString(dr["insuranceType2"]);
    //                    am.caInsuranceMemo = Convert.ToString(dr["caInsuranceMemo"]);
    //                    am.injuredMy = Convert.ToString(dr["injuredMy"]);
    //                    am.injuredOther = Convert.ToString(dr["injuredOther"]);
    //                    am.damageCarMy = Convert.ToString(dr["damageCarMy"]);
    //                    am.damageCarOther = Convert.ToString(dr["damageCarOther"]);
    //                    am.MemoMy = Convert.ToString(dr["MemoMy"]);
    //                    am.MemoOther = Convert.ToString(dr["MemoOther"]);
    //                    am.caStatus = Convert.ToString(dr["caStatus"]);
    //                    am.carAccidentTID = Convert.ToInt32(dr["carAccidentTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public CarAccident findByPrimaryKey(int carAccidentTID)
    //    {
    //        CarAccident am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarAccident a WHERE a.carAccidentTID = " + carAccidentTID;
    //            DataSet ds = my.select(sqlCmd, "CarAccident");
    //            if (ds.Tables["CarAccident"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarAccident"].Rows[0];
    //                am = new CarAccident();
    //                am.caCreateatetime = Convert.ToInt64(dr["caCreateatetime"]);
    //                am.caDatetime = Convert.ToInt64(dr["caDatetime"]);
    //                am.caDatetimeApprox = Convert.ToInt32(dr["caDatetimeApprox"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.caDriver = Convert.ToInt32(dr["caDriver"]);
    //                am.caOccured = Convert.ToString(dr["caOccured"]);
    //                am.caResolution = Convert.ToString(dr["caResolution"]);
    //                am.caDriverFund = dr["caDriverFund"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caDriverFund"]);
    //                am.caFixIt = Convert.ToInt32(dr["caFixIt"]);
    //                am.caRemedy = Convert.ToInt32(dr["caRemedy"]);
    //                am.caNotifyPolice = Convert.ToInt32(dr["caNotifyPolice"]);
    //                am.caReportToPolice = Convert.ToInt32(dr["caReportToPolice"]);
    //                am.caUseInsurance = Convert.ToInt32(dr["caUseInsurance"]);
    //                am.caInsuranceID = Convert.ToInt32(dr["caInsuranceID"]);
    //                am.insuranceType = Convert.ToString(dr["insuranceType"]);
    //                am.caInsuranceID2 = Convert.ToInt32(dr["caInsuranceID2"]);
    //                am.insuranceType2 = Convert.ToString(dr["insuranceType2"]);
    //                am.caInsuranceMemo = Convert.ToString(dr["caInsuranceMemo"]);
    //                am.injuredMy = Convert.ToString(dr["injuredMy"]);
    //                am.injuredOther = Convert.ToString(dr["injuredOther"]);
    //                am.damageCarMy = Convert.ToString(dr["damageCarMy"]);
    //                am.damageCarOther = Convert.ToString(dr["damageCarOther"]);
    //                am.MemoMy = Convert.ToString(dr["MemoMy"]);
    //                am.MemoOther = Convert.ToString(dr["MemoOther"]);
    //                am.caStatus = Convert.ToString(dr["caStatus"]);
    //                am.carAccidentTID = Convert.ToInt32(dr["carAccidentTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(long caCreateatetime, long caDatetime, int caDatetimeApprox, String carID, int caDriver, String caOccured, String caResolution, double caDriverFund, int caFixIt, int caRemedy, int caNotifyPolice, int caReportToPolice, int caUseInsurance, int caInsuranceID, String insuranceType, int caInsuranceID2, String insuranceType2, String caInsuranceMemo, String injuredMy, String injuredOther, String damageCarMy, String damageCarOther, String MemoMy, String MemoOther, String caStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(caCreateatetime + ",");
    //            sb_value.Append(caDatetime + ",");
    //            sb_value.Append(caDatetimeApprox + ",");
    //            sb_value.Append((String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append(caDriver + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caOccured) ? "''" : "N'" + Regex.Replace(caOccured, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caResolution) ? "null" : "N'" + Regex.Replace(caResolution, "'", "''") + "'") + ",");
    //            sb_value.Append(caDriverFund + ",");
    //            sb_value.Append(caFixIt + ",");
    //            sb_value.Append(caRemedy + ",");
    //            sb_value.Append(caNotifyPolice + ",");
    //            sb_value.Append(caReportToPolice + ",");
    //            sb_value.Append(caUseInsurance + ",");
    //            sb_value.Append(caInsuranceID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(insuranceType) ? "null" : "N'" + Regex.Replace(insuranceType, "'", "''") + "'") + ",");
    //            sb_value.Append(caInsuranceID2 + ",");
    //            sb_value.Append((String.IsNullOrEmpty(insuranceType2) ? "null" : "N'" + Regex.Replace(insuranceType2, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caInsuranceMemo) ? "null" : "N'" + Regex.Replace(caInsuranceMemo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(injuredMy) ? "null" : "N'" + Regex.Replace(injuredMy, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(injuredOther) ? "null" : "N'" + Regex.Replace(injuredOther, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(damageCarMy) ? "null" : "N'" + Regex.Replace(damageCarMy, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(damageCarOther) ? "null" : "N'" + Regex.Replace(damageCarOther, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(MemoMy) ? "null" : "N'" + Regex.Replace(MemoMy, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(MemoOther) ? "null" : "N'" + Regex.Replace(MemoOther, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caStatus) ? "''" : "N'" + Regex.Replace(caStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into CarAccident(caCreateatetime,caDatetime,caDatetimeApprox,carID,caDriver,caOccured,caResolution,caDriverFund,caFixIt,caRemedy,caNotifyPolice,caReportToPolice,caUseInsurance,caInsuranceID,insuranceType,caInsuranceID2,insuranceType2,caInsuranceMemo,injuredMy,injuredOther,damageCarMy,damageCarOther,MemoMy,MemoOther,caStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int carAccidentTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarAccident where carAccidentTID = " + carAccidentTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.delete() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int DeleteByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(long caCreateatetime, long caDatetime, int caDatetimeApprox, String carID, int caDriver, String caOccured, String caResolution, double caDriverFund, int caFixIt, int caRemedy, int caNotifyPolice, int caReportToPolice, int caUseInsurance, int caInsuranceID, String insuranceType, int caInsuranceID2, String insuranceType2, String caInsuranceMemo, String injuredMy, String injuredOther, String damageCarMy, String damageCarOther, String MemoMy, String MemoOther, String caStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("caCreateatetime =" + caCreateatetime + ",");
    //            sb_value.Append("caDatetime =" + caDatetime + ",");
    //            sb_value.Append("caDatetimeApprox =" + caDatetimeApprox + ",");
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append("caDriver =" + caDriver + ",");
    //            sb_value.Append("caOccured=" + (String.IsNullOrEmpty(caOccured) ? "''" : "N'" + Regex.Replace(caOccured, "'", "''") + "'") + ",");
    //            sb_value.Append("caResolution=" + (String.IsNullOrEmpty(caResolution) ? "null" : "N'" + Regex.Replace(caResolution, "'", "''") + "'") + ",");
    //            sb_value.Append("caDriverFund =" + caDriverFund + ",");
    //            sb_value.Append("caFixIt =" + caFixIt + ",");
    //            sb_value.Append("caRemedy =" + caRemedy + ",");
    //            sb_value.Append("caNotifyPolice =" + caNotifyPolice + ",");
    //            sb_value.Append("caReportToPolice =" + caReportToPolice + ",");
    //            sb_value.Append("caUseInsurance =" + caUseInsurance + ",");
    //            sb_value.Append("caInsuranceID =" + caInsuranceID + ",");
    //            sb_value.Append("insuranceType=" + (String.IsNullOrEmpty(insuranceType) ? "null" : "N'" + Regex.Replace(insuranceType, "'", "''") + "'") + ",");
    //            sb_value.Append("caInsuranceID2 =" + caInsuranceID2 + ",");
    //            sb_value.Append("insuranceType2=" + (String.IsNullOrEmpty(insuranceType2) ? "null" : "N'" + Regex.Replace(insuranceType2, "'", "''") + "'") + ",");
    //            sb_value.Append("caInsuranceMemo=" + (String.IsNullOrEmpty(caInsuranceMemo) ? "null" : "N'" + Regex.Replace(caInsuranceMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("injuredMy=" + (String.IsNullOrEmpty(injuredMy) ? "null" : "N'" + Regex.Replace(injuredMy, "'", "''") + "'") + ",");
    //            sb_value.Append("injuredOther=" + (String.IsNullOrEmpty(injuredOther) ? "null" : "N'" + Regex.Replace(injuredOther, "'", "''") + "'") + ",");
    //            sb_value.Append("damageCarMy=" + (String.IsNullOrEmpty(damageCarMy) ? "null" : "N'" + Regex.Replace(damageCarMy, "'", "''") + "'") + ",");
    //            sb_value.Append("damageCarOther=" + (String.IsNullOrEmpty(damageCarOther) ? "null" : "N'" + Regex.Replace(damageCarOther, "'", "''") + "'") + ",");
    //            sb_value.Append("MemoMy=" + (String.IsNullOrEmpty(MemoMy) ? "null" : "N'" + Regex.Replace(MemoMy, "'", "''") + "'") + ",");
    //            sb_value.Append("MemoOther=" + (String.IsNullOrEmpty(MemoOther) ? "null" : "N'" + Regex.Replace(MemoOther, "'", "''") + "'") + ",");
    //            sb_value.Append("caStatus=" + (String.IsNullOrEmpty(caStatus) ? "''" : "N'" + Regex.Replace(caStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarAccident set  " + sb_value.ToString() + "  where carAccidentTID = " + this.carAccidentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("caCreateatetime =" + this.caCreateatetime + ",");
    //            sb_value.Append("caDatetime =" + this.caDatetime + ",");
    //            sb_value.Append("caDatetimeApprox =" + this.caDatetimeApprox + ",");
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(this.carID) ? "''" : "N'" + Regex.Replace(this.carID, "'", "''") + "'") + ",");
    //            sb_value.Append("caDriver =" + this.caDriver + ",");
    //            sb_value.Append("caOccured=" + (String.IsNullOrEmpty(this.caOccured) ? "''" : "N'" + Regex.Replace(this.caOccured, "'", "''") + "'") + ",");
    //            sb_value.Append("caResolution=" + (String.IsNullOrEmpty(this.caResolution) ? "null" : "N'" + Regex.Replace(this.caResolution, "'", "''") + "'") + ",");
    //            sb_value.Append("caDriverFund =" + this.caDriverFund + ",");
    //            sb_value.Append("caFixIt =" + this.caFixIt + ",");
    //            sb_value.Append("caRemedy =" + this.caRemedy + ",");
    //            sb_value.Append("caNotifyPolice =" + this.caNotifyPolice + ",");
    //            sb_value.Append("caReportToPolice =" + this.caReportToPolice + ",");
    //            sb_value.Append("caUseInsurance =" + this.caUseInsurance + ",");
    //            sb_value.Append("caInsuranceID =" + this.caInsuranceID + ",");
    //            sb_value.Append("insuranceType=" + (String.IsNullOrEmpty(this.insuranceType) ? "null" : "N'" + Regex.Replace(this.insuranceType, "'", "''") + "'") + ",");
    //            sb_value.Append("caInsuranceID2 =" + this.caInsuranceID2 + ",");
    //            sb_value.Append("insuranceType2=" + (String.IsNullOrEmpty(this.insuranceType2) ? "null" : "N'" + Regex.Replace(this.insuranceType2, "'", "''") + "'") + ",");
    //            sb_value.Append("caInsuranceMemo=" + (String.IsNullOrEmpty(this.caInsuranceMemo) ? "null" : "N'" + Regex.Replace(this.caInsuranceMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("injuredMy=" + (String.IsNullOrEmpty(this.injuredMy) ? "null" : "N'" + Regex.Replace(this.injuredMy, "'", "''") + "'") + ",");
    //            sb_value.Append("injuredOther=" + (String.IsNullOrEmpty(this.injuredOther) ? "null" : "N'" + Regex.Replace(this.injuredOther, "'", "''") + "'") + ",");
    //            sb_value.Append("damageCarMy=" + (String.IsNullOrEmpty(this.damageCarMy) ? "null" : "N'" + Regex.Replace(this.damageCarMy, "'", "''") + "'") + ",");
    //            sb_value.Append("damageCarOther=" + (String.IsNullOrEmpty(this.damageCarOther) ? "null" : "N'" + Regex.Replace(this.damageCarOther, "'", "''") + "'") + ",");
    //            sb_value.Append("MemoMy=" + (String.IsNullOrEmpty(this.MemoMy) ? "null" : "N'" + Regex.Replace(this.MemoMy, "'", "''") + "'") + ",");
    //            sb_value.Append("MemoOther=" + (String.IsNullOrEmpty(this.MemoOther) ? "null" : "N'" + Regex.Replace(this.MemoOther, "'", "''") + "'") + ",");
    //            sb_value.Append("caStatus=" + (String.IsNullOrEmpty(this.caStatus) ? "''" : "N'" + Regex.Replace(this.caStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarAccident set  " + sb_value.ToString() + "  where carAccidentTID = " + this.carAccidentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarAccident");
    //            if (ds.Tables["CarAccident"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarAccident"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarAccident.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


