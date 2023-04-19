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
    //public partial class DictionaryTableExt : DictionaryTable
    //{
    //    public Collection<DictionaryTable> findText(String category, String value, String status = "Active")
    //    {
    //        Collection<DictionaryTable> c = null;
    //        try
    //        {
    //            String sqlCmd = "Select * from DictionaryTable where dicCategory ='" + category + "' AND dicValue='" + value + "' AND dicStatus='" + status + "'";
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "DictionaryTable");
    //            if (ds.Tables["DictionaryTable"].Rows.Count > 0)
    //            {
    //                c = new Collection<DictionaryTable>();
    //                foreach (DataRow dr in ds.Tables["DictionaryTable"].Rows)
    //                {
    //                    DictionaryTable am = new DictionaryTable();
    //                    am.dictionaryTableTID = Convert.ToInt32(dr["dictionaryTableTID"]);
    //                    am.dicCategory = Convert.ToString(dr["dicCategory"]);
    //                    am.dicValue = Convert.ToString(dr["dicValue"]);
    //                    am.dicText = Convert.ToString(dr["dicText"]);
    //                    am.dicOrder = Convert.ToInt32(dr["dicOrder"]);
    //                    am.dicStatus = Convert.ToString(dr["dicStatus"]);
    //                    c.Add(am);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.findByKeyword() : " + e.ToString());
    //        }
    //        return c;
    //    }

    //    public DataTable findByCategory(String category, String status="Active")
    //    {
    //        String sqlCmd = "Select * from DictionaryTable where dicCategory ='" + category + "' AND dicStatus='" + status + "'";
    //        DataTable dt = new MssqlTool().findByKeywordDateTable(sqlCmd);
    //        return dt;
            
    //    }

    //    public int findCategoryLastOrder(String category, bool returnNextOrder = true, String status = "Active")
    //    {
    //        String sqlCmd = "Select Top 1 * from DictionaryTable where dicCategory ='" + category + "' AND dicStatus='" + status + "' order by dicOrder Desc";
    //        DataTable dt = new MssqlTool().findByKeywordDateTable(sqlCmd);
    //        int orderNumber = 0;
    //        if(dt != null && dt.Rows.Count >0)
    //        {
    //            int lastNumber = Convert.ToInt32(dt.Rows[0]["dicOrder"]);
    //            if (returnNextOrder)
    //            {
    //                orderNumber = lastNumber + 1;
    //            }
    //            else
    //            {
    //                orderNumber = lastNumber;
    //            }
    //        }

    //        return orderNumber;

    //    }
    //}
}