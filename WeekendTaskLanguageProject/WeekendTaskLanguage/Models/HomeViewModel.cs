using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekendTaskLanguage.Models
{
    public class HomeViewModel
    {
        public List<Blog> Blog { get; set; }
        public List<Ability> Ability { get; set; }
        public List<AboutSpec> AboutSpec { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Portfolio> Portfolio { get; set; }
        public List<HomeImage> HomeImage { get; set; }
        public List<Position> Position { get; set; }
        public List<Post> Post { get; set; }
        public List<SecondBlog> SecondBlog { get; set; }
        public List<Service> Service { get; set; }
        public List<Speciality> Speciality { get; set; }
        public List<Team> Team { get; set; }
        public List<Testimonial> Testimonial { get; set; }
        public Setting Setting { get; set; }
        
    }
}