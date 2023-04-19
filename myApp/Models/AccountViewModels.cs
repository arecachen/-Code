﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace hsintongERP2022.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "電子郵件")]
        public string? Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string? ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string? SelectedProvider { get; set; }
        public ICollection<SelectListItem>? Providers { get; set; }
        public string? ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string? Provider { get; set; }

        [Required]
        [Display(Name = "代碼")]
        public string? Code { get; set; }
        public string? ReturnUrl { get; set; }

        [Display(Name = "記住此瀏覽器?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "電子郵件")]
        public string? Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "電子郵件")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string? Password { get; set; }

        [Display(Name = "記住我?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        public string? ID { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件")]
        public string? Mail { get; set; }

        //[Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string? Pw { get; set; }

       [DataType(DataType.Password)]
       [Display(Name = "確認密碼")]
       [Compare("Pw", ErrorMessage = "密碼和確認密碼不相符。")]
       public string? ConfirmPassword { get; set; }
       public string? PasswordResetToke { get; set; }
        [Display(Name = "群組")]
        public string? UserRoles { get; set; }
        [Display(Name = "啟用")]
        public bool IsActive { get; set; }
        [Display(Name = "帳戶ID"), StringLength(64), MinLength(5, ErrorMessage = "長度不可小於 5"), MaxLength(64, ErrorMessage = "長度不可超過 64")]
        public string? UserId { get; set; }
        [Display(Name = "使用者姓名"), StringLength(64),  MaxLength(64, ErrorMessage = "長度不可超過 64")]
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public bool IsSysAdmin { get; set; }
        
    }

    public class ResetPasswordViewModel
    {
        [Required]
        //[EmailAddress]
        [Display(Name = "帳號")]
        public string? userName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "原密碼")]
        public string? OrgPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string? ConfirmPassword { get; set; }

        public string? Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件")]
        public string? Email { get; set; }
    }
}
