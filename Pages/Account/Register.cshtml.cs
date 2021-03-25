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
        private readonly Context _context;

        public RegisterModel(UserManager<User> userManager, SignInManager<User> signInManager, Context context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public void OnGet()

        {
        }

        public async Task<IActionResult> OnPostRegisterAccount(string email, string password, string confirmPassword, bool rememberMe)
        {

            User user = await _userManager.FindByEmailAsync(email);

            if (user is not null)
            {
                ViewData["message"] = "This email is already taken!";
            }
            else
            {
                if (password.Equals(confirmPassword))
                {
                    User newUser = new User() { UserName = email, Email = email };

                    var result = await _userManager.CreateAsync(newUser, password);

                    if (result.Succeeded)
                    {
                        if (_context.Users.Count() == 1)
                        {
                            await _userManager.AddToRoleAsync(newUser, "Admin");
                        }
                        else
                        {
                            await _userManager.AddToRoleAsync(newUser, "Customer");
                        }

                        await _signInManager.PasswordSignInAsync(newUser, password, rememberMe, false);

                        return LocalRedirect("/");

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
            }

            

            return Page();

        }
    }
}
