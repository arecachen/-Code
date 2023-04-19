using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Howgreater.util;

using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
namespace hsintongERP2022.Models
{
//    public partial class CarFinedFile
//    {

//        public Collection<CarFinedFile> findAll()
//        {
//            Collection<CarFinedFile> c = null;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                DataSet ds = my.select("select * from CarFinedFile order by CarFinedFileTID asc", "CarFinedFile");
//                if (ds.Tables["CarFinedFile"].Rows.Count > 0)
//                {
//                    c = new Collection<CarFinedFile>();
//                    foreach (DataRow dr in ds.Tables["CarFinedFile"].Rows)
//                    {
//                        CarFinedFile am = new CarFinedFile();
//                        am.CarFinedID = Convert.ToInt32(dr["CarFinedID"]);
//                        am.cffRelName = Convert.ToString(dr["cffRelName"]);
//                        am.cffSysName = Convert.ToString(dr["cffSysName"]);
//                        am.CarFinedFileTID = Convert.ToInt32(dr["CarFinedFileTID"]);
//                        c.Add(am);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.findAll() : " + e.ToString());
//            }
//            return c;
//        }


//        public Collection<CarFinedFile> findByKeyword(String sqlCmd)
//        {
//            Collection<CarFinedFile> c = null;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                DataSet ds = my.select(sqlCmd, "CarFinedFile");
//                if (ds.Tables["CarFinedFile"].Rows.Count > 0)
//                {
//                    c = new Collection<CarFinedFile>();
//                    foreach (DataRow dr in ds.Tables["CarFinedFile"].Rows)
//                    {
//                        CarFinedFile am = new CarFinedFile();
//                        am.CarFinedID = Convert.ToInt32(dr["CarFinedID"]);
//                        am.cffRelName = Convert.ToString(dr["cffRelName"]);
//                        am.cffSysName = Convert.ToString(dr["cffSysName"]);
//                        am.CarFinedFileTID = Convert.ToInt32(dr["CarFinedFileTID"]);
//                        c.Add(am);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.findByKeyword() : " + e.ToString());
//            }
//            return c;
//        }


//        public CarFinedFile findByPrimaryKey(int CarFinedFileTID)
//        {
//            CarFinedFile am = null;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                String sqlCmd = "select * FROM CarFinedFile a WHERE a.CarFinedFileTID = " + CarFinedFileTID;
//                DataSet ds = my.select(sqlCmd, "CarFinedFile");
//                if (ds.Tables["CarFinedFile"].Rows.Count == 1)
//                {
//                    DataRow dr = ds.Tables["CarFinedFile"].Rows[0];
//                    am = new CarFinedFile();
//                    am.CarFinedID = Convert.ToInt32(dr["CarFinedID"]);
//                    am.cffRelName = Convert.ToString(dr["cffRelName"]);
//                    am.cffSysName = Convert.ToString(dr["cffSysName"]);
//                    am.CarFinedFileTID = Convert.ToInt32(dr["CarFinedFileTID"]);
//                }
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.findByPrimaryKey() : " + e.ToString());
//            }
//            return am;
//        }


//        public int create(int CarFinedID, String cffRelName, String cffSysName)
//        {
//            int count = 0;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                StringBuilder sb_value = new StringBuilder();
//                sb_value.Append(CarFinedID + ",");
//                sb_value.Append((String.IsNullOrEmpty(cffRelName) ? "''" : "N'" + Regex.Replace(cffRelName, "'", "''") + "'") + ",");
//                sb_value.Append((String.IsNullOrEmpty(cffSysName) ? "''" : "N'" + Regex.Replace(cffSysName, "'", "''") + "'"));

//                String sqlCmd = "insert into CarFinedFile(CarFinedID,cffRelName,cffSysName) values (" + sb_value.ToString() + ")";
//                count = my.insertBackIdentity(sqlCmd);
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.create() : " + e.ToString());
//            }
//            return count;
//        }


//        public int Delete(int CarFinedFileTID)
//        {
//            int count = 0;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                String sqlCmd = "delete from CarFinedFile where CarFinedFileTID = " + CarFinedFileTID;
//                count = my.delete(sqlCmd);
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.delete() : " + e.ToString());
//            }
//            return count;
//        }


//        public int DeleteByKeyword(String sqlCmd)
//        {
//            int count = 0;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                count = my.delete(sqlCmd);
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.DeleteByKeyword() : " + e.ToString());
//            }
//            return count;
//        }


//        public int update(int CarFinedID, String cffRelName, String cffSysName)
//        {
//            int count = 0;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                StringBuilder sb_value = new StringBuilder();
//                sb_value.Append("CarFinedID =" + CarFinedID + ",");
//                sb_value.Append("cffRelName=" + (String.IsNullOrEmpty(cffRelName) ? "''" : "N'" + Regex.Replace(cffRelName, "'", "''") + "'") + ",");
//                sb_value.Append("cffSysName=" + (String.IsNullOrEmpty(cffSysName) ? "''" : "N'" + Regex.Replace(cffSysName, "'", "''") + "'"));

//                String sqlCmd = "update CarFinedFile set  " + sb_value.ToString() + "  where CarFinedFileTID = " + this.CarFinedFileTID;
//                count = my.update(sqlCmd);
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.create() : " + e.ToString());
//            }
//            return count;
//        }


//        public int update()
//        {
//            int count = 0;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                StringBuilder sb_value = new StringBuilder();
//                sb_value.Append("CarFinedID =" + this.CarFinedID + ",");
//                sb_value.Append("cffRelName=" + (String.IsNullOrEmpty(this.cffRelName) ? "''" : "N'" + Regex.Replace(this.cffRelName, "'", "''") + "'") + ",");
//                sb_value.Append("cffSysName=" + (String.IsNullOrEmpty(this.cffSysName) ? "''" : "N'" + Regex.Replace(this.cffSysName, "'", "''") + "'"));

//                String sqlCmd = "update CarFinedFile set  " + sb_value.ToString() + "  where CarFinedFileTID = " + this.CarFinedFileTID;
//                count = my.update(sqlCmd);
//            }
//            catch (Exception e)
//            {
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.update() : " + e.ToString());
//            }
//            return count;
//        }


//        public int TotalCountByKeyword(String sqlCmd)
//        {
//            int count = 0;
//            try
//            {
//                MssqlTool my = new MssqlTool("");
//                DataSet ds = my.select(sqlCmd, "CarFinedFile");
//                if (ds.Tables["CarFinedFile"].Rows.Count > 0)
//                {
//                    DataRow dr = ds.Tables["CarFinedFile"].Rows[0];
//                    count = Convert.ToInt32(dr[0]);
//                }
//            }
//            catch (Exception e)
//            {
//                count = 0;
//                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.TotalCountByKeyword() : " + e.ToString());
//            }
//            return count;
//        }


//    }
}


