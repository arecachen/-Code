namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_orderCarPartner
    {
        public int? orderTID { get; set; }

        public int? orderCarInfoTID { get; set; }

        public int? price { get; set; }

        public int? customerTID { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        public int? OutBusAllian { get; set; }

        [StringLength(15)]
        public string? CarID { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        public int? InBusAllian { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long useDate { get; set; }

        [StringLength(30)]
        public string? carType { get; set; }

        [Key]
        [Column(Order = 1)]
        public string? apptMemo { get; set; }

        public string? apptJobMemo { get; set; }

        [Key]
        [Column(Order = 2)]
        public int? cost { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string? finalStatus { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string? JobSource { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCarJobTID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carOrderInfoID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carOrderRegularInfoID { get; set; }
    }
}
