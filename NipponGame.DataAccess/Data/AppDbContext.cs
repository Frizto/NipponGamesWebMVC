﻿using Microsoft.EntityFrameworkCore;
using NipponGame.Models;

namespace NipponGame.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
