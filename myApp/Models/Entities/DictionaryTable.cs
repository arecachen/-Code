namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DictionaryTable")]
    public partial class DictionaryTable
    {
        [Key]
        public int dictionaryTableTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? dicCategory { get; set; }

        [Required]
        [StringLength(30)]
        public string? dicValue { get; set; }

        [Required]
        [StringLength(30)]
        public string? dicText { get; set; }

        public int dicOrder { get; set; }

        [Required]
        [StringLength(12)]
        public string? dicStatus { get; set; }

        public bool deleted { get; set; } = false;
    }
}
