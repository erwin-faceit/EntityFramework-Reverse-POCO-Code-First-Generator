// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V7EfrpgTest
{
    // AB_OrderLinesAB_
    public class AbOrderLinesAb
    {
        public int Id { get; set; } // ID (Primary key)
        public int OrderId { get; set; } // OrderID
        public string Sku { get; set; } // sku (length: 15)

        // Foreign keys

        /// <summary>
        /// Parent AbOrdersAb pointed by [AB_OrderLinesAB_].([OrderId]) (AB_OrderLinesAB_FK)
        /// </summary>
        public virtual AbOrdersAb AbOrdersAb { get; set; } // AB_OrderLinesAB_FK
    }

}
// </auto-generated>
