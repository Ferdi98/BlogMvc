using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string ArticleTitle { get; set; }
        public DateTime ArticleDate { get; set; }
        public string ArticleContent { get; set; }
        public IEnumerable<ArticleTags> ArticleTags { get; set; }
    }
}
