﻿namespace ApiAplication.Dtos.ProductDtos
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsStock { get; set; }
    }
}
