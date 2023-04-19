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
    public partial class TaskCol
    {
        public int TaskDocumentMainID { get; set; } //ä¸???¯ç©º???,ä»»å??TID 
        public string? ColName { get; set; } //ä¸???¯ç©º???,æ¨???­å??ç¨? 
        public int ColOrder { get; set; } //ä¸???¯ç©º???,æ¨???­æ??åº? 
        public string? ColType { get; set; } //ä¸???¯ç©º???,è¡?????????? 
        public int TaskColTID { get; set; } //ä¸???¯ç©º???, 
        public Collection<TaskCol> findAll()
        {
            Collection<TaskCol> c = null;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select("select * from TaskCol order by TaskColTID asc", "TaskCol");
                if (ds.Tables["TaskCol"].Rows.Count > 0)
                {
                    c = new Collection<TaskCol>();
                    foreach (DataRow dr in ds.Tables["TaskCol"].Rows)
                    {
                        TaskCol am = new TaskCol();
                        am.TaskDocumentMainID = Convert.ToInt32(dr["TaskDocumentMainID"]);
                        am.ColName = Convert.ToString(dr["ColName"]);
                        am.ColOrder = Convert.ToInt32(dr["ColOrder"]);
                        am.ColType = Convert.ToString(dr["ColType"]);
                        am.TaskColTID = Convert.ToInt32(dr["TaskColTID"]);
                        c.Add(am);
                    }
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.findAll() : " + e.ToString());
            }
            return c;
        }


        public Collection<TaskCol> findByKeyword(string? sqlCmd)
        {
            Collection<TaskCol> c = null;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select(sqlCmd, "TaskCol");
                if (ds.Tables["TaskCol"].Rows.Count > 0)
                {
                    c = new Collection<TaskCol>();
                    foreach (DataRow dr in ds.Tables["TaskCol"].Rows)
                    {
                        TaskCol am = new TaskCol();
                        am.TaskDocumentMainID = Convert.ToInt32(dr["TaskDocumentMainID"]);
                        am.ColName = Convert.ToString(dr["ColName"]);
                        am.ColOrder = Convert.ToInt32(dr["ColOrder"]);
                        am.ColType = Convert.ToString(dr["ColType"]);
                        am.TaskColTID = Convert.ToInt32(dr["TaskColTID"]);
                        c.Add(am);
                    }
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.findByKeyword() : " + e.ToString());
            }
            return c;
        }


        public TaskCol findByPrimaryKey(int TaskColTID)
        {
            TaskCol am = null;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "select * FROM TaskCol a WHERE a.TaskColTID = " + TaskColTID;
                DataSet ds = my.select(sqlCmd, "TaskCol");
                if (ds.Tables["TaskCol"].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables["TaskCol"].Rows[0];
                    am = new TaskCol();
                    am.TaskDocumentMainID = Convert.ToInt32(dr["TaskDocumentMainID"]);
                    am.ColName = Convert.ToString(dr["ColName"]);
                    am.ColOrder = Convert.ToInt32(dr["ColOrder"]);
                    am.ColType = Convert.ToString(dr["ColType"]);
                    am.TaskColTID = Convert.ToInt32(dr["TaskColTID"]);
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.findByPrimaryKey() : " + e.ToString());
            }
            return am;
        }


        public int create(int TaskDocumentMainID, string? ColName, int ColOrder, string? ColType)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "insert into TaskCol(TaskDocumentMainID,ColName,ColOrder,ColType) values (" + TaskDocumentMainID + ",'" + ColName + "'," + ColOrder + ",'" + ColType + "')";
                count = my.insertBackIdentity(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.create() : " + e.ToString());
            }
            return count;
        }


        public int Delete(int TaskColTID)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "delete from TaskCol where TaskColTID = " + TaskColTID;
                count = my.delete(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.delete() : " + e.ToString());
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
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.DeleteByKeyword() : " + e.ToString());
            }
            return count;
        }


        public int update(int TaskDocumentMainID, string? ColName, int ColOrder, string? ColType)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "update TaskCol set TaskDocumentMainID =" + TaskDocumentMainID + ",ColName ='" + ColName + "',ColOrder =" + ColOrder + ",ColType ='" + ColType + "' where TaskColTID = " + this.TaskColTID;
                count = my.update(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.create() : " + e.ToString());
            }
            return count;
        }


        public int update()
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "update TaskCol set TaskDocumentMainID =" + this.TaskDocumentMainID + ",ColName ='" + this.ColName + "',ColOrder =" + this.ColOrder + ",ColType ='" + this.ColType + "' where TaskColTID = " + this.TaskColTID;
                count = my.update(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.update() : " + e.ToString());
            }
            return count;
        }


        public int TotalCountByKeyword(string? sqlCmd)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select(sqlCmd, "TaskCol");
                if (ds.Tables["TaskCol"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["TaskCol"].Rows[0];
                    count = Convert.ToInt32(dr[0]);
                }
            }
            catch (Exception e)
            {
                count = 0;
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskCol.TotalCountByKeyword() : " + e.ToString());
            }
            return count;
        }


    }
}


