using DocumentFormat.OpenXml.Wordprocessing;
using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace hsintongERP2022.Models {
    public partial class CarMileage {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        public string? IPNO { get; set; }//             "IPNO": "018070200002",
        public string? SubCompName { get; set; }  //": "新通交通有限公司　 ",
        public string? DriverNo { get; set; } //": "劉繡郎",
        public string? carno { get; set; } //": "KAH-727",
        public long? Gpstime_Start { get; set; } //": "20230201 05:43:12",
        public long? Gpstime_End { get; set; } //": "20230201 20:58:19",        
        public decimal? Carlost_Hour { get; set; } //": "9.08",
        public decimal? Carstay_Hour { get; set; } //": "2.73",
        public decimal? MaxCarStay_Hour { get; set; } //": "0.67",
        public decimal? TotalMileage { get; set; } //": "68.91",
        public decimal? Tollstation_Count { get; set; } //": "0",
        public long? CreateDate { get; set; } //": "20230201",
        public decimal? AvgTempValue { get; set; } //": "",
        public string? Driver { get; set; } //": "",
        public decimal? TOTALMILEAGE_2G { get; set; } //": "68.91",
        public int? TripCount { get; set; } //": "0",
        public int? TempCheck { get; set; } //": "",
        public int? CARCOST { get; set; } //": "0",
        public int? EMPLOYEE_COST { get; set; } //": "0",
        public int? OTHER_COST { get; set; } //": "0",
        public int? CAR_SPENTOIL { get; set; } //": "0",
        public int? OILCOST { get; set; } //": "27",
        public bool? IsUseCPCPrice { get; set; } //": "True",
        public decimal? TotalCost { get; set; } //": "0.00000",
        public decimal? DriveHour { get; set; } //": "0.0000",
        public decimal? FireHour { get; set; } //": "0.0000",
        public decimal? Drive_spentoil { get; set; } //": "0.0000",
        public decimal? CarSpentoil { get; set; } //": "0.0000",
        public decimal? totalhour { get; set; } //": "15.25",
        public decimal? Day_Total { get; set; } //": "0",
        public decimal? CPCListPrice { get; set; } //": "28.2"
        public decimal? AccMiles { get; set; }
        public bool isAdjust { get; set; }=false;
        [NotMapped]
        public string? sCreateDate
        {
            get { return CreateDate.LongToDateString(); }
            set { CreateDate = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sGpstime_Start
        {
            get { return Gpstime_Start.LongToDateTimeString(); }
            set { Gpstime_Start = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sGpstime_End
        {
            get { return Gpstime_End.LongToDateTimeString(); }
            set { Gpstime_End = value.ToDateLong(); }
        }
      
    }
}