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
    //public partial class OrderCarInfoPayRecord
    //{

    //    public Collection<OrderCarInfoPayRecord> findAll()
    //    {
    //        Collection<OrderCarInfoPayRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderCarInfoPayRecord order by orderCarInfoPayRecordTID asc", "OrderCarInfoPayRecord");
    //            if (ds.Tables["OrderCarInfoPayRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarInfoPayRecord>();
    //                foreach (DataRow dr in ds.Tables["OrderCarInfoPayRecord"].Rows)
    //                {
    //                    OrderCarInfoPayRecord am = new OrderCarInfoPayRecord();
    //                    am.orderCarInfoID = Convert.ToInt32(dr["orderCarInfoID"]);
    //                    am.paymentReceiveDate = Convert.ToInt64(dr["paymentReceiveDate"]);
    //                    am.paymentAmount = dr["paymentAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["paymentAmount"]);
    //                    am.paymentInFull = dr["paymentInFull"] == DBNull.Value ? -999 : Convert.ToInt32(dr["paymentInFull"]);
    //                    am.payDriveType = Convert.ToString(dr["payDriveType"]);
    //                    am.payDriverDate = dr["payDriverDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["payDriverDate"]);
    //                    am.payDriverAmount = dr["payDriverAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payDriverAmount"]);
    //                    am.payInsurance = dr["payInsurance"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payInsurance"]);
    //                    am.payInsuraceAmount = dr["payInsuraceAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payInsuraceAmount"]);
    //                    am.sentReceipt = dr["sentReceipt"] == DBNull.Value ? -999 : Convert.ToInt32(dr["sentReceipt"]);
    //                    am.sentReceiptDate = dr["sentReceiptDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["sentReceiptDate"]);
    //                    am.sentReceiptNo = Convert.ToString(dr["sentReceiptNo"]);
    //                    am.multiSentReceiptMemo = Convert.ToString(dr["multiSentReceiptMemo"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.accountCheckDate = dr["accountCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["accountCheckDate"]);
    //                    am.accountCheck = Convert.ToInt32(dr["accountCheck"]);
    //                    am.accountCheckMemo = Convert.ToString(dr["accountCheckMemo"]);
    //                    am.orderCarInfoPayRecordTID = Convert.ToInt32(dr["orderCarInfoPayRecordTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarInfoPayRecord> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarInfoPayRecord> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfoPayRecord");
    //            if (ds.Tables["OrderCarInfoPayRecord"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarInfoPayRecord>();
    //                foreach (DataRow dr in ds.Tables["OrderCarInfoPayRecord"].Rows)
    //                {
    //                    OrderCarInfoPayRecord am = new OrderCarInfoPayRecord();
    //                    am.orderCarInfoID = Convert.ToInt32(dr["orderCarInfoID"]);
    //                    am.paymentReceiveDate = Convert.ToInt64(dr["paymentReceiveDate"]);
    //                    am.paymentAmount = dr["paymentAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["paymentAmount"]);
    //                    am.paymentInFull = dr["paymentInFull"] == DBNull.Value ? -999 : Convert.ToInt32(dr["paymentInFull"]);
    //                    am.payDriveType = Convert.ToString(dr["payDriveType"]);
    //                    am.payDriverDate = dr["payDriverDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["payDriverDate"]);
    //                    am.payDriverAmount = dr["payDriverAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payDriverAmount"]);
    //                    am.payInsurance = dr["payInsurance"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payInsurance"]);
    //                    am.payInsuraceAmount = dr["payInsuraceAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payInsuraceAmount"]);
    //                    am.sentReceipt = dr["sentReceipt"] == DBNull.Value ? -999 : Convert.ToInt32(dr["sentReceipt"]);
    //                    am.sentReceiptDate = dr["sentReceiptDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["sentReceiptDate"]);
    //                    am.sentReceiptNo = Convert.ToString(dr["sentReceiptNo"]);
    //                    am.multiSentReceiptMemo = Convert.ToString(dr["multiSentReceiptMemo"]);
    //                    am.memo = Convert.ToString(dr["memo"]);
    //                    am.accountCheckDate = dr["accountCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["accountCheckDate"]);
    //                    am.accountCheck = Convert.ToInt32(dr["accountCheck"]);
    //                    am.accountCheckMemo = Convert.ToString(dr["accountCheckMemo"]);
    //                    am.orderCarInfoPayRecordTID = Convert.ToInt32(dr["orderCarInfoPayRecordTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarInfoPayRecord findByPrimaryKey(int orderCarInfoPayRecordTID)
    //    {
    //        OrderCarInfoPayRecord am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarInfoPayRecord a WHERE a.orderCarInfoPayRecordTID = " + orderCarInfoPayRecordTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfoPayRecord");
    //            if (ds.Tables["OrderCarInfoPayRecord"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarInfoPayRecord"].Rows[0];
    //                am = new OrderCarInfoPayRecord();
    //                am.orderCarInfoID = Convert.ToInt32(dr["orderCarInfoID"]);
    //                am.paymentReceiveDate = Convert.ToInt64(dr["paymentReceiveDate"]);
    //                am.paymentAmount = dr["paymentAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["paymentAmount"]);
    //                am.paymentInFull = dr["paymentInFull"] == DBNull.Value ? -999 : Convert.ToInt32(dr["paymentInFull"]);
    //                am.payDriveType = Convert.ToString(dr["payDriveType"]);
    //                am.payDriverDate = dr["payDriverDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["payDriverDate"]);
    //                am.payDriverAmount = dr["payDriverAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payDriverAmount"]);
    //                am.payInsurance = dr["payInsurance"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payInsurance"]);
    //                am.payInsuraceAmount = dr["payInsuraceAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["payInsuraceAmount"]);
    //                am.sentReceipt = dr["sentReceipt"] == DBNull.Value ? -999 : Convert.ToInt32(dr["sentReceipt"]);
    //                am.sentReceiptDate = dr["sentReceiptDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["sentReceiptDate"]);
    //                am.sentReceiptNo = Convert.ToString(dr["sentReceiptNo"]);
    //                am.multiSentReceiptMemo = Convert.ToString(dr["multiSentReceiptMemo"]);
    //                am.memo = Convert.ToString(dr["memo"]);
    //                am.accountCheckDate = dr["accountCheckDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["accountCheckDate"]);
    //                am.accountCheck = Convert.ToInt32(dr["accountCheck"]);
    //                am.accountCheckMemo = Convert.ToString(dr["accountCheckMemo"]);
    //                am.orderCarInfoPayRecordTID = Convert.ToInt32(dr["orderCarInfoPayRecordTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarInfoID, long paymentReceiveDate, decimal paymentAmount, int paymentInFull, String payDriveType, long payDriverDate, decimal payDriverAmount, int payInsurance, decimal payInsuraceAmount, int sentReceipt, long sentReceiptDate, String sentReceiptNo, String multiSentReceiptMemo, String memo, long accountCheckDate, int accountCheck, String accountCheckMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderCarInfoPayRecord(orderCarInfoID,paymentReceiveDate,paymentAmount,paymentInFull,payDriveType,payDriverDate,payDriverAmount,payInsurance,payInsuraceAmount,sentReceipt,sentReceiptDate,sentReceiptNo,multiSentReceiptMemo,memo,accountCheckDate,accountCheck,accountCheckMemo) values (" + orderCarInfoID + "," + paymentReceiveDate + "," + paymentAmount + "," + paymentInFull + ",'" + payDriveType + "'," + payDriverDate + "," + payDriverAmount + "," + payInsurance + "," + payInsuraceAmount + "," + sentReceipt + "," + sentReceiptDate + ",'" + sentReceiptNo + "','" + multiSentReceiptMemo + "','" + memo + "'," + accountCheckDate + "," + accountCheck + ",'" + accountCheckMemo + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int orderCarInfoPayRecordTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderCarInfoPayRecord where orderCarInfoPayRecordTID = " + orderCarInfoPayRecordTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarInfoID, long paymentReceiveDate, double paymentAmount, int paymentInFull, String payDriveType, long payDriverDate, double payDriverAmount, int payInsurance, double payInsuraceAmount, int sentReceipt, long sentReceiptDate, String sentReceiptNo, String multiSentReceiptMemo, String memo, long accountCheckDate, int accountCheck, String accountCheckMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfoPayRecord set orderCarInfoID =" + orderCarInfoID + ",paymentReceiveDate =" + paymentReceiveDate + ",paymentAmount =" + paymentAmount + ",paymentInFull =" + paymentInFull + ",payDriveType ='" + payDriveType + "',payDriverDate =" + payDriverDate + ",payDriverAmount =" + payDriverAmount + ",payInsurance =" + payInsurance + ",payInsuraceAmount =" + payInsuraceAmount + ",sentReceipt =" + sentReceipt + ",sentReceiptDate =" + sentReceiptDate + ",sentReceiptNo ='" + sentReceiptNo + "',multiSentReceiptMemo ='" + multiSentReceiptMemo + "',memo ='" + memo + "',accountCheckDate =" + accountCheckDate + ",accountCheck =" + accountCheck + ",accountCheckMemo ='" + accountCheckMemo + "' where orderCarInfoPayRecordTID = " + this.orderCarInfoPayRecordTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderCarInfoPayRecord set orderCarInfoID =" + this.orderCarInfoID + ",paymentReceiveDate =" + this.paymentReceiveDate + ",paymentAmount =" + this.paymentAmount + ",paymentInFull =" + this.paymentInFull + ",payDriveType ='" + this.payDriveType + "',payDriverDate =" + this.payDriverDate + ",payDriverAmount =" + this.payDriverAmount + ",payInsurance =" + this.payInsurance + ",payInsuraceAmount =" + this.payInsuraceAmount + ",sentReceipt =" + this.sentReceipt + ",sentReceiptDate =" + this.sentReceiptDate + ",sentReceiptNo ='" + this.sentReceiptNo + "',multiSentReceiptMemo ='" + this.multiSentReceiptMemo + "',memo ='" + this.memo + "',accountCheckDate =" + this.accountCheckDate + ",accountCheck =" + this.accountCheck + ",accountCheckMemo ='" + this.accountCheckMemo + "' where orderCarInfoPayRecordTID = " + this.orderCarInfoPayRecordTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderCarInfoPayRecord");
    //            if (ds.Tables["OrderCarInfoPayRecord"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarInfoPayRecord"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarInfoPayRecord.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


