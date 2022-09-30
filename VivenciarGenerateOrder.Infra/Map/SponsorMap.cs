using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using VivenciarGenerateOrder.Domain.Entities;
using VivenciarGenerateOrder.Domain.Enum;

namespace VivenciarGenerateOrder.Infra.Map
{
    public class SponsorMap : IEntityTypeConfiguration<Sponsor>
    {
        public void Configure(EntityTypeBuilder<Sponsor> builder)
        {
            builder.Property(x => x.Id).HasColumnName("SponsorId").ValueGeneratedNever().IsRequired();

            builder.Property(x => x.FullName).HasColumnType("VARCHAR(60)").IsRequired();

            builder.Property(x => x.Phone).HasColumnType("VARCHAR(11)");

            builder.OwnsOne(n => n.Address, cb =>
            {
                cb.Property(x => x.Street).HasColumnName("Street").HasColumnType("VARCHAR(100)");

                cb.Property(x => x.Number).HasColumnName("Number").HasColumnType("VARCHAR(20)");

                cb.Property(x => x.MoreIfo).HasColumnName("MoreIfo").HasColumnType("VARCHAR(50)");

                cb.Property(x => x.ZipCode).HasColumnName("ZipCode").HasColumnType("VARCHAR(9)");

                cb.Property(x => x.City).HasColumnName("City").HasColumnType("VARCHAR(50)");

                cb.Property(x => x.State).HasConversion(
                    v => Convert.ToInt32(v),
                    v => (BrazilianStates)Enum.Parse(typeof(BrazilianStates), v.ToString()));
            });

            builder.Property(x => x.NationalRegister).HasColumnType("VARCHAR(18)").IsRequired();
            
            builder.Property(x => x.CreatedAt).IsRequired();

            builder.Property(x => x.LastUpdate).IsRequired();
        }
    }
}
