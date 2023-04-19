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
    //public partial class OrderCarRegular
    //{
      
    //    public Collection<OrderCarRegular> findAll()
    //    {
    //        Collection<OrderCarRegular> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select("select * from OrderCarRegular order by OrderCarRegularTID asc", "OrderCarRegular");
    //            if (ds.Tables["OrderCarRegular"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegular>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegular"].Rows)
    //                {
    //                    OrderCarRegular am = new OrderCarRegular();
    //                    am.MainTitle = Convert.ToString(dr["MainTitle"]);
    //                    am.inTouchBy = dr["inTouchBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inTouchBy"]);
    //                    am.inChargeBy = dr["inChargeBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inChargeBy"]);
    //                    am.CreateBy = Convert.ToInt32(dr["CreateBy"]);
    //                    am.CreateDate = Convert.ToInt64(dr["CreateDate"]);
    //                    am.UpdateBy = dr["UpdateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["UpdateBy"]);
    //                    am.UpdateDate = dr["UpdateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["UpdateDate"]);
    //                    am.CustomerID = Convert.ToInt32(dr["CustomerID"]);
    //                    am.CustomerContactID = Convert.ToInt32(dr["CustomerContactID"]);
    //                    am.Cust_Name = Convert.ToString(dr["Cust_Name"]);
    //                    am.Cust_Phone = Convert.ToString(dr["Cust_Phone"]);
    //                    am.Cust_Mobile = Convert.ToString(dr["Cust_Mobile"]);
    //                    am.Cust_Fax = Convert.ToString(dr["Cust_Fax"]);
    //                    am.PayAmount = dr["PayAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PayAmount"]);
    //                    am.ExtraDocument = Convert.ToString(dr["ExtraDocument"]);
    //                    am.StartDate = Convert.ToInt64(dr["StartDate"]);
    //                    am.EndDate = Convert.ToInt64(dr["EndDate"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.OrderCarRegularTID = Convert.ToInt32(dr["OrderCarRegularTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderCarRegular> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderCarRegular> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegular");
    //            if (ds.Tables["OrderCarRegular"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderCarRegular>();
    //                foreach (DataRow dr in ds.Tables["OrderCarRegular"].Rows)
    //                {
    //                    OrderCarRegular am = new OrderCarRegular();
    //                    am.MainTitle = Convert.ToString(dr["MainTitle"]);
    //                    am.inTouchBy = dr["inTouchBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inTouchBy"]);
    //                    am.inChargeBy = dr["inChargeBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inChargeBy"]);
    //                    am.CreateBy = Convert.ToInt32(dr["CreateBy"]);
    //                    am.CreateDate = Convert.ToInt64(dr["CreateDate"]);
    //                    am.UpdateBy = dr["UpdateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["UpdateBy"]);
    //                    am.UpdateDate = dr["UpdateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["UpdateDate"]);
    //                    am.CustomerID = Convert.ToInt32(dr["CustomerID"]);
    //                    am.CustomerContactID = Convert.ToInt32(dr["CustomerContactID"]);
    //                    am.Cust_Name = Convert.ToString(dr["Cust_Name"]);
    //                    am.Cust_Phone = Convert.ToString(dr["Cust_Phone"]);
    //                    am.Cust_Mobile = Convert.ToString(dr["Cust_Mobile"]);
    //                    am.Cust_Fax = Convert.ToString(dr["Cust_Fax"]);
    //                    am.PayAmount = dr["PayAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PayAmount"]);
    //                    am.ExtraDocument = Convert.ToString(dr["ExtraDocument"]);
    //                    am.StartDate = Convert.ToInt64(dr["StartDate"]);
    //                    am.EndDate = Convert.ToInt64(dr["EndDate"]);
    //                    am.status = Convert.ToString(dr["status"]);
    //                    am.OrderCarRegularTID = Convert.ToInt32(dr["OrderCarRegularTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderCarRegular findByPrimaryKey(int OrderCarRegularTID)
    //    {
    //        OrderCarRegular am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "select * FROM OrderCarRegular a WHERE a.OrderCarRegularTID = " + OrderCarRegularTID;
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegular");
    //            if (ds.Tables["OrderCarRegular"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegular"].Rows[0];
    //                am = new OrderCarRegular();
    //                am.MainTitle = Convert.ToString(dr["MainTitle"]);
    //                am.inTouchBy = dr["inTouchBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inTouchBy"]);
    //                am.inChargeBy = dr["inChargeBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["inChargeBy"]);
    //                am.CreateBy = Convert.ToInt32(dr["CreateBy"]);
    //                am.CreateDate = Convert.ToInt64(dr["CreateDate"]);
    //                am.UpdateBy = dr["UpdateBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["UpdateBy"]);
    //                am.UpdateDate = dr["UpdateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["UpdateDate"]);
    //                am.CustomerID = Convert.ToInt32(dr["CustomerID"]);
    //                am.CustomerContactID = Convert.ToInt32(dr["CustomerContactID"]);
    //                am.Cust_Name = Convert.ToString(dr["Cust_Name"]);
    //                am.Cust_Phone = Convert.ToString(dr["Cust_Phone"]);
    //                am.Cust_Mobile = Convert.ToString(dr["Cust_Mobile"]);
    //                am.Cust_Fax = Convert.ToString(dr["Cust_Fax"]);
    //                am.PayAmount = dr["PayAmount"] == DBNull.Value ? -999 : Convert.ToInt32(dr["PayAmount"]);
    //                am.ExtraDocument = Convert.ToString(dr["ExtraDocument"]);
    //                am.StartDate = Convert.ToInt64(dr["StartDate"]);
    //                am.EndDate = Convert.ToInt64(dr["EndDate"]);
    //                am.status = Convert.ToString(dr["status"]);
    //                am.OrderCarRegularTID = Convert.ToInt32(dr["OrderCarRegularTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String MainTitle, int inTouchBy, int inChargeBy, int CreateBy, long CreateDate, int UpdateBy, long UpdateDate, int CustomerID, int CustomerContactID, String Cust_Name, String Cust_Phone, String Cust_Mobile, String Cust_Fax, decimal PayAmount, String ExtraDocument, long StartDate, long EndDate, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append((String.IsNullOrEmpty(MainTitle) ? "''" : "N'" + Regex.Replace(MainTitle, "'", "''") + "'") + ",");
    //            sb_value.Append(inTouchBy + ",");
    //            sb_value.Append(inChargeBy + ",");
    //            sb_value.Append(CreateBy + ",");
    //            sb_value.Append(CreateDate + ",");
    //            sb_value.Append(UpdateBy + ",");
    //            sb_value.Append(UpdateDate + ",");
    //            sb_value.Append(CustomerID + ",");
    //            sb_value.Append(CustomerContactID + ",");
    //            sb_value.Append((String.IsNullOrEmpty(Cust_Name) ? "null" : "N'" + Regex.Replace(Cust_Name, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(Cust_Phone) ? "null" : "N'" + Regex.Replace(Cust_Phone, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(Cust_Mobile) ? "null" : "N'" + Regex.Replace(Cust_Mobile, "'", "''") + "'") + ",");
    //            sb_value.Append((String.IsNullOrEmpty(Cust_Fax) ? "null" : "N'" + Regex.Replace(Cust_Fax, "'", "''") + "'") + ",");
    //            sb_value.Append(PayAmount + ",");
    //            sb_value.Append((String.IsNullOrEmpty(ExtraDocument) ? "null" : "N'" + Regex.Replace(ExtraDocument, "'", "''") + "'") + ",");
    //            sb_value.Append(StartDate + ",");
    //            sb_value.Append(EndDate + ",");
    //            sb_value.Append((String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

    //            String sqlCmd = "insert into OrderCarRegular(MainTitle,inTouchBy,inChargeBy,CreateBy,CreateDate,UpdateBy,UpdateDate,CustomerID,CustomerContactID,Cust_Name,Cust_Phone,Cust_Mobile,Cust_Fax,PayAmount,ExtraDocument,StartDate,EndDate,status) values (" + sb_value.ToString() + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int OrderCarRegularTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            String sqlCmd = "delete from OrderCarRegular where OrderCarRegularTID = " + OrderCarRegularTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String MainTitle, int inTouchBy, int inChargeBy, int CreateBy, long CreateDate, int UpdateBy, long UpdateDate, int CustomerID, int CustomerContactID, String Cust_Name, String Cust_Phone, String Cust_Mobile, String Cust_Fax, double PayAmount, String ExtraDocument, long StartDate, long EndDate, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append("MainTitle=" + (String.IsNullOrEmpty(MainTitle) ? "''" : "N'" + Regex.Replace(MainTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("inTouchBy =" + inTouchBy + ",");
    //            sb_value.Append("inChargeBy =" + inChargeBy + ",");
    //            sb_value.Append("CreateBy =" + CreateBy + ",");
    //            sb_value.Append("CreateDate =" + CreateDate + ",");
    //            sb_value.Append("UpdateBy =" + UpdateBy + ",");
    //            sb_value.Append("UpdateDate =" + UpdateDate + ",");
    //            sb_value.Append("CustomerID =" + CustomerID + ",");
    //            sb_value.Append("CustomerContactID =" + CustomerContactID + ",");
    //            sb_value.Append("Cust_Name=" + (String.IsNullOrEmpty(Cust_Name) ? "null" : "N'" + Regex.Replace(Cust_Name, "'", "''") + "'") + ",");
    //            sb_value.Append("Cust_Phone=" + (String.IsNullOrEmpty(Cust_Phone) ? "null" : "N'" + Regex.Replace(Cust_Phone, "'", "''") + "'") + ",");
    //            sb_value.Append("Cust_Mobile=" + (String.IsNullOrEmpty(Cust_Mobile) ? "null" : "N'" + Regex.Replace(Cust_Mobile, "'", "''") + "'") + ",");
    //            sb_value.Append("Cust_Fax=" + (String.IsNullOrEmpty(Cust_Fax) ? "null" : "N'" + Regex.Replace(Cust_Fax, "'", "''") + "'") + ",");
    //            sb_value.Append("PayAmount =" + PayAmount + ",");
    //            sb_value.Append("ExtraDocument=" + (String.IsNullOrEmpty(ExtraDocument) ? "null" : "N'" + Regex.Replace(ExtraDocument, "'", "''") + "'") + ",");
    //            sb_value.Append("StartDate =" + StartDate + ",");
    //            sb_value.Append("EndDate =" + EndDate + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

    //            String sqlCmd = "update OrderCarRegular set  " + sb_value.ToString() + "  where OrderCarRegularTID = " + this.OrderCarRegularTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.create() : " + e.ToString());
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
    //            sb_value.Append("MainTitle=" + (String.IsNullOrEmpty(this.MainTitle) ? "''" : "N'" + Regex.Replace(this.MainTitle, "'", "''") + "'") + ",");
    //            sb_value.Append("inTouchBy =" + this.inTouchBy + ",");
    //            sb_value.Append("inChargeBy =" + this.inChargeBy + ",");
    //            sb_value.Append("CreateBy =" + this.CreateBy + ",");
    //            sb_value.Append("CreateDate =" + this.CreateDate + ",");
    //            sb_value.Append("UpdateBy =" + this.UpdateBy + ",");
    //            sb_value.Append("UpdateDate =" + this.UpdateDate + ",");
    //            sb_value.Append("CustomerID =" + this.CustomerID + ",");
    //            sb_value.Append("CustomerContactID =" + this.CustomerContactID + ",");
    //            sb_value.Append("Cust_Name=" + (String.IsNullOrEmpty(this.Cust_Name) ? "null" : "N'" + Regex.Replace(this.Cust_Name, "'", "''") + "'") + ",");
    //            sb_value.Append("Cust_Phone=" + (String.IsNullOrEmpty(this.Cust_Phone) ? "null" : "N'" + Regex.Replace(this.Cust_Phone, "'", "''") + "'") + ",");
    //            sb_value.Append("Cust_Mobile=" + (String.IsNullOrEmpty(this.Cust_Mobile) ? "null" : "N'" + Regex.Replace(this.Cust_Mobile, "'", "''") + "'") + ",");
    //            sb_value.Append("Cust_Fax=" + (String.IsNullOrEmpty(this.Cust_Fax) ? "null" : "N'" + Regex.Replace(this.Cust_Fax, "'", "''") + "'") + ",");
    //            sb_value.Append("PayAmount =" + this.PayAmount + ",");
    //            sb_value.Append("ExtraDocument=" + (String.IsNullOrEmpty(this.ExtraDocument) ? "null" : "N'" + Regex.Replace(this.ExtraDocument, "'", "''") + "'") + ",");
    //            sb_value.Append("StartDate =" + this.StartDate + ",");
    //            sb_value.Append("EndDate =" + this.EndDate + ",");
    //            sb_value.Append("status=" + (String.IsNullOrEmpty(this.status) ? "''" : "N'" + Regex.Replace(this.status, "'", "''") + "'"));

    //            String sqlCmd = "update OrderCarRegular set  " + sb_value.ToString() + "  where OrderCarRegularTID = " + this.OrderCarRegularTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool("");
    //            DataSet ds = my.select(sqlCmd, "OrderCarRegular");
    //            if (ds.Tables["OrderCarRegular"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderCarRegular"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegular.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


