using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Models
{
    public class ArticleTags
    {
        public int ArticleID { get; set; }
        public Article Article { get; set; }
        public int TagID { get; set; }
        public Tag Tag { get; set; }
    }
}
