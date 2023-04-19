namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_OrderCarMiscList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderTID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderCarInfoTID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderIrregularTID { get; set; }

        [StringLength(100)]
        public string? rentArriveLocation { get; set; }

        public long? rentStartDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int miscSticker { get; set; }

        [StringLength(50)]
        public string? miscStickerMemo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int miscInsurance { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int miscGuide { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int miscGift { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "text")]
        public string? miscGiftMemo { get; set; }

        [StringLength(50)]
        public string? withCarContactName { get; set; }

        [StringLength(50)]
        public string? withCarContactPhone { get; set; }

        [StringLength(50)]
        public string? withCarContactMobile { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string? custContactName { get; set; }

        [StringLength(50)]
        public string? custContactPhone { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string? custContactMobile { get; set; }

        [StringLength(50)]
        public string? custContactFax { get; set; }

        [StringLength(256)]
        public string? companyName { get; set; }

        [StringLength(50)]
        public string? mainPhone { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int custContactID { get; set; }
    }
}
