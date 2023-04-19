namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Text.RegularExpressions;
    using System.Text;

    [Table("CarAccidentFile")]
    public partial class CarAccidentFile
    {
        [Key]
        public int CarAccidentFileTID { get; set; }

        public int carAccidentID { get; set; }

        [Required]
        [StringLength(256)]
        public string? caf_RelName { get; set; }

        [Required]
        [StringLength(256)]
        public string? caf_SysName { get; set; }
   
        public bool deleted { get; set; } = false;
        public int create(int carAccidentID, string?caf_RelName, string?caf_SysName)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool("");
                StringBuilder sb_value = new StringBuilder();
                sb_value.Append(carAccidentID + ",");
                sb_value.Append((String.IsNullOrEmpty(caf_RelName) ? "''" : "N'" + Regex.Replace(caf_RelName, "'", "''") + "'") + ",");
                sb_value.Append((String.IsNullOrEmpty(caf_SysName) ? "''" : "N'" + Regex.Replace(caf_SysName, "'", "''") + "'"));

                string? sqlCmd = "insert into CarAccidentFile(carAccidentID,caf_RelName,caf_SysName) values (" + sb_value.ToString() + ")";
                count = my.insertBackIdentity(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.CarAccidentFile.create() : " + e.ToString());
            }
            return count;
        }
    }
}
