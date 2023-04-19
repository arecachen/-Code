namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarInfoPayRecord")]
    public partial class OrderCarInfoPayRecord
    {
        [Key]
        public int orderCarInfoPayRecordTID { get; set; }

        public int orderCarInfoID { get; set; }

        public long paymentReceiveDate { get; set; }

        public int? paymentAmount { get; set; }

        public int? paymentInFull { get; set; }

        [StringLength(12)]
        public string? payDriveType { get; set; }

        public long? payDriverDate { get; set; }

        public int? payDriverAmount { get; set; }

        public int? payInsurance { get; set; }

        public int? payInsuraceAmount { get; set; }

        public int? sentReceipt { get; set; }

        public long? sentReceiptDate { get; set; }

        [StringLength(256)]
        public string? sentReceiptNo { get; set; }

        [Column(TypeName = "text")]
        public string? multiSentReceiptMemo { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        public long? accountCheckDate { get; set; }

        public int accountCheck { get; set; }

        [Column(TypeName = "text")]
        public string? accountCheckMemo { get; set; }

        public virtual OrderCarInfo? OrderCarInfo { get; set; }

        public bool deleted { get; set; } = false;
    }
}
