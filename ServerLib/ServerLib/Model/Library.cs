using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib.Model
{
    [Table("Library")]
    public class Library
    {
        [PrimaryKey]
        public int id { get; set; }

        [MaxLength(60)]
        public string iro { get; set; }

        [MaxLength(80)]
        public string cim { get; set; }

        [MaxLength(20000)]
        public int oldalszam { get; set; }

        [MaxLength(10000)]
        public int darab { get; set; }

        [MaxLength(10000)]
        public int kolcsonzott { get; set; }
    }
}
