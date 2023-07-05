using CrudCompanies.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCompanies.Map
{
    public class SupplierMap : BaseMap<Supplier>
    {
        public SupplierMap() : base("tb_supplier")
        {
        }

        public override void Configure(EntityTypeBuilder<Supplier> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.TaxId).HasColumnName("cpf_cnpj").HasColumnType("varchar(15)").IsRequired();
            builder.Property(x => x.Cep).HasColumnName("cep").HasColumnType("varchar(8)").IsRequired();

        }
    }
}