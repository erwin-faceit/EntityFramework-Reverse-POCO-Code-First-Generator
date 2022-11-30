// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V7EfrpgTest
{
    // UserRoles
    public class Issue47_UserRole
    {
        public int UserRoleId { get; set; } // UserRoleId (Primary key)
        public int UserId { get; set; } // UserId
        public int RoleId { get; set; } // RoleId

        // Foreign keys

        /// <summary>
        /// Parent Issue47_Role pointed by [UserRoles].([RoleId]) (Issue47_UserRoles_roleid)
        /// </summary>
        public virtual Issue47_Role Issue47_Role { get; set; } // Issue47_UserRoles_roleid

        /// <summary>
        /// Parent Issue47_User pointed by [UserRoles].([UserId]) (Issue47_UserRoles_userid)
        /// </summary>
        public virtual Issue47_User Issue47_User { get; set; } // Issue47_UserRoles_userid
    }

}
// </auto-generated>
