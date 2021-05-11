using System.ComponentModel.DataAnnotations.Schema;

namespace MuhtarlikOtomasyonu.Data.DbModels
{
    public class Cadde:BaseEntity
    {
        public string CaddeAdi { get; set; }
        public int MahalleId { get; set; }
        [ForeignKey("MahalleId")]
        public Mahalle Mahalle { get; set; }
    }
}