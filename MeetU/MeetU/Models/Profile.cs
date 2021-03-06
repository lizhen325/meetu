﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace MeetU.Models
{
    public class Profile
    {
        [JsonIgnore]
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Key]
        [Required]
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        [Required]
        [MaxLength(32)]
        public string NickName { get; set; }
        [MaxLength(32)]
        public string GivenName { get; set; }
        [MaxLength(32)]
        public string FamilyName { get; set; }
        public string Picture { get; set; }
        [MaxLength(32)]
        public string Gender { get; set; }
        [MaxLength(256)]
        public string Brief { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int LoginCount { get; set; }
    }
}