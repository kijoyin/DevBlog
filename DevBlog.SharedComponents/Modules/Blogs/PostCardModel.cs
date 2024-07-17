using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBlog.SharedComponents.Modules.Blogs
{
    public class PostCardModel(string title,string? subtitle,string summary,string slug)
    {
        
        public string Title { get; set; } = title;
        public string? SubTitle { get; set; } = subtitle;
        public string Summary { get; set; } = summary;
        public string Slug { get; set; } = slug;
    }
}
