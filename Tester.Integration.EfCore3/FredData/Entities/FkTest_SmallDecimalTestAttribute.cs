// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // SmallDecimalTestAttribute
    public class FkTest_SmallDecimalTestAttribute
    {
        public int FkId { get; set; } // FkID (Primary key)
        public string Description { get; set; } // description (length: 20)

        // Reverse navigation

        /// <summary>
        /// Child Alpha_Harish3485 where [Harish3485].[harish_id] point to this entity (FK_Harish)
        /// </summary>
        public virtual ICollection<Alpha_Harish3485> Alpha_Harish3485 { get; set; } // Harish3485.FK_Harish

        // Foreign keys

        /// <summary>
        /// Parent SmallDecimalTest pointed by [SmallDecimalTestAttribute].([FkId]) (KateFK)
        /// </summary>
        public virtual SmallDecimalTest SmallDecimalTest { get; set; } // KateFK

        public FkTest_SmallDecimalTestAttribute()
        {
            Alpha_Harish3485 = new List<Alpha_Harish3485>();
        }
    }

}
// </auto-generated>
