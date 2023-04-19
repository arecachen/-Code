namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_carListForTrack
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string? CarID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carManuYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carManuMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string? empName { get; set; }

        public long? lastFuelMaile { get; set; }

        public long? lastFuelDate { get; set; }

        public long? purchaseDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string? statusText { get; set; }
    }
}
