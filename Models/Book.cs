using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_Recommendation_System.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishYear { get; set; }
        public string Categories { get; set; }
        public string BookLength { get; set; }
        public string Language { get; set; }
        public string Author { get; set; }
    }
}