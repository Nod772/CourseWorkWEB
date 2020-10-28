using DB.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DB
{
    public class EFContext : IdentityDbContext<User>
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }

      
        public DbSet<UserAdditionalInfo> UserAdditionalInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(u => u.UserAdditionalInfo)
                .WithOne(t => t.User)
                .HasForeignKey<UserAdditionalInfo>(r => r.Id);

            base.OnModelCreating(builder);
        }

    }
}
