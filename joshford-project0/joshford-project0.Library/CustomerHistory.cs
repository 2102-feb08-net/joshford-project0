using System;
using System.Collections.Generic;

#nullable disable

namespace joshford_project0.Library
{
    public partial class CustomerHistory
    {
        public int PurchaseId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
    }
}
