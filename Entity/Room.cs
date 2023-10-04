using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Room:BaseModel
    {
        public string RoomNumber { get; set; }
        public string CoverImage { get; set; }
        public int Price { get; set; }

        public string BedCount { get; set; }

        public string BathCount { get; set; }

        public string Wifi { get; set; }

        public string Description { get; set; }
    }
}
