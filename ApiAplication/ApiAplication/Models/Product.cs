using ApiAplication.Dtos.ProductDtos;

namespace ApiAplication.Models
{
    public class Product:BaseEntity
    {
   
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsStock{ get; set; }
    }
}
