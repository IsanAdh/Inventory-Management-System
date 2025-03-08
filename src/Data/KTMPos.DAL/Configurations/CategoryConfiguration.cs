using KTMPos.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.DAL.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Id).HasColumnOrder(0);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnOrder(1);
            builder.Property(x => x.CreatedBy).HasColumnOrder(2);
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("GETDATE()").HasColumnOrder(3);
            builder.Property(x => x.LastModifiedBy).HasColumnOrder(4);
            builder.Property(x => x.LastModifiedDate).HasColumnOrder(5);

            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasOne(x => x.CreatedUser).WithMany(x => x.CreatedCategories).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ModifiedUser).WithMany(x => x.ModifiedCategories).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
