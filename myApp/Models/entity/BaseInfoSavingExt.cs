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
    //public partial class BaseInfoSavingExt : BaseInfoSaving
    //{
    //    public BaseInfoSaving findByColumnsName(string ColumnsName)
    //    {
    //        BaseInfoSaving am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM BaseInfoSaving a WHERE a." + ColumnsName + " is not null ";
    //            DataSet ds = my.select(sqlCmd, "BaseInfoSaving");
    //            if (ds.Tables["BaseInfoSaving"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["BaseInfoSaving"].Rows[0];
    //                am = new BaseInfoSaving();
    //                am.OrderCarJobBaseDate = dr["OrderCarJobBaseDate"] == DBNull.Value ? -999 : Convert.ToInt64(dr["OrderCarJobBaseDate"]);
    //                am.BaseInfoSavingTID = Convert.ToInt32(dr["BaseInfoSavingTID"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.BaseInfoSaving.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }
    //}
}