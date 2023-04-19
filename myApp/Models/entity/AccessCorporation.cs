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
//public partial class AccessCorporation{

//public Collection<AccessCorporation> findAll()
//{
//Collection<AccessCorporation> c = null;
//try
//{
//MssqlTool my = new MssqlTool();
//DataSet ds = my.select("select * from AccessCorporation order by loginTID asc", "AccessCorporation");
//if (ds.Tables["AccessCorporation"].Rows.Count > 0)
//{
//c = new Collection<AccessCorporation>();
//foreach (DataRow dr in ds.Tables["AccessCorporation"].Rows)
//{
//AccessCorporation am = new AccessCorporation();
//am.loginTID =  Convert.ToInt32(dr["loginTID"]);
//am.corpID =  Convert.ToInt32(dr["corpID"]);
//am.loginID =  Convert.ToString(dr["loginID"]);
//am.loginPWD =  Convert.ToString(dr["loginPWD"]);
//am.empEmail =  Convert.ToString(dr["empEmail"]);
//am.accGroup =  Convert.ToString(dr["accGroup"]);
//am.status =  Convert.ToString(dr["status"]);
//c.Add(am);
//}
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.findAll() : " + e.ToString());
//}
//return c;
//}


//public Collection<AccessCorporation> findByKeyword(String sqlCmd)
//{
//Collection<AccessCorporation> c = null;
//try
//{
//MssqlTool my = new MssqlTool();
//DataSet ds = my.select(sqlCmd, "AccessCorporation");
//if (ds.Tables["AccessCorporation"].Rows.Count > 0)
//{
//c = new Collection<AccessCorporation>();
//foreach (DataRow dr in ds.Tables["AccessCorporation"].Rows)
//{
//AccessCorporation am = new AccessCorporation();
//am.loginTID =  Convert.ToInt32(dr["loginTID"]);
//am.corpID =  Convert.ToInt32(dr["corpID"]);
//am.loginID =  Convert.ToString(dr["loginID"]);
//am.loginPWD =  Convert.ToString(dr["loginPWD"]);
//am.empEmail =  Convert.ToString(dr["empEmail"]);
//am.accGroup =  Convert.ToString(dr["accGroup"]);
//am.status =  Convert.ToString(dr["status"]);
//c.Add(am);
//}
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.findByKeyword() : " + e.ToString());
//}
//return c;
//}


//public AccessCorporation findByPrimaryKey(int loginTID)
//{
//AccessCorporation am = null;
//try
//{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "select * FROM AccessCorporation a WHERE a.loginTID = " + loginTID;
//DataSet ds = my.select(sqlCmd, "AccessCorporation");
//if (ds.Tables["AccessCorporation"].Rows.Count == 1)
//{
//DataRow dr = ds.Tables["AccessCorporation"].Rows[0];
//am = new AccessCorporation();
//am.loginTID =  Convert.ToInt32(dr["loginTID"]);
//am.corpID =  Convert.ToInt32(dr["corpID"]);
//am.loginID =  Convert.ToString(dr["loginID"]);
//am.loginPWD =  Convert.ToString(dr["loginPWD"]);
//am.empEmail =  Convert.ToString(dr["empEmail"]);
//am.accGroup =  Convert.ToString(dr["accGroup"]);
//am.status =  Convert.ToString(dr["status"]);
//}
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.findByPrimaryKey() : " + e.ToString());
//}
//return am;
//}


//public int create( int corpID, String loginID, String loginPWD, String empEmail, String accGroup, String status)
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "insert into AccessCorporation(corpID,loginID,loginPWD,empEmail,accGroup,status) values ("+corpID+",'"+loginID+"','"+loginPWD+"','"+empEmail+"','"+accGroup+"','"+status+"')";
//count = my.insertBackIdentity(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.create() : " + e.ToString());
//}
//return count;
//}


//public int Delete(int loginTID)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "delete from AccessCorporation where loginTID = " + loginTID;
//count = my.delete(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.delete() : " + e.ToString());
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
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.DeleteByKeyword() : " + e.ToString());
//}
//return count;
//}


//public int update( int corpID, String loginID, String loginPWD, String empEmail, String accGroup, String status)
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "update AccessCorporation set corpID =" + corpID + ",loginID ='" + loginID + "',loginPWD ='" + loginPWD + "',empEmail ='" + empEmail + "',accGroup ='" + accGroup + "',status ='" + status + "' where loginTID = " + this.loginTID;
//count = my.update(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.create() : " + e.ToString());
//}
//return count;
//}


//public int update()
//{
//int count = 0;
//try{
//MssqlTool my = new MssqlTool();
//String sqlCmd = "update AccessCorporation set corpID =" + this.corpID + ",loginID ='" + this.loginID + "',loginPWD ='" + this.loginPWD + "',empEmail ='" + this.empEmail + "',accGroup ='" + this.accGroup + "',status ='" + this.status + "' where loginTID = " + this.loginTID;
//count = my.update(sqlCmd);
//}
//catch (Exception e)
//{
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.update() : " + e.ToString());
//}
//return count;
//}


//public int TotalCountByKeyword(String sqlCmd)
//{
//int count = 0;
//try
//{
//MssqlTool my = new MssqlTool();
//DataSet ds = my.select(sqlCmd, "AccessCorporation");
//if (ds.Tables["AccessCorporation"].Rows.Count > 0)
//{
//DataRow dr = ds.Tables["AccessCorporation"].Rows[0];
//count = Convert.ToInt32(dr[0]);
//}
//}
//catch (Exception e)
//{
//count = 0;
//new log().wiriteSystemLog("hsintongERP2022.Models.AccessCorporation.TotalCountByKeyword() : " + e.ToString());
//}
//return count;
//}


//}
}


