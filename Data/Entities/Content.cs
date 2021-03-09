using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Data
{
    public class Content        :BaseEntity
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string ImageUrl { get; set; }

        public bool IsInMenu { get; set; }
        public bool IsPublished { get; set; }


        public Content(string title, string body, string imgUrl = "")
        {
            Title = title;
            Body = body;
            IsInMenu = false;
            IsPublished = false;
            ImageUrl = imgUrl;

        }

        public Content()
        {

        }
      
    }
}
