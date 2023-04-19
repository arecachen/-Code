namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAddress")]
    public partial class CustomerAddress
    {
        [Key]
        public int customerAddressTID { get; set; }

        public int? custID { get; set; }

        [Required]
        [StringLength(50)]
        public string? custCity { get; set; }

        [Required]
        [StringLength(50)]
        public string? custSuburb { get; set; }

        [Required]
        [StringLength(30)]
        public string? custPostCode { get; set; }

        [Required]
        [StringLength(100)]
        public string? custStreet { get; set; }

        [Required]
        [StringLength(20)]
        public string? custAddType { get; set; }

        public virtual Customer? Customer { get; set; }
        [NotMapped]
        public string? cityCode  { get; set; }
        [NotMapped]
        public int distid { get; set; }

        public int? customerContactTID { get; set; }
        [ForeignKey("customerContactTID")]
        public CustomerContact? customerContact { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? fullAddress { get { return this.custCity + this.custPostCode + this.custSuburb + this.custStreet; } }
    }
}
