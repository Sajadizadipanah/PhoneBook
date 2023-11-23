﻿using Microsoft.EntityFrameworkCore;
using System.IO;
using System;

namespace Persistence;

public class DatabaseContext : DbContext

{

#pragma warning disable CS8618
	public DatabaseContext() : base()
#pragma warning restore CS8618

	{
		Database.EnsureCreated();
	}

	public DbSet<Domain.Contact> Contacts { get; set; }

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)

	{
        var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.db");
        var sqliteConnectionString = $"Data Source={dbPath};";
        var connectionString =

         "Server=.;Database=PhoneBook ;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly
            (assembly: typeof(Configurations.ContactConfiguration).Assembly);
    }
}
