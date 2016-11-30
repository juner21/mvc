namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_USER
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string ACCOUNT { get; set; }

        [StringLength(1000)]
        public string PASSWORD { get; set; }

        public int? ISCANLOGIN { get; set; }

        public int? SHOWORDER1 { get; set; }

        public int? SHOWORDER2 { get; set; }

        [StringLength(50)]
        public string PINYIN1 { get; set; }

        [StringLength(50)]
        public string PINYIN2 { get; set; }

        [StringLength(200)]
        public string FACE_IMG { get; set; }

        [StringLength(36)]
        public string LEVELS { get; set; }

        [StringLength(36)]
        public string DPTID { get; set; }

        [StringLength(36)]
        public string CREATEPER { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(36)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [StringLength(50)]
        public string LastLoginIP { get; set; }
    }
}
