﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Pencil 1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Pencil 2",
                Price = 200,
                Stock = 30,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Pencil 3",
                Price = 500,
                Stock = 60,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Book 1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Book 2",
                Price = 400,
                Stock = 320,
                CreatedDate = DateTime.Now
            });
        }
    }
}
