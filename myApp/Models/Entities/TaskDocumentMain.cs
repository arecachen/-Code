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
    public partial class TaskDocumentMain
    {
        public string? TaskName { get; set; } //不可空值,任務名稱 
        public string? TaskStatus { get; set; } //不可空值,任務狀態(使用中，空閒) 
        public int TaskDocumentMainTID { get; set; } //不可空值, 
        public Collection<TaskDocumentMain> findAll()
        {
            Collection<TaskDocumentMain> c = null;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select("select * from TaskDocumentMain order by TaskDocumentMainTID asc", "TaskDocumentMain");
                if (ds.Tables["TaskDocumentMain"].Rows.Count > 0)
                {
                    c = new Collection<TaskDocumentMain>();
                    foreach (DataRow dr in ds.Tables["TaskDocumentMain"].Rows)
                    {
                        TaskDocumentMain am = new TaskDocumentMain();
                        am.TaskName = Convert.ToString(dr["TaskName"]);
                        am.TaskStatus = Convert.ToString(dr["TaskStatus"]);
                        am.TaskDocumentMainTID = Convert.ToInt32(dr["TaskDocumentMainTID"]);
                        c.Add(am);
                    }
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.findAll() : " + e.ToString());
            }
            return c;
        }


        public Collection<TaskDocumentMain> findByKeyword(string? sqlCmd)
        {
            Collection<TaskDocumentMain> c = null;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select(sqlCmd, "TaskDocumentMain");
                if (ds.Tables["TaskDocumentMain"].Rows.Count > 0)
                {
                    c = new Collection<TaskDocumentMain>();
                    foreach (DataRow dr in ds.Tables["TaskDocumentMain"].Rows)
                    {
                        TaskDocumentMain am = new TaskDocumentMain();
                        am.TaskName = Convert.ToString(dr["TaskName"]);
                        am.TaskStatus = Convert.ToString(dr["TaskStatus"]);
                        am.TaskDocumentMainTID = Convert.ToInt32(dr["TaskDocumentMainTID"]);
                        c.Add(am);
                    }
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.findByKeyword() : " + e.ToString());
            }
            return c;
        }


        public TaskDocumentMain findByPrimaryKey(int TaskDocumentMainTID)
        {
            TaskDocumentMain am = null;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "select * FROM TaskDocumentMain a WHERE a.TaskDocumentMainTID = " + TaskDocumentMainTID;
                DataSet ds = my.select(sqlCmd, "TaskDocumentMain");
                if (ds.Tables["TaskDocumentMain"].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables["TaskDocumentMain"].Rows[0];
                    am = new TaskDocumentMain();
                    am.TaskName = Convert.ToString(dr["TaskName"]);
                    am.TaskStatus = Convert.ToString(dr["TaskStatus"]);
                    am.TaskDocumentMainTID = Convert.ToInt32(dr["TaskDocumentMainTID"]);
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.findByPrimaryKey() : " + e.ToString());
            }
            return am;
        }


        public int create(string? TaskName, string? TaskStatus)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "insert into TaskDocumentMain(TaskName,TaskStatus) values ('" + TaskName + "','" + TaskStatus + "')";
                count = my.insertBackIdentity(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.create() : " + e.ToString());
            }
            return count;
        }


        public int Delete(int TaskDocumentMainTID)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "delete from TaskDocumentMain where TaskDocumentMainTID = " + TaskDocumentMainTID;
                count = my.delete(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.delete() : " + e.ToString());
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
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.DeleteByKeyword() : " + e.ToString());
            }
            return count;
        }


        public int update(string? TaskName, string? TaskStatus)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "update TaskDocumentMain set TaskName ='" + TaskName + "',TaskStatus ='" + TaskStatus + "' where TaskDocumentMainTID = " + this.TaskDocumentMainTID;
                count = my.update(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.create() : " + e.ToString());
            }
            return count;
        }


        public int update()
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "update TaskDocumentMain set TaskName ='" + this.TaskName + "',TaskStatus ='" + this.TaskStatus + "' where TaskDocumentMainTID = " + this.TaskDocumentMainTID;
                count = my.update(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.update() : " + e.ToString());
            }
            return count;
        }


        public int TotalCountByKeyword(string? sqlCmd)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                DataSet ds = my.select(sqlCmd, "TaskDocumentMain");
                if (ds.Tables["TaskDocumentMain"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["TaskDocumentMain"].Rows[0];
                    count = Convert.ToInt32(dr[0]);
                }
            }
            catch (Exception e)
            {
                count = 0;
                new log().wiriteSystemLog("hsintongERP2022.Models.TaskDocumentMain.TotalCountByKeyword() : " + e.ToString());
            }
            return count;
        }


    }
}


