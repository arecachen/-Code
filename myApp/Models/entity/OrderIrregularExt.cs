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
    //public partial class OrderIrregularExt : OrderIrregular
    //{
    //    public int createBackIdentity(int orderCarID, int workContract, int workQuotation, int workCarDetails, int workOther, int workCarRegInfo, int miscSticker, String miscStickerMemo, int miscInsurance, int miscGuide, int miscGift, String miscGiftMemo)
    //    {
    //        int insertID = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into OrderIrregular(orderCarID,workContract,workQuotation,workCarDetails,workOther,workCarRegInfo,miscSticker,miscStickerMemo,miscInsurance,miscGuide,miscGift,miscGiftMemo) values (" + orderCarID + "," + workContract + "," + workQuotation + "," + workCarDetails + "," + workOther + "," + workCarRegInfo + "," + miscSticker + ",'" + miscStickerMemo + "'," + miscInsurance + "," + miscGuide + "," + miscGift + ",'" + miscGiftMemo + "')";
    //            insertID = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CustomerExt.createBackIdentity() : " + e.ToString());
    //        }
    //        return insertID;
    //    }

    //    public int updateBySQL(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderIrregularExt.updateBySQL() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}