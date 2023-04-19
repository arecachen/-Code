using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using hsintongERP2022.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hsintongERP2022.Models
{
    //[NotMapped]
    public partial class ApplicationRole : IdentityRole
    {
        [Display(Name = "備註")]
        public string? memo { get; set; }
    }
    // 您可以將更多屬性新增至 User 類別，藉此新增使用者的 User 資料，若要深入了解，請前往 https://go.microsoft.com/fwlink/?LinkID=317594。
    
    public partial class ApplicationUser : IdentityUser
    {
        [Display(Name = "啟用")]
        public bool IsActive { get; set; }
        [Display(Name = "帳戶ID"), StringLength(64), MinLength(5, ErrorMessage = "長度不可小於 5"), MaxLength(64, ErrorMessage = "長度不可超過 64")]
        public string? UserId { get; set; }
        [Display(Name = "使用者姓名"), StringLength(64), MaxLength(64, ErrorMessage = "長度不可超過 64")]
        public string? Name { get; set; }
        public bool IsSysAdmin { get; set; }
        public int? EmployeeMain_employeeTID { get; set; }
        //[NotMapped]
        //public  object Discriminator { get; set; }
        public ClaimsIdentity GenerateUserIdentity(ApplicationUserManager manager)
        {
            // 注意 authenticationType 必須符合 CookieAuthenticationOptions.AuthenticationType 中定義的項目
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // 在這裡新增自訂使用者宣告
            return userIdentity;
        }

        public async  Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            //return Task.FromResult(GenerateUserIdentity(manager));
            // 注意 authenticationType 必須符合 CookieAuthenticationOptions.AuthenticationType 中定義的項目
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // 在這裡新增自訂使用者宣告
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            //**     : base("Model_legacy", throwIfV1Schema: false)
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}

#region Helper
namespace hsintongERP2022
{
    public static class IdentityHelper
    {
        // 連線外部登入時使用 XSRF
        public const string? XsrfKey = "XsrfId";

        public const string? ProviderNameKey = "providerName";
        public static string? GetProviderNameFromRequest(HttpRequest request)
        {
            return request.QueryString[ProviderNameKey];
        }

        public const string? CodeKey = "code";
        public static string? GetCodeFromRequest(HttpRequest request)
        {
            return request.QueryString[CodeKey];
        }

        public const string? UserIdKey = "userId";
        public static string? GetUserIdFromRequest(HttpRequest request)
        {
            return HttpUtility.UrlDecode(request.QueryString[UserIdKey]);
        }

        public static string? GetResetPasswordRedirectUrl(string? code, HttpRequest request)
        {
            var absoluteUri = "/Account/ResetPassword?" + CodeKey + "=" + HttpUtility.UrlEncode(code);
            return new Uri(request.Url, absoluteUri).AbsoluteUri.ToString();
        }

        public static string? GetUserConfirmationRedirectUrl(string? code, string? userId, HttpRequest request)
        {
            var absoluteUri = "/Account/Confirm?" + CodeKey + "=" + HttpUtility.UrlEncode(code) + "&" + UserIdKey + "=" + HttpUtility.UrlEncode(userId);
            return new Uri(request.Url, absoluteUri).AbsoluteUri.ToString();
        }

        private static bool IsLocalUrl(string? url)
        {
            return !string.IsNullOrEmpty(url) && ((url[0] == '/' && (url.Length == 1 || (url[1] != '/' && url[1] != '\\'))) || (url.Length > 1 && url[0] == '~' && url[1] == '/'));
        }

        public static void RedirectToReturnUrl(string? returnUrl, HttpResponse response)
        {
            if (!String.IsNullOrEmpty(returnUrl) && IsLocalUrl(returnUrl))
            {
                response.Redirect(returnUrl);
            }
            else
            {
                response.Redirect("~/");
            }
        }
    }
}
#endregion
