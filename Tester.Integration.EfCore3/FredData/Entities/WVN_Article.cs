// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // Articles
    public class WVN_Article
    {
        public int PkArticle { get; set; } // PK_Article (Primary key)
        public Guid FkFactory { get; set; } // FK_Factory
        public int FkArticleLevel { get; set; } // FK_ArticleLevel
        public int? FkParentArticle { get; set; } // FK_ParentArticle
        public string Code { get; set; } // Code (length: 20)
    }

}
// </auto-generated>
