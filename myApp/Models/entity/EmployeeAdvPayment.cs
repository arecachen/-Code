using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hsintongERP2022.Models
{
    //public partial class EmployeeAdvPayment
    //{


    //    #region sql
    //    public Collection<EmployeeAdvPayment> findAll()
    //    {
    //        Collection<EmployeeAdvPayment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from EmployeeAdvPayment order by employeeAdvPaymentTID asc", "EmployeeAdvPayment");
    //            if (ds.Tables["EmployeeAdvPayment"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeAdvPayment>();
    //                foreach (DataRow dr in ds.Tables["EmployeeAdvPayment"].Rows)
    //                {
    //                    EmployeeAdvPayment am = new EmployeeAdvPayment();
    //                    am.empPaymentRecordID = Convert.ToInt32(dr["empPaymentRecordID"]);
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.empContact = Convert.ToString(dr["empContact"]);
    //                    am.empCashDatetime = Convert.ToInt64(dr["empCashDatetime"]);
    //                    am.empCashAmount = Convert.ToInt32(dr["empCashAmount"]);
    //                    am.empCashMemo = Convert.ToString(dr["empCashMemo"]);
    //                    am.empRepaid = Convert.ToInt32(dr["empRepaid"]);
    //                    am.empRepaidDate = dr["empRepaidDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["empRepaidDate"]);
    //                    am.empRepaidCash = Convert.ToInt32(dr["empRepaidCash"]);
    //                    am.cashRecordBy = Convert.ToInt32(dr["cashRecordBy"]);
    //                    am.cashUpdateBy = Convert.ToInt32(dr["cashUpdateBy"]);
    //                    am.cashRecordDatetime = Convert.ToInt64(dr["cashRecordDatetime"]);
    //                    am.cashLastUpadteDatetime = Convert.ToInt64(dr["cashLastUpadteDatetime"]);
    //                    am.employeeAdvPaymentTID = Convert.ToInt32(dr["employeeAdvPaymentTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<EmployeeAdvPayment> findByKeyword(String sqlCmd)
    //    {
    //        Collection<EmployeeAdvPayment> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeAdvPayment");
    //            if (ds.Tables["EmployeeAdvPayment"].Rows.Count > 0)
    //            {
    //                c = new Collection<EmployeeAdvPayment>();
    //                foreach (DataRow dr in ds.Tables["EmployeeAdvPayment"].Rows)
    //                {
    //                    EmployeeAdvPayment am = new EmployeeAdvPayment();
    //                    am.empPaymentRecordID = Convert.ToInt32(dr["empPaymentRecordID"]);
    //                    am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                    am.empContact = Convert.ToString(dr["empContact"]);
    //                    am.empCashDatetime = Convert.ToInt64(dr["empCashDatetime"]);
    //                    am.empCashAmount = Convert.ToInt32(dr["empCashAmount"]);
    //                    am.empCashMemo = Convert.ToString(dr["empCashMemo"]);
    //                    am.empRepaid = Convert.ToInt32(dr["empRepaid"]);
    //                    am.empRepaidDate = dr["empRepaidDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["empRepaidDate"]);
    //                    am.empRepaidCash = Convert.ToInt32(dr["empRepaidCash"]);
    //                    am.cashRecordBy = Convert.ToInt32(dr["cashRecordBy"]);
    //                    am.cashUpdateBy = Convert.ToInt32(dr["cashUpdateBy"]);
    //                    am.cashRecordDatetime = Convert.ToInt64(dr["cashRecordDatetime"]);
    //                    am.cashLastUpadteDatetime = Convert.ToInt64(dr["cashLastUpadteDatetime"]);
    //                    am.employeeAdvPaymentTID = Convert.ToInt32(dr["employeeAdvPaymentTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public EmployeeAdvPayment findByPrimaryKey(int employeeAdvPaymentTID)
    //    {
    //        EmployeeAdvPayment am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM EmployeeAdvPayment a WHERE a.employeeAdvPaymentTID = " + employeeAdvPaymentTID;
    //            DataSet ds = my.select(sqlCmd, "EmployeeAdvPayment");
    //            if (ds.Tables["EmployeeAdvPayment"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["EmployeeAdvPayment"].Rows[0];
    //                am = new EmployeeAdvPayment();
    //                am.empPaymentRecordID = Convert.ToInt32(dr["empPaymentRecordID"]);
    //                am.employeeID = Convert.ToInt32(dr["employeeID"]);
    //                am.empContact = Convert.ToString(dr["empContact"]);
    //                am.empCashDatetime = Convert.ToInt64(dr["empCashDatetime"]);
    //                am.empCashAmount = Convert.ToInt32(dr["empCashAmount"]);
    //                am.empCashMemo = Convert.ToString(dr["empCashMemo"]);
    //                am.empRepaid = Convert.ToInt32(dr["empRepaid"]);
    //                am.empRepaidDate = dr["empRepaidDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["empRepaidDate"]);
    //                am.empRepaidCash = Convert.ToInt32(dr["empRepaidCash"]);
    //                am.cashRecordBy = Convert.ToInt32(dr["cashRecordBy"]);
    //                am.cashUpdateBy = Convert.ToInt32(dr["cashUpdateBy"]);
    //                am.cashRecordDatetime = Convert.ToInt64(dr["cashRecordDatetime"]);
    //                am.cashLastUpadteDatetime = Convert.ToInt64(dr["cashLastUpadteDatetime"]);
    //                am.employeeAdvPaymentTID = Convert.ToInt32(dr["employeeAdvPaymentTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int empPaymentRecordID, int employeeID, String empContact, long empCashDatetime, double empCashAmount, String empCashMemo, int empRepaid, long empRepaidDate, int empRepaidCash, int cashRecordBy, int cashUpdateBy, long cashRecordDatetime, long cashLastUpadteDatetime)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(empPaymentRecordID + ",");
    //            sb_value.Append(employeeID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(empContact) ? "''" : "N'" + Regex.Replace(empContact, "'", "''") + "'") + ",");
    //            sb_value.Append(empCashDatetime + ",");
    //            sb_value.Append(empCashAmount + ",");
    //            sb_value.Append((String.IsNullOrEmpty(empCashMemo) ? "null" : "N'" + Regex.Replace(empCashMemo, "'", "''") + "'") + ",");
    //            sb_value.Append(empRepaid + ",");
    //            sb_value.Append(empRepaidDate + ",");
    //            sb_value.Append(empRepaidCash + ",");
    //            sb_value.Append(cashRecordBy + ",");
    //            sb_value.Append(cashUpdateBy + ",");
    //            sb_value.Append(cashRecordDatetime + ",");
    //            sb_value.Append(cashLastUpadteDatetime);

    //            String sqlCmd = "insert into EmployeeAdvPayment(empPaymentRecordID,employeeID,empContact,empCashDatetime,empCashAmount,empCashMemo,empRepaid,empRepaidDate,empRepaidCash,cashRecordBy,cashUpdateBy,cashRecordDatetime,cashLastUpadteDatetime) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int employeeAdvPaymentTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from EmployeeAdvPayment where employeeAdvPaymentTID = " + employeeAdvPaymentTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int empPaymentRecordID, int employeeID, String empContact, long empCashDatetime, double empCashAmount, String empCashMemo, int empRepaid, long empRepaidDate, int empRepaidCash, int cashRecordBy, int cashUpdateBy, long cashRecordDatetime, long cashLastUpadteDatetime)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("empPaymentRecordID =" + empPaymentRecordID + ",");
    //            sb_value.Append("employeeID =" + employeeID + ",");
    //            sb_value.Append("empContact=" + (String.IsNullOrEmpty(empContact) ? "''" : "N'" + Regex.Replace(empContact, "'", "''") + "'") + ",");
    //            sb_value.Append("empCashDatetime =" + empCashDatetime + ",");
    //            sb_value.Append("empCashAmount =" + empCashAmount + ",");
    //            sb_value.Append("empCashMemo=" + (String.IsNullOrEmpty(empCashMemo) ? "null" : "N'" + Regex.Replace(empCashMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("empRepaid =" + empRepaid + ",");
    //            sb_value.Append("empRepaidDate =" + empRepaidDate + ",");
    //            sb_value.Append("empRepaidCash =" + empRepaidCash + ",");
    //            sb_value.Append("cashRecordBy =" + cashRecordBy + ",");
    //            sb_value.Append("cashUpdateBy =" + cashUpdateBy + ",");
    //            sb_value.Append("cashRecordDatetime =" + cashRecordDatetime + ",");
    //            sb_value.Append("cashLastUpadteDatetime =" + cashLastUpadteDatetime);

    //            String sqlCmd = "update EmployeeAdvPayment set  " + sb_value.ToString() + "  where employeeAdvPaymentTID = " + this.employeeAdvPaymentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("empPaymentRecordID =" + this.empPaymentRecordID + ",");
    //            sb_value.Append("employeeID =" + this.employeeID + ",");
    //            sb_value.Append("empContact=" + (String.IsNullOrEmpty(this.empContact) ? "''" : "N'" + Regex.Replace(this.empContact, "'", "''") + "'") + ",");
    //            sb_value.Append("empCashDatetime =" + this.empCashDatetime + ",");
    //            sb_value.Append("empCashAmount =" + this.empCashAmount + ",");
    //            sb_value.Append("empCashMemo=" + (String.IsNullOrEmpty(this.empCashMemo) ? "null" : "N'" + Regex.Replace(this.empCashMemo, "'", "''") + "'") + ",");
    //            sb_value.Append("empRepaid =" + this.empRepaid + ",");
    //            sb_value.Append("empRepaidDate =" + this.empRepaidDate + ",");
    //            sb_value.Append("empRepaidCash =" + this.empRepaidCash + ",");
    //            sb_value.Append("cashRecordBy =" + this.cashRecordBy + ",");
    //            sb_value.Append("cashUpdateBy =" + this.cashUpdateBy + ",");
    //            sb_value.Append("cashRecordDatetime =" + this.cashRecordDatetime + ",");
    //            sb_value.Append("cashLastUpadteDatetime =" + this.cashLastUpadteDatetime);

    //            String sqlCmd = "update EmployeeAdvPayment set  " + sb_value.ToString() + "  where employeeAdvPaymentTID = " + this.employeeAdvPaymentTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "EmployeeAdvPayment");
    //            if (ds.Tables["EmployeeAdvPayment"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["EmployeeAdvPayment"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeAdvPayment.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //    #endregion sql

    //}
}


