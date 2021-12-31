﻿using Microsoft.EntityFrameworkCore;
using SelfieAwokie.Domain;
using SelfieAwookie.Infrastructure.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwookie.Infrastructure.Data
{
    public class SelfieContext : DbContext
    {
        public SelfieContext(DbContextOptions<SelfieContext> options) : base(options) { }

        public DbSet<Selfie> Selfies { get; set; }
        public DbSet<Wookie> Wookies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
        }
    }
}
