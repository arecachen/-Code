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
    //public partial class AccessControlGroupExt
    //{
    //    public int accessControlID { get; set; } //不可空值,頁面特殊權限控制項 群組隸屬控制項 的控制項ID  FK_AccessControl.accessControlTID 
    //    public int menuGroupID { get; set; } //不可空值,頁面特殊權限控制項 群組隸屬 的群組ID  FK_MenuGroup.groupTID 

    //    public int updateData(AccessControlGroupExt[] createData, string[] deleteData)
    //    {
    //        int count = 0;
    //        string sqlCmd = "";
    //        try
    //        {
    //            foreach (AccessControlGroupExt AC in createData)
    //            {
    //                if (AC != null)
    //                {
    //                    sqlCmd += "insert into AccessControlGroup(accessControlID,menuGroupID) values (" + AC.accessControlID + "," + AC.menuGroupID + "); ";
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }
    //            foreach (string str in deleteData)
    //            {
    //                if (str != null && str != "")
    //                {
    //                    sqlCmd += "delete from AccessControlGroup where accessControlGroupTID = " + str + ";";
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }
    //            MssqlTool my = new MssqlTool();
    //            count = my.update(sqlCmd);
    //            count = 1;
    //        }
    //        catch (Exception ex)
    //        {
    //            new log().wiriteSystemLog("AccessControlGroupExt_updateData_Error:" + ex.ToString());
    //        }
    //        return count;
    //    }
    //}
}