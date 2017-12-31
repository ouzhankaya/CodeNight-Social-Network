﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNight.Entities
{
    [Table("Users")]
   public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(25), DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
        [Required, StringLength(25), DisplayName("Ad")]
        public string Name { get; set; }
        [Required, StringLength(25), DisplayName("Soyad")]
        public string Surname { get; set; }
        [Required, StringLength(25), DisplayName("Şifre")]
        public string Password { get; set; }
        [Required, StringLength(70), DisplayName("E-Mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public string ProfileImageFileName { get; set; }
        [DisplayName("Doğum Tarihi")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Yaş")]
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        [DisplayName("Aktif")]
        public bool IsActive { get; set; }

        [Required, ScaffoldColumn(false)]
        public Guid ActivateGuid { get; set; }
        [DisplayName("Telefon Numarası"), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public List<Share> Shares { get; set; }
        public List<Liked> Likes { get; set; }
        public List<Followers> Followers { get; set; }
        public List<FollowRequest> FollowRequests { get; set; }
        public List<Notifications> Notifications { get; set; }
    }
}
