﻿using Microsoft.AspNetCore.Server.IIS.Core;

namespace Ice_Hot_Tea.Data.Entitty.Shop
{
    public class CategoryByAuthor : Categories
    {
        public String image { get; set; }
        public CategoryByAuthor(String id, String name, String description, String image, DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.image = image;
            this.createdAt = createdAt;
        }
    }
}
