using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ServerLib.Model
{
    [Table("Booking")]
    public class Booking
    {
        [PrimaryKey]
        public int id { get; set; }

        public int userId { get; set; }

        public int bookId { get; set; }

        [MaxLength(60)]
        public string iro { get; set; }

        [MaxLength(80)]
        public string cim { get; set; }

        [MaxLength(20000)]
        public int oldalszam { get; set; }

        public DateTime booking_date { get; set; } //altalunk be vitt info nem szukseges korlatozas

        public DateTime return_date { get; set; } //altalunk be vitt info nem szukseges korlatozas

        public int darab { get; set; } //altalunk be vitt info nem szukseges korlatozas


    }
}
