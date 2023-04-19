namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_AccessControlList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int accessControlTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string? ctPageName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string? ctlPageID { get; set; }

        [Column(TypeName = "text")]
        public string? ctlMemo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int accessControlGroupTID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int menuGroupID { get; set; }
    }
}
