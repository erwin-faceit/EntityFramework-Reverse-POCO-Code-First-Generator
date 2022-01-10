// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V6Fred
{
    // Burak2
    public class Burak2
    {
        public long Id { get; set; } // id (Primary key)
        public long Num { get; set; } // num

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Burak2 pointed by [Burak1].([id], [num]) (FK_Burak_Test2)
        /// </summary>
        public virtual Burak1 Burak1_Id { get; set; } // Burak1.FK_Burak_Test2

        /// <summary>
        /// Parent (One-to-One) Burak2 pointed by [Burak1].([id_t], [num]) (FK_Burak_Test1)
        /// </summary>
        public virtual Burak1 Burak1_IdT { get; set; } // Burak1.FK_Burak_Test1
    }

}
// </auto-generated>