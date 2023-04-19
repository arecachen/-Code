namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_ExportForCalculateSalary
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarInfoTID { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string? custName { get; set; }

        [StringLength(100)]
        public string? rentArriveLocation { get; set; }

        [StringLength(256)]
        public string? journey { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoInMemo { get; set; }

        [Column(TypeName = "text")]
        public string? carInfoExMemo { get; set; }

        public int? price { get; set; }

        public int? priceTour { get; set; }

        public int? priceTip { get; set; }

        public int? priceParking { get; set; }

        public int? priceTax { get; set; }

        [StringLength(50)]
        public string? carGuide { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string? OrderStatus { get; set; }

        [StringLength(20)]
        public string? OrderInfoStatus { get; set; }

        [StringLength(50)]
        public string? DriverName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCarJobTID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carOrderInfoID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carOrderRegularInfoID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceOrderCarJobID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(15)]
        public string? carID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int driver { get; set; }

        [StringLength(30)]
        public string? carType { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long useDate { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carStartHour { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carStartMin { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carEndHour { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carEndMin { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(15)]
        public string? apptType { get; set; }

        [Key]
        [Column(Order = 16)]
        public string? apptMemo { get; set; }

        public string? apptJobMemo { get; set; }

        public string? unpickMemo { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int apptSalary { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int apptCharge { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isTakeApart { get; set; }

        [Key]
        [Column(Order = 20)]
        public int? cost { get; set; }

        [Key]
        [Column(Order = 21)]
        public int? SalaryTips { get; set; }

        [Key]
        [Column(Order = 22)]
        public int? SalaryTrip { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(20)]
        public string? finalStatus { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(50)]
        public string? JobSource { get; set; }

        [Column(TypeName = "text")]
        public string? CheckinLocation { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(50)]
        public string? empName { get; set; }
    }
}
