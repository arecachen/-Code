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
    //[MetadataType(typeof(OrderCarInfoMetadata))]
    //public partial class OrderCarInfo
    //{

    //    public Collection<OrderCarInfo> findAll()
    //    {
    //        Collection<OrderCarInfo> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderCarInfo order by orderCarInfoTID asc", "OrderCarInfo");
    //            if (ds.Tables["OrderCarInfo"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarInfo>();
    //                foreach (DataRow dr in ds.Tables["OrderCarInfo"].Rows)
    //                {
    //                    OrderCarInfo am = new OrderCarInfo();
    //                    am.orderCarInfoTID = Convert.ToInt32(dr["orderCarInfoTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.carYear = dr["carYear"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carYear"]);
    //                    am.rentStartDate = dr["rentStartDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["rentStartDate"]);
    //                    am.rentLength = dr["rentLength"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentLength"]);
    //                    am.rentArriveHour = dr["rentArriveHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentArriveHour"]);
    //                    am.rentArriveMinute = dr["rentArriveMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentArriveMinute"]);
    //                    am.rentArriveLocation = Convert.ToString(dr["rentArriveLocation"]);
    //                    am.pickAtMLocation = dr["pickAtMLocation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["pickAtMLocation"]);
    //                    am.journey = Convert.ToString(dr["journey"]);
    //                    am.returnHour = dr["returnHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["returnHour"]);
    //                    am.returnMinute = dr["returnMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["returnMinute"]);
    //                    am.endHour = dr["endHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["endHour"]);
    //                    am.endMinute = dr["endMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["endMinute"]);
    //                    am.withCarContactName = Convert.ToString(dr["withCarContactName"]);
    //                    am.withCarContactPhone = Convert.ToString(dr["withCarContactPhone"]);
    //                    am.withCarContactMobile = Convert.ToString(dr["withCarContactMobile"]);
    //                    am.price = dr["price"] == DBNull.Value ? -999 : Convert.ToInt32(dr["price"]);
    //                    am.priceTour = dr["priceTour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTour"]);
    //                    am.priceTip = dr["priceTip"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTip"]);
    //                    am.priceParking = dr["priceParking"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceParking"]);
    //                    am.priceTax = dr["priceTax"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTax"]);
    //                    am.costTip = dr["costTip"] == DBNull.Value ? -999 : Convert.ToInt32(dr["costTip"]);
    //                    am.costAccomodation = dr["costAccomodation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["costAccomodation"]);
    //                    am.priceInsurance = dr["priceInsurance"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceInsurance"]);
    //                    am.insurancePaidBy = dr["insurancePaidBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["insurancePaidBy"]);
    //                    am.withTourContract = dr["withTourContract"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourContract"]);
    //                    am.withTourQuotation = dr["withTourQuotation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourQuotation"]);
    //                    am.withTourInvoice = dr["withTourInvoice"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourInvoice"]);
    //                    am.withTourReceipt = dr["withTourReceipt"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourReceipt"]);
    //                    am.withTourInsurace = dr["withTourInsurace"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourInsurace"]);
    //                    am.withTourSticker = dr["withTourSticker"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourSticker"]);
    //                    am.withTourPaymentAccount = dr["withTourPaymentAccount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourPaymentAccount"]);
    //                    am.withTourSecurityCheck = dr["withTourSecurityCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourSecurityCheck"]);
    //                    am.withTourCarDetails = dr["withTourCarDetails"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourCarDetails"]);
    //                    am.withTourOther = dr["withTourOther"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourOther"]);
    //                    am.withTourOtherMemo = Convert.ToString(dr["withTourOtherMemo"]);
    //                    am.carAssign = Convert.ToString(dr["carAssign"]);
    //                    am.carDriver = dr["carDriver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carDriver"]);
    //                    am.carGuide = Convert.ToString(dr["carGuide"]);
    //                    am.jobType = Convert.ToString(dr["jobType"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.jobChecked = Convert.ToInt32(dr["jobChecked"]);
    //                    am.carInfoInMemo = Convert.ToString(dr["carInfoInMemo"]);
    //                    am.carInfoExMemo = Convert.ToString(dr["carInfoExMemo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarInfo> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarInfo> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfo");
    //            if (ds.Tables["OrderCarInfo"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarInfo>();
    //                foreach (DataRow dr in ds.Tables["OrderCarInfo"].Rows)
    //                {
    //                    OrderCarInfo am = new OrderCarInfo();
    //                    am.orderCarInfoTID = Convert.ToInt32(dr["orderCarInfoTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.carType = Convert.ToString(dr["carType"]);
    //                    am.carYear = dr["carYear"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carYear"]);
    //                    am.rentStartDate = dr["rentStartDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["rentStartDate"]);
    //                    am.rentLength = dr["rentLength"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentLength"]);
    //                    am.rentArriveHour = dr["rentArriveHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentArriveHour"]);
    //                    am.rentArriveMinute = dr["rentArriveMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentArriveMinute"]);
    //                    am.rentArriveLocation = Convert.ToString(dr["rentArriveLocation"]);
    //                    am.pickAtMLocation = dr["pickAtMLocation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["pickAtMLocation"]);
    //                    am.journey = Convert.ToString(dr["journey"]);
    //                    am.returnHour = dr["returnHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["returnHour"]);
    //                    am.returnMinute = dr["returnMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["returnMinute"]);
    //                    am.endHour = dr["endHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["endHour"]);
    //                    am.endMinute = dr["endMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["endMinute"]);
    //                    am.withCarContactName = Convert.ToString(dr["withCarContactName"]);
    //                    am.withCarContactPhone = Convert.ToString(dr["withCarContactPhone"]);
    //                    am.withCarContactMobile = Convert.ToString(dr["withCarContactMobile"]);
    //                    am.price = dr["price"] == DBNull.Value ? -999 : Convert.ToInt32(dr["price"]);
    //                    am.priceTour = dr["priceTour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTour"]);
    //                    am.priceTip = dr["priceTip"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTip"]);
    //                    am.priceParking = dr["priceParking"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceParking"]);
    //                    am.priceTax = dr["priceTax"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTax"]);
    //                    am.costTip = dr["costTip"] == DBNull.Value ? -999 : Convert.ToInt32(dr["costTip"]);
    //                    am.costAccomodation = dr["costAccomodation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["costAccomodation"]);
    //                    am.priceInsurance = dr["priceInsurance"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceInsurance"]);
    //                    am.insurancePaidBy = dr["insurancePaidBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["insurancePaidBy"]);
    //                    am.withTourContract = dr["withTourContract"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourContract"]);
    //                    am.withTourQuotation = dr["withTourQuotation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourQuotation"]);
    //                    am.withTourInvoice = dr["withTourInvoice"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourInvoice"]);
    //                    am.withTourReceipt = dr["withTourReceipt"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourReceipt"]);
    //                    am.withTourInsurace = dr["withTourInsurace"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourInsurace"]);
    //                    am.withTourSticker = dr["withTourSticker"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourSticker"]);
    //                    am.withTourPaymentAccount = dr["withTourPaymentAccount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourPaymentAccount"]);
    //                    am.withTourSecurityCheck = dr["withTourSecurityCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourSecurityCheck"]);
    //                    am.withTourCarDetails = dr["withTourCarDetails"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourCarDetails"]);
    //                    am.withTourOther = dr["withTourOther"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourOther"]);
    //                    am.withTourOtherMemo = Convert.ToString(dr["withTourOtherMemo"]);
    //                    am.carAssign = Convert.ToString(dr["carAssign"]);
    //                    am.carDriver = dr["carDriver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carDriver"]);
    //                    am.carGuide = Convert.ToString(dr["carGuide"]);
    //                    am.jobType = Convert.ToString(dr["jobType"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.jobChecked = Convert.ToInt32(dr["jobChecked"]);
    //                    am.carInfoInMemo = Convert.ToString(dr["carInfoInMemo"]);
    //                    am.carInfoExMemo = Convert.ToString(dr["carInfoExMemo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarInfo findByPrimaryKey(int orderCarInfoTID)
    //    {
    //        OrderCarInfo am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarInfo a WHERE a.orderCarInfoTID = " + orderCarInfoTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfo");
    //            if (ds.Tables["OrderCarInfo"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarInfo"].Rows[0];
    //                am = new OrderCarInfo();
    //                am.orderCarInfoTID = Convert.ToInt32(dr["orderCarInfoTID"]);
    //                am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                am.carType = Convert.ToString(dr["carType"]);
    //                am.carYear = dr["carYear"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carYear"]);
    //                am.rentStartDate = dr["rentStartDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["rentStartDate"]);
    //                am.rentLength = dr["rentLength"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentLength"]);
    //                am.rentArriveHour = dr["rentArriveHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentArriveHour"]);
    //                am.rentArriveMinute = dr["rentArriveMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["rentArriveMinute"]);
    //                am.rentArriveLocation = Convert.ToString(dr["rentArriveLocation"]);
    //                am.pickAtMLocation = dr["pickAtMLocation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["pickAtMLocation"]);
    //                am.journey = Convert.ToString(dr["journey"]);
    //                am.returnHour = dr["returnHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["returnHour"]);
    //                am.returnMinute = dr["returnMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["returnMinute"]);
    //                am.endHour = dr["endHour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["endHour"]);
    //                am.endMinute = dr["endMinute"] == DBNull.Value ? -999 : Convert.ToInt32(dr["endMinute"]);
    //                am.withCarContactName = Convert.ToString(dr["withCarContactName"]);
    //                am.withCarContactPhone = Convert.ToString(dr["withCarContactPhone"]);
    //                am.withCarContactMobile = Convert.ToString(dr["withCarContactMobile"]);
    //                am.price = dr["price"] == DBNull.Value ? -999 : Convert.ToInt32(dr["price"]);
    //                am.priceTour = dr["priceTour"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTour"]);
    //                am.priceTip = dr["priceTip"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTip"]);
    //                am.priceParking = dr["priceParking"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceParking"]);
    //                am.priceTax = dr["priceTax"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceTax"]);
    //                am.costTip = dr["costTip"] == DBNull.Value ? -999 : Convert.ToInt32(dr["costTip"]);
    //                am.costAccomodation = dr["costAccomodation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["costAccomodation"]);
    //                am.priceInsurance = dr["priceInsurance"] == DBNull.Value ? -999 : Convert.ToInt32(dr["priceInsurance"]);
    //                am.insurancePaidBy = dr["insurancePaidBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["insurancePaidBy"]);
    //                am.withTourContract = dr["withTourContract"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourContract"]);
    //                am.withTourQuotation = dr["withTourQuotation"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourQuotation"]);
    //                am.withTourInvoice = dr["withTourInvoice"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourInvoice"]);
    //                am.withTourReceipt = dr["withTourReceipt"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourReceipt"]);
    //                am.withTourInsurace = dr["withTourInsurace"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourInsurace"]);
    //                am.withTourSticker = dr["withTourSticker"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourSticker"]);
    //                am.withTourPaymentAccount = dr["withTourPaymentAccount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourPaymentAccount"]);
    //                am.withTourSecurityCheck = dr["withTourSecurityCheck"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourSecurityCheck"]);
    //                am.withTourCarDetails = dr["withTourCarDetails"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourCarDetails"]);
    //                am.withTourOther = dr["withTourOther"] == DBNull.Value ? -999 : Convert.ToInt32(dr["withTourOther"]);
    //                am.withTourOtherMemo = Convert.ToString(dr["withTourOtherMemo"]);
    //                am.carAssign = Convert.ToString(dr["carAssign"]);
    //                am.carDriver = dr["carDriver"] == DBNull.Value ? -999 : Convert.ToInt32(dr["carDriver"]);
    //                am.carGuide = Convert.ToString(dr["carGuide"]);
    //                am.jobType = Convert.ToString(dr["jobType"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.jobChecked = Convert.ToInt32(dr["jobChecked"]);
    //                am.carInfoInMemo = Convert.ToString(dr["carInfoInMemo"]);
    //                am.carInfoExMemo = Convert.ToString(dr["carInfoExMemo"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarID, String carType, int carYear, long rentStartDate, int rentLength, int rentArriveHour, int rentArriveMinute, String rentArriveLocation, int pickAtMLocation, String journey, int returnHour, int returnMinute, int endHour, int endMinute, String withCarContactName, String withCarContactPhone, String withCarContactMobile, double price, int priceTour, int priceTip, int priceParking, int priceTax, double costTip, double costAccomodation, double priceInsurance, int insurancePaidBy, int withTourContract, int withTourQuotation, int withTourInvoice, int withTourReceipt, int withTourInsurace, int withTourSticker, int withTourPaymentAccount, int withTourSecurityCheck, int withTourCarDetails, int withTourOther, String withTourOtherMemo, String carAssign, int carDriver, String carGuide, String jobType, String status, int jobChecked, String carInfoInMemo, String carInfoExMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarInfo(orderCarID,carType,carYear,rentStartDate,rentLength,rentArriveHour,rentArriveMinute,rentArriveLocation,pickAtMLocation,journey,returnHour,returnMinute,endHour,endMinute,withCarContactName,withCarContactPhone,withCarContactMobile,price,priceTour,priceTip,priceParking,priceTax,costTip,costAccomodation,priceInsurance,insurancePaidBy,withTourContract,withTourQuotation,withTourInvoice,withTourReceipt,withTourInsurace,withTourSticker,withTourPaymentAccount,withTourSecurityCheck,withTourCarDetails,withTourOther,withTourOtherMemo,carAssign,carDriver,carGuide,jobType,status,jobChecked,carInfoInMemo,carInfoExMemo) values (" + orderCarID + ",'" + carType + "'," + carYear + "," + rentStartDate + "," + rentLength + "," + rentArriveHour + "," + rentArriveMinute + ",N'" + rentArriveLocation + "'," + pickAtMLocation + ",N'" + journey + "'," + returnHour + "," + returnMinute + "," + endHour + "," + endMinute + ",'" + withCarContactName + "','" + withCarContactPhone + "','" + withCarContactMobile + "'," + price + "," + priceTour + "," + priceTip + "," + priceParking + "," + priceTax + "," + costTip + "," + costAccomodation + "," + priceInsurance + "," + insurancePaidBy + "," + withTourContract + "," + withTourQuotation + "," + withTourInvoice + "," + withTourReceipt + "," + withTourInsurace + "," + withTourSticker + "," + withTourPaymentAccount + "," + withTourSecurityCheck + "," + withTourCarDetails + "," + withTourOther + ",'" + withTourOtherMemo + "','" + carAssign + "'," + carDriver + ",'" + carGuide + "','" + jobType + "','" + status + "'," + jobChecked + ",'" + carInfoInMemo + "','" + carInfoExMemo + "')";
    //            count = my.insert(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int orderCarInfoTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderCarInfo where orderCarInfoTID = " + orderCarInfoTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarID, String carType, int carYear, long rentStartDate, int rentLength, int rentArriveHour, int rentArriveMinute, String rentArriveLocation, int pickAtMLocation, String journey, int returnHour, int returnMinute, int endHour, int endMinute, String withCarContactName, String withCarContactPhone, String withCarContactMobile, double price, int priceTour, int priceTip, int priceParking, int priceTax, double costTip, double costAccomodation, double priceInsurance, int insurancePaidBy, int withTourContract, int withTourQuotation, int withTourInvoice, int withTourReceipt, int withTourInsurace, int withTourSticker, int withTourPaymentAccount, int withTourSecurityCheck, int withTourCarDetails, int withTourOther, String withTourOtherMemo, String carAssign, int carDriver, String carGuide, String jobType, String status, int jobChecked, String carInfoInMemo, String carInfoExMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfo set orderCarID =" + orderCarID + ",carType ='" + carType + "',carYear =" + carYear + ",rentStartDate =" + rentStartDate + ",rentLength =" + rentLength + ",rentArriveHour =" + rentArriveHour + ",rentArriveMinute =" + rentArriveMinute + ",rentArriveLocation ='" + rentArriveLocation + "',pickAtMLocation =" + pickAtMLocation + ",journey ='" + journey + "',returnHour =" + returnHour + ",returnMinute =" + returnMinute + ",endHour =" + endHour + ",endMinute =" + endMinute + ",withCarContactName ='" + withCarContactName + "',withCarContactPhone ='" + withCarContactPhone + "',withCarContactMobile ='" + withCarContactMobile + "',price =" + price + ",priceTour =" + priceTour + ",priceTip =" + priceTip + ",priceParking =" + priceParking + ",priceTax =" + priceTax + ",costTip =" + costTip + ",costAccomodation =" + costAccomodation + ",priceInsurance =" + priceInsurance + ",insurancePaidBy =" + insurancePaidBy + ",withTourContract =" + withTourContract + ",withTourQuotation =" + withTourQuotation + ",withTourInvoice =" + withTourInvoice + ",withTourReceipt =" + withTourReceipt + ",withTourInsurace =" + withTourInsurace + ",withTourSticker =" + withTourSticker + ",withTourPaymentAccount =" + withTourPaymentAccount + ",withTourSecurityCheck =" + withTourSecurityCheck + ",withTourCarDetails =" + withTourCarDetails + ",withTourOther =" + withTourOther + ",withTourOtherMemo ='" + withTourOtherMemo + "',carAssign ='" + carAssign + "',carDriver =" + carDriver + ",carGuide ='" + carGuide + "',jobType ='" + jobType + "',status ='" + status + "',jobChecked =" + jobChecked + ",carInfoInMemo ='" + carInfoInMemo + "',carInfoExMemo ='" + carInfoExMemo + "' where orderCarInfoTID = " + this.orderCarInfoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfo set orderCarID =" + this.orderCarID + ",carType ='" + this.carType + "',carYear =" + this.carYear + ",rentStartDate =" + this.rentStartDate + ",rentLength =" + this.rentLength + ",rentArriveHour =" + this.rentArriveHour + ",rentArriveMinute =" + this.rentArriveMinute + ",rentArriveLocation ='" + this.rentArriveLocation + "',pickAtMLocation =" + this.pickAtMLocation + ",journey ='" + this.journey + "',returnHour =" + this.returnHour + ",returnMinute =" + this.returnMinute + ",endHour =" + this.endHour + ",endMinute =" + this.endMinute + ",withCarContactName ='" + this.withCarContactName + "',withCarContactPhone ='" + this.withCarContactPhone + "',withCarContactMobile ='" + this.withCarContactMobile + "',price =" + this.price + ",priceTour =" + this.priceTour + ",priceTip =" + this.priceTip + ",priceParking =" + this.priceParking + ",priceTax =" + this.priceTax + ",costTip =" + this.costTip + ",costAccomodation =" + this.costAccomodation + ",priceInsurance =" + this.priceInsurance + ",insurancePaidBy =" + this.insurancePaidBy + ",withTourContract =" + this.withTourContract + ",withTourQuotation =" + this.withTourQuotation + ",withTourInvoice =" + this.withTourInvoice + ",withTourReceipt =" + this.withTourReceipt + ",withTourInsurace =" + this.withTourInsurace + ",withTourSticker =" + this.withTourSticker + ",withTourPaymentAccount =" + this.withTourPaymentAccount + ",withTourSecurityCheck =" + this.withTourSecurityCheck + ",withTourCarDetails =" + this.withTourCarDetails + ",withTourOther =" + this.withTourOther + ",withTourOtherMemo ='" + this.withTourOtherMemo + "',carAssign ='" + this.carAssign + "',carDriver =" + this.carDriver + ",carGuide ='" + this.carGuide + "',jobType ='" + this.jobType + "',status ='" + this.status + "',jobChecked =" + this.jobChecked + ",carInfoInMemo ='" + this.carInfoInMemo + "',carInfoExMemo ='" + this.carInfoExMemo + "' where orderCarInfoTID = " + this.orderCarInfoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfo");
    //            if (ds.Tables["OrderCarInfo"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarInfo"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfo.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
    //public class OrderCarInfoMetadata
    //{
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<CarAppointment> CarAppointment { get; set; }
    //    public virtual OrderCar OrderCar { get; set; }
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<OrderCarInfoPassenger_del> OrderCarInfoPassenger_del { get; set; }
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<OrderCarInfoPayRecord> OrderCarInfoPayRecord { get; set; }
    //    [JsonIgnore]
    //    [IgnoreDataMember]
    //    public virtual ICollection<OrderCarInfoWithEquip> OrderCarInfoWithEquip { get; set; }
    //}
}


