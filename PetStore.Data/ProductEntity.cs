﻿using System.ComponentModel.DataAnnotations;

namespace PetStore.Data;
public class ProductEntity
{
    [Key] public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
}

