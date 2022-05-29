using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ServerLib.Model
{
    [Table("Users")]
    public class Users
    {
        [PrimaryKey]
        public int userId { get; set; }

        [MaxLength(60)]
        public string vezeteknev { get; set; }

        [MaxLength(60)]
        public string keresztnev { get; set; }

        public DateTime szuldatum { get; set; }

        public List<Booking> data;

        public Users()
        {
            data = new List<Booking>();
        }

        public void loadData(SQLiteConnection db)
        {
            if (data.Count == 0)
                data = db.Query<Booking>("SELECT * FROM Booking WHERE userId=?", new object[] { userId });
        }
    }
}
