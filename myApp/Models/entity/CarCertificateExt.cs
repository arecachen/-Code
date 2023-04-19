using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Howgreater.util;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    //public partial class CarCertificateExt : CarCertificate 
    //{
    //    public int updateByCarID(String carID, int certTypeID, String certID, String certImgSrc, String certImgShow, String cerDoc, int certRequiredUpdate, long certCreateDatetime, long certUpdateDatetime, long certRenewDate, String memo, String status)
    //    {
    //        int count = 0;
    //        try
    //        {
    //            MssqlTool my = new MssqlTool();
    //            String sqlCmd = "update CarCertificate set certTypeID =" + certTypeID + ",certID ='" + certID + "',certImgSrc ='" + certImgSrc + "',certImgShow ='" + certImgShow + "',cerDoc ='" + cerDoc + "',certRequiredUpdate =" + certRequiredUpdate + ",certCreateDatetime =" + certCreateDatetime + ",certUpdateDatetime =" + certUpdateDatetime + ",certRenewDate =" + certRenewDate + ",memo ='" + memo + "',status ='" + status + "' where carID = " + carID;
    //            count = my.update(sqlCmd);
    //        }
    //        catch (Exception e)
    //        {
    //            new log().wiriteSystemLog("hsintongERP2022.Models.CarCertificate.create() : " + e.ToString());
    //        }
    //        return count;
    //    }

    //    public string getImgfromCarID(string carId)
    //    {
    //        MssqlTool sql = new MssqlTool();
    //        String sqlCmd = "Select certImgSrc from CarCertificate where certImgShow = 1 and carId = '" + carId + "'";
    //        DataTable keyword = sql.findByKeywordDateTable(sqlCmd);
    //        if (keyword.Rows.Count > 0)
    //            return keyword.Rows[0][0].ToString();
    //        return "";
    //    }
    //}
}