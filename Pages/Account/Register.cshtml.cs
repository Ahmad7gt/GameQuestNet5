using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public RegisterModel(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostRegisterAccount(string email, string password, string confirmPassword, bool rememberMe)
        {
            if (password.Equals(confirmPassword))
            {
                User newUser = new User() { UserName = email, Email = email };

                var result = await _userManager.CreateAsync(newUser, password);

                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(newUser, password, rememberMe, false);

                    ViewData["message"] = "Your account was created!";

                }
                else
                {
                    ViewData["message"] = "Something happened, your account was not created";

                }

            }
            else
            {

                ViewData["message"] = "Your password does not match!";
            
            }

            return Page();

        }
    }
}
