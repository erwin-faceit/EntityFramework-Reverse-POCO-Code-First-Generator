// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V7EfrpgTest
{
    // SmallDecimalTest
    public class SmallDecimalTest
    {
        public int Id { get; set; } // id (Primary key)
        public decimal? KoeffVed { get; set; } // KoeffVed

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) SmallDecimalTest pointed by [SmallDecimalTestAttribute].[FkID] (KateFK)
        /// </summary>
        public virtual FkTest_SmallDecimalTestAttribute FkTest_SmallDecimalTestAttribute { get; set; } // SmallDecimalTestAttribute.KateFK

        public SmallDecimalTest()
        {
            KoeffVed = 0.5m;
        }
    }

}
// </auto-generated>
