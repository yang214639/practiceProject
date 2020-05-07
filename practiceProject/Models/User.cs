using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practiceProject.Models
{
    public class User
    {
        [Required]
        [DisplayName("使用者名稱")]
        
        public string userName { get; set; }
        [DisplayName("密碼")]
        [Required]
        public string password { get; set; }

        [DisplayName("性別")]
        [Required]
        public string gender { get; set; }

        [DisplayName("出生日期")]
        [DataType(DataType.Date)]
        [Required]
        public string birth_Day { get; set; }

        [DisplayName("出生時辰")]
        [Required]
        public string birth_Time { get; set; }

        [DisplayName("電子信箱")]
        [Required]
        public string email { get; set; }
    }
}