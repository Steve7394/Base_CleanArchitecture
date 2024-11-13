﻿namespace Base.Samples.Infrastructure.Common;

using Base.Infrastructure;

public class SampleDbContext : BaseDbContext
{
    public DbSet<Person> People { get; set; }
    public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}