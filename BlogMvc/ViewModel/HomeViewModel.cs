using BlogMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Articles = new List<Article>();
            Categories = new List<Category>();
            Tags = new List<Tag>();
        }
        public List<Article> Articles { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags  { get; set; }
    }
}
