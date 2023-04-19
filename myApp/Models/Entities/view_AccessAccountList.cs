namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_AccessAccountList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loginTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string? loginID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string? loginPWD { get; set; }

        [StringLength(256)]
        public string? empEmail { get; set; }

        [StringLength(256)]
        public string? accGroup { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string? status { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int employeeTID { get; set; }

        [StringLength(15)]
        public string? empID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string? empNID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string? empName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long empDOB { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string? empMainContact { get; set; }
    }
}
