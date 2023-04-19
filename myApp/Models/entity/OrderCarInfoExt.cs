using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class OrderCarInfoExt : OrderCarInfo
    //{
    //    public int createBackIdentity(int orderCarID, String carType, int carYear, long rentStartDate, int rentLength, int rentArriveHour, int rentArriveMinute, String rentArriveLocation, int pickAtMLocation, String journey, int returnHour, int returnMinute, int endHour, int endMinute, String withCarContactName, String withCarContactPhone, String withCarContactMobile, decimal price, int priceTour, int priceTip, int priceParking, int priceTax, decimal costTip, decimal costAccomodation, decimal priceInsurance, int insurancePaidBy, int withTourContract, int withTourQuotation, int withTourInvoice, int withTourReceipt, int withTourInsurace, int withTourSticker, int withTourPaymentAccount, int withTourSecurityCheck, int withTourCarDetails, int withTourOther, String withTourOtherMemo, String carAssign, int carDriver, String carGuide, String jobType, String status, int jobChecked, String carInfoInMemo, String carInfoExMemo)
    //    {
    //        String carDriverString = "NULL", carAssignString = "NULL";
    //        if (carDriver != -999)
    //            carDriverString = carDriver.ToString();
    //        if (carAssign != "-999" && carAssign != "")
    //            carAssignString = "'" + carAssign + "'";
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarInfo(orderCarID,carType,carYear,rentStartDate,rentLength,rentArriveHour,rentArriveMinute,rentArriveLocation,pickAtMLocation,journey,returnHour,returnMinute,endHour,endMinute,withCarContactName,withCarContactPhone,withCarContactMobile,price,priceTour,priceTip,priceParking,priceTax,costTip,costAccomodation,priceInsurance,insurancePaidBy,withTourContract,withTourQuotation,withTourInvoice,withTourReceipt,withTourInsurace,withTourSticker,withTourPaymentAccount,withTourSecurityCheck,withTourCarDetails,withTourOther,withTourOtherMemo,carAssign,carDriver,carGuide,jobType,status,jobChecked, carInfoInMemo, carInfoExMemo) values (" + orderCarID + ",'" + carType + "'," + carYear + "," + rentStartDate + "," + rentLength + "," + rentArriveHour + "," + rentArriveMinute + ",'" + rentArriveLocation + "'," + pickAtMLocation + ",'" + journey + "'," + returnHour + "," + returnMinute + "," + endHour + "," + endMinute + ",'" + withCarContactName + "','" + withCarContactPhone + "','" + withCarContactMobile + "'," + price + "," + priceTour + "," + priceTip + "," + priceParking + "," + priceTax + "," + costTip + "," + costAccomodation + "," + priceInsurance + "," + insurancePaidBy + "," + withTourContract + "," + withTourQuotation + "," + withTourInvoice + "," + withTourReceipt + "," + withTourInsurace + "," + withTourSticker + "," + withTourPaymentAccount + "," + withTourSecurityCheck + "," + withTourCarDetails + "," + withTourOther + ",'" + withTourOtherMemo + "'," + carAssignString + "," + carDriverString + ",'" + carGuide + "','" + jobType + "','" + status + "'," + jobChecked + ",'" + carInfoInMemo + "','" + carInfoExMemo + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.createBackIdentity() : " + e.ToString());
    //        }
    //        return insertID;
    //    }
    //    /*
    //    public int createBackIdentity(int orderCarID, String carType, int carYear, long rentStartDate, int rentLength, int rentArriveHour, int rentArriveMinute, String rentArriveLocation, int pickAtMLocation, String journey, String returnHour, String returnMinute, String endHour, String endMinute, String withCarContactName, String withCarContactPhone, String withCarContactMobile, double price, int priceTour, int priceTip, int priceParking, int priceTax, double costTip, double costAccomodation, double priceInsurance, int insurancePaidBy, int withTourContract, int withTourQuotation, int withTourInvoice, int withTourReceipt, int withTourInsurace, int withTourSticker, int withTourPaymentAccount, int withTourSecurityCheck, int withTourCarDetails, int withTourOther, String withTourOtherMemo, String carAssign, int carDriver, String carGuide, String jobType, String status, int jobChecked, String carInfoInMemo, String carInfoExMemo)
    //    {
    //        String carDriverString = "NULL", carAssignString = "NULL";
    //        if (carDriver != -999)
    //            carDriverString = carDriver.ToString();
    //        if (carAssign != "-999" && carAssign != "")
    //            carAssignString = "'" + carAssign + "'";
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarInfo(orderCarID,carType,carYear,rentStartDate,rentLength,rentArriveHour,rentArriveMinute,rentArriveLocation,pickAtMLocation,journey,returnHour,returnMinute,endHour,endMinute,withCarContactName,withCarContactPhone,withCarContactMobile,price,priceTour,priceTip,priceParking,priceTax,costTip,costAccomodation,priceInsurance,insurancePaidBy,withTourContract,withTourQuotation,withTourInvoice,withTourReceipt,withTourInsurace,withTourSticker,withTourPaymentAccount,withTourSecurityCheck,withTourCarDetails,withTourOther,withTourOtherMemo,carAssign,carDriver,carGuide,jobType,status,jobChecked, carInfoInMemo, carInfoExMemo) values (" + orderCarID + ",'" + carType + "'," + carYear + "," + rentStartDate + "," + rentLength + "," + rentArriveHour + "," + rentArriveMinute + ",'" + rentArriveLocation + "'," + pickAtMLocation + ",'" + journey + "'," + returnHour + "," + returnMinute + "," + endHour + "," + endMinute + ",'" + withCarContactName + "','" + withCarContactPhone + "','" + withCarContactMobile + "'," + price + "," + priceTour + "," + priceTip + "," + priceParking + "," + priceTax + "," + costTip + "," + costAccomodation + "," + priceInsurance + "," + insurancePaidBy + "," + withTourContract + "," + withTourQuotation + "," + withTourInvoice + "," + withTourReceipt + "," + withTourInsurace + "," + withTourSticker + "," + withTourPaymentAccount + "," + withTourSecurityCheck + "," + withTourCarDetails + "," + withTourOther + ",'" + withTourOtherMemo + "'," + carAssignString + "," + carDriverString + ",'" + carGuide + "','" + jobType + "','" + status + "'," + jobChecked + ",'" + carInfoInMemo + "','" + carInfoExMemo + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.createBackIdentity() : " + e.ToString());
    //        }
    //        return insertID;
    //    }
    //    */
    //    public int updateOrderCarInfo(int orderCarID, String carType, int carYear, long rentStartDate, int rentLength, int rentArriveHour, int rentArriveMinute, String rentArriveLocation, int pickAtMLocation, String journey, int returnHour, int returnMinute, int endHour, int endMinute, String withCarContactName, String withCarContactPhone, String withCarContactMobile, decimal price, int priceTour, int priceTip, int priceParking, int priceTax, decimal costTip, decimal costAccomodation, decimal priceInsurance, int insurancePaidBy, int withTourContract, int withTourQuotation, int withTourInvoice, int withTourReceipt, int withTourInsurace, int withTourSticker, int withTourPaymentAccount, int withTourSecurityCheck, int withTourCarDetails, int withTourOther, String withTourOtherMemo, String carAssign, int carDriver, String carGuide, String jobType, String status, int jobChecked, String carInfoInMemo, String carInfoExMemo)
    //    {
    //        String carDriverString = "NULL", carAssignString = "NULL";
    //        if (carDriver != -999)
    //            carDriverString = carDriver.ToString();
    //        if (carAssign != "-999")
    //            carAssignString = "'" + carAssign + "'";
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfo set orderCarID =" + orderCarID + ",carType ='" + carType + "',carYear =" + carYear + ",rentStartDate =" + rentStartDate + ",rentLength =" + rentLength + ",rentArriveHour =" + rentArriveHour + ",rentArriveMinute =" + rentArriveMinute + ",rentArriveLocation ='" + rentArriveLocation + "',pickAtMLocation =" + pickAtMLocation + ",journey ='" + journey + "',returnHour =" + returnHour + ",returnMinute =" + returnMinute + ",endHour =" + endHour + ",endMinute =" + endMinute + ",withCarContactName ='" + withCarContactName + "',withCarContactPhone ='" + withCarContactPhone + "',withCarContactMobile ='" + withCarContactMobile + "',price =" + price + ",priceTour =" + priceTour + ",priceTip =" + priceTip + ",priceParking =" + priceParking + ",priceTax =" + priceTax + ",costTip =" + costTip + ",costAccomodation =" + costAccomodation + ",priceInsurance =" + priceInsurance + ",insurancePaidBy =" + insurancePaidBy + ",withTourContract =" + withTourContract + ",withTourQuotation =" + withTourQuotation + ",withTourInvoice =" + withTourInvoice + ",withTourReceipt =" + withTourReceipt + ",withTourInsurace =" + withTourInsurace + ",withTourSticker =" + withTourSticker + ",withTourPaymentAccount =" + withTourPaymentAccount + ",withTourSecurityCheck =" + withTourSecurityCheck + ",withTourCarDetails =" + withTourCarDetails + ",withTourOther =" + withTourOther + ",withTourOtherMemo ='" + withTourOtherMemo + "',carAssign =" + carAssignString + ",carDriver =" + carDriverString + ",carGuide ='" + carGuide + "',jobType ='" + jobType + "',status ='" + status + "',jobChecked =" + jobChecked + ",carInfoInMemo ='" + carInfoInMemo + "',carInfoExMemo ='" + carInfoExMemo + "' where orderCarInfoTID = " + this.orderCarInfoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.updateOrderCarInfo() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    //Regular固定訂單的用車資料
    //    public int createRegular(int orderCarID, String carType, long rentStartDate, int rentArriveHour, int rentArriveMinute, String rentArriveLocation, String status)
    //    {
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarInfo(orderCarID,carType,carYear,rentStartDate,rentLength,rentArriveHour,rentArriveMinute,rentArriveLocation,pickAtMLocation,journey,returnHour,returnMinute,endHour,endMinute,withCarContactName,withCarContactPhone,withCarContactMobile,price,priceTour,priceTip,priceParking,priceTax,costTip,costAccomodation,priceInsurance,insurancePaidBy,withTourContract,withTourQuotation,withTourInvoice,withTourReceipt,withTourInsurace,withTourSticker,withTourPaymentAccount,withTourSecurityCheck,withTourCarDetails,withTourOther,withTourOtherMemo,carAssign,carDriver,carGuide,jobType,status) values (" + orderCarID + ",'" + carType + "',NULL," + rentStartDate + ",NULL," + rentArriveHour + "," + rentArriveMinute + ",'" + rentArriveLocation + "',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'" + status + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.createRegular() : " + e.ToString());
    //        }
    //        return insertID;
    //    }
    //    public int createRegularfast(DataTable dt)
    //    {
    //        int insertID = 0;
    //        String sqlCmd;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            for (int i = 0; i < dt.Rows.Count; i++)
    //            {
    //                sqlCmd = "insert into OrderCarInfo(orderCarID,carType,carYear,rentStartDate,rentLength,rentArriveHour,rentArriveMinute,rentArriveLocation,pickAtMLocation,journey,returnHour,returnMinute,endHour,endMinute,withCarContactName,withCarContactPhone,withCarContactMobile,price,priceTour,priceTip,priceParking,priceTax,costTip,costAccomodation,priceInsurance,insurancePaidBy,withTourContract,withTourQuotation,withTourInvoice,withTourReceipt,withTourInsurace,withTourSticker,withTourPaymentAccount,withTourSecurityCheck,withTourCarDetails,withTourOther,withTourOtherMemo,carAssign,carDriver,carGuide,jobType,status) values (" + dt.Rows[i]["id"] + ",'" + dt.Rows[i]["type"] + "',NULL," + dt.Rows[i]["date"] + ",NULL," + dt.Rows[i]["hour"] + "," + dt.Rows[i]["min"] + ",'" + dt.Rows[i]["locate"] + "',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'" + dt.Rows[i]["prepare"] + "')";
    //                insertID = my.insertBackIdentity(sqlCmd);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.createRegular() : " + e.ToString());
    //        }
    //        return insertID;
    //    }

    //    //Regular修改固定訂單的用車資料
    //    public int updateRegularOrderCarInfo(int orderCarID, String carType, long rentStartDate, int rentArriveHour, int rentArriveMinute, String rentArriveLocation, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfo set orderCarID =" + orderCarID + ",carType ='" + carType + "',rentStartDate =" + rentStartDate + ",rentArriveHour =" + rentArriveHour + ",rentArriveMinute =" + rentArriveMinute + ",rentArriveLocation ='" + rentArriveLocation + "',status ='" + status + "' where orderCarInfoTID = " + this.orderCarInfoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.updateRegularOrderCarInfo() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    //Regular批次修改固定訂單的用車資料
    //    public int eOrderCarInfo(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            //String sqlCmd = "update OrderCarInfo set orderCarID =" + orderCarID + ",carType ='" + carType + "',rentStartDate =" + rentStartDate + ",rentArriveHour =" + rentArriveHour + ",rentArriveMinute =" + rentArriveMinute + ",rentArriveLocation ='" + rentArriveLocation + "',status ='" + status + "' where orderCarInfoTID = " + this.orderCarInfoTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.eOrderCarInfo() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    //Regular批次刪除固定訂單的用車資料
    //    public int dOrderCarInfo(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            //String sqlCmd = "update OrderCarInfo set orderCarID =" + orderCarID + ",carType ='" + carType + "',rentStartDate =" + rentStartDate + ",rentArriveHour =" + rentArriveHour + ",rentArriveMinute =" + rentArriveMinute + ",rentArriveLocation ='" + rentArriveLocation + "',status ='" + status + "' where orderCarInfoTID = " + this.orderCarInfoTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.dOrderCarInfo() : " + e.ToString());
    //        }
    //        return count;
    //    }

    //    public void deleteOrderCarInfoFromId(string orderCarInfoID)
    //    {
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete OrderCarInfo where orderCarInfoTID =" + orderCarInfoID;
    //            my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoExt.deleteOrderCarInfoFromId() : " + e.ToString());
    //        }
    //    }


    //}
}