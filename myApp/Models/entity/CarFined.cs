using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;
using Altways;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace hsintongERP2022.Models
{


    //public partial class CarFined
    //{
    //    Model_hsintong _db = new Model_hsintong();
    //    [NotMapped, Display(Name = "違規單建檔日期")]
    //    public string sCaCreatetime
    //    {
    //        get { return ((long?)caCreatetime).StampToDateString(); }
    //        set { caCreatetime = value.ToDateStamp(); }
    //    }
    //    [NotMapped, Display(Name = "違規日期")]
    //    public string sCaDatetime
    //    {
    //        get { return ((long?)caDatetime).StampToDateString(); }
    //        set { caDatetime = value.ToDateStamp(); }
    //    }
    //    [NotMapped, Display(Name = "違規種類")]
    //    public string crfinedCategory
    //    {
    //        get
    //        {
    //            return _db.DictionaryTable.FirstOrDefault(x => x.dicValue == CarFinedCategoryID).dicText;
    //        }
    //        set { CarFinedCategoryID = _db.DictionaryTable.FirstOrDefault(x => x.dicText.Contains(value)).dicValue; }
    //    }
    //    [NotMapped, Display(Name = "是否為約略時間")]
    //    public bool IsRoughFinedTime
    //    {
    //        get { return caRoughFinedTime.Ensure(x => x > 0, false); }
    //        set { caRoughFinedTime = value ? 1 : 0; }
    //    }
    //    [NotMapped, Display(Name = "扣款金額未定 ")]
    //    public bool isDeductUnknow {
    //        get { return carDeductUnknow.Ensure(x => x > 0, false); }
    //        set { carDeductUnknow = value ? 1 : 0; }
    //    }
    //    [NotMapped]
    //    public string TicketImage { get; set; }
    //    #region sql        
    //    public Collection<CarFined> findAll()
    //    {
    //        Collection<CarFined> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from CarFined order by CarFinedTID asc", "CarFined");
    //            if (ds.Tables["CarFined"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFined>();
    //                foreach (DataRow dr in ds.Tables["CarFined"].Rows)
    //                {
    //                    CarFined am = new CarFined();
    //                    am.CarFinedCategoryID = Convert.ToString(dr["CarFinedCategoryID"]);
    //                    am.caCreatetime = Convert.ToInt64(dr["caCreatetime"]);
    //                    am.caTicketID = Convert.ToString(dr["caTicketID"]);
    //                    am.caDatetime = Convert.ToInt64(dr["caDatetime"]);
    //                    am.caFinedHour = Convert.ToInt32(dr["caFinedHour"]);
    //                    am.caFinedMinute = Convert.ToInt32(dr["caFinedMinute"]);
    //                    am.caRoughFinedTime = dr["caRoughFinedTime"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caRoughFinedTime"]);
    //                    am.caDriver = Convert.ToInt32(dr["caDriver"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.caFineLocation = Convert.ToString(dr["caFineLocation"]);
    //                    am.caFineReason = Convert.ToString(dr["caFineReason"]);
    //                    am.caThrough = Convert.ToString(dr["caThrough"]);
    //                    am.caLaw = Convert.ToString(dr["caLaw"]);
    //                    am.caDriverFinedAmount = dr["caDriverFinedAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caDriverFinedAmount"]);
    //                    am.caDeductStatus = Convert.ToString(dr["caDeductStatus"]);
    //                    am.carDeductUnknow = dr["carDeductUnknow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carDeductUnknow"]);
    //                    am.caMemo = Convert.ToString(dr["caMemo"]);
    //                    am.caTicketImage = Convert.ToString(dr["caTicketImage"]);
    //                    am.caTicketImageSysName = Convert.ToString(dr["caTicketImageSysName"]);
    //                    am.caFinedSource = Convert.ToString(dr["caFinedSource"]);
    //                    am.caFinedResolution = Convert.ToString(dr["caFinedResolution"]);
    //                    am.caPartyStatement = Convert.ToString(dr["caPartyStatement"]);
    //                    am.caFiledBy = dr["caFiledBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caFiledBy"]);
    //                    am.caCreatedBy = dr["caCreatedBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caCreatedBy"]);
    //                    am.caStatus = Convert.ToString(dr["caStatus"]);
    //                    am.CarFinedTID = Convert.ToInt32(dr["CarFinedTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }
    //    public Collection<CarFined> findByKeyword(String sqlCmd)
    //    {
    //        Collection<CarFined> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarFined");
    //            if (ds.Tables["CarFined"].Rows.Count > 0)
    //            {
    //                c = new Collection<CarFined>();
    //                foreach (DataRow dr in ds.Tables["CarFined"].Rows)
    //                {
    //                    CarFined am = new CarFined();
    //                    am.CarFinedCategoryID = Convert.ToString(dr["CarFinedCategoryID"]);
    //                    am.caCreatetime = Convert.ToInt64(dr["caCreatetime"]);
    //                    am.caTicketID = Convert.ToString(dr["caTicketID"]);
    //                    am.caDatetime = Convert.ToInt64(dr["caDatetime"]);
    //                    am.caFinedHour = Convert.ToInt32(dr["caFinedHour"]);
    //                    am.caFinedMinute = Convert.ToInt32(dr["caFinedMinute"]);
    //                    am.caRoughFinedTime = dr["caRoughFinedTime"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caRoughFinedTime"]);
    //                    am.caDriver = Convert.ToInt32(dr["caDriver"]);
    //                    am.carID = Convert.ToString(dr["carID"]);
    //                    am.caFineLocation = Convert.ToString(dr["caFineLocation"]);
    //                    am.caFineReason = Convert.ToString(dr["caFineReason"]);
    //                    am.caThrough = Convert.ToString(dr["caThrough"]);
    //                    am.caLaw = Convert.ToString(dr["caLaw"]);
    //                    am.caDriverFinedAmount = dr["caDriverFinedAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caDriverFinedAmount"]);
    //                    am.caDeductStatus = Convert.ToString(dr["caDeductStatus"]);
    //                    am.carDeductUnknow = dr["carDeductUnknow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carDeductUnknow"]);
    //                    am.caMemo = Convert.ToString(dr["caMemo"]);
    //                    am.caTicketImage = Convert.ToString(dr["caTicketImage"]);
    //                    am.caTicketImageSysName = Convert.ToString(dr["caTicketImageSysName"]);
    //                    am.caFinedSource = Convert.ToString(dr["caFinedSource"]);
    //                    am.caFinedResolution = Convert.ToString(dr["caFinedResolution"]);
    //                    am.caPartyStatement = Convert.ToString(dr["caPartyStatement"]);
    //                    am.caFiledBy = dr["caFiledBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caFiledBy"]);
    //                    am.caCreatedBy = dr["caCreatedBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caCreatedBy"]);
    //                    am.caStatus = Convert.ToString(dr["caStatus"]);
    //                    am.CarFinedTID = Convert.ToInt32(dr["CarFinedTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }
    //    public CarFined findByPrimaryKey(int CarFinedTID)
    //    {
    //        CarFined am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM CarFined a WHERE a.CarFinedTID = " + CarFinedTID;
    //            DataSet ds = my.select(sqlCmd, "CarFined");
    //            if (ds.Tables["CarFined"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["CarFined"].Rows[0];
    //                am = new CarFined();
    //                am.CarFinedCategoryID = Convert.ToString(dr["CarFinedCategoryID"]);
    //                am.caCreatetime = Convert.ToInt64(dr["caCreatetime"]);
    //                am.caTicketID = Convert.ToString(dr["caTicketID"]);
    //                am.caDatetime = Convert.ToInt64(dr["caDatetime"]);
    //                am.caFinedHour = Convert.ToInt32(dr["caFinedHour"]);
    //                am.caFinedMinute = Convert.ToInt32(dr["caFinedMinute"]);
    //                am.caRoughFinedTime = dr["caRoughFinedTime"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caRoughFinedTime"]);
    //                am.caDriver = Convert.ToInt32(dr["caDriver"]);
    //                am.carID = Convert.ToString(dr["carID"]);
    //                am.caFineLocation = Convert.ToString(dr["caFineLocation"]);
    //                am.caFineReason = Convert.ToString(dr["caFineReason"]);
    //                am.caThrough = Convert.ToString(dr["caThrough"]);
    //                am.caLaw = Convert.ToString(dr["caLaw"]);
    //                am.caDriverFinedAmount = dr["caDriverFinedAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caDriverFinedAmount"]);
    //                am.caDeductStatus = Convert.ToString(dr["caDeductStatus"]);
    //                am.carDeductUnknow = dr["carDeductUnknow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carDeductUnknow"]);
    //                am.caMemo = Convert.ToString(dr["caMemo"]);
    //                am.caTicketImage = Convert.ToString(dr["caTicketImage"]);
    //                am.caTicketImageSysName = Convert.ToString(dr["caTicketImageSysName"]);
    //                am.caFinedSource = Convert.ToString(dr["caFinedSource"]);
    //                am.caFinedResolution = Convert.ToString(dr["caFinedResolution"]);
    //                am.caPartyStatement = Convert.ToString(dr["caPartyStatement"]);
    //                am.caFiledBy = dr["caFiledBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caFiledBy"]);
    //                am.caCreatedBy = dr["caCreatedBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["caCreatedBy"]);
    //                am.caStatus = Convert.ToString(dr["caStatus"]);
    //                am.CarFinedTID = Convert.ToInt32(dr["CarFinedTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }
    //    public int create(String CarFinedCategoryID, long caCreatetime, String caTicketID, long caDatetime, int caFinedHour, int caFinedMinute, int caRoughFinedTime, int caDriver, String carID, String caFineLocation, String caFineReason, String caThrough, String caLaw, double caDriverFinedAmount, String caDeductStatus, int carDeductUnknow, String caMemo, String caTicketImage, String caTicketImageSysName, String caFinedSource, String caFinedResolution, String caPartyStatement, int caFiledBy, int caCreatedBy, String caStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(CarFinedCategoryID) ? "null" : "N'" + Regex.Replace(CarFinedCategoryID, "'", "''") + "'") + ",");
    //            sb_value.Append(caCreatetime + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caTicketID) ? "null" : "N'" + Regex.Replace(caTicketID, "'", "''") + "'") + ",");
    //            sb_value.Append(caDatetime + ",");
    //            sb_value.Append(caFinedHour + ",");
    //            sb_value.Append(caFinedMinute + ",");
    //            sb_value.Append(caRoughFinedTime + ",");
    //            sb_value.Append(caDriver + ",");
    //            sb_value.Append((String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caFineLocation) ? "''" : "N'" + Regex.Replace(caFineLocation, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caFineReason) ? "''" : "N'" + Regex.Replace(caFineReason, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caThrough) ? "null" : "N'" + Regex.Replace(caThrough, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caLaw) ? "null" : "N'" + Regex.Replace(caLaw, "'", "''") + "'") + ",");
    //            sb_value.Append(caDriverFinedAmount + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caDeductStatus) ? "null" : "N'" + Regex.Replace(caDeductStatus, "'", "''") + "'") + ",");
    //            sb_value.Append(carDeductUnknow + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caMemo) ? "null" : "N'" + Regex.Replace(caMemo, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caTicketImage) ? "null" : "N'" + Regex.Replace(caTicketImage, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caTicketImageSysName) ? "null" : "N'" + Regex.Replace(caTicketImageSysName, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caFinedSource) ? "null" : "N'" + Regex.Replace(caFinedSource, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caFinedResolution) ? "null" : "N'" + Regex.Replace(caFinedResolution, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caPartyStatement) ? "null" : "N'" + Regex.Replace(caPartyStatement, "'", "''") + "'") + ",");
    //            sb_value.Append(caFiledBy + ",");
    //            sb_value.Append(caCreatedBy + ",");
    //            sb_value.Append((String.IsNullOrEmpty(caStatus) ? "''" : "N'" + Regex.Replace(caStatus, "'", "''") + "'"));

    //            String sqlCmd = "insert into CarFined(CarFinedCategoryID,caCreatetime,caTicketID,caDatetime,caFinedHour,caFinedMinute,caRoughFinedTime,caDriver,carID,caFineLocation,caFineReason,caThrough,caLaw,caDriverFinedAmount,caDeductStatus,carDeductUnknow,caMemo,caTicketImage,caTicketImageSysName,caFinedSource,caFinedResolution,caPartyStatement,caFiledBy,caCreatedBy,caStatus) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.create() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int Delete(int CarFinedTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from CarFined where CarFinedTID = " + CarFinedTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int update(String CarFinedCategoryID, long caCreatetime, String caTicketID, long caDatetime, int caFinedHour, int caFinedMinute, int caRoughFinedTime, int caDriver, String carID, String caFineLocation, String caFineReason, String caThrough, String caLaw, double caDriverFinedAmount, String caDeductStatus, int carDeductUnknow, String caMemo, String caTicketImage, String caTicketImageSysName, String caFinedSource, String caFinedResolution, String caPartyStatement, int caFiledBy, int caCreatedBy, String caStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("CarFinedCategoryID=" + (String.IsNullOrEmpty(CarFinedCategoryID) ? "null" : "N'" + Regex.Replace(CarFinedCategoryID, "'", "''") + "'") + ",");
    //            sb_value.Append("caCreatetime =" + caCreatetime + ",");
    //            sb_value.Append("caTicketID=" + (String.IsNullOrEmpty(caTicketID) ? "null" : "N'" + Regex.Replace(caTicketID, "'", "''") + "'") + ",");
    //            sb_value.Append("caDatetime =" + caDatetime + ",");
    //            sb_value.Append("caFinedHour =" + caFinedHour + ",");
    //            sb_value.Append("caFinedMinute =" + caFinedMinute + ",");
    //            sb_value.Append("caRoughFinedTime =" + caRoughFinedTime + ",");
    //            sb_value.Append("caDriver =" + caDriver + ",");
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(carID) ? "''" : "N'" + Regex.Replace(carID, "'", "''") + "'") + ",");
    //            sb_value.Append("caFineLocation=" + (String.IsNullOrEmpty(caFineLocation) ? "''" : "N'" + Regex.Replace(caFineLocation, "'", "''") + "'") + ",");
    //            sb_value.Append("caFineReason=" + (String.IsNullOrEmpty(caFineReason) ? "''" : "N'" + Regex.Replace(caFineReason, "'", "''") + "'") + ",");
    //            sb_value.Append("caThrough=" + (String.IsNullOrEmpty(caThrough) ? "null" : "N'" + Regex.Replace(caThrough, "'", "''") + "'") + ",");
    //            sb_value.Append("caLaw=" + (String.IsNullOrEmpty(caLaw) ? "null" : "N'" + Regex.Replace(caLaw, "'", "''") + "'") + ",");
    //            sb_value.Append("caDriverFinedAmount =" + caDriverFinedAmount + ",");
    //            sb_value.Append("caDeductStatus=" + (String.IsNullOrEmpty(caDeductStatus) ? "null" : "N'" + Regex.Replace(caDeductStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("carDeductUnknow =" + carDeductUnknow + ",");
    //            sb_value.Append("caMemo=" + (String.IsNullOrEmpty(caMemo) ? "null" : "N'" + Regex.Replace(caMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("caTicketImage=" + (String.IsNullOrEmpty(caTicketImage) ? "null" : "N'" + Regex.Replace(caTicketImage, "'", "''") + "'") + ",");
    //            sb_value.Append("caTicketImageSysName=" + (String.IsNullOrEmpty(caTicketImageSysName) ? "null" : "N'" + Regex.Replace(caTicketImageSysName, "'", "''") + "'") + ",");
    //            sb_value.Append("caFinedSource=" + (String.IsNullOrEmpty(caFinedSource) ? "null" : "N'" + Regex.Replace(caFinedSource, "'", "''") + "'") + ",");
    //            sb_value.Append("caFinedResolution=" + (String.IsNullOrEmpty(caFinedResolution) ? "null" : "N'" + Regex.Replace(caFinedResolution, "'", "''") + "'") + ",");
    //            sb_value.Append("caPartyStatement=" + (String.IsNullOrEmpty(caPartyStatement) ? "null" : "N'" + Regex.Replace(caPartyStatement, "'", "''") + "'") + ",");
    //            sb_value.Append("caFiledBy =" + caFiledBy + ",");
    //            sb_value.Append("caCreatedBy =" + caCreatedBy + ",");
    //            sb_value.Append("caStatus=" + (String.IsNullOrEmpty(caStatus) ? "''" : "N'" + Regex.Replace(caStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarFined set  " + sb_value.ToString() + "  where CarFinedTID = " + this.CarFinedTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.create() : " + e.ToString());
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
    //            sb_value.Append("CarFinedCategoryID=" + (String.IsNullOrEmpty(this.CarFinedCategoryID) ? "null" : "N'" + Regex.Replace(this.CarFinedCategoryID, "'", "''") + "'") + ",");
    //            sb_value.Append("caCreatetime =" + this.caCreatetime + ",");
    //            sb_value.Append("caTicketID=" + (String.IsNullOrEmpty(this.caTicketID) ? "null" : "N'" + Regex.Replace(this.caTicketID, "'", "''") + "'") + ",");
    //            sb_value.Append("caDatetime =" + this.caDatetime + ",");
    //            sb_value.Append("caFinedHour =" + this.caFinedHour + ",");
    //            sb_value.Append("caFinedMinute =" + this.caFinedMinute + ",");
    //            sb_value.Append("caRoughFinedTime =" + this.caRoughFinedTime + ",");
    //            sb_value.Append("caDriver =" + this.caDriver + ",");
    //            sb_value.Append("carID=" + (String.IsNullOrEmpty(this.carID) ? "''" : "N'" + Regex.Replace(this.carID, "'", "''") + "'") + ",");
    //            sb_value.Append("caFineLocation=" + (String.IsNullOrEmpty(this.caFineLocation) ? "''" : "N'" + Regex.Replace(this.caFineLocation, "'", "''") + "'") + ",");
    //            sb_value.Append("caFineReason=" + (String.IsNullOrEmpty(this.caFineReason) ? "''" : "N'" + Regex.Replace(this.caFineReason, "'", "''") + "'") + ",");
    //            sb_value.Append("caThrough=" + (String.IsNullOrEmpty(this.caThrough) ? "null" : "N'" + Regex.Replace(this.caThrough, "'", "''") + "'") + ",");
    //            sb_value.Append("caLaw=" + (String.IsNullOrEmpty(this.caLaw) ? "null" : "N'" + Regex.Replace(this.caLaw, "'", "''") + "'") + ",");
    //            sb_value.Append("caDriverFinedAmount =" + this.caDriverFinedAmount + ",");
    //            sb_value.Append("caDeductStatus=" + (String.IsNullOrEmpty(this.caDeductStatus) ? "null" : "N'" + Regex.Replace(this.caDeductStatus, "'", "''") + "'") + ",");
    //            sb_value.Append("carDeductUnknow =" + this.carDeductUnknow + ",");
    //            sb_value.Append("caMemo=" + (String.IsNullOrEmpty(this.caMemo) ? "null" : "N'" + Regex.Replace(this.caMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("caTicketImage=" + (String.IsNullOrEmpty(this.caTicketImage) ? "null" : "N'" + Regex.Replace(this.caTicketImage, "'", "''") + "'") + ",");
    //            sb_value.Append("caTicketImageSysName=" + (String.IsNullOrEmpty(this.caTicketImageSysName) ? "null" : "N'" + Regex.Replace(this.caTicketImageSysName, "'", "''") + "'") + ",");
    //            sb_value.Append("caFinedSource=" + (String.IsNullOrEmpty(this.caFinedSource) ? "null" : "N'" + Regex.Replace(this.caFinedSource, "'", "''") + "'") + ",");
    //            sb_value.Append("caFinedResolution=" + (String.IsNullOrEmpty(this.caFinedResolution) ? "null" : "N'" + Regex.Replace(this.caFinedResolution, "'", "''") + "'") + ",");
    //            sb_value.Append("caPartyStatement=" + (String.IsNullOrEmpty(this.caPartyStatement) ? "null" : "N'" + Regex.Replace(this.caPartyStatement, "'", "''") + "'") + ",");
    //            sb_value.Append("caFiledBy =" + this.caFiledBy + ",");
    //            sb_value.Append("caCreatedBy =" + this.caCreatedBy + ",");
    //            sb_value.Append("caStatus=" + (String.IsNullOrEmpty(this.caStatus) ? "''" : "N'" + Regex.Replace(this.caStatus, "'", "''") + "'"));

    //            String sqlCmd = "update CarFined set  " + sb_value.ToString() + "  where CarFinedTID = " + this.CarFinedTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.update() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "CarFined");
    //            if (ds.Tables["CarFined"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["CarFined"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarFined.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    #endregion sql

    //}

    
}


