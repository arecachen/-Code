using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    [Table("dbo.View_CarWithEquipment")]
    public partial class ViewCarWithEquipment
    {
        [Key]      
        public string? carID { get; set; }
        public string? equipName { get; set; }
        public string? itemTitle { get; set; }
        public string? empName { get; set; }
        public string? categoryTitle { get; set; }
        public string? label { get; set; }
        public string? supplier { get; set; }
        public string? specification { get; set; }
        public Nullable<int> amount { get; set; }
        public string? memo { get; set; }
        public Nullable<int> CarItemsId { get; set; }
    }
   
}