namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderIrregular")]
    public partial class OrderIrregular
    {
        [Key]
        public int orderIrregularTID { get; set; }

        public int orderCarID { get; set; }

        public int workContract { get; set; }=0;

        public int workQuotation { get; set; } = 0;

        public int workCarDetails { get; set; } = 0;

        public int workOther { get; set; } = 0;

        public int workCarRegInfo { get; set; } = 0;    

        public int miscSticker { get; set; } = 0;

        [StringLength(50)]
        public string? miscStickerMemo { get; set; }

        public int miscInsurance { get; set; } = 0;

        public int miscGuide { get; set; } = 0;

        public int miscGift { get; set; } = 0;

        [Column(TypeName = "text")]
        [Required]
        public string? miscGiftMemo { get; set; }
        [ForeignKey("orderCarID")]
        public virtual OrderCar? OrderCar { get; set; }

        public bool deleted { get; set; } = false;
    }
}
