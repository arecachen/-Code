namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_carLastMiles
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string? carID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long lastFuleDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long lastMile { get; set; }

        public decimal? purchaseMile { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int busAllian { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string? carStatus { get; set; }
    }
}
