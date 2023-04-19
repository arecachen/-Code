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
    //public partial class CarPartItemWithCorporationExt : CarPartItemWithCorporation
    //{
    //    public int deleteByItemKey(int itemKey)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarPartItemWithCorporation where carPartItemID = " + itemKey;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporationExt.deleteByItemKey() : " + e.ToString());
    //        }
    //        return count;
    //    }

    //    public int deleteByCorpKey(int corpKey)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from CarPartItemWithCorporation where corporationID = " + corpKey;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarPartItemWithCorporationExt.deleteByCorpKey() : " + e.ToString());
    //        }
    //        return count;
    //    }
    //}
}