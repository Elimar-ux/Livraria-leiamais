using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEIAMAIS.Infra.Data.context
{
    public class LEIAMAISContext : DbContext
    {
        public LEIAMAISContext(DbContextOptions<LEIAMAISContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LEIAMAISContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new DebugLoggerProvider());
            optionsBuilder.UseLoggerFactory(loggerFactory);
        
        }
    }
}
