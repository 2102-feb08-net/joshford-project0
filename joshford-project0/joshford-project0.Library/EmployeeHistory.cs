using System;
using System.Collections.Generic;

#nullable disable

namespace joshford_project0.Library
{
    public partial class EmployeeHistory
    {
        public int SaleId { get; set; }
        public int EmployeeId { get; set; }
        public int OrderId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Order Order { get; set; }
    }
}
