using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Dtos.RoomDto
{
    public class RoomAddDto
    {
     
        public string Title { get; set; }

        [Required(ErrorMessage ="Lütfen Oda Numarası Giriniz..")]
        public string RoomNumber { get; set; }
        public string CoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Fiyat Giriniz..")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Yatak Sayısı  Giriniz..")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Banyo Sayısı Giriniz..")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        public string Description { get; set; }
    }
}
