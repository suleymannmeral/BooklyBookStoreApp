using BooklyBookStoreApp.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Persistence.Configuration
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x=>x.Adress)
                .HasMaxLength(400);
            builder.Property(x => x.City)
               .HasMaxLength(50);
            builder.Property(x => x.District)
               .HasMaxLength(50);

            builder.HasMany(u=>u.Orders)
                .WithOne(o=>o.AppUser)
                .HasForeignKey(o=>o.AppUserID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Favorites)
              .WithOne(f => f.AppUser)
              .HasForeignKey(f => f.AppUserID)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u=>u.BookComments)
                .WithOne(bc=>bc.AppUser)
                .HasForeignKey(bc=>bc.AppUserID)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
