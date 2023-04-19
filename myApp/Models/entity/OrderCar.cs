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
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[MetadataType(typeof(OrderCarMetadata))]
    //public partial class OrderCar
    //{       
     
        #region SQL
        //public Collection<OrderCar> findAll()
        //{
        //    Collection<OrderCar> c = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        DataSet ds = my.select("select * from OrderCar order by orderTID asc", "OrderCar");
        //        if (ds.Tables["OrderCar"].Rows.Count > 0)
        //        {
        //            c = new Collection<OrderCar>();
        //            foreach (DataRow dr in ds.Tables["OrderCar"].Rows)
        //            {
        //                OrderCar am = new OrderCar();
        //                am.orderTID = Convert.ToInt32(dr["orderTID"]);
        //                am.inTouchBy = dr["inTouchBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inTouchBy"]);
        //                am.inChargeBy = dr["inChargeBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inChargeBy"]);
        //                am.createBy = dr["createBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["createBy"]);
        //                am.createDatetime = Convert.ToInt64(dr["createDatetime"]);
        //                am.lastUpdateDatetime = dr["lastUpdateDatetime"] == DBNull.Value ? -999 : Convert.ToInt64(dr["lastUpdateDatetime"]);
        //                am.lastUpdateBy = dr["lastUpdateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["lastUpdateBy"]);
        //                am.custID = Convert.ToInt32(dr["custID"]);
        //                am.custContactID = Convert.ToInt32(dr["custContactID"]);
        //                am.custContactName = Convert.ToString(dr["custContactName"]);
        //                am.custContactPhone = Convert.ToString(dr["custContactPhone"]);
        //                am.custContactMobile = Convert.ToString(dr["custContactMobile"]);
        //                am.custContactFax = Convert.ToString(dr["custContactFax"]);
        //                am.orderSource = Convert.ToString(dr["orderSource"]);
        //                am.orderType = Convert.ToString(dr["orderType"]);
        //                am.payByCash = dr["payByCash"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByCash"]);
        //                am.payByTransfer = dr["payByTransfer"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByTransfer"]);
        //                am.payByInfo = dr["payByInfo"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByInfo"]);
        //                am.payTermMonthly = dr["payTermMonthly"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payTermMonthly"]);
        //                am.payPaid = dr["payPaid"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payPaid"]);
        //                am.payWith = Convert.ToString(dr["payWith"]);
        //                am.payAmountShow = dr["payAmountShow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payAmountShow"]);
        //                am.payToCustUniCode = dr["payToCustUniCode"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payToCustUniCode"]);
        //                am.extraDocument = Convert.ToString(dr["extraDocument"]);
        //                am.memoExternal = Convert.ToString(dr["memoExternal"]);
        //                am.memoInternal = Convert.ToString(dr["memoInternal"]);
        //                am.regu_contractStart = dr["regu_contractStart"] == DBNull.Value ? -999 : Convert.ToInt64(dr["regu_contractStart"]);
        //                am.regu_contractEnd = dr["regu_contractEnd"] == DBNull.Value ? -999 : Convert.ToInt64(dr["regu_contractEnd"]);
        //                am.status = Convert.ToString(dr["status"]);
        //                c.Add(am);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.findAll() : " + e.ToString());
        //    }
        //    return c;
        //}


        //public Collection<OrderCar> findByKeyword(String sqlCmd)
        //{
        //    Collection<OrderCar> c = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        DataSet ds = my.select(sqlCmd, "OrderCar");
        //        if (ds.Tables["OrderCar"].Rows.Count > 0)
        //        {
        //            c = new Collection<OrderCar>();
        //            foreach (DataRow dr in ds.Tables["OrderCar"].Rows)
        //            {
        //                OrderCar am = new OrderCar();
        //                am.orderTID = Convert.ToInt32(dr["orderTID"]);
        //                am.inTouchBy = dr["inTouchBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inTouchBy"]);
        //                am.inChargeBy = dr["inChargeBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inChargeBy"]);
        //                am.createBy = dr["createBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["createBy"]);
        //                am.createDatetime = Convert.ToInt64(dr["createDatetime"]);
        //                am.lastUpdateDatetime = dr["lastUpdateDatetime"] == DBNull.Value ? -999 : Convert.ToInt64(dr["lastUpdateDatetime"]);
        //                am.lastUpdateBy = dr["lastUpdateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["lastUpdateBy"]);
        //                am.custID = Convert.ToInt32(dr["custID"]);
        //                am.custContactID = Convert.ToInt32(dr["custContactID"]);
        //                am.custContactName = Convert.ToString(dr["custContactName"]);
        //                am.custContactPhone = Convert.ToString(dr["custContactPhone"]);
        //                am.custContactMobile = Convert.ToString(dr["custContactMobile"]);
        //                am.custContactFax = Convert.ToString(dr["custContactFax"]);
        //                am.orderSource = Convert.ToString(dr["orderSource"]);
        //                am.orderType = Convert.ToString(dr["orderType"]);
        //                am.payByCash = dr["payByCash"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByCash"]);
        //                am.payByTransfer = dr["payByTransfer"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByTransfer"]);
        //                am.payByInfo = dr["payByInfo"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByInfo"]);
        //                am.payTermMonthly = dr["payTermMonthly"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payTermMonthly"]);
        //                am.payPaid = dr["payPaid"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payPaid"]);
        //                am.payWith = Convert.ToString(dr["payWith"]);
        //                am.payAmountShow = dr["payAmountShow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payAmountShow"]);
        //                am.payToCustUniCode = dr["payToCustUniCode"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payToCustUniCode"]);
        //                am.extraDocument = Convert.ToString(dr["extraDocument"]);
        //                am.memoExternal = Convert.ToString(dr["memoExternal"]);
        //                am.memoInternal = Convert.ToString(dr["memoInternal"]);
        //                am.regu_contractStart = dr["regu_contractStart"] == DBNull.Value ? -999 : Convert.ToInt64(dr["regu_contractStart"]);
        //                am.regu_contractEnd = dr["regu_contractEnd"] == DBNull.Value ? -999 : Convert.ToInt64(dr["regu_contractEnd"]);
        //                am.status = Convert.ToString(dr["status"]);
        //                c.Add(am);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.findByKeyword() : " + e.ToString());
        //    }
        //    return c;
        //}


        //public OrderCar findByPrimaryKey(int orderTID)
        //{
        //    OrderCar am = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "select * FROM OrderCar a WHERE a.orderTID = " + orderTID;
        //        DataSet ds = my.select(sqlCmd, "OrderCar");
        //        if (ds.Tables["OrderCar"].Rows.Count == 1)
        //        {
        //            DataRow dr = ds.Tables["OrderCar"].Rows[0];
        //            am = new OrderCar();
        //            am.orderTID = Convert.ToInt32(dr["orderTID"]);
        //            am.inTouchBy = dr["inTouchBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inTouchBy"]);
        //            am.inChargeBy = dr["inChargeBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inChargeBy"]);
        //            am.createBy = dr["createBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["createBy"]);
        //            am.createDatetime = Convert.ToInt64(dr["createDatetime"]);
        //            am.lastUpdateDatetime = dr["lastUpdateDatetime"] == DBNull.Value ? -999 : Convert.ToInt64(dr["lastUpdateDatetime"]);
        //            am.lastUpdateBy = dr["lastUpdateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["lastUpdateBy"]);
        //            am.custID = Convert.ToInt32(dr["custID"]);
        //            am.custContactID = Convert.ToInt32(dr["custContactID"]);
        //            am.custContactName = Convert.ToString(dr["custContactName"]);
        //            am.custContactPhone = Convert.ToString(dr["custContactPhone"]);
        //            am.custContactMobile = Convert.ToString(dr["custContactMobile"]);
        //            am.custContactFax = Convert.ToString(dr["custContactFax"]);
        //            am.orderSource = Convert.ToString(dr["orderSource"]);
        //            am.orderType = Convert.ToString(dr["orderType"]);
        //            am.payByCash = dr["payByCash"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByCash"]);
        //            am.payByTransfer = dr["payByTransfer"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByTransfer"]);
        //            am.payByInfo = dr["payByInfo"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payByInfo"]);
        //            am.payTermMonthly = dr["payTermMonthly"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payTermMonthly"]);
        //            am.payPaid = dr["payPaid"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payPaid"]);
        //            am.payWith = Convert.ToString(dr["payWith"]);
        //            am.payAmountShow = dr["payAmountShow"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payAmountShow"]);
        //            am.payToCustUniCode = dr["payToCustUniCode"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payToCustUniCode"]);
        //            am.extraDocument = Convert.ToString(dr["extraDocument"]);
        //            am.memoExternal = Convert.ToString(dr["memoExternal"]);
        //            am.memoInternal = Convert.ToString(dr["memoInternal"]);
        //            am.regu_contractStart = dr["regu_contractStart"] == DBNull.Value ? -999 : Convert.ToInt64(dr["regu_contractStart"]);
        //            am.regu_contractEnd = dr["regu_contractEnd"] == DBNull.Value ? -999 : Convert.ToInt64(dr["regu_contractEnd"]);
        //            am.status = Convert.ToString(dr["status"]);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.findByPrimaryKey() : " + e.ToString());
        //    }
        //    return am;
        //}


        //public int create(int inTouchBy, int inChargeBy, int createBy, long createDatetime, long lastUpdateDatetime, int lastUpdateBy, int custID, int custContactID, String custContactName, String custContactPhone, String custContactMobile, String custContactFax, String orderSource, String orderType, int payByCash, int payByTransfer, int payByInfo, int payTermMonthly, int payPaid, String payWith, double payAmountShow, int payToCustUniCode, String extraDocument, String memoExternal, String memoInternal, long regu_contractStart, long regu_contractEnd, String status)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "insert into OrderCar(inTouchBy,inChargeBy,createBy,createDatetime,lastUpdateDatetime,lastUpdateBy,custID,custContactID,custContactName,custContactPhone,custContactMobile,custContactFax,orderSource,orderType,payByCash,payByTransfer,payByInfo,payTermMonthly,payPaid,payWith,payAmountShow,payToCustUniCode,extraDocument,memoExternal,memoInternal,regu_contractStart,regu_contractEnd,status) values (" + inTouchBy + "," + inChargeBy + "," + createBy + "," + createDatetime + "," + lastUpdateDatetime + "," + lastUpdateBy + "," + custID + "," + custContactID + ",'" + custContactName + "','" + custContactPhone + "','" + custContactMobile + "','" + custContactFax + "','" + orderSource + "','" + orderType + "'," + payByCash + "," + payByTransfer + "," + payByInfo + "," + payTermMonthly + "," + payPaid + ",'" + payWith + "'," + payAmountShow + "," + payToCustUniCode + ",'" + extraDocument + "','" + memoExternal + "','" + memoInternal + "'," + regu_contractStart + "," + regu_contractEnd + ",'" + status + "')";
        //        count = my.insert(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.create() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int Delete(int orderTID)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "delete from OrderCar where orderTID = " + orderTID;
        //        count = my.delete(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.delete() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int DeleteByKeyword(String sqlCmd)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        count = my.delete(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.DeleteByKeyword() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int update(int inTouchBy, int inChargeBy, int createBy, long createDatetime, long lastUpdateDatetime, int lastUpdateBy, int custID, int custContactID, String custContactName, String custContactPhone, String custContactMobile, String custContactFax, String orderSource, String orderType, int payByCash, int payByTransfer, int payByInfo, int payTermMonthly, int payPaid, String payWith, double payAmountShow, int payToCustUniCode, String extraDocument, String memoExternal, String memoInternal, long regu_contractStart, long regu_contractEnd, String status)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "update OrderCar set inTouchBy =" + inTouchBy + ",inChargeBy =" + inChargeBy + ",createBy =" + createBy + ",createDatetime =" + createDatetime + ",lastUpdateDatetime =" + lastUpdateDatetime + ",lastUpdateBy =" + lastUpdateBy + ",custID =" + custID + ",custContactID =" + custContactID + ",custContactName ='" + custContactName + "',custContactPhone ='" + custContactPhone + "',custContactMobile ='" + custContactMobile + "',custContactFax ='" + custContactFax + "',orderSource ='" + orderSource + "',orderType ='" + orderType + "',payByCash =" + payByCash + ",payByTransfer =" + payByTransfer + ",payByInfo =" + payByInfo + ",payTermMonthly =" + payTermMonthly + ",payPaid =" + payPaid + ",payWith ='" + payWith + "',payAmountShow =" + payAmountShow + ",payToCustUniCode =" + payToCustUniCode + ",extraDocument ='" + extraDocument + "',memoExternal ='" + memoExternal + "',memoInternal ='" + memoInternal + "',regu_contractStart =" + regu_contractStart + ",regu_contractEnd =" + regu_contractEnd + ",status ='" + status + "' where orderTID = " + this.orderTID;
        //        count = my.update(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.create() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int update()
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        String sqlCmd = "update OrderCar set inTouchBy =" + this.inTouchBy + ",inChargeBy =" + this.inChargeBy + ",createBy =" + this.createBy + ",createDatetime =" + this.createDatetime + ",lastUpdateDatetime =" + this.lastUpdateDatetime + ",lastUpdateBy =" + this.lastUpdateBy + ",custID =" + this.custID + ",custContactID =" + this.custContactID + ",custContactName ='" + this.custContactName + "',custContactPhone ='" + this.custContactPhone + "',custContactMobile ='" + this.custContactMobile + "',custContactFax ='" + this.custContactFax + "',orderSource ='" + this.orderSource + "',orderType ='" + this.orderType + "',payByCash =" + this.payByCash + ",payByTransfer =" + this.payByTransfer + ",payByInfo =" + this.payByInfo + ",payTermMonthly =" + this.payTermMonthly + ",payPaid =" + this.payPaid + ",payWith ='" + this.payWith + "',payAmountShow =" + this.payAmountShow + ",payToCustUniCode =" + this.payToCustUniCode + ",extraDocument ='" + this.extraDocument + "',memoExternal ='" + this.memoExternal + "',memoInternal ='" + this.memoInternal + "',regu_contractStart =" + this.regu_contractStart + ",regu_contractEnd =" + this.regu_contractEnd + ",status ='" + this.status + "' where orderTID = " + this.orderTID;
        //        count = my.update(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.update() : " + e.ToString());
        //    }
        //    return count;
        //}


        //public int TotalCountByKeyword(String sqlCmd)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool();
        //        DataSet ds = my.select(sqlCmd, "OrderCar");
        //        if (ds.Tables["OrderCar"].Rows.Count > 0)
        //        {
        //            DataRow dr = ds.Tables["OrderCar"].Rows[0];
        //            count = Convert.ToInt32(dr[0]);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        count = 0;
        //        new log().wiriteSystemLog("hsintongERP2022.Models.OrderCar.TotalCountByKeyword() : " + e.ToString());
        //    }
        //    return count;
        //}

        #endregion SQL
    //}
   
}


