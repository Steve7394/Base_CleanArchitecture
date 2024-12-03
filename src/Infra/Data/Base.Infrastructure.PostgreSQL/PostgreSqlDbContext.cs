using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Infrastructure.SqlContext;
using Microsoft.EntityFrameworkCore;

namespace Base.Infrastructure.PostgreSQL;

public class PostgreSqlDbContext : BaseDbContext
{
    public PostgreSqlDbContext(DbContextOptions options) : base(options)
    {
    }
}