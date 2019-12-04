﻿using Microsoft.EntityFrameworkCore;
using SampleApp.Data;

namespace SampleApp.Persistence
{
    public class SampleAppDbContext : DbContext
    {
        #region Ctor

        public SampleAppDbContext(DbContextOptions<SampleAppDbContext> options) 
            : base(options)
        {}

        #endregion

        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

       
    }
}