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
    //public partial class OrderIrregular
    //{
     
    //    public Collection<OrderIrregular> findAll()
    //    {
    //        Collection<OrderIrregular> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from OrderIrregular order by orderIrregularTID asc", "OrderIrregular");
    //            if (ds.Tables["OrderIrregular"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderIrregular>();
    //                foreach (DataRow dr in ds.Tables["OrderIrregular"].Rows)
    //                {
    //                    OrderIrregular am = new OrderIrregular();
    //                    am.orderIrregularTID = Convert.ToInt32(dr["orderIrregularTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.workContract = Convert.ToInt32(dr["workContract"]);
    //                    am.workQuotation = Convert.ToInt32(dr["workQuotation"]);
    //                    am.workCarDetails = Convert.ToInt32(dr["workCarDetails"]);
    //                    am.workOther = Convert.ToInt32(dr["workOther"]);
    //                    am.workCarRegInfo = Convert.ToInt32(dr["workCarRegInfo"]);
    //                    am.miscSticker = Convert.ToInt32(dr["miscSticker"]);
    //                    am.miscStickerMemo = Convert.ToString(dr["miscStickerMemo"]);
    //                    am.miscInsurance = Convert.ToInt32(dr["miscInsurance"]);
    //                    am.miscGuide = Convert.ToInt32(dr["miscGuide"]);
    //                    am.miscGift = Convert.ToInt32(dr["miscGift"]);
    //                    am.miscGiftMemo = Convert.ToString(dr["miscGiftMemo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<OrderIrregular> findByKeyword(String sqlCmd)
    //    {
    //        Collection<OrderIrregular> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderIrregular");
    //            if (ds.Tables["OrderIrregular"].Rows.Count > 0)
    //            {
    //                c = new Collection<OrderIrregular>();
    //                foreach (DataRow dr in ds.Tables["OrderIrregular"].Rows)
    //                {
    //                    OrderIrregular am = new OrderIrregular();
    //                    am.orderIrregularTID = Convert.ToInt32(dr["orderIrregularTID"]);
    //                    am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                    am.workContract = Convert.ToInt32(dr["workContract"]);
    //                    am.workQuotation = Convert.ToInt32(dr["workQuotation"]);
    //                    am.workCarDetails = Convert.ToInt32(dr["workCarDetails"]);
    //                    am.workOther = Convert.ToInt32(dr["workOther"]);
    //                    am.workCarRegInfo = Convert.ToInt32(dr["workCarRegInfo"]);
    //                    am.miscSticker = Convert.ToInt32(dr["miscSticker"]);
    //                    am.miscStickerMemo = Convert.ToString(dr["miscStickerMemo"]);
    //                    am.miscInsurance = Convert.ToInt32(dr["miscInsurance"]);
    //                    am.miscGuide = Convert.ToInt32(dr["miscGuide"]);
    //                    am.miscGift = Convert.ToInt32(dr["miscGift"]);
    //                    am.miscGiftMemo = Convert.ToString(dr["miscGiftMemo"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public OrderIrregular findByPrimaryKey(int orderIrregularTID)
    //    {
    //        OrderIrregular am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderIrregular a WHERE a.orderIrregularTID = " + orderIrregularTID;
    //            DataSet ds = my.select(sqlCmd, "OrderIrregular");
    //            if (ds.Tables["OrderIrregular"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderIrregular"].Rows[0];
    //                am = new OrderIrregular();
    //                am.orderIrregularTID = Convert.ToInt32(dr["orderIrregularTID"]);
    //                am.orderCarID = Convert.ToInt32(dr["orderCarID"]);
    //                am.workContract = Convert.ToInt32(dr["workContract"]);
    //                am.workQuotation = Convert.ToInt32(dr["workQuotation"]);
    //                am.workCarDetails = Convert.ToInt32(dr["workCarDetails"]);
    //                am.workOther = Convert.ToInt32(dr["workOther"]);
    //                am.workCarRegInfo = Convert.ToInt32(dr["workCarRegInfo"]);
    //                am.miscSticker = Convert.ToInt32(dr["miscSticker"]);
    //                am.miscStickerMemo = Convert.ToString(dr["miscStickerMemo"]);
    //                am.miscInsurance = Convert.ToInt32(dr["miscInsurance"]);
    //                am.miscGuide = Convert.ToInt32(dr["miscGuide"]);
    //                am.miscGift = Convert.ToInt32(dr["miscGift"]);
    //                am.miscGiftMemo = Convert.ToString(dr["miscGiftMemo"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(int orderCarID, int workContract, int workQuotation, int workCarDetails, int workOther, int workCarRegInfo, int miscSticker, String miscStickerMemo, int miscInsurance, int miscGuide, int miscGift, String miscGiftMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderIrregular(orderCarID,workContract,workQuotation,workCarDetails,workOther,workCarRegInfo,miscSticker,miscStickerMemo,miscInsurance,miscGuide,miscGift,miscGiftMemo) values (" + orderCarID + "," + workContract + "," + workQuotation + "," + workCarDetails + "," + workOther + "," + workCarRegInfo + "," + miscSticker + ",'" + miscStickerMemo + "'," + miscInsurance + "," + miscGuide + "," + miscGift + ",'" + miscGiftMemo + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int orderIrregularTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from OrderIrregular where orderIrregularTID = " + orderIrregularTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(int orderCarID, int workContract, int workQuotation, int workCarDetails, int workOther, int workCarRegInfo, int miscSticker, String miscStickerMemo, int miscInsurance, int miscGuide, int miscGift, String miscGiftMemo)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderIrregular set orderCarID =" + orderCarID + ",workContract =" + workContract + ",workQuotation =" + workQuotation + ",workCarDetails =" + workCarDetails + ",workOther =" + workOther + ",workCarRegInfo =" + workCarRegInfo + ",miscSticker =" + miscSticker + ",miscStickerMemo ='" + miscStickerMemo + "',miscInsurance =" + miscInsurance + ",miscGuide =" + miscGuide + ",miscGift =" + miscGift + ",miscGiftMemo ='" + miscGiftMemo + "' where orderIrregularTID = " + this.orderIrregularTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update OrderIrregular set orderCarID =" + this.orderCarID + ",workContract =" + this.workContract + ",workQuotation =" + this.workQuotation + ",workCarDetails =" + this.workCarDetails + ",workOther =" + this.workOther + ",workCarRegInfo =" + this.workCarRegInfo + ",miscSticker =" + this.miscSticker + ",miscStickerMemo ='" + this.miscStickerMemo + "',miscInsurance =" + this.miscInsurance + ",miscGuide =" + this.miscGuide + ",miscGift =" + this.miscGift + ",miscGiftMemo ='" + this.miscGiftMemo + "' where orderIrregularTID = " + this.orderIrregularTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "OrderIrregular");
    //            if (ds.Tables["OrderIrregular"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["OrderIrregular"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregular.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


