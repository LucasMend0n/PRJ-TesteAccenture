using CrudCompanies.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCompanies.Map
{
    public class CompanyMap : BaseMap<Company>
    {
        public CompanyMap() : base("tb_company")
        {
        }

        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.BusinessName).HasColumnName("business_name").HasColumnType("varchar(100)").IsRequired(); 
            builder.Property(x => x.TaxId).HasColumnName("cnpj").HasColumnType("varchar(15)").IsRequired(); 
            builder.Property(x => x.Cep).HasColumnName("cep").HasColumnType("varchar(10)").IsRequired(); 
        }
    }
}