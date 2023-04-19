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
    //public partial class FinCashFlowMain
    //{

    //    public Collection<FinCashFlowMain> findAll()
    //    {
    //        Collection<FinCashFlowMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from FinCashFlowMain order by FinCashFlowMainTID asc", "FinCashFlowMain");
    //            if (ds.Tables["FinCashFlowMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinCashFlowMain>();
    //                foreach (DataRow dr in ds.Tables["FinCashFlowMain"].Rows)
    //                {
    //                    FinCashFlowMain am = new FinCashFlowMain();
    //                    am.FinCFDate = dr["FinCFDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinCFDate"]);
    //                    am.FinCSRelatedCompany = Convert.ToString(dr["FinCSRelatedCompany"]);
    //                    am.FinAccItemCodeUX = Convert.ToString(dr["FinAccItemCodeUX"]);
    //                    am.FinCFContent = Convert.ToString(dr["FinCFContent"]);
    //                    am.FinCFAmount = Convert.ToInt32(dr["FinCFAmount"]);
    //                    am.FinCFCashType = Convert.ToString(dr["FinCFCashType"]);
    //                    am.FinCFStatus = Convert.ToString(dr["FinCFStatus"]);
    //                    am.FinCreateBy = Convert.ToInt32(dr["FinCreateBy"]);
    //                    am.FinCreateDate = dr["FinCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinCreateDate"]);
    //                    am.FinLastModifyBy = dr["FinLastModifyBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinLastModifyBy"]);
    //                    am.FinLastModifyDate = dr["FinLastModifyDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinLastModifyDate"]);
    //                    am.FinDeletedBy = dr["FinDeletedBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinDeletedBy"]);
    //                    am.FinDeletedDate = dr["FinDeletedDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinDeletedDate"]);
    //                    am.FinCashFlowMainTID = Convert.ToInt32(dr["FinCashFlowMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<FinCashFlowMain> findByKeyword(String sqlCmd)
    //    {
    //        Collection<FinCashFlowMain> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FinCashFlowMain");
    //            if (ds.Tables["FinCashFlowMain"].Rows.Count > 0)
    //            {
    //                c = new Collection<FinCashFlowMain>();
    //                foreach (DataRow dr in ds.Tables["FinCashFlowMain"].Rows)
    //                {
    //                    FinCashFlowMain am = new FinCashFlowMain();
    //                    am.FinCFDate = dr["FinCFDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinCFDate"]);
    //                    am.FinCSRelatedCompany = Convert.ToString(dr["FinCSRelatedCompany"]);
    //                    am.FinAccItemCodeUX = Convert.ToString(dr["FinAccItemCodeUX"]);
    //                    am.FinCFContent = Convert.ToString(dr["FinCFContent"]);
    //                    am.FinCFAmount = Convert.ToInt32(dr["FinCFAmount"]);
    //                    am.FinCFCashType = Convert.ToString(dr["FinCFCashType"]);
    //                    am.FinCFStatus = Convert.ToString(dr["FinCFStatus"]);
    //                    am.FinCreateBy = Convert.ToInt32(dr["FinCreateBy"]);
    //                    am.FinCreateDate = dr["FinCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinCreateDate"]);
    //                    am.FinLastModifyBy = dr["FinLastModifyBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinLastModifyBy"]);
    //                    am.FinLastModifyDate = dr["FinLastModifyDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinLastModifyDate"]);
    //                    am.FinDeletedBy = dr["FinDeletedBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinDeletedBy"]);
    //                    am.FinDeletedDate = dr["FinDeletedDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinDeletedDate"]);
    //                    am.FinCashFlowMainTID = Convert.ToInt32(dr["FinCashFlowMainTID"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public FinCashFlowMain findByPrimaryKey(int FinCashFlowMainTID)
    //    {
    //        FinCashFlowMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM FinCashFlowMain a WHERE a.FinCashFlowMainTID = " + FinCashFlowMainTID;
    //            DataSet ds = my.select(sqlCmd, "FinCashFlowMain");
    //            if (ds.Tables["FinCashFlowMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["FinCashFlowMain"].Rows[0];
    //                am = new FinCashFlowMain();
    //                am.FinCFDate = dr["FinCFDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinCFDate"]);
    //                am.FinCSRelatedCompany = Convert.ToString(dr["FinCSRelatedCompany"]);
    //                am.FinAccItemCodeUX = Convert.ToString(dr["FinAccItemCodeUX"]);
    //                am.FinCFContent = Convert.ToString(dr["FinCFContent"]);
    //                am.FinCFAmount = Convert.ToInt32(dr["FinCFAmount"]);
    //                am.FinCFCashType = Convert.ToString(dr["FinCFCashType"]);
    //                am.FinCFStatus = Convert.ToString(dr["FinCFStatus"]);
    //                am.FinCreateBy = Convert.ToInt32(dr["FinCreateBy"]);
    //                am.FinCreateDate = dr["FinCreateDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinCreateDate"]);
    //                am.FinLastModifyBy = dr["FinLastModifyBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinLastModifyBy"]);
    //                am.FinLastModifyDate = dr["FinLastModifyDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinLastModifyDate"]);
    //                am.FinDeletedBy = dr["FinDeletedBy"] == DBNull.Value ? -999 : Convert.ToInt32(dr["FinDeletedBy"]);
    //                am.FinDeletedDate = dr["FinDeletedDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["FinDeletedDate"]);
    //                am.FinCashFlowMainTID = Convert.ToInt32(dr["FinCashFlowMainTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(long FinCFDate, String FinCSRelatedCompany, String FinAccItemCodeUX, String FinCFContent, double FinCFAmount, String FinCFCashType, String FinCFStatus, int FinCreateBy, long FinCreateDate, int FinLastModifyBy, long FinLastModifyDate, int FinDeletedBy, long FinDeletedDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into FinCashFlowMain(FinCFDate,FinCSRelatedCompany,FinAccItemCodeUX,FinCFContent,FinCFAmount,FinCFCashType,FinCFStatus,FinCreateBy,FinCreateDate,FinLastModifyBy,FinLastModifyDate,FinDeletedBy,FinDeletedDate) values (" + FinCFDate + ",N'" + FinCSRelatedCompany + "',N'" + FinAccItemCodeUX + "',N'" + FinCFContent + "'," + FinCFAmount + ",N'" + FinCFCashType + "',N'" + FinCFStatus + "'," + FinCreateBy + "," + FinCreateDate + "," + FinLastModifyBy + "," + FinLastModifyDate + "," + FinDeletedBy + "," + FinDeletedDate + ")";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int FinCashFlowMainTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from FinCashFlowMain where FinCashFlowMainTID = " + FinCashFlowMainTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(long FinCFDate, String FinCSRelatedCompany, String FinAccItemCodeUX, String FinCFContent, double FinCFAmount, String FinCFCashType, String FinCFStatus, int FinCreateBy, long FinCreateDate, int FinLastModifyBy, long FinLastModifyDate, int FinDeletedBy, long FinDeletedDate)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FinCashFlowMain set FinCFDate =" + FinCFDate + ",FinCSRelatedCompany =N'" + FinCSRelatedCompany + "',FinAccItemCodeUX =N'" + FinAccItemCodeUX + "',FinCFContent =N'" + FinCFContent + "',FinCFAmount =" + FinCFAmount + ",FinCFCashType =N'" + FinCFCashType + "',FinCFStatus =N'" + FinCFStatus + "',FinCreateBy =" + FinCreateBy + ",FinCreateDate =" + FinCreateDate + ",FinLastModifyBy =" + FinLastModifyBy + ",FinLastModifyDate =" + FinLastModifyDate + ",FinDeletedBy =" + FinDeletedBy + ",FinDeletedDate =" + FinDeletedDate + " where FinCashFlowMainTID = " + this.FinCashFlowMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update FinCashFlowMain set FinCFDate =" + this.FinCFDate + ",FinCSRelatedCompany =N'" + this.FinCSRelatedCompany + "',FinAccItemCodeUX =N'" + this.FinAccItemCodeUX + "',FinCFContent =N'" + this.FinCFContent + "',FinCFAmount =" + this.FinCFAmount + ",FinCFCashType =N'" + this.FinCFCashType + "',FinCFStatus =N'" + this.FinCFStatus + "',FinCreateBy =" + this.FinCreateBy + ",FinCreateDate =" + this.FinCreateDate + ",FinLastModifyBy =" + this.FinLastModifyBy + ",FinLastModifyDate =" + this.FinLastModifyDate + ",FinDeletedBy =" + this.FinDeletedBy + ",FinDeletedDate =" + this.FinDeletedDate + " where FinCashFlowMainTID = " + this.FinCashFlowMainTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "FinCashFlowMain");
    //            if (ds.Tables["FinCashFlowMain"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["FinCashFlowMain"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.FinCashFlowMain.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


