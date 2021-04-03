using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages.Account
{
    public class LoginModel : PageModel
    {
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;
        public LoginModel(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        public void OnGet(string value)
        {
            if(!string.IsNullOrWhiteSpace(value))
            { 
                if (value.Equals("accessdenied"))
                { 
                ViewData["message"] = "You do not have access to that page, please sign in with the right acocunt.";
                }
            }

        }


        public async Task<IActionResult> OnPostLogin(string user, string password)
        {

            User usr = user.Contains("@") ? await _userManager.FindByEmailAsync(user) : await _userManager.FindByNameAsync(user);

            if (usr is not null)
            {

                var result = await _signInManager.PasswordSignInAsync(usr.Email, password, false, false);

                if (result.Succeeded)
                {
                    return LocalRedirect("/");
                }
                else
                {
                    ViewData["message"] = "Check your password";
                }

            }
            else
            {
                ViewData["message"] = "User does not exist";
            }


            return Page();
        }
    }
}
