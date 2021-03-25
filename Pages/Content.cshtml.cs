using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GameQuest.Data;
using GameQuest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages
{
    public class ContentModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public static IServiceProvider serviceProvider { get; }

        private Context _context;

        public ContentPageModel _contentModel;

        public ContentModel(Context context)
        {
            _context = context;
            _contentModel = new ContentPageModel();
        }

        public void OnGet(string pageName)
        {

            if (pageName is not null)
            {
                // Get the current content named in "page string" from database using the title as a find atribute.
                Content content = _context.Contents.Where(page => page.Title.Equals(pageName)).FirstOrDefault();

                if (content is not null)
                {
                    if (content.IsPublished)
                    {
                        ViewData["Title"] = content.Title;
                        _contentModel.Title = content.Title;
                        _contentModel.Body = content.Body;
                        _contentModel.ImageUrl = content.ImageUrl;
                    }
                    else
                    {
                        _contentModel.Title = "Sorry, this page has not been published";
                    }
                }
                else
                {
                    _contentModel.Title = "Sorry, this page does not exist (404)";
                }

            }
            else
            {
                _contentModel.Title = "Sorry, you have no query";
            }

        }
    }
}
