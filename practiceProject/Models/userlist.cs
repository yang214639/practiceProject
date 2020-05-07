namespace practiceProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testdb.userlist")]
    public partial class userlist
    {
        [Key]
        public int user_id { get; set; }

        [StringLength(10)]
        public string user_Name { get; set; }

        [StringLength(10)]
        public string user_Password { get; set; }

        [StringLength(5)]
        public string gender { get; set; }

        public DateTime? birth_Day { get; set; }

        [StringLength(10)]
        public string birth_Time { get; set; }

        [StringLength(20)]
        public string email { get; set; }
    }
}
