using System.ComponentModel.DataAnnotations;

namespace HotelProject.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığı  giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string Icon { get; set; }

        public string Description { get; set; }
    }
}
