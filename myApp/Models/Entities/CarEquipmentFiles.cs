using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    //裝備單品
    //public class CarEquipments
    //{
    //    [Key]
    //    public int id { get; set; }
    //    [Display(Name = "用途分類")]
    //    public int CarItemCategoryId { get; set; }
    //    [ForeignKey("CarItemCategoryId")]
    //    public virtual CarItemCategory CarItemCategory { get; set; }
    //    [Display(Name = "設備統稱")]
    //    public int CarItemsId { get; set; }
    //    [ForeignKey("CarItemsId")]
    //    public virtual CarItemsMain CarItemsMain { get; set; }
    //    [StringLength(256), Display(Name = "單品名稱")]
    //    public string? name { get; set; }
    //    [StringLength(256), Display(Name = "廠牌")]
    //    public string? label { get; set; }
    //    [StringLength(256), Display(Name = "供應商")]
    //    public string? supplier { get; set; }
    //    [Column(TypeName = "varchar(MAX)"), Display(Name = "規格")]
    //    public string? specification { get; set; }
    //    [StringLength(256), Display(Name = "說明檔案")]
    //    public string? illustrateImgSrc { get; set; }
    //    public virtual ICollection<CarEquipmentFiles> EquipmentFiles { get; set; }
    //    [StringLength(15), Display(Name = "狀態")]
    //    public string? status { get; set; } = "Active";
    //    public bool deleted { get; set; } = false;

    //}
    //裝備單品-圖檔
    public class CarEquipmentFiles
    {
        [Key]
        public int id { get; set; }        
        public int EquipmentId { get; set; }       
        [StringLength(256), Display(Name = "圖檔")]
        public string? EquipmentSrc { get; set; }
    }
}