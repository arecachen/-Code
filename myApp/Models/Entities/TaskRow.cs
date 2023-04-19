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
    public partial class TaskRow
    {
        public int TaskDocumentMainID { get; set; } //不可空值,任務TID 
        public int TaskColID { get; set; } //不可空值,標頭ID 
        public string? RowValue { get; set; } //不可空值,資料列內容 
        public int RowOrder { get; set; } //不可空值,資料列排序 
        public int TaskRowTID { get; set; } //不可空值, 
        public Collection<TaskRow> findAll()
        {
            Collection<TaskRow> c = null;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select("select * from TaskRow order by TaskRowTID asc", "TaskRow");
                if (ds.Tables["TaskRow"].Rows.Count > 0)
                {
                    c = new Collection<TaskRow>();
                    foreach (DataRow dr in ds.Tables["TaskRow"].Rows)
                    {
                        TaskRow am = new TaskRow();
                        am.TaskDocumentMainID = Convert.ToInt32(dr["TaskDocumentMainID"]);
                        am.TaskColID = Convert.ToInt32(dr["TaskColID"]);
                        am.RowValue = Convert.ToString(dr["RowValue"]);
                        am.RowOrder = Convert.ToInt32(dr["RowOrder"]);
                        am.TaskRowTID = Convert.ToInt32(dr["TaskRowTID"]);
                        c.Add(am);
                    }
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.findAll() : " + e.ToString());
            }
            return c;
        }


        public Collection<TaskRow> findByKeyword(string? sqlCmd)
        {
            Collection<TaskRow> c = null;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select(sqlCmd, "TaskRow");
                if (ds.Tables["TaskRow"].Rows.Count > 0)
                {
                    c = new Collection<TaskRow>();
                    foreach (DataRow dr in ds.Tables["TaskRow"].Rows)
                    {
                        TaskRow am = new TaskRow();
                        am.TaskDocumentMainID = Convert.ToInt32(dr["TaskDocumentMainID"]);
                        am.TaskColID = Convert.ToInt32(dr["TaskColID"]);
                        am.RowValue = Convert.ToString(dr["RowValue"]);
                        am.RowOrder = Convert.ToInt32(dr["RowOrder"]);
                        am.TaskRowTID = Convert.ToInt32(dr["TaskRowTID"]);
                        c.Add(am);
                    }
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.findByKeyword() : " + e.ToString());
            }
            return c;
        }


        public TaskRow findByPrimaryKey(int TaskRowTID)
        {
            TaskRow am = null;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "select * FROM TaskRow a WHERE a.TaskRowTID = " + TaskRowTID;
                DataSet ds = my.select(sqlCmd, "TaskRow");
                if (ds.Tables["TaskRow"].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables["TaskRow"].Rows[0];
                    am = new TaskRow();
                    am.TaskDocumentMainID = Convert.ToInt32(dr["TaskDocumentMainID"]);
                    am.TaskColID = Convert.ToInt32(dr["TaskColID"]);
                    am.RowValue = Convert.ToString(dr["RowValue"]);
                    am.RowOrder = Convert.ToInt32(dr["RowOrder"]);
                    am.TaskRowTID = Convert.ToInt32(dr["TaskRowTID"]);
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.findByPrimaryKey() : " + e.ToString());
            }
            return am;
        }


        public int create(int TaskDocumentMainID, int TaskColID, string? RowValue, int RowOrder)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "insert into TaskRow(TaskDocumentMainID,TaskColID,RowValue,RowOrder) values (" + TaskDocumentMainID + "," + TaskColID + ",'" + RowValue + "'," + RowOrder + ")";
                count = my.insertBackIdentity(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.create() : " + e.ToString());
            }
            return count;
        }


        public int Delete(int TaskRowTID)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "delete from TaskRow where TaskRowTID = " + TaskRowTID;
                count = my.delete(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.delete() : " + e.ToString());
            }
            return count;
        }


        public int DeleteByKeyword(string? sqlCmd)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                count = my.delete(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.DeleteByKeyword() : " + e.ToString());
            }
            return count;
        }


        public int update(int TaskDocumentMainID, int TaskColID, string? RowValue, int RowOrder)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "update TaskRow set TaskDocumentMainID =" + TaskDocumentMainID + ",TaskColID =" + TaskColID + ",RowValue ='" + RowValue + "',RowOrder =" + RowOrder + " where TaskRowTID = " + this.TaskRowTID;
                count = my.update(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.create() : " + e.ToString());
            }
            return count;
        }


        public int update()
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "update TaskRow set TaskDocumentMainID =" + this.TaskDocumentMainID + ",TaskColID =" + this.TaskColID + ",RowValue ='" + this.RowValue + "',RowOrder =" + this.RowOrder + " where TaskRowTID = " + this.TaskRowTID;
                count = my.update(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.update() : " + e.ToString());
            }
            return count;
        }


        public int TotalCountByKeyword(string? sqlCmd)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select(sqlCmd, "TaskRow");
                if (ds.Tables["TaskRow"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["TaskRow"].Rows[0];
                    count = Convert.ToInt32(dr[0]);
                }
            }
            catch (Exception e)
            {
                count = 0;
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskRow.TotalCountByKeyword() : " + e.ToString());
            }
            return count;
        }


    }
}


