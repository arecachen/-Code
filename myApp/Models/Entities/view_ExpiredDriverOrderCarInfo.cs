namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_ExpiredDriverOrderCarInfo
    {
        [StringLength(50)]
        public string? empName { get; set; }

        [StringLength(50)]
        public string? InCharge { get; set; }

        [StringLength(15)]
        public string? empDuty { get; set; }

        public long? rentStartDate { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarInfoTID { get; set; }

        [StringLength(50)]
        public string? withCarContactName { get; set; }

        [StringLength(100)]
        public string? rentArriveLocation { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string? carType { get; set; }

        public int? carYear { get; set; }

        [StringLength(15)]
        public string? carAssign { get; set; }

        [StringLength(15)]
        public string? status { get; set; }

        public long? leaveDate { get; set; }

        public int? employeeTID { get; set; }

        public int? rentArriveHour { get; set; }

        public int? rentArriveMinute { get; set; }

        public int? leaveTimeStartHour { get; set; }

        public int? leaveTimeStartMin { get; set; }

        public int? leaveTimeEndHour { get; set; }

        public int? leaveTimeEndMin { get; set; }

        public long? leaveEndDate { get; set; }
    }
}
