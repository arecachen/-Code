namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarNotAvailable")]
    public partial class CarNotAvailable
    {
        [Key]
        public int carNATID { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "������������")]
        public string? carID { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = "�����L�k�ϥΤ����������")]
        public long carNADate { get; set; }

        public int carNAAllDay { get; set; }

        public int carNAStartHour { get; set; }

        public int carNAStartMin { get; set; }

        public int carNAEndHour { get; set; }

        public int carNAEndMin { get; set; }

        [StringLength(50)]
        public string? carNAReason { get; set; }

        public virtual CarMain CarMain { get; set; }

        public bool deleted { get; set; } = false;

        [NotMapped]
        public TimeSpan? carNAStartTime
        {
            get { return new TimeSpan(carNAStartHour, carNAStartMin, 0); }
            set
            {
                carNAStartHour = (value.HasValue) ? value.Value.Hours : 0;
                carNAStartMin = (value.HasValue) ? value.Value.Minutes : 0;
            }
        }
        [NotMapped]
        public TimeSpan? carNAEndTime
        {
            get { return new TimeSpan(carNAEndHour, carNAEndMin, 0); }
            set
            {
                carNAEndHour = (value.HasValue) ? value.Value.Hours : 0;
                carNAEndMin = (value.HasValue) ? value.Value.Minutes : 0;
            }
        }
        [NotMapped]
        public string? sCarNADate
        {
            get { return ((long?)carNADate).LongToDateString(); }
            set { carNADate = value.ToDateLong(); }
        }
        [NotMapped]
        public bool bCarNAAllDay
        {
            get { return (carNAAllDay > 0); }
            set { carNAAllDay = value ? 1 : 0; }
        }
    }
}
