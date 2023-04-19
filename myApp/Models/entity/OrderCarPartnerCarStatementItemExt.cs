using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class OrderCarPartnerCarStatementItemExt : OrderCarPartnerCarStatementItem
    //{
    //    public String buildCreateString(int OrderCarPartnerCarStatementMainID, int OrderCarJobID, String PartnerInfoType, String PCSItemDirection, double PCSItemPrice)
    //    {
    //        StringBuilder sb_value = new StringBuilder();
    //        sb_value.Append(OrderCarPartnerCarStatementMainID + ",");
    //        sb_value.Append(OrderCarJobID + ",");
    //        sb_value.Append((String.IsNullOrEmpty(PartnerInfoType) ? "''" : "N'" + Regex.Replace(PartnerInfoType, "'", "''") + "'") + ",");
    //        sb_value.Append((String.IsNullOrEmpty(PCSItemDirection) ? "''" : "N'" + Regex.Replace(PCSItemDirection, "'", "''") + "'") + ",");
    //        sb_value.Append(PCSItemPrice);

    //        String sqlCmd = "insert into OrderCarPartnerCarStatementItem(OrderCarPartnerCarStatementMainID,OrderCarJobID,PartnerInfoType,PCSItemDirection,PCSItemPrice) values (" + sb_value.ToString() + ");";
    //        return sqlCmd;
    //    }
    //}
}