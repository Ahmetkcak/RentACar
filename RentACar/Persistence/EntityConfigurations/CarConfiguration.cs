﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.ModelId).HasColumnName("ModelId").IsRequired();
        builder.Property(c => c.Kilometer).HasColumnName("Kilometer");
        builder.Property(c => c.CarState).HasColumnName("State");
        builder.Property(c => c.ModelYear).HasColumnName("ModelYear");
        builder.Property(c => c.Plate).HasColumnName("Plate").IsRequired();
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: c => c.Plate, name: "UK_Car_Name").IsUnique();

        builder.HasOne(c => c.Model);

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
    }
}