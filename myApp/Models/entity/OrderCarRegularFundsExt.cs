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
    //public partial class OrderCarRegularFundsExt
    //{
    //    public string createExt(int OrderCarRegularInfoID, int OrderCarRegularClassID, int OrderCarRegularGroupID, int Funds)
    //    {
    //        String sqlCmd = "";
    //        try
    //        {
    //            StringBuilder sb_value = new StringBuilder();
    //            sb_value.Append(OrderCarRegularInfoID + ",");
    //            sb_value.Append(OrderCarRegularClassID + ",");
    //            sb_value.Append(OrderCarRegularGroupID + ",");
    //            sb_value.Append(Funds);

    //            sqlCmd = "insert into OrderCarRegularFunds(OrderCarRegularInfoID,OrderCarRegularClassID,OrderCarRegularGroupID,Funds) values (" + sb_value.ToString() + ");";
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.OrderCarRegularFundsExt.createExt() : " + e.ToString());
    //        }
    //        return sqlCmd;
    //    }
    //}
}