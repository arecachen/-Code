namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarAppointment")]
    public partial class CarAppointment
    {
        [Key]
        public int carOrderAppointmentTID { get; set; }

        [Required]
        [StringLength(15)]
        public string? carID { get; set; }

        public int carOrderInfoID { get; set; }

        public long useDate { get; set; }

        public int carStartHour { get; set; }

        public int carStartMin { get; set; }

        public int driver { get; set; }

        [Required]
        [StringLength(15)]
        public string? apptType { get; set; }

        [Required]
        [StringLength(30)]
        public string? apptMemo { get; set; }

        [StringLength(60)]
        public string? apptJobMemo { get; set; }

        public int apptSalary { get; set; }

        public int apptCharge { get; set; }

        [Required]
        [StringLength(25)]
        public string? status { get; set; }

        public int final { get; set; }

        [StringLength(30)]
        public string? carType { get; set; }

        public int passengerCount { get; set; }

        public int? cost { get; set; }

        public virtual EmployeeMain? EmployeeMain { get; set; }

        public virtual OrderCarInfo OrderCarInfo { get; set; }
        public bool deleted { get; set; } = false;
    }
}
