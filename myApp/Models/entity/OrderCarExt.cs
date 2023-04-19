using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

using Howgreater.util;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class OrderCarExt : OrderCar //新增OrderCar並回傳OrderCar.orderIrregularTID
    //{
    //    public int createBackIdentity(int inTouchBy, int inChargeBy, int createBy, long createDatetime, long lastUpdateDatetime, int lastUpdateBy, int custID, int custContactID, String custContactName, String custContactPhone, String custContactMobile, String custContactFax, String orderSource, String orderType, int payByCash, int payByTransfer, int payByInfo, int payTermMonthly, int payPaid, String payWith, double payAmountShow, int payToCustUniCode, String extraDocument, String memoExternal, String memoInternal, String status)
    //    {
    //        String payToCustUniCodeString = "NULL";
    //        if (payToCustUniCode != -999)
    //            payToCustUniCodeString = payToCustUniCode.ToString();
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCar(inTouchBy,inChargeBy,createBy,createDatetime,lastUpdateDatetime,lastUpdateBy,custID,custContactID,custContactName,custContactPhone,custContactMobile,custContactFax,orderSource,orderType,payByCash,payByTransfer,payByInfo,payTermMonthly,payPaid,payWith,payAmountShow,payToCustUniCode,extraDocument,memoExternal,memoInternal,regu_contractStart,regu_contractEnd,status) values (" + inTouchBy + "," + inChargeBy + "," + createBy + "," + createDatetime + "," + lastUpdateDatetime + "," + lastUpdateBy + "," + custID + "," + custContactID + ",'" + custContactName + "','" + custContactPhone + "','" + custContactMobile + "','" + custContactFax + "','" + orderSource + "','" + orderType + "'," + payByCash + "," + payByTransfer + "," + payByInfo + "," + payTermMonthly + "," + payPaid + ",'" + payWith + "'," + payAmountShow + "," + payToCustUniCodeString + ",'" + extraDocument + "','" + memoExternal + "','" + memoInternal + "',NULL,NULL,'" + status + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarExt.createBackIdentity() : " + e.ToString());
    //        }
    //        return insertID;
    //    }
    //    //不更改long regu_contractStart, long regu_contractEnd, 
    //    public int updateIrregular(int inTouchBy, int inChargeBy, int createBy, long createDatetime, long lastUpdateDatetime, int lastUpdateBy, int custID, int custContactID, String custContactName, String custContactPhone, String custContactMobile, String custContactFax, String orderSource, String orderType, int payByCash, int payByTransfer, int payByInfo, int payTermMonthly, int payPaid, String payWith, double payAmountShow, int payToCustUniCode, String extraDocument, String memoExternal, String memoInternal, String status)
    //    {
    //        String payToCustUniCodeString = "NULL";
    //        if (payToCustUniCode != -999)
    //            payToCustUniCodeString = payToCustUniCode.ToString();
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCar set inTouchBy =" + inTouchBy + ",inChargeBy =" + inChargeBy + ",createBy =" + createBy + ",createDatetime =" + createDatetime + ",lastUpdateDatetime =" + lastUpdateDatetime + ",lastUpdateBy =" + lastUpdateBy + ",custID =" + custID + ",custContactID =" + custContactID + ",custContactName ='" + custContactName + "',custContactPhone ='" + custContactPhone + "',custContactMobile ='" + custContactMobile + "',custContactFax ='" + custContactFax + "',orderSource ='" + orderSource + "',orderType ='" + orderType + "',payByCash =" + payByCash + ",payByTransfer =" + payByTransfer + ",payByInfo =" + payByInfo + ",payTermMonthly =" + payTermMonthly + ",payPaid =" + payPaid + ",payWith ='" + payWith + "',payAmountShow =" + payAmountShow + ",payToCustUniCode =" + payToCustUniCodeString + ",extraDocument ='" + extraDocument + "',memoExternal ='" + memoExternal + "',memoInternal ='" + memoInternal + "',status ='" + status + "' where orderTID = " + this.orderTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.updateIrregular() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    //固定訂單Regular
    //    public int createRegularBackIdentity(int createBy, long createDatetime, long lastUpdateDatetime, int lastUpdateBy, int custID, int custContactID, String custContactName, String custContactPhone, String custContactMobile, String custContactFax, long regu_contractStart, long regu_contractEnd, String status, Double payAmountShow)
    //    {
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCar(inTouchBy,inChargeBy,createBy,createDatetime,lastUpdateDatetime,lastUpdateBy,custID,custContactID,custContactName,custContactPhone,custContactMobile,custContactFax,orderSource,orderType,payByCash,payByTransfer,payByInfo,payTermMonthly,payPaid,payWith,payAmountShow,payToCustUniCode,extraDocument,memoExternal,memoInternal,regu_contractStart,regu_contractEnd,status) values (NULL,NULL," + createBy + "," + createDatetime + "," + lastUpdateDatetime + "," + lastUpdateBy + "," + custID + "," + custContactID + ",'" + custContactName + "','" + custContactPhone + "','" + custContactMobile + "','" + custContactFax + "','Regular',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'" + payAmountShow + "',NULL,NULL,NULL,NULL," + regu_contractStart + "," + regu_contractEnd + ",'" + status + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarExt.createRegularBackIdentity() : " + e.ToString());
    //        }
    //        return insertID;
    //    }
    //    //update固定訂單Regular 
    //    public int updateRegular(int createBy, long createDatetime, long lastUpdateDatetime, int lastUpdateBy, int custID, int custContactID, String custContactName, String custContactPhone, String custContactMobile, String custContactFax, long regu_contractStart, long regu_contractEnd, String status, Double payAmountShow)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCar set createBy =" + createBy + ",createDatetime =" + createDatetime + ",lastUpdateDatetime =" + lastUpdateDatetime + ",lastUpdateBy =" + lastUpdateBy + ",custID =" + custID + ",custContactID =" + custContactID + ",custContactName ='" + custContactName + "',custContactPhone ='" + custContactPhone + "',custContactMobile ='" + custContactMobile + "',custContactFax ='" + custContactFax + "',regu_contractStart =" + regu_contractStart + ",regu_contractEnd =" + regu_contractEnd + ",status ='" + status + "',payAmountShow=" + payAmountShow + " where orderTID = " + this.orderTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.updateRegular() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}