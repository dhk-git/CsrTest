// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Csr.Models;

namespace Csr.Areas.Account.Pages.CsrLogin
{
    public class LoginModel : PageModel
    {
        Csr.Data.CsrDbContext _csrDbContext;
        public LoginModel(Data.CsrDbContext csrDbContext)
        {
            _csrDbContext = csrDbContext;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        //public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            //[Required]
            //[EmailAddress]
            //public string Email { get; set; }
            [Required]
            public string UserID { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public MD_USER LoginUser { get; set; }

        public async Task OnGet(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }
            await HttpContext.SignOutAsync(Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme);
            returnUrl ??= Url.Content("~/");
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            

            if (ModelState.IsValid)
            {
                var chkRst = true;
                LoginUser = _csrDbContext.MD_USER.Where(a => a.USER_ID == Input.UserID).FirstOrDefault();
                chkRst = LoginUser != null ? true : false;
                
                if (chkRst)
                {
                    var claims = new List<Claim> {
                        //new Claim(ClaimTypes.Sid, Input.Email),
                        new Claim(ClaimTypes.Name, Input.UserID),
                        new Claim(ClaimTypes.Role, "User"),
                        new Claim("USER_NM", LoginUser.USER_NM),
                    };


                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        new AuthenticationProperties()
                        {
                            IsPersistent = Input.RememberMe,
                            ExpiresUtc = Input.RememberMe ? DateTime.UtcNow.AddDays(7) : DateTime.UtcNow.AddMinutes(30)
                        });
                    return LocalRedirect(returnUrl);
                    }
                else
                {
                    return Page();
                }
            }
            return Page();
        }
    }
}
