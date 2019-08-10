using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Books_Recommendation_System.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string PreferCatg { get; set; }
        public string BookLength { get; set; }
        public string Language { get; set; }

    }
}