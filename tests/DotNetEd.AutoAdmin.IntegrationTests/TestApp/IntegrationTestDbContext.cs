﻿using DotNetEd.CoreAdmin.IntegrationTests.TestApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEd.CoreAdmin.IntegrationTests.TestApp
{
    public class IntegrationTestDbContext : DbContext
    {
        public DbSet<TestEntity> TestEntities { get; set; }

        public IntegrationTestDbContext(DbContextOptions<IntegrationTestDbContext> contextOptions) : base(contextOptions)
        {

        }
    }
}
