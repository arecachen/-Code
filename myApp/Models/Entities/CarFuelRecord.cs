namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarFuelRecord")]
    public partial class CarFuelRecord
    {
        

        [Key]
        public int carFuelRecordTID { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "������������")]
        public string? carID { get; set; }
        public long carRecordTime { get; set; }
        public long fuelDatetime { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = "�[�o�ȵ{�ƥ�������")]
        public long fuelMile { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "�[�o���ɼƥ�������")]
        public int? fuelFilled { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "�O�Υ�������")]
        public int? fuelCost { get; set; }

        public int fuelCorpID { get; set; }

        [Column(TypeName = "text")]
        public string? fuelMemo { get; set; }

        public int? fuelKmPerLiter { get; set; }

        public int? fuelCostPerKm { get; set; }

        public int fuelMissedLastTime { get; set; }
        [ForeignKey("carID")]
        public virtual CarMain CarMain { get; set; }

        public virtual Corporation Corporation { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "���������������")]
        public string? sCarRecordTime
        {
            get { return ((long?)carRecordTime).LongToDateString(); }
            set { carRecordTime = value.ToDateLong(); }
        }
        [NotMapped]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "�[�o�����������")]
        public string? sFuelDatetime
        {
            get { return ((long?)fuelDatetime).LongToDateString(); }
            set { fuelDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        public bool? bFuelMissedLastTime
        {
            get { return fuelMissedLastTime > 0; }
            set { fuelMissedLastTime = (value.HasValue && value.Value) ? 1 : 0; }
        }
        [NotMapped]
        public int sumMile { get; set; }
        [NotMapped]
        public int sumFilled { get; set; }
        [NotMapped]
        public int sumCost { get; set; }
        [NotMapped]
        public double avgMile { get; set; }
        [NotMapped]
        public double avgCost { get; set; }
        [NotMapped]
        public string? carSize { get; set; }
        
    }
}
