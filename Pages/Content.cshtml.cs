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
        //public static IServiceProvider serviceProvider { get; }

        private EmailService _email;

        private Context _context;

        public ContentPageModel _contentModel;

        

        public bool showContactForm = false;
        public bool showEmailSentSuccess = false;

        public ContentModel(Context context, EmailService emailService)
        {
            _context = context;
            _contentModel = new ContentPageModel();
            _email = emailService;
        }
        
        public void OnGet(string pageName)
        {


            if (pageName.ToLower().Equals("Contact".ToLower()))
            {
                showContactForm = true;
            }
            else
            {
                showContactForm = false;
            }

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

        public void OnPostSendEmail(string email, string message)
        {

            SendEmailModel emailModel  = new SendEmailModel(email, message);


            try
            {
                bool didSend = _email.SendContactEmail(emailModel);

                if (didSend)
                {
                    showEmailSentSuccess = true;
                }

            }
            catch(Exception ex)
            {

                ViewData["message"] = $"Something went wrong: {ex}";

            }
            
        }
    }
}
