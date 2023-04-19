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
//public partial class AccessControlGroup
//    {

//public Collection<AccessControlGroup> findAll()
//{
//Collection<AccessControlGroup> c = null;
//try
//{
//MssqlTool my = new MssqlTool();
//DataSet ds = my.select("select * from AccessControlGroup order by accessControlGroupTID asc", "AccessControlGroup");
//if (ds.Tables["AccessControlGroup"].Rows.Count > 0)
//{
//c = new Collection<AccessControlGroup>();
//foreach (DataRow dr in ds.Tables["AccessControlGroup"].Rows)
//{
//AccessControlGroup am = new AccessControlGroup();
//am.accessControlID =  Convert.ToInt32(dr["accessControlID"]);
//am.menuGroupID =  Convert.ToInt32(dr["menuGroupID"]);
//am.accessControlGroupTID =  Convert.ToInt32(dr["accessControlGroupTID"]);
//c.Add(am);
//}
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.findAll() : " + e.ToString());
//}
//return c;
//}


//public Collection<AccessControlGroup> findByKeyword(String sqlCmd)
//{
//Collection<AccessControlGroup> c = null;
//try
//{
//MssqlTool my = new MssqlTool();
//DataSet ds = my.select(sqlCmd, "AccessControlGroup");
//if (ds.Tables["AccessControlGroup"].Rows.Count > 0)
//{
//c = new Collection<AccessControlGroup>();
//foreach (DataRow dr in ds.Tables["AccessControlGroup"].Rows)
//{
//AccessControlGroup am = new AccessControlGroup();
//am.accessControlID =  Convert.ToInt32(dr["accessControlID"]);
//am.menuGroupID =  Convert.ToInt32(dr["menuGroupID"]);
//am.accessControlGroupTID =  Convert.ToInt32(dr["accessControlGroupTID"]);
//c.Add(am);
//}
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.findByKeyword() : " + e.ToString());
//}
//return c;
//}


//public AccessControlGroup findByPrimaryKey(int accessControlGroupTID)
//{
//AccessControlGroup am = null;
//try
//{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "select * FROM AccessControlGroup a WHERE a.accessControlGroupTID = " + accessControlGroupTID;
//DataSet ds = my.select(sqlCmd, "AccessControlGroup");
//if (ds.Tables["AccessControlGroup"].Rows.Count == 1)
//{
//DataRow dr = ds.Tables["AccessControlGroup"].Rows[0];
//am = new AccessControlGroup();
//am.accessControlID =  Convert.ToInt32(dr["accessControlID"]);
//am.menuGroupID =  Convert.ToInt32(dr["menuGroupID"]);
//am.accessControlGroupTID =  Convert.ToInt32(dr["accessControlGroupTID"]);
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.findByPrimaryKey() : " + e.ToString());
//}
//return am;
//}


//public int create( int accessControlID, int menuGroupID)
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "insert into AccessControlGroup(accessControlID,menuGroupID) values ("+accessControlID+","+menuGroupID+")";
//count = my.insertBackIdentity(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.create() : " + e.ToString());
//}
//return count;
//}


//public int Delete(int accessControlGroupTID)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "delete from AccessControlGroup where accessControlGroupTID = " + accessControlGroupTID;
//count = my.delete(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.delete() : " + e.ToString());
//}
//return count;
//}


//public int DeleteByKeyword(String sqlCmd)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool();
//count = my.delete(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.DeleteByKeyword() : " + e.ToString());
//}
//return count;
//}


//public int update( int accessControlID, int menuGroupID)
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "update AccessControlGroup set accessControlID =" + accessControlID + ",menuGroupID =" + menuGroupID + " where accessControlGroupTID = " + this.accessControlGroupTID;
//count = my.update(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.create() : " + e.ToString());
//}
//return count;
//}


//public int update()
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "update AccessControlGroup set accessControlID =" + this.accessControlID + ",menuGroupID =" + this.menuGroupID + " where accessControlGroupTID = " + this.accessControlGroupTID;
//count = my.update(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.update() : " + e.ToString());
//}
//return count;
//}


//public int TotalCountByKeyword(String sqlCmd)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool();
//DataSet ds = my.select(sqlCmd, "AccessControlGroup");
//if (ds.Tables["AccessControlGroup"].Rows.Count > 0)
//{
//DataRow dr = ds.Tables["AccessControlGroup"].Rows[0];
//count = Convert.ToInt32(dr[0]);
//}
//}
//catch (Exception e)
//{
//count = 0;
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessControlGroup.TotalCountByKeyword() : " + e.ToString());
//}
//return count;
//}


//}
}


