﻿using AspNetCoreIdentityApp.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz")]
        [Display(Name = "Kullanıcı Adı : ")]
        public string UserName { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Email format yanlış")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz")]
        [Display(Name = "Email : ")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz")]
        [Display(Name = "Telefon : ")]
        public string Phone { get; set; } = null!;

        [DataType(DataType.Date)]
        [Display(Name = "Doğum tarihi : ")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Şehir : ")]
        public string? City { get; set; }

        [Display(Name = "Profil Resmi : ")]
        public IFormFile? Picture { get; set; }

        [Display(Name = "Cinsiyet : ")]
        public GenderEnum? Gender { get; set; }

    }
}
