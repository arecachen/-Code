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

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class OrderCarJobMainExt : OrderCarJobMain
    //{
    //    public OrderCarJobMain findByUseDate(long useDate)
    //    {
    //        OrderCarJobMain am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM OrderCarJobMain a WHERE a.CarJobDate = " + useDate;
    //            DataSet ds = my.select(sqlCmd, "OrderCarJobMain");
    //            if (ds.Tables["OrderCarJobMain"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["OrderCarJobMain"].Rows[0];
    //                am = new OrderCarJobMain();
    //                am.CarJobDate = Convert.ToInt64(dr["CarJobDate"]);
    //                am.CarJobMemo = Convert.ToString(dr["CarJobMemo"]);
    //                am.CarJobStatus = Convert.ToString(dr["CarJobStatus"]);
    //                am.CarJobFinalBy = Convert.ToString(dr["CarJobFinalBy"]);
    //                am.CarJobFinalDate = Convert.ToInt64(dr["CarJobFinalDate"]);
    //                am.OrderCarJobMainTID = Convert.ToInt32(dr["OrderCarJobMainTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarJobMain.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }
    //}
}