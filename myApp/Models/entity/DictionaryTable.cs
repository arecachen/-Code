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
    //public partial class DictionaryTable
    //{

    //    public Collection<DictionaryTable> findAll()
    //    {
    //        Collection<DictionaryTable> c = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select("select * from DictionaryTable order by dictionaryTableTID asc", "DictionaryTable");
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.findAll() : " + e.ToString());
    //        }
    //        return c;
    //    }


    //    public Collection<DictionaryTable> findByKeyword(String sqlCmd)
    //    {
    //        Collection<DictionaryTable> c = null;
    //        try
    //        {
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


    //    public DictionaryTable findByPrimaryKey(int dictionaryTableTID)
    //    {
    //        DictionaryTable am = null;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "select * FROM DictionaryTable a WHERE a.dictionaryTableTID = " + dictionaryTableTID;
    //            DataSet ds = my.select(sqlCmd, "DictionaryTable");
    //            if (ds.Tables["DictionaryTable"].Rows.Count == 1)
    //            {
    //                DataRow dr = ds.Tables["DictionaryTable"].Rows[0];
    //                am = new DictionaryTable();
    //                am.dictionaryTableTID = Convert.ToInt32(dr["dictionaryTableTID"]);
    //                am.dicCategory = Convert.ToString(dr["dicCategory"]);
    //                am.dicValue = Convert.ToString(dr["dicValue"]);
    //                am.dicText = Convert.ToString(dr["dicText"]);
    //                am.dicOrder = Convert.ToInt32(dr["dicOrder"]);
    //                am.dicStatus = Convert.ToString(dr["dicStatus"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.findByPrimaryKey() : " + e.ToString());
    //        }
    //        return am;
    //    }


    //    public int create(String dicCategory, String dicValue, String dicText, int dicOrder, String dicStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "insert into DictionaryTable(dicCategory,dicValue,dicText,dicOrder,dicStatus) values ('" + dicCategory + "','" + dicValue + "','" + dicText + "'," + dicOrder + ",'" + dicStatus + "')";
    //            count = my.insertBackIdentity(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int Delete(int dictionaryTableTID)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "delete from DictionaryTable where dictionaryTableTID = " + dictionaryTableTID;
    //            count = my.delete(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.delete() : " + e.ToString());
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
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.DeleteByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update(String dicCategory, String dicValue, String dicText, int dicOrder, String dicStatus)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update DictionaryTable set dicCategory ='" + dicCategory + "',dicValue ='" + dicValue + "',dicText ='" + dicText + "',dicOrder =" + dicOrder + ",dicStatus ='" + dicStatus + "' where dictionaryTableTID = " + this.dictionaryTableTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.create() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int update()
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update DictionaryTable set dicCategory ='" + this.dicCategory + "',dicValue ='" + this.dicValue + "',dicText ='" + this.dicText + "',dicOrder =" + this.dicOrder + ",dicStatus ='" + this.dicStatus + "' where dictionaryTableTID = " + this.dictionaryTableTID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.update() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //    public int TotalCountByKeyword(String sqlCmd)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            DataSet ds = my.select(sqlCmd, "DictionaryTable");
    //            if (ds.Tables["DictionaryTable"].Rows.Count > 0)
    //            {
    //                DataRow dr = ds.Tables["DictionaryTable"].Rows[0];
    //                count = Convert.ToInt32(dr[0]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            count = 0;
    //            new log().wiriteSystemLog("hsintongERP2022.Models.DictionaryTable.TotalCountByKeyword() : " + e.ToString());
    //        }
    //        return count;
    //    }


    //}
}


