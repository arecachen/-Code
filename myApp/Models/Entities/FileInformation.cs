namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileInformation")]
    public partial class FileInformation
    {
        [Key]
        public int FileInformationTID { get; set; }

        [Required]
        [StringLength(256)]
        public string? InfoRelName { get; set; }

        [Required]
        [StringLength(256)]
        public string? InfoSysName { get; set; }

        public int FileFolderID { get; set; }

        public virtual FileFolder? FileFolder { get; set; }

        public bool deleted { get; set; } = false;
        public int create(string? InfoRelName, string? InfoSysName, int FileFolderID)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool();
                string? sqlCmd = "insert into FileInformation(InfoRelName,InfoSysName,FileFolderID) values ('" + InfoRelName + "','" + InfoSysName + "'," + FileFolderID + ")";
                count = my.insertBackIdentity(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.FileInformation.create() : " + e.ToString());
            }
            return count;
        }
    }
}
