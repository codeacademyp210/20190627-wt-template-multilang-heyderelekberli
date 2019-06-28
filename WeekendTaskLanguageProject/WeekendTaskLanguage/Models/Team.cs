using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekendTaskLanguage.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Text { get; set; }
    }
}