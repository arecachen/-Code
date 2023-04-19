namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_AccessCorporationList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loginTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corpID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string? loginID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string? loginPWD { get; set; }

        [StringLength(256)]
        public string? empEmail { get; set; }

        [StringLength(256)]
        public string? accGroup { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string? status { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string? corpName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(15)]
        public string? corpType { get; set; }

        [StringLength(50)]
        public string? corpPhone { get; set; }

        [StringLength(50)]
        public string? corpAddress { get; set; }

        [StringLength(50)]
        public string? corpContact { get; set; }

        [StringLength(50)]
        public string? corpMobile { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(25)]
        public string? corpStatus { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corpOrder { get; set; }
    }
}
