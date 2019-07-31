using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Models
{
    public class Tag
    { 
        public int ID { get; set; }
        public string TagName{ get; set; }
        public IEnumerable<ArticleTags> Articles { get; set; }
    }
}
