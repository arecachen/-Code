namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTimeSlot")]
    public partial class EmployeeTimeSlot
    {
        [Key]
        public int EmployeeTimeSlotTID { get; set; }

        public int EmployeeSalaryID { get; set; }

        public int EmployeeMainID { get; set; }

        public int OrderCarRegularClassID { get; set; }

        public int StartHourSlot { get; set; }

        public int StartMinuteSlot { get; set; }

        public int EndHourSlot { get; set; }

        public int EndMinuteSlot { get; set; }

        public bool deleted { get; set; } = false;
    }
}
