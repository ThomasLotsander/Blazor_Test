﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataAccessLayer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Joke> Jokes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Joke>().ToTable("Jokes");
        }
    }
}
