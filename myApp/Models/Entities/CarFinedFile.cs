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

    [Table("CarFinedFile")]
    public partial class CarFinedFile
    {
        [Key]
        public int CarFinedFileTID { get; set; }

        public int CarFinedID { get; set; }

        [Required]
        [StringLength(256)]
        public string? cffRelName { get; set; }

        [Required]
        [StringLength(256)]
        public string? cffSysName { get; set; }

        public bool deleted { get; set; } = false;

        public int create(int CarFinedID, string? cffRelName, string? cffSysName)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool("");
                StringBuilder sb_value = new StringBuilder();
                sb_value.Append(CarFinedID + ",");
                sb_value.Append((String.IsNullOrEmpty(cffRelName) ? "''" : "N'" + Regex.Replace(cffRelName, "'", "''") + "'") + ",");
                sb_value.Append((String.IsNullOrEmpty(cffSysName) ? "''" : "N'" + Regex.Replace(cffSysName, "'", "''") + "'"));

                string? sqlCmd = "insert into CarFinedFile(CarFinedID,cffRelName,cffSysName) values (" + sb_value.ToString() + ")";
                count = my.insertBackIdentity(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.CarFinedFile.create() : " + e.ToString());
            }
            return count;
        }
    }
}
