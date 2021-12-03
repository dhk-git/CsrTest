// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace Csr.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        //private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly ILogger<LoginModel> _logger;

        //public LoginModel(SignInManager<IdentityUser> signInManager, ILogger<LoginModel> logger)
        //{
        //    _signInManager = signInManager;
        //    _logger = logger;
        //}

        public LoginModel()
        {

        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            //await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            //await HttpContext.SignOutAsync();
            await Task.Delay(1);

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                //IdentityUser identityUser = new IdentityUser() { Id = "test", UserName = "Test" };
                //await _signInManager.SignInAsync(identityUser, true);
                //var claims = BuildClaims(data, loginViewModel.LoginPW, device_data, loginViewModel.LangCode);
                var claims = new List<Claim> {
                new Claim(ClaimTypes.Sid, Input.Email),
                new Claim(ClaimTypes.Name, Input.Email),
                new Claim(ClaimTypes.Role, "User")};
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), new AuthenticationProperties { IsPersistent = true });

                return LocalRedirect(returnUrl);

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                //var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);

                //if (result.Succeeded)
                //{
                //    _logger.LogInformation("User logged in.");
                //    return LocalRedirect(returnUrl);
                //}
                //if (result.RequiresTwoFactor)
                //{
                //    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                //}
                //if (result.IsLockedOut)
                //{
                //    _logger.LogWarning("User account locked out.");
                //    return RedirectToPage("./Lockout");
                //}
                //else
                //{
                //    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                //    return Page();
                //}
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
        //private IList<Claim> BuildClaims(UserInfoModel user, string secret_cd, List<DeviceInfoModel> Device, string langCode)
        //{
        //    var claims = new List<Claim> {
        //        new Claim(ClaimTypes.Sid, $"{user.USER_ID}"),
        //        new Claim(ClaimTypes.Name, user.USER_ID),
        //        new Claim("SECRET_CD",secret_cd),
        //        new Claim("USER_NM", user.USER_NM),
        //        new Claim("LANG_CD", langCode),
        //        new Claim(ClaimTypes.Role, "User"),
        //        new Claim("MQTT_TOPIC",System.String.IsNullOrEmpty(user.RECEIVE_MQTT_TOPIC) ? string.Empty : user.RECEIVE_MQTT_TOPIC), //20201028 topic관련 메세지 받을수 있도록 추가. 구분자 "/"
        //        new Claim("MENU_LIST",user.MENU_LIST), //메뉴 권한 ^#^ 구분자. _Layout 에서 잘라서 show 해줄것임.


        //        new Claim("COMP_CD", user.COMP_CD),
        //        new Claim("COMP_NM", user.COMP_NM),
        //        new Claim("DEPT_CD", user.DEPT_CD),
        //        new Claim("DEPT_NM", user.DEPT_NM)
        //    };
        //    //Device정보 동적 바인딩.(unpivot으로 받아옴.)
        //    foreach (DeviceInfoModel Device_Data in Device)
        //    {
        //        claims.Add(new Claim(Device_Data.TYPE_NM, Device_Data.TYPE_CD));
        //    }
        //    return claims;
        //}


    }
}
